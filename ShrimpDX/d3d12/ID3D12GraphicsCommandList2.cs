// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D12GraphicsCommandList2: ID3D12GraphicsCommandList1
    {
        static Guid s_uuid = new Guid("38c3e585-ff17-412c-9150-4fc6f9d72a28");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual void WriteBufferImmediate(
            uint Count,
            ref D3D12_WRITEBUFFERIMMEDIATE_PARAMETER pParams,
            ref D3D12_WRITEBUFFERIMMEDIATE_MODE pModes
        ){
            var fp = GetFunctionPointer(66);
            if(m_WriteBufferImmediateFunc==null) m_WriteBufferImmediateFunc = (WriteBufferImmediateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(WriteBufferImmediateFunc));
            
            m_WriteBufferImmediateFunc(m_ptr, Count, ref pParams, ref pModes);
        }
        delegate void WriteBufferImmediateFunc(IntPtr self, uint Count, ref D3D12_WRITEBUFFERIMMEDIATE_PARAMETER pParams, ref D3D12_WRITEBUFFERIMMEDIATE_MODE pModes);
        WriteBufferImmediateFunc m_WriteBufferImmediateFunc;

    }
}