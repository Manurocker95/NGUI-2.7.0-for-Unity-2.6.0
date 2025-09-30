using UnityEngine;
using System.Collections;

public enum TextureImporterNPOTScale
{
    //
    // Resumen:
    //     Keep non power of two textures as is.
    None,
    //
    // Resumen:
    //     Scale to nearest power of two.
    ToNearest,
    //
    // Resumen:
    //     Scale to larger power of two.
    ToLarger,
    //
    // Resumen:
    //     Scale to smaller power of two.
    ToSmaller
}