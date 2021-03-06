// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IWICBitmapSourceTransform: IUnknown
    {
        static Guid s_uuid = new Guid("3b16811b-6a43-4ec9-b713-3d5a0c13b940");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int CopyPixels(
            ref WICRect prc,
            uint uiWidth,
            uint uiHeight,
            out Guid pguidDstFormat,
            WICBitmapTransformOptions dstTransform,
            uint nStride,
            uint cbBufferSize,
            out byte pbBuffer
        ){
            var fp = GetFunctionPointer(3);
            if(m_CopyPixelsFunc==null) m_CopyPixelsFunc = (CopyPixelsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CopyPixelsFunc));
            
            return m_CopyPixelsFunc(m_ptr, ref prc, uiWidth, uiHeight, out pguidDstFormat, dstTransform, nStride, cbBufferSize, out pbBuffer);
        }
        delegate int CopyPixelsFunc(IntPtr self, ref WICRect prc, uint uiWidth, uint uiHeight, out Guid pguidDstFormat, WICBitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, out byte pbBuffer);
        CopyPixelsFunc m_CopyPixelsFunc;

        public virtual int GetClosestSize(
            out uint puiWidth,
            out uint puiHeight
        ){
            var fp = GetFunctionPointer(4);
            if(m_GetClosestSizeFunc==null) m_GetClosestSizeFunc = (GetClosestSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetClosestSizeFunc));
            
            return m_GetClosestSizeFunc(m_ptr, out puiWidth, out puiHeight);
        }
        delegate int GetClosestSizeFunc(IntPtr self, out uint puiWidth, out uint puiHeight);
        GetClosestSizeFunc m_GetClosestSizeFunc;

        public virtual int GetClosestPixelFormat(
            out Guid pguidDstFormat
        ){
            var fp = GetFunctionPointer(5);
            if(m_GetClosestPixelFormatFunc==null) m_GetClosestPixelFormatFunc = (GetClosestPixelFormatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetClosestPixelFormatFunc));
            
            return m_GetClosestPixelFormatFunc(m_ptr, out pguidDstFormat);
        }
        delegate int GetClosestPixelFormatFunc(IntPtr self, out Guid pguidDstFormat);
        GetClosestPixelFormatFunc m_GetClosestPixelFormatFunc;

        public virtual int DoesSupportTransform(
            WICBitmapTransformOptions dstTransform,
            out int pfIsSupported
        ){
            var fp = GetFunctionPointer(6);
            if(m_DoesSupportTransformFunc==null) m_DoesSupportTransformFunc = (DoesSupportTransformFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DoesSupportTransformFunc));
            
            return m_DoesSupportTransformFunc(m_ptr, dstTransform, out pfIsSupported);
        }
        delegate int DoesSupportTransformFunc(IntPtr self, WICBitmapTransformOptions dstTransform, out int pfIsSupported);
        DoesSupportTransformFunc m_DoesSupportTransformFunc;

    }
}
