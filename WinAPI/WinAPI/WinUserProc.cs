using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace WinAPI
{
    /// <summary>
    /// dcrenl:2022-12-26 11:11:23
    /// 
    /// </summary>
    /// <param name="hwnd"></param>
    /// <param name="uMsg"></param>
    /// <param name="wParam"></param>
    /// <param name="lParam"></param>
    /// <returns></returns>
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int WindowProc(IntPtr hwnd, uint uMsg, IntPtr wParam, IntPtr lParam);
}
