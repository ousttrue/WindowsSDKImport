// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D10EffectType: ComPtr
    {
        static Guid s_uuid = new Guid("4e9e1ddc-cd9d-4772-a837-00180b9b88fd");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int IsValid(
        ){
            var fp = GetFunctionPointer(0);
            if(m_IsValidFunc==null) m_IsValidFunc = (IsValidFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsValidFunc));
            
            return m_IsValidFunc(m_ptr);
        }
        delegate int IsValidFunc(IntPtr self);
        IsValidFunc m_IsValidFunc;

        public virtual int GetDesc(
            out _D3D10_EFFECT_TYPE_DESC pDesc
        ){
            var fp = GetFunctionPointer(1);
            if(m_GetDescFunc==null) m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            
            return m_GetDescFunc(m_ptr, out pDesc);
        }
        delegate int GetDescFunc(IntPtr self, out _D3D10_EFFECT_TYPE_DESC pDesc);
        GetDescFunc m_GetDescFunc;

        public virtual ID3D10EffectType GetMemberTypeByIndex(
            uint Index
        ){
            var fp = GetFunctionPointer(2);
            if(m_GetMemberTypeByIndexFunc==null) m_GetMemberTypeByIndexFunc = (GetMemberTypeByIndexFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMemberTypeByIndexFunc));
            
            return m_GetMemberTypeByIndexFunc(m_ptr, Index);
        }
        delegate ID3D10EffectType GetMemberTypeByIndexFunc(IntPtr self, uint Index);
        GetMemberTypeByIndexFunc m_GetMemberTypeByIndexFunc;

        public virtual ID3D10EffectType GetMemberTypeByName(
            string Name
        ){
            var fp = GetFunctionPointer(3);
            if(m_GetMemberTypeByNameFunc==null) m_GetMemberTypeByNameFunc = (GetMemberTypeByNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMemberTypeByNameFunc));
            
            return m_GetMemberTypeByNameFunc(m_ptr, Name);
        }
        delegate ID3D10EffectType GetMemberTypeByNameFunc(IntPtr self, string Name);
        GetMemberTypeByNameFunc m_GetMemberTypeByNameFunc;

        public virtual ID3D10EffectType GetMemberTypeBySemantic(
            string Semantic
        ){
            var fp = GetFunctionPointer(4);
            if(m_GetMemberTypeBySemanticFunc==null) m_GetMemberTypeBySemanticFunc = (GetMemberTypeBySemanticFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMemberTypeBySemanticFunc));
            
            return m_GetMemberTypeBySemanticFunc(m_ptr, Semantic);
        }
        delegate ID3D10EffectType GetMemberTypeBySemanticFunc(IntPtr self, string Semantic);
        GetMemberTypeBySemanticFunc m_GetMemberTypeBySemanticFunc;

        public virtual string GetMemberName(
            uint Index
        ){
            var fp = GetFunctionPointer(5);
            if(m_GetMemberNameFunc==null) m_GetMemberNameFunc = (GetMemberNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMemberNameFunc));
            
            return m_GetMemberNameFunc(m_ptr, Index);
        }
        delegate string GetMemberNameFunc(IntPtr self, uint Index);
        GetMemberNameFunc m_GetMemberNameFunc;

        public virtual string GetMemberSemantic(
            uint Index
        ){
            var fp = GetFunctionPointer(6);
            if(m_GetMemberSemanticFunc==null) m_GetMemberSemanticFunc = (GetMemberSemanticFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMemberSemanticFunc));
            
            return m_GetMemberSemanticFunc(m_ptr, Index);
        }
        delegate string GetMemberSemanticFunc(IntPtr self, uint Index);
        GetMemberSemanticFunc m_GetMemberSemanticFunc;

    }
}