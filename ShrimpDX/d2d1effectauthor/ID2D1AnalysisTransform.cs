// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID2D1AnalysisTransform: IUnknown
    {
        static Guid s_uuid = new Guid("0359dc30-95e6-4568-9055-27720d130e93");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int ProcessAnalysisResults(
            ref byte analysisData,
            uint analysisDataCount
        ){
            var fp = GetFunctionPointer(3);
            if(m_ProcessAnalysisResultsFunc==null) m_ProcessAnalysisResultsFunc = (ProcessAnalysisResultsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ProcessAnalysisResultsFunc));
            
            return m_ProcessAnalysisResultsFunc(m_ptr, ref analysisData, analysisDataCount);
        }
        delegate int ProcessAnalysisResultsFunc(IntPtr self, ref byte analysisData, uint analysisDataCount);
        ProcessAnalysisResultsFunc m_ProcessAnalysisResultsFunc;

    }
}
