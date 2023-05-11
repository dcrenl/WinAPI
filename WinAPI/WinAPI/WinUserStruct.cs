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

    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
    public struct DEVMODE
    {
        public const int CCHDEVICENAME = 32;
        public const int CCHFORMNAME = 32;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHDEVICENAME)]
        [FieldOffset(0)]
        public string dmDeviceName;
        [FieldOffset(32)]
        public Int16 dmSpecVersion;
        [FieldOffset(34)]
        public Int16 dmDriverVersion;
        [FieldOffset(36)]
        public Int16 dmSize;
        [FieldOffset(38)]
        public Int16 dmDriverExtra;
        [FieldOffset(40)]
        public Int32 dmFields;

        [FieldOffset(44)]
        Int16 dmOrientation;
        [FieldOffset(46)]
        Int16 dmPaperSize;
        [FieldOffset(48)]
        Int16 dmPaperLength;
        [FieldOffset(50)]
        Int16 dmPaperWidth;
        [FieldOffset(52)]
        Int16 dmScale;
        [FieldOffset(54)]
        Int16 dmCopies;
        [FieldOffset(56)]
        Int16 dmDefaultSource;
        [FieldOffset(58)]
        Int16 dmPrintQuality;

        [FieldOffset(44)]
        public POINTL dmPosition;
        [FieldOffset(52)]
        public Int32 dmDisplayOrientation;
        [FieldOffset(56)]
        public Int32 dmDisplayFixedOutput;

        [FieldOffset(60)]
        public short dmColor;
        [FieldOffset(62)]
        public short dmDuplex;
        [FieldOffset(64)]
        public short dmYResolution;
        [FieldOffset(66)]
        public short dmTTOption;
        [FieldOffset(68)]
        public short dmCollate;
        [FieldOffset(72)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHFORMNAME)]
        public string dmFormName;
        [FieldOffset(102)]
        public Int16 dmLogPixels;
        [FieldOffset(104)]
        public Int32 dmBitsPerPel;
        [FieldOffset(108)]
        public Int32 dmPelsWidth;
        [FieldOffset(112)]
        public Int32 dmPelsHeight;
        [FieldOffset(116)]
        public Int32 dmDisplayFlags;
        [FieldOffset(116)]
        public Int32 dmNup;
        [FieldOffset(120)]
        public Int32 dmDisplayFrequency;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ChangeFilterStruct
    {
        public uint CbSize;
        public readonly ChangeFilterStatu ExtStatus;
    }

    #endregion
}
