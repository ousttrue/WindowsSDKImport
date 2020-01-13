// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    [StructLayout(LayoutKind.Explicit)]
    public struct _devicemodeA__anonymous_5 // 1
    {
       // anonymous struct __param__;
       // anonymous struct __param__;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct _devicemodeA___anonymous_6 // 1
    {
        public short dmOrientation;
        public short dmPaperSize;
        public short dmPaperLength;
        public short dmPaperWidth;
        public short dmScale;
        public short dmCopies;
        public short dmDefaultSource;
        public short dmPrintQuality;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct _devicemodeA___anonymous_7 // 1
    {
        public _POINTL dmPosition;
        public uint dmDisplayOrientation;
        public uint dmDisplayFixedOutput;
    }
    [StructLayout(LayoutKind.Explicit)]
    public struct _devicemodeA__anonymous_8 // 1
    {
        [FieldOffset(0)]
        public uint dmDisplayFlags;
        [FieldOffset(0)]
        public uint dmNup;
    }
    [StructLayout(LayoutKind.Explicit)]
    public struct _devicemodeW__anonymous_11 // 1
    {
       // anonymous struct __param__;
       // anonymous struct __param__;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct _devicemodeW___anonymous_12 // 1
    {
        public short dmOrientation;
        public short dmPaperSize;
        public short dmPaperLength;
        public short dmPaperWidth;
        public short dmScale;
        public short dmCopies;
        public short dmDefaultSource;
        public short dmPrintQuality;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct _devicemodeW___anonymous_13 // 1
    {
        public _POINTL dmPosition;
        public uint dmDisplayOrientation;
        public uint dmDisplayFixedOutput;
    }
    [StructLayout(LayoutKind.Explicit)]
    public struct _devicemodeW__anonymous_14 // 1
    {
        [FieldOffset(0)]
        public uint dmDisplayFlags;
        [FieldOffset(0)]
        public uint dmNup;
    }
    [StructLayout(LayoutKind.Explicit)]
    public struct DISPLAYCONFIG_PATH_SOURCE_INFO__anonymous_27 // 1
    {
        [FieldOffset(0)]
        public uint modeInfoIdx;
       // anonymous struct __param__;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DISPLAYCONFIG_PATH_SOURCE_INFO___anonymous_28 // 1
    {
        public uint cloneGroupId;
        public uint sourceModeInfoIdx;
    }
    [StructLayout(LayoutKind.Explicit)]
    public struct DISPLAYCONFIG_PATH_TARGET_INFO__anonymous_31 // 1
    {
        [FieldOffset(0)]
        public uint modeInfoIdx;
       // anonymous struct __param__;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DISPLAYCONFIG_PATH_TARGET_INFO___anonymous_32 // 1
    {
        public uint desktopModeInfoIdx;
        public uint targetModeInfoIdx;
    }
    [StructLayout(LayoutKind.Explicit)]
    public struct DISPLAYCONFIG_MODE_INFO__anonymous_47 // 1
    {
        [FieldOffset(0)]
        public DISPLAYCONFIG_TARGET_MODE targetMode;
        [FieldOffset(0)]
        public DISPLAYCONFIG_SOURCE_MODE sourceMode;
        [FieldOffset(0)]
        public DISPLAYCONFIG_DESKTOP_IMAGE_INFO desktopImageInfo;
    }
    [StructLayout(LayoutKind.Explicit)]
    public struct DISPLAYCONFIG_VIDEO_SIGNAL_INFO__anonymous_54 // 1
    {
       // anonymous struct __param__;
       // anonymous struct AdditionalSignalInfo;
        [FieldOffset(0)]
        public uint videoStandard;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DISPLAYCONFIG_VIDEO_SIGNAL_INFO___anonymous_55 // 2
    {
        public uint videoStandard;
        public uint vSyncFreqDivider;
        public uint reserved;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagLOGFONTW // 4
    {
        public int lfHeight;
        public int lfWidth;
        public int lfEscapement;
        public int lfOrientation;
        public int lfWeight;
        public byte lfItalic;
        public byte lfUnderline;
        public byte lfStrikeOut;
        public byte lfCharSet;
        public byte lfOutPrecision;
        public byte lfClipPrecision;
        public byte lfQuality;
        public byte lfPitchAndFamily;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]public ushort[] lfFaceName;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct _devicemodeA // 4
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]public byte[] dmDeviceName;
        public ushort dmSpecVersion;
        public ushort dmDriverVersion;
        public ushort dmSize;
        public ushort dmDriverExtra;
        public uint dmFields;
        public _devicemodeA__anonymous_5 __param__7;
        public short dmColor;
        public short dmDuplex;
        public short dmYResolution;
        public short dmTTOption;
        public short dmCollate;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]public byte[] dmFormName;
        public ushort dmLogPixels;
        public uint dmBitsPerPel;
        public uint dmPelsWidth;
        public uint dmPelsHeight;
        public _devicemodeA__anonymous_8 __param__18;
        public uint dmDisplayFrequency;
        public uint dmICMMethod;
        public uint dmICMIntent;
        public uint dmMediaType;
        public uint dmDitherType;
        public uint dmReserved1;
        public uint dmReserved2;
        public uint dmPanningWidth;
        public uint dmPanningHeight;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct _devicemodeW // 4
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]public ushort[] dmDeviceName;
        public ushort dmSpecVersion;
        public ushort dmDriverVersion;
        public ushort dmSize;
        public ushort dmDriverExtra;
        public uint dmFields;
        public _devicemodeW__anonymous_11 __param__7;
        public short dmColor;
        public short dmDuplex;
        public short dmYResolution;
        public short dmTTOption;
        public short dmCollate;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]public ushort[] dmFormName;
        public ushort dmLogPixels;
        public uint dmBitsPerPel;
        public uint dmPelsWidth;
        public uint dmPelsHeight;
        public _devicemodeW__anonymous_14 __param__18;
        public uint dmDisplayFrequency;
        public uint dmICMMethod;
        public uint dmICMIntent;
        public uint dmMediaType;
        public uint dmDitherType;
        public uint dmReserved1;
        public uint dmReserved2;
        public uint dmPanningWidth;
        public uint dmPanningHeight;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct _BLENDFUNCTION // 2
    {
        public byte BlendOp;
        public byte BlendFlags;
        public byte SourceConstantAlpha;
        public byte AlphaFormat;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagLOGFONTA // 4
    {
        public int lfHeight;
        public int lfWidth;
        public int lfEscapement;
        public int lfOrientation;
        public int lfWeight;
        public byte lfItalic;
        public byte lfUnderline;
        public byte lfStrikeOut;
        public byte lfCharSet;
        public byte lfOutPrecision;
        public byte lfClipPrecision;
        public byte lfQuality;
        public byte lfPitchAndFamily;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]public sbyte[] lfFaceName;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct _DISPLAY_DEVICEA // 3
    {
        public uint cb;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]public sbyte[] DeviceName;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=128)]public sbyte[] DeviceString;
        public uint StateFlags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=128)]public sbyte[] DeviceID;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=128)]public sbyte[] DeviceKey;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct _DISPLAY_DEVICEW // 3
    {
        public uint cb;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]public ushort[] DeviceName;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=128)]public ushort[] DeviceString;
        public uint StateFlags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=128)]public ushort[] DeviceID;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=128)]public ushort[] DeviceKey;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DISPLAYCONFIG_PATH_INFO // 1
    {
        public DISPLAYCONFIG_PATH_SOURCE_INFO sourceInfo;
        public DISPLAYCONFIG_PATH_TARGET_INFO targetInfo;
        public uint flags;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DISPLAYCONFIG_PATH_SOURCE_INFO // 1
    {
        public _LUID adapterId;
        public uint id;
        public DISPLAYCONFIG_PATH_SOURCE_INFO__anonymous_27 __param__3;
        public uint statusFlags;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DISPLAYCONFIG_PATH_TARGET_INFO // 1
    {
        public _LUID adapterId;
        public uint id;
        public DISPLAYCONFIG_PATH_TARGET_INFO__anonymous_31 __param__3;
        public DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY outputTechnology;
        public DISPLAYCONFIG_ROTATION rotation;
        public DISPLAYCONFIG_SCALING scaling;
        public DISPLAYCONFIG_RATIONAL refreshRate;
        public DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;
        public int targetAvailable;
        public uint statusFlags;
    }
    public enum DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY // 1
    {
        _OTHER = unchecked((int)0xffffffff),
        _HD15 = 0x0,
        _SVIDEO = 0x1,
        _COMPOSITE_VIDEO = 0x2,
        _COMPONENT_VIDEO = 0x3,
        _DVI = 0x4,
        _HDMI = 0x5,
        _LVDS = 0x6,
        _D_JPN = 0x8,
        _SDI = 0x9,
        _DISPLAYPORT_EXTERNAL = 0xa,
        _DISPLAYPORT_EMBEDDED = 0xb,
        _UDI_EXTERNAL = 0xc,
        _UDI_EMBEDDED = 0xd,
        _SDTVDONGLE = 0xe,
        _MIRACAST = 0xf,
        _INDIRECT_WIRED = 0x10,
        _INDIRECT_VIRTUAL = 0x11,
        _INTERNAL = unchecked((int)0x80000000),
        _FORCE_UINT32 = unchecked((int)0xffffffff),
    }
    public enum DISPLAYCONFIG_ROTATION // 1
    {
        _IDENTITY = 0x1,
        _ROTATE90 = 0x2,
        _ROTATE180 = 0x3,
        _ROTATE270 = 0x4,
        _FORCE_UINT32 = unchecked((int)0xffffffff),
    }
    public enum DISPLAYCONFIG_SCALING // 1
    {
        _IDENTITY = 0x1,
        _CENTERED = 0x2,
        _STRETCHED = 0x3,
        _ASPECTRATIOCENTEREDMAX = 0x4,
        _CUSTOM = 0x5,
        _PREFERRED = 0x80,
        _FORCE_UINT32 = unchecked((int)0xffffffff),
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DISPLAYCONFIG_RATIONAL // 1
    {
        public uint Numerator;
        public uint Denominator;
    }
    public enum DISPLAYCONFIG_SCANLINE_ORDERING // 1
    {
        _UNSPECIFIED = 0x0,
        _PROGRESSIVE = 0x1,
        _INTERLACED = 0x2,
        _INTERLACED_UPPERFIELDFIRST = 0x2,
        _INTERLACED_LOWERFIELDFIRST = 0x3,
        _FORCE_UINT32 = unchecked((int)0xffffffff),
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DISPLAYCONFIG_MODE_INFO // 1
    {
        public DISPLAYCONFIG_MODE_INFO_TYPE infoType;
        public uint id;
        public _LUID adapterId;
        public DISPLAYCONFIG_MODE_INFO__anonymous_47 __param__4;
    }
    public enum DISPLAYCONFIG_MODE_INFO_TYPE // 1
    {
        _SOURCE = 0x1,
        _TARGET = 0x2,
        _DESKTOP_IMAGE = 0x3,
        _FORCE_UINT32 = unchecked((int)0xffffffff),
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DISPLAYCONFIG_TARGET_MODE // 1
    {
        public DISPLAYCONFIG_VIDEO_SIGNAL_INFO targetVideoSignalInfo;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DISPLAYCONFIG_VIDEO_SIGNAL_INFO // 1
    {
        public ulong pixelRate;
        public DISPLAYCONFIG_RATIONAL hSyncFreq;
        public DISPLAYCONFIG_RATIONAL vSyncFreq;
        public DISPLAYCONFIG_2DREGION activeSize;
        public DISPLAYCONFIG_2DREGION totalSize;
        public DISPLAYCONFIG_VIDEO_SIGNAL_INFO__anonymous_54 __param__6;
        public DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DISPLAYCONFIG_2DREGION // 1
    {
        public uint cx;
        public uint cy;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DISPLAYCONFIG_SOURCE_MODE // 1
    {
        public uint width;
        public uint height;
        public DISPLAYCONFIG_PIXELFORMAT pixelFormat;
        public _POINTL position;
    }
    public enum DISPLAYCONFIG_PIXELFORMAT // 1
    {
        _8BPP = 0x1,
        _16BPP = 0x2,
        _24BPP = 0x3,
        _32BPP = 0x4,
        _NONGDI = 0x5,
        _FORCE_UINT32 = unchecked((int)0xffffffff),
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DISPLAYCONFIG_DESKTOP_IMAGE_INFO // 1
    {
        public _POINTL PathSourceSize;
        public _RECTL DesktopImageRegion;
        public _RECTL DesktopImageClip;
    }
    public enum DISPLAYCONFIG_TOPOLOGY_ID // 1
    {
        _INTERNAL = 0x1,
        _CLONE = 0x2,
        _EXTEND = 0x4,
        _EXTERNAL = 0x8,
        _FORCE_UINT32 = unchecked((int)0xffffffff),
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DISPLAYCONFIG_DEVICE_INFO_HEADER // 1
    {
        public DISPLAYCONFIG_DEVICE_INFO_TYPE type;
        public uint size;
        public _LUID adapterId;
        public uint id;
    }
    public enum DISPLAYCONFIG_DEVICE_INFO_TYPE // 1
    {
        _GET_SOURCE_NAME = 0x1,
        _GET_TARGET_NAME = 0x2,
        _GET_TARGET_PREFERRED_MODE = 0x3,
        _GET_ADAPTER_NAME = 0x4,
        _SET_TARGET_PERSISTENCE = 0x5,
        _GET_TARGET_BASE_TYPE = 0x6,
        _GET_SUPPORT_VIRTUAL_RESOLUTION = 0x7,
        _SET_SUPPORT_VIRTUAL_RESOLUTION = 0x8,
        _GET_ADVANCED_COLOR_INFO = 0x9,
        _SET_ADVANCED_COLOR_STATE = 0xa,
        _GET_SDR_WHITE_LEVEL = 0xb,
        _FORCE_UINT32 = unchecked((int)0xffffffff),
    }
}
