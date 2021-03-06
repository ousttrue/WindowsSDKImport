// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D12LifetimeTracker: ID3D12DeviceChild
    {
        static Guid s_uuid = new Guid("3fd03d36-4eb1-424a-a582-494ecb8ba813");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int DestroyOwnedObject(
            ID3D12DeviceChild pObject
        ){
            var fp = GetFunctionPointer(8);
            if(m_DestroyOwnedObjectFunc==null) m_DestroyOwnedObjectFunc = (DestroyOwnedObjectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DestroyOwnedObjectFunc));
            
            return m_DestroyOwnedObjectFunc(m_ptr, pObject!=null ? pObject.Ptr : IntPtr.Zero);
        }
        delegate int DestroyOwnedObjectFunc(IntPtr self, IntPtr pObject);
        DestroyOwnedObjectFunc m_DestroyOwnedObjectFunc;

    }
}
