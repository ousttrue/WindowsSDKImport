// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IWICMetadataQueryReader: IUnknown
    {
        static Guid s_uuid = new Guid("30989668-e1c9-4597-b395-458eedb808df");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int GetContainerFormat(
            out Guid pguidContainerFormat
        ){
            var fp = GetFunctionPointer(3);
            if(m_GetContainerFormatFunc==null) m_GetContainerFormatFunc = (GetContainerFormatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetContainerFormatFunc));
            
            return m_GetContainerFormatFunc(m_ptr, out pguidContainerFormat);
        }
        delegate int GetContainerFormatFunc(IntPtr self, out Guid pguidContainerFormat);
        GetContainerFormatFunc m_GetContainerFormatFunc;

        public virtual int GetLocation(
            uint cchMaxLength,
            out ushort wzNamespace,
            out uint pcchActualLength
        ){
            var fp = GetFunctionPointer(4);
            if(m_GetLocationFunc==null) m_GetLocationFunc = (GetLocationFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLocationFunc));
            
            return m_GetLocationFunc(m_ptr, cchMaxLength, out wzNamespace, out pcchActualLength);
        }
        delegate int GetLocationFunc(IntPtr self, uint cchMaxLength, out ushort wzNamespace, out uint pcchActualLength);
        GetLocationFunc m_GetLocationFunc;

        public virtual int GetMetadataByName(
            ref ushort wzName,
            out tagPROPVARIANT pvarValue
        ){
            var fp = GetFunctionPointer(5);
            if(m_GetMetadataByNameFunc==null) m_GetMetadataByNameFunc = (GetMetadataByNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMetadataByNameFunc));
            
            return m_GetMetadataByNameFunc(m_ptr, ref wzName, out pvarValue);
        }
        delegate int GetMetadataByNameFunc(IntPtr self, ref ushort wzName, out tagPROPVARIANT pvarValue);
        GetMetadataByNameFunc m_GetMetadataByNameFunc;

        public virtual int GetEnumerator(
            out IEnumString ppIEnumString
        ){
            var fp = GetFunctionPointer(6);
            if(m_GetEnumeratorFunc==null) m_GetEnumeratorFunc = (GetEnumeratorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetEnumeratorFunc));
            ppIEnumString = new IEnumString();
            return m_GetEnumeratorFunc(m_ptr, out ppIEnumString.PtrForNew);
        }
        delegate int GetEnumeratorFunc(IntPtr self, out IntPtr ppIEnumString);
        GetEnumeratorFunc m_GetEnumeratorFunc;

    }
}