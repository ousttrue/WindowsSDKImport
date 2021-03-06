// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID2D1BorderTransform: ID2D1ConcreteTransform
    {
        static Guid s_uuid = new Guid("4998735c-3a19-473c-9781-656847e3a347");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual void SetExtendModeX(
            D2D1_EXTEND_MODE extendMode
        ){
            var fp = GetFunctionPointer(6);
            if(m_SetExtendModeXFunc==null) m_SetExtendModeXFunc = (SetExtendModeXFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetExtendModeXFunc));
            
            m_SetExtendModeXFunc(m_ptr, extendMode);
        }
        delegate void SetExtendModeXFunc(IntPtr self, D2D1_EXTEND_MODE extendMode);
        SetExtendModeXFunc m_SetExtendModeXFunc;

        public virtual void SetExtendModeY(
            D2D1_EXTEND_MODE extendMode
        ){
            var fp = GetFunctionPointer(7);
            if(m_SetExtendModeYFunc==null) m_SetExtendModeYFunc = (SetExtendModeYFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetExtendModeYFunc));
            
            m_SetExtendModeYFunc(m_ptr, extendMode);
        }
        delegate void SetExtendModeYFunc(IntPtr self, D2D1_EXTEND_MODE extendMode);
        SetExtendModeYFunc m_SetExtendModeYFunc;

        public virtual D2D1_EXTEND_MODE GetExtendModeX(
        ){
            var fp = GetFunctionPointer(8);
            if(m_GetExtendModeXFunc==null) m_GetExtendModeXFunc = (GetExtendModeXFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetExtendModeXFunc));
            
            return m_GetExtendModeXFunc(m_ptr);
        }
        delegate D2D1_EXTEND_MODE GetExtendModeXFunc(IntPtr self);
        GetExtendModeXFunc m_GetExtendModeXFunc;

        public virtual D2D1_EXTEND_MODE GetExtendModeY(
        ){
            var fp = GetFunctionPointer(9);
            if(m_GetExtendModeYFunc==null) m_GetExtendModeYFunc = (GetExtendModeYFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetExtendModeYFunc));
            
            return m_GetExtendModeYFunc(m_ptr);
        }
        delegate D2D1_EXTEND_MODE GetExtendModeYFunc(IntPtr self);
        GetExtendModeYFunc m_GetExtendModeYFunc;

    }
}
