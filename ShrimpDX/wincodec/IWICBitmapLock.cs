// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IWICBitmapLock: IUnknown
    {
        static Guid s_uuid = new Guid("00000123-a8f2-4877-ba0a-fd2b6645fb94");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int GetSize(
            out uint puiWidth,
            out uint puiHeight
        ){
            var fp = GetFunctionPointer(3);
            if(m_GetSizeFunc==null) m_GetSizeFunc = (GetSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSizeFunc));
            
            return m_GetSizeFunc(m_ptr, out puiWidth, out puiHeight);
        }
        delegate int GetSizeFunc(IntPtr self, out uint puiWidth, out uint puiHeight);
        GetSizeFunc m_GetSizeFunc;

        public virtual int GetStride(
            out uint pcbStride
        ){
            var fp = GetFunctionPointer(4);
            if(m_GetStrideFunc==null) m_GetStrideFunc = (GetStrideFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetStrideFunc));
            
            return m_GetStrideFunc(m_ptr, out pcbStride);
        }
        delegate int GetStrideFunc(IntPtr self, out uint pcbStride);
        GetStrideFunc m_GetStrideFunc;

        public virtual int GetDataPointer(
            out uint pcbBufferSize,
            out IntPtr ppbData
        ){
            var fp = GetFunctionPointer(5);
            if(m_GetDataPointerFunc==null) m_GetDataPointerFunc = (GetDataPointerFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDataPointerFunc));
            
            return m_GetDataPointerFunc(m_ptr, out pcbBufferSize, out ppbData);
        }
        delegate int GetDataPointerFunc(IntPtr self, out uint pcbBufferSize, out IntPtr ppbData);
        GetDataPointerFunc m_GetDataPointerFunc;

        public virtual int GetPixelFormat(
            out Guid pPixelFormat
        ){
            var fp = GetFunctionPointer(6);
            if(m_GetPixelFormatFunc==null) m_GetPixelFormatFunc = (GetPixelFormatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPixelFormatFunc));
            
            return m_GetPixelFormatFunc(m_ptr, out pPixelFormat);
        }
        delegate int GetPixelFormatFunc(IntPtr self, out Guid pPixelFormat);
        GetPixelFormatFunc m_GetPixelFormatFunc;

    }
}
