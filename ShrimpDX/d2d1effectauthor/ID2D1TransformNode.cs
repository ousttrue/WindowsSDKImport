// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID2D1TransformNode: IUnknown
    {
        static Guid s_uuid = new Guid("b2efe1e7-729f-4102-949f-505fa21bf666");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual uint GetInputCount(
        ){
            var fp = GetFunctionPointer(3);
            if(m_GetInputCountFunc==null) m_GetInputCountFunc = (GetInputCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetInputCountFunc));
            
            return m_GetInputCountFunc(m_ptr);
        }
        delegate uint GetInputCountFunc(IntPtr self);
        GetInputCountFunc m_GetInputCountFunc;

    }
}
