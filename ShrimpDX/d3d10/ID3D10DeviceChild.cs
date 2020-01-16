// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D10DeviceChild: IUnknown
    {
        static Guid s_uuid = new Guid("9b7e4c00-342c-4106-a19f-4f2704f689f0");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual void GetDevice(
            out ID3D10Device ppDevice
        ){
            var fp = GetFunctionPointer(3);
            if(m_GetDeviceFunc==null) m_GetDeviceFunc = (GetDeviceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDeviceFunc));
            ppDevice = new ID3D10Device();
            m_GetDeviceFunc(m_ptr, out ppDevice.PtrForNew);
        }
        delegate void GetDeviceFunc(IntPtr self, out IntPtr ppDevice);
        GetDeviceFunc m_GetDeviceFunc;

        public virtual int GetPrivateData(
            ref Guid guid,
            out uint pDataSize,
            IntPtr pData
        ){
            var fp = GetFunctionPointer(4);
            if(m_GetPrivateDataFunc==null) m_GetPrivateDataFunc = (GetPrivateDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPrivateDataFunc));
            
            return m_GetPrivateDataFunc(m_ptr, ref guid, out pDataSize, pData);
        }
        delegate int GetPrivateDataFunc(IntPtr self, ref Guid guid, out uint pDataSize, IntPtr pData);
        GetPrivateDataFunc m_GetPrivateDataFunc;

        public virtual int SetPrivateData(
            ref Guid guid,
            uint DataSize,
            IntPtr pData
        ){
            var fp = GetFunctionPointer(5);
            if(m_SetPrivateDataFunc==null) m_SetPrivateDataFunc = (SetPrivateDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrivateDataFunc));
            
            return m_SetPrivateDataFunc(m_ptr, ref guid, DataSize, pData);
        }
        delegate int SetPrivateDataFunc(IntPtr self, ref Guid guid, uint DataSize, IntPtr pData);
        SetPrivateDataFunc m_SetPrivateDataFunc;

        public virtual int SetPrivateDataInterface(
            ref Guid guid,
            IUnknown pData
        ){
            var fp = GetFunctionPointer(6);
            if(m_SetPrivateDataInterfaceFunc==null) m_SetPrivateDataInterfaceFunc = (SetPrivateDataInterfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrivateDataInterfaceFunc));
            
            return m_SetPrivateDataInterfaceFunc(m_ptr, ref guid, pData!=null ? pData.Ptr : IntPtr.Zero);
        }
        delegate int SetPrivateDataInterfaceFunc(IntPtr self, ref Guid guid, IntPtr pData);
        SetPrivateDataInterfaceFunc m_SetPrivateDataInterfaceFunc;

    }
}
