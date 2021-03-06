// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public static partial class Constants {
        // macro function: DWRITE_DECLARE_INTERFACE ( iid ) DECLSPEC_UUID ( iid ) DECLSPEC_NOVTABLE
        // public const int DWRITE_EXPORT = __declspec ( dllimport ) WINAPI;
        // macro function: DWRITE_MAKE_OPENTYPE_TAG ( a , b , c , d ) ( ( static_cast < UINT32 > ( static_cast < UINT8 > ( d ) ) << 24 ) | ( static_cast < UINT32 > ( static_cast < UINT8 > ( c ) ) << 16 ) | ( static_cast < UINT32 > ( static_cast < UINT8 > ( b ) ) << 8 ) | static_cast < UINT32 > ( static_cast < UINT8 > ( a ) ) )
        // macro function: DWRITE_MAKE_FONT_FEATURE_TAG ( a , b , c , d ) ( static_cast < DWRITE_FONT_FEATURE_TAG > ( DWRITE_MAKE_OPENTYPE_TAG ( a , b , c , d ) ) )
        public const int DWRITE_ALPHA_MAX = 255;
        public const int FACILITY_DWRITE = unchecked((int)0x898);
        public const int DWRITE_ERR_BASE = unchecked((int)0x5000);
        // macro function: MAKE_DWRITE_HR ( severity , code ) MAKE_HRESULT ( severity , FACILITY_DWRITE , ( DWRITE_ERR_BASE + code ) )
        // macro function: MAKE_DWRITE_HR_ERR ( code ) MAKE_DWRITE_HR ( SEVERITY_ERROR , code )
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_FONT_METRICS // 3
    {
        public ushort designUnitsPerEm;
        public ushort ascent;
        public ushort descent;
        public short lineGap;
        public ushort capHeight;
        public ushort xHeight;
        public short underlinePosition;
        public ushort underlineThickness;
        public short strikethroughPosition;
        public ushort strikethroughThickness;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_GLYPH_METRICS // 2
    {
        public int leftSideBearing;
        public uint advanceWidth;
        public int rightSideBearing;
        public int topSideBearing;
        public uint advanceHeight;
        public int bottomSideBearing;
        public int verticalOriginY;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_GLYPH_OFFSET // 4
    {
        public float advanceOffset;
        public float ascenderOffset;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_MATRIX // 8
    {
        public float m11;
        public float m12;
        public float m21;
        public float m22;
        public float dx;
        public float dy;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_TRIMMING // 2
    {
        public DWRITE_TRIMMING_GRANULARITY granularity;
        public uint delimiter;
        public uint delimiterCount;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_GLYPH_RUN // 4
    {
        public IDWriteFontFace fontFace;
        public float fontEmSize;
        public uint glyphCount;
        public IntPtr glyphIndices;
        public IntPtr glyphAdvances;
        public IntPtr glyphOffsets;
        public int isSideways;
        public uint bidiLevel;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_GLYPH_RUN_DESCRIPTION // 2
    {
        public IntPtr localeName;
        public IntPtr _string;
        public uint stringLength;
        public IntPtr clusterMap;
        public uint textPosition;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_UNDERLINE // 1
    {
        public float width;
        public float thickness;
        public float offset;
        public float runHeight;
        public DWRITE_READING_DIRECTION readingDirection;
        public DWRITE_FLOW_DIRECTION flowDirection;
        public IntPtr localeName;
        public DWRITE_MEASURING_MODE measuringMode;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_STRIKETHROUGH // 1
    {
        public float width;
        public float thickness;
        public float offset;
        public DWRITE_READING_DIRECTION readingDirection;
        public DWRITE_FLOW_DIRECTION flowDirection;
        public IntPtr localeName;
        public DWRITE_MEASURING_MODE measuringMode;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_INLINE_OBJECT_METRICS // 1
    {
        public float width;
        public float height;
        public float baseline;
        public int supportsSideways;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_OVERHANG_METRICS // 2
    {
        public float left;
        public float top;
        public float right;
        public float bottom;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_FONT_FEATURE // 3
    {
        public DWRITE_FONT_FEATURE_TAG nameTag;
        public uint parameter;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_TEXT_RANGE // 26
    {
        public uint startPosition;
        public uint length;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_LINE_METRICS // 1
    {
        public uint length;
        public uint trailingWhitespaceLength;
        public uint newlineLength;
        public float height;
        public float baseline;
        public int isTrimmed;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_TEXT_METRICS // 1
    {
        public float left;
        public float top;
        public float width;
        public float widthIncludingTrailingWhitespace;
        public float height;
        public float layoutWidth;
        public float layoutHeight;
        public uint maxBidiReorderingDepth;
        public uint lineCount;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_CLUSTER_METRICS // 1
    {
        public float width;
        public ushort length;
        public ushort canWrapLineAfter;
        public ushort isWhitespace;
        public ushort isNewline;
        public ushort isSoftHyphen;
        public ushort isRightToLeft;
        public ushort padding;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_HIT_TEST_METRICS // 3
    {
        public uint textPosition;
        public uint length;
        public float left;
        public float top;
        public float width;
        public float height;
        public uint bidiLevel;
        public int isText;
        public int isTrimmed;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_SCRIPT_ANALYSIS // 4
    {
        public ushort script;
        public DWRITE_SCRIPT_SHAPES shapes;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_LINE_BREAKPOINT // 1
    {
        public byte breakConditionBefore;
        public byte breakConditionAfter;
        public byte isWhitespace;
        public byte isSoftHyphen;
        public byte padding;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_TYPOGRAPHIC_FEATURES // 3
    {
        public IntPtr features;
        public uint featureCount;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_SHAPING_TEXT_PROPERTIES // 3
    {
        public ushort isShapedAlone;
        public ushort reserved1;
        public ushort canBreakShapingAfter;
        public ushort reserved;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_SHAPING_GLYPH_PROPERTIES // 3
    {
        public ushort justification;
        public ushort isClusterStart;
        public ushort isDiacritic;
        public ushort isZeroWidthSpace;
        public ushort reserved;
    }
    public static class dwrite {
        [DllImport("dwrite.dll")]
        public static extern int DWriteCreateFactory(
            DWRITE_FACTORY_TYPE factoryType,
            ref Guid iid,
            out IntPtr factory
        );
    }
}
