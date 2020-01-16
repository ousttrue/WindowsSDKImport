// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IWICFastMetadataEncoder: IUnknown
    {
        static Guid s_uuid = new Guid("b84e2c09-78c9-4ac4-8bd3-524ae1663a2f");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int Commit(
        ){
            var fp = GetFunctionPointer(3);
            if(m_CommitFunc==null) m_CommitFunc = (CommitFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CommitFunc));
            
            return m_CommitFunc(m_ptr);
        }
        delegate int CommitFunc(IntPtr self);
        CommitFunc m_CommitFunc;

        public virtual int GetMetadataQueryWriter(
            out IWICMetadataQueryWriter ppIMetadataQueryWriter
        ){
            var fp = GetFunctionPointer(4);
            if(m_GetMetadataQueryWriterFunc==null) m_GetMetadataQueryWriterFunc = (GetMetadataQueryWriterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMetadataQueryWriterFunc));
            ppIMetadataQueryWriter = new IWICMetadataQueryWriter();
            return m_GetMetadataQueryWriterFunc(m_ptr, out ppIMetadataQueryWriter.PtrForNew);
        }
        delegate int GetMetadataQueryWriterFunc(IntPtr self, out IntPtr ppIMetadataQueryWriter);
        GetMetadataQueryWriterFunc m_GetMetadataQueryWriterFunc;

    }
}
