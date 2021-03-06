// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D11Texture1D: ID3D11Resource
    {
        static Guid s_uuid = new Guid("f8fb5c27-c6b3-4f75-a4c8-439af2ef564c");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual void GetDesc(
            out D3D11_TEXTURE1D_DESC pDesc
        ){
            var fp = GetFunctionPointer(10);
            if(m_GetDescFunc==null) m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            
            m_GetDescFunc(m_ptr, out pDesc);
        }
        delegate void GetDescFunc(IntPtr self, out D3D11_TEXTURE1D_DESC pDesc);
        GetDescFunc m_GetDescFunc;

    }
}
