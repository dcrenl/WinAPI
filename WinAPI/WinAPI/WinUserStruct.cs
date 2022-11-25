using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace WinAPI
{
    /// <summary>
    /// dcrenl:2022-11-24 13:06:40
    /// user32.dll使用到的struct
    /// </summary>
    #region

    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        /// LONG->int
        public int left;

        /// LONG->int
        public int top;

        /// LONG->int
        public int right;

        /// LONG->int
        public int bottom;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PAINTSTRUCT
    {
        /// HDC->HDC__*
        public IntPtr hdc;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fErase;

        /// RECT->tagRECT
        public RECT rcPaint;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fRestore;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fIncUpdate;

        /// BYTE[32]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
        public byte[] rgbReserved;
    }


    #endregion
}
