// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    [StructLayout(LayoutKind.Sequential)]
    public struct tagCY__anonymous_6 // 1
    {
        public uint Lo;
        public int Hi;
    }
    [StructLayout(LayoutKind.Explicit)]
    public struct tagDEC__anonymous_11 // 1
    {
       // anonymous struct __param__;
        [FieldOffset(0)]
        public ushort signscale;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagDEC___anonymous_12 // 1
    {
        public byte scale;
        public byte sign;
    }
    [StructLayout(LayoutKind.Explicit)]
    public struct tagDEC__anonymous_13 // 1
    {
       // anonymous struct __param__;
        [FieldOffset(0)]
        public ulong Lo64;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagDEC___anonymous_14 // 1
    {
        public uint Lo32;
        public uint Mid32;
    }
    [StructLayout(LayoutKind.Explicit)]
    public struct tagCY // 1
    {
        [FieldOffset(0)]
        public tagCY__anonymous_6 __param__1;
        [FieldOffset(0)]
        public long int64;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagDEC // 1
    {
        public ushort wReserved;
        public tagDEC__anonymous_11 __param__2;
        public uint Hi32;
        public tagDEC__anonymous_13 __param__4;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagCLIPDATA // 1
    {
        public uint cbSize;
        public int ulClipFmt;
        public IntPtr pClipData;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagBSTRBLOB // 2
    {
        public uint cbSize;
        public IntPtr pData;
    }
}
