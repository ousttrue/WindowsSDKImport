// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    [StructLayout(LayoutKind.Explicit)]
    public struct D2D_MATRIX_3X2_F__anonymous_5 // 1
    {
       // anonymous struct __param__;
       // anonymous struct __param__;
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=3)]public float[][] m;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D_MATRIX_3X2_F___anonymous_6 // 1
    {
        public float m11;
        public float m12;
        public float m21;
        public float m22;
        public float dx;
        public float dy;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D_MATRIX_3X2_F___anonymous_7 // 1
    {
        public float _11;
        public float _12;
        public float _21;
        public float _22;
        public float _31;
        public float _32;
    }
    [StructLayout(LayoutKind.Explicit)]
    public struct D2D_MATRIX_4X4_F__anonymous_26 // 1
    {
       // anonymous struct __param__;
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]public float[][] m;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D_MATRIX_4X4_F___anonymous_27 // 1
    {
        public float _11;
        public float _12;
        public float _13;
        public float _14;
        public float _21;
        public float _22;
        public float _23;
        public float _24;
        public float _31;
        public float _32;
        public float _33;
        public float _34;
        public float _41;
        public float _42;
        public float _43;
        public float _44;
    }
    [StructLayout(LayoutKind.Explicit)]
    public struct D2D_MATRIX_4X3_F__anonymous_38 // 1
    {
       // anonymous struct __param__;
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]public float[][] m;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D_MATRIX_4X3_F___anonymous_39 // 1
    {
        public float _11;
        public float _12;
        public float _13;
        public float _21;
        public float _22;
        public float _23;
        public float _31;
        public float _32;
        public float _33;
        public float _41;
        public float _42;
        public float _43;
    }
    [StructLayout(LayoutKind.Explicit)]
    public struct D2D_MATRIX_5X4_F__anonymous_42 // 1
    {
       // anonymous struct __param__;
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=5)]public float[][] m;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D_MATRIX_5X4_F___anonymous_43 // 1
    {
        public float _11;
        public float _12;
        public float _13;
        public float _14;
        public float _21;
        public float _22;
        public float _23;
        public float _24;
        public float _31;
        public float _32;
        public float _33;
        public float _34;
        public float _41;
        public float _42;
        public float _43;
        public float _44;
        public float _51;
        public float _52;
        public float _53;
        public float _54;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D_RECT_F // 1
    {
        public float left;
        public float top;
        public float right;
        public float bottom;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D_MATRIX_3X2_F // 1
    {
        public D2D_MATRIX_3X2_F__anonymous_5 __param__1;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D_POINT_2F // 1
    {
        public float x;
        public float y;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D_SIZE_F // 1
    {
        public float width;
        public float height;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_PIXEL_FORMAT // 1
    {
        public DXGI_FORMAT format;
        public D2D1_ALPHA_MODE alphaMode;
    }
    public enum D2D1_ALPHA_MODE // 1
    {
        _UNKNOWN = 0x0,
        _PREMULTIPLIED = 0x1,
        _STRAIGHT = 0x2,
        _IGNORE = 0x3,
        _FORCE_DWORD = unchecked((int)0xffffffff),
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D_SIZE_U // 1
    {
        public uint width;
        public uint height;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D_POINT_2U // 1
    {
        public uint x;
        public uint y;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D_RECT_U // 1
    {
        public uint left;
        public uint top;
        public uint right;
        public uint bottom;
    }
    public enum DWRITE_MEASURING_MODE // 1
    {
        _NATURAL = 0x0,
        _GDI_CLASSIC = 0x1,
        _GDI_NATURAL = 0x2,
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D_MATRIX_4X4_F // 1
    {
        public D2D_MATRIX_4X4_F__anonymous_26 __param__1;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D_VECTOR_2F // 1
    {
        public float x;
        public float y;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D_VECTOR_3F // 1
    {
        public float x;
        public float y;
        public float z;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D_VECTOR_4F // 1
    {
        public float x;
        public float y;
        public float z;
        public float w;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D_MATRIX_4X3_F // 1
    {
        public D2D_MATRIX_4X3_F__anonymous_38 __param__1;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D_MATRIX_5X4_F // 1
    {
        public D2D_MATRIX_5X4_F__anonymous_42 __param__1;
    }
}
