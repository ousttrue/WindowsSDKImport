// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D10EffectRasterizerVariable: ID3D10EffectVariable
    {
        static Guid s_uuid = new Guid("21af9f0e-4d94-4ea9-9785-2cb76b8c0b34");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int GetRasterizerState(
            uint Index,
            out ID3D10RasterizerState ppRasterizerState
        ){
            var fp = GetFunctionPointer(25);
            if(m_GetRasterizerStateFunc==null) m_GetRasterizerStateFunc = (GetRasterizerStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRasterizerStateFunc));
            ppRasterizerState = new ID3D10RasterizerState();
            return m_GetRasterizerStateFunc(m_ptr, Index, out ppRasterizerState.PtrForNew);
        }
        delegate int GetRasterizerStateFunc(IntPtr self, uint Index, out IntPtr ppRasterizerState);
        GetRasterizerStateFunc m_GetRasterizerStateFunc;

        public virtual int GetBackingStore(
            uint Index,
            out D3D10_RASTERIZER_DESC pRasterizerDesc
        ){
            var fp = GetFunctionPointer(26);
            if(m_GetBackingStoreFunc==null) m_GetBackingStoreFunc = (GetBackingStoreFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBackingStoreFunc));
            
            return m_GetBackingStoreFunc(m_ptr, Index, out pRasterizerDesc);
        }
        delegate int GetBackingStoreFunc(IntPtr self, uint Index, out D3D10_RASTERIZER_DESC pRasterizerDesc);
        GetBackingStoreFunc m_GetBackingStoreFunc;

    }
}
