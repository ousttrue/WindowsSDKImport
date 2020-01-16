// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IDWriteFontCollection: IUnknown
    {
        static Guid s_uuid = new Guid("a84cee02-3eea-4eee-a827-87c1a02a0fcc");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual uint GetFontFamilyCount(
        ){
            var fp = GetFunctionPointer(3);
            if(m_GetFontFamilyCountFunc==null) m_GetFontFamilyCountFunc = (GetFontFamilyCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontFamilyCountFunc));
            
            return m_GetFontFamilyCountFunc(m_ptr);
        }
        delegate uint GetFontFamilyCountFunc(IntPtr self);
        GetFontFamilyCountFunc m_GetFontFamilyCountFunc;

        public virtual int GetFontFamily(
            uint index,
            out IDWriteFontFamily fontFamily
        ){
            var fp = GetFunctionPointer(4);
            if(m_GetFontFamilyFunc==null) m_GetFontFamilyFunc = (GetFontFamilyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontFamilyFunc));
            fontFamily = new IDWriteFontFamily();
            return m_GetFontFamilyFunc(m_ptr, index, out fontFamily.PtrForNew);
        }
        delegate int GetFontFamilyFunc(IntPtr self, uint index, out IntPtr fontFamily);
        GetFontFamilyFunc m_GetFontFamilyFunc;

        public virtual int FindFamilyName(
            ref ushort familyName,
            out uint index,
            out int exists
        ){
            var fp = GetFunctionPointer(5);
            if(m_FindFamilyNameFunc==null) m_FindFamilyNameFunc = (FindFamilyNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FindFamilyNameFunc));
            
            return m_FindFamilyNameFunc(m_ptr, ref familyName, out index, out exists);
        }
        delegate int FindFamilyNameFunc(IntPtr self, ref ushort familyName, out uint index, out int exists);
        FindFamilyNameFunc m_FindFamilyNameFunc;

        public virtual int GetFontFromFontFace(
            IDWriteFontFace fontFace,
            out IDWriteFont font
        ){
            var fp = GetFunctionPointer(6);
            if(m_GetFontFromFontFaceFunc==null) m_GetFontFromFontFaceFunc = (GetFontFromFontFaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontFromFontFaceFunc));
            font = new IDWriteFont();
            return m_GetFontFromFontFaceFunc(m_ptr, fontFace!=null ? fontFace.Ptr : IntPtr.Zero, out font.PtrForNew);
        }
        delegate int GetFontFromFontFaceFunc(IntPtr self, IntPtr fontFace, out IntPtr font);
        GetFontFromFontFaceFunc m_GetFontFromFontFaceFunc;

    }
}
