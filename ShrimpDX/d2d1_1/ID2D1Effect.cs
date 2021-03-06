// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID2D1Effect: ID2D1Properties
    {
        static Guid s_uuid = new Guid("28211a43-7d89-476f-8181-2d6159b220ad");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual void SetInput(
            uint index,
            ID2D1Image input,
            int invalidate
        ){
            var fp = GetFunctionPointer(14);
            if(m_SetInputFunc==null) m_SetInputFunc = (SetInputFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetInputFunc));
            
            m_SetInputFunc(m_ptr, index, input!=null ? input.Ptr : IntPtr.Zero, invalidate);
        }
        delegate void SetInputFunc(IntPtr self, uint index, IntPtr input, int invalidate);
        SetInputFunc m_SetInputFunc;

        public virtual int SetInputCount(
            uint inputCount
        ){
            var fp = GetFunctionPointer(15);
            if(m_SetInputCountFunc==null) m_SetInputCountFunc = (SetInputCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetInputCountFunc));
            
            return m_SetInputCountFunc(m_ptr, inputCount);
        }
        delegate int SetInputCountFunc(IntPtr self, uint inputCount);
        SetInputCountFunc m_SetInputCountFunc;

        public virtual void GetInput(
            uint index,
            out ID2D1Image input
        ){
            var fp = GetFunctionPointer(16);
            if(m_GetInputFunc==null) m_GetInputFunc = (GetInputFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetInputFunc));
            input = new ID2D1Image();
            m_GetInputFunc(m_ptr, index, out input.PtrForNew);
        }
        delegate void GetInputFunc(IntPtr self, uint index, out IntPtr input);
        GetInputFunc m_GetInputFunc;

        public virtual uint GetInputCount(
        ){
            var fp = GetFunctionPointer(17);
            if(m_GetInputCountFunc==null) m_GetInputCountFunc = (GetInputCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetInputCountFunc));
            
            return m_GetInputCountFunc(m_ptr);
        }
        delegate uint GetInputCountFunc(IntPtr self);
        GetInputCountFunc m_GetInputCountFunc;

        public virtual void GetOutput(
            out ID2D1Image outputImage
        ){
            var fp = GetFunctionPointer(18);
            if(m_GetOutputFunc==null) m_GetOutputFunc = (GetOutputFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetOutputFunc));
            outputImage = new ID2D1Image();
            m_GetOutputFunc(m_ptr, out outputImage.PtrForNew);
        }
        delegate void GetOutputFunc(IntPtr self, out IntPtr outputImage);
        GetOutputFunc m_GetOutputFunc;

    }
}
