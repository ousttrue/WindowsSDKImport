// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IDXGISwapChain2: IDXGISwapChain1
    {
        static Guid s_uuid = new Guid("a8be2ac4-199f-4946-b331-79599fb98de7");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int SetSourceSize(
            uint Width,
            uint Height
        ){
            var fp = GetFunctionPointer(29);
            if(m_SetSourceSizeFunc==null) m_SetSourceSizeFunc = (SetSourceSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetSourceSizeFunc));
            
            return m_SetSourceSizeFunc(m_ptr, Width, Height);
        }
        delegate int SetSourceSizeFunc(IntPtr self, uint Width, uint Height);
        SetSourceSizeFunc m_SetSourceSizeFunc;

        public virtual int GetSourceSize(
            out uint pWidth,
            out uint pHeight
        ){
            var fp = GetFunctionPointer(30);
            if(m_GetSourceSizeFunc==null) m_GetSourceSizeFunc = (GetSourceSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSourceSizeFunc));
            
            return m_GetSourceSizeFunc(m_ptr, out pWidth, out pHeight);
        }
        delegate int GetSourceSizeFunc(IntPtr self, out uint pWidth, out uint pHeight);
        GetSourceSizeFunc m_GetSourceSizeFunc;

        public virtual int SetMaximumFrameLatency(
            uint MaxLatency
        ){
            var fp = GetFunctionPointer(31);
            if(m_SetMaximumFrameLatencyFunc==null) m_SetMaximumFrameLatencyFunc = (SetMaximumFrameLatencyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetMaximumFrameLatencyFunc));
            
            return m_SetMaximumFrameLatencyFunc(m_ptr, MaxLatency);
        }
        delegate int SetMaximumFrameLatencyFunc(IntPtr self, uint MaxLatency);
        SetMaximumFrameLatencyFunc m_SetMaximumFrameLatencyFunc;

        public virtual int GetMaximumFrameLatency(
            out uint pMaxLatency
        ){
            var fp = GetFunctionPointer(32);
            if(m_GetMaximumFrameLatencyFunc==null) m_GetMaximumFrameLatencyFunc = (GetMaximumFrameLatencyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMaximumFrameLatencyFunc));
            
            return m_GetMaximumFrameLatencyFunc(m_ptr, out pMaxLatency);
        }
        delegate int GetMaximumFrameLatencyFunc(IntPtr self, out uint pMaxLatency);
        GetMaximumFrameLatencyFunc m_GetMaximumFrameLatencyFunc;

        public virtual IntPtr GetFrameLatencyWaitableObject(
        ){
            var fp = GetFunctionPointer(33);
            if(m_GetFrameLatencyWaitableObjectFunc==null) m_GetFrameLatencyWaitableObjectFunc = (GetFrameLatencyWaitableObjectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFrameLatencyWaitableObjectFunc));
            
            return m_GetFrameLatencyWaitableObjectFunc(m_ptr);
        }
        delegate IntPtr GetFrameLatencyWaitableObjectFunc(IntPtr self);
        GetFrameLatencyWaitableObjectFunc m_GetFrameLatencyWaitableObjectFunc;

        public virtual int SetMatrixTransform(
            ref DXGI_MATRIX_3X2_F pMatrix
        ){
            var fp = GetFunctionPointer(34);
            if(m_SetMatrixTransformFunc==null) m_SetMatrixTransformFunc = (SetMatrixTransformFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetMatrixTransformFunc));
            
            return m_SetMatrixTransformFunc(m_ptr, ref pMatrix);
        }
        delegate int SetMatrixTransformFunc(IntPtr self, ref DXGI_MATRIX_3X2_F pMatrix);
        SetMatrixTransformFunc m_SetMatrixTransformFunc;

        public virtual int GetMatrixTransform(
            out DXGI_MATRIX_3X2_F pMatrix
        ){
            var fp = GetFunctionPointer(35);
            if(m_GetMatrixTransformFunc==null) m_GetMatrixTransformFunc = (GetMatrixTransformFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMatrixTransformFunc));
            
            return m_GetMatrixTransformFunc(m_ptr, out pMatrix);
        }
        delegate int GetMatrixTransformFunc(IntPtr self, out DXGI_MATRIX_3X2_F pMatrix);
        GetMatrixTransformFunc m_GetMatrixTransformFunc;

    }
}
