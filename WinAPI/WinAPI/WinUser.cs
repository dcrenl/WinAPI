using System;
using System.Runtime.InteropServices;

namespace WinAPI
{
    /// <summary>
    /// dcrenl:2022-11-24 13:01:00
    /// C#调用windows系统中的user32.dll中的方法，函数参考微软官方文档
    /// 因官方引用头文件名称为：winuser.h所以C#类名沿用官方为WinUser
    /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/
    /// </summary>
    public class WinUser
    {
        private const string _dllName = "user32.dll";

        #region user32.dll函数

        /// <summary>
        /// 设置输入区域设置标识符 (以前称为调用线程或当前进程的键盘布局句柄) 。 输入区域设置标识符指定区域设置和键盘的物理布局。
        /// 此函数仅影响当前进程或线程的布局。
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-activatekeyboardlayout
        /// </summary>
        /// <param name="hkl">要激活的输入区域设置标识符。
        /// 1：在系统维护的已加载区域设置标识符的循环列表中选择下一个区域设置标识符。
        /// 0：在系统维护的已加载区域设置标识符的循环列表中选择以前的区域设置标识符。</param>
        /// <param name="Flags">指定如何激活输入区域设置标识符</param>
        /// <returns>返回值的类型为 HKL。 如果函数成功，则返回值为以前的输入区域设置标识符。 否则为零。</returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ActivateKeyboardLayout(IntPtr hkl, KLF Flags, string _dllName);

        /// <summary>
        /// 将给定窗口置于系统维护的剪贴板格式侦听器列表中。
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-addclipboardformatlistener
        /// </summary>
        /// <param name="hkl">要放置在剪贴板格式侦听器列表中的窗口的句柄。</param>
        /// <returns>如果成功，则返回 TRUE ;否则返回 FALSE 。</returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddClipboardFormatListener(IntPtr hwnd);

        /// <summary>
        /// 根据所需的客户端矩形大小计算窗口矩形的所需大小。 然后，窗口矩形可以传递给 CreateWindow 函数，以创建其工作区为所需大小的窗口。
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-adjustwindowrect
        /// </summary>
        /// <param name="lpRect">指向 RECT 结构的指针，该结构包含所需工作区左上角和右下角的坐标。 函数返回时，结构包含窗口左上角和右下角的坐标，以适应所需的工作区。</param>
        /// <param name="dwStyle">要计算所需大小的窗口的 窗口样式 。 请注意，不能指定 WS_OVERLAPPED 样式。</param>
        /// <param name="bMenu">指示窗口是否具有菜单。</param>
        /// <returns>如果该函数成功，则返回值为非零值。如果函数失败，则返回值为零。 要获得更多的错误信息，请调用 GetLastError。</returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AdjustWindowRect(ref RECT lpRect, WS dwStyle, [MarshalAs(UnmanagedType.Bool)] bool bMenu);


        /// <summary>
        /// 根据客户端矩形的所需大小计算窗口矩形的所需大小。 然后，窗口矩形可以传递给 CreateWindowEx 函数，以创建其工作区为所需大小的窗口。
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-adjustwindowrectex
        /// </summary>
        /// <param name="lpRect">指向 RECT 结构的指针，该结构包含所需工作区左上角和右下角的坐标。 函数返回时，结构包含窗口左上角和右下角的坐标，以适应所需的工作区。</param>
        /// <param name="dwStyle">要计算所需大小的窗口的 窗口样式 。 请注意，不能指定 WS_OVERLAPPED 样式。</param>
        /// <param name="bMenu">指示窗口是否具有菜单。</param>
        /// <param name="dwExStyle">要计算所需大小的 窗口的扩展窗口样式 。</param>
        /// <returns>如果该函数成功，则返回值为非零值。如果函数失败，则返回值为零。 要获得更多的错误信息，请调用 GetLastError。</returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AdjustWindowRect(ref RECT lpRect, WS dwStyle, [MarshalAs(UnmanagedType.Bool)] bool bMenu, WS dwExStyle);


        #endregion
    }
}
