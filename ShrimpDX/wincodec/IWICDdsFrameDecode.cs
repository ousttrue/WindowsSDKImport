// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IWICDdsFrameDecode: IUnknown
    {
        static Guid s_uuid = new Guid("3d4c0c61-18a4-41e4-bd80-481a4fc9f464");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int GetSizeInBlocks(
            out uint pWidthInBlocks,
            out uint pHeightInBlocks
        ){
            var fp = GetFunctionPointer(3);
            if(m_GetSizeInBlocksFunc==null) m_GetSizeInBlocksFunc = (GetSizeInBlocksFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSizeInBlocksFunc));
            
            return m_GetSizeInBlocksFunc(m_ptr, out pWidthInBlocks, out pHeightInBlocks);
        }
        delegate int GetSizeInBlocksFunc(IntPtr self, out uint pWidthInBlocks, out uint pHeightInBlocks);
        GetSizeInBlocksFunc m_GetSizeInBlocksFunc;

        public virtual int GetFormatInfo(
            out WICDdsFormatInfo pFormatInfo
        ){
            var fp = GetFunctionPointer(4);
            if(m_GetFormatInfoFunc==null) m_GetFormatInfoFunc = (GetFormatInfoFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFormatInfoFunc));
            
            return m_GetFormatInfoFunc(m_ptr, out pFormatInfo);
        }
        delegate int GetFormatInfoFunc(IntPtr self, out WICDdsFormatInfo pFormatInfo);
        GetFormatInfoFunc m_GetFormatInfoFunc;

        public virtual int CopyBlocks(
            ref WICRect prcBoundsInBlocks,
            uint cbStride,
            uint cbBufferSize,
            out byte pbBuffer
        ){
            var fp = GetFunctionPointer(5);
            if(m_CopyBlocksFunc==null) m_CopyBlocksFunc = (CopyBlocksFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CopyBlocksFunc));
            
            return m_CopyBlocksFunc(m_ptr, ref prcBoundsInBlocks, cbStride, cbBufferSize, out pbBuffer);
        }
        delegate int CopyBlocksFunc(IntPtr self, ref WICRect prcBoundsInBlocks, uint cbStride, uint cbBufferSize, out byte pbBuffer);
        CopyBlocksFunc m_CopyBlocksFunc;

    }
}
