// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D11Asynchronous: ID3D11DeviceChild
    {
        static Guid s_uuid = new Guid("4b35d0cd-1e15-4258-9c98-1b1333f6dd3b");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual uint GetDataSize(
        ){
            var fp = GetFunctionPointer(7);
            if(m_GetDataSizeFunc==null) m_GetDataSizeFunc = (GetDataSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDataSizeFunc));
            
            return m_GetDataSizeFunc(m_ptr);
        }
        delegate uint GetDataSizeFunc(IntPtr self);
        GetDataSizeFunc m_GetDataSizeFunc;

    }
}
