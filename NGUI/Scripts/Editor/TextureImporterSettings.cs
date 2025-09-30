using UnityEngine;
using System.Collections;

[System.Serializable]
public sealed class TextureImporterSettings
{
    [SerializeField]
    private int m_AlphaSource;

    [SerializeField]
    private int m_MipMapMode;

    [SerializeField]
    private int m_EnableMipMap;

    [SerializeField]
    private int m_FadeOut;

    [SerializeField]
    private int m_BorderMipMap;

    [SerializeField]
    private int m_MipMapFadeDistanceStart;

    [SerializeField]
    private int m_MipMapFadeDistanceEnd;

    [SerializeField]
    private int m_ConvertToNormalMap;

    [SerializeField]
    private float m_HeightScale;

    [SerializeField]
    private int m_NormalMapFilter;

    [SerializeField]
    private int m_IsReadable;

    [SerializeField]
    private int m_NPOTScale;

    [SerializeField]
    private int m_sRGBTexture;

    [SerializeField]
    private int m_SpriteMode;

    [SerializeField]
    private uint m_SpriteExtrude;

    [SerializeField]
    private int m_SpriteMeshType;

    [SerializeField]
    private int m_Alignment;

    [SerializeField]
    private Vector2 m_SpritePivot;

    [SerializeField]
    private float m_SpritePixelsToUnits;

    [SerializeField]
    private Vector4 m_SpriteBorder;

    [SerializeField]
    private int m_GenerateCubemap;

    [SerializeField]
    private int m_CubemapConvolution;

    [SerializeField]
    private int m_SeamlessCubemap;

    [SerializeField]
    private int m_AlphaIsTransparency;

    [SerializeField]
    private float m_SpriteTessellationDetail;

    [SerializeField]
    private int m_TextureType;

    [SerializeField]
    private int m_TextureShape;

    [SerializeField]
    private int m_FilterMode;

    [SerializeField]
    private int m_Aniso;

    [SerializeField]
    private float m_MipBias;

    [SerializeField]
    private int m_WrapMode;

    [SerializeField]
    private int m_NormalMap;

    [SerializeField]
    private int m_TextureFormat;

    [SerializeField]
    private int m_MaxTextureSize;

    [SerializeField]
    private int m_Lightmap;

    [SerializeField]
    private int m_CompressionQuality;

    [SerializeField]
    private int m_LinearTexture;

    [SerializeField]
    private int m_GrayScaleToAlpha;

    [SerializeField]
    private int m_RGBM;

    [SerializeField]
    private int m_CubemapConvolutionSteps;

    [SerializeField]
    private float m_CubemapConvolutionExponent;

    [SerializeField]
    private int m_MaxTextureSizeSet;

    [SerializeField]
    private int m_CompressionQualitySet;

    [SerializeField]
    private int m_TextureFormatSet;

    //
    // Resumen:
    //     Which type of texture are we dealing with here.
    public TextureImporterType textureType
    {
        get
        {
            return (TextureImporterType)m_TextureType;
        }
        set
        {
            m_TextureType = (int)value;
        }
    }

    //
    // Resumen:
    //     Shape of imported texture.
    public TextureImporterShape textureShape
    {
        get
        {
            return (TextureImporterShape)m_TextureShape;
        }
        set
        {
            m_TextureShape = (int)value;
        }
    }

    //
    // Resumen:
    //     Mipmap filtering mode.
    public TextureImporterMipFilter mipmapFilter
    {
        get
        {
            return (TextureImporterMipFilter)m_MipMapMode;
        }
        set
        {
            m_MipMapMode = (int)value;
        }
    }

    //
    // Resumen:
    //     Generate mip maps for the texture?
    public bool mipmapEnabled
    {
        get
        {
            return m_EnableMipMap != 0;
        }
        set
        {
            m_EnableMipMap = (value ? 1 : 0);
        }
    }


    public bool generateMipsInLinearSpace
    {
        get
        {
            return true;
        }
        set
        {
        }
    }

    //
    // Resumen:
    //     Is texture storing color data?
    public bool sRGBTexture
    {
        get
        {
            return m_sRGBTexture != 0;
        }
        set
        {
            m_sRGBTexture = (value ? 1 : 0);
        }
    }

    //
    // Resumen:
    //     Fade out mip levels to gray color?
    public bool fadeOut
    {
        get
        {
            return m_FadeOut != 0;
        }
        set
        {
            m_FadeOut = (value ? 1 : 0);
        }
    }

    //
    // Resumen:
    //     Enable this to avoid colors seeping out to the edge of the lower Mip levels.
    //     Used for light cookies.
    public bool borderMipmap
    {
        get
        {
            return m_BorderMipMap != 0;
        }
        set
        {
            m_BorderMipMap = (value ? 1 : 0);
        }
    }

    //
    // Resumen:
    //     Mip level where texture begins to fade out to gray.
    public int mipmapFadeDistanceStart
    {
        get
        {
            return m_MipMapFadeDistanceStart;
        }
        set
        {
            m_MipMapFadeDistanceStart = value;
        }
    }

    //
    // Resumen:
    //     Mip level where texture is faded out to gray completely.
    public int mipmapFadeDistanceEnd
    {
        get
        {
            return m_MipMapFadeDistanceEnd;
        }
        set
        {
            m_MipMapFadeDistanceEnd = value;
        }
    }

    //
    // Resumen:
    //     Convert heightmap to normal map?
    public bool convertToNormalMap
    {
        get
        {
            return m_ConvertToNormalMap != 0;
        }
        set
        {
            m_ConvertToNormalMap = (value ? 1 : 0);
        }
    }

    //
    // Resumen:
    //     Amount of bumpyness in the heightmap.
    public float heightmapScale
    {
        get
        {
            return m_HeightScale;
        }
        set
        {
            m_HeightScale = value;
        }
    }

    //
    // Resumen:
    //     Normal map filtering mode.
    public TextureImporterNormalFilter normalMapFilter
    {
        get
        {
            return (TextureImporterNormalFilter)m_NormalMapFilter;
        }
        set
        {
            m_NormalMapFilter = (int)value;
        }
    }

    //
    // Resumen:
    //     Select how the alpha of the imported texture is generated.
    public TextureImporterAlphaSource alphaSource
    {
        get
        {
            return (TextureImporterAlphaSource)m_AlphaSource;
        }
        set
        {
            m_AlphaSource = (int)value;
        }
    }

    //
    // Resumen:
    //     Is texture data readable from scripts.
    public bool readable
    {
        get
        {
            return m_IsReadable != 0;
        }
        set
        {
            m_IsReadable = (value ? 1 : 0);
        }
    }

    //
    // Resumen:
    //     Scaling mode for non power of two textures.
    public TextureImporterNPOTScale npotScale
    {
        get
        {
            return (TextureImporterNPOTScale)m_NPOTScale;
        }
        set
        {
            m_NPOTScale = (int)value;
        }
    }

    //
    // Resumen:
    //     Cubemap generation mode.
    public TextureImporterGenerateCubemap generateCubemap
    {
        get
        {
            return (TextureImporterGenerateCubemap)m_GenerateCubemap;
        }
        set
        {
            m_GenerateCubemap = (int)value;
        }
    }

    //
    // Resumen:
    //     Convolution mode.
    public TextureImporterCubemapConvolution cubemapConvolution
    {
        get
        {
            return (TextureImporterCubemapConvolution)m_CubemapConvolution;
        }
        set
        {
            m_CubemapConvolution = (int)value;
        }
    }

    public bool seamlessCubemap
    {
        get
        {
            return m_SeamlessCubemap != 0;
        }
        set
        {
            m_SeamlessCubemap = (value ? 1 : 0);
        }
    }

    //
    // Resumen:
    //     Filtering mode of the texture.
    public FilterMode filterMode
    {
        get
        {
            return (FilterMode)m_FilterMode;
        }
        set
        {
            m_FilterMode = (int)value;
        }
    }

    //
    // Resumen:
    //     Anisotropic filtering level of the texture.
    public int aniso
    {
        get
        {
            return m_Aniso;
        }
        set
        {
            m_Aniso = value;
        }
    }

    //
    // Resumen:
    //     Mip map bias of the texture.
    public float mipmapBias
    {
        get
        {
            return m_MipBias;
        }
        set
        {
            m_MipBias = value;
        }
    }

    //
    // Resumen:
    //     Wrap mode (Repeat or Clamp) of the texture.
    public TextureWrapMode wrapMode
    {
        get
        {
            return (TextureWrapMode)m_WrapMode;
        }
        set
        {
            m_WrapMode = (int)value;
        }
    }

    //
    // Resumen:
    //     If the provided alpha channel is transparency, enable this to dilate the color
    //     to avoid filtering artifacts on the edges.
    public bool alphaIsTransparency
    {
        get
        {
            return m_AlphaIsTransparency != 0;
        }
        set
        {
            m_AlphaIsTransparency = (value ? 1 : 0);
        }
    }

    //
    // Resumen:
    //     Sprite texture import mode.
    public int spriteMode
    {
        get
        {
            return m_SpriteMode;
        }
        set
        {
            m_SpriteMode = value;
        }
    }

    //
    // Resumen:
    //     The number of pixels in the sprite that correspond to one unit in world space.
    public float spritePixelsPerUnit
    {
        get
        {
            return m_SpritePixelsToUnits;
        }
        set
        {
            m_SpritePixelsToUnits = value;
        }
    }

    //
    // Resumen:
    //     Scale factor between pixels in the sprite graphic and world space units.

    public float spritePixelsToUnits
    {
        get
        {
            return m_SpritePixelsToUnits;
        }
        set
        {
            m_SpritePixelsToUnits = value;
        }
    }

    //
    // Resumen:
    //     The tessellation detail to be used for generating the mesh for the associated
    //     sprite if the SpriteMode is set to Single. For Multiple sprites, use the SpriteEditor
    //     to specify the value per sprite. Valid values are in the range [0-1], with higher
    //     values generating a tighter mesh. A default of -1 will allow Unity to determine
    //     the value automatically.
    public float spriteTessellationDetail
    {
        get
        {
            return m_SpriteTessellationDetail;
        }
        set
        {
            m_SpriteTessellationDetail = value;
        }
    }

    //
    // Resumen:
    //     The number of blank pixels to leave between the edge of the graphic and the mesh.
    public uint spriteExtrude
    {
        get
        {
            return m_SpriteExtrude;
        }
        set
        {
            m_SpriteExtrude = value;
        }
    }

    public SpriteMeshType spriteMeshType
    {
        get
        {
            return (SpriteMeshType)m_SpriteMeshType;
        }
        set
        {
            m_SpriteMeshType = (int)value;
        }
    }

    //
    // Resumen:
    //     Edge-relative alignment of the sprite graphic.
    public int spriteAlignment
    {
        get
        {
            return m_Alignment;
        }
        set
        {
            m_Alignment = value;
        }
    }

    //
    // Resumen:
    //     Pivot point of the Sprite relative to its graphic's rectangle.
    public Vector2 spritePivot
    {
        get
        {
            return m_SpritePivot;
        }
        set
        {
            m_SpritePivot = value;
        }
    }

    //
    // Resumen:
    //     Border sizes of the generated sprites.
    public Vector4 spriteBorder
    {
        get
        {
            return m_SpriteBorder;
        }
        set
        {
            m_SpriteBorder = value;
        }
    }

  
    public bool linearTexture
    {
        get
        {
            return !sRGBTexture;
        }
        set
        {
            sRGBTexture = !value;
        }
    }

   
    public bool normalMap
    {
        get
        {
            return textureType == TextureImporterType.NormalMap;
        }
        set
        {
            if (value)
            {
                textureType = TextureImporterType.NormalMap;
            }
            else
            {
                textureType = TextureImporterType.Default;
            }
        }
    }

  
    public TextureImporterFormat textureFormat
    {
        get
        {
            return (TextureImporterFormat)m_TextureFormat;
        }
        set
        {
            m_TextureFormat = (int)textureFormat;
            textureFormatSet = 1;
        }
    }

   
    public int maxTextureSize
    {
        get
        {
            return m_MaxTextureSize;
        }
        set
        {
            m_MaxTextureSize = value;
            maxTextureSizeSet = 1;
        }
    }

 
    public bool lightmap
    {
        get
        {
            return textureType == TextureImporterType.Lightmap;
        }
        set
        {
            if (value)
            {
                textureType = TextureImporterType.Lightmap;
            }
            else
            {
                textureType = TextureImporterType.Default;
            }
        }
    }

    //
    // Resumen:
    //     RGBM encoding mode for HDR textures in TextureImporter.

    public TextureImporterRGBMMode rgbm
    {
        get
        {
            return (TextureImporterRGBMMode)m_RGBM;
        }
        set
        {
            m_RGBM = (int)value;
        }
    }

    //
    // Resumen:
    //     Generate alpha channel from intensity?

    public bool grayscaleToAlpha
    {
        get
        {
            return alphaSource == TextureImporterAlphaSource.FromGrayScale;
        }
        set
        {
            if (value)
            {
                alphaSource = TextureImporterAlphaSource.FromGrayScale;
            }
            else
            {
                alphaSource = TextureImporterAlphaSource.FromInput;
            }
        }
    }

    //
    // Resumen:
    //     Defines how many different Phong exponents to store in mip maps. Higher value
    //     will give better transition between glossy and rough reflections, but will need
    //     higher texture resolution.

    public int cubemapConvolutionSteps
    {
        get
        {
            return m_CubemapConvolutionSteps;
        }
        set
        {
            m_CubemapConvolutionSteps = value;
        }
    }

    //
    // Resumen:
    //     Defines how fast Phong exponent wears off in mip maps. Higher value will apply
    //     less blur to high resolution mip maps.

    public float cubemapConvolutionExponent
    {
        get
        {
            return m_CubemapConvolutionExponent;
        }
        set
        {
            m_CubemapConvolutionExponent = value;
        }
    }

  
    public int compressionQuality
    {
        get
        {
            return m_CompressionQuality;
        }
        set
        {
            m_CompressionQuality = value;
            compressionQualitySet = 1;
        }
    }

    private int maxTextureSizeSet
    {
        get
        {
            return m_MaxTextureSizeSet;
        }
        set
        {
            m_MaxTextureSizeSet = value;
        }
    }

    private int textureFormatSet
    {
        get
        {
            return m_TextureFormatSet;
        }
        set
        {
            m_TextureFormatSet = value;
        }
    }

    private int compressionQualitySet
    {
        get
        {
            return m_CompressionQualitySet;
        }
        set
        {
            m_CompressionQualitySet = value;
        }
    }

    //
    // Resumen:
    //     Test texture importer settings for equality.
    //
    // Parámetros:
    //   a:
    //
    //   b:

 public static bool Equal(TextureImporterSettings a, TextureImporterSettings b)
{
    if (a == null || b == null) return false;

    // Comparar todos los campos serializados
    return
        a.m_AlphaSource == b.m_AlphaSource &&
        a.m_MipMapMode == b.m_MipMapMode &&
        a.m_EnableMipMap == b.m_EnableMipMap &&
        a.m_FadeOut == b.m_FadeOut &&
        a.m_BorderMipMap == b.m_BorderMipMap &&
        a.m_MipMapFadeDistanceStart == b.m_MipMapFadeDistanceStart &&
        a.m_MipMapFadeDistanceEnd == b.m_MipMapFadeDistanceEnd &&
        a.m_ConvertToNormalMap == b.m_ConvertToNormalMap &&
        Mathf.Approximately(a.m_HeightScale, b.m_HeightScale) &&
        a.m_NormalMapFilter == b.m_NormalMapFilter &&
        a.m_IsReadable == b.m_IsReadable &&
        a.m_NPOTScale == b.m_NPOTScale &&
        a.m_sRGBTexture == b.m_sRGBTexture &&
        a.m_SpriteMode == b.m_SpriteMode &&
        a.m_SpriteExtrude == b.m_SpriteExtrude &&
        a.m_SpriteMeshType == b.m_SpriteMeshType &&
        a.m_Alignment == b.m_Alignment &&
        a.m_SpritePivot == b.m_SpritePivot &&
        Mathf.Approximately(a.m_SpritePixelsToUnits, b.m_SpritePixelsToUnits) &&
        a.m_SpriteBorder == b.m_SpriteBorder &&
        a.m_GenerateCubemap == b.m_GenerateCubemap &&
        a.m_CubemapConvolution == b.m_CubemapConvolution &&
        a.m_SeamlessCubemap == b.m_SeamlessCubemap &&
        a.m_AlphaIsTransparency == b.m_AlphaIsTransparency &&
        Mathf.Approximately(a.m_SpriteTessellationDetail, b.m_SpriteTessellationDetail) &&
        a.m_TextureType == b.m_TextureType &&
        a.m_TextureShape == b.m_TextureShape &&
        a.m_FilterMode == b.m_FilterMode &&
        a.m_Aniso == b.m_Aniso &&
        Mathf.Approximately(a.m_MipBias, b.m_MipBias) &&
        a.m_WrapMode == b.m_WrapMode &&
        a.m_NormalMap == b.m_NormalMap &&
        a.m_TextureFormat == b.m_TextureFormat &&
        a.m_MaxTextureSize == b.m_MaxTextureSize &&
        a.m_Lightmap == b.m_Lightmap &&
        a.m_CompressionQuality == b.m_CompressionQuality &&
        a.m_LinearTexture == b.m_LinearTexture &&
        a.m_GrayScaleToAlpha == b.m_GrayScaleToAlpha &&
        a.m_RGBM == b.m_RGBM &&
        a.m_CubemapConvolutionSteps == b.m_CubemapConvolutionSteps &&
        Mathf.Approximately(a.m_CubemapConvolutionExponent, b.m_CubemapConvolutionExponent) &&
        a.m_MaxTextureSizeSet == b.m_MaxTextureSizeSet &&
        a.m_CompressionQualitySet == b.m_CompressionQualitySet &&
        a.m_TextureFormatSet == b.m_TextureFormatSet;
}

    //
    // Resumen:
    //     Copy parameters into another TextureImporterSettings object.
    //
    // Parámetros:
    //   target:
    //     TextureImporterSettings object to copy settings to.

public void CopyTo(TextureImporterSettings target)
{
    if (target == null) return;

    target.m_AlphaSource = this.m_AlphaSource;
    target.m_MipMapMode = this.m_MipMapMode;
    target.m_EnableMipMap = this.m_EnableMipMap;
    target.m_FadeOut = this.m_FadeOut;
    target.m_BorderMipMap = this.m_BorderMipMap;
    target.m_MipMapFadeDistanceStart = this.m_MipMapFadeDistanceStart;
    target.m_MipMapFadeDistanceEnd = this.m_MipMapFadeDistanceEnd;
    target.m_ConvertToNormalMap = this.m_ConvertToNormalMap;
    target.m_HeightScale = this.m_HeightScale;
    target.m_NormalMapFilter = this.m_NormalMapFilter;
    target.m_IsReadable = this.m_IsReadable;
    target.m_NPOTScale = this.m_NPOTScale;
    target.m_sRGBTexture = this.m_sRGBTexture;
    target.m_SpriteMode = this.m_SpriteMode;
    target.m_SpriteExtrude = this.m_SpriteExtrude;
    target.m_SpriteMeshType = this.m_SpriteMeshType;
    target.m_Alignment = this.m_Alignment;
    target.m_SpritePivot = this.m_SpritePivot;
    target.m_SpritePixelsToUnits = this.m_SpritePixelsToUnits;
    target.m_SpriteBorder = this.m_SpriteBorder;
    target.m_GenerateCubemap = this.m_GenerateCubemap;
    target.m_CubemapConvolution = this.m_CubemapConvolution;
    target.m_SeamlessCubemap = this.m_SeamlessCubemap;
    target.m_AlphaIsTransparency = this.m_AlphaIsTransparency;
    target.m_SpriteTessellationDetail = this.m_SpriteTessellationDetail;
    target.m_TextureType = this.m_TextureType;
    target.m_TextureShape = this.m_TextureShape;
    target.m_FilterMode = this.m_FilterMode;
    target.m_Aniso = this.m_Aniso;
    target.m_MipBias = this.m_MipBias;
    target.m_WrapMode = this.m_WrapMode;
    target.m_NormalMap = this.m_NormalMap;
    target.m_TextureFormat = this.m_TextureFormat;
    target.m_MaxTextureSize = this.m_MaxTextureSize;
    target.m_Lightmap = this.m_Lightmap;
    target.m_CompressionQuality = this.m_CompressionQuality;
    target.m_LinearTexture = this.m_LinearTexture;
    target.m_GrayScaleToAlpha = this.m_GrayScaleToAlpha;
    target.m_RGBM = this.m_RGBM;
    target.m_CubemapConvolutionSteps = this.m_CubemapConvolutionSteps;
    target.m_CubemapConvolutionExponent = this.m_CubemapConvolutionExponent;
    target.m_MaxTextureSizeSet = this.m_MaxTextureSizeSet;
    target.m_CompressionQualitySet = this.m_CompressionQualitySet;
    target.m_TextureFormatSet = this.m_TextureFormatSet;
}

    //
    // Resumen:
    //     Configure parameters to import a texture for a purpose of type, as described
    //     TextureImporterType|here.
    //
    // Parámetros:
    //   type:
    //     Texture type. See TextureImporterType.
    //
    //   applyAll:
    //     If false, change only specific properties. Exactly which, depends on type.
    
    public void ApplyTextureType(TextureImporterType type, bool applyAll)
    {
        Internal_ApplyTextureType(this, type);
    }

    public void ApplyTextureType(TextureImporterType type)
    {
        Internal_ApplyTextureType(this, type);
    }

    private void Internal_ApplyTextureType(TextureImporterSettings s, TextureImporterType type)
	{
	}
}