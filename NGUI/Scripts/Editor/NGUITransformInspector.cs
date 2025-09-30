
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Transform))]
public class NGUITransformInspector : Editor
{
	static public NGUITransformInspector instance;

	void OnEnable ()
	{
		instance = this;
	}

	void OnDestroy () { instance = null; }

	/// <summary>
	/// Draw the inspector widget.
	/// </summary>
	public override void OnInspectorGUI ()
	{
		EditorGUIUtility.LookLikeControls(15f);

		// Multi-object edit is limited in Unity 2.6; we still attempt to support basic apply across selection.
		Object[] targetsArray = Selection.transforms != null && Selection.transforms.Length > 0
			? (Object[])Selection.transforms
			: new Object[] { target };

		bool anyIsWidget = AnyIsWidget(targetsArray);

		DrawPosition(targetsArray);
		DrawRotation(targetsArray, anyIsWidget);
		DrawScale(targetsArray, anyIsWidget);
	}

	/// <summary>
	/// Checks whether any selected transform has a UIWidget component (by name, via reflection-free GetComponent(string)).
	/// Keeps compatibility even if UIWidget is not included in the project.
	/// </summary>
	bool AnyIsWidget (Object[] objs)
	{
		int i;
		for (i = 0; i < objs.Length; ++i)
		{
			Transform t = objs[i] as Transform;
			if (t != null && t.GetComponent("UIWidget") != null)
				return true;
		}
		return false;
	}

	void DrawPosition (Object[] objs)
{
	Transform t = target as Transform;
	Vector3 pos = (t != null) ? t.localPosition : Vector3.zero;

	bool changed = false;

	GUILayout.BeginHorizontal();
	{
		bool reset = GUILayout.Button("P", GUILayout.Width(20f));

		// Use FloatField triplet instead of Vector3Field for Unity 2.6
		GUILayoutOption opt = GUILayout.MinWidth(30f);
		float px = EditorGUILayout.FloatField("X", pos.x, opt);
		float py = EditorGUILayout.FloatField("Y", pos.y, opt);
		float pz = EditorGUILayout.FloatField("Z", pos.z, opt);

		if (reset)
		{
			pos = Vector3.zero;
			changed = true;
		}
		else if (Differs(px, pos.x) || Differs(py, pos.y) || Differs(pz, pos.z))
		{
			pos.x = px; pos.y = py; pos.z = pz;
			changed = true;
		}
	}
	GUILayout.EndHorizontal();

	// Apply to all selected transforms if something changed
	if (changed)
	{
		NGUIEditorTools.RegisterUndo("Change Position", objs);
		int i;
		for (i = 0; i < objs.Length; ++i)
		{
			Transform tt = objs[i] as Transform;
			if (tt != null) tt.localPosition = Validate(pos);
		}
	}
}

	void DrawScale (Object[] objs, bool isWidget)
	{
		Transform t = target as Transform;
		Vector3 scale = t != null ? t.localScale : Vector3.one;

		GUILayout.BeginHorizontal();
		{
			bool reset = GUILayout.Button("S", GUILayout.Width(20f));

			// X, Y normal
			GUILayoutOption opt = GUILayout.MinWidth(30f);
			float sx = EditorGUILayout.FloatField("X", scale.x, opt);
			float sy = EditorGUILayout.FloatField("Y", scale.y, opt);

			// Z greyed if it's a widget (to discourage non-2D depth scaling)
			if (isWidget) GUI.color = new Color(0.7f, 0.7f, 0.7f);
			float sz = EditorGUILayout.FloatField("Z", scale.z, opt);
			if (isWidget) GUI.color = Color.white;

			scale.x = sx; scale.y = sy; scale.z = sz;

			if (reset) scale = Vector3.one;
		}
		GUILayout.EndHorizontal();

		if (GUI.changed)
		{
			NGUIEditorTools.RegisterUndo("Change Scale", objs);
			int i;
			for (i = 0; i < objs.Length; ++i)
			{
				Transform tt = objs[i] as Transform;
				if (tt != null) tt.localScale = Validate(scale);
			}
		}
		GUI.changed = false;
	}

#region Rotation (manual euler editing without SerializedProperty)
	enum Axes : int
	{
		None = 0,
		X = 1,
		Y = 2,
		Z = 4,
		All = 7,
	}

	static bool Differs (float a, float b) { return Mathf.Abs(a - b) > 0.0001f; }

	/// <summary>
	/// Draw an editable float field with optional hidden/greyed states.
	/// </summary>
	static bool FloatField (string name, ref float value, bool hidden, bool greyedOut, GUILayoutOption opt)
	{
		float newValue = value;
		bool changed = false;

		if (!hidden)
		{
			if (greyedOut)
			{
				GUI.color = new Color(0.7f, 0.7f, 0.7f);
				newValue = EditorGUILayout.FloatField(name, newValue, opt);
				GUI.color = Color.white;
			}
			else
			{
				newValue = EditorGUILayout.FloatField(name, newValue, opt);
			}
		}
		else
		{
			if (greyedOut) GUI.color = new Color(0.7f, 0.7f, 0.7f);
			float parsed;
			float.TryParse(EditorGUILayout.TextField(name, "--", opt), out parsed);
			if (greyedOut) GUI.color = Color.white;
			newValue = parsed;
		}

		if (Differs(newValue, value))
		{
			value = newValue;
			changed = true;
		}
		return changed;
	}

	void DrawRotation (Object[] objs, bool isWidget)
	{
		Transform t = target as Transform;
		Vector3 visible = t != null ? t.localEulerAngles : Vector3.zero;

		// In Unity 2.6, we don't have SerializedProperty.hasMultipleDifferentValues.
		// We emulate "mixed value" detection by comparing against the first selected transform.
		Vector3 baseAngles = visible;
		Axes mixedAxes = Axes.None;

		if (objs != null && objs.Length > 1)
		{
			int i;
			for (i = 0; i < objs.Length; ++i)
			{
				Transform tt = objs[i] as Transform;
				if (tt == null) continue;

				Vector3 ea = tt.localEulerAngles;
				if (Differs(ea.x, baseAngles.x)) mixedAxes |= Axes.X;
				if (Differs(ea.y, baseAngles.y)) mixedAxes |= Axes.Y;
				if (Differs(ea.z, baseAngles.z)) mixedAxes |= Axes.Z;

				if (mixedAxes == Axes.All) break;
			}
		}

		GUILayout.BeginHorizontal();
		{
			bool reset = GUILayout.Button("R", GUILayout.Width(20f));

			GUILayoutOption opt = GUILayout.MinWidth(30f);
			Axes altered = Axes.None;

			if (FloatField("X", ref visible.x, (mixedAxes & Axes.X) != 0, isWidget, opt)) altered |= Axes.X;
			if (FloatField("Y", ref visible.y, (mixedAxes & Axes.Y) != 0, isWidget, opt)) altered |= Axes.Y;
			if (FloatField("Z", ref visible.z, (mixedAxes & Axes.Z) != 0, false,    opt)) altered |= Axes.Z;

			if (reset)
			{
				NGUIEditorTools.RegisterUndo("Reset Rotation", objs);
				int i;
				for (i = 0; i < objs.Length; ++i)
				{
					Transform tt = objs[i] as Transform;
					if (tt != null) tt.localRotation = Quaternion.identity;
				}
			}
			else if (altered != Axes.None)
			{
				NGUIEditorTools.RegisterUndo("Change Rotation", objs);
				int i;
				for (i = 0; i < objs.Length; ++i)
				{
					Transform tt = objs[i] as Transform;
					if (tt == null) continue;

					Vector3 v = tt.localEulerAngles;
					if ((altered & Axes.X) != 0) v.x = visible.x;
					if ((altered & Axes.Y) != 0) v.y = visible.y;
					if ((altered & Axes.Z) != 0) v.z = visible.z;

					tt.localEulerAngles = v;
				}
			}
		}
		GUILayout.EndHorizontal();
	}
#endregion

	/// <summary>
	/// Replace NaN with 0 for safety.
	/// </summary>
	static Vector3 Validate (Vector3 vector)
	{
		vector.x = float.IsNaN(vector.x) ? 0f : vector.x;
		vector.y = float.IsNaN(vector.y) ? 0f : vector.y;
		vector.z = float.IsNaN(vector.z) ? 0f : vector.z;
		return vector;
	}
}

