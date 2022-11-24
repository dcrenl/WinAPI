//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;
//using static WinAPI.User32;

//namespace WinAPI
//{
//    // ReSharper disable InconsistentNaming
//    [StructLayout(LayoutKind.Sequential)]
//    public struct POINT
//    {
//        /// LONG->int
//        public int x;

//        /// LONG->int
//        public int y;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct SECURITY_QUALITY_OF_SERVICE
//    {
//        /// DWORD->unsigned int
//        public uint Length;

//        /// SECURITY_IMPERSONATION_LEVEL->_SECURITY_IMPERSONATION_LEVEL
//        public SECURITY_IMPERSONATION_LEVEL ImpersonationLevel;

//        /// SECURITY_CONTEXT_TRACKING_MODE->BOOLEAN->BYTE->unsigned char
//        public byte ContextTrackingMode;

//        /// BOOLEAN->BYTE->unsigned char
//        public byte EffectiveOnly;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct SIZE
//    {
//        /// LONG->int
//        public int cx;

//        /// LONG->int
//        public int cy;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct BLENDFUNCTION
//    {
//        /// BYTE->unsigned char
//        public byte BlendOp;

//        /// BYTE->unsigned char
//        public byte BlendFlags;

//        /// BYTE->unsigned char
//        public byte SourceConstantAlpha;

//        /// BYTE->unsigned char
//        public byte AlphaFormat;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct MSGBOXPARAMS
//    {
//        /// UINT->unsigned int
//        public uint cbSize;

//        /// HWND->HWND__*
//        public IntPtr hwndOwner;

//        /// HINSTANCE->HINSTANCE__*
//        public IntPtr hInstance;

//        /// LPCWSTR->WCHAR*
//        [MarshalAs(UnmanagedType.LPTStr)]
//        public string lpszText;

//        /// LPCWSTR->WCHAR*
//        [MarshalAs(UnmanagedType.LPTStr)]
//        public string lpszCaption;

//        /// DWORD->unsigned int
//        public uint dwStyle;

//        /// LPCWSTR->WCHAR*
//        [MarshalAs(UnmanagedType.LPTStr)]
//        public string lpszIcon;

//        /// DWORD_PTR->ULONG_PTR->unsigned int
//        public uint dwContextHelpId;

//        /// MSGBOXCALLBACK
//        public MsgBoxCallback lpfnMsgBoxCallback;

//        /// DWORD->unsigned int
//        public uint dwLanguageId;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct WINDOWPLACEMENT
//    {
//        /// UINT->unsigned int
//        public uint length;

//        /// UINT->unsigned int
//        public uint flags;

//        /// UINT->unsigned int
//        public uint showCmd;

//        /// POINT->tagPOINT
//        public POINT ptMinPosition;

//        /// POINT->tagPOINT
//        public POINT ptMaxPosition;

//        /// RECT->tagRECT
//        public RECT rcNormalPosition;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct RECT
//    {
//        /// LONG->int
//        public int left;

//        /// LONG->int
//        public int top;

//        /// LONG->int
//        public int right;

//        /// LONG->int
//        public int bottom;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct MSG
//    {
//        /// HWND->HWND__*
//        public IntPtr hwnd;

//        /// UINT->unsigned int
//        public WM message;

//        /// WPARAM->UINT_PTR->unsigned int
//        public uint wParam;

//        /// LPARAM->LONG_PTR->int
//        public int lParam;

//        /// DWORD->unsigned int
//        public uint time;

//        /// POINT->tagPOINT
//        public POINT pt;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct WNDCLASSEX
//    {
//        /// UINT->unsigned int
//        public uint cbSize;

//        /// UINT->unsigned int
//        public uint style;

//        /// WNDPROC
//        public WindowProc lpfnWndProc;

//        /// int
//        public int cbClsExtra;

//        /// int
//        public int cbWndExtra;

//        /// HINSTANCE->HINSTANCE__*
//        public IntPtr hInstance;

//        /// HICON->HICON__*
//        public IntPtr hIcon;

//        /// HCURSOR->HICON->HICON__*
//        public IntPtr hCursor;

//        /// HBRUSH->HBRUSH__*
//        public IntPtr hbrBackground;

//        /// LPCWSTR->WCHAR*
//        [MarshalAs(UnmanagedType.LPTStr)]
//        public string lpszMenuName;

//        /// LPCWSTR->WCHAR*
//        [MarshalAs(UnmanagedType.LPTStr)]
//        public string lpszClassName;

//        /// HICON->HICON__*
//        public IntPtr hIconSm;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct WNDCLASS
//    {
//        /// UINT->unsigned int
//        public uint style;

//        /// WNDPROC
//        public WindowProc lpfnWndProc;

//        /// int
//        public int cbClsExtra;

//        /// int
//        public int cbWndExtra;

//        /// HINSTANCE->HINSTANCE__*
//        public IntPtr hInstance;

//        /// HICON->HICON__*
//        public IntPtr hIcon;

//        /// HCURSOR->HICON->HICON__*
//        public IntPtr hCursor;

//        /// HBRUSH->HBRUSH__*
//        public IntPtr hbrBackground;

//        /// LPCWSTR->WCHAR*
//        [MarshalAs(UnmanagedType.LPTStr)]
//        public string lpszMenuName;

//        /// LPCWSTR->WCHAR*
//        [MarshalAs(UnmanagedType.LPTStr)]
//        public string lpszClassName;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct PAINTSTRUCT
//    {
//        /// HDC->HDC__*
//        public IntPtr hdc;

//        /// BOOL->int
//        [MarshalAs(UnmanagedType.Bool)]
//        public bool fErase;

//        /// RECT->tagRECT
//        public RECT rcPaint;

//        /// BOOL->int
//        [MarshalAs(UnmanagedType.Bool)]
//        public bool fRestore;

//        /// BOOL->int
//        [MarshalAs(UnmanagedType.Bool)]
//        public bool fIncUpdate;

//        /// BYTE[32]
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
//        public byte[] rgbReserved;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct RAWINPUTDEVICE
//    {
//        /// USHORT->unsigned short
//        public ushort usUsagePage;

//        /// USHORT->unsigned short
//        public ushort usUsage;

//        /// DWORD->unsigned int
//        public uint dwFlags;

//        /// HWND->HWND__*
//        public IntPtr hwndTarget;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct BSMINFO
//    {
//        /// UINT->unsigned int
//        public uint cbSize;

//        /// HDESK->HDESK__*
//        public IntPtr hdesk;

//        /// HWND->HWND__*
//        public IntPtr hwnd;

//        /// LUID->_LUID
//        public LUID luid;
//    }

//    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
//    public struct DEVMODE
//    {
//        public const int CCHDEVICENAME = 32;
//        public const int CCHFORMNAME = 32;

//        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHDEVICENAME)]
//        [FieldOffset(0)]
//        public string dmDeviceName;
//        [FieldOffset(32)]
//        public Int16 dmSpecVersion;
//        [FieldOffset(34)]
//        public Int16 dmDriverVersion;
//        [FieldOffset(36)]
//        public Int16 dmSize;
//        [FieldOffset(38)]
//        public Int16 dmDriverExtra;
//        [FieldOffset(40)]
//        public Int32 dmFields;

//        [FieldOffset(44)]
//        Int16 dmOrientation;
//        [FieldOffset(46)]
//        Int16 dmPaperSize;
//        [FieldOffset(48)]
//        Int16 dmPaperLength;
//        [FieldOffset(50)]
//        Int16 dmPaperWidth;
//        [FieldOffset(52)]
//        Int16 dmScale;
//        [FieldOffset(54)]
//        Int16 dmCopies;
//        [FieldOffset(56)]
//        Int16 dmDefaultSource;
//        [FieldOffset(58)]
//        Int16 dmPrintQuality;

//        [FieldOffset(44)]
//        public POINTL dmPosition;
//        [FieldOffset(52)]
//        public Int32 dmDisplayOrientation;
//        [FieldOffset(56)]
//        public Int32 dmDisplayFixedOutput;

//        [FieldOffset(60)]
//        public short dmColor;
//        [FieldOffset(62)]
//        public short dmDuplex;
//        [FieldOffset(64)]
//        public short dmYResolution;
//        [FieldOffset(66)]
//        public short dmTTOption;
//        [FieldOffset(68)]
//        public short dmCollate;
//        [FieldOffset(72)]
//        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHFORMNAME)]
//        public string dmFormName;
//        [FieldOffset(102)]
//        public Int16 dmLogPixels;
//        [FieldOffset(104)]
//        public Int32 dmBitsPerPel;
//        [FieldOffset(108)]
//        public Int32 dmPelsWidth;
//        [FieldOffset(112)]
//        public Int32 dmPelsHeight;
//        [FieldOffset(116)]
//        public Int32 dmDisplayFlags;
//        [FieldOffset(116)]
//        public Int32 dmNup;
//        [FieldOffset(120)]
//        public Int32 dmDisplayFrequency;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct ACCEL
//    {
//        /// BYTE->unsigned char
//        public byte fVirt;

//        /// WORD->unsigned short
//        public ushort key;

//        /// WORD->unsigned short
//        public ushort cmd;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct RAWINPUTDEVICELIST
//    {
//        /// HANDLE->void*
//        public IntPtr hDevice;

//        /// DWORD->unsigned int
//        public uint dwType;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct MOUSEMOVEPOINT
//    {
//        /// int
//        public int x;

//        /// int
//        public int y;

//        /// DWORD->unsigned int
//        public uint time;

//        /// ULONG_PTR->unsigned int
//        public uint dwExtraInfo;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct SECURITY_ATTRIBUTES
//    {
//        /// DWORD->unsigned int
//        public uint nLength;

//        /// LPVOID->void*
//        public IntPtr lpSecurityDescriptor;

//        /// BOOL->int
//        [MarshalAs(UnmanagedType.Bool)]
//        public bool bInheritHandle;
//    }

//    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
//    public struct DISPLAY_DEVICE
//    {
//        /// DWORD->unsigned int
//        public uint cb;

//        /// WCHAR[32]
//        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
//        public string DeviceName;

//        /// WCHAR[128]
//        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
//        public string DeviceString;

//        /// DWORD->unsigned int
//        public uint StateFlags;

//        /// WCHAR[128]
//        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
//        public string DeviceID;

//        /// WCHAR[128]
//        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
//        public string DeviceKey;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct RAWINPUT
//    {
//        /// RAWINPUTHEADER->tagRAWINPUTHEADER
//        public RAWINPUTHEADER header;

//        /// Anonymous_d34c77ee_53b2_47a5_a97c_d5c2b29c8ee3
//        public RAW_INPUT_DATA data;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct SCROLLBARINFO
//    {
//        /// DWORD->unsigned int
//        public uint cbSize;

//        /// RECT->tagRECT
//        public RECT rcScrollBar;

//        /// int
//        public int dxyLineButton;

//        /// int
//        public int xyThumbTop;

//        /// int
//        public int xyThumbBottom;

//        /// int
//        public int reserved;

//        /// DWORD[6]
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.U4)]
//        public uint[] rgstate;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct MENUITEMINFO
//    {
//        /// UINT->unsigned int
//        public uint cbSize;

//        /// UINT->unsigned int
//        public uint fMask;

//        /// UINT->unsigned int
//        public uint fType;

//        /// UINT->unsigned int
//        public uint fState;

//        /// UINT->unsigned int
//        public uint wID;

//        /// HMENU->HMENU__*
//        public IntPtr hSubMenu;

//        /// HBITMAP->HBITMAP__*
//        public IntPtr hbmpChecked;

//        /// HBITMAP->HBITMAP__*
//        public IntPtr hbmpUnchecked;

//        /// ULONG_PTR->unsigned int
//        public uint dwItemData;

//        /// LPWSTR->WCHAR*
//        [MarshalAs(UnmanagedType.LPTStr)]
//        public string dwTypeData;

//        /// UINT->unsigned int
//        public uint cch;

//        /// HBITMAP->HBITMAP__*
//        public IntPtr hbmpItem;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct LASTINPUTINFO
//    {
//        /// UINT->unsigned int
//        public uint cbSize;

//        /// DWORD->unsigned int
//        public uint dwTime;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct GUITHREADINFO
//    {
//        /// DWORD->unsigned int
//        public uint cbSize;

//        /// DWORD->unsigned int
//        public uint flags;

//        /// HWND->HWND__*
//        public IntPtr hwndActive;

//        /// HWND->HWND__*
//        public IntPtr hwndFocus;

//        /// HWND->HWND__*
//        public IntPtr hwndCapture;

//        /// HWND->HWND__*
//        public IntPtr hwndMenuOwner;

//        /// HWND->HWND__*
//        public IntPtr hwndMoveSize;

//        /// HWND->HWND__*
//        public IntPtr hwndCaret;

//        /// RECT->tagRECT
//        public RECT rcCaret;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct TRACKMOUSEEVENT
//    {
//        /// DWORD->unsigned int
//        public uint cbSize;

//        /// DWORD->unsigned int
//        public uint dwFlags;

//        /// HWND->HWND__*
//        public IntPtr hwndTrack;

//        /// DWORD->unsigned int
//        public uint dwHoverTime;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct TITLEBARINFO
//    {
//        /// DWORD->unsigned int
//        public uint cbSize;

//        /// RECT->tagRECT
//        public RECT rcTitleBar;

//        /// DWORD[6]
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.U4)]
//        public uint[] rgstate;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct MONITORINFO
//    {
//        /// DWORD->unsigned int
//        public uint cbSize;

//        /// RECT->tagRECT
//        public RECT rcMonitor;

//        /// RECT->tagRECT
//        public RECT rcWork;

//        /// DWORD->unsigned int
//        public uint dwFlags;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct COMBOBOXINFO
//    {
//        /// DWORD->unsigned int
//        public uint cbSize;

//        /// RECT->tagRECT
//        public RECT rcItem;

//        /// RECT->tagRECT
//        public RECT rcButton;

//        /// DWORD->unsigned int
//        public uint stateButton;

//        /// HWND->HWND__*
//        public IntPtr hwndCombo;

//        /// HWND->HWND__*
//        public IntPtr hwndItem;

//        /// HWND->HWND__*
//        public IntPtr hwndList;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct MENUBARINFO
//    {
//        /// DWORD->unsigned int
//        public uint cbSize;

//        /// RECT->tagRECT
//        public RECT rcBar;

//        /// HMENU->HMENU__*
//        public IntPtr hMenu;

//        /// HWND->HWND__*
//        public IntPtr hwndMenu;

//        /// fBarFocused : 1
//        /// fFocused : 1
//        public uint bitvector1;

//        public uint fBarFocused
//        {
//            get
//            {
//                return bitvector1 & 1u;
//            }

//            set
//            {
//                bitvector1 = value | bitvector1;
//            }
//        }

//        public uint fFocused
//        {
//            get
//            {
//                return (bitvector1 & 2u) / 2;
//            }

//            set
//            {
//                bitvector1 = (value * 2) | bitvector1;
//            }
//        }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct ALTTABINFO
//    {
//        /// DWORD->unsigned int
//        public uint cbSize;

//        /// int
//        public int cItems;

//        /// int
//        public int cColumns;

//        /// int
//        public int cRows;

//        /// int
//        public int iColFocus;

//        /// int
//        public int iRowFocus;

//        /// int
//        public int cxItem;

//        /// int
//        public int cyItem;

//        /// POINT->tagPOINT
//        public POINT ptStart;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct WINDOWINFO
//    {
//        /// DWORD->unsigned int
//        public uint cbSize;

//        /// RECT->tagRECT
//        public RECT rcWindow;

//        /// RECT->tagRECT
//        public RECT rcClient;

//        /// DWORD->unsigned int
//        public uint dwStyle;

//        /// DWORD->unsigned int
//        public uint dwExStyle;

//        /// DWORD->unsigned int
//        public uint dwWindowStatus;

//        /// UINT->unsigned int
//        public uint cxWindowBorders;

//        /// UINT->unsigned int
//        public uint cyWindowBorders;

//        /// ATOM->WORD->unsigned short
//        public ushort atomWindowType;

//        /// WORD->unsigned short
//        public ushort wCreatorVersion;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct SCROLLINFO
//    {
//        /// UINT->unsigned int
//        public uint cbSize;

//        /// UINT->unsigned int
//        public uint fMask;

//        /// int
//        public int nMin;

//        /// int
//        public int nMax;

//        /// UINT->unsigned int
//        public uint nPage;

//        /// int
//        public int nPos;

//        /// int
//        public int nTrackPos;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct CURSORINFO
//    {
//        /// DWORD->unsigned int
//        public uint cbSize;

//        /// DWORD->unsigned int
//        public uint flags;

//        /// HCURSOR->HICON->HICON__*
//        public IntPtr hCursor;

//        /// POINT->tagPOINT
//        public POINT ptScreenPos;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct FLASHWINFO
//    {
//        /// UINT->unsigned int
//        public uint cbSize;

//        /// HWND->HWND__*
//        public IntPtr hwnd;

//        /// DWORD->unsigned int
//        public uint dwFlags;

//        /// UINT->unsigned int
//        public uint uCount;

//        /// DWORD->unsigned int
//        public uint dwTimeout;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct MENUINFO
//    {
//        /// DWORD->unsigned int
//        public uint cbSize;

//        /// DWORD->unsigned int
//        public uint fMask;

//        /// DWORD->unsigned int
//        public uint dwStyle;

//        /// UINT->unsigned int
//        public uint cyMax;

//        /// HBRUSH->HBRUSH__*
//        public IntPtr hbrBack;

//        /// DWORD->unsigned int
//        public uint dwContextHelpID;

//        /// ULONG_PTR->unsigned int
//        public uint dwMenuData;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct DRAWTEXTPARAMS
//    {
//        /// UINT->unsigned int
//        public uint cbSize;

//        /// int
//        public int iTabLength;

//        /// int
//        public int iLeftMargin;

//        /// int
//        public int iRightMargin;

//        /// UINT->unsigned int
//        public uint uiLengthDrawn;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct INPUT
//    {
//        /// DWORD->unsigned int
//        public uint type;

//        /// Anonymous_dccf47da_5155_438b_92bc_41adbefe840c
//        public INPUT_DATA inputData;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct DLGTEMPLATE
//    {
//        /// DWORD->unsigned int
//        public uint style;

//        /// DWORD->unsigned int
//        public uint dwExtendedStyle;

//        /// WORD->unsigned short
//        public ushort cdit;

//        /// short
//        public short x;

//        /// short
//        public short y;

//        /// short
//        public short cx;

//        /// short
//        public short cy;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct ICONINFO
//    {
//        /// BOOL->int
//        [MarshalAs(UnmanagedType.Bool)]
//        public bool fIcon;

//        /// DWORD->unsigned int
//        public uint xHotspot;

//        /// DWORD->unsigned int
//        public uint yHotspot;

//        /// HBITMAP->HBITMAP__*
//        public IntPtr hbmMask;

//        /// HBITMAP->HBITMAP__*
//        public IntPtr hbmColor;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct TPMPARAMS
//    {
//        /// UINT->unsigned int
//        public uint cbSize;

//        /// RECT->tagRECT
//        public RECT rcExclude;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct CONVINFO
//    {
//        /// DWORD->unsigned int
//        public uint cb;

//        /// DWORD_PTR->ULONG_PTR->unsigned int
//        public uint hUser;

//        /// HCONV->HCONV__*
//        public IntPtr hConvPartner;

//        /// HSZ->HSZ__*
//        public IntPtr hszSvcPartner;

//        /// HSZ->HSZ__*
//        public IntPtr hszServiceReq;

//        /// HSZ->HSZ__*
//        public IntPtr hszTopic;

//        /// HSZ->HSZ__*
//        public IntPtr hszItem;

//        /// UINT->unsigned int
//        public uint wFmt;

//        /// UINT->unsigned int
//        public uint wType;

//        /// UINT->unsigned int
//        public uint wStatus;

//        /// UINT->unsigned int
//        public uint wConvst;

//        /// UINT->unsigned int
//        public uint wLastError;

//        /// HCONVLIST->HCONVLIST__*
//        public IntPtr hConvList;

//        /// CONVCONTEXT->tagCONVCONTEXT
//        public CONVCONTEXT ConvCtxt;

//        /// HWND->HWND__*
//        public IntPtr hwnd;

//        /// HWND->HWND__*
//        public IntPtr hwndPartner;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct CONVCONTEXT
//    {
//        /// UINT->unsigned int
//        public uint cb;

//        /// UINT->unsigned int
//        public uint wFlags;

//        /// UINT->unsigned int
//        public uint wCountryID;

//        /// int
//        public int iCodePage;

//        /// DWORD->unsigned int
//        public uint dwLangID;

//        /// DWORD->unsigned int
//        public uint dwSecurity;

//        /// SECURITY_QUALITY_OF_SERVICE->_SECURITY_QUALITY_OF_SERVICE
//        public SECURITY_QUALITY_OF_SERVICE qos;
//    }

//    [StructLayout(LayoutKind.Explicit)]
//    public struct PAGE_DATA
//    {
//        /// Anonymous_865d3c92_fe8c_4ee6_9601_a9eb2536957e
//        [FieldOffset(0)]
//        public PAGE_SETUP pageSetup;

//        /// Anonymous_1b5f787e_41ca_472c_8595_3484490ffe0c
//        [FieldOffset(0)]
//        public PAGE_DISPLAY pageDisplay;
//    }

//    [StructLayout(LayoutKind.Explicit)]
//    public struct DISPLAY_DATA
//    {
//        /// DWORD->unsigned int
//        [FieldOffset(0)]
//        public uint dmDisplayFlags;

//        /// DWORD->unsigned int
//        [FieldOffset(0)]
//        public uint dmNup;
//    }

//    [StructLayout(LayoutKind.Explicit)]
//    public struct RAW_INPUT_DATA
//    {
//        /// RAWMOUSE->tagRAWMOUSE
//        [FieldOffset(0)]
//        public RAWMOUSE mouse;

//        /// RAWKEYBOARD->tagRAWKEYBOARD
//        [FieldOffset(0)]
//        public RAWKEYBOARD keyboard;

//        /// RAWHID->tagRAWHID
//        [FieldOffset(0)]
//        public RAWHID hid;
//    }

//    [StructLayout(LayoutKind.Explicit)]
//    public struct INPUT_DATA
//    {
//        /// MOUSEINPUT->tagMOUSEINPUT
//        [FieldOffset(0)]
//        public MOUSEINPUT mi;

//        /// KEYBDINPUT->tagKEYBDINPUT
//        [FieldOffset(0)]
//        public KEYBDINPUT ki;

//        /// HARDWAREINPUT->tagHARDWAREINPUT
//        [FieldOffset(0)]
//        public HARDWAREINPUT hi;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct LUID
//    {
//        /// DWORD->unsigned int
//        public uint LowPart;

//        /// LONG->int
//        public int HighPart;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct RAWINPUTHEADER
//    {
//        /// DWORD->unsigned int
//        public uint dwType;

//        /// DWORD->unsigned int
//        public uint dwSize;

//        /// HANDLE->void*
//        public IntPtr hDevice;

//        /// WPARAM->UINT_PTR->unsigned int
//        public uint wParam;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct PAGE_SETUP
//    {
//        /// short
//        public short dmOrientation;

//        /// short
//        public short dmPaperSize;

//        /// short
//        public short dmPaperLength;

//        /// short
//        public short dmPaperWidth;

//        /// short
//        public short dmScale;

//        /// short
//        public short dmCopies;

//        /// short
//        public short dmDefaultSource;

//        /// short
//        public short dmPrintQuality;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct PAGE_DISPLAY
//    {
//        /// POINTL->_POINTL
//        public POINTL dmPosition;

//        /// DWORD->unsigned int
//        public uint dmDisplayOrientation;

//        /// DWORD->unsigned int
//        public uint dmDisplayFixedOutput;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct RAWMOUSE
//    {
//        /// USHORT->unsigned short
//        public ushort usFlags;

//        /// Anonymous_4e912b36_f5ab_4eb4_804f_6587b7a78602
//        public BUTTONS buttons;

//        /// ULONG->unsigned int
//        public uint ulRawButtons;

//        /// LONG->int
//        public int lLastX;

//        /// LONG->int
//        public int lLastY;

//        /// ULONG->unsigned int
//        public uint ulExtraInformation;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct RAWKEYBOARD
//    {
//        /// USHORT->unsigned short
//        public ushort MakeCode;

//        /// USHORT->unsigned short
//        public ushort Flags;

//        /// USHORT->unsigned short
//        public ushort Reserved;

//        /// USHORT->unsigned short
//        public ushort VKey;

//        /// UINT->unsigned int
//        public uint Message;

//        /// ULONG->unsigned int
//        public uint ExtraInformation;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct RAWHID
//    {
//        /// DWORD->unsigned int
//        public uint dwSizeHid;

//        /// DWORD->unsigned int
//        public uint dwCount;

//        /// BYTE[1]
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
//        public byte[] bRawData;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct MOUSEINPUT
//    {
//        /// LONG->int
//        public int dx;

//        /// LONG->int
//        public int dy;

//        /// DWORD->unsigned int
//        public uint mouseData;

//        /// DWORD->unsigned int
//        public uint dwFlags;

//        /// DWORD->unsigned int
//        public uint time;

//        /// ULONG_PTR->unsigned int
//        public uint dwExtraInfo;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct KEYBDINPUT
//    {
//        /// WORD->unsigned short
//        public ushort wVk;

//        /// WORD->unsigned short
//        public ushort wScan;

//        /// DWORD->unsigned int
//        public uint dwFlags;

//        /// DWORD->unsigned int
//        public uint time;

//        /// ULONG_PTR->unsigned int
//        public uint dwExtraInfo;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct HARDWAREINPUT
//    {
//        /// DWORD->unsigned int
//        public uint uMsg;

//        /// WORD->unsigned short
//        public ushort wParamL;

//        /// WORD->unsigned short
//        public ushort wParamH;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct HELPINFO
//    {
//        /// UINT->unsigned int
//        public uint cbSize;

//        /// int
//        public int iContextType;

//        /// int
//        public int iCtrlId;

//        /// HANDLE->void*
//        public IntPtr hItemHandle;

//        /// DWORD_PTR->ULONG_PTR->unsigned int
//        public uint dwContextId;

//        /// POINT->tagPOINT
//        public POINT MousePos;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct POINTL
//    {
//        /// LONG->int
//        public int x;

//        /// LONG->int
//        public int y;
//    }

//    [StructLayout(LayoutKind.Explicit)]
//    public struct BUTTONS
//    {
//        /// ULONG->unsigned int
//        [FieldOffset(0)]
//        public uint ulButtons;

//        /// Anonymous_500af501_b9b4_43cc_ad24_07d5d9d24897
//        [FieldOffset(0)]
//        public BUTTON_DATA buttonData;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct BUTTON_DATA
//    {
//        /// USHORT->unsigned short
//        public ushort usButtonFlags;

//        /// USHORT->unsigned short
//        public ushort usButtonData;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct MSLLHOOKSTRUCT
//    {
//        public POINT pt;
//        public int mouseData;
//        public int flags;
//        public int time;
//        public UIntPtr dwExtraInfo;
//    }

//    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
//    public class TEXTMETRIC
//    {
//        public int tmHeight;
//        public int tmAscent;
//        public int tmDescent;
//        public int tmInternalLeading;
//        public int tmExternalLeading;
//        public int tmAveCharWidth;
//        public int tmMaxCharWidth;
//        public int tmWeight;
//        public int tmOverhang;
//        public int tmDigitizedAspectX;
//        public int tmDigitizedAspectY;
//        public byte tmFirstChar;
//        public byte tmLastChar;
//        public byte tmDefaultChar;
//        public byte tmBreakChar;
//        public byte tmItalic;
//        public byte tmUnderlined;
//        public byte tmStruckOut;
//        public byte tmPitchAndFamily;
//        public byte tmCharSet;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct COLORREF
//    {
//        public uint ColorDWORD;

//        public COLORREF(Color color)
//        {
//            ColorDWORD = color.R + (((uint)color.G) << 8) + (((uint)color.B) << 16);
//        }

//        public Color GetColor()
//        {
//            return Color.FromArgb(
//                (int)(0x000000FFU & ColorDWORD),
//                (int)(0x0000FF00U & ColorDWORD) >> 8, (int)(0x00FF0000U & ColorDWORD) >> 16);
//        }

//        public void SetColor(Color color)
//        {
//            ColorDWORD = color.R + (((uint)color.G) << 8) + (((uint)color.B) << 16);
//        }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct DEV_BROADCAST_HDR
//    {
//        /// DWORD->unsigned int
//        public uint dbch_size;

//        /// DWORD->unsigned int
//        public DBT dbch_devicetype;

//        /// DWORD->unsigned int
//        public uint dbch_reserved;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct DLGITEMTEMPLATE
//    {
//        /// DWORD->unsigned int
//        public uint style;

//        /// DWORD->unsigned int
//        public uint dwExtendedStyle;

//        /// short
//        public short x;

//        /// short
//        public short y;

//        /// short
//        public short cx;

//        /// short
//        public short cy;

//        /// WORD->unsigned short
//        public ushort id;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct DLGITEMTEMPLATEEX
//    {
//        /// DWORD->unsigned int
//        public uint helpID;

//        /// DWORD->unsigned int
//        public uint exStyle;

//        /// DWORD->unsigned int
//        public uint style;

//        /// short
//        public short x;

//        /// short
//        public short y;

//        /// short
//        public short cx;

//        /// short
//        public short cy;

//        /// DWORD->unsigned int
//        public uint id;

//        /// short[]
//        public short[] windowClass;

//        /// short[]
//        public short[] title;

//        /// WORD->unsigned short
//        public ushort extraCount;
//    }

//    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
//    public struct DLGTEMPLATEEX
//    {
//        /// WORD->unsigned short
//        public ushort dlgVer;

//        /// WORD->unsigned short
//        public ushort signature;

//        /// DWORD->unsigned int
//        public uint helpID;

//        /// DWORD->unsigned int
//        public uint exStyle;

//        /// DWORD->unsigned int
//        public uint style;

//        /// WORD->unsigned short
//        public ushort cDlgItems;

//        /// short
//        public short x;

//        /// short
//        public short y;

//        /// short
//        public short cx;

//        /// short
//        public short cy;

//        /// short[]
//        public short[] menu;

//        /// short[]
//        public short[] windowClass;

//        /// WCHAR[]
//        public string title;

//        /// WORD->unsigned short
//        public ushort pointsize;

//        /// WORD->unsigned short
//        public ushort weight;

//        /// BYTE->unsigned char
//        public byte italic;

//        /// BYTE->unsigned char
//        public byte charset;

//        /// WCHAR[]
//        public string typeface;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct USEROBJECTFLAGS
//    {
//        /// BOOL->int
//        [MarshalAs(UnmanagedType.Bool)]
//        public bool fInherit;

//        /// BOOL->int
//        [MarshalAs(UnmanagedType.Bool)]
//        public bool fReserved;

//        /// DWORD->unsigned int
//        public uint dwFlags;
//    }

//    [StructLayout(LayoutKind.Explicit)]
//    public struct MOUSE_KEYBOARD_HID
//    {
//        /// RID_DEVICE_INFO_MOUSE->tagRID_DEVICE_INFO_MOUSE
//        [FieldOffset(0)]
//        public RID_DEVICE_INFO_MOUSE mouse;

//        /// RID_DEVICE_INFO_KEYBOARD->tagRID_DEVICE_INFO_KEYBOARD
//        [FieldOffset(0)]
//        public RID_DEVICE_INFO_KEYBOARD keyboard;

//        /// RID_DEVICE_INFO_HID->tagRID_DEVICE_INFO_HID
//        [FieldOffset(0)]
//        public RID_DEVICE_INFO_HID hid;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct RID_DEVICE_INFO
//    {
//        /// DWORD->unsigned int
//        public uint cbSize;

//        /// DWORD->unsigned int
//        public uint dwType;

//        /// Anonymous_b3e3df38_776a_40ee_9539_1851bbc299c6
//        public MOUSE_KEYBOARD_HID mouseKeyboardHid;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct RID_DEVICE_INFO_MOUSE
//    {
//        /// DWORD->unsigned int
//        public uint dwId;

//        /// DWORD->unsigned int
//        public uint dwNumberOfButtons;

//        /// DWORD->unsigned int
//        public uint dwSampleRate;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct RID_DEVICE_INFO_KEYBOARD
//    {
//        /// DWORD->unsigned int
//        public uint dwType;

//        /// DWORD->unsigned int
//        public uint dwSubType;

//        /// DWORD->unsigned int
//        public uint dwKeyboardMode;

//        /// DWORD->unsigned int
//        public uint dwNumberOfFunctionKeys;

//        /// DWORD->unsigned int
//        public uint dwNumberOfIndicators;

//        /// DWORD->unsigned int
//        public uint dwNumberOfKeysTotal;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct RID_DEVICE_INFO_HID
//    {
//        /// DWORD->unsigned int
//        public uint dwVendorId;

//        /// DWORD->unsigned int
//        public uint dwProductId;

//        /// DWORD->unsigned int
//        public uint dwVersionNumber;

//        /// USHORT->unsigned short
//        public ushort usUsagePage;

//        /// USHORT->unsigned short
//        public ushort usUsage;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct ACCESSTIMEOUT
//    {
//        /// UINT->unsigned int
//        public uint cbSize;

//        /// DWORD->unsigned int
//        public uint dwFlags;

//        /// DWORD->unsigned int
//        public uint iTimeOutMSec;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public struct AUDIODESCRIPTION
//    {
//        /// UINT->unsigned int
//        public uint cbSize;

//        /// BOOL->int
//        [MarshalAs(UnmanagedType.Bool)]
//        public bool Enabled;

//        /// LCID->DWORD->unsigned int
//        public uint Locale;
//    }

//    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
//    public struct FILTERKEYS
//    {

//        /// UINT->unsigned int
//        public uint cbSize;

//        /// DWORD->unsigned int
//        public uint dwFlags;

//        /// DWORD->unsigned int
//        public uint iWaitMSec;

//        /// DWORD->unsigned int
//        public uint iDelayMSec;

//        /// DWORD->unsigned int
//        public uint iRepeatMSec;

//        /// DWORD->unsigned int
//        public uint iBounceMSec;
//    }

//    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
//    public struct HIGHCONTRAST
//    {

//        /// UINT->unsigned int
//        public uint cbSize;

//        /// DWORD->unsigned int
//        public uint dwFlags;

//        /// LPWSTR->WCHAR*
//        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPTStr)]
//        public string lpszDefaultScheme;
//    }

//    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
//    public struct MOUSEKEYS
//    {

//        /// UINT->unsigned int
//        public uint cbSize;

//        /// DWORD->unsigned int
//        public uint dwFlags;

//        /// DWORD->unsigned int
//        public uint iMaxSpeed;

//        /// DWORD->unsigned int
//        public uint iTimeToMaxSpeed;

//        /// DWORD->unsigned int
//        public uint iCtrlSpeed;

//        /// DWORD->unsigned int
//        public uint dwReserved1;

//        /// DWORD->unsigned int
//        public uint dwReserved2;
//    }

//    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
//    public struct SOUNDSENTRY
//    {

//        /// UINT->unsigned int
//        public uint cbSize;

//        /// DWORD->unsigned int
//        public uint dwFlags;

//        /// DWORD->unsigned int
//        public uint iFSTextEffect;

//        /// DWORD->unsigned int
//        public uint iFSTextEffectMSec;

//        /// DWORD->unsigned int
//        public uint iFSTextEffectColorBits;

//        /// DWORD->unsigned int
//        public uint iFSGrafEffect;

//        /// DWORD->unsigned int
//        public uint iFSGrafEffectMSec;

//        /// DWORD->unsigned int
//        public uint iFSGrafEffectColor;

//        /// DWORD->unsigned int
//        public uint iWindowsEffect;

//        /// DWORD->unsigned int
//        public uint iWindowsEffectMSec;

//        /// LPWSTR->WCHAR*
//        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPTStr)]
//        public string lpszWindowsEffectDLL;

//        /// DWORD->unsigned int
//        public uint iWindowsEffectOrdinal;
//    }

//    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
//    public struct STICKYKEYS
//    {

//        /// UINT->unsigned int
//        public uint cbSize;

//        /// DWORD->unsigned int
//        public uint dwFlags;
//    }


//    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
//    public struct TOGGLEKEYS
//    {

//        /// UINT->unsigned int
//        public uint cbSize;

//        /// DWORD->unsigned int
//        public uint dwFlags;
//    }

//    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
//    public struct ICONMETRICS
//    {

//        /// UINT->unsigned int
//        public uint cbSize;

//        /// int
//        public int iHorzSpacing;

//        /// int
//        public int iVertSpacing;

//        /// int
//        public int iTitleWrap;

//        /// LOGFONTW->tagLOGFONTW
//        public LOGFONT lfFont;
//    }

//    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
//    public struct ANIMATIONINFO
//    {

//        /// UINT->unsigned int
//        public uint cbSize;

//        /// int
//        public int iMinAnimate;
//    }

//    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
//    public struct MINIMIZEDMETRICS
//    {

//        /// UINT->unsigned int
//        public uint cbSize;

//        /// int
//        public int iWidth;

//        /// int
//        public int iHorzGap;

//        /// int
//        public int iVertGap;

//        /// int
//        public int iArrange;
//    }

//    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
//    public struct MENUITEMTEMPLATEHEADER
//    {

//        /// WORD->unsigned short
//        public ushort versionNumber;

//        /// WORD->unsigned short
//        public ushort offset;
//    }

//    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
//    public struct MENUITEMTEMPLATE
//    {

//        /// WORD->unsigned short
//        public ushort mtOption;

//        /// WORD->unsigned short
//        public ushort mtID;

//        /// WCHAR[1]
//        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 1)]
//        public string mtString;
//    }

//    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
//    public struct NONCLIENTMETRICS
//    {

//        /// UINT->unsigned int
//        public uint cbSize;

//        /// int
//        public int iBorderWidth;

//        /// int
//        public int iScrollWidth;

//        /// int
//        public int iScrollHeight;

//        /// int
//        public int iCaptionWidth;

//        /// int
//        public int iCaptionHeight;

//        /// LOGFONTW->tagLOGFONTW
//        public LOGFONT lfCaptionFont;

//        /// int
//        public int iSmCaptionWidth;

//        /// int
//        public int iSmCaptionHeight;

//        /// LOGFONTW->tagLOGFONTW
//        public LOGFONT lfSmCaptionFont;

//        /// int
//        public int iMenuWidth;

//        /// int
//        public int iMenuHeight;

//        /// LOGFONTW->tagLOGFONTW
//        public LOGFONT lfMenuFont;

//        /// LOGFONTW->tagLOGFONTW
//        public LOGFONT lfStatusFont;

//        /// LOGFONTW->tagLOGFONTW
//        public LOGFONT lfMessageFont;

//        /// int
//        public int iPaddedBorderWidth;
//    }

//    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
//    public struct SECURITY_DESCRIPTOR
//    {

//        /// BYTE->unsigned char
//        public byte Revision;

//        /// BYTE->unsigned char
//        public byte Sbz1;

//        /// SECURITY_DESCRIPTOR_CONTROL->WORD->unsigned short
//        public ushort Control;

//        /// PSID->PVOID->void*
//        public System.IntPtr Owner;

//        /// PSID->PVOID->void*
//        public System.IntPtr Group;

//        /// PACL->ACL*
//        public System.IntPtr Sacl;

//        /// PACL->ACL*
//        public System.IntPtr Dacl;
//    }

//    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
//    public struct ACL
//    {

//        /// BYTE->unsigned char
//        public byte AclRevision;

//        /// BYTE->unsigned char
//        public byte Sbz1;

//        /// WORD->unsigned short
//        public ushort AclSize;

//        /// WORD->unsigned short
//        public ushort AceCount;

//        /// WORD->unsigned short
//        public ushort Sbz2;
//    }


//    /// <summary>
//    ///     The <see cref="LOGFONT" /> structure defines the attributes of a font.
//    /// </summary>
//    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
//    public struct LOGFONT
//    {
//        /// <summary>
//        ///     <para>
//        ///         The height, in logical units, of the font's character cell or character. The character height value (also known as the em height) is the
//        ///         character cell height value minus the internal-leading value. The font mapper interprets the value specified in <see cref="lfHeight" /> in
//        ///         the following manner.
//        ///     </para>
//        ///     <list type="table">
//        ///         <item>
//        ///             <term>&gt; 0</term>
//        ///             <description>The font mapper transforms this value into device units and matches it against the cell height of the available fonts.</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>0</term>
//        ///             <description>The font mapper uses a default height value when it searches for a match.</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>&lt; 0</term>
//        ///             <description>
//        ///                 The font mapper transforms this value into device units and matches its absolute value against the character height of the
//        ///                 available fonts.
//        ///             </description>
//        ///         </item>
//        ///     </list>
//        ///     <para>For all height comparisons, the font mapper looks for the largest font that does not exceed the requested size.</para>
//        ///     <para>This mapping occurs when the font is used for the first time.</para>
//        ///     <para>For the MM_TEXT mapping mode, you can use the following formula to specify a height for a font with a specified point size:</para>
//        /// </summary>
//        public int lfHeight;

//        /// <summary>
//        ///     The average width, in logical units, of characters in the font. If <see cref="lfWidth" /> is zero, the aspect ratio of the device is matched
//        ///     against the digitization aspect ratio of the available fonts to find the closest match, determined by the absolute value of the difference.
//        /// </summary>
//        public int lfWidth;

//        /// <summary>
//        ///     <para>
//        ///         The angle, in tenths of degrees, between the escapement vector and the x-axis of the device. The escapement vector is parallel to the base
//        ///         line of a row of text.
//        ///     </para>
//        ///     <para>
//        ///         When the graphics mode is set to GM_ADVANCED, you can specify the escapement angle of the string independently of the orientation angle of
//        ///         the string's characters.
//        ///     </para>
//        ///     <para>
//        ///         When the graphics mode is set to GM_COMPATIBLE, <see cref="lfEscapement" /> specifies both the escapement and orientation. You should set
//        ///         <see cref="lfEscapement" /> and <see cref="lfOrientation" /> to the same value.
//        ///     </para>
//        /// </summary>
//        public int lfEscapement;

//        /// <summary>The angle, in tenths of degrees, between each character's base line and the x-axis of the device.</summary>
//        public int lfOrientation;

//        /// <summary>
//        ///     <para>
//        ///         The weight of the font in the range 0 through 1000. For example, 400 is normal and 700 is bold. If this value is zero, a default weight is
//        ///         used.
//        ///     </para>
//        ///     <para>The following values are defined for convenience.</para>
//        ///     <list type="table">
//        ///         <item>
//        ///             <term>FW_DONTCARE</term>
//        ///             <description>0</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>FW_THIN</term>
//        ///             <description>100</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>FW_EXTRALIGHT</term>
//        ///             <description>200</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>FW_ULTRALIGHT</term>
//        ///             <description>200</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>FW_LIGHT</term>
//        ///             <description>300</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>FW_NORMAL</term>
//        ///             <description>400</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>FW_REGULAR</term>
//        ///             <description>400</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>FW_MEDIUM</term>
//        ///             <description>500</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>FW_SEMIBOLD</term>
//        ///             <description>600</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>FW_DEMIBOLD</term>
//        ///             <description>600</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>FW_BOLD</term>
//        ///             <description>700</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>FW_EXTRABOLD</term>
//        ///             <description>800</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>FW_ULTRABOLD</term>
//        ///             <description>800</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>FW_HEAVY</term>
//        ///             <description>900</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>FW_BLACK</term>
//        ///             <description>900</description>
//        ///         </item>
//        ///     </list>
//        /// </summary>
//        public FW lfWeight;

//        /// <summary>An italic font if set to TRUE.</summary>
//        [MarshalAs(UnmanagedType.U1)]
//        public bool lfItalic;

//        /// <summary>An underlined font if set to TRUE.</summary>
//        [MarshalAs(UnmanagedType.U1)]
//        public bool lfUnderline;

//        /// <summary>A strikeout font if set to TRUE.</summary>
//        [MarshalAs(UnmanagedType.U1)]
//        public bool lfStrikeOut;

//        /// <summary>
//        ///     <para>The character set. The following values are predefined.</para>
//        ///     <list type="table"></list>
//        ///     <para>Korean language edition of Windows:</para>
//        ///     <list type="table"></list>
//        ///     <para>Middle East language edition of Windows:</para>
//        ///     <list type="table"></list>
//        ///     <para>Thai language edition of Windows:</para>
//        ///     <list type="table"></list>
//        ///     <para>The OEM_CHARSET value specifies a character set that is operating-system dependent.</para>
//        ///     <para>
//        ///         DEFAULT_CHARSET is set to a value based on the current system locale. For example, when the system locale is English (United States), it is
//        ///         set as ANSI_CHARSET.
//        ///     </para>
//        ///     <para>
//        ///         Fonts with other character sets may exist in the operating system. If an application uses a font with an unknown character set, it should not
//        ///         attempt to translate or interpret strings that are rendered with that font.
//        ///     </para>
//        ///     <para>
//        ///         This parameter is important in the font mapping process. To ensure consistent results, specify a specific character set. If you specify a
//        ///         typeface name in the <see cref="lfFaceName" /> member, make sure that the <see cref="lfCharSet" /> value matches the character set of the
//        ///         typeface specified in <see cref="lfFaceName" />.
//        ///     </para>
//        /// </summary>
//        public CHARSET lfCharSet;

//        /// <summary>
//        ///     <para>
//        ///         The output precision. The output precision defines how closely the output must match the requested font's height, width, character
//        ///         orientation, escapement, pitch, and font type. It can be one of the following values.
//        ///     </para>
//        ///     <list type="table">
//        ///         <item>
//        ///             <term>OUT_CHARACTER_PRECIS</term>
//        ///             <description>Not used.</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>OUT_DEFAULT_PRECIS</term>
//        ///             <description>Specifies the default font mapper behavior.</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>OUT_DEVICE_PRECIS</term>
//        ///             <description>Instructs the font mapper to choose a Device font when the system contains multiple fonts with the same name.</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>OUT_OUTLINE_PRECIS</term>
//        ///             <description>This value instructs the font mapper to choose from TrueType and other outline-based fonts.</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>OUT_PS_ONLY_PRECIS</term>
//        ///             <description>
//        ///                 Instructs the font mapper to choose from only PostScript fonts. If there are no PostScript fonts installed in the system, the font
//        ///                 mapper returns to default behavior.
//        ///             </description>
//        ///         </item>
//        ///         <item>
//        ///             <term>OUT_RASTER_PRECIS</term>
//        ///             <description>Instructs the font mapper to choose a raster font when the system contains multiple fonts with the same name.</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>OUT_STRING_PRECIS</term>
//        ///             <description>This value is not used by the font mapper, but it is returned when raster fonts are enumerated.</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>OUT_STROKE_PRECIS</term>
//        ///             <description>
//        ///                 This value is not used by the font mapper, but it is returned when TrueType, other outline-based fonts, and vector fonts are
//        ///                 enumerated.
//        ///             </description>
//        ///         </item>
//        ///         <item>
//        ///             <term>OUT_TT_ONLY_PRECIS</term>
//        ///             <description>
//        ///                 Instructs the font mapper to choose from only TrueType fonts. If there are no TrueType fonts installed in the system, the font mapper
//        ///                 returns to default behavior.
//        ///             </description>
//        ///         </item>
//        ///         <item>
//        ///             <term>OUT_TT_PRECIS</term>
//        ///             <description>Instructs the font mapper to choose a TrueType font when the system contains multiple fonts with the same name.</description>
//        ///         </item>
//        ///     </list>
//        ///     <para>
//        ///         Applications can use the OUT_DEVICE_PRECIS, OUT_RASTER_PRECIS, OUT_TT_PRECIS, and OUT_PS_ONLY_PRECIS values to control how the font mapper
//        ///         chooses a font when the operating system contains more than one font with a specified name. For example, if an operating system contains a
//        ///         font named Symbol in raster and TrueType form, specifying OUT_TT_PRECIS forces the font mapper to choose the TrueType version. Specifying
//        ///         OUT_TT_ONLY_PRECIS forces the font mapper to choose a TrueType font, even if it must substitute a TrueType font of another name.
//        ///     </para>
//        /// </summary>
//        public PRECIS lfOutPrecision;

//        /// <summary>The clipping precision. The clipping precision defines how to clip characters that are partially outside the clipping region.</summary>
//        public CLIP lfClipPrecision;

//        /// <summary>
//        ///     <para>
//        ///         The output quality. The output quality defines how carefully the graphics device interface (GDI) must attempt to match the logical-font
//        ///         attributes to those of an actual physical font. It can be one of the following values.
//        ///     </para>
//        ///     <list type="table">
//        ///         <item>
//        ///             <term>ANTIALIASED_QUALITY</term>
//        ///             <description>Font is always antialiased if the font supports it and the size of the font is not too small or too large.</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>CLEARTYPE_QUALITY</term>
//        ///             <description>If set, text is rendered (when possible) using ClearType antialiasing method. See Remarks for more information.</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>DEFAULT_QUALITY</term>
//        ///             <description>Appearance of the font does not matter.</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>DRAFT_QUALITY</term>
//        ///             <description>
//        ///                 Appearance of the font is less important than when PROOF_QUALITY is used. For GDI raster fonts, scaling is enabled, which means that
//        ///                 more font sizes are available, but the quality may be lower. Bold, italic, underline, and strikeout fonts are synthesized if
//        ///                 necessary.
//        ///             </description>
//        ///         </item>
//        ///         <item>
//        ///             <term>NONANTIALIASED_QUALITY</term>
//        ///             <description>Font is never antialiased.</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>PROOF_QUALITY</term>
//        ///             <description>
//        ///                 Character quality of the font is more important than exact matching of the logical-font attributes. For GDI raster fonts, scaling is
//        ///                 disabled and the font closest in size is chosen. Although the chosen font size may not be mapped exactly when PROOF_QUALITY is used,
//        ///                 the quality of the font is high and there is no distortion of appearance. Bold, italic, underline, and strikeout fonts are
//        ///                 synthesized if necessary.
//        ///             </description>
//        ///         </item>
//        ///     </list>
//        ///     <para>
//        ///         If neither ANTIALIASED_QUALITY nor NONANTIALIASED_QUALITY is selected, the font is antialiased only if the user chooses smooth screen fonts
//        ///         in Control Panel.
//        ///     </para>
//        /// </summary>
//        public QUALITY lfQuality;

//        /// <summary>
//        ///     <para>The pitch and family of the font. The two low-order bits specify the pitch of the font and can be one of the following values.</para>
//        ///     <para>Bits 4 through 7 of the member specify the font family and can be one of the following values.</para>
//        ///     <para>The proper value can be obtained by using the Boolean OR operator to join one pitch constant with one family constant.</para>
//        ///     <para>
//        ///         Font families describe the look of a font in a general way. They are intended for specifying fonts when the exact typeface desired is not
//        ///         available. The values for font families are as follows.
//        ///     </para>
//        ///     <list type="table">
//        ///         <item>
//        ///             <term>FF_DECORATIVE</term>
//        ///             <description>Novelty fonts. Old English is an example.</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>FF_DONTCARE</term>
//        ///             <description>Use default font.</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>FF_MODERN</term>
//        ///             <description>
//        ///                 Fonts with constant stroke width (monospace), with or without serifs. Monospace fonts are usually modern. Pica, Elite, and
//        ///                 CourierNew are examples.
//        ///             </description>
//        ///         </item>
//        ///         <item>
//        ///             <term>FF_ROMAN</term>
//        ///             <description>Fonts with variable stroke width (proportional) and with serifs. MS Serif is an example.</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>FF_SCRIPT</term>
//        ///             <description>Fonts designed to look like handwriting. Script and Cursive are examples.</description>
//        ///         </item>
//        ///         <item>
//        ///             <term>FF_SWISS</term>
//        ///             <description>Fonts with variable stroke width (proportional) and without serifs. MS Sans Serif is an example.</description>
//        ///         </item>
//        ///     </list>
//        /// </summary>
//        public PITCH_FAMILY lfPitchAndFamily;

//        /// <summary>
//        ///     A null-terminated string that specifies the typeface name of the font. The length of this string must not exceed 32 TCHAR values, including the
//        ///     terminating NULL. The <see cref="Gdi32.EnumFontFamiliesEx" /> function can be used to enumerate the typeface names of all currently available
//        ///     fonts. If <see cref="lfFaceName" /> is an empty string, GDI uses the first font that matches the other specified attributes.
//        /// </summary>
//        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
//        public string lfFaceName;
//    }


//    // ReSharper restore InconsistentNaming

//    #region
//    //#region 未整理

//    //[UnmanagedFunctionPointer(CallingConvention.StdCall)]
//    //public delegate int EnumWindowStationProc(StringBuilder lpszWindowStation, IntPtr lParam);


//    //[UnmanagedFunctionPointer(CallingConvention.StdCall)]
//    //public delegate void MsgBoxCallback(ref HELPINFO lpHelpInfo);


//    //[UnmanagedFunctionPointer(CallingConvention.StdCall)]
//    //public delegate int DialogProc(IntPtr hwndDlg, uint uMsg, IntPtr wParam, IntPtr lParam);

//    //[UnmanagedFunctionPointer(CallingConvention.StdCall)]
//    //public delegate void SendAsyncProc(IntPtr hwnd, uint uMsg, uint dwData, IntPtr lResult);

//    //[UnmanagedFunctionPointer(CallingConvention.StdCall)]
//    //public delegate int MonitorEnumProc(IntPtr hMonitor, IntPtr hdcMonitor, ref RECT lprcMonitor, IntPtr dwData);

//    //[UnmanagedFunctionPointer(CallingConvention.StdCall)]
//    //public delegate int EnumWindowsProc(IntPtr hwnd, IntPtr lParam);

//    //[UnmanagedFunctionPointer(CallingConvention.StdCall)]
//    //public delegate IntPtr HOOKPROC(int code, IntPtr wParam, IntPtr lParam);

//    //[UnmanagedFunctionPointer(CallingConvention.StdCall)]
//    //public delegate void WinEventProc(IntPtr hWinEventHook, uint @event, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime);

//    //[UnmanagedFunctionPointer(CallingConvention.StdCall)]
//    //public delegate int WindowProc(IntPtr hwnd, uint uMsg, IntPtr wParam, IntPtr lParam);

//    //[UnmanagedFunctionPointer(CallingConvention.StdCall)]
//    //public delegate IntPtr DdeCallback(uint uType, uint uFmt, IntPtr hconv, IntPtr hsz1, IntPtr hsz2, IntPtr hdata, uint dwData1, uint dwData2);

//    //[UnmanagedFunctionPointer(CallingConvention.StdCall)]
//    //public delegate int PropEnumProcEx(IntPtr hwnd, StringBuilder lpszString, IntPtr hData, uint dwData);

//    //[UnmanagedFunctionPointer(CallingConvention.StdCall)]
//    //public delegate int OutputProc(IntPtr hdc, IntPtr lpData, int cchData);

//    //[UnmanagedFunctionPointer(CallingConvention.StdCall)]
//    //public delegate int PropEnumProc(IntPtr hwnd, [In] string lpszString, IntPtr hData);

//    //[UnmanagedFunctionPointer(CallingConvention.StdCall)]
//    //public delegate int DrawStateProc(IntPtr hdc, IntPtr lData, IntPtr wData, int cx, int cy);

//    //[UnmanagedFunctionPointer(CallingConvention.StdCall)]
//    //public delegate void TimerProc(IntPtr hwnd, uint uMsg, IntPtr idEvent, uint dwTime);

//    //public class User32
//    //{
//    //    [DllImport("user32.dll", EntryPoint = "DisableProcessWindowsGhosting")]
//    //    public static extern void DisableProcessWindowsGhosting();

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "UnregisterDeviceNotification")]
//    //    public static extern bool UnregisterDeviceNotification([In] IntPtr Handle);

//    //    [DllImport("user32.dll", EntryPoint = "GetRegisteredRawInputDevices")]
//    //    public static extern uint GetRegisteredRawInputDevices(ref RAWINPUTDEVICE[] pRawInputDevices, ref uint puiNumDevices, uint cbSize);

//    //    [DllImport("user32.dll", EntryPoint = "RegisterDeviceNotification")]
//    //    public static extern IntPtr RegisterDeviceNotification([In] IntPtr hRecipient, [In] IntPtr NotificationFilter, DEVICE_NOTIFY Flags);

//    //    [DllImport("user32.dll", EntryPoint = "MsgWaitForMultipleObjectsEx")]
//    //    public static extern uint MsgWaitForMultipleObjectsEx(uint nCount, ref IntPtr pHandles, uint dwMilliseconds, QS dwWakeMask, MWMO dwFlags);

//    //    [DllImport("user32.dll", EntryPoint = "LookupIconIdFromDirectoryEx")]
//    //    public static extern int LookupIconIdFromDirectoryEx(
//    //        [In] ref byte presbits, [MarshalAs(UnmanagedType.Bool)] bool fIcon, int cxDesired, int cyDesired, LR Flags);

//    //    [DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool SetLayeredWindowAttributes([In] IntPtr hwnd, uint crKey, byte bAlpha, LWA dwFlags);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "IsClipboardFormatAvailable")]
//    //    public static extern bool IsClipboardFormatAvailable(uint format);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "ImpersonateDdeClientWindow")]
//    //    public static extern bool ImpersonateDdeClientWindow(IntPtr hWndClient, IntPtr hWndServer);

//    //    [DllImport("user32.dll", EntryPoint = "GetPriorityClipboardFormat")]
//    //    public static extern int GetPriorityClipboardFormat(
//    //        [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4, SizeParamIndex = 1)] uint[] paFormatPriorityList, int cFormats);

//    //    [DllImport("user32.dll", EntryPoint = "GetMenuCheckMarkDimensions")]
//    //    public static extern int GetMenuCheckMarkDimensions();

//    //    [DllImport("user32.dll", EntryPoint = "GetLayeredWindowAttributes")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool GetLayeredWindowAttributes([In] IntPtr hwnd, ref COLORREF pcrKey, IntPtr pbAlpha, out LWA pdwFlags);

//    //    [DllImport("user32.dll", EntryPoint = "GetClipboardSequenceNumber")]
//    //    public static extern uint GetClipboardSequenceNumber();

//    //    [DllImport("user32.dll", EntryPoint = "CreateDialogIndirectParam")]
//    //    public static extern IntPtr CreateDialogIndirectParam(
//    //        [In] IntPtr hInstance, [In] ref DLGTEMPLATE lpTemplate, [In] IntPtr hWndParent, DialogProc lpDialogFunc, [MarshalAs(UnmanagedType.SysInt)] int lParamInit);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetUserObjectInformation")]
//    //    public static extern bool SetUserObjectInformation([In] IntPtr hObj, int nIndex, [In] IntPtr pvInfo, uint nLength);

//    //    [DllImport("user32.dll", EntryPoint = "MsgWaitForMultipleObjects")]
//    //    public static extern uint MsgWaitForMultipleObjects(
//    //        uint nCount, ref IntPtr pHandles, [MarshalAs(UnmanagedType.Bool)] bool bWaitAll, uint dwMilliseconds, uint dwWakeMask);

//    //    [DllImport("user32.dll", EntryPoint = "LookupIconIdFromDirectory")]
//    //    public static extern int LookupIconIdFromDirectory([In] ref byte presbits, [MarshalAs(UnmanagedType.Bool)] bool fIcon);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "GetUserObjectInformation")]
//    //    public static extern bool GetUserObjectInformation([In] IntPtr hObj, int nIndex, IntPtr pvInfo, uint nLength, IntPtr lpnLengthNeeded);

//    //    [DllImport("user32.dll", EntryPoint = "DeregisterShellHookWindow")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool DeregisterShellHookWindow([In] IntPtr hWnd);

//    //    [DllImport("user32.dll", EntryPoint = "BroadcastSystemMessageEx")]
//    //    public static extern int BroadcastSystemMessageEx(
//    //        BSF dwFlags, IntPtr lpdwRecipients, uint uiMessage, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam, ref BSMINFO pBSMInfo);

//    //    [DllImport("user32.dll", EntryPoint = "RegisterClipboardFormat")]
//    //    public static extern uint RegisterClipboardFormat([In] string lpszFormat);

//    //    [DllImport("user32.dll", EntryPoint = "RealChildWindowFromPoint")]
//    //    public static extern IntPtr RealChildWindowFromPoint([In] IntPtr hwndParent, POINT ptParentClientCoords);

//    //    [DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId")]
//    //    public static extern uint GetWindowThreadProcessId([In] IntPtr hWnd, IntPtr lpdwProcessId);

//    //    [DllImport("user32.dll", EntryPoint = "GetWindowModuleFileName")]
//    //    public static extern uint GetWindowModuleFileName(
//    //        [In] IntPtr hwnd, [Out] StringBuilder lpszFileName, uint cchFileNameMax);

//    //    [DllImport("user32.dll", EntryPoint = "CreateIconFromResourceEx")]
//    //    public static extern IntPtr CreateIconFromResourceEx(
//    //        [In] ref byte pbIconBits, uint cbIconBits, [MarshalAs(UnmanagedType.Bool)] bool fIcon, uint dwVersion, int cxDesired, int cyDesired, LR uFlags);

//    //    [DllImport("user32.dll", EntryPoint = "ChangeDisplaySettingsEx")]
//    //    public static extern int ChangeDisplaySettingsEx(
//    //        [In] string lpszDeviceName, [In] ref DEVMODE lpDevMode, IntPtr hwnd, CDS dwFlags, [In] IntPtr lParam);

//    //    [DllImport("user32.dll", EntryPoint = "AllowSetForegroundWindow")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool AllowSetForegroundWindow(uint dwProcessId);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetProcessWindowStation")]
//    //    public static extern bool SetProcessWindowStation([In] IntPtr hWinSta);

//    //    [DllImport("user32.dll", EntryPoint = "SetProcessDefaultLayout")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool SetProcessDefaultLayout(uint dwDefaultLayout);

//    //    [DllImport("user32.dll", EntryPoint = "RegisterShellHookWindow")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool RegisterShellHookWindow([In] IntPtr hWnd);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "RegisterRawInputDevices")]
//    //    public static extern bool RegisterRawInputDevices(
//    //        [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1)] RAWINPUTDEVICE[] pRawInputDevices, uint uiNumDevices,
//    //        uint cbSize);

//    //    [DllImport("user32.dll", EntryPoint = "LockSetForegroundWindow")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool LockSetForegroundWindow(uint uLockCode);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "IsWinEventHookInstalled")]
//    //    public static extern bool IsWinEventHookInstalled(uint @event);

//    //    [DllImport("user32.dll", EntryPoint = "GetProcessWindowStation")]
//    //    public static extern IntPtr GetProcessWindowStation();

//    //    [DllImport("user32.dll", EntryPoint = "GetProcessDefaultLayout")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool GetProcessDefaultLayout([Out] out uint pdwDefaultLayout);

//    //    [DllImport("user32.dll", EntryPoint = "GetClipboardFormatName")]
//    //    public static extern int GetClipboardFormatName(uint format, [Out] StringBuilder lpszFormatName, int cchMaxCount);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DlgDirSelectComboBoxEx")]
//    //    public static extern bool DlgDirSelectComboBoxEx([In] IntPtr hDlg, [Out] StringBuilder lpString, int nCount, int nIDComboBox);

//    //    [DllImport("user32.dll", EntryPoint = "DialogBoxIndirectParam")]
//    //    public static extern int DialogBoxIndirectParam(
//    //        [In] IntPtr hInstance, [In] ref DLGTEMPLATE hDialogTemplate, [In] IntPtr hWndParent, DialogProc lpDialogFunc,
//    //        [MarshalAs(UnmanagedType.SysInt)] int dwInitParam);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DestroyAcceleratorTable")]
//    //    public static extern bool DestroyAcceleratorTable([In] IntPtr hAccel);

//    //    [DllImport("user32.dll", EntryPoint = "CreateAcceleratorTable")]
//    //    public static extern IntPtr CreateAcceleratorTable(
//    //        [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1)] ACCEL[] lpaccl, int cEntries);

//    //    [DllImport("user32.dll", EntryPoint = "BroadcastSystemMessage")]
//    //    public static extern int BroadcastSystemMessage(
//    //        BSF dwFlags, IntPtr lpdwRecipients, uint uiMessage, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetWindowContextHelpId")]
//    //    public static extern bool SetWindowContextHelpId([In] IntPtr hwnd, uint dwContextHelpId);

//    //    [DllImport("user32.dll", EntryPoint = "RegisterWindowMessage")]
//    //    public static extern uint RegisterWindowMessage([In] string lpString);

//    //    [DllImport("user32.dll", EntryPoint = "GetWindowContextHelpId")]
//    //    public static extern uint GetWindowContextHelpId([In] IntPtr hwnd);

//    //    [DllImport("user32.dll", EntryPoint = "GetRawInputDeviceInfo")]
//    //    public static extern uint GetRawInputDeviceInfo([In] IntPtr hDevice, uint uiCommand, IntPtr pData, ref uint pcbSize);

//    //    [DllImport("user32.dll", EntryPoint = "GetOpenClipboardWindow")]
//    //    public static extern IntPtr GetOpenClipboardWindow();

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "GetKeyboardLayoutName")]
//    //    public static extern bool GetKeyboardLayoutName([Out] StringBuilder pwszKLID);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "EnumDisplaySettingsEx")]
//    //    public static extern bool EnumDisplaySettingsEx(
//    //        [In][MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, uint iModeNum, [Out] out DEVMODE lpDevMode, EDS dwFlags);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DdeSetQualityOfService")]
//    //    public static extern bool DdeSetQualityOfService(IntPtr hwndClient, ref SECURITY_QUALITY_OF_SERVICE pqosNew, ref SECURITY_QUALITY_OF_SERVICE pqosPrev);

//    //    [DllImport("user32.dll", EntryPoint = "DdeCreateStringHandle")]
//    //    public static extern IntPtr DdeCreateStringHandle(uint idInst, [In] string psz, int iCodePage);

//    //    [DllImport("user32.dll", EntryPoint = "CreateIconFromResource")]
//    //    public static extern IntPtr CreateIconFromResource([In] ref byte presbits, uint dwResSize, [MarshalAs(UnmanagedType.Bool)] bool fIcon, uint dwVer);

//    //    [DllImport("user32.dll", EntryPoint = "ChildWindowFromPointEx")]
//    //    public static extern IntPtr ChildWindowFromPointEx([In] IntPtr hwndParent, POINT pt, CWP uFlags);

//    //    [DllImport("user32.dll", EntryPoint = "ChangeDisplaySettings")]
//    //    public static extern int ChangeDisplaySettings(ref DEVMODE lpDevMode, CDS dwflags);

//    //    [DllImport("user32.dll", EntryPoint = "ActivateKeyboardLayout")]
//    //    public static extern IntPtr ActivateKeyboardLayout([In] IntPtr hkl, KLF Flags);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "UserHandleGrantAccess")]
//    //    public static extern bool UserHandleGrantAccess([In] IntPtr hUserHandle, [In] IntPtr hJob, [MarshalAs(UnmanagedType.Bool)] bool bGrant);

//    //    [DllImport("user32.dll", EntryPoint = "TranslateAccelerator")]
//    //    public static extern int TranslateAccelerator([In] IntPtr hWnd, [In] IntPtr hAccTable, [In] ref MSG lpMsg);

//    //    [DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool SystemParametersInfo(uint uiAction, uint uiParam, IntPtr pvParam, uint fWinIni);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetUserObjectSecurity")]
//    //    public static extern bool SetUserObjectSecurity([In] IntPtr hObj, [In] ref uint pSIRequested, [MarshalAs(UnmanagedType.LPStruct)] SECURITY_DESCRIPTOR pSID);

//    //    [DllImport("user32.dll", EntryPoint = "InternalGetWindowText")]
//    //    public static extern int InternalGetWindowText([In] IntPtr hWnd, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpString, int nMaxCount);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "GetUserObjectSecurity")]
//    //    public static extern bool GetUserObjectSecurity([In] IntPtr hObj, [In] ref uint pSIRequested, ref SECURITY_DESCRIPTOR pSD, uint nLength, [Out] out uint lpnLengthNeeded);

//    //    [DllImport("user32.dll", EntryPoint = "GetRawInputDeviceList")]
//    //    public static extern uint GetRawInputDeviceList(ref RAWINPUTDEVICELIST[] pRawInputDeviceList, ref uint puiNumDevices, uint cbSize);

//    //    [DllImport("user32.dll", EntryPoint = "GetKeyboardLayoutList")]
//    //    public static extern int GetKeyboardLayoutList(int nBuff, ref IntPtr lpList);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DdeAbandonTransaction")]
//    //    public static extern bool DdeAbandonTransaction(uint idInst, IntPtr hConv, uint idTransaction);

//    //    [DllImport("user32.dll", EntryPoint = "CountClipboardFormats")]
//    //    public static extern int CountClipboardFormats();

//    //    [DllImport("user32.dll", EntryPoint = "CopyAcceleratorTable")]
//    //    public static extern int CopyAcceleratorTable([In] IntPtr hAccelSrc, IntPtr lpAccelDst, int cAccelEntries);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "UnloadKeyboardLayout")]
//    //    public static extern bool UnloadKeyboardLayout([In] IntPtr hkl);

//    //    [DllImport("user32.dll", EntryPoint = "TranslateMDISysAccel")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool TranslateMDISysAccel([In] IntPtr hWndClient, [In] ref MSG lpMsg);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetMenuContextHelpId")]
//    //    public static extern bool SetMenuContextHelpId([In] IntPtr hmenu, uint dwContextHelpId);

//    //    [DllImport("user32.dll", EntryPoint = "SendMessageCallback")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool SendMessageCallback(
//    //        [In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam,
//    //        SendAsyncProc lpCallBack, uint dwData);

//    //    [DllImport("user32.dll", EntryPoint = "PrivateExtractIcons")]
//    //    public static extern uint PrivateExtractIcons(
//    //        [In] string lpszFile, int nIconIndex, int cxIcon, int cyIcon, ref IntPtr phicon, IntPtr piconid, uint nIcons, LR flags);

//    //    [DllImport("user32.dll", EntryPoint = "GetWindowTextLength")]
//    //    public static extern int GetWindowTextLength([In] IntPtr hWnd);

//    //    [DllImport("user32.dll", EntryPoint = "GetTabbedTextExtent")]
//    //    public static extern uint GetTabbedTextExtent([In] IntPtr hDC, [In] string lpString, int nCount, int nTabPositions, [In] IntPtr lpnTabStopPositions);

//    //    [DllImport("user32.dll", EntryPoint = "GetMouseMovePointsEx")]
//    //    public static extern int GetMouseMovePointsEx(uint cbSize, [In] ref MOUSEMOVEPOINT lppt, IntPtr lpptBuf, int nBufPoints, uint resolution);

//    //    [DllImport("user32.dll", EntryPoint = "GetMenuContextHelpId")]
//    //    public static extern uint GetMenuContextHelpId([In] IntPtr hmenu);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "EnumDisplaySettings")]
//    //    public static extern bool EnumDisplaySettings(
//    //        [In][MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, int iModeNum, ref DEVMODE lpDevMode);

//    //    [DllImport("user32.dll", EntryPoint = "EnumClipboardFormats")]
//    //    public static extern uint EnumClipboardFormats(uint format);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DdeImpersonateClient")]
//    //    public static extern bool DdeImpersonateClient(IntPtr hConv);

//    //    [DllImport("user32.dll", EntryPoint = "DdeClientTransaction")]
//    //    public static extern IntPtr DdeClientTransaction(
//    //        ref byte pData, uint cbData, IntPtr hConv, IntPtr hszItem, uint wFmt, uint wType, uint dwTimeout, ref uint pdwResult);

//    //    [DllImport("user32.dll", EntryPoint = "CreateWindowStation")]
//    //    public static extern IntPtr CreateWindowStation([In] string lpwinsta, CWF dwFlags, uint dwDesiredAccess, [In] ref SECURITY_ATTRIBUTES lpsa);

//    //    [DllImport("user32.dll", EntryPoint = "ChildWindowFromPoint")]
//    //    public static extern IntPtr ChildWindowFromPoint([In] IntPtr hWndParent, POINT Point);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "ChangeClipboardChain")]
//    //    public static extern bool ChangeClipboardChain([In] IntPtr hWndRemove, [In] IntPtr hWndNewNext);

//    //    [DllImport("user32.dll", EntryPoint = "ArrangeIconicWindows")]
//    //    public static extern uint ArrangeIconicWindows([In] IntPtr hWnd);

//    //    [DllImport("user32.dll", EntryPoint = "UpdateLayeredWindow")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool UpdateLayeredWindow(
//    //        [In] IntPtr hwnd, [In] IntPtr hdcDst, ref POINT pptDst, ref SIZE psize, [In] IntPtr hdcSrc, ref POINT pptSrc, uint crKey, ref BLENDFUNCTION pblend,
//    //        ULW dwFlags);

//    //    [DllImport("user32.dll", EntryPoint = "UnhookWindowsHookEx")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool UnhookWindowsHookEx([In] IntPtr hhk);

//    //    [DllImport("user32.dll", EntryPoint = "SetMessageExtraInfo")]
//    //    [return: MarshalAs(UnmanagedType.SysInt)]
//    //    public static extern int SetMessageExtraInfo([MarshalAs(UnmanagedType.SysInt)] int lParam);

//    //    [DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool SetForegroundWindow([In] IntPtr hWnd);

//    //    [DllImport("user32.dll", EntryPoint = "SendMessageTimeout")]
//    //    [return: MarshalAs(UnmanagedType.SysInt)]
//    //    public static extern int SendMessageTimeout(
//    //        [In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam, SMTO fuFlags,
//    //        uint uTimeout, IntPtr lpdwResult);

//    //    [return: MarshalAs(UnmanagedType.SysInt)]
//    //    [DllImport("user32.dll", EntryPoint = "SendDlgItemMessage")]
//    //    public static extern int SendDlgItemMessage(
//    //        [In] IntPtr hDlg, int nIDDlgItem, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

//    //    [DllImport("user32.dll", EntryPoint = "RealGetWindowClass")]
//    //    public static extern uint RealGetWindowClass([In] IntPtr hwnd, [Out] StringBuilder pszType, uint cchType);

//    //    [DllImport("user32.dll", EntryPoint = "MessageBoxIndirect")]
//    //    public static extern int MessageBoxIndirect([In] ref MSGBOXPARAMS lpMsgBoxParams);

//    //    [DllImport("user32.dll", EntryPoint = "LoadKeyboardLayout")]
//    //    public static extern IntPtr LoadKeyboardLayout([In] string pwszKLID, KLF Flags);

//    //    [DllImport("user32.dll", EntryPoint = "LoadCursorFromFile")]
//    //    public static extern IntPtr LoadCursorFromFile([In] string lpFileName);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "IsCharAlphaNumeric")]
//    //    public static extern bool IsCharAlphaNumeric(char ch);

//    //    [DllImport("user32.dll", EntryPoint = "GetNextDlgGroupItem")]
//    //    public static extern IntPtr GetNextDlgGroupItem([In] IntPtr hDlg, [In] IntPtr hCtl, [MarshalAs(UnmanagedType.Bool)] bool bPrevious);

//    //    [DllImport("user32.dll", EntryPoint = "GetMessageExtraInfo")]
//    //    [return: MarshalAs(UnmanagedType.SysInt)]
//    //    public static extern int GetMessageExtraInfo();

//    //    [DllImport("user32.dll", EntryPoint = "GetForegroundWindow")]
//    //    public static extern IntPtr GetForegroundWindow();

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "EnumWindowStations")]
//    //    public static extern bool EnumWindowStations(EnumWindowStationProc lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "EnumDisplayMonitors")]
//    //    public static extern bool EnumDisplayMonitors(
//    //        [In] IntPtr hdc, [In] IntPtr lprcClip, MonitorEnumProc lpfnEnum, [MarshalAs(UnmanagedType.SysInt)] int dwData);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "EnumDisplayDevices")]
//    //    public static extern bool EnumDisplayDevices(
//    //        [In][MarshalAs(UnmanagedType.LPTStr)] string lpDevice, uint iDevNum, ref DISPLAY_DEVICE lpDisplayDevice, EDD dwFlags);

//    //    [DllImport("user32.dll", EntryPoint = "DlgDirListComboBox")]
//    //    public static extern int DlgDirListComboBox([In] IntPtr hDlg, IntPtr lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DdeKeepStringHandle")]
//    //    public static extern bool DdeKeepStringHandle(uint idInst, IntPtr hsz);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DdeFreeStringHandle")]
//    //    public static extern bool DdeFreeStringHandle(uint idInst, IntPtr hsz);

//    //    [DllImport("user32.dll", EntryPoint = "DdeCreateDataHandle")]
//    //    public static extern IntPtr DdeCreateDataHandle(uint idInst, ref byte pSrc, uint cb, uint cbOff, IntPtr hszItem, uint wFmt, uint afCmd);

//    //    [DllImport("user32.dll", EntryPoint = "DdeCmpStringHandles")]
//    //    public static extern int DdeCmpStringHandles(IntPtr hsz1, IntPtr hsz2);

//    //    [DllImport("user32.dll", EntryPoint = "BeginDeferWindowPos")]
//    //    public static extern IntPtr BeginDeferWindowPos(int nNumWindows);

//    //    [DllImport("user32.dll", EntryPoint = "SwitchToThisWindow")]
//    //    public static extern void SwitchToThisWindow([In] IntPtr hWnd, [MarshalAs(UnmanagedType.Bool)] bool fAltTab);

//    //    [DllImport("user32.dll", EntryPoint = "SetWindowPlacement")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool SetWindowPlacement([In] IntPtr hWnd, [In] ref WINDOWPLACEMENT lpwndpl);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetMenuItemBitmaps")]
//    //    public static extern bool SetMenuItemBitmaps([In] IntPtr hMenu, uint uPosition, MF uFlags, [In] IntPtr hBitmapUnchecked, [In] IntPtr hBitmapChecked);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetMenuDefaultItem")]
//    //    public static extern bool SetMenuDefaultItem([In] IntPtr hMenu, uint uItem, uint fByPos);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetDoubleClickTime")]
//    //    public static extern bool SetDoubleClickTime(uint uInterval);

//    //    [DllImport("user32.dll", EntryPoint = "SetClipboardViewer")]
//    //    public static extern IntPtr SetClipboardViewer([In] IntPtr hWndNewViewer);

//    //    [DllImport("user32.dll", EntryPoint = "SendNotifyMessage")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool SendNotifyMessage(
//    //        [In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

//    //    [DllImport("user32.dll", EntryPoint = "PostThreadMessage")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool PostThreadMessage(
//    //        uint idThread, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

//    //    [DllImport("user32.dll", EntryPoint = "OpenWindowStation")]
//    //    public static extern IntPtr OpenWindowStation([In] string lpszWinSta, [MarshalAs(UnmanagedType.Bool)] bool fInherit, uint dwDesiredAccess);

//    //    [DllImport("user32.dll", EntryPoint = "IsDlgButtonChecked")]
//    //    public static extern uint IsDlgButtonChecked([In] IntPtr hDlg, int nIDButton);

//    //    [DllImport("user32.dll", EntryPoint = "GetWindowPlacement")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool GetWindowPlacement([In] IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);

//    //    [DllImport("user32.dll", EntryPoint = "GetMenuDefaultItem")]
//    //    public static extern uint GetMenuDefaultItem([In] IntPtr hMenu, uint fByPos, GMDI gmdiFlags);

//    //    [DllImport("user32.dll", EntryPoint = "GetLastActivePopup")]
//    //    public static extern IntPtr GetLastActivePopup([In] IntPtr hWnd);

//    //    [DllImport("user32.dll", EntryPoint = "GetDoubleClickTime")]
//    //    public static extern uint GetDoubleClickTime();

//    //    [DllImport("user32.dll", EntryPoint = "GetDialogBaseUnits")]
//    //    public static extern int GetDialogBaseUnits();

//    //    [DllImport("user32.dll", EntryPoint = "GetClipboardViewer")]
//    //    public static extern IntPtr GetClipboardViewer();

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "EnumDesktopWindows")]
//    //    public static extern bool EnumDesktopWindows([In] IntPtr hDesktop, EnumWindowsProc lpfn, [MarshalAs(UnmanagedType.SysInt)] int lParam);

//    //    [DllImport("user32.dll", EntryPoint = "DdeQueryNextServer")]
//    //    public static extern IntPtr DdeQueryNextServer(IntPtr hConvList, IntPtr hConvPrev);

//    //    [DllImport("user32.dll", EntryPoint = "CreateIconIndirect")]
//    //    public static extern IntPtr CreateIconIndirect([In] ref ICONINFO piconinfo);

//    //    [DllImport("user32.dll", EntryPoint = "CreateDialogParam")]
//    //    public static extern IntPtr CreateDialogParam(
//    //        [In] IntPtr hInstance, [In] string lpTemplateName, [In] IntPtr hWndParent, DialogProc lpDialogFunc, [MarshalAs(UnmanagedType.SysInt)] int dwInitParam);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "CloseWindowStation")]
//    //    public static extern bool CloseWindowStation([In] IntPtr hWinSta);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "CheckMenuRadioItem")]
//    //    public static extern bool CheckMenuRadioItem([In] IntPtr hmenu, uint idFirst, uint idLast, uint idCheck, MF uFlags);

//    //    [DllImport("user32.dll", EntryPoint = "AdjustWindowRectEx")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool AdjustWindowRectEx(ref RECT lpRect, WS dwStyle, [MarshalAs(UnmanagedType.Bool)] bool bMenu, WS_EX dwExStyle);

//    //    [DllImport("user32.dll", EntryPoint = "UnhookWindowsHook")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    protected static extern bool UnhookWindowsHookInternal(WH nCode, HOOKPROC pfnFilterProc);

//    //    public static bool UnhookWindowsHook(WH nCode, HOOKPROC pfnFilterProc)
//    //    {
//    //        if (nCode == WH.WH_GETMESSAGE)
//    //            return UninitializeHook(nCode);

//    //        return UnhookWindowsHookInternal(nCode, pfnFilterProc);
//    //    }

//    //    [DllImport("user32.dll", EntryPoint = "SetWindowsHookEx")]
//    //    protected static extern IntPtr SetWindowsHookExInternal(WH idHook, HOOKPROC lpfn, [In] IntPtr hmod, uint dwThreadId);

//    //    [DllImport("SystemHookCore.dll", EntryPoint = "SetUserHookCallback")]
//    //    protected static extern IntPtr SetUserHookCallback(WH hookID, HOOKPROC lpfn, uint threadId);

//    //    [DllImport("SystemHookCore.dll", EntryPoint = "UninitializeHook")]
//    //    protected static extern bool UninitializeHook(WH hookType);

//    //    public static IntPtr SetWindowsHookEx(WH idHook, HOOKPROC lpfn, IntPtr hmod, uint dwThreadId)
//    //    {
//    //        if (idHook == WH.WH_GETMESSAGE)
//    //            return SetUserHookCallback(idHook, lpfn, dwThreadId);

//    //        else
//    //            return SetWindowsHookExInternal(idHook, lpfn, hmod, dwThreadId);
//    //    }

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetCaretBlinkTime")]
//    //    public static extern bool SetCaretBlinkTime(uint uMSeconds);

//    //    [DllImport("user32.dll", EntryPoint = "MonitorFromWindow")]
//    //    public static extern IntPtr MonitorFromWindow([In] IntPtr hwnd, MONITOR dwFlags);

//    //    [DllImport("user32.dll", EntryPoint = "MenuItemFromPoint")]
//    //    public static extern int MenuItemFromPoint([In] IntPtr hWnd, [In] IntPtr hMenu, POINT ptScreen);

//    //    [DllImport("user32.dll", EntryPoint = "LoadMenuIndirect")]
//    //    public static extern IntPtr LoadMenuIndirect([In] IntPtr lpMenuTemplate);

//    //    [DllImport("user32.dll", EntryPoint = "LoadAccelerators")]
//    //    public static extern IntPtr LoadAccelerators([In] IntPtr hInstance, [In] string lpTableName);

//    //    [DllImport("user32.dll", EntryPoint = "GetRawInputBuffer")]
//    //    public static extern uint GetRawInputBuffer(ref RAWINPUT[] pData, ref uint pcbSize, uint cbSizeHeader);

//    //    [DllImport("user32.dll", EntryPoint = "GetNextDlgTabItem")]
//    //    public static extern IntPtr GetNextDlgTabItem([In] IntPtr hDlg, [In] IntPtr hCtl, [MarshalAs(UnmanagedType.Bool)] bool bPrevious);

//    //    [DllImport("user32.dll", EntryPoint = "GetKeyboardLayout")]
//    //    public static extern IntPtr GetKeyboardLayout(uint idThread);

//    //    [DllImport("user32.dll", EntryPoint = "GetClipboardOwner")]
//    //    public static extern IntPtr GetClipboardOwner();

//    //    [DllImport("user32.dll", EntryPoint = "GetCaretBlinkTime")]
//    //    public static extern uint GetCaretBlinkTime();

//    //    [DllImport("user32.dll", EntryPoint = "EnumThreadWindows")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool EnumThreadWindows(uint dwThreadId, EnumWindowsProc lpfn, [MarshalAs(UnmanagedType.SysInt)] int lParam);

//    //    [DllImport("user32.dll", EntryPoint = "EndDeferWindowPos")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool EndDeferWindowPos([In] IntPtr hWinPosInfo);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DrawAnimatedRects")]
//    //    public static extern bool DrawAnimatedRects([In] IntPtr hwnd, int idAni, [In] ref RECT lprcFrom, [In] ref RECT lprcTo);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DdeFreeDataHandle")]
//    //    public static extern bool DdeFreeDataHandle(IntPtr hData);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DdeEnableCallback")]
//    //    public static extern bool DdeEnableCallback(uint idInst, IntPtr hConv, uint wCmd);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DdeDisconnectList")]
//    //    public static extern bool DdeDisconnectList(IntPtr hConvList);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "AttachThreadInput")]
//    //    public static extern bool AttachThreadInput(uint idAttach, uint idAttachTo, [MarshalAs(UnmanagedType.Bool)] bool fAttach);

//    //    [DllImport("user32.dll", EntryPoint = "WaitForInputIdle")]
//    //    public static extern uint WaitForInputIdle([In] IntPtr hProcess, uint dwMilliseconds);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "UnregisterHotKey")]
//    //    public static extern bool UnregisterHotKey([In] IntPtr hWnd, int id);

//    //    [DllImport("user32.dll", EntryPoint = "UnregisterClass")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool UnregisterClass([In] string lpClassName, [In] IntPtr hInstance);

//    //    [DllImport("user32.dll", EntryPoint = "TranslateMessage")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool TranslateMessage([In] ref MSG lpMsg);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "TrackPopupMenuEx")]
//    //    public static extern bool TrackPopupMenuEx([In] IntPtr hmenu, uint fuFlags, int x, int y, [In] IntPtr hwnd, [In] ref TPMPARAMS lptpm);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetThreadDesktop")]
//    //    public static extern bool SetThreadDesktop([In] IntPtr hDesktop);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetMenuItemInfo")]
//    //    public static extern bool SetMenuItemInfo(
//    //        [In] IntPtr hMenu, uint uItem, [MarshalAs(UnmanagedType.Bool)] bool fByPosition, [In] ref MENUITEMINFO lpmii);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetKeyboardState")]
//    //    public static extern bool SetKeyboardState([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I1, SizeConst = 256)] byte[] lpKeyState);

//    //    [DllImport("user32.dll", EntryPoint = "SetClipboardData")]
//    //    public static extern IntPtr SetClipboardData(CF uFormat, [In] IntPtr hMem);

//    //    [DllImport("user32.dll", EntryPoint = "RegisterClassEx")]
//    //    public static extern ushort RegisterClassEx([In] ref WNDCLASSEX lpWndClass);

//    //    [DllImport("user32.dll", EntryPoint = "OpenInputDesktop")]
//    //    public static extern IntPtr OpenInputDesktop(DF dwFlags, [MarshalAs(UnmanagedType.Bool)] bool fInherit, uint dwDesiredAccess);

//    //    [DllImport("user32.dll", EntryPoint = "MonitorFromPoint")]
//    //    public static extern IntPtr MonitorFromPoint(POINT pt, MONITOR dwFlags);

//    //    [DllImport("user32.dll", EntryPoint = "MapVirtualKeyEx")]
//    //    public static extern uint MapVirtualKeyEx(uint uCode, uint uMapType, [In] IntPtr dwhkl);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "LockWindowUpdate")]
//    //    public static extern bool LockWindowUpdate([In] IntPtr hWndLock);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "IsDialogMessage")]
//    //    public static extern bool IsDialogMessage([In] IntPtr hDlg, [In] ref MSG lpMsg);

//    //    [DllImport("user32.dll", EntryPoint = "GetThreadDesktop")]
//    //    public static extern IntPtr GetThreadDesktop(uint dwThreadId);

//    //    [DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
//    //    public static extern int GetSystemMetrics(int nIndex);

//    //    [DllImport("user32.dll", EntryPoint = "GetSysColorBrush")]
//    //    public static extern IntPtr GetSysColorBrush(int nIndex);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "GetScrollBarInfo")]
//    //    public static extern bool GetScrollBarInfo([In] IntPtr hwnd, int idObject, ref SCROLLBARINFO psbi);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "GetMenuItemInfo")]
//    //    public static extern bool GetMenuItemInfo([In] IntPtr hMenu, uint uItem, [MarshalAs(UnmanagedType.Bool)] bool fByPosition, ref MENUITEMINFO lpmii);

//    //    [DllImport("user32.dll", EntryPoint = "GetMenuItemCount")]
//    //    public static extern int GetMenuItemCount([In] IntPtr hMenu);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "GetLastInputInfo")]
//    //    public static extern bool GetLastInputInfo([Out] out LASTINPUTINFO plii);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "GetKeyboardState")]
//    //    public static extern bool GetKeyboardState(IntPtr lpKeyState);

//    //    [DllImport("user32.dll", EntryPoint = "GetGUIThreadInfo")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool GetGUIThreadInfo(uint idThread, ref GUITHREADINFO lpgui);

//    //    [DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
//    //    public static extern IntPtr GetDesktopWindow();

//    //    [DllImport("user32.dll", EntryPoint = "GetClipboardData")]
//    //    public static extern IntPtr GetClipboardData(uint uFormat);

//    //    [DllImport("user32.dll", EntryPoint = "GetAsyncKeyState")]
//    //    public static extern short GetAsyncKeyState(int vKey);

//    //    [DllImport("user32.dll", EntryPoint = "ExcludeUpdateRgn")]
//    //    public static extern int ExcludeUpdateRgn([In] IntPtr hDC, [In] IntPtr hWnd);

//    //    [DllImport("user32.dll", EntryPoint = "EnumChildWindows")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool EnumChildWindows([In] IntPtr hWndParent, EnumWindowsProc lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DrawFrameControl")]
//    //    public static extern bool DrawFrameControl([In] IntPtr hdc, ref RECT lprc, uint uType, uint uState);

//    //    [DllImport("user32.dll", EntryPoint = "DispatchMessage")]
//    //    [return: MarshalAs(UnmanagedType.SysInt)]
//    //    public static extern int DispatchMessage([In] ref MSG lpmsg);

//    //    [DllImport("user32.dll", EntryPoint = "DefMDIChildProc")]
//    //    [return: MarshalAs(UnmanagedType.SysInt)]
//    //    public static extern int DefMDIChildProc(
//    //        [In] IntPtr hWnd, uint uMsg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DdeSetUserHandle")]
//    //    public static extern bool DdeSetUserHandle(IntPtr hConv, uint id, uint hUser);

//    //    [DllImport("user32.dll", EntryPoint = "DdeQueryConvInfo")]
//    //    public static extern uint DdeQueryConvInfo(IntPtr hConv, uint idTransaction, ref CONVINFO pConvInfo);

//    //    [DllImport("user32.dll", EntryPoint = "CreateMDIWindow")]
//    //    public static extern IntPtr CreateMDIWindow(
//    //        [In] string lpClassName, [In] string lpWindowName, WS dwStyle, int X, int Y, int nWidth, int nHeight, [In] IntPtr hWndParent, [In] IntPtr hInstance,
//    //        [MarshalAs(UnmanagedType.SysInt)] int lParam);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "CheckRadioButton")]
//    //    public static extern bool CheckRadioButton([In] IntPtr hDlg, int nIDFirstButton, int nIDLastButton, int nIDCheckButton);

//    //    [DllImport("user32.dll", EntryPoint = "BringWindowToTop")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool BringWindowToTop([In] IntPtr hWnd);

//    //    [DllImport("user32.dll", EntryPoint = "AdjustWindowRect")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool AdjustWindowRect(ref RECT lpRect, WS dwStyle, [MarshalAs(UnmanagedType.Bool)] bool bMenu);

//    //    [DllImport("user32.dll", EntryPoint = "WindowFromPoint")]
//    //    public static extern IntPtr WindowFromPoint(POINT Point);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "UnpackDDElParam")]
//    //    public static extern bool UnpackDDElParam(uint msg, [MarshalAs(UnmanagedType.SysInt)] int lParam, ref uint puiLo, ref uint puiHi);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "TrackMouseEvent")]
//    //    public static extern bool TrackMouseEvent(ref TRACKMOUSEEVENT lpEventTrack);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SwapMouseButton")]
//    //    public static extern bool SwapMouseButton([MarshalAs(UnmanagedType.Bool)] bool fSwap);

//    //    [DllImport("user32.dll", EntryPoint = "ShowWindowAsync")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool ShowWindowAsync([In] IntPtr hWnd, int nCmdShow);

//    //    [DllImport("user32.dll", EntryPoint = "ShowOwnedPopups")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool ShowOwnedPopups([In] IntPtr hWnd, [MarshalAs(UnmanagedType.Bool)] bool fShow);

//    //    [DllImport("user32.dll", EntryPoint = "SetWinEventHook")]
//    //    public static extern IntPtr SetWinEventHook(
//    //        uint eventMin, uint eventMax, [In] IntPtr hmodWinEventProc, WinEventProc lpfnWinEventProc, uint idProcess, uint idThread, WINEVENT dwflags);

//    //    [DllImport("user32.dll", EntryPoint = "SetWindowsHook")]
//    //    public static extern IntPtr SetWindowsHook(int nFilterType, HOOKPROC pfnFilterProc);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetSystemCursor")]
//    //    public static extern bool SetSystemCursor([In] IntPtr hcur, uint id);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetMessageQueue")]
//    //    public static extern bool SetMessageQueue(int cMessagesMax);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetDlgItemText")]
//    //    public static extern bool SetDlgItemText([In] IntPtr hDlg, int nIDDlgItem, [In] string lpString);

//    //    [DllImport("user32.dll", EntryPoint = "SetActiveWindow")]
//    //    public static extern IntPtr SetActiveWindow([In] IntPtr hWnd);

//    //    [DllImport("user32.dll", EntryPoint = "PostQuitMessage")]
//    //    public static extern void PostQuitMessage(int nExitCode);

//    //    [DllImport("user32.dll", EntryPoint = "MonitorFromRect")]
//    //    public static extern IntPtr MonitorFromRect([In] ref RECT lprc, MONITOR dwFlags);

//    //    [DllImport("user32.dll", EntryPoint = "MapWindowPoints")]
//    //    public static extern int MapWindowPoints([In] IntPtr hWndFrom, [In] IntPtr hWndTo, ref POINT[] lpPoints, uint cPoints);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "LockWorkStation")]
//    //    public static extern bool LockWorkStation();

//    //    [DllImport("user32.dll", EntryPoint = "IsWindowVisible")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool IsWindowVisible([In] IntPtr hWnd);

//    //    [DllImport("user32.dll", EntryPoint = "IsWindowUnicode")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool IsWindowUnicode([In] IntPtr hWnd);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "IsWindowEnabled")]
//    //    public static extern bool IsWindowEnabled([In] IntPtr hWnd);

//    //    [DllImport("user32.dll", EntryPoint = "IsHungAppWindow")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool IsHungAppWindow([In] IntPtr hwnd);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "InsertMenuItem")]
//    //    public static extern bool InsertMenuItem(
//    //        [In] IntPtr hmenu, uint item, [MarshalAs(UnmanagedType.Bool)] bool fByPosition, [In] ref MENUITEMINFO lpmi);

//    //    [DllImport("user32.dll", EntryPoint = "InSendMessageEx")]
//    //    public static extern uint InSendMessageEx(IntPtr lpReserved);

//    //    [DllImport("user32.dll", EntryPoint = "GetWindowRgnBox")]
//    //    public static extern int GetWindowRgnBox([In] IntPtr hWnd, [Out] out RECT lprc);

//    //    [DllImport("user32.dll", EntryPoint = "GetTitleBarInfo")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool GetTitleBarInfo([In] IntPtr hwnd, ref TITLEBARINFO pti);

//    //    [DllImport("user32.dll", EntryPoint = "GetRawInputData")]
//    //    public static extern uint GetRawInputData([In] IntPtr hRawInput, uint uiCommand, IntPtr pData, ref uint pcbSize, uint cbSizeHeader);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "GetMonitorInfo")]
//    //    public static extern bool GetMonitorInfo([In] IntPtr hMonitor, ref MONITORINFO lpmi);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "GetMenuItemRect")]
//    //    public static extern bool GetMenuItemRect([In] IntPtr hWnd, [In] IntPtr hMenu, uint uItem, [Out] out RECT lprcItem);

//    //    [DllImport("user32.dll", EntryPoint = "GetKeyNameText")]
//    //    public static extern int GetKeyNameText(int lParam, [Out] StringBuilder lpString, int cchSize);

//    //    [DllImport("user32.dll", EntryPoint = "GetKeyboardType")]
//    //    public static extern int GetKeyboardType(int nTypeFlag);

//    //    [DllImport("user32.dll", EntryPoint = "GetGuiResources")]
//    //    public static extern uint GetGuiResources([In] IntPtr hProcess, GR uiFlags);

//    //    [DllImport("user32.dll", EntryPoint = "GetDlgItemText")]
//    //    public static extern uint GetDlgItemText([In] IntPtr hDlg, int nIDDlgItem, [Out] StringBuilder lpString, int nMaxCount);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "GetComboBoxInfo")]
//    //    public static extern bool GetComboBoxInfo([In] IntPtr hwndCombo, ref COMBOBOXINFO pcbi);

//    //    [DllImport("user32.dll", EntryPoint = "GetClassInfoEx")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool GetClassInfoEx([In] IntPtr hinst, [In] string lpszClass, [Out] out WNDCLASSEX lpwcx);

//    //    [DllImport("user32.dll", EntryPoint = "GetActiveWindow")]
//    //    public static extern IntPtr GetActiveWindow();

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "EnableScrollBar")]
//    //    public static extern bool EnableScrollBar([In] IntPtr hWnd, SB wSBflags, ESB wArrows);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DlgDirSelectEx")]
//    //    public static extern bool DlgDirSelectEx([In] IntPtr hDlg, [Out] StringBuilder lpString, int nCount, int nIDListBox);

//    //    [DllImport("user32.dll", EntryPoint = "DialogBoxParam")]
//    //    public static extern int DialogBoxParam(
//    //        [In] IntPtr hInstance, [In] string lpTemplateName, [In] IntPtr hWndParent, DialogProc lpDialogFunc, [MarshalAs(UnmanagedType.SysInt)] int dwInitParam);

//    //    [return: MarshalAs(UnmanagedType.SysInt)]
//    //    [DllImport("user32.dll", EntryPoint = "DefRawInputProc")]
//    //    public static extern int DefRawInputProc(ref RAWINPUT[] paRawInput, int nInput, uint cbSizeHeader);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DdeUninitialize")]
//    //    public static extern bool DdeUninitialize(uint idInst);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DdeUnaccessData")]
//    //    public static extern bool DdeUnaccessData(IntPtr hData);

//    //    [DllImport("user32.dll", EntryPoint = "DdeQueryString")]
//    //    public static extern uint DdeQueryString(uint idInst, IntPtr hsz, StringBuilder psz, uint cchMax, int iCodePage);

//    //    [DllImport("user32.dll", EntryPoint = "DdeGetLastError")]
//    //    public static extern uint DdeGetLastError(uint idInst);

//    //    [DllImport("user32.dll", EntryPoint = "CreateWindowEx")]
//    //    public static extern IntPtr CreateWindowEx(
//    //        WS_EX dwExStyle, [In] string lpClassName, [In] string lpWindowName, WS dwStyle, int X, int Y, int nWidth, int nHeight, [In] IntPtr hWndParent,
//    //        [In] IntPtr hMenu, [In] IntPtr hInstance, [In] IntPtr lpParam);

//    //    [DllImport("user32.dll", EntryPoint = "CreatePopupMenu")]
//    //    public static extern IntPtr CreatePopupMenu();

//    //    [DllImport("user32.dll", EntryPoint = "CallWindowProc")]
//    //    [return: MarshalAs(UnmanagedType.SysInt)]
//    //    public static extern int CallWindowProc(
//    //        WindowProc lpPrevWndFunc, [In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "UnhookWinEvent")]
//    //    public static extern bool UnhookWinEvent([In] IntPtr hWinEventHook);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "TrackPopupMenu")]
//    //    public static extern bool TrackPopupMenu([In] IntPtr hMenu, TPM uFlags, int x, int y, int nReserved, [In] IntPtr hWnd, [In] IntPtr prcRect);

//    //    [DllImport("user32.dll", EntryPoint = "TabbedTextOut")]
//    //    public static extern int TabbedTextOut(
//    //        [In] IntPtr hdc, int x, int y, [In] string lpString, int chCount, int nTabPositions, [In] IntPtr lpnTabStopPositions, int nTabOrigin);

//    //    [DllImport("user32.dll", EntryPoint = "SetWindowText")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool SetWindowText([In] IntPtr hWnd, [In] string lpString);

//    //    [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
//    //    public static extern int SetWindowLong([In] IntPtr hWnd, int nIndex, int dwNewLong);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetScrollRange")]
//    //    public static extern bool SetScrollRange([In] IntPtr hWnd, int nBar, int nMinPos, int nMaxPos, [MarshalAs(UnmanagedType.Bool)] bool bRedraw);

//    //    [DllImport("user32.dll", EntryPoint = "SetLastErrorEx")]
//    //    public static extern void SetLastErrorEx(uint dwErrCode, uint dwType);

//    //    [DllImport("user32.dll", EntryPoint = "ScrollWindowEx")]
//    //    public static extern int ScrollWindowEx(
//    //        [In] IntPtr hWnd, int dx, int dy, [In] ref RECT prcScroll, [In] ref RECT prcClip, [In] IntPtr hrgnUpdate, ref RECT prcUpdate, SW flags);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "ScreenToClient")]
//    //    public static extern bool ScreenToClient([In] IntPtr hWnd, ref POINT lpPoint);

//    //    [return: MarshalAs(UnmanagedType.SysInt)]
//    //    [DllImport("user32.dll", EntryPoint = "ReuseDDElParam")]
//    //    public static extern int ReuseDDElParam(
//    //        [MarshalAs(UnmanagedType.SysInt)] int lParam, uint msgIn, uint msgOut, [MarshalAs(UnmanagedType.SysUInt)] uint uiLo,
//    //        [MarshalAs(UnmanagedType.SysUInt)] uint uiHi);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
//    //    public static extern bool ReleaseCapture();

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "RegisterHotKey")]
//    //    public static extern bool RegisterHotKey([In] IntPtr hWnd, int id, uint fsModifiers, uint vk);

//    //    [DllImport("user32.dll", EntryPoint = "RegisterClass")]
//    //    public static extern ushort RegisterClass([In] ref WNDCLASS lpWndClass);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "OemToCharBuff")]
//    //    public static extern bool OemToCharBuff([In][MarshalAs(UnmanagedType.LPStr)] string lpszSrc, [Out] StringBuilder lpszDst, uint cchDstLength);

//    //    [DllImport("user32.dll", EntryPoint = "NotifyWinEvent")]
//    //    public static extern void NotifyWinEvent(uint @event, [In] IntPtr hwnd, int idObject, int idChild);

//    //    [DllImport("user32.dll", EntryPoint = "MapVirtualKey")]
//    //    public static extern uint MapVirtualKey(uint uCode, uint uMapType);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "InvalidateRect")]
//    //    public static extern bool InvalidateRect([In] IntPtr hWnd, [In] ref RECT lpRect, [MarshalAs(UnmanagedType.Bool)] bool bErase);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "HiliteMenuItem")]
//    //    public static extern bool HiliteMenuItem([In] IntPtr hwnd, [In] IntPtr hmenu, uint uItemHilite, uint uHilite);

//    //    [DllImport("user32.dll", EntryPoint = "GetWindowText")]
//    //    public static extern int GetWindowText([In] IntPtr hWnd, [Out] StringBuilder lpString, int nMaxCount);

//    //    [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
//    //    public static extern int GetWindowLong([In] IntPtr hWnd, int nIndex);

//    //    [DllImport("user32.dll", EntryPoint = "GetShellWindow")]
//    //    public static extern IntPtr GetShellWindow();

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "GetScrollRange")]
//    //    public static extern bool GetScrollRange([In] IntPtr hWnd, int nBar, [Out] out int lpMinPos, [Out] out int lpMaxPos);

//    //    [DllImport("user32.dll", EntryPoint = "GetQueueStatus")]
//    //    public static extern uint GetQueueStatus(QS flags);

//    //    [DllImport("user32.dll", EntryPoint = "GetMessageTime")]
//    //    public static extern int GetMessageTime();

//    //    [DllImport("user32.dll", EntryPoint = "GetMenuString")]
//    //    public static extern int GetMenuString([In] IntPtr hMenu, uint uIDItem, [Out] StringBuilder lpString, int nMaxCount, MF uFlag);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "GetMenuBarInfo")]
//    //    public static extern bool GetMenuBarInfo([In] IntPtr hwnd, int idObject, int idItem, ref MENUBARINFO pmbi);

//    //    [DllImport("user32.dll", EntryPoint = "GetListBoxInfo")]
//    //    public static extern uint GetListBoxInfo([In] IntPtr hwnd);

//    //    [DllImport("user32.dll", EntryPoint = "GetAltTabInfo")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool GetAltTabInfo([In] IntPtr hwnd, int iItem, ref ALTTABINFO pati, [Out] StringBuilder pszItemText, uint cchItemText);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "EnableMenuItem")]
//    //    public static extern bool EnableMenuItem([In] IntPtr hMenu, uint uIDEnableItem, uint uEnable);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "EmptyClipboard")]
//    //    public static extern bool EmptyClipboard();

//    //    [DllImport("user32.dll", EntryPoint = "DefWindowProc")]
//    //    [return: MarshalAs(UnmanagedType.SysInt)]
//    //    public static extern int DefWindowProc(
//    //        [In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

//    //    [DllImport("user32.dll", EntryPoint = "DeferWindowPos")]
//    //    public static extern IntPtr DeferWindowPos(
//    //        [In] IntPtr hWinPosInfo, [In] IntPtr hWnd, [In] IntPtr hWndInsertAfter, int x, int y, int cx, int cy, SWP uFlags);

//    //    [DllImport("user32.dll", EntryPoint = "DdeNameService")]
//    //    public static extern IntPtr DdeNameService(uint idInst, IntPtr hsz1, IntPtr hsz2, uint afCmd);

//    //    [DllImport("user32.dll", EntryPoint = "DdeInitialize")]
//    //    public static extern uint DdeInitialize(ref uint pidInst, DdeCallback pfnCallback, uint afCmd, uint ulRes);

//    //    [DllImport("user32.dll", EntryPoint = "DdeConnectList")]
//    //    public static extern IntPtr DdeConnectList(uint idInst, IntPtr hszService, IntPtr hszTopic, IntPtr hConvList, ref CONVCONTEXT pCC);

//    //    [DllImport("user32.dll", EntryPoint = "CreateDesktop")]
//    //    public static extern IntPtr CreateDesktop(
//    //        [In] string lpszDesktop, [In] string lpszDevice, IntPtr pDevmode, DF dwFlags, uint dwDesiredAccess, [In] ref SECURITY_ATTRIBUTES lpsa);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "CloseClipboard")]
//    //    public static extern bool CloseClipboard();

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "ClientToScreen")]
//    //    public static extern bool ClientToScreen([In] IntPtr hWnd, ref POINT lpPoint);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "CheckDlgButton")]
//    //    public static extern bool CheckDlgButton([In] IntPtr hDlg, int nIDButton, uint uCheck);

//    //    [DllImport("user32.dll", EntryPoint = "CharUpperBuff")]
//    //    public static extern uint CharUpperBuff(StringBuilder lpsz, uint cchLength);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "CharToOemBuff")]
//    //    public static extern bool CharToOemBuff([In] string lpszSrc, [Out] StringBuilder lpszDst, uint cchDstLength);

//    //    [DllImport("user32.dll", EntryPoint = "CharLowerBuff")]
//    //    public static extern uint CharLowerBuff(StringBuilder lpsz, uint cchLength);

//    //    [DllImport("user32.dll", EntryPoint = "CascadeWindows")]
//    //    public static extern ushort CascadeWindows([In] IntPtr hwndParent, uint wHow, [In] ref RECT lpRect, uint cKids, ref IntPtr lpKids);

//    //    [DllImport("user32.dll", EntryPoint = "CallNextHookEx")]
//    //    public static extern IntPtr CallNextHookEx(
//    //        [In] IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

//    //    [DllImport("user32.dll", EntryPoint = "CallMsgFilter")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool CallMsgFilter([In] ref MSG lpMsg, int nCode);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SwitchDesktop")]
//    //    public static extern bool SwitchDesktop([In] IntPtr hDesktop);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "ShowScrollBar")]
//    //    public static extern bool ShowScrollBar([In] IntPtr hWnd, int wBar, [MarshalAs(UnmanagedType.Bool)] bool bShow);

//    //    [DllImport("user32.dll", EntryPoint = "SetWindowWord")]
//    //    public static extern ushort SetWindowWord([In] IntPtr hWnd, int nIndex, ushort wNewWord);

//    //    [DllImport("user32.dll", EntryPoint = "SetScrollInfo")]
//    //    public static extern int SetScrollInfo([In] IntPtr hwnd, int nBar, [In] ref SCROLLINFO lpsi, [MarshalAs(UnmanagedType.Bool)] bool redraw);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetDlgItemInt")]
//    //    public static extern bool SetDlgItemInt([In] IntPtr hDlg, int nIDDlgItem, uint uValue, [MarshalAs(UnmanagedType.Bool)] bool bSigned);

//    //    [DllImport("user32.dll", EntryPoint = "SetClassLong")]
//    //    public static extern uint SetClassLong([In] IntPtr hWnd, int nIndex, int dwNewLong);

//    //    [return: MarshalAs(UnmanagedType.SysInt)]
//    //    [DllImport("user32.dll", EntryPoint = "PackDDElParam")]
//    //    public static extern int PackDDElParam(uint msg, [MarshalAs(UnmanagedType.SysUInt)] uint uiLo, [MarshalAs(UnmanagedType.SysUInt)] uint uiHi);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "OpenClipboard")]
//    //    public static extern bool OpenClipboard([In] IntPtr hWndNewOwner);

//    //    [DllImport("user32.dll", EntryPoint = "MessageBoxEx")]
//    //    public static extern int MessageBoxEx([In] IntPtr hWnd, [In] string lpText, [In] string lpCaption, uint uType, ushort wLanguageId);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "MapDialogRect")]
//    //    public static extern bool MapDialogRect([In] IntPtr hDlg, ref RECT lpRect);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "InvalidateRgn")]
//    //    public static extern bool InvalidateRgn([In] IntPtr hWnd, [In] IntPtr hRgn, [MarshalAs(UnmanagedType.Bool)] bool bErase);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "IntersectRect")]
//    //    public static extern bool IntersectRect([Out] out RECT lprcDst, [In] ref RECT lprcSrc1, [In] ref RECT lprcSrc2);

//    //    [DllImport("user32.dll", EntryPoint = "InSendMessage")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool InSendMessage();

//    //    [DllImport("user32.dll", EntryPoint = "GetWindowWord")]
//    //    public static extern ushort GetWindowWord([In] IntPtr hWnd, int nIndex);

//    //    [DllImport("user32.dll", EntryPoint = "GetWindowRect")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool GetWindowRect([In] IntPtr hWnd, [Out] out RECT lpRect);

//    //    [DllImport("user32.dll", EntryPoint = "GetWindowInfo")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool GetWindowInfo([In] IntPtr hwnd, ref WINDOWINFO pwi);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "GetUpdateRect")]
//    //    public static extern bool GetUpdateRect([In] IntPtr hWnd, ref RECT lpRect, [MarshalAs(UnmanagedType.Bool)] bool bErase);

//    //    [DllImport("user32.dll", EntryPoint = "GetSystemMenu")]
//    //    public static extern IntPtr GetSystemMenu([In] IntPtr hWnd, [MarshalAs(UnmanagedType.Bool)] bool bRevert);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "GetScrollInfo")]
//    //    public static extern bool GetScrollInfo([In] IntPtr hwnd, int fnBar, ref SCROLLINFO lpsi);

//    //    [DllImport("user32.dll", EntryPoint = "GetMessagePos")]
//    //    public static extern uint GetMessagePos();

//    //    [DllImport("user32.dll", EntryPoint = "GetMenuItemID")]
//    //    public static extern uint GetMenuItemID([In] IntPtr hMenu, int nPos);

//    //    [DllImport("user32.dll", EntryPoint = "GetKBCodePage")]
//    //    public static extern uint GetKBCodePage();

//    //    [DllImport("user32.dll", EntryPoint = "GetInputState")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool GetInputState();

//    //    [DllImport("user32.dll", EntryPoint = "GetDlgItemInt")]
//    //    public static extern uint GetDlgItemInt([In] IntPtr hDlg, int nIDDlgItem, IntPtr lpTranslated, [MarshalAs(UnmanagedType.Bool)] bool bSigned);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "GetCursorInfo")]
//    //    public static extern bool GetCursorInfo(ref CURSORINFO pci);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "GetClipCursor")]
//    //    public static extern bool GetClipCursor([Out] out RECT lpRect);

//    //    [DllImport("user32.dll", EntryPoint = "GetClientRect")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool GetClientRect([In] IntPtr hWnd, [Out] out RECT lpRect);

//    //    [DllImport("user32.dll", EntryPoint = "GetClassName")]
//    //    public static extern int GetClassName([In] IntPtr hWnd, [Out] StringBuilder lpClassName, int nMaxCount);

//    //    [DllImport("user32.dll", EntryPoint = "GetClassLong")]
//    //    public static extern uint GetClassLong([In] IntPtr hWnd, int nIndex);

//    //    [DllImport("user32.dll", EntryPoint = "GetClassInfo")]
//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    public static extern bool GetClassInfo([In] IntPtr hInstance, [In] string lpClassName, [Out] out WNDCLASS lpWndClass);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "FreeDDElParam")]
//    //    public static extern bool FreeDDElParam(uint msg, [MarshalAs(UnmanagedType.SysInt)] int lParam);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "FlashWindowEx")]
//    //    public static extern bool FlashWindowEx([In] ref FLASHWINFO pfwi);

//    //    [DllImport("user32.dll", EntryPoint = "FindWindowEx")]
//    //    public static extern IntPtr FindWindowEx([In] IntPtr hWndParent, [In] IntPtr hWndChildAfter, [In] string lpszClass, [In] string lpszWindow);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "ExitWindowsEx")]
//    //    public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "EnumDesktops")]
//    //    public static extern bool EnumDesktops([In] IntPtr hwinsta, EnumWindowStationProc lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DrawFocusRect")]
//    //    public static extern bool DrawFocusRect([In] IntPtr hDC, [In] ref RECT lprc);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DestroyWindow")]
//    //    public static extern bool DestroyWindow([In] IntPtr hWnd);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DestroyCursor")]
//    //    public static extern bool DestroyCursor([In] IntPtr hCursor);

//    //    [return: MarshalAs(UnmanagedType.SysInt)]
//    //    [DllImport("user32.dll", EntryPoint = "DefFrameProc")]
//    //    public static extern int DefFrameProc(
//    //        [In] IntPtr hWnd, [In] IntPtr hWndMDIClient, uint uMsg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DdePostAdvise")]
//    //    public static extern bool DdePostAdvise(uint idInst, IntPtr hszTopic, IntPtr hszItem);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DdeDisconnect")]
//    //    public static extern bool DdeDisconnect(IntPtr hConv);

//    //    [DllImport("user32.dll", EntryPoint = "DdeAccessData")]
//    //    public static extern IntPtr DdeAccessData(IntPtr hData, ref uint pcbDataSize);

//    //    [DllImport("user32.dll", EntryPoint = "CheckMenuItem")]
//    //    public static extern uint CheckMenuItem([In] IntPtr hMenu, uint uIDCheckItem, uint uCheck);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "AnimateWindow")]
//    //    public static extern bool AnimateWindow([In] IntPtr hWnd, uint dwTime, AW dwFlags);

//    //    [DllImport("user32.dll", EntryPoint = "WindowFromDC")]
//    //    public static extern IntPtr WindowFromDC([In] IntPtr hDC);

//    //    [DllImport("user32.dll", EntryPoint = "VkKeyScanEx")]
//    //    public static extern short VkKeyScanEx(char ch, [In] IntPtr dwhkl);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "ValidateRect")]
//    //    public static extern bool ValidateRect([In] IntPtr hWnd, [In] ref RECT lpRect);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "UpdateWindow")]
//    //    public static extern bool UpdateWindow([In] IntPtr hWnd);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SubtractRect")]
//    //    public static extern bool SubtractRect([Out] out RECT lprcDst, [In] ref RECT lprcSrc1, [In] ref RECT lprcSrc2);

//    //    [DllImport("user32.dll", EntryPoint = "SetWindowRgn")]
//    //    public static extern int SetWindowRgn([In] IntPtr hWnd, [In] IntPtr hRgn, [MarshalAs(UnmanagedType.Bool)] bool bRedraw);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
//    //    public static extern bool SetWindowPos([In] IntPtr hWnd, [In] IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, SWP uFlags);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetSysColors")]
//    //    public static extern bool SetSysColors(
//    //        int cElements, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4, SizeParamIndex = 0)] int[] lpaElements,
//    //        [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4, SizeParamIndex = 0)] uint[] lpaRgbValues);

//    //    [DllImport("user32.dll", EntryPoint = "SetScrollPos")]
//    //    public static extern int SetScrollPos([In] IntPtr hWnd, int nBar, int nPos, [MarshalAs(UnmanagedType.Bool)] bool bRedraw);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetRectEmpty")]
//    //    public static extern bool SetRectEmpty([Out] out RECT lprc);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
//    //    public static extern bool SetCursorPos(int X, int Y);

//    //    [DllImport("user32.dll", EntryPoint = "SetClassWord")]
//    //    public static extern ushort SetClassWord([In] IntPtr hWnd, int nIndex, ushort wNewWord);

//    //    [DllImport("user32.dll", EntryPoint = "SendMessage")]
//    //    public static extern IntPtr SendMessage([In] IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

//    //    public static IntPtr SendMessage([In] IntPtr hWnd, WM Msg, IntPtr wParam, IntPtr lParam)
//    //    {
//    //        return SendMessage(hWnd, (uint)Msg, lParam, wParam);
//    //    }

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "ScrollWindow")]
//    //    public static extern bool ScrollWindow([In] IntPtr hWnd, int XAmount, int YAmount, [In] ref RECT lpRect, [In] ref RECT lpClipRect);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "ReplyMessage")]
//    //    public static extern bool ReplyMessage([MarshalAs(UnmanagedType.SysInt)] int lResult);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "RedrawWindow")]
//    //    public static extern bool RedrawWindow([In] IntPtr hWnd, [In] ref RECT lprcUpdate, [In] IntPtr hrgnUpdate, RDW flags);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "PostMessage")]
//    //    public static extern bool PostMessage([In] IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

//    //    public static bool PostMessage([In] IntPtr hWnd, WM Msg, IntPtr wParam, IntPtr lParam)
//    //    {
//    //        return PostMessage(hWnd, (uint)Msg, wParam, lParam);
//    //    }

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "PeekMessage")]
//    //    public static extern bool PeekMessage([Out] out MSG lpMsg, [In] IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "PaintDesktop")]
//    //    public static extern bool PaintDesktop([In] IntPtr hdc);

//    //    [DllImport("user32.dll", EntryPoint = "OpenDesktop")]
//    //    public static extern IntPtr OpenDesktop([In] string lpszDesktop, DF dwFlags, [MarshalAs(UnmanagedType.Bool)] bool fInherit, uint dwDesiredAccess);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "IsCharUpper")]
//    //    public static extern bool IsCharUpper(char ch);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "IsCharLower")]
//    //    public static extern bool IsCharLower(char ch);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "IsCharAlpha")]
//    //    public static extern bool IsCharAlpha(char ch);

//    //    [DllImport("user32.dll", EntryPoint = "GetWindowRgn")]
//    //    public static extern int GetWindowRgn([In] IntPtr hWnd, [In] IntPtr hRgn);

//    //    [DllImport("user32.dll", EntryPoint = "GetUpdateRgn")]
//    //    public static extern int GetUpdateRgn([In] IntPtr hWnd, [In] IntPtr hRgn, [MarshalAs(UnmanagedType.Bool)] bool bErase);

//    //    [DllImport("user32.dll", EntryPoint = "GetTopWindow")]
//    //    public static extern IntPtr GetTopWindow([In] IntPtr hWnd);

//    //    [DllImport("user32.dll", EntryPoint = "GetScrollPos")]
//    //    public static extern int GetScrollPos([In] IntPtr hWnd, int nBar);

//    //    [DllImport("user32.dll", EntryPoint = "GetMenuState")]
//    //    public static extern uint GetMenuState([In] IntPtr hMenu, uint uId, MF uFlags);

//    //    [DllImport("user32.dll", EntryPoint = "GetDlgCtrlID")]
//    //    public static extern int GetDlgCtrlID([In] IntPtr hWnd);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "GetCursorPos")]
//    //    public static extern bool GetCursorPos([Out] out POINT lpPoint);

//    //    [DllImport("user32.dll", EntryPoint = "GetClassWord")]
//    //    public static extern ushort GetClassWord([In] IntPtr hWnd, int nIndex);

//    //    [DllImport("user32.dll", EntryPoint = "EnumPropsEx")]
//    //    public static extern int EnumPropsEx([In] IntPtr hWnd, PropEnumProcEx lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "EnableWindow")]
//    //    public static extern bool EnableWindow([In] IntPtr hWnd, [MarshalAs(UnmanagedType.Bool)] bool bEnable);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DestroyCaret")]
//    //    public static extern bool DestroyCaret();

//    //    [DllImport("user32.dll", EntryPoint = "DdeReconnect")]
//    //    public static extern IntPtr DdeReconnect(IntPtr hConv);

//    //    [DllImport("user32.dll", EntryPoint = "CreateCursor")]
//    //    public static extern IntPtr CreateCursor(
//    //        [In] IntPtr hInst, int xHotSpot, int yHotSpot, int nWidth, int nHeight, [In] ref byte[] pvANDPlane, [In] ref byte[] pvXORPlane);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "CloseDesktop")]
//    //    public static extern bool CloseDesktop([In] IntPtr hDesktop);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "WaitMessage")]
//    //    public static extern bool WaitMessage();

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "ValidateRgn")]
//    //    public static extern bool ValidateRgn([In] IntPtr hWnd, [In] IntPtr hRgn);

//    //    [DllImport("user32.dll", EntryPoint = "ToUnicodeEx")]
//    //    public static extern int ToUnicodeEx(
//    //        uint wVirtKey, uint wScanCode, [In] IntPtr lpKeyState, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, TU wFlags,
//    //        [In] IntPtr dwhkl);

//    //    [DllImport("user32.dll", EntryPoint = "TileWindows")]
//    //    public static extern ushort TileWindows([In] IntPtr hwndParent, MDITILE wHow, [In] ref RECT lpRect, uint cKids, ref IntPtr lpKids);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetMenuInfo")]
//    //    public static extern bool SetMenuInfo([In] IntPtr hmenu, [In] ref MENUINFO lpcmi);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetCaretPos")]
//    //    public static extern bool SetCaretPos(int X, int Y);

//    //    [DllImport("user32.dll", EntryPoint = "RemoveProp")]
//    //    public static extern IntPtr RemoveProp([In] IntPtr hWnd, [In] string lpString);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "PrintWindow")]
//    //    public static extern bool PrintWindow([In] IntPtr hwnd, [In] IntPtr hdcBlt, PW nFlags);

//    //    [DllImport("user32.dll", EntryPoint = "mouse_event")]
//    //    public static extern void mouse_event(MOUSEEVENTF dwFlags, uint dx, uint dy, uint dwData, uint dwExtraInfo);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "ModifyMenu")]
//    //    public static extern bool ModifyMenu([In] IntPtr hMnu, uint uPosition, MF uFlags, [MarshalAs(UnmanagedType.SysUInt)] uint uIDNewItem, [In] string lpNewItem);

//    //    [DllImport("user32.dll", EntryPoint = "MessageBox")]
//    //    public static extern int MessageBox([In] IntPtr hWnd, [In] string lpText, [In] string lpCaption, uint uType);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "MessageBeep")]
//    //    public static extern bool MessageBeep(uint uType);

//    //    [DllImport("user32.dll", EntryPoint = "LoadString")]
//    //    public static extern int LoadString([In] IntPtr hInstance, uint uID, [Out] StringBuilder lpBuffer, int cchBufferMax);

//    //    [DllImport("user32.dll", EntryPoint = "LoadCursor")]
//    //    public static extern IntPtr LoadCursor([In] IntPtr hInstance, [In] string lpCursorName);

//    //    [DllImport("user32.dll", EntryPoint = "LoadBitmap")]
//    //    public static extern IntPtr LoadBitmap([In] IntPtr hInstance, [In] string lpBitmapName);

//    //    [DllImport("user32.dll", EntryPoint = "keybd_event")]
//    //    public static extern void keybd_event(byte bVk, byte bScan, KEYEVENTF dwFlags, uint dwExtraInfo);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "IsRectEmpty")]
//    //    public static extern bool IsRectEmpty([In] ref RECT lprc);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "IsGUIThread")]
//    //    public static extern bool IsGUIThread([MarshalAs(UnmanagedType.Bool)] bool bConvert);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "InsertMenu")]
//    //    public static extern bool InsertMenu(
//    //        [In] IntPtr hMenu, uint uPosition, MF uFlags, [MarshalAs(UnmanagedType.SysUInt)] uint uIDNewItem, [In] string lpNewItem);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "InflateRect")]
//    //    public static extern bool InflateRect(ref RECT lprc, int dx, int dy);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "GrayString")]
//    //    public static extern bool GrayString(
//    //        [In] IntPtr hDC, [In] IntPtr hBrush, OutputProc lpOutputFunc, [MarshalAs(UnmanagedType.SysInt)] int lpData, int nCount, int X, int Y, int nWidth,
//    //        int nHeight);

//    //    [DllImport("user32.dll", EntryPoint = "GetWindowDC")]
//    //    public static extern IntPtr GetWindowDC([In] IntPtr hWnd);

//    //    [DllImport("user32.dll", EntryPoint = "GetSysColor")]
//    //    public static extern uint GetSysColor(int nIndex);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "GetMessage")]
//    //    public static extern bool GetMessage([Out] out MSG lpMsg, [In] IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "GetMenuInfo")]
//    //    public static extern bool GetMenuInfo([In] IntPtr hmenu, ref MENUINFO lpcmi);

//    //    [DllImport("user32.dll", EntryPoint = "GetKeyState")]
//    //    public static extern short GetKeyState(int nVirtKey);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "GetIconInfo")]
//    //    public static extern bool GetIconInfo([In] IntPtr hIcon, [Out] out ICONINFO piconinfo);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "GetCaretPos")]
//    //    public static extern bool GetCaretPos([Out] out POINT lpPoint);

//    //    [DllImport("user32.dll", EntryPoint = "GetAncestor")]
//    //    public static extern IntPtr GetAncestor([In] IntPtr hwnd, GA gaFlags);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "FlashWindow")]
//    //    public static extern bool FlashWindow([In] IntPtr hWnd, [MarshalAs(UnmanagedType.Bool)] bool bInvert);

//    //    [DllImport("user32.dll", EntryPoint = "FindWindow")]
//    //    public static extern IntPtr FindWindow([In] string lpClassName, [In] string lpWindowName);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "EnumWindows")]
//    //    public static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

//    //    [DllImport("user32.dll", EntryPoint = "DrawTextEx")]
//    //    public static extern int DrawTextEx([In] IntPtr hdc, StringBuilder lpchText, int cchText, ref RECT lprc, uint format, [In] IntPtr lpdtp);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DrawMenuBar")]
//    //    public static extern bool DrawMenuBar([In] IntPtr hWnd);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DrawCaption")]
//    //    public static extern bool DrawCaption([In] IntPtr hwnd, [In] IntPtr hdc, [In] ref RECT lprc, DC uFlags);

//    //    [DllImport("user32.dll", EntryPoint = "DlgDirList")]
//    //    public static extern int DlgDirList([In] IntPtr hDlg, IntPtr lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DestroyMenu")]
//    //    public static extern bool DestroyMenu([In] IntPtr hMenu);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DestroyIcon")]
//    //    public static extern bool DestroyIcon([In] IntPtr hIcon);

//    //    [return: MarshalAs(UnmanagedType.SysInt)]
//    //    [DllImport("user32.dll", EntryPoint = "DefDlgProc")]
//    //    public static extern int DefDlgProc(
//    //        [In] IntPtr hDlg, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "CreateCaret")]
//    //    public static extern bool CreateCaret([In] IntPtr hWnd, [In] IntPtr hBitmap, int nWidth, int nHeight);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "CloseWindow")]
//    //    public static extern bool CloseWindow([In] IntPtr hWnd);

//    //    [return: MarshalAs(UnmanagedType.LPStr)]
//    //    [DllImport("user32.dll", EntryPoint = "CharPrevEx")]
//    //    public static extern string CharPrevEx(
//    //        CP CodePage, [In] string lpStart, [In][MarshalAs(UnmanagedType.LPStr)] string lpCurrentChar, uint dwFlags);

//    //    [return: MarshalAs(UnmanagedType.LPStr)]
//    //    [DllImport("user32.dll", EntryPoint = "CharNextEx")]
//    //    public static extern string CharNextEx(CP CodePage, [In][MarshalAs(UnmanagedType.LPStr)] string lpCurrentChar, uint dwFlags);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "ChangeMenu")]
//    //    public static extern bool ChangeMenu([In] IntPtr hMenu, uint cmd, [In] string lpszNewItem, uint cmdInsert, MF flags);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "AppendMenu")]
//    //    public static extern bool AppendMenu([In] IntPtr hMenu, MF uFlags, [MarshalAs(UnmanagedType.SysUInt)] uint uIDNewItem, [In] string lpNewItem);

//    //    [DllImport("user32.dll", EntryPoint = "wvsprintf")]
//    //    public static extern int wvsprintf(
//    //        [Out] StringBuilder lpOutput, [In] string lpFmt, [In][MarshalAs(UnmanagedType.LPStr)] string arglist);

//    //    [DllImport("user32.dll", EntryPoint = "VkKeyScan")]
//    //    public static extern short VkKeyScan(char ch);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "ShowWindow")]
//    //    public static extern bool ShowWindow([In] IntPtr hWnd, int nCmdShow);

//    //    [DllImport("user32.dll", EntryPoint = "ShowCursor")]
//    //    public static extern int ShowCursor([MarshalAs(UnmanagedType.Bool)] bool bShow);

//    //    [DllImport("user32.dll", EntryPoint = "SetCapture")]
//    //    public static extern IntPtr SetCapture([In] IntPtr hWnd);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "RemoveMenu")]
//    //    public static extern bool RemoveMenu([In] IntPtr hMenu, uint uPosition, MF uFlags);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "OffsetRect")]
//    //    public static extern bool OffsetRect(ref RECT lprc, int dx, int dy);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "OemToChar")]
//    //    public static extern bool OemToChar([In][MarshalAs(UnmanagedType.LPStr)] string lpszSrc, [Out] StringBuilder lpszDst);

//    //    [DllImport("user32.dll", EntryPoint = "OemKeyScan")]
//    //    public static extern uint OemKeyScan(ushort wOemChar);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "MoveWindow")]
//    //    public static extern bool MoveWindow([In] IntPtr hWnd, int X, int Y, int nWidth, int nHeight, [MarshalAs(UnmanagedType.Bool)] bool bRepaint);

//    //    [DllImport("user32.dll", EntryPoint = "LoadImage")]
//    //    public static extern IntPtr LoadImage([In] IntPtr hInst, [In] string name, uint type, int cx, int cy, uint fuLoad);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "InvertRect")]
//    //    public static extern bool InvertRect([In] IntPtr hDC, [In] ref RECT lprc);

//    //    [DllImport("user32.dll", EntryPoint = "GetSubMenu")]
//    //    public static extern IntPtr GetSubMenu([In] IntPtr hMenu, int nPos);

//    //    [DllImport("user32.dll", EntryPoint = "GetDlgItem")]
//    //    public static extern IntPtr GetDlgItem([In] IntPtr hDlg, int nIDDlgItem);

//    //    [DllImport("user32.dll", EntryPoint = "GetCapture")]
//    //    public static extern IntPtr GetCapture();

//    //    [DllImport("user32.dll", EntryPoint = "EnumProps")]
//    //    public static extern int EnumProps([In] IntPtr hWnd, PropEnumProc lpEnumFunc);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DrawState")]
//    //    public static extern bool DrawState(
//    //        [In] IntPtr hdc, [In] IntPtr hbrFore, DrawStateProc qfnCallBack, [MarshalAs(UnmanagedType.SysInt)] int lData,
//    //        [MarshalAs(UnmanagedType.SysUInt)] uint wData, int x, int y, int cx, int cy, uint uFlags);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DrawIconEx")]
//    //    public static extern bool DrawIconEx(
//    //        [In] IntPtr hdc, int xLeft, int yTop, [In] IntPtr hIcon, int cxWidth, int cyWidth, uint istepIfAniCur, [In] IntPtr hbrFlickerFreeDraw, DI diFlags);

//    //    [DllImport("user32.dll", EntryPoint = "DragObject")]
//    //    public static extern uint DragObject([In] IntPtr hwndParent, [In] IntPtr hwndFrom, uint fmt, uint data, [In] IntPtr hcur);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DragDetect")]
//    //    public static extern bool DragDetect([In] IntPtr hwnd, POINT pt);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DeleteMenu")]
//    //    public static extern bool DeleteMenu([In] IntPtr hMenu, uint uPosition, MF uFlags);

//    //    [DllImport("user32.dll", EntryPoint = "DdeGetData")]
//    //    public static extern uint DdeGetData(IntPtr hData, ref byte pDst, uint cbMax, uint cbOff);

//    //    [DllImport("user32.dll", EntryPoint = "DdeConnect")]
//    //    public static extern IntPtr DdeConnect(uint idInst, IntPtr hszService, IntPtr hszTopic, ref CONVCONTEXT pCC);

//    //    [DllImport("user32.dll", EntryPoint = "DdeAddData")]
//    //    public static extern IntPtr DdeAddData(IntPtr hData, ref byte pSrc, uint cb, uint cbOff);

//    //    [DllImport("user32.dll", EntryPoint = "CreateMenu")]
//    //    public static extern IntPtr CreateMenu();

//    //    [DllImport("user32.dll", EntryPoint = "CreateIcon")]
//    //    public static extern IntPtr CreateIcon(
//    //        [In] IntPtr hInstance, int nWidth, int nHeight, byte cPlanes, byte cBitsPixel, [In] ref byte lpbANDbits, [In] ref byte lpbXORbits);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "ClipCursor")]
//    //    public static extern bool ClipCursor([In] ref RECT lpRect);

//    //    [DllImport("user32.dll", EntryPoint = "CharUpper")]
//    //    public static extern string CharUpper(string lpsz);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "CharToOem")]
//    //    public static extern bool CharToOem([In] string lpszSrc, [Out][MarshalAs(UnmanagedType.LPStr)] StringBuilder lpszDst);

//    //    [DllImport("user32.dll", EntryPoint = "CharLower")]
//    //    public static extern string CharLower(IntPtr lpsz);

//    //    [DllImport("user32.dll", EntryPoint = "BeginPaint")]
//    //    public static extern IntPtr BeginPaint([In] IntPtr hWnd, [Out] out PAINTSTRUCT lpPaint);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "UnionRect")]
//    //    public static extern bool UnionRect([Out] out RECT lprcDst, [In] ref RECT lprcSrc1, [In] ref RECT lprcSrc2);

//    //    [DllImport("user32.dll", EntryPoint = "ToUnicode")]
//    //    public static extern int ToUnicode(
//    //        uint wVirtKey, uint wScanCode, [In] IntPtr lpKeyState, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, TU wFlags);

//    //    [DllImport("user32.dll", EntryPoint = "ToAsciiEx")]
//    //    public static extern int ToAsciiEx(uint uVirtKey, uint uScanCode, [In] IntPtr lpKeyState, [Out] out ushort lpChar, TA uFlags, [In] IntPtr dwhkl);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "ShowCaret")]
//    //    public static extern bool ShowCaret([In] IntPtr hWnd);

//    //    [DllImport("user32.dll", EntryPoint = "SetParent")]
//    //    public static extern IntPtr SetParent([In] IntPtr hWndChild, [In] IntPtr hWndNewParent);

//    //    [DllImport("user32.dll", EntryPoint = "SetCursor")]
//    //    public static extern IntPtr SetCursor([In] IntPtr hCursor);

//    //    [DllImport("user32.dll", EntryPoint = "SendInput")]
//    //    public static extern uint SendInput(
//    //        uint nInputs, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 0)] INPUT[] pInputs, int cbSize);

//    //    [DllImport("user32.dll", EntryPoint = "ReleaseDC")]
//    //    public static extern int ReleaseDC([In] IntPtr hWnd, [In] IntPtr hDC);

//    //    [DllImport("user32.dll", EntryPoint = "LoadMenu")]
//    //    public static extern IntPtr LoadMenu([In] IntPtr hInstance, [In] string lpMenuName);

//    //    [DllImport("user32.dll", EntryPoint = "LoadIcon")]
//    //    public static extern IntPtr LoadIcon([In] IntPtr hInstance, [In] string lpIconName);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "KillTimer")]
//    //    public static extern bool KillTimer([In] IntPtr hWnd, [MarshalAs(UnmanagedType.SysUInt)] uint uIDEvent);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "HideCaret")]
//    //    public static extern bool HideCaret([In] IntPtr hWnd);

//    //    [DllImport("user32.dll", EntryPoint = "GetWindow")]
//    //    public static extern IntPtr GetWindow([In] IntPtr hWnd, GW uCmd);

//    //    [DllImport("user32.dll", EntryPoint = "GetParent")]
//    //    public static extern IntPtr GetParent([In] IntPtr hWnd);

//    //    [DllImport("user32.dll", EntryPoint = "GetCursor")]
//    //    public static extern IntPtr GetCursor();

//    //    [DllImport("user32.dll", EntryPoint = "FrameRect")]
//    //    public static extern int FrameRect([In] IntPtr hDC, [In] ref RECT lprc, [In] IntPtr hbr);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "EqualRect")]
//    //    public static extern bool EqualRect([In] ref RECT lprc1, [In] ref RECT lprc2);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "EndDialog")]
//    //    public static extern bool EndDialog([In] IntPtr hDlg, int nResult);

//    //    [DllImport("user32.dll", EntryPoint = "DrawText")]
//    //    public static extern int DrawText([In] IntPtr hDC, StringBuilder lpchText, int nCount, ref RECT lpRect, uint uFormat);

//    //    [DllImport("user32.dll", EntryPoint = "CopyImage")]
//    //    public static extern IntPtr CopyImage([In] IntPtr h, uint type, int cx, int cy, LR flags);

//    //    [DllImport("user32.dll", EntryPoint = "CharPrev")]
//    //    public static extern string CharPrev([In] string lpszStart, [In] string lpszCurrent);

//    //    [DllImport("user32.dll", EntryPoint = "CharNext")]
//    //    public static extern string CharNext([In] string lpsz);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "WinHelp")]
//    //    public static extern bool WinHelp([In] IntPtr hWndMain, [In] string lpszHelp, uint uCommand, uint dwData);

//    //    [return: MarshalAs(UnmanagedType.SysUInt)]
//    //    [DllImport("user32.dll", EntryPoint = "SetTimer")]
//    //    public static extern uint SetTimer([In] IntPtr hWnd, [MarshalAs(UnmanagedType.SysUInt)] uint nIDEvent, uint uElapse, TimerProc lpTimerFunc);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetProp")]
//    //    public static extern bool SetProp([In] IntPtr hWnd, [In] string lpString, [In] IntPtr hData);

//    //    [DllImport("user32.dll", EntryPoint = "SetFocus")]
//    //    public static extern IntPtr SetFocus([In] IntPtr hWnd);

//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "ScrollDC")]
//    //    public static extern bool ScrollDC([In] IntPtr hDC, int dx, int dy, [In] ref RECT lprcScroll, [In] ref RECT lprcClip, [In] IntPtr hrgnUpdate, ref RECT lprcUpdate);


//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "PtInRect")]
//    //    public static extern bool PtInRect([In] ref RECT lprc, POINT pt);


//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "OpenIcon")]
//    //    public static extern bool OpenIcon([In] IntPtr hWnd);


//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "IsZoomed")]
//    //    public static extern bool IsZoomed([In] IntPtr hWnd);


//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "IsWindow")]
//    //    public static extern bool IsWindow([In] IntPtr hWnd);


//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "IsIconic")]
//    //    public static extern bool IsIconic([In] IntPtr hWnd);


//    //    [DllImport("user32.dll", EntryPoint = "GetProp")]
//    //    public static extern IntPtr GetProp([In] IntPtr hWnd, [In] string lpString);


//    //    [DllImport("user32.dll", EntryPoint = "GetFocus")]
//    //    public static extern IntPtr GetFocus();


//    //    [DllImport("user32.dll", EntryPoint = "FillRect")]
//    //    public static extern int FillRect([In] IntPtr hDC, [In] ref RECT lprc, [In] IntPtr hbr);


//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "EndPaint")]
//    //    public static extern bool EndPaint([In] IntPtr hWnd, [In] ref PAINTSTRUCT lpPaint);


//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DrawIcon")]
//    //    public static extern bool DrawIcon([In] IntPtr hDC, int X, int Y, [In] IntPtr hIcon);


//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "DrawEdge")]
//    //    public static extern bool DrawEdge([In] IntPtr hdc, ref RECT qrc, uint edge, BF grfFlags);


//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "CopyRect")]
//    //    public static extern bool CopyRect([Out] out RECT lprcDst, [In] ref RECT lprcSrc);


//    //    [DllImport("user32.dll", EntryPoint = "CopyIcon")]
//    //    public static extern IntPtr CopyIcon([In] IntPtr hIcon);


//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "AnyPopup")]
//    //    public static extern bool AnyPopup();


//    //    [DllImport("user32.dll", EntryPoint = "ToAscii")]
//    //    public static extern int ToAscii(uint uVirtKey, uint uScanCode, [In] IntPtr lpKeyState, [Out] out ushort lpChar, TA uFlags);


//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetRect")]
//    //    public static extern bool SetRect([Out] out RECT lprc, int xLeft, int yTop, int xRight, int yBottom);


//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "SetMenu")]
//    //    public static extern bool SetMenu([In] IntPtr hWnd, [In] IntPtr hMenu);


//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "IsChild")]
//    //    public static extern bool IsChild([In] IntPtr hWndParent, [In] IntPtr hWnd);


//    //    [DllImport("user32.dll", EntryPoint = "GetMenu")]
//    //    public static extern IntPtr GetMenu([In] IntPtr hWnd);


//    //    [DllImport("user32.dll", EntryPoint = "GetDCEx")]
//    //    public static extern IntPtr GetDCEx([In] IntPtr hWnd, [In] IntPtr hrgnClip, DCX flags);


//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "EndMenu")]
//    //    public static extern bool EndMenu();


//    //    [return: MarshalAs(UnmanagedType.Bool)]
//    //    [DllImport("user32.dll", EntryPoint = "IsMenu")]
//    //    public static extern bool IsMenu([In] IntPtr hMenu);


//    //    [DllImport("user32.dll", EntryPoint = "GetDC")]
//    //    public static extern IntPtr GetDC([In] IntPtr hWnd);

//    //    #endregion
//    #endregion

//}
