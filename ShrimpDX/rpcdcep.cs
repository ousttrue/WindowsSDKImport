// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    [StructLayout(LayoutKind.Sequential)]
    public struct _RPC_MESSAGE // 2
    {
        public IntPtr Handle;
        public uint DataRepresentation;
        public IntPtr Buffer;
        public uint BufferLength;
        public uint ProcNum;
        public IntPtr TransferSyntax;
        public IntPtr RpcInterfaceInformation;
        public IntPtr ReservedForRuntime;
        public IntPtr ManagerEpv;
        public IntPtr ImportContext;
        public uint RpcFlags;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct _RPC_SYNTAX_IDENTIFIER // 2
    {
        public Guid SyntaxGUID;
        public _RPC_VERSION SyntaxVersion;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct _RPC_VERSION // 1
    {
        public ushort MajorVersion;
        public ushort MinorVersion;
    }
}
