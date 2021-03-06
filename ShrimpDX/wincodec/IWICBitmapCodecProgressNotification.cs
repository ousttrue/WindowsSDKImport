// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IWICBitmapCodecProgressNotification: IUnknown
    {
        static Guid s_uuid = new Guid("64c1024e-c3cf-4462-8078-88c2b11c46d9");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int RegisterProgressNotification(
            PFNProgressNotification pfnProgressNotification,
            IntPtr pvData,
            uint dwProgressFlags
        ){
            var fp = GetFunctionPointer(3);
            if(m_RegisterProgressNotificationFunc==null) m_RegisterProgressNotificationFunc = (RegisterProgressNotificationFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RegisterProgressNotificationFunc));
            
            return m_RegisterProgressNotificationFunc(m_ptr, pfnProgressNotification, pvData, dwProgressFlags);
        }
        delegate int RegisterProgressNotificationFunc(IntPtr self, PFNProgressNotification pfnProgressNotification, IntPtr pvData, uint dwProgressFlags);
        RegisterProgressNotificationFunc m_RegisterProgressNotificationFunc;

    }
}
