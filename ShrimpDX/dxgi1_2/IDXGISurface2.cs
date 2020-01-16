// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IDXGISurface2: IDXGISurface1
    {
        static Guid s_uuid = new Guid("aba496dd-b617-4cb8-a866-bc44d7eb1fa2");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int GetResource(
            ref Guid riid,
            out IntPtr ppParentResource,
            out uint pSubresourceIndex
        ){
            var fp = GetFunctionPointer(13);
            if(m_GetResourceFunc==null) m_GetResourceFunc = (GetResourceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetResourceFunc));
            
            return m_GetResourceFunc(m_ptr, ref riid, out ppParentResource, out pSubresourceIndex);
        }
        delegate int GetResourceFunc(IntPtr self, ref Guid riid, out IntPtr ppParentResource, out uint pSubresourceIndex);
        GetResourceFunc m_GetResourceFunc;

    }
}
