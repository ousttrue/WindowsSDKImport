// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IRpcChannelBuffer: IUnknown
    {
        static Guid s_uuid = new Guid("d5f56b60-593b-101a-b569-08002b2dbf7a");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int GetBuffer(
            out tagRPCOLEMESSAGE pMessage,
            ref Guid riid
        ){
            var fp = GetFunctionPointer(3);
            if(m_GetBufferFunc==null) m_GetBufferFunc = (GetBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBufferFunc));
            
            return m_GetBufferFunc(m_ptr, out pMessage, ref riid);
        }
        delegate int GetBufferFunc(IntPtr self, out tagRPCOLEMESSAGE pMessage, ref Guid riid);
        GetBufferFunc m_GetBufferFunc;

        public virtual int SendReceive(
            out tagRPCOLEMESSAGE pMessage,
            out uint pStatus
        ){
            var fp = GetFunctionPointer(4);
            if(m_SendReceiveFunc==null) m_SendReceiveFunc = (SendReceiveFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SendReceiveFunc));
            
            return m_SendReceiveFunc(m_ptr, out pMessage, out pStatus);
        }
        delegate int SendReceiveFunc(IntPtr self, out tagRPCOLEMESSAGE pMessage, out uint pStatus);
        SendReceiveFunc m_SendReceiveFunc;

        public virtual int FreeBuffer(
            out tagRPCOLEMESSAGE pMessage
        ){
            var fp = GetFunctionPointer(5);
            if(m_FreeBufferFunc==null) m_FreeBufferFunc = (FreeBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FreeBufferFunc));
            
            return m_FreeBufferFunc(m_ptr, out pMessage);
        }
        delegate int FreeBufferFunc(IntPtr self, out tagRPCOLEMESSAGE pMessage);
        FreeBufferFunc m_FreeBufferFunc;

        public virtual int GetDestCtx(
            out uint pdwDestContext,
            out IntPtr ppvDestContext
        ){
            var fp = GetFunctionPointer(6);
            if(m_GetDestCtxFunc==null) m_GetDestCtxFunc = (GetDestCtxFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDestCtxFunc));
            
            return m_GetDestCtxFunc(m_ptr, out pdwDestContext, out ppvDestContext);
        }
        delegate int GetDestCtxFunc(IntPtr self, out uint pdwDestContext, out IntPtr ppvDestContext);
        GetDestCtxFunc m_GetDestCtxFunc;

        public virtual int IsConnected(
        ){
            var fp = GetFunctionPointer(7);
            if(m_IsConnectedFunc==null) m_IsConnectedFunc = (IsConnectedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsConnectedFunc));
            
            return m_IsConnectedFunc(m_ptr);
        }
        delegate int IsConnectedFunc(IntPtr self);
        IsConnectedFunc m_IsConnectedFunc;

    }
}
