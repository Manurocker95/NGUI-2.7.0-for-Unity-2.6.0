using UnityEngine;
using System.Collections;

[System.Flags]
public enum TextureImporterShape
{
    //
    // Resumen:
    //     Texture is 2D.
    Texture2D = 1,
    //
    // Resumen:
    //     Texture is a Cubemap.
    TextureCube = 2
}