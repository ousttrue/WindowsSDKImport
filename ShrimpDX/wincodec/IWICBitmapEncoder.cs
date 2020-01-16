// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IWICBitmapEncoder: IUnknown
    {
        static Guid s_uuid = new Guid("00000103-a8f2-4877-ba0a-fd2b6645fb94");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int Initialize(
            IStream pIStream,
            WICBitmapEncoderCacheOption cacheOption
        ){
            var fp = GetFunctionPointer(3);
            if(m_InitializeFunc==null) m_InitializeFunc = (InitializeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(InitializeFunc));
            
            return m_InitializeFunc(m_ptr, pIStream!=null ? pIStream.Ptr : IntPtr.Zero, cacheOption);
        }
        delegate int InitializeFunc(IntPtr self, IntPtr pIStream, WICBitmapEncoderCacheOption cacheOption);
        InitializeFunc m_InitializeFunc;

        public virtual int GetContainerFormat(
            out Guid pguidContainerFormat
        ){
            var fp = GetFunctionPointer(4);
            if(m_GetContainerFormatFunc==null) m_GetContainerFormatFunc = (GetContainerFormatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetContainerFormatFunc));
            
            return m_GetContainerFormatFunc(m_ptr, out pguidContainerFormat);
        }
        delegate int GetContainerFormatFunc(IntPtr self, out Guid pguidContainerFormat);
        GetContainerFormatFunc m_GetContainerFormatFunc;

        public virtual int GetEncoderInfo(
            out IWICBitmapEncoderInfo ppIEncoderInfo
        ){
            var fp = GetFunctionPointer(5);
            if(m_GetEncoderInfoFunc==null) m_GetEncoderInfoFunc = (GetEncoderInfoFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetEncoderInfoFunc));
            ppIEncoderInfo = new IWICBitmapEncoderInfo();
            return m_GetEncoderInfoFunc(m_ptr, out ppIEncoderInfo.PtrForNew);
        }
        delegate int GetEncoderInfoFunc(IntPtr self, out IntPtr ppIEncoderInfo);
        GetEncoderInfoFunc m_GetEncoderInfoFunc;

        public virtual int SetColorContexts(
            uint cCount,
            out IWICColorContext ppIColorContext
        ){
            var fp = GetFunctionPointer(6);
            if(m_SetColorContextsFunc==null) m_SetColorContextsFunc = (SetColorContextsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetColorContextsFunc));
            ppIColorContext = new IWICColorContext();
            return m_SetColorContextsFunc(m_ptr, cCount, out ppIColorContext.PtrForNew);
        }
        delegate int SetColorContextsFunc(IntPtr self, uint cCount, out IntPtr ppIColorContext);
        SetColorContextsFunc m_SetColorContextsFunc;

        public virtual int SetPalette(
            IWICPalette pIPalette
        ){
            var fp = GetFunctionPointer(7);
            if(m_SetPaletteFunc==null) m_SetPaletteFunc = (SetPaletteFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPaletteFunc));
            
            return m_SetPaletteFunc(m_ptr, pIPalette!=null ? pIPalette.Ptr : IntPtr.Zero);
        }
        delegate int SetPaletteFunc(IntPtr self, IntPtr pIPalette);
        SetPaletteFunc m_SetPaletteFunc;

        public virtual int SetThumbnail(
            IWICBitmapSource pIThumbnail
        ){
            var fp = GetFunctionPointer(8);
            if(m_SetThumbnailFunc==null) m_SetThumbnailFunc = (SetThumbnailFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetThumbnailFunc));
            
            return m_SetThumbnailFunc(m_ptr, pIThumbnail!=null ? pIThumbnail.Ptr : IntPtr.Zero);
        }
        delegate int SetThumbnailFunc(IntPtr self, IntPtr pIThumbnail);
        SetThumbnailFunc m_SetThumbnailFunc;

        public virtual int SetPreview(
            IWICBitmapSource pIPreview
        ){
            var fp = GetFunctionPointer(9);
            if(m_SetPreviewFunc==null) m_SetPreviewFunc = (SetPreviewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPreviewFunc));
            
            return m_SetPreviewFunc(m_ptr, pIPreview!=null ? pIPreview.Ptr : IntPtr.Zero);
        }
        delegate int SetPreviewFunc(IntPtr self, IntPtr pIPreview);
        SetPreviewFunc m_SetPreviewFunc;

        public virtual int CreateNewFrame(
            out IWICBitmapFrameEncode ppIFrameEncode,
            out IPropertyBag2 ppIEncoderOptions
        ){
            var fp = GetFunctionPointer(10);
            if(m_CreateNewFrameFunc==null) m_CreateNewFrameFunc = (CreateNewFrameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateNewFrameFunc));
            ppIFrameEncode = new IWICBitmapFrameEncode();ppIEncoderOptions = new IPropertyBag2();
            return m_CreateNewFrameFunc(m_ptr, out ppIFrameEncode.PtrForNew, out ppIEncoderOptions.PtrForNew);
        }
        delegate int CreateNewFrameFunc(IntPtr self, out IntPtr ppIFrameEncode, out IntPtr ppIEncoderOptions);
        CreateNewFrameFunc m_CreateNewFrameFunc;

        public virtual int Commit(
        ){
            var fp = GetFunctionPointer(11);
            if(m_CommitFunc==null) m_CommitFunc = (CommitFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CommitFunc));
            
            return m_CommitFunc(m_ptr);
        }
        delegate int CommitFunc(IntPtr self);
        CommitFunc m_CommitFunc;

        public virtual int GetMetadataQueryWriter(
            out IWICMetadataQueryWriter ppIMetadataQueryWriter
        ){
            var fp = GetFunctionPointer(12);
            if(m_GetMetadataQueryWriterFunc==null) m_GetMetadataQueryWriterFunc = (GetMetadataQueryWriterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMetadataQueryWriterFunc));
            ppIMetadataQueryWriter = new IWICMetadataQueryWriter();
            return m_GetMetadataQueryWriterFunc(m_ptr, out ppIMetadataQueryWriter.PtrForNew);
        }
        delegate int GetMetadataQueryWriterFunc(IntPtr self, out IntPtr ppIMetadataQueryWriter);
        GetMetadataQueryWriterFunc m_GetMetadataQueryWriterFunc;

    }
}
