public enum TextureImporterFormat
{
    //
    // Resumen:
    //     Choose texture format automatically based on the texture parameters.
    Automatic = -1,
    //
    // Resumen:
    //     Choose a compressed format automatically.

    AutomaticCompressed = -1,
    //
    // Resumen:
    //     Choose a 16 bit format automatically.

    Automatic16bit = -2,
    //
    // Resumen:
    //     Choose a Truecolor format automatically.
 
    AutomaticTruecolor = -3,
    //
    // Resumen:
    //     Choose a crunched format automatically.

    AutomaticCrunched = -5,
    //
    // Resumen:
    //     Choose an HDR format automatically.

    AutomaticHDR = -6,
    //
    // Resumen:
    //     Choose a compressed HDR format automatically.

    AutomaticCompressedHDR = -7,
    //
    // Resumen:
    //     TextureFormat.DXT1 compressed texture format.
    DXT1 = 10,
    //
    // Resumen:
    //     TextureFormat.DXT5 compressed texture format.
    DXT5 = 12,
    //
    // Resumen:
    //     TextureFormat.RGB565 texture format.
    RGB16 = 7,
    //
    // Resumen:
    //     TextureFormat.RGB24 texture format.
    RGB24 = 3,
    //
    // Resumen:
    //     TextureFormat.Alpha8 texture format.
    Alpha8 = 1,
    //
    // Resumen:
    //     TextureFormat.ARGB4444 texture format.
    ARGB16 = 2,
    //
    // Resumen:
    //     TextureFormat.RGBA32 texture format.
    RGBA32 = 4,
    //
    // Resumen:
    //     TextureFormat.ARGB32 texture format.
    ARGB32 = 5,
    //
    // Resumen:
    //     TextureFormat.RGBA4444 texture format.
    RGBA16 = 13,
    //
    // Resumen:
    //     TextureFormat.RGBAHalf floating point texture format.
    RGBAHalf = 17,
    //
    // Resumen:
    //     TextureFormat.BC4 compressed texture format.
    BC4 = 26,
    //
    // Resumen:
    //     TextureFormat.BC5 compressed texture format.
    BC5 = 27,
    //
    // Resumen:
    //     TextureFormat.BC6H compressed HDR texture format.
    BC6H = 24,
    //
    // Resumen:
    //     TextureFormat.BC7 compressed texture format.
    BC7 = 25,
    //
    // Resumen:
    //     DXT1 compressed texture format with Crunch compression for small storage sizes.
    DXT1Crunched = 28,
    //
    // Resumen:
    //     DXT5 compressed texture format with Crunch compression for small storage sizes.
    DXT5Crunched = 29,
    //
    // Resumen:
    //     PowerVR/iOS TextureFormat.PVRTC_RGB2 compressed texture format.
    PVRTC_RGB2 = 30,
    //
    // Resumen:
    //     PowerVR/iOS TextureFormat.PVRTC_RGBA2 compressed texture format.
    PVRTC_RGBA2 = 31,
    //
    // Resumen:
    //     PowerVR/iOS TextureFormat.PVRTC_RGB4 compressed texture format.
    PVRTC_RGB4 = 32,
    //
    // Resumen:
    //     PowerVR/iOS TextureFormat.PVRTC_RGBA4 compressed texture format.
    PVRTC_RGBA4 = 33,
    //
    // Resumen:
    //     ETC (GLES2.0) 4 bits/pixel compressed RGB texture format.
    ETC_RGB4 = 34,
    //
    // Resumen:
    //     ATC (Android) 4 bits/pixel compressed RGB texture format.
    ATC_RGB4 = 35,
    //
    // Resumen:
    //     ATC (Android) 8 bits/pixel compressed RGBA texture format.
    ATC_RGBA8 = 36,
    //
    // Resumen:
    //     ETC2EAC compressed 4 bits pixel unsigned R texture format.
    EAC_R = 41,
    //
    // Resumen:
    //     ETC2EAC compressed 4 bits pixel signed R texture format.
    EAC_R_SIGNED = 42,
    //
    // Resumen:
    //     ETC2EAC compressed 8 bits pixel unsigned RG texture format.
    EAC_RG = 43,
    //
    // Resumen:
    //     ETC2EAC compressed 4 bits pixel signed RG texture format.
    EAC_RG_SIGNED = 44,
    //
    // Resumen:
    //     ETC2 compressed 4 bits / pixel RGB texture format.
    ETC2_RGB4 = 45,
    //
    // Resumen:
    //     ETC2 compressed 4 bits / pixel RGB + 1-bit alpha texture format.
    ETC2_RGB4_PUNCHTHROUGH_ALPHA = 46,
    //
    // Resumen:
    //     ETC2 compressed 8 bits / pixel RGBA texture format.
    ETC2_RGBA8 = 47,
    //
    // Resumen:
    //     ASTC compressed RGB texture format, 4x4 block size.
    ASTC_RGB_4x4 = 48,
    //
    // Resumen:
    //     ASTC compressed RGB texture format, 5x5 block size.
    ASTC_RGB_5x5 = 49,
    //
    // Resumen:
    //     ASTC compressed RGB texture format, 6x6 block size.
    ASTC_RGB_6x6 = 50,
    //
    // Resumen:
    //     ASTC compressed RGB texture format, 8x8 block size.
    ASTC_RGB_8x8 = 51,
    //
    // Resumen:
    //     ASTC compressed RGB texture format, 10x10 block size.
    ASTC_RGB_10x10 = 52,
    //
    // Resumen:
    //     ASTC compressed RGB texture format, 12x12 block size.
    ASTC_RGB_12x12 = 53,
    //
    // Resumen:
    //     ASTC compressed RGBA texture format, 4x4 block size.
    ASTC_RGBA_4x4 = 54,
    //
    // Resumen:
    //     ASTC compressed RGBA texture format, 5x5 block size.
    ASTC_RGBA_5x5 = 55,
    //
    // Resumen:
    //     ASTC compressed RGBA texture format, 6x6 block size.
    ASTC_RGBA_6x6 = 56,
    //
    // Resumen:
    //     ASTC compressed RGBA texture format, 8x8 block size.
    ASTC_RGBA_8x8 = 57,
    //
    // Resumen:
    //     ASTC compressed RGBA texture format, 10x10 block size.
    ASTC_RGBA_10x10 = 58,
    //
    // Resumen:
    //     ASTC compressed RGBA texture format, 12x12 block size.
    ASTC_RGBA_12x12 = 59,
    ETC_RGB8_N3DS = 60,
    ETC_A4_N3DS = 61
}