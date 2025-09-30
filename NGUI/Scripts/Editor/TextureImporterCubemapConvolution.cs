//
// Resumen:
//     Defines Cubemap convolution mode.
public enum TextureImporterCubemapConvolution
{
    //
    // Resumen:
    //     No convolution needed. This Cubemap texture represents mirror reflection or Skybox.
    None,
    //
    // Resumen:
    //     Specular convolution (aka Prefiltered Environment Map).
    Specular,
    //
    // Resumen:
    //     Diffuse convolution (aka irradiance Cubemap).
    Diffuse
}