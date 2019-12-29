// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;
using HRESULT = System.Int32;

namespace ShrimpDX {
    public static partial class Constants {
    }
    public class IUnknown: ComPtr
    {
        static /*readonly*/ Guid s_uuid = new Guid("00000000-0000-0000-c000-000000000046");
        public override ref /*readonly*/ Guid IID => ref s_uuid;
                    
        public HRESULT QueryInterface(
            ref Guid riid,
            ref IntPtr ppvObject
        ){
            var fp = GetFunctionPointer(0);
            var callback = (QueryInterfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(QueryInterfaceFunc));
            
            return callback(Self, ref riid, ref ppvObject);
        }
        delegate HRESULT QueryInterfaceFunc(IntPtr self, ref Guid riid, ref IntPtr ppvObject);

        public ULONG AddRef(
        ){
            var fp = GetFunctionPointer(1);
            var callback = (AddRefFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddRefFunc));
            
            return callback(Self);
        }
        delegate ULONG AddRefFunc(IntPtr self);

        public ULONG Release(
        ){
            var fp = GetFunctionPointer(2);
            var callback = (ReleaseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseFunc));
            
            return callback(Self);
        }
        delegate ULONG ReleaseFunc(IntPtr self);

    }
    public static class unknwnbase {
    }
}
