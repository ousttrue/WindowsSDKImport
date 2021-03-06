// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IDWriteLocalizedStrings: IUnknown
    {
        static Guid s_uuid = new Guid("08256209-099a-4b34-b86d-c22b110e7771");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual uint GetCount(
        ){
            var fp = GetFunctionPointer(3);
            if(m_GetCountFunc==null) m_GetCountFunc = (GetCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCountFunc));
            
            return m_GetCountFunc(m_ptr);
        }
        delegate uint GetCountFunc(IntPtr self);
        GetCountFunc m_GetCountFunc;

        public virtual int FindLocaleName(
            ref ushort localeName,
            out uint index,
            out int exists
        ){
            var fp = GetFunctionPointer(4);
            if(m_FindLocaleNameFunc==null) m_FindLocaleNameFunc = (FindLocaleNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FindLocaleNameFunc));
            
            return m_FindLocaleNameFunc(m_ptr, ref localeName, out index, out exists);
        }
        delegate int FindLocaleNameFunc(IntPtr self, ref ushort localeName, out uint index, out int exists);
        FindLocaleNameFunc m_FindLocaleNameFunc;

        public virtual int GetLocaleNameLength(
            uint index,
            out uint length
        ){
            var fp = GetFunctionPointer(5);
            if(m_GetLocaleNameLengthFunc==null) m_GetLocaleNameLengthFunc = (GetLocaleNameLengthFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLocaleNameLengthFunc));
            
            return m_GetLocaleNameLengthFunc(m_ptr, index, out length);
        }
        delegate int GetLocaleNameLengthFunc(IntPtr self, uint index, out uint length);
        GetLocaleNameLengthFunc m_GetLocaleNameLengthFunc;

        public virtual int GetLocaleName(
            uint index,
            out ushort localeName,
            uint size
        ){
            var fp = GetFunctionPointer(6);
            if(m_GetLocaleNameFunc==null) m_GetLocaleNameFunc = (GetLocaleNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLocaleNameFunc));
            
            return m_GetLocaleNameFunc(m_ptr, index, out localeName, size);
        }
        delegate int GetLocaleNameFunc(IntPtr self, uint index, out ushort localeName, uint size);
        GetLocaleNameFunc m_GetLocaleNameFunc;

        public virtual int GetStringLength(
            uint index,
            out uint length
        ){
            var fp = GetFunctionPointer(7);
            if(m_GetStringLengthFunc==null) m_GetStringLengthFunc = (GetStringLengthFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetStringLengthFunc));
            
            return m_GetStringLengthFunc(m_ptr, index, out length);
        }
        delegate int GetStringLengthFunc(IntPtr self, uint index, out uint length);
        GetStringLengthFunc m_GetStringLengthFunc;

        public virtual int GetString(
            uint index,
            out ushort stringBuffer,
            uint size
        ){
            var fp = GetFunctionPointer(8);
            if(m_GetStringFunc==null) m_GetStringFunc = (GetStringFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetStringFunc));
            
            return m_GetStringFunc(m_ptr, index, out stringBuffer, size);
        }
        delegate int GetStringFunc(IntPtr self, uint index, out ushort stringBuffer, uint size);
        GetStringFunc m_GetStringFunc;

    }
}
