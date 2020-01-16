// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D11CryptoSession: ID3D11DeviceChild
    {
        static Guid s_uuid = new Guid("9b32f9ad-bdcc-40a6-a39d-d5c865845720");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual void GetCryptoType(
            out Guid pCryptoType
        ){
            var fp = GetFunctionPointer(7);
            if(m_GetCryptoTypeFunc==null) m_GetCryptoTypeFunc = (GetCryptoTypeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCryptoTypeFunc));
            
            m_GetCryptoTypeFunc(m_ptr, out pCryptoType);
        }
        delegate void GetCryptoTypeFunc(IntPtr self, out Guid pCryptoType);
        GetCryptoTypeFunc m_GetCryptoTypeFunc;

        public virtual void GetDecoderProfile(
            out Guid pDecoderProfile
        ){
            var fp = GetFunctionPointer(8);
            if(m_GetDecoderProfileFunc==null) m_GetDecoderProfileFunc = (GetDecoderProfileFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDecoderProfileFunc));
            
            m_GetDecoderProfileFunc(m_ptr, out pDecoderProfile);
        }
        delegate void GetDecoderProfileFunc(IntPtr self, out Guid pDecoderProfile);
        GetDecoderProfileFunc m_GetDecoderProfileFunc;

        public virtual int GetCertificateSize(
            out uint pCertificateSize
        ){
            var fp = GetFunctionPointer(9);
            if(m_GetCertificateSizeFunc==null) m_GetCertificateSizeFunc = (GetCertificateSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCertificateSizeFunc));
            
            return m_GetCertificateSizeFunc(m_ptr, out pCertificateSize);
        }
        delegate int GetCertificateSizeFunc(IntPtr self, out uint pCertificateSize);
        GetCertificateSizeFunc m_GetCertificateSizeFunc;

        public virtual int GetCertificate(
            uint CertificateSize,
            out byte pCertificate
        ){
            var fp = GetFunctionPointer(10);
            if(m_GetCertificateFunc==null) m_GetCertificateFunc = (GetCertificateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCertificateFunc));
            
            return m_GetCertificateFunc(m_ptr, CertificateSize, out pCertificate);
        }
        delegate int GetCertificateFunc(IntPtr self, uint CertificateSize, out byte pCertificate);
        GetCertificateFunc m_GetCertificateFunc;

        public virtual void GetCryptoSessionHandle(
            out IntPtr pCryptoSessionHandle
        ){
            var fp = GetFunctionPointer(11);
            if(m_GetCryptoSessionHandleFunc==null) m_GetCryptoSessionHandleFunc = (GetCryptoSessionHandleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCryptoSessionHandleFunc));
            
            m_GetCryptoSessionHandleFunc(m_ptr, out pCryptoSessionHandle);
        }
        delegate void GetCryptoSessionHandleFunc(IntPtr self, out IntPtr pCryptoSessionHandle);
        GetCryptoSessionHandleFunc m_GetCryptoSessionHandleFunc;

    }
}
