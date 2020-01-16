// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D10EffectConstantBuffer: ID3D10EffectVariable
    {
        static Guid s_uuid = new Guid("56648f4d-cc8b-4444-a5ad-b5a3d76e91b3");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int SetConstantBuffer(
            ID3D10Buffer pConstantBuffer
        ){
            var fp = GetFunctionPointer(25);
            if(m_SetConstantBufferFunc==null) m_SetConstantBufferFunc = (SetConstantBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetConstantBufferFunc));
            
            return m_SetConstantBufferFunc(m_ptr, pConstantBuffer!=null ? pConstantBuffer.Ptr : IntPtr.Zero);
        }
        delegate int SetConstantBufferFunc(IntPtr self, IntPtr pConstantBuffer);
        SetConstantBufferFunc m_SetConstantBufferFunc;

        public virtual int GetConstantBuffer(
            out ID3D10Buffer ppConstantBuffer
        ){
            var fp = GetFunctionPointer(26);
            if(m_GetConstantBufferFunc==null) m_GetConstantBufferFunc = (GetConstantBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetConstantBufferFunc));
            ppConstantBuffer = new ID3D10Buffer();
            return m_GetConstantBufferFunc(m_ptr, out ppConstantBuffer.PtrForNew);
        }
        delegate int GetConstantBufferFunc(IntPtr self, out IntPtr ppConstantBuffer);
        GetConstantBufferFunc m_GetConstantBufferFunc;

        public virtual int SetTextureBuffer(
            ID3D10ShaderResourceView pTextureBuffer
        ){
            var fp = GetFunctionPointer(27);
            if(m_SetTextureBufferFunc==null) m_SetTextureBufferFunc = (SetTextureBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTextureBufferFunc));
            
            return m_SetTextureBufferFunc(m_ptr, pTextureBuffer!=null ? pTextureBuffer.Ptr : IntPtr.Zero);
        }
        delegate int SetTextureBufferFunc(IntPtr self, IntPtr pTextureBuffer);
        SetTextureBufferFunc m_SetTextureBufferFunc;

        public virtual int GetTextureBuffer(
            out ID3D10ShaderResourceView ppTextureBuffer
        ){
            var fp = GetFunctionPointer(28);
            if(m_GetTextureBufferFunc==null) m_GetTextureBufferFunc = (GetTextureBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTextureBufferFunc));
            ppTextureBuffer = new ID3D10ShaderResourceView();
            return m_GetTextureBufferFunc(m_ptr, out ppTextureBuffer.PtrForNew);
        }
        delegate int GetTextureBufferFunc(IntPtr self, out IntPtr ppTextureBuffer);
        GetTextureBufferFunc m_GetTextureBufferFunc;

    }
}
