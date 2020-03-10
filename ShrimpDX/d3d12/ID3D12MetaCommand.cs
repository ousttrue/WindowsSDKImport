// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D12MetaCommand: ID3D12Pageable
    {
        static Guid s_uuid = new Guid("dbb84c27-36ce-4fc9-b801-f048c46ac570");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual ulong GetRequiredParameterResourceSize(
            D3D12_META_COMMAND_PARAMETER_STAGE Stage,
            uint ParameterIndex
        ){
            var fp = GetFunctionPointer(8);
            if(m_GetRequiredParameterResourceSizeFunc==null) m_GetRequiredParameterResourceSizeFunc = (GetRequiredParameterResourceSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRequiredParameterResourceSizeFunc));
            
            return m_GetRequiredParameterResourceSizeFunc(m_ptr, Stage, ParameterIndex);
        }
        delegate ulong GetRequiredParameterResourceSizeFunc(IntPtr self, D3D12_META_COMMAND_PARAMETER_STAGE Stage, uint ParameterIndex);
        GetRequiredParameterResourceSizeFunc m_GetRequiredParameterResourceSizeFunc;

    }
}