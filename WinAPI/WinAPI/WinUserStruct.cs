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
    public struct RECT//PRECT, NPRECT, LPRECT
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

    [StructLayout(LayoutKind.Sequential)]
    public struct BSMINFO
    {
        /// UINT->unsigned int
        public uint cbSize;

        /// HDESK->HDESK__*
        public IntPtr hdesk;

        /// HWND->HWND__*
        public IntPtr hwnd;

        /// LUID->_LUID
        public LUID luid;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LUID
    {
        /// DWORD->unsigned int
        public uint LowPart;

        /// LONG->int
        public int HighPart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        /// LONG->int
        public int x;

        /// LONG->int
        public int y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SIZE
    {
        /// LONG->int
        public int cx;

        /// LONG->int
        public int cy;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MSG
    {
        /// HWND->HWND__*
        public IntPtr hwnd;

        /// UINT->unsigned int
        public WM message;

        /// WPARAM->UINT_PTR->unsigned int
        public uint wParam;

        /// LPARAM->LONG_PTR->int
        public int lParam;

        /// DWORD->unsigned int
        public uint time;

        /// POINT->tagPOINT
        public POINT pt;
    }


    #endregion
}
