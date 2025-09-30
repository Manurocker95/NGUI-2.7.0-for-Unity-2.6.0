public enum TextureImporterGenerateCubemap
{
    //
    // Resumen:
    //     Do not generate cubemap (default).

    None,
    //
    // Resumen:
    //     Generate cubemap from spheremap texture.
    Spheremap,
    //
    // Resumen:
    //     Generate cubemap from cylindrical texture.
    Cylindrical,
   
    SimpleSpheremap,
   
    NiceSpheremap,
    //
    // Resumen:
    //     Generate cubemap from vertical or horizontal cross texture.
    FullCubemap,
    //
    // Resumen:
    //     Automatically determine type of cubemap generation from the source image.
    AutoCubemap
}