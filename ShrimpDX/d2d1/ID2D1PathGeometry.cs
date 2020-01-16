// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID2D1PathGeometry: ID2D1Geometry
    {
        static Guid s_uuid = new Guid("2cd906a5-12e2-11dc-9fed-001143a055f9");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int Open(
            out ID2D1GeometrySink geometrySink
        ){
            var fp = GetFunctionPointer(17);
            if(m_OpenFunc==null) m_OpenFunc = (OpenFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OpenFunc));
            geometrySink = new ID2D1GeometrySink();
            return m_OpenFunc(m_ptr, out geometrySink.PtrForNew);
        }
        delegate int OpenFunc(IntPtr self, out IntPtr geometrySink);
        OpenFunc m_OpenFunc;

        public virtual int Stream(
            ID2D1GeometrySink geometrySink
        ){
            var fp = GetFunctionPointer(18);
            if(m_StreamFunc==null) m_StreamFunc = (StreamFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(StreamFunc));
            
            return m_StreamFunc(m_ptr, geometrySink!=null ? geometrySink.Ptr : IntPtr.Zero);
        }
        delegate int StreamFunc(IntPtr self, IntPtr geometrySink);
        StreamFunc m_StreamFunc;

        public virtual int GetSegmentCount(
            out uint count
        ){
            var fp = GetFunctionPointer(19);
            if(m_GetSegmentCountFunc==null) m_GetSegmentCountFunc = (GetSegmentCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSegmentCountFunc));
            
            return m_GetSegmentCountFunc(m_ptr, out count);
        }
        delegate int GetSegmentCountFunc(IntPtr self, out uint count);
        GetSegmentCountFunc m_GetSegmentCountFunc;

        public virtual int GetFigureCount(
            out uint count
        ){
            var fp = GetFunctionPointer(20);
            if(m_GetFigureCountFunc==null) m_GetFigureCountFunc = (GetFigureCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFigureCountFunc));
            
            return m_GetFigureCountFunc(m_ptr, out count);
        }
        delegate int GetFigureCountFunc(IntPtr self, out uint count);
        GetFigureCountFunc m_GetFigureCountFunc;

    }
}
