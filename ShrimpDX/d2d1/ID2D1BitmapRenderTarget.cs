// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID2D1BitmapRenderTarget: ID2D1RenderTarget
    {
        static Guid s_uuid = new Guid("2cd90695-12e2-11dc-9fed-001143a055f9");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int GetBitmap(
            out ID2D1Bitmap bitmap
        ){
            var fp = GetFunctionPointer(57);
            if(m_GetBitmapFunc==null) m_GetBitmapFunc = (GetBitmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBitmapFunc));
            bitmap = new ID2D1Bitmap();
            return m_GetBitmapFunc(m_ptr, out bitmap.PtrForNew);
        }
        delegate int GetBitmapFunc(IntPtr self, out IntPtr bitmap);
        GetBitmapFunc m_GetBitmapFunc;

    }
}
