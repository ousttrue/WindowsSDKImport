// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D11ClassLinkage: ID3D11DeviceChild
    {
        static Guid s_uuid = new Guid("ddf57cba-9543-46e4-a12b-f207a0fe7fed");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int GetClassInstance(
            string pClassInstanceName,
            uint InstanceIndex,
            out ID3D11ClassInstance ppInstance
        ){
            var fp = GetFunctionPointer(7);
            if(m_GetClassInstanceFunc==null) m_GetClassInstanceFunc = (GetClassInstanceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetClassInstanceFunc));
            ppInstance = new ID3D11ClassInstance();
            return m_GetClassInstanceFunc(m_ptr, pClassInstanceName, InstanceIndex, out ppInstance.PtrForNew);
        }
        delegate int GetClassInstanceFunc(IntPtr self, string pClassInstanceName, uint InstanceIndex, out IntPtr ppInstance);
        GetClassInstanceFunc m_GetClassInstanceFunc;

        public virtual int CreateClassInstance(
            string pClassTypeName,
            uint ConstantBufferOffset,
            uint ConstantVectorOffset,
            uint TextureOffset,
            uint SamplerOffset,
            out ID3D11ClassInstance ppInstance
        ){
            var fp = GetFunctionPointer(8);
            if(m_CreateClassInstanceFunc==null) m_CreateClassInstanceFunc = (CreateClassInstanceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateClassInstanceFunc));
            ppInstance = new ID3D11ClassInstance();
            return m_CreateClassInstanceFunc(m_ptr, pClassTypeName, ConstantBufferOffset, ConstantVectorOffset, TextureOffset, SamplerOffset, out ppInstance.PtrForNew);
        }
        delegate int CreateClassInstanceFunc(IntPtr self, string pClassTypeName, uint ConstantBufferOffset, uint ConstantVectorOffset, uint TextureOffset, uint SamplerOffset, out IntPtr ppInstance);
        CreateClassInstanceFunc m_CreateClassInstanceFunc;

    }
}
