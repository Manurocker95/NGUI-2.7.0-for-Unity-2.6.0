using UnityEngine;
using System.Collections;

public enum TextureImporterType
{
    //
    // Resumen:
    //     This is the most common setting used for all the textures in general.
    Default = 0,
    //
    // Resumen:
    //     This is the most common setting used for all the textures in general.

    Image = 0,
    //
    // Resumen:
    //     Select this to turn the color channels into a format suitable for real-time normal
    //     mapping.
    NormalMap = 1,

    Bump = 1,
    //
    // Resumen:
    //     Use this if your texture is going to be used on any HUD/GUI Controls.
    GUI = 2,
    //
    // Resumen:
    //     Select this if you will be using your texture for Sprite graphics.
    Sprite = 8,
    //
    // Resumen:
    //     Use this if your texture is going to be used as a cursor.
    Cursor = 7,

    Cubemap = 3,
   
    Reflection = 3,
    //
    // Resumen:
    //     This sets up your texture with the basic parameters used for the Cookies of your
    //     lights.
    Cookie = 4,
    //
    // Resumen:
    //     This sets up your texture with the parameters used by the lightmap.
    Lightmap = 6,

    HDRI = 9,
   
    Advanced = 5,
    //
    // Resumen:
    //     Use this for texture containing a single channel.
    SingleChannel = 10
}