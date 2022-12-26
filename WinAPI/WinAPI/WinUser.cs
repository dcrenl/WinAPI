using System;
using System.Drawing;
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
        /// dcrenl:2022-11-24 13:06:40
        /// 设置输入区域设置标识符 (以前称为调用线程或当前进程的键盘布局句柄) 。 输入区域设置标识符指定区域设置和键盘的物理布局。
        /// 此函数仅影响当前进程或线程的布局。
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-activatekeyboardlayout
        /// </summary>
        /// <param name="hkl">要激活的输入区域设置标识符。
        /// 1：在系统维护的已加载区域设置标识符的循环列表中选择下一个区域设置标识符。
        /// 0：在系统维护的已加载区域设置标识符的循环列表中选择以前的区域设置标识符。</param>
        /// <param name="Flags">指定如何激活输入区域设置标识符</param>
        /// <returns>返回值的类型为 HKL。 如果函数成功，则返回值为以前的输入区域设置标识符。 否则为零。</returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]//, CallingConvention = CallingConvention.StdCall
        public static extern IntPtr ActivateKeyboardLayout(IntPtr hkl, KLF Flags, string _dllName);

        /// <summary>
        /// dcrenl:2022-11-24 13:06:40
        /// 将给定窗口置于系统维护的剪贴板格式侦听器列表中。
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-addclipboardformatlistener
        /// </summary>
        /// <param name="hkl">要放置在剪贴板格式侦听器列表中的窗口的句柄。</param>
        /// <returns>如果成功，则返回 TRUE ;否则返回 FALSE 。</returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddClipboardFormatListener(IntPtr hwnd);

        /// <summary>
        /// dcrenl:2022-11-24 13:06:40
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
        /// dcrenl:2022-11-24 13:06:40
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
        public static extern bool AdjustWindowRectEx(ref RECT lpRect, WS dwStyle, [MarshalAs(UnmanagedType.Bool)] bool bMenu, WS dwExStyle);

        /// <summary>
        /// dcrenl:2022-11-24 13:06:40
        /// 根据所需的客户端矩形大小和提供的 DPI 计算窗口矩形所需的大小。 然后，可以将此窗口矩形传递给 CreateWindowEx 函数，以创建具有所需大小的工作区的窗口。
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-adjustwindowrectexfordpi
        /// </summary>
        /// <param name="lpRect">指向 RECT 结构的指针，该结构包含所需工作区的左上角和右下角的坐标。 函数返回时，结构包含窗口左上角和右下角的坐标，以适应所需的工作区。</param>
        /// <param name="dwStyle">要计算所需大小的窗口的 窗口样式 。 请注意，不能指定 WS_OVERLAPPED 样式。</param>
        /// <param name="bMenu">指示窗口是否具有菜单。</param>
        /// <param name="dwExStyle">要计算所需大小的窗口的 扩展窗口样式 。</param>
        /// <param name="dpi">用于缩放的 DPI。</param>
        /// <returns>如果该函数成功，则返回值为非零值。如果函数失败，则返回值为零。 要获得更多的错误信息，请调用 GetLastError。</returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AdjustWindowRectExForDpi(ref RECT lpRect, WS dwStyle, [MarshalAs(UnmanagedType.Bool)] bool bMenu, WS dwExStyle, uint dpi);

        /// <summary>
        /// dcrenl:2022-11-24 13:06:40
        /// 使指定的进程能够使用SetForegroundWindow函数设置前台窗口。调用进程必须已经能够设置前台窗口。有关详细信息，请参阅本主题后面的备注。
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-allowsetforegroundwindow
        /// </summary>
        /// <param name="dwProcessId">使指定的进程能够使用SetForegroundWindow函数设置前台窗口。调用进程必须已经能够设置前台窗口。有关详细信息，请参阅本主题后面的备注。</param>
        /// <returns>如果函数成功，则返回值为非零值。</returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllowSetForegroundWindow(uint dwProcessId);

        /// <summary>
        /// dcrenl:2022-11-24 13:06:40
        /// 使你可以在显示或隐藏窗口时产生特殊效果。 有四种类型的动画：滚动、幻灯片、折叠或展开和 alpha 混合淡化。
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-animatewindow
        /// </summary>
        /// <param name="hWnd">要设置动画的窗口的句柄。 调用线程必须拥有此窗口。</param>
        /// <param name="dwTime">播放动画所需的时间（以毫秒为单位）。 通常，播放一个动画需要 200 毫秒。</param>
        /// <param name="dwFlags">动画的类型。 此参数可使用以下一个或多个值。 请注意，默认情况下，这些标志在显示窗口时生效。 
        /// 若要在隐藏窗口时生效，请使用具有相应标志 的AW_HIDE 和逻辑 OR 运算符。</param>
        /// <returns>如果该函数成功，则返回值为非零值。
        /// 如果函数失败，则返回值为零。 在以下情况下，该函数将失败：
        /// 如果窗口已可见，并且你正尝试显示该窗口。
        /// 如果窗口已隐藏，并且你正尝试隐藏该窗口。
        /// 如果没有为幻灯片或滚动动画指定方向。
        /// 尝试使用 AW_BLEND 对子窗口进行动画处理时。
        /// 如果线程不拥有窗口。 请注意，在这种情况下， AnimateWindow 失败，但 GetLastError 返回 ERROR_SUCCESS。
        /// </returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AnimateWindow(IntPtr hWnd, uint dwTime, AW dwFlags);

        /// <summary>
        /// dcrenl:2022-11-24 13:06:40
        /// 指示屏幕上是否存在拥有、可见、顶级弹出窗口或重叠窗口。 该函数将搜索整个屏幕，而不仅仅是调用应用程序的工作区。
        /// 此函数仅用于与 16 位版本的 Windows 兼容。 它通常不有用。
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-anypopup
        /// </summary>
        /// <returns>如果弹出窗口存在，则返回值为非零，即使弹出窗口被其他窗口完全覆盖也是如此。</returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AAnyPopup();

        /// <summary>
        /// dcrenl:2022-11-24 13:06:40
        /// 将新项追加到指定菜单栏的末尾、下拉菜单、子菜单或快捷菜单。 可以使用此函数指定菜单项的内容、外观和行为。 (ANSI)
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-appendmenua
        /// </summary>
        /// <param name="hMenu">要更改的菜单栏、下拉菜单、子菜单或快捷菜单的句柄。</param>
        /// <param name="uFlags">控制新菜单项的外观和行为。</param>
        /// <param name="uIDNewItem">新菜单项的标识符;如果 uFlags 参数设置为 MF_POPUP，则为下拉菜单或子菜单的句柄。</param>
        /// <param name="lpNewItem">新菜单项的内容。 lpNewItem 的解释取决于 uFlags 参数</param>
        /// <returns>如果该函数成功，则返回值为非零值。 如果函数失败，则返回值为零。</returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AppendMenuA(IntPtr hMenu, MF uFlags, [MarshalAs(UnmanagedType.SysUInt)] uint uIDNewItem, MF lpNewItem);

        /// <summary>
        /// dcrenl:2022-11-24 13:06:40
        /// 将新项追加到指定菜单栏的末尾、下拉菜单、子菜单或快捷菜单。 可以使用此函数指定菜单项的内容、外观和行为。 (Unicode)
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-appendmenuw
        /// </summary>
        /// <param name="hMenu">要更改的菜单栏、下拉菜单、子菜单或快捷菜单的句柄。</param>
        /// <param name="uFlags">控制新菜单项的外观和行为。</param>
        /// <param name="uIDNewItem">新菜单项的标识符;如果 uFlags 参数设置为 MF_POPUP，则为下拉菜单或子菜单的句柄。</param>
        /// <param name="lpNewItem">新菜单项的内容。 lpNewItem 的解释取决于 uFlags 参数</param>
        /// <returns>如果该函数成功，则返回值为非零值。 如果函数失败，则返回值为零。</returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AppendMenuW(IntPtr hMenu, MF uFlags, [MarshalAs(UnmanagedType.SysUInt)] uint uIDNewItem, MF lpNewItem);

        /// <summary>
        /// dcrenl:2022-11-24 13:06:40
        /// 确定两个DPI_AWARENESS_CONTEXT值是否相同。
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-aredpiawarenesscontextsequal
        /// </summary>
        /// <param name="dpiContextA"></param>
        /// <param name="dpiContextB"></param>
        /// <returns>如果值相等，则返回 TRUE ，否则返回 FALSE。</returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AreDpiAwarenessContextsEqual(DPI_AWARENESS dpiContextA, DPI_AWARENESS dpiContextB);

        /// <summary>
        /// dcrenl:2022-11-24 13:06:40
        /// 排列指定父窗口的所有最小化(标志性) 子窗口。
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-arrangeiconicwindows
        /// </summary>
        /// <param name="hWnd">父窗口的句柄。</param>
        /// <returns>如果函数成功，则返回值是一行图标的高度。如果函数失败，则返回值为零。</returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern uint ArrangeIconicWindows(IntPtr hWnd);

        /// <summary>
        /// dcrenl:2022-11-24 13:06:40
        /// 将一个线程的输入处理机制附加到另一个线程的输入处理机制。
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-attachthreadinput
        /// </summary>
        /// <param name="idAttach">要附加到另一个线程的线程的标识符。 要附加的线程不能是系统线程。</param>
        /// <param name="idAttachTo">idAttach 将附加到的线程的标识符。 此线程不能是系统线程。线程无法附加到自身。 因此， idAttachTo 不能等于 idAttach。</param>
        /// <param name="fAttach">如果此参数为 TRUE，则附加两个线程。 如果参数为 FALSE，则分离线程。</param>
        /// <returns>如果此参数为 TRUE，则附加两个线程。 如果参数为 FALSE，则分离线程。</returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AttachThreadInput(uint idAttach, uint idAttachTo, [MarshalAs(UnmanagedType.Bool)] bool fAttach);

        /// <summary>
        /// dcrenl:2022-11-24 13:06:40
        /// 为多窗口位置结构分配内存，并将句柄返回到结构。
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-begindeferwindowpos
        /// </summary>
        /// <param name="nNumWindows">要为其存储位置信息的窗口的初始数目。 如果需要，DeferWindowPos 函数会增加结构的大小。</param>
        /// <returns>如果函数成功，则返回值将标识多窗口位置结构。 如果系统资源不足而无法分配结构，则返回值为 NULL。</returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr BeginDeferWindowPos(int nNumWindows);

        /// <summary>
        /// dcrenl:2022-11-24 13:06:40
        /// BeginPaint 函数准备用于绘制的指定窗口，并使用有关绘图的信息填充 PAINTSTRUCT 结构。
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-beginpaint
        /// </summary>
        /// <param name="hWnd">要重新绘制的窗口的句柄。</param>
        /// <param name="lpPaint">指向将接收绘画信息的 PAINTSTRUCT 结构的指针。</param>
        /// <returns>如果函数成功，则返回值是指定窗口的显示设备上下文的句柄。如果函数失败，则返回值为 NULL，指示没有显示设备上下文可用。</returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr BeginPaint(IntPtr hWnd, out PAINTSTRUCT lpPaint);

        /// <summary>
        /// dcrenl:2022-11-24 13:06:40
        /// 阻止键盘和鼠标输入事件到达应用程序。
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-blockinput
        /// </summary>
        /// <param name="fBlockIt">函数的用途。 如果此参数为 TRUE，则阻止键盘和鼠标输入事件。 
        /// 如果此参数为 FALSE，则取消阻止键盘和鼠标事件。 请注意，只有阻止输入的线程才能成功取消阻止输入。</param>
        /// <returns>如果该函数成功，则返回值为非零值。如果输入已被阻止，则返回值为零。</returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr BlockInput([MarshalAs(UnmanagedType.Bool)] bool fBlockIt);

        /// <summary>
        /// dcrenl:2022-11-25 10:14:00
        /// 将指定的窗口置于 Z 顺序的顶部。 如果窗口是顶级窗口，则会激活该窗口。 如果窗口是子窗口，则会激活与子窗口关联的顶级父窗口。
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-bringwindowtotop
        /// </summary>
        /// <param name="hWnd">要置于 Z 顺序顶部的窗口的句柄。</param>
        /// <returns>如果该函数成功，则返回值为非零值。如果函数失败，则返回值为零。</returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BringWindowToTop([In] IntPtr hWnd);

        /// <summary>
        /// dcrenl:2022-11-25 10:19:53
        /// 将邮件发送到指定的收件人。 (BroadcastSystemMessageW)
        /// 向指定收件人发送邮件。 收件人可以是应用程序、可安装驱动程序、网络驱动程序、系统级设备驱动程序或这些系统组件的任何组合。
        /// 若要在定义请求时接收其他信息，请使用 BroadcastSystemMessageEx 函数。
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-broadcastsystemmessage
        /// </summary>
        /// <param name="flags">广播选项。</param>
        /// <param name="lpInfo">指向包含和接收有关邮件收件人信息的变量的指针。
        /// 当函数返回时，此变量将接收这些值的组合，这些值标识哪些收件人实际接收了邮件。
        /// 如果此参数为 NULL，则该函数将广播到所有组件。</param>
        /// <param name="Msg">要发送的消息。 有关系统提供的消息的列表，请参阅 系统定义的消息。</param>
        /// <param name="wParam">其他的消息特定信息。</param>
        /// <param name="lParam">其他的消息特定信息。</param>
        /// <returns>如果函数成功，则返回值为正值。如果函数无法广播消息，则返回值为 –1。
        /// 如果 dwFlags 参数 BSF_QUERY 且至少一个收件人 BROADCAST_QUERY_DENY 返回相应邮件，则返回值为零。 </returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern int BroadcastSystemMessage(BSF flags, IntPtr lpInfo, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// <summary>
        /// dcrenl:2022-11-25 16:05:27
        /// 将邮件发送到指定的收件人。 (BroadcastSystemMessageA)
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-broadcastsystemmessagea
        /// </summary>
        /// <param name="flags">广播选项。</param>
        /// <param name="lpInfo">指向包含和接收有关邮件收件人信息的变量的指针。
        /// 当函数返回时，此变量将接收这些值的组合，这些值标识哪些收件人实际接收了邮件。
        /// 如果此参数为 NULL，则该函数将广播到所有组件。</param>
        /// <param name="Msg">要发送的消息。 有关系统提供的消息的列表，请参阅 系统定义的消息。</param>
        /// <param name="wParam">其他的消息特定信息。</param>
        /// <param name="lParam">其他的消息特定信息。</param>
        /// <returns>如果函数成功，则返回值为正值。如果函数无法广播消息，则返回值为 –1。
        /// 如果 dwFlags 参数 BSF_QUERY 且至少一个收件人 BROADCAST_QUERY_DENY 返回相应邮件，则返回值为零。 </returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern int BroadcastSystemMessageA(BSF flags, IntPtr lpInfo, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// <summary>
        /// dcrenl:2022-11-25 16:13:20
        /// 将邮件发送到指定的收件人。 (BroadcastSystemMessageExA)
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-broadcastsystemmessageexa
        /// </summary>
        /// <param name="flags">广播选项。</param>
        /// <param name="lpInfo">指向包含和接收有关邮件收件人信息的变量的指针。
        /// 当函数返回时，此变量将接收这些值的组合，这些值标识哪些收件人实际接收了邮件。
        /// 如果此参数为 NULL，则该函数将广播到所有组件。</param>
        /// <param name="Msg">要发送的消息。</param>
        /// <param name="wParam">其他的消息特定信息。</param>
        /// <param name="lParam">其他的消息特定信息。</param>
        /// <param name="pbsmInfo">指向BSMINFO结构的指针，该结构包含请求被拒绝且dwFlags设置为BSF_QUERY 时的其他信息。</param>
        /// <returns>如果函数成功，则返回值为正值。如果函数无法广播消息，则返回值为 –1。
        /// 如果dwFlags参数为BSF_QUERY，并且至少有一个收件人返回了相应邮件BROADCAST_QUERY_DENY，则返回值为零。</returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern int BroadcastSystemMessageExA(BSF flags, IntPtr lpInfo, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam, ref BSMINFO pbsmInfo);

        /// <summary>
        /// dcrenl:2022-11-25 16:16:44
        /// 将邮件发送到指定的收件人。 (BroadcastSystemMessageExW)
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-broadcastsystemmessageexw
        /// </summary>
        /// <param name="flags">广播选项。</param>
        /// <param name="lpInfo">指向包含和接收有关邮件收件人信息的变量的指针。
        /// 当函数返回时，此变量将接收这些值的组合，这些值标识哪些收件人实际接收了邮件。
        /// 如果此参数为 NULL，则该函数将广播到所有组件。</param>
        /// <param name="Msg">要发送的消息。</param>
        /// <param name="wParam">其他的消息特定信息。</param>
        /// <param name="lParam">其他的消息特定信息。</param>
        /// <param name="pbsmInfo">指向BSMINFO结构的指针，该结构包含请求被拒绝且dwFlags设置为BSF_QUERY 时的其他信息。</param>
        /// <returns>如果函数成功，则返回值为正值。如果函数无法广播消息，则返回值为 –1。
        /// 如果dwFlags参数为BSF_QUERY，并且至少有一个收件人返回了相应邮件BROADCAST_QUERY_DENY，则返回值为零。</returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern int BroadcastSystemMessageExW(BSF flags, IntPtr lpInfo, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam, ref BSMINFO pbsmInfo);

        /// <summary>
        /// dcrenl:2022-11-25 16:21:08
        /// 将邮件发送到指定的收件人。 (BroadcastSystemMessageW)
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-broadcastsystemmessagew
        /// </summary>
        /// <param name="flags">广播选项。</param>
        /// <param name="lpInfo">指向包含和接收有关邮件收件人信息的变量的指针。
        /// 当函数返回时，此变量将接收这些值的组合，这些值标识哪些收件人实际接收了邮件。
        /// 如果此参数为 NULL，则该函数将广播到所有组件。</param>
        /// <param name="Msg">要发送的消息。 有关系统提供的消息的列表，请参阅 系统定义的消息。</param>
        /// <param name="wParam">其他的消息特定信息。</param>
        /// <param name="lParam">其他的消息特定信息。</param>
        /// <returns>如果函数成功，则返回值为正值。如果函数无法广播消息，则返回值为 –1。
        /// 如果 dwFlags 参数 BSF_QUERY 且至少一个收件人 BROADCAST_QUERY_DENY 返回相应邮件，则返回值为零。 </returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern int BroadcastSystemMessageW(BSF flags, IntPtr lpInfo, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// <summary>
        /// dcrenl:2022-11-25 16:23:18
        /// 使用指定的定位点、弹出窗口大小、标志和可选的排除矩形计算相应的弹出窗口位置。 
        /// 当指定的弹出窗口大小小于桌面窗口大小时，请使用 CalculatePopupWindowPosition 函数来确保无论指定的定位点如何，弹出窗口在桌面窗口中完全可见。
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-calculatepopupwindowposition
        /// </summary>
        /// <param name="anchorPoint">指定的定位点。</param>
        /// <param name="windowSize">指定的窗口大小。</param>
        /// <param name="flags">使用以下标志之一指定函数如何水平和垂直定位弹出窗口。 标志与 TrackPopupMenuEx 函数的垂直和水平定位标志相同。</param>
        /// <param name="excludeRect">指向指定排除矩形的结构的指针。 它可以为 NULL。</param>
        /// <param name="popupWindowPosition">指向指定弹出窗口位置的结构的指针。</param>
        /// <returns>如果函数成功，则返回 TRUE;否则，它将返回 FALSE。</returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CalculatePopupWindowPosition(ref POINT anchorPoint, ref SIZE windowSize, uint flags, ref RECT excludeRect, out RECT popupWindowPosition);

        /// <summary>
        /// dcrenl:2022-12-06 12:49:56
        /// 将指定的消息和挂钩代码传递给与WH_SYSMSGFILTER和WH_MSGFILTER挂钩关联的挂钩过程。 (ANSI)
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-callmsgfiltera
        /// </summary>
        /// <param name="lpMsg">指向包含要传递给挂钩过程的消息的 MSG 结构的指针。</param>
        /// <param name="nCode">挂钩过程用来确定如何处理消息的应用程序定义代码。 代码不能与系统定义的挂钩代码具有相同的值， (MSGF_与 WH_SYSMSGFILTER 和WH_MSGFILTER挂钩关联的 HC_) 。</param>
        /// <returns>如果应用程序应进一步处理消息，则返回值为零。 如果应用程序不应进一步处理消息，则返回值为非零。</returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CallMsgFilterA(MSG lpMsg, int nCode);

        /// <summary>
        /// dcrenl:2022-12-06 12:56:50
        /// 将指定的消息和挂钩代码传递给与WH_SYSMSGFILTER和WH_MSGFILTER挂钩关联的挂钩过程。 (Unicode)
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-callmsgfilterw
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CallMsgFilterW(MSG lpMsg, int nCode);

        /// <summary>
        /// dcrenl:2022-12-06 12:57:54
        /// 将挂钩信息传递到当前挂钩链中的下一个挂钩过程。 挂钩过程可以在处理挂钩信息之前或之后调用此函数。
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-callnexthookex
        /// </summary>
        /// <param name="hhk">HHOOK 忽略此参数。</param>
        /// <param name="nCode">传递给当前挂钩过程的挂钩代码。 下一个挂钩过程使用此代码来确定如何处理挂钩信息。</param>
        /// <param name="wParam">传递给当前挂钩过程的 wParam 值。 此参数的含义取决于与当前挂钩链关联的挂钩类型。</param>
        /// <param name="lParam">传递给当前挂钩过程的 lParam 值。 此参数的含义取决于与当前挂钩链关联的挂钩类型。</param>
        /// <returns>此值由链中的下一个挂钩过程返回。 当前挂钩过程还必须返回此值。 返回值的含义取决于挂钩类型。 有关详细信息，请参阅各个挂钩过程的说明。</returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// dcrenl:2022-12-26 10:59:31
        /// 将消息信息传递给指定的窗口过程。 (ANSI)
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-callwindowproca
        /// </summary>
        /// <param name="lpPrevWndFunc"></param>
        /// <param name="hWnd"></param>
        /// <param name="Msg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CallWindowProcA(WindowProc lpPrevWndFunc, IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// dcrenl:2022-12-26 11:13:20
        /// 将消息信息传递给指定的窗口过程。 (Unicode)
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-callwindowprocw
        /// </summary>
        /// <param name="lpPrevWndFunc"></param>
        /// <param name="hWnd"></param>
        /// <param name="Msg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CallWindowProcW(WindowProc lpPrevWndFunc, IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// dcrenl:2022-12-26 11:14:25
        /// 级联指定父窗口的指定子窗口。
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-cascadewindows
        /// </summary>
        /// <param name="hwndParent"></param>
        /// <param name="wHow"></param>
        /// <param name="lpRect"></param>
        /// <param name="cKids"></param>
        /// <param name="lpKids"></param>
        /// <returns></returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern ushort CascadeWindows([In] IntPtr hwndParent, uint wHow, [In] ref RECT lpRect, uint cKids, ref IntPtr lpKids);

        /// <summary>
        /// dcrenl:2022-12-26 11:16:14
        /// 从剪贴板查看器链中删除指定的窗口。
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-changeclipboardchain
        /// </summary>
        /// <param name="hWndRemove"></param>
        /// <param name="hWndNewNext"></param>
        /// <returns></returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

        /// <summary>
        /// dcrenl:2022-12-26 11:17:48
        /// ChangeDisplaySettings 函数将默认显示设备的设置更改为指定的图形模式。 (ANSI)
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-changedisplaysettingsa
        /// </summary>
        /// <param name="lpDevMode"></param>
        /// <param name="dwFlags"></param>
        /// <returns></returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern long ChangeDisplaySettingsA([In] ref DEVMODE lpDevMode, uint dwFlags);

        /// <summary>
        /// dcrenl:2022-12-26 11:29:55
        /// ChangeDisplaySettingsEx 函数将指定显示设备的设置更改为指定的图形模式。 (ANSI)
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-changedisplaysettingsexa
        /// </summary>
        /// <param name="lpszDeviceName"></param>
        /// <param name="lpDevMode"></param>
        /// <param name="hwnd"></param>
        /// <param name="dwFlags"></param>
        /// <param name="lParamm"></param>
        /// <returns></returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern long ChangeDisplaySettingsExA([In] string lpszDeviceName, [In] ref DEVMODE lpDevMode, IntPtr hwnd, CDS dwFlags, [In] IntPtr lParamm);

        /// <summary>
        /// dcrenl:2022-12-26 11:33:29
        /// ChangeDisplaySettingsEx 函数将指定显示设备的设置更改为指定的图形模式。 (Unicode)
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-changedisplaysettingsexw
        /// </summary>
        /// <param name="lpszDeviceName"></param>
        /// <param name="lpDevMode"></param>
        /// <param name="hwnd"></param>
        /// <param name="dwFlags"></param>
        /// <param name="lParamm"></param>
        /// <returns></returns>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern long ChangeDisplaySettingsExW([In] string lpszDeviceName, [In] ref DEVMODE lpDevMode, IntPtr hwnd, CDS dwFlags, [In] IntPtr lParamm);

        /// <summary>
        /// dcrenl:2022-12-26 11:37:10
        /// ChangeDisplaySettings 函数将默认显示设备的设置更改为指定的图形模式。 (Unicode)
        /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-changedisplaysettingsw
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern long ChangeDisplaySettingsW([In] ref DEVMODE lpDevMode, CDS dwFlags);

        /// <summary>
        /// 在用户界面特权隔离(UIPI) 消息筛选器中添加或删除消息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ChangeWindowMessageFilter();

        /// <summary>
        /// 修改指定窗口的用户界面特权隔离(UIPI) 消息筛选器。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ChangeWindowMessageFilterEx();

        /// <summary>
        /// 将字符串或单个字符转换为小写。 如果操作数是一个字符串，则函数将就地转换字符。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CharLowerA();

        /// <summary>
        /// 将缓冲区中的大写字符转换为小写字符。 该函数将就地转换字符。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CharLowerBuffA();

        /// <summary>
        /// 将缓冲区中的大写字符转换为小写字符。 该函数将就地转换字符。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CharLowerBuffW();

        /// <summary>
        /// 将字符串或单个字符转换为小写。 如果操作数是一个字符串，则函数将就地转换字符。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CharLowerW();

        /// <summary>
        /// 检索指向字符串中下一个字符的指针。 此函数可以处理包含单字节字符或多字节字符的字符串。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CharNextA();

        /// <summary>
        /// 检索指向字符串中下一个字符的指针。 此函数可以处理包含单字节字符或多字节字符的字符串。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CharNextExA();

        /// <summary>
        /// 检索指向字符串中下一个字符的指针。 此函数可以处理包含单字节字符或多字节字符的字符串。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CharNextW();

        /// <summary>
        /// 检索指向字符串中上述字符的指针。 此函数可以处理包含单字节字符或多字节字符的字符串。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CharPrevA();

        /// <summary>
        /// 检索指向字符串中上述字符的指针。 此函数可以处理包含单字节字符或多字节字符的字符串。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CharPrevExA();

        /// <summary>
        /// 检索指向字符串中上述字符的指针。 此函数可以处理包含单字节字符或多字节字符的字符串。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CharPrevW();

        /// <summary>
        /// 将字符串转换为 OEM 定义的字符集。警告不使用。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CharToOemA();

        /// <summary>
        /// 将字符串中的指定字符数转换为 OEM 定义的字符集。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CharToOemBuffA();

        /// <summary>
        /// 将字符串中的指定字符数转换为 OEM 定义的字符集。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CharToOemBuffW();

        /// <summary>
        /// 将字符串转换为 OEM 定义的字符集。警告不使用。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CharToOemW();

        /// <summary>
        /// 将字符串或单个字符转换为大写。 如果操作数是一个字符串，则函数将就地转换字符。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CharUpperA();

        /// <summary>
        /// 将缓冲区中的小写字符转换为大写字符。 该函数将就地转换字符。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CharUpperBuffA();

        /// <summary>
        /// 将缓冲区中的小写字符转换为大写字符。 该函数将就地转换字符。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CharUpperBuffW();

        /// <summary>
        /// 将字符串或单个字符转换为大写。 如果操作数是一个字符串，则函数将就地转换字符。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CharUpperW();

        /// <summary>
        /// 更改按钮控件的检查状态。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CheckDlgButton();

        /// <summary>
        /// 将指定菜单项的复选标记属性的状态设置为选中或清除。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CheckMenuItem();

        /// <summary>
        /// 检查指定的菜单项并使其成为单选项。 同时，该函数清除关联组中所有其他菜单项，并清除这些项目的无线电项类型标志。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CheckMenuRadioItem();

        /// <summary>
        /// 将复选标记添加到(检查) 组中的指定单选按钮，并从(中删除复选标记) 组中所有其他单选按钮。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CheckRadioButton();

        /// <summary>
        /// 确定属于父窗口的子窗口包含指定的点（如果有）。 搜索仅限于即时子窗口。 孙子，和更深的后代窗口没有搜索。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ChildWindowFromPoint();

        /// <summary>
        /// 确定属于指定父窗口的子窗口包含指定的点（如果有）。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ChildWindowFromPointEx();

        /// <summary>
        /// ClientToScreen 函数将指定点的工作区坐标转换为屏幕坐标。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ClientToScreen();

        /// <summary>
        /// 将光标限制在屏幕上的矩形区域。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ClipCursor();

        /// <summary>
        /// 关闭剪贴板。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CloseClipboard();

        /// <summary>
        /// 关闭桌面对象的打开句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CloseDesktop();

        /// <summary>
        /// 关闭与手势信息句柄关联的资源。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CloseGestureInfoHandle();

        /// <summary>
        /// 关闭触摸输入句柄，释放与之关联的进程内存，并使句柄失效。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CloseTouchInputHandle();

        /// <summary>
        /// 最小化(但不销毁指定窗口) 。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CloseWindow();

        /// <summary>
        /// 关闭打开的窗口工作站句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CloseWindowStation();

        /// <summary>
        /// 复制指定的加速器表。 此函数用于获取对应于加速器表句柄的加速器表数据，或确定加速器表数据的大小。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CopyAcceleratorTableA();

        /// <summary>
        /// 复制指定的加速器表。 此函数用于获取对应于加速器表句柄的加速器表数据，或确定加速器表数据的大小。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CopyAcceleratorTableW();

        /// <summary>
        /// 复制指定的游标。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CopyCursor();

        /// <summary>
        /// 将指定图标从另一个模块复制到当前模块。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CopyIcon();

        /// <summary>
        /// 创建新的图像(图标、光标或位图) ，并将指定图像的属性复制到新图像。 如有必要，该函数会拉伸位以适应新图像的所需大小。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CopyImage();

        /// <summary>
        /// CopyRect 函数将一个矩形的坐标复制到另一个矩形。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CopyRect();

        /// <summary>
        /// 检索剪贴板上当前不同数据格式的数目。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CountClipboardFormats();

        /// <summary>
        /// 创建加速器表。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateAcceleratorTableA();

        /// <summary>
        /// 创建加速器表。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateAcceleratorTableW();

        /// <summary>
        /// 为系统插入符号创建一个新形状，并将插入符号的所有权分配给指定窗口。 插入符号形状可以是线条、块或位图。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateCaret();

        /// <summary>
        /// 创建具有指定大小、位模式和热点的游标。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateCursor();

        /// <summary>
        /// 创建新的桌面，将其与调用进程的当前窗口工作站相关联，并将其分配给调用线程。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateDesktopA();

        /// <summary>
        /// 创建具有指定堆的新桌面，将其与调用进程的当前窗口工作站相关联，并将其分配给调用线程。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateDesktopExA();

        /// <summary>
        /// 创建具有指定堆的新桌面，将其与调用进程的当前窗口工作站相关联，并将其分配给调用线程。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateDesktopExW();

        /// <summary>
        /// 创建新的桌面，将其与调用进程的当前窗口工作站相关联，并将其分配给调用线程。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateDesktopW();

        /// <summary>
        /// 从对话框模板资源创建无模式对话框。 CreateDialog 宏使用 CreateDialogParam 函数。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateDialogA();

        /// <summary>
        /// 从内存中的对话框模板创建无模式对话框。 CreateDialogIndirect 宏使用 CreateDialogIndirectParam 函数。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateDialogIndirectA();

        /// <summary>
        /// 从内存中的对话框模板创建无模式对话框。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateDialogIndirectParamA();

        /// <summary>
        /// 从内存中的对话框模板创建无模式对话框。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateDialogIndirectParamW();

        /// <summary>
        /// 从内存中的对话框模板创建无模式对话框。 CreateDialogIndirect 宏使用 CreateDialogIndirectParam 函数。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateDialogIndirectW();

        /// <summary>
        /// 从对话框模板资源创建无模式对话框。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateDialogParamA();

        /// <summary>
        /// 从对话框模板资源创建无模式对话框。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateDialogParamW();

        /// <summary>
        /// 从对话框模板资源创建无模式对话框。 CreateDialog 宏使用 CreateDialogParam 函数。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateDialogW();

        /// <summary>
        /// 创建具有指定大小、颜色和位模式的图标。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateIcon();

        /// <summary>
        /// 从描述图标的资源位创建图标或游标。 (CreateIconFromResource)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateIconFromResource();

        /// <summary>
        /// 从描述图标的资源位创建图标或游标。 (CreateIconFromResourceEx)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateIconFromResourceEx();

        /// <summary>
        /// 从 ICONINFO 结构创建图标或光标。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateIconIndirect();

        /// <summary>
        /// (MDI) 子窗口创建多文档接口。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateMDIWindowA();

        /// <summary>
        /// (MDI) 子窗口创建多文档接口。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateMDIWindowW();

        /// <summary>
        /// 创建菜单。 菜单最初为空，但可以使用 InsertMenuItem、AppendMenu 和 InsertMenu 函数填充菜单项。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateMenu();

        /// <summary>
        /// 创建下拉菜单、子菜单或快捷菜单。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreatePopupMenu();

        /// <summary>
        /// 为调用应用程序配置指针注入设备，并初始化应用可以注入的最大同时指针数。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateSyntheticPointerDevice();

        /// <summary>
        /// 创建重叠、弹出窗口或子窗口。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateWindowA();

        /// <summary>
        /// 创建具有扩展窗口样式的重叠、弹出窗口或子窗口;否则，此函数与 CreateWindow 函数相同。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateWindowExA();

        /// <summary>
        /// 创建具有扩展窗口样式的重叠、弹出窗口或子窗口;否则，此函数与 CreateWindow 函数相同。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateWindowExW();

        /// <summary>
        /// 创建一个窗口工作站对象，将其与调用过程相关联，并将其分配给当前会话。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateWindowStationA();

        /// <summary>
        /// 创建一个窗口工作站对象，将其与调用过程相关联，并将其分配给当前会话。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateWindowStationW();

        /// <summary>
        /// 创建重叠、弹出窗口或子窗口。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateWindowW();

        /// <summary>
        /// 调用默认对话框窗口过程，为具有专用窗口类的对话框不处理的任何窗口消息提供默认处理。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DefDlgProcA();

        /// <summary>
        /// 调用默认对话框窗口过程，为具有专用窗口类的对话框不处理的任何窗口消息提供默认处理。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DefDlgProcW();

        /// <summary>
        /// 汇报指定窗口的指定多窗口位置结构。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DeferWindowPos();

        /// <summary>
        /// 为多文档接口的窗口过程 (MDI) 框架窗口未处理的任何窗口消息提供默认处理。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DefFrameProcA();

        /// <summary>
        /// 为多文档接口的窗口过程 (MDI) 框架窗口未处理的任何窗口消息提供默认处理。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DefFrameProcW();

        /// <summary>
        /// 为多文档接口的窗口过程 (MDI) 子窗口未处理的任何窗口消息提供默认处理。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DefMDIChildProcA();

        /// <summary>
        /// 为多文档接口的窗口过程 (MDI) 子窗口未处理的任何窗口消息提供默认处理。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DefMDIChildProcW();

        /// <summary>
        /// 验证 RAWINPUTHEADER 结构的大小是否正确。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DefRawInputProc();

        /// <summary>
        /// 调用默认窗口过程，为应用程序未处理的任何窗口消息提供默认处理。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DefWindowProcA();

        /// <summary>
        /// 调用默认窗口过程，为应用程序未处理的任何窗口消息提供默认处理。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DefWindowProcW();

        /// <summary>
        /// 从指定菜单中删除项。 如果菜单项打开菜单或子菜单，则此函数将销毁菜单或子菜单的句柄，并释放菜单或子菜单使用的内存。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DeleteMenu();

        /// <summary>
        /// 取消注册已注册以接收 Shell 挂钩消息的指定 Shell 窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DeregisterShellHookWindow();

        /// <summary>
        /// 销毁加速器表。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DestroyAcceleratorTable();

        /// <summary>
        /// 销毁插入符号的当前形状，从窗口中释放插入符号，并从屏幕中删除插入符号。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DestroyCaret();

        /// <summary>
        /// 销毁游标并释放光标占用的任何内存。 请勿使用此函数销毁共享游标。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DestroyCursor();

        /// <summary>
        /// 销毁图标并释放图标占用的任何内存。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DestroyIcon();

        /// <summary>
        /// 销毁指定的菜单并释放菜单占用的任何内存。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DestroyMenu();

        /// <summary>
        /// 销毁指定的指针注入设备。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DestroySyntheticPointerDevice();

        /// <summary>
        /// 销毁指定的窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DestroyWindow();

        /// <summary>
        /// 从对话框模板资源创建模式对话框。 在指定的回调函数通过调用 EndDialog 函数终止模式对话框之前，DialogBox 不会返回控件。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DialogBoxA();

        /// <summary>
        /// 从内存中的对话框模板创建模式对话框。 在指定的回调函数通过调用 EndDialog 函数终止模式对话框之前，DialogBoxIndirect 不会返回控件。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DialogBoxIndirectA();

        /// <summary>
        /// 从内存中的对话框模板创建模式对话框。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DialogBoxIndirectParamA();

        /// <summary>
        /// 从内存中的对话框模板创建模式对话框。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DialogBoxIndirectParamW();

        /// <summary>
        /// 从内存中的对话框模板创建模式对话框。 在指定的回调函数通过调用 EndDialog 函数终止模式对话框之前，DialogBoxIndirect 不会返回控件。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DialogBoxIndirectW();

        /// <summary>
        /// 从对话框模板资源创建模式对话框。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DialogBoxParamA();

        /// <summary>
        /// 从对话框模板资源创建模式对话框。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DialogBoxParamW();

        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DisableProcessWindowsGhosting();
        /// <summary>
        /// 从对话框模板资源创建模式对话框。 在指定的回调函数通过调用 EndDialog 函数终止模式对话框之前，DialogBox 不会返回控件。 (Unicode)
        /// </summary>

        /// <summary>
        /// 禁用调用 GUI 进程的窗口虚影功能。 窗口虚影是一项 Windows 管理器功能，允许用户最小化、移动或关闭未响应的应用程序的主窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DialogBoxW();

        /// <summary>
        /// 将消息调度到窗口过程。 它通常用于调度 GetMessage 函数检索的消息。 (DispatchMessageW)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DispatchMessage();

        /// <summary>
        /// 将消息调度到窗口过程。 它通常用于调度 GetMessage 函数检索的消息。 (DispatchMessageA)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DispatchMessageA();

        /// <summary>
        /// 将消息调度到窗口过程。 它通常用于调度 GetMessage 函数检索的消息。 (DispatchMessageW)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DispatchMessageW();

        /// <summary>
        /// DisplayConfigGetDeviceInfo 函数检索有关设备的显示配置信息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DisplayConfigGetDeviceInfo();

        /// <summary>
        /// DisplayConfigSetDeviceInfo 函数设置目标的属性。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DisplayConfigSetDeviceInfo();

        /// <summary>
        /// 将列表框的内容替换为指定目录中的子目录和文件的名称。 可以通过指定一组文件属性来筛选名称列表。 列表可以选择包含映射的驱动器。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DlgDirListA();

        /// <summary>
        /// 将组合框的内容替换为指定目录中的子目录和文件的名称。 可以通过指定一组文件属性来筛选名称列表。 名称列表可以包括映射的驱动器号。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DlgDirListComboBoxA();

        /// <summary>
        /// 将组合框的内容替换为指定目录中的子目录和文件的名称。 可以通过指定一组文件属性来筛选名称列表。 名称列表可以包括映射的驱动器号。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DlgDirListComboBoxW();

        /// <summary>
        /// 将列表框的内容替换为指定目录中的子目录和文件的名称。 可以通过指定一组文件属性来筛选名称列表。 列表可以选择包含映射的驱动器。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DlgDirListW();

        /// <summary>
        /// 使用 DlgDirListComboBox 函数从填充的组合框中检索当前所选内容。 所选内容解释为驱动器号、文件或目录名称。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DlgDirSelectComboBoxExA();

        /// <summary>
        /// 使用 DlgDirListComboBox 函数从填充的组合框中检索当前所选内容。 所选内容解释为驱动器号、文件或目录名称。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DlgDirSelectComboBoxExW();

        /// <summary>
        /// 从单选列表框中检索当前选定内容。 它假定列表框已由 DlgDirList 函数填充，并且所选内容是驱动器号、文件名或目录名称。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DlgDirSelectExA();

        /// <summary>
        /// 从单选列表框中检索当前选定内容。 它假定列表框已由 DlgDirList 函数填充，并且所选内容是驱动器号、文件名或目录名称。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DlgDirSelectExW();

        /// <summary>
        /// 捕获鼠标并跟踪其移动，直到用户释放左键、按 ESC 键或将鼠标移动到围绕指定点的拖动矩形外部。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DragDetect();

        /// <summary>
        /// 对窗口的标题进行动画处理，以指示图标的打开或窗口最小化或最大化。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DrawAnimatedRects();

        /// <summary>
        /// DrawCaption 函数绘制窗口标题。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DrawCaption();

        /// <summary>
        /// DrawEdge 函数绘制矩形的一个或多个边缘。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DrawEdge();

        /// <summary>
        /// DrawFocusRect 函数在样式中绘制一个矩形，该矩形指示该矩形具有焦点。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DrawFocusRect();

        /// <summary>
        /// DrawFrameControl 函数绘制指定类型和样式的帧控件。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DrawFrameControl();

        /// <summary>
        /// 将图标或光标绘制到指定的设备上下文中。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DrawIcon();

        /// <summary>
        /// 将图标或光标绘制到指定的设备上下文中，执行指定的光栅操作，并按指定拉伸或压缩图标或光标。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DrawIconEx();

        /// <summary>
        /// 重绘指定窗口的菜单栏。 如果在系统创建窗口后菜单栏发生更改，则必须调用此函数来绘制更改的菜单栏。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DrawMenuBar();

        /// <summary>
        /// DrawState 函数显示图像，并应用视觉效果来指示状态，例如已禁用或默认状态。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DrawStateA();

        /// <summary>
        /// DrawState 函数显示图像，并应用视觉效果来指示状态，例如已禁用或默认状态。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DrawStateW();

        /// <summary>
        /// DrawText 函数在指定的矩形中绘制带格式的文本。 它根据指定的方法设置文本格式， (展开制表符、对齐字符、断行等) 。 (DrawTextW)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DrawText();

        /// <summary>
        /// DrawText 函数绘制指定矩形中的格式化文本。 它根据指定的方法设置文本格式， (展开制表符、对齐字符、断行等) 。 (DrawTextA)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DrawTextA();

        /// <summary>
        /// DrawTextEx 函数绘制指定矩形中的格式化文本。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DrawTextExA();

        /// <summary>
        /// DrawTextEx 函数绘制指定矩形中的格式化文本。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DrawTextExW();

        /// <summary>
        /// DrawText 函数绘制指定矩形中的格式化文本。 它根据指定的方法设置文本格式， (展开制表符、对齐字符、断行等) 。 (DrawTextW)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr DrawTextW();

        /// <summary>
        /// 清空剪贴板并释放剪贴板中的数据句柄。 然后，该函数将剪贴板的所有权分配给当前打开剪贴板的窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EmptyClipboard();

        /// <summary>
        /// 启用、禁用或灰显指定的菜单项。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EnableMenuItem();

        /// <summary>
        /// 使鼠标能够充当指针输入设备并发送WM_POINTER消息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EnableMouseInPointer();

        /// <summary>
        /// 在高 DPI 显示器中，启用指定顶级窗口的非工作区部分的自动显示缩放。 必须在初始化该窗口期间调用。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EnableNonClientDpiScaling();

        /// <summary>
        /// EnableScrollBar 函数启用或禁用一个或两个滚动条箭头。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EnableScrollBar();

        /// <summary>
        /// 启用或禁用指定窗口或控件的鼠标和键盘输入。 禁用输入后，窗口不会接收鼠标单击和按下键等输入。 启用输入后，窗口将接收所有输入。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EnableWindow();

        /// <summary>
        /// 同时更新单个屏幕刷新周期中一个或多个窗口的位置和大小。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EndDeferWindowPos();

        /// <summary>
        /// 销毁模式对话框，导致系统结束对对话框的任何处理。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EndDialog();

        /// <summary>
        /// 结束调用线程的活动菜单。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EndMenu();

        /// <summary>
        /// EndPaint 函数标记指定窗口中的绘制结束。 每次调用 BeginPaint 函数时，都需要此函数，但仅在绘制完成后才能完成。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EndPaint();

        /// <summary>
        /// 强行关闭指定的窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EndTask();

        /// <summary>
        /// 通过将句柄传递给应用程序定义的回调函数，枚举属于指定父窗口的子窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EnumChildWindows();

        /// <summary>
        /// 枚举剪贴板上当前可用的数据格式。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EnumClipboardFormats();

        /// <summary>
        /// 枚举与调用进程的指定窗口工作站关联的所有桌面。 该函数又将每个桌面的名称传递给应用程序定义的回调函数。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EnumDesktopsA();

        /// <summary>
        /// 枚举与调用进程的指定窗口工作站关联的所有桌面。 该函数又将每个桌面的名称传递给应用程序定义的回调函数。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EnumDesktopsW();

        /// <summary>
        /// 枚举与指定桌面关联的所有顶级窗口。 它将句柄传递给每个窗口，进而传递给应用程序定义的回调函数。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EnumDesktopWindows();

        /// <summary>
        /// EnumDisplayDevices 函数允许你获取有关当前会话中显示设备的信息。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EnumDisplayDevicesA();

        /// <summary>
        /// EnumDisplayDevices 函数允许你获取有关当前会话中显示设备的信息。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EnumDisplayDevicesW();

        /// <summary>
        /// EnumDisplayMonitors 函数枚举显示监视器 (包括与镜像驱动程序关联的不可见伪监视器) ，这些监视器与指定剪辑矩形的交集和设备上下文的可见区域相交的区域相交。 EnumDisplayMonitors 对枚举的每个监视器调用应用程序定义的 MonitorEnumProc 回调函数一次。 请注意，GetSystemMetrics (SM_CMONITORS) 仅计算显示监视器。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EnumDisplayMonitors();

        /// <summary>
        /// EnumDisplaySettings 函数检索有关显示设备的图形模式之一的信息。 若要检索显示设备的所有图形模式的信息，请对此函数进行一系列调用。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EnumDisplaySettingsA();

        /// <summary>
        /// EnumDisplaySettingsEx 函数检索有关显示设备的图形模式之一的信息。 若要检索显示设备的所有图形模式的信息，请对此函数进行一系列调用。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EnumDisplaySettingsExA();

        /// <summary>
        /// EnumDisplaySettingsEx 函数检索有关显示设备的图形模式之一的信息。 若要检索显示设备的所有图形模式的信息，请对此函数进行一系列调用。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EnumDisplaySettingsExW();

        /// <summary>
        /// EnumDisplaySettings 函数检索有关显示设备的图形模式之一的信息。 若要检索显示设备的所有图形模式的信息，请对此函数进行一系列调用。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EnumDisplaySettingsW();

        /// <summary>
        /// 通过将窗口的属性列表中的所有条目（一个一个）传递给指定的回调函数来枚举这些条目。 枚举Props 会继续，直到枚举最后一个条目或回调函数返回 FALSE。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EnumPropsA();

        /// <summary>
        /// 通过将窗口的属性列表中的所有条目（一个一个）传递给指定的回调函数来枚举这些条目。 枚举PropsEx 将继续，直到枚举最后一个条目或回调函数返回 FALSE。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EnumPropsExA();

        /// <summary>
        /// 通过将窗口的属性列表中的所有条目（一个一个）传递给指定的回调函数来枚举这些条目。 枚举PropsEx 将继续，直到枚举最后一个条目或回调函数返回 FALSE。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EnumPropsExW();

        /// <summary>
        /// 通过将窗口的属性列表中的所有条目（一个一个）传递给指定的回调函数来枚举这些条目。 枚举Props 会继续，直到枚举最后一个条目或回调函数返回 FALSE。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EnumPropsW();

        /// <summary>
        /// 通过将句柄传递给应用程序定义的回调函数，枚举与线程关联的所有非子窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EnumThreadWindows();

        /// <summary>
        /// 通过将句柄传递到应用程序定义的回调函数，枚举屏幕上的所有顶级窗口。 枚举枚举到最后一个顶级窗口或回调函数返回 FALSE 为止。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EnumWindows();

        /// <summary>
        /// 枚举当前会话中的所有窗口工作站。 该函数又将每个窗口站的名称传递给应用程序定义的回调函数。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EnumWindowStationsA();

        /// <summary>
        /// 枚举当前会话中的所有窗口工作站。 该函数又将每个窗口站的名称传递给应用程序定义的回调函数。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EnumWindowStationsW();

        /// <summary>
        /// EqualRect 函数通过比较其左上角和右下角的坐标来确定两个指定的矩形是否相等。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EqualRect();

        /// <summary>
        /// 将多边形的分数作为可能的触摸目标 (与与触摸接触区相交的所有其他多边形) 和多边形中调整的触摸点进行比较。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EvaluateProximityToPolygon();

        /// <summary>
        /// 返回矩形的分数作为可能的触摸目标，与与触摸接触区域相交的所有其他矩形以及矩形内调整的触摸点进行比较。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr EvaluateProximityToRect();

        /// <summary>
        /// ExcludeUpdateRgn 函数通过从剪辑区域中排除窗口中更新的区域，防止在窗口的无效区域中绘制。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ExcludeUpdateRgn();

        /// <summary>
        /// 调用 ExitWindowsEx 函数以注销交互式用户。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ExitWindows();

        /// <summary>
        /// 注销交互式用户、关闭系统或关闭并重启系统。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ExitWindowsEx();

        /// <summary>
        /// FillRect 函数使用指定的画笔填充矩形。 此函数包括左边框和上边框，但排除矩形的右边框和下边框。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr FillRect();

        /// <summary>
        /// 检索顶级窗口的句柄，该窗口的类名称和窗口名称与指定的字符串匹配。 此函数不搜索子窗口。 此函数不执行区分大小写的搜索。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindowA();

        /// <summary>
        /// 检索一个窗口的句柄，该窗口的类名和窗口名称与指定的字符串匹配。 该函数搜索子窗口，从指定子窗口后面的子窗口开始。 此函数不执行区分大小写的搜索。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindowExA();

        /// <summary>
        /// 检索一个窗口的句柄，该窗口的类名和窗口名称与指定的字符串匹配。 该函数搜索子窗口，从指定子窗口后面的子窗口开始。 此函数不执行区分大小写的搜索。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindowExW();

        /// <summary>
        /// 检索顶级窗口的句柄，该窗口的类名称和窗口名称与指定的字符串匹配。 此函数不搜索子窗口。 此函数不执行区分大小写的搜索。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindowW();

        /// <summary>
        /// 一次闪烁指定的窗口。 它不会更改窗口的活动状态。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr FlashWindow();

        /// <summary>
        /// 闪烁指定的窗口。 它不会更改窗口的活动状态。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr FlashWindowEx();

        /// <summary>
        /// FrameRect 函数使用指定的画笔在指定矩形周围绘制边框。 边框的宽度和高度始终是一个逻辑单元。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr FrameRect();

        /// <summary>
        /// 从指定的 LPARAM 值检索应用程序命令。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GET_APPCOMMAND_LPARAM();

        /// <summary>
        /// 从指定的 LPARAM 值检索输入设备类型。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GET_DEVICE_LPARAM();

        /// <summary>
        /// 从指定的 LPARAM 值检索特定虚拟密钥的状态。 (GET_FLAGS_LPARAM)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GET_FLAGS_LPARAM();

        /// <summary>
        /// 从指定的 LPARAM 值检索特定虚拟密钥的状态。 (GET_KEYSTATE_LPARAM)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GET_KEYSTATE_LPARAM();

        /// <summary>
        /// 从指定的 WPARAM 值检索特定虚拟密钥的状态。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GET_KEYSTATE_WPARAM();

        /// <summary>
        /// 从指定的 WPARAM 值检索命中测试值。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GET_NCHITTEST_WPARAM();

        /// <summary>
        /// 使用指定的值检索指针 ID。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GET_POINTERID_WPARAM();

        /// <summary>
        /// 从 WM_INPUT 中的 wParam 检索输入代码。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GET_RAWINPUT_CODE_WPARAM();

        /// <summary>
        /// 从指定的 WPARAM 值检索滚轮增量值。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GET_WHEEL_DELTA_WPARAM();

        /// <summary>
        /// 从指定的 WPARAM 值检索某些按钮的状态。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GET_XBUTTON_WPARAM();

        /// <summary>
        /// 检索附加到调用线程消息队列的活动窗口的窗口句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetActiveWindow();

        /// <summary>
        /// 如果指定窗口是应用程序切换 (ALT+TAB) 窗口，则检索指定窗口的状态信息。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetAltTabInfoA();

        /// <summary>
        /// 如果指定窗口是应用程序切换 (ALT+TAB) 窗口，则检索指定窗口的状态信息。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetAltTabInfoW();

        /// <summary>
        /// 检索指定窗口的上级句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetAncestor();

        /// <summary>
        /// 确定调用函数时键是向上还是向下键，以及之前调用 GetAsyncKeyState 后是否按下了键。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetAsyncKeyState();

        /// <summary>
        /// 检索一个AR_STATE值，该值包含系统的屏幕自动旋转状态，例如是否支持自动轮换，以及是否由用户启用。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetAutoRotationState();

        /// <summary>
        /// 从DPI_AWARENESS_CONTEXT检索DPI_AWARENESS值。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetAwarenessFromDpiAwarenessContext();

        /// <summary>
        /// 如果捕获了鼠标的任何) ，则检索窗口 (句柄。 一次只能捕获一个窗口;此窗口接收鼠标输入，无论光标是否在其边框内。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetCapture();

        /// <summary>
        /// 检索反转插入点像素所需的时间。 用户可以设置此值。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetCaretBlinkTime();

        /// <summary>
        /// 将插入点的位置复制到指定的 POINT 结构。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetCaretPos();

        /// <summary>
        /// (GetCurrentInputMessageSourceInSendMessage) 检索输入消息的源。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetCIMSSM();

        /// <summary>
        /// 检索有关窗口类的信息。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetClassInfoA();

        /// <summary>
        /// 检索有关窗口类的信息，包括与窗口类关联的小图标的句柄。 GetClassInfo 函数不会检索小图标的句柄。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetClassInfoExA();

        /// <summary>
        /// 检索有关窗口类的信息，包括与窗口类关联的小图标的句柄。 GetClassInfo 函数不会检索小图标的句柄。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetClassInfoExW();

        /// <summary>
        /// 检索有关窗口类的信息。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetClassInfoW();

        /// <summary>
        /// 从与指定窗口关联的 WNDCLASSEX 结构中检索指定的 32 位 (DWORD) 值。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetClassLongA();

        /// <summary>
        /// 从与指定窗口关联的 WNDCLASSEX 结构检索指定的值。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetClassLongPtrA();

        /// <summary>
        /// 从与指定窗口关联的 WNDCLASSEX 结构检索指定的值。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetClassLongPtrW();

        /// <summary>
        /// 从与指定窗口关联的 WNDCLASSEX 结构中检索指定的 32 位 (DWORD) 值。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetClassLongW();

        /// <summary>
        /// 检索指定窗口所属的类的名称。 (GetClassNameW)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetClassName();

        /// <summary>
        /// 检索指定窗口所属的类的名称。 (GetClassNameA)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetClassNameA();

        /// <summary>
        /// 检索指定窗口所属的类的名称。 (GetClassNameW)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetClassNameW();

        /// <summary>
        /// 将 16 位 (WORD) 值检索到指定窗口所属窗口类的额外类内存中。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetClassWord();

        /// <summary>
        /// 检索窗口工作区的坐标。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetClientRect();

        /// <summary>
        /// 以指定格式从剪贴板检索数据。 剪贴板之前必须已打开。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetClipboardData();

        /// <summary>
        /// 从剪贴板中检索指定注册格式的名称。 该函数将名称复制到指定的缓冲区。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetClipboardFormatNameA();

        /// <summary>
        /// 从剪贴板中检索指定注册格式的名称。 该函数将名称复制到指定的缓冲区。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetClipboardFormatNameW();

        /// <summary>
        /// 检索剪贴板的当前所有者的窗口句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetClipboardOwner();

        /// <summary>
        /// 检索当前窗口工作站的剪贴板序列号。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetClipboardSequenceNumber();

        /// <summary>
        /// 检索剪贴板查看器链中第一个窗口的句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetClipboardViewer();

        /// <summary>
        /// 检索光标被限制到的矩形区域的屏幕坐标。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetClipCursor();

        /// <summary>
        /// 检索有关指定组合框的信息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetComboBoxInfo();

        /// <summary>
        /// 检索输入消息的源。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetCurrentInputMessageSource();

        /// <summary>
        /// 检索当前游标的句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetCursor();

        /// <summary>
        /// 检索有关全局游标的信息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetCursorInfo();

        /// <summary>
        /// 检索鼠标光标在屏幕坐标中的位置。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetCursorPos();

        /// <summary>
        /// GetDC 函数检索设备上下文的句柄， (DC) 指定窗口的工作区或整个屏幕。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetDC();

        /// <summary>
        /// GetDCEx 函数检索指定窗口或整个屏幕的工作区 (DC) 设备上下文的句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetDCEx();

        /// <summary>
        /// 检索桌面窗口的句柄。 桌面窗口覆盖整个屏幕。 桌面窗口是其他窗口绘制的区域。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetDesktopWindow();

        /// <summary>
        /// 检索系统的对话框基单位，这些单位是系统字体中字符的平均宽度和高度。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetDialogBaseUnits();

        /// <summary>
        /// 检索对话中子窗口的按监视器 DPI 缩放行为替代。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetDialogControlDpiChangeBehavior();

        /// <summary>
        /// 通过对 SetDialogDpiChangeBehavior 的早期调用，返回可能在给定对话框中设置的标志。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetDialogDpiChangeBehavior();

        /// <summary>
        /// 检索当前进程的屏幕自动旋转首选项。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetDisplayAutoRotationPreferences();

        /// <summary>
        /// 检索 dwProcessId 参数指示的进程的屏幕自动旋转首选项。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetDisplayAutoRotationPreferencesByProcessId();

        /// <summary>
        /// GetDisplayConfigBufferSizes 函数检索调用 QueryDisplayConfig 函数所需的缓冲区的大小。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetDisplayConfigBufferSizes();

        /// <summary>
        /// 检索指定控件的标识符。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetDlgCtrlID();

        /// <summary>
        /// 检索指定对话框中控件的句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetDlgItem();

        /// <summary>
        /// 将对话框中指定控件的文本转换为整数值。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetDlgItemInt();

        /// <summary>
        /// 检索与对话框中的控件关联的标题或文本。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetDlgItemTextA();

        /// <summary>
        /// 检索与对话框中的控件关联的标题或文本。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetDlgItemTextW();

        /// <summary>
        /// 检索鼠标的当前双击时间。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetDoubleClickTime();

        /// <summary>
        /// 返回系统 DPI。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetDpiForSystem();

        /// <summary>
        /// 返回指定窗口的每英寸点 (dpi) 值。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetDpiForWindow();

        /// <summary>
        /// 从给定DPI_AWARENESS_CONTEXT句柄检索 DPI。 这样，便可以确定线程的 DPI，而无需检查在该线程中创建的窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetDpiFromDpiAwarenessContext();

        /// <summary>
        /// 如果窗口附加到调用线程的消息队列，则检索具有键盘焦点的窗口的句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetFocus();

        /// <summary>
        /// 检索前台窗口的句柄， (用户当前正在使用的窗口) 。 系统向创建前台窗口的线程分配略高于其他线程的优先级。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetForegroundWindow();

        /// <summary>
        /// 检索从窗口发送 Windows Touch 手势消息的配置。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetGestureConfig();

        /// <summary>
        /// 从其 GESTUREINFO 句柄中检索有关手势的其他信息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetGestureExtraArgs();

        /// <summary>
        /// 检索一个 GESTUREINFO 结构，给定手势信息的句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetGestureInfo();

        /// <summary>
        /// 检索图形用户界面的句柄计数， (GUI) 指定进程使用的对象。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetGuiResources();

        /// <summary>
        /// 检索有关活动窗口或指定 GUI 线程的信息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetGUIThreadInfo();

        /// <summary>
        /// 检索有关指定图标或游标的信息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetIconInfo();

        /// <summary>
        /// 检索有关指定图标或游标的信息。 GetIconInfoEx 使用较新的 ICONINFOEX 结构扩展 GetIconInfo。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetIconInfoExA();

        /// <summary>
        /// 检索有关指定图标或游标的信息。 GetIconInfoEx 使用较新的 ICONINFOEX 结构扩展 GetIconInfo。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetIconInfoExW();

        /// <summary>
        /// 确定调用线程的消息队列中是否存在鼠标按钮或键盘消息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetInputState();

        /// <summary>
        /// 检索当前代码页。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetKBCodePage();

        /// <summary>
        /// 检索以前称为键盘布局) 的活动输入区域设置标识符 (。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetKeyboardLayout();

        /// <summary>
        /// 检索以前称为键盘布局 (输入区域设置标识符) 对应于系统中当前输入区域设置集的输入区域设置。 该函数将标识符复制到指定的缓冲区。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetKeyboardLayoutList();

        /// <summary>
        /// 检索活动输入区域设置标识符的名称， (以前称为系统的键盘布局) 。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetKeyboardLayoutNameA();

        /// <summary>
        /// 检索活动输入区域设置标识符的名称， (以前称为系统的键盘布局) 。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetKeyboardLayoutNameW();

        /// <summary>
        /// 将 256 个虚拟密钥的状态复制到指定的缓冲区。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetKeyboardState();

        /// <summary>
        /// 检索有关当前键盘的信息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetKeyboardType();

        /// <summary>
        /// 检索表示密钥名称的字符串。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetKeyNameTextA();

        /// <summary>
        /// 检索表示密钥名称的字符串。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetKeyNameTextW();

        /// <summary>
        /// 检索指定虚拟密钥的状态。 状态指定每次) 按下键时，键是向上、关闭还是切换 (，每次按下键时都会交替切换。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetKeyState();

        /// <summary>
        /// 确定指定窗口拥有的弹出窗口最近处于活动状态。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetLastActivePopup();

        /// <summary>
        /// 检索最后一个输入事件的时间。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetLastInputInfo();

        /// <summary>
        /// 检索分层窗口的不透明度和透明度颜色键。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetLayeredWindowAttributes();

        /// <summary>
        /// 检索指定列表框中每列的项目数。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetListBoxInfo();

        /// <summary>
        /// 检索分配给指定窗口的菜单的句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr getMenu();

        /// <summary>
        /// 检索有关指定的菜单栏的信息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetMenuBarInfo();

        /// <summary>
        /// 检索默认复选标记位图的维度。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetMenuCheckMarkDimensions();

        /// <summary>
        /// 检索与指定菜单关联的帮助上下文标识符。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetMenuContextHelpId();

        /// <summary>
        /// 确定指定菜单上的默认菜单项。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetMenuDefaultItem();

        /// <summary>
        /// 检索有关指定菜单的信息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetMenuInfo();

        /// <summary>
        /// 确定指定菜单中的项数。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetMenuItemCount();

        /// <summary>
        /// 检索位于菜单中指定位置的菜单项的菜单项标识符。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetMenuItemID();

        /// <summary>
        /// 检索有关菜单项的信息。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetMenuItemInfoA();

        /// <summary>
        /// 检索有关菜单项的信息。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetMenuItemInfoW();

        /// <summary>
        /// 检索指定菜单项的边界矩形。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetMenuItemRect();

        /// <summary>
        /// 检索与指定菜单项关联的菜单标志。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetMenuState();

        /// <summary>
        /// 将指定菜单项的文本字符串复制到指定的缓冲区中。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetMenuStringA();

        /// <summary>
        /// 将指定菜单项的文本字符串复制到指定的缓冲区中。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetMenuStringW();

        /// <summary>
        /// 从调用线程的消息队列中检索消息。 该函数将调度传入的已发送邮件，直到发布的消息可供检索。 (GetMessageW)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetMessage();

        /// <summary>
        /// 从调用线程的消息队列中检索消息。 该函数将调度传入的已发送邮件，直到发布的消息可供检索。 (GetMessageA)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetMessageA();

        /// <summary>
        /// 检索当前线程的额外消息信息。 额外消息信息是与当前线程的消息队列关联的应用程序或驱动程序定义值。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetMessageExtraInfo();

        /// <summary>
        /// 检索 GetMessage 函数检索的最后一条消息的游标位置。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetMessagePos();

        /// <summary>
        /// 检索 GetMessage 函数检索最后一条消息的消息时间。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetMessageTime();

        /// <summary>
        /// 从调用线程的消息队列中检索消息。 该函数将调度传入的已发送邮件，直到发布的消息可供检索。 (GetMessageW)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetMessageW();

        /// <summary>
        /// GetMonitorInfo 函数检索有关显示监视器的信息。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetMonitorInfoA();

        /// <summary>
        /// GetMonitorInfo 函数检索有关显示监视器的信息。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetMonitorInfoW();

        /// <summary>
        /// 检索鼠标或笔前 64 个坐标的历史记录。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetMouseMovePointsEx();

        /// <summary>
        /// 检索位于 (之前的控件组中第一个控件的句柄，或) 对话框中的指定控件。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetNextDlgGroupItem();

        /// <summary>
        /// 检索第一个控件的句柄，该控件具有前面 (或) 指定控件之前的WS_TABSTOP样式。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetNextDlgTabItem();

        /// <summary>
        /// 检索 Z 顺序中下一个或上一个窗口的句柄。 下一个窗口位于指定窗口下方;上一个窗口位于上面。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetNextWindow();

        /// <summary>
        /// 检索当前打开剪贴板的窗口的句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetOpenClipboardWindow();

        /// <summary>
        /// 检索指定窗口的父或所有者的句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetParent();

        /// <summary>
        /// 检索光标在物理坐标中的位置。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetPhysicalCursorPos();

        /// <summary>
        /// 检索与指定指针关联的游标标识符。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetPointerCursorId();

        /// <summary>
        /// 获取有关指针设备的信息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetPointerDevice();

        /// <summary>
        /// 获取映射到与指针设备关联的游标的游标 ID。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetPointerDeviceCursors();

        /// <summary>
        /// 获取POINTER_DEVICE_INFO结构中不包含的设备属性。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetPointerDeviceProperties();

        /// <summary>
        /// 获取) 中指针设备的 x 和 y 范围 (， (当前分辨率) 指针设备映射到的显示器的 x 和 y 范围。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetPointerDeviceRects();

        /// <summary>
        /// 获取有关附加到系统的指针设备的信息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetPointerDevices();

        /// <summary>
        /// 获取与当前消息关联的指定指针的整个信息帧。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetPointerFrameInfo();

        /// <summary>
        /// 获取整个信息帧 (，包括与当前消息关联的指定指针的合并输入帧) 。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetPointerFrameInfoHistory();

        /// <summary>
        /// 获取与当前消息关联的类型PT_PEN) 的指定指针 (的基于笔的信息的整个帧。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetPointerFramePenInfo();

        /// <summary>
        /// 获取基于笔的信息的完整帧， (包括与当前消息关联的指定指针的合并输入帧) (类型PT_PEN) 。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetPointerFramePenInfoHistory();

        /// <summary>
        /// 获取与当前消息关联的类型PT_TOUCH) 的指定指针 (的基于触摸的信息的整个帧。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetPointerFrameTouchInfo();

        /// <summary>
        /// 获取 (基于触摸的信息的整个帧，包括与当前消息关联的指定指针的合并输入帧) PT_TOUCH) (。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetPointerFrameTouchInfoHistory();

        /// <summary>
        /// 获取与当前消息关联的指定指针的信息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetPointerInfo();

        /// <summary>
        /// 获取与单个输入关联的信息（如果有）合并到指定指针的当前消息中。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetPointerInfoHistory();

        /// <summary>
        /// 获取与当前消息关联的指针信息坐标的一个或多个转换。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetPointerInputTransform();

        /// <summary>
        /// 获取与当前消息关联的类型PT_PEN) 的指定指针 (的基于笔的信息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetPointerPenInfo();

        /// <summary>
        /// 获取与单个输入（如果有）关联的基于笔的信息，这些信息已合并到指定指针 (类型PT_PEN) 的当前消息中。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetPointerPenInfoHistory();

        /// <summary>
        /// 获取与当前消息关联的类型PT_TOUCH) 的指定指针 (的基于触摸的信息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetPointerTouchInfo();

        /// <summary>
        /// 获取与单个输入（如果有）关联的基于触摸的信息，这些信息已合并到指定指针的当前消息中，PT_TOUCH) 类型 (。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetPointerTouchInfoHistory();

        /// <summary>
        /// 检索指定指针的指针类型。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetPointerType();

        /// <summary>
        /// 检索指定列表中的第一个可用剪贴板格式。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetPriorityClipboardFormat();

        /// <summary>
        /// 检索在没有父级或所有者的情况下创建窗口时使用的默认布局。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetProcessDefaultLayout();

        /// <summary>
        /// 检索调用进程的当前窗口工作站的句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetProcessWindowStation();

        /// <summary>
        /// 从指定窗口的属性列表中检索数据句柄。 字符串标识要检索的句柄。 必须通过对 SetProp 函数的上一次调用将字符串和句柄添加到属性列表中。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetPropA();

        /// <summary>
        /// 从指定窗口的属性列表中检索数据句柄。 字符串标识要检索的句柄。 必须通过对 SetProp 函数的上一次调用将字符串和句柄添加到属性列表中。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetPropW();

        /// <summary>
        /// 检索在调用线程的消息队列中找到的消息类型。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetQueueStatus();

        /// <summary>
        /// 执行原始输入数据的缓冲读取。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetRawInputBuffer();

        /// <summary>
        /// 从指定设备检索原始输入。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetRawInputData();

        /// <summary>
        /// 检索有关原始输入设备的信息。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetRawInputDeviceInfoA();

        /// <summary>
        /// 检索有关原始输入设备的信息。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetRawInputDeviceInfoW();

        /// <summary>
        /// 枚举附加到系统的原始输入设备。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetRawInputDeviceList();

        /// <summary>
        /// 从指针设备获取原始输入数据。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetRawPointerDeviceData();

        /// <summary>
        /// 检索有关当前应用程序的原始输入设备的信息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetRegisteredRawInputDevices();

        /// <summary>
        /// GetScrollBarInfo 函数检索有关指定滚动条的信息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetScrollBarInfo();

        /// <summary>
        /// GetScrollInfo 函数检索滚动条的参数，包括最小和最大滚动位置、页面大小以及滚动框的位置 (拇指) 。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetScrollInfo();

        /// <summary>
        /// GetScrollPos 函数检索指定滚动条中滚动框的当前位置 (拇指) 。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetScrollPos();

        /// <summary>
        /// GetScrollRange 函数检索指定的滚动条的当前最小和最大滚动框 (拇指) 位置。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetScrollRange();

        /// <summary>
        /// 检索 Shell 桌面窗口的句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetShellWindow();

        /// <summary>
        /// 检索由指定菜单项激活的下拉菜单或子菜单的句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetSubMenu();

        /// <summary>
        /// 检索指定显示元素的当前颜色。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetSysColor();

        /// <summary>
        /// GetSysColorBrush 函数检索标识与指定颜色索引对应的逻辑画笔的句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetSysColorBrush();

        /// <summary>
        /// 检索与给定进程关联的系统 DPI。 这可用于避免在具有不同系统 DPI 值的多个系统感知进程之间共享 DPI 敏感信息时出现的兼容性问题。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetSystemDpiForProcess();

        /// <summary>
        /// 使应用程序能够访问窗口菜单 (也称为系统菜单或控件菜单) 进行复制和修改。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetSystemMenu();

        /// <summary>
        /// 检索指定的系统指标或系统配置设置。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetSystemMetrics();

        /// <summary>
        /// 检索考虑到提供的 DPI 的指定系统指标或系统配置设置。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetSystemMetricsForDpi();

        /// <summary>
        /// GetTabbedTextExtent 函数计算字符串的宽度和高度。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetTabbedTextExtentA();

        /// <summary>
        /// GetTabbedTextExtent 函数计算字符串的宽度和高度。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetTabbedTextExtentW();

        /// <summary>
        /// 检索分配给指定线程的桌面的句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetThreadDesktop();

        /// <summary>
        /// 获取当前线程的DPI_AWARENESS_CONTEXT。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetThreadDpiAwarenessContext();

        /// <summary>
        /// 从当前线程检索DPI_HOSTING_BEHAVIOR。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetThreadDpiHostingBehavior();

        /// <summary>
        /// 检索有关指定标题栏的信息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetTitleBarInfo();

        /// <summary>
        /// 检查与指定父窗口关联的子窗口的 Z 顺序，并检索 Z 顺序顶部子窗口的句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetTopWindow();

        /// <summary>
        /// 检索与特定触摸输入句柄关联的触摸输入的详细信息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetTouchInputInfo();

        /// <summary>
        /// 获取指针数据，然后再完成触摸预测处理。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetUnpredictedMessagePos();

        /// <summary>
        /// 检索当前支持的剪贴板格式。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetUpdatedClipboardFormats();

        /// <summary>
        /// GetUpdateRect 函数检索最小矩形的坐标，该矩形完全封闭指定窗口的更新区域。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetUpdateRect();

        /// <summary>
        /// GetUpdateRgn 函数通过将窗口的更新区域复制到指定区域来检索窗口的更新区域。 更新区域的坐标相对于窗口左上角 (，即客户端坐标) 。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetUpdateRgn();

        /// <summary>
        /// 检索有关指定窗口工作站或桌面对象的信息。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetUserObjectInformationA();

        /// <summary>
        /// 检索有关指定窗口工作站或桌面对象的信息。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetUserObjectInformationW();

        /// <summary>
        /// 检索指定用户对象的安全信息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetUserObjectSecurity();

        /// <summary>
        /// 检索具有指定关系 (Z-Order 或所有者) 到指定窗口的窗口的句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindow();

        /// <summary>
        /// 检索与指定窗口关联的帮助上下文标识符（如果有）。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowContextHelpId();

        /// <summary>
        /// GetWindowDC 函数检索整个窗口的设备上下文 (DC) ，包括标题栏、菜单和滚动条。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowDC();

        /// <summary>
        /// 从给定窗口的任何进程检索当前显示相关性设置。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowDisplayAffinity();

        /// <summary>
        /// 返回与窗口关联的DPI_AWARENESS_CONTEXT。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowDpiAwarenessContext();

        /// <summary>
        /// 返回指定窗口的DPI_HOSTING_BEHAVIOR。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowDpiHostingBehavior();

        /// <summary>
        /// 检索窗口的反馈配置。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowFeedbackSetting();

        /// <summary>
        /// 检索有关指定窗口的信息。 (GetWindowInfo)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowInfo();

        /// <summary>
        /// 检索有关指定窗口的信息。 (GetWindowLongA)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowLongA();

        /// <summary>
        /// 检索有关指定窗口的信息。 该函数还会在额外的窗口内存中检索指定偏移量处的值。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowLongPtrA();

        /// <summary>
        /// 检索有关指定窗口的信息。 该函数还会在额外的窗口内存中检索指定偏移量处的值。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowLongPtrW();

        /// <summary>
        /// 检索有关指定窗口的信息。 (GetWindowLongW)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowLongW();

        /// <summary>
        /// 检索与指定窗口句柄关联的模块的完整路径和文件名。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowModuleFileNameA();

        /// <summary>
        /// 检索与指定窗口句柄关联的模块的完整路径和文件名。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowModuleFileNameW();

        /// <summary>
        /// 检索显示状态和已还原、最小化和最大化指定窗口的位置。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowPlacement();

        /// <summary>
        /// 检索指定窗口的边界矩形的维度。 维度以相对于屏幕左上角的屏幕坐标提供。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowRect();

        /// <summary>
        /// GetWindowRgn 函数获取窗口区域的窗口区域的副本。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowRgn();

        /// <summary>
        /// GetWindowRgnBox 函数检索窗口区域最紧密边界矩形的维度。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowRgnBox();

        /// <summary>
        /// 如果指定窗口的标题栏有一个) ，则将其文本复制到缓冲区中 (。 如果指定的窗口是控件，则会复制控件的文本。 但是，GetWindowText 无法检索另一个应用程序中控件的文本。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowTextA();

        /// <summary>
        /// 如果窗口具有标题栏 () ，则检索指定窗口的标题栏文本的长度（以字符为单位）。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowTextLengthA();

        /// <summary>
        /// 如果窗口具有标题栏 () ，则检索指定窗口的标题栏文本的长度（以字符为单位）。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowTextLengthW();

        /// <summary>
        /// 如果指定窗口的标题栏有一个) ，则将其文本复制到缓冲区中 (。 如果指定的窗口是控件，则会复制控件的文本。 但是，GetWindowText 无法检索另一个应用程序中控件的文本。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowTextW();

        /// <summary>
        /// 检索创建指定窗口的线程的标识符，以及创建窗口的进程标识符（可选）。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowThreadProcessId();

        /// <summary>
        /// GID_ROTATE_ANGLE_FROM_ARGUMENT宏用于在接收WM_GESTURE结构中的值时解释 GID_ROTATE ullArgument 值。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GID_ROTATE_ANGLE_FROM_ARGUMENT();

        /// <summary>
        /// 将弧度值转换为旋转手势消息的参数。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GID_ROTATE_ANGLE_TO_ARGUMENT();

        /// <summary>
        /// GrayString 函数在指定位置绘制灰色文本。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GrayStringA();

        /// <summary>
        /// GrayString 函数在指定位置绘制灰色文本。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr GrayStringW();

        /// <summary>
        /// 检查指定的指针消息是否被视为有意而不是意外。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr HAS_POINTER_CONFIDENCE_WPARAM();

        /// <summary>
        /// 从屏幕中删除插入符号。 隐藏插入符号不会销毁其当前形状或使插入点失效。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr HideCaret();

        /// <summary>
        /// 在菜单栏中的项中添加或删除突出显示。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr HiliteMenuItem();

        /// <summary>
        /// InflateRect 函数增加或减小指定矩形的宽度和高度。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr InflateRect();

        /// <summary>
        /// 为呼叫应用程序配置触摸注入上下文，并初始化应用可以注入的最大同时联系人数。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr InitializeTouchInjection();

        /// <summary>
        /// 模拟指针输入 (笔或触摸) 。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr InjectSyntheticPointerInput();

        /// <summary>
        /// 模拟触摸输入。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr InjectTouchInput();

        /// <summary>
        /// 确定当前窗口过程是处理从同一进程中的另一个线程发送的消息 (，还是通过调用 SendMessage 函数) 从另一个线程发送的消息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr InSendMessage();

        /// <summary>
        /// 确定当前窗口过程正在处理从同一进程中的另一个线程发送的消息 (还是另一个进程) 。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr InSendMessageEx();

        /// <summary>
        /// 将新菜单项插入菜单，将其他项向下移动。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr InsertMenuA();

        /// <summary>
        /// 在菜单中的指定位置插入新菜单项。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr InsertMenuItemA();

        /// <summary>
        /// 在菜单中的指定位置插入新菜单项。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr InsertMenuItemW();

        /// <summary>
        /// 将新菜单项插入菜单，将其他项向下移动。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr InsertMenuW();

        /// <summary>
        /// 如果指定窗口的标题栏有一个) ，则将其文本复制到缓冲区中 (。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr InternalGetWindowText();

        /// <summary>
        /// IntersectRect 函数计算两个源矩形的交集，并将交集矩形的坐标置于目标矩形中。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IntersectRect();

        /// <summary>
        /// InvalidateRect 函数向指定窗口的更新区域添加一个矩形。 更新区域表示必须重新绘制的窗口工作区的一部分。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr InvalidateRect();

        /// <summary>
        /// InvalidateRgn 函数通过将其添加到窗口的当前更新区域，使指定区域中的工作区失效。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr InvalidateRgn();

        /// <summary>
        /// InvertRect 函数通过对矩形内部每个像素的颜色值执行逻辑 NOT 操作来反转窗口中的矩形。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr InvertRect();

        /// <summary>
        /// 确定值是否为资源的整数标识符。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IS_INTRESOURCE();

        /// <summary>
        /// 检查指定的指针输入是突然结束还是无效，指示交互未完成。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IS_POINTER_CANCELED_WPARAM();

        /// <summary>
        /// 检查指定的指针是否执行了第五个操作。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IS_POINTER_FIFTHBUTTON_WPARAM();

        /// <summary>
        /// 检查指定的指针是否执行了第一个操作。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IS_POINTER_FIRSTBUTTON_WPARAM();

        /// <summary>
        /// 检查指针宏是否设置指定的标志。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IS_POINTER_FLAG_SET_WPARAM();

        /// <summary>
        /// 检查指定的指针是否执行了第四个操作。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IS_POINTER_FOURTHBUTTON_WPARAM();

        /// <summary>
        /// 检查指定的指针是否处于联系中。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IS_POINTER_INCONTACT_WPARAM();

        /// <summary>
        /// 检查指定的指针是否在范围内。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IS_POINTER_INRANGE_WPARAM();

        /// <summary>
        /// 检查指定的指针是否为新指针。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IS_POINTER_NEW_WPARAM();

        /// <summary>
        /// 检查指定的指针是否执行了第二个操作。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IS_POINTER_SECONDBUTTON_WPARAM();

        /// <summary>
        /// 检查指定的指针是否执行了第三个操作。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IS_POINTER_THIRDBUTTON_WPARAM();

        /// <summary>
        /// 确定字符是否为字母字符。 此决定基于用户在设置期间或通过控制面板选择的语言的语义。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsCharAlphaA();

        /// <summary>
        /// 确定字符是字母还是数字字符。 此决定基于用户在设置期间或通过控制面板选择的语言的语义。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsCharAlphaNumericA();

        /// <summary>
        /// 确定字符是字母还是数字字符。 此决定基于用户在设置期间或通过控制面板选择的语言的语义。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsCharAlphaNumericW();

        /// <summary>
        /// 确定字符是否为字母字符。 此决定基于用户在设置期间或通过控制面板选择的语言的语义。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsCharAlphaW();

        /// <summary>
        /// 确定字符是否为小写。 此决定基于用户在设置期间或通过控制面板选择的语言的语义。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsCharLowerA();

        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsCharLowerW();

        /// <summary>
        /// 确定字符是否为大写。 此决定基于用户在设置期间或通过控制面板选择的语言的语义。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsCharUpperA();

        /// <summary>
        /// 确定字符是否为大写。 此决定基于用户在设置期间或通过控制面板选择的语言的语义。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsCharUpperW();

        /// <summary>
        /// 确定窗口是指定父窗口的子窗口还是子窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsChild();

        /// <summary>
        /// 确定剪贴板是否包含指定格式的数据。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsClipboardFormatAvailable();

        /// <summary>
        /// 确定消息是否适用于指定的对话框，如果是，则处理该消息。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsDialogMessageA();

        /// <summary>
        /// 确定消息是否适用于指定的对话框，如果是，则处理该消息。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsDialogMessageW();

        /// <summary>
        /// IsDlgButtonChecked 函数确定是检查按钮控件还是检查三态按钮控件、未选中还是不确定。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsDlgButtonChecked();

        /// <summary>
        /// 确定调用线程是否已经是 GUI 线程。 它还可以选择将线程转换为 GUI 线程。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsGUIThread();

        /// <summary>
        /// 确定系统是否认为指定的应用程序未响应。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsHungAppWindow();

        /// <summary>
        /// 确定指定的窗口是否最小化 (标志性的) 。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsIconic();

        /// <summary>
        /// 确定进程是否属于 Windows 应用商店应用。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsImmersiveProcess();

        /// <summary>
        /// 确定句柄是否为菜单句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsMenu();

        /// <summary>
        /// 指示是否为鼠标设置 EnableMouseInPointer 作为指针输入设备并发送WM_POINTER消息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsMouseInPointerEnabled();

        /// <summary>
        /// IsProcessDPIAware 可能已更改或不可用。 请改用 GetProcessDPIAwareness。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsProcessDPIAware();

        /// <summary>
        /// IsRectEmpty 函数确定指定的矩形是否为空。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsRectEmpty();

        /// <summary>
        /// 检查指定的窗口是否支持触摸，并且（可选）检索为窗口的触摸功能设置的修饰标志。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsTouchWindow();

        /// <summary>
        /// 确定指定的DPI_AWARENESS_CONTEXT是否有效且受当前系统支持。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsValidDpiAwarenessContext();

        /// <summary>
        /// 确定指定的窗口句柄是否标识现有窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsWindow();

        /// <summary>
        /// 确定是否为鼠标和键盘输入启用指定的窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsWindowEnabled();

        /// <summary>
        /// 确定指定的窗口是否为本机 Unicode 窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsWindowUnicode();

        /// <summary>
        /// 确定指定窗口的可见性状态。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsWindowVisible();

        /// <summary>
        /// 确定是否安装了 WinEvent 挂钩，该挂钩可能会收到指定事件的通知。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsWinEventHookInstalled();

        /// <summary>
        /// 确定从当前线程队列中读取的最后一条消息是否源自 WOW64 进程。
        /// </summary>
        /// <summary>
        /// IsWow64Message
        /// </summary>

        /// <summary>
        /// 确定窗口是否最大化。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr IsZoomed();

        /// <summary>
        /// 合成击键。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr keybd_event();

        /// <summary>
        /// 销毁指定的计时器。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr KillTimer();

        /// <summary>
        /// 加载指定的加速器表。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LoadAcceleratorsA();

        /// <summary>
        /// 加载指定的加速器表。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LoadAcceleratorsW();

        /// <summary>
        /// LoadBitmap 函数从模块的可执行文件加载指定的位图资源。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LoadBitmapA();

        /// <summary>
        /// LoadBitmap 函数从模块的可执行文件加载指定的位图资源。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LoadBitmapW();

        /// <summary>
        /// 从与应用程序实例关联的可执行 (.EXE) 文件中加载指定的游标资源。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LoadCursorA();

        /// <summary>
        /// 基于文件中包含的数据创建游标。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LoadCursorFromFileA();

        /// <summary>
        /// 基于文件中包含的数据创建游标。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LoadCursorFromFileW();

        /// <summary>
        /// 从与应用程序实例关联的可执行 (.EXE) 文件中加载指定的游标资源。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LoadCursorW();

        /// <summary>
        /// 从与应用程序实例关联的可执行文件 (.exe) 文件加载指定的图标资源。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LoadIconA();

        /// <summary>
        /// 从与应用程序实例关联的可执行文件 (.exe) 文件加载指定的图标资源。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LoadIconW();

        /// <summary>
        /// 加载图标、游标、动画游标或位图。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LoadImageA();

        /// <summary>
        /// 加载图标、游标、动画游标或位图。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LoadImageW();

        /// <summary>
        /// 将以前称为键盘布局的新输入区域设置标识符加载到系统中) (。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LoadKeyboardLayoutA();

        /// <summary>
        /// 将以前称为键盘布局的新输入区域设置标识符加载到系统中) (。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LoadKeyboardLayoutW();

        /// <summary>
        /// 从与应用程序实例关联的可执行文件 (.exe) 加载指定的菜单资源。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LoadMenuA();

        /// <summary>
        /// 在内存中加载指定的菜单模板。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LoadMenuIndirectA();

        /// <summary>
        /// 在内存中加载指定的菜单模板。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LoadMenuIndirectW();

        /// <summary>
        /// 从与应用程序实例关联的可执行文件 (.exe) 加载指定的菜单资源。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LoadMenuW();

        /// <summary>
        /// 从与指定模块关联的可执行文件加载字符串资源，将字符串复制到缓冲区中，并追加终止 null 字符。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LoadStringA();

        /// <summary>
        /// 从与指定模块关联的可执行文件加载字符串资源，将字符串复制到缓冲区中，并追加终止 null 字符。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LoadStringW();

        /// <summary>
        /// 前台进程可以调用 LockSetForegroundWindow 函数以禁用对 SetForegroundWindow 函数的调用。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LockSetForegroundWindow();

        /// <summary>
        /// LockWindowUpdate 函数在指定窗口中禁用或启用绘图。 一次只能锁定一个窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LockWindowUpdate();

        /// <summary>
        /// 锁定工作站的显示器。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LockWorkStation();

        /// <summary>
        /// 将窗口中某个点的逻辑坐标转换为物理坐标。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LogicalToPhysicalPoint();

        /// <summary>
        /// 将窗口中的点从逻辑坐标转换为物理坐标，无论每英寸点 (dpi) 调用方感知。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LogicalToPhysicalPointForPerMonitorDPI();

        /// <summary>
        /// 在图标或光标数据中搜索最适合当前显示设备的图标或光标。 (LookupIconIdFromDirectory)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LookupIconIdFromDirectory();

        /// <summary>
        /// 在图标或光标数据中搜索最适合当前显示设备的图标或光标。 (LookupIconIdFromDirectoryEx)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr LookupIconIdFromDirectoryEx();

        /// <summary>
        /// 将整数值转换为与资源管理功能兼容的资源类型。 此宏用于代替包含资源名称的字符串。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MAKEINTRESOURCEA();

        /// <summary>
        /// 将整数值转换为与资源管理功能兼容的资源类型。 此宏用于代替包含资源名称的字符串。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MAKEINTRESOURCEW();

        /// <summary>
        /// 创建一个值，以便在消息中用作 lParam 参数。 宏连接指定的值。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MAKELPARAM();

        /// <summary>
        /// 创建一个值，该值用作窗口过程的返回值。 宏连接指定的值。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MAKELRESULT();

        /// <summary>
        /// 创建一个值，以便在消息中用作 wParam 参数。 宏连接指定的值。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MAKEWPARAM();

        /// <summary>
        /// 将指定的对话框单位转换为屏幕单位 (像素) 。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MapDialogRect();

        /// <summary>
        /// 将 (映射) 虚拟密钥代码转换为扫描代码或字符值，或者将扫描代码转换为虚拟密钥代码。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MapVirtualKeyA();

        /// <summary>
        /// 将 (映射) 虚拟密钥代码转换为扫描代码或字符值，或者将扫描代码转换为虚拟密钥代码。 该函数使用输入语言和输入区域设置标识符翻译代码。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MapVirtualKeyExA();

        /// <summary>
        /// 将 (映射) 虚拟密钥代码转换为扫描代码或字符值，或将扫描代码转换为虚拟密钥代码。 该函数使用输入语言和输入区域设置标识符翻译代码。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MapVirtualKeyExW();

        /// <summary>
        /// 将 (映射) 虚拟密钥代码转换为扫描代码或字符值，或将扫描代码转换为虚拟密钥代码。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MapVirtualKeyW();

        /// <summary>
        /// MapWindowPoints 函数将 (映射) 一组相对于一个窗口的坐标空间的点转换为相对于另一个窗口的坐标空间。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MapWindowPoints();

        /// <summary>
        /// 确定位于指定位置的菜单项（如果有）。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MenuItemFromPoint();

        /// <summary>
        /// 播放波形声音。 每个声音类型的波形声音由注册表中的一个条目标识。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBeep();

        /// <summary>
        /// 显示一个模式对话框，其中包含系统图标、一组按钮和一条简短的应用程序特定消息，例如状态或错误信息。 消息框返回一个整数值，该值指示用户单击的按钮。 (MessageBoxW)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBox();

        /// <summary>
        /// 显示一个模式对话框，其中包含系统图标、一组按钮和一条简短的应用程序特定消息，例如状态或错误信息。 消息框返回一个整数值，该值指示用户单击的按钮。 (MessageBoxA)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBoxA();

        /// <summary>
        /// 创建、显示和操作消息框。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBoxExA();

        /// <summary>
        /// 创建、显示和操作消息框。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBoxExW();

        /// <summary>
        /// 创建、显示和操作消息框。 消息框包含应用程序定义的消息文本和标题、任何图标以及预定义的按下按钮的任意组合。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBoxIndirectA();

        /// <summary>
        /// 创建、显示和操作消息框。 消息框包含应用程序定义的消息文本和标题、任何图标以及预定义的按下按钮的任意组合。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBoxIndirectW();

        /// <summary>
        /// 显示一个模式对话框，其中包含系统图标、一组按钮和一条简短的应用程序特定消息，例如状态或错误信息。 消息框返回一个整数值，该值指示用户单击的按钮。 (MessageBoxW)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBoxW();

        /// <summary>
        /// 更改现有菜单项。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ModifyMenuA();

        /// <summary>
        /// 更改现有菜单项。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ModifyMenuW();

        /// <summary>
        /// MonitorFromPoint 函数检索包含指定点的显示监视器的句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MonitorFromPoint();

        /// <summary>
        /// MonitorFromRect 函数检索具有具有指定矩形交集最大区域的显示监视器的句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MonitorFromRect();

        /// <summary>
        /// MonitorFromWindow 函数检索显示监视器的句柄，该监视器具有与指定窗口的边界矩形相交的最大区域。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MonitorFromWindow();

        /// <summary>
        /// mouse_event函数合成鼠标运动和按钮单击。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr mouse_event();

        /// <summary>
        /// 更改指定窗口的位置和尺寸。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MoveWindow();

        /// <summary>
        /// 等待一个或多个指定对象处于信号状态或超时间隔过。 这些对象可以包括输入事件对象。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MsgWaitForMultipleObjects();

        /// <summary>
        /// 等待一个或多个指定对象处于信号状态、I/O 完成例程或异步过程调用 (APC) 排队到线程或超时间隔。 对象的数组可以包括输入事件对象。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr MsgWaitForMultipleObjectsEx();

        /// <summary>
        /// 检索 RAWINPUT 结构数组中下一个结构的位置。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr NEXTRAWINPUTBLOCK();

        /// <summary>
        /// 向系统发出信号，指出发生了预定义事件。 如果任何客户端应用程序为该事件注册了挂钩函数，系统将调用客户端的挂钩函数。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr NotifyWinEvent();

        /// <summary>
        /// 将 OEMASCII 代码 0 映射到 OEM 扫描代码和移位状态0x0FF。 该函数提供的信息允许程序通过模拟键盘输入将 OEM 文本发送到另一个程序。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr OemKeyScan();

        /// <summary>
        /// 将 OEM 定义的字符集中的字符串转换为 ANSI 或宽字符字符串。警告不使用。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr OemToCharA();

        /// <summary>
        /// 将 OEM 定义的字符集中的指定字符数转换为 ANSI 或宽字符字符串。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr OemToCharBuffA();

        /// <summary>
        /// 将 OEM 定义的字符集中的指定字符数转换为 ANSI 或宽字符字符串。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr OemToCharBuffW();

        /// <summary>
        /// 将 OEM 定义的字符集中的字符串转换为 ANSI 或宽字符字符串。警告不使用。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr OemToCharW();

        /// <summary>
        /// OffsetRect 函数按指定的偏移量移动指定的矩形。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr OffsetRect();

        /// <summary>
        /// 打开剪贴板进行检查，并阻止其他应用程序修改剪贴板内容。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr OpenClipboard();

        /// <summary>
        /// 打开指定的桌面对象。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr OpenDesktopA();

        /// <summary>
        /// 打开指定的桌面对象。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr OpenDesktopW();

        /// <summary>
        /// 将最小化的 (标志性的) 窗口还原到其以前的大小和位置;然后激活窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr OpenIcon();

        /// <summary>
        /// 打开接收用户输入的桌面。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr OpenInputDesktop();

        /// <summary>
        /// 打开指定的窗口工作站。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr OpenWindowStationA();

        /// <summary>
        /// 打开指定的窗口工作站。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr OpenWindowStationW();

        /// <summary>
        /// 返回邻近评估分数和调整的触摸点坐标作为WM_TOUCHHITTESTING回调的打包值。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr PackTouchHitTestingProximityEvaluation();

        /// <summary>
        /// PaintDesktop 函数使用桌面模式或壁纸填充指定设备上下文中的剪辑区域。 该函数主要用于 shell 桌面。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr PaintDesktop();

        /// <summary>
        /// 调度传入的非排队消息，检查已发布消息的线程消息队列，并检索消息 (是否存在任何) 。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr PeekMessageA();

        /// <summary>
        /// 调度传入的非排队消息，检查已发布消息的线程消息队列，并检索消息 (是否存在任何) 。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr PeekMessageW();

        /// <summary>
        /// 将窗口中某个点的物理坐标转换为逻辑坐标。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr PhysicalToLogicalPoint();

        /// <summary>
        /// 将窗口中的点从物理坐标转换为逻辑坐标，无论每英寸点 (dpi) 调用方感知。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr PhysicalToLogicalPointForPerMonitorDPI();

        /// <summary>
        /// POINTSTOPOINT 宏将 POINTS 结构的内容复制到 POINT 结构中。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr POINTSTOPOINT();

        /// <summary>
        /// POINTTOPOINTS 宏将 POINT 结构转换为 POINTS 结构。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr POINTTOPOINTS();

        /// <summary>
        /// 将 (帖子) 与创建指定窗口的线程关联的消息队列中，并返回，而无需等待线程处理消息。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr PostMessageA();

        /// <summary>
        /// 将 (帖子) 与创建指定窗口的线程关联的消息队列中，并返回，而无需等待线程处理消息。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr PostMessageW();

        /// <summary>
        /// 向系统指示线程已发出终止 (退出) 的请求。 它通常用于响应WM_DESTROY消息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr PostQuitMessage();

        /// <summary>
        /// 将消息发布到指定线程的消息队列。 它返回时不等待线程处理消息。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr PostThreadMessageA();

        /// <summary>
        /// 将消息发布到指定线程的消息队列。 它返回时不等待线程处理消息。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr PostThreadMessageW();

        /// <summary>
        /// PrintWindow 函数将视觉窗口复制到指定的设备上下文中， (DC) ，通常是打印机 DC。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr PrintWindow();

        /// <summary>
        /// 创建从指定文件中提取的图标的句柄数组。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr PrivateExtractIconsA();

        /// <summary>
        /// 创建从指定文件中提取的图标的句柄数组。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr PrivateExtractIconsW();

        /// <summary>
        /// PtInRect 函数确定指定的点是否位于指定的矩形内。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr PtInRect();

        /// <summary>
        /// QueryDisplayConfig 函数在当前设置中检索有关所有显示设备或视图的所有可能显示路径的信息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr QueryDisplayConfig();

        /// <summary>
        /// 检索指定点的子窗口的句柄。 搜索仅限于即时子窗口;孙子和更深的后代窗口没有搜索。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RealChildWindowFromPoint();

        /// <summary>
        /// 检索指定窗口类型的字符串。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RealGetWindowClassA();

        /// <summary>
        /// 检索指定窗口类型的字符串。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RealGetWindowClassW();

        /// <summary>
        /// RedrawWindow 函数更新窗口的工作区中的指定矩形或区域。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RedrawWindow();

        /// <summary>
        /// 注册一个窗口类，以便在对 CreateWindow 或 CreateWindowEx 函数的调用中随后使用。 (RegisterClassA)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RegisterClassA();

        /// <summary>
        /// 注册一个窗口类，以便在对 CreateWindow 或 CreateWindowEx 函数的调用中随后使用。 (RegisterClassExA)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RegisterClassExA();

        /// <summary>
        /// 注册一个窗口类，以便在对 CreateWindow 或 CreateWindowEx 函数的调用中随后使用。 (RegisterClassExW)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RegisterClassExW();

        /// <summary>
        /// 注册一个窗口类，以便在对 CreateWindow 或 CreateWindowEx 函数的调用中随后使用。 (RegisterClassW)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RegisterClassW();

        /// <summary>
        /// 注册新的剪贴板格式。 然后，此格式可用作有效的剪贴板格式。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RegisterClipboardFormatA();

        /// <summary>
        /// 注册新的剪贴板格式。 然后，此格式可用作有效的剪贴板格式。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RegisterClipboardFormatW();

        /// <summary>
        /// 注册窗口将为其接收通知的设备或设备类型。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RegisterDeviceNotificationA();

        /// <summary>
        /// 注册窗口将为其接收通知的设备或设备类型。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RegisterDeviceNotificationW();

        /// <summary>
        /// 允许应用或 UI 框架注册和注销窗口以接收通知以消除其工具提示窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RegisterForTooltipDismissNotification();

        /// <summary>
        /// 定义系统范围的热键。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RegisterHotKey();

        /// <summary>
        /// 注册一个窗口来处理WM_POINTERDEVICECHANGE、WM_POINTERDEVICEINRANGE和WM_POINTERDEVICEOUTOFRANGE指针设备通知。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RegisterPointerDeviceNotifications();

        /// <summary>
        /// 允许调用方注册将指定类型的所有指针输入重定向到的目标窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RegisterPointerInputTarget();

        /// <summary>
        /// RegisterPointerInputTargetEx 可能会更改或不可用。 请改用 RegisterPointerInputTarget。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RegisterPointerInputTargetEx();

        /// <summary>
        /// 注册应用程序以接收特定电源设置事件的电源设置通知。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RegisterPowerSettingNotification();

        /// <summary>
        /// 注册提供原始输入数据的设备。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RegisterRawInputDevices();

        /// <summary>
        /// 注册指定的 Shell 窗口，以接收对 Shell 应用程序有用的事件或通知的某些消息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RegisterShellHookWindow();

        /// <summary>
        /// 注册以在系统暂停或恢复时接收通知。 类似于 PowerRegisterSuspendResumeNotification，但在用户模式下运行，可以采用窗口句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RegisterSuspendResumeNotification();

        /// <summary>
        /// 注册一个窗口来处理WM_TOUCHHITTESTING通知。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RegisterTouchHitTestingWindow();

        /// <summary>
        /// 将窗口注册为支持触摸。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RegisterTouchWindow();

        /// <summary>
        /// 定义保证在整个系统中唯一的新窗口消息。 发送或发布消息时，可以使用消息值。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RegisterWindowMessageA();

        /// <summary>
        /// 定义保证在整个系统中唯一的新窗口消息。 发送或发布消息时，可以使用消息值。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RegisterWindowMessageW();

        /// <summary>
        /// 从当前线程中的窗口释放鼠标捕获并还原正常的鼠标输入处理。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ReleaseCapture();

        /// <summary>
        /// ReleaseDC 函数 (DC) 发布设备上下文，释放它供其他应用程序使用。 ReleaseDC 函数的效果取决于 DC 的类型。 它只释放公用 DC 和窗口 DC。 它对类或专用 DC 没有影响。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ReleaseDC();

        /// <summary>
        /// 从系统维护的剪贴板格式侦听器列表中删除给定窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RemoveClipboardFormatListener();

        /// <summary>
        /// 删除菜单项或从指定菜单中分离子菜单。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RemoveMenu();

        /// <summary>
        /// 从指定窗口的属性列表中删除一个条目。 指定的字符串标识要删除的条目。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RemovePropA();

        /// <summary>
        /// 从指定窗口的属性列表中删除一个条目。 指定的字符串标识要删除的条目。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr RemovePropW();

        /// <summary>
        /// 通过 SendMessage 函数回复从另一个线程发送的消息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ReplyMessage();

        /// <summary>
        /// ScreenToClient 函数将屏幕上指定点的屏幕坐标转换为工作区坐标。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ScreenToClient();

        /// <summary>
        /// ScrollDC 函数水平和垂直滚动一个位矩形。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ScrollDC();

        /// <summary>
        /// ScrollWindow 函数滚动指定窗口的工作区的内容。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ScrollWindow();

        /// <summary>
        /// ScrollWindowEx 函数滚动指定窗口的工作区的内容。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ScrollWindowEx();

        /// <summary>
        /// 将消息发送到对话框中的指定控件。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SendDlgItemMessageA();

        /// <summary>
        /// 将消息发送到对话框中的指定控件。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SendDlgItemMessageW();

        /// <summary>
        /// 合成击键、鼠标动作和按钮单击。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SendInput();

        /// <summary>
        /// 将指定的消息发送到窗口或窗口。 SendMessage 函数调用指定窗口的窗口过程，在窗口过程处理消息之前不会返回。 (SendMessageW)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage();

        /// <summary>
        /// 将指定的消息发送到窗口或窗口。 SendMessage 函数调用指定窗口的窗口过程，在窗口过程处理消息之前不会返回。 (SendMessageA)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessageA();

        /// <summary>
        /// 将指定的消息发送到窗口或窗口。 (SendMessageCallbackA)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessageCallbackA();

        /// <summary>
        /// 将指定的消息发送到窗口或窗口。 (SendMessageCallbackW)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessageCallbackW();

        /// <summary>
        /// 将指定的消息发送到一个或多个窗口。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessageTimeoutA();

        /// <summary>
        /// 将指定的消息发送到一个或多个窗口。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessageTimeoutW();

        /// <summary>
        /// 将指定的消息发送到窗口或窗口。 SendMessage 函数调用指定窗口的窗口过程，在窗口过程处理消息之前不会返回。 (SendMessageW)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessageW();

        /// <summary>
        /// 将指定的消息发送到窗口或窗口。 (SendNotifyMessageA)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SendNotifyMessageA();

        /// <summary>
        /// 将指定的消息发送到窗口或窗口。 (SendNotifyMessageW)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SendNotifyMessageW();

        /// <summary>
        /// 激活窗口。 窗口必须附加到调用线程的消息队列。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetActiveWindow();

        /// <summary>
        /// SetAdditionalForegroundBoostProcesses 是一种性能辅助 API，可帮助应用程序使用多进程应用程序模型，其中多个进程会作为数据或呈现提供前台体验。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetAdditionalForegroundBoostProcesses();

        /// <summary>
        /// 将鼠标捕获设置为属于当前线程的指定窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetCapture();

        /// <summary>
        /// 将插入点闪烁时间设置为指定的毫秒数。 闪烁时间是倒转插入点像素所需的已用时间（以毫秒为单位）。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetCaretBlinkTime();

        /// <summary>
        /// 将插入点移动到指定的坐标。 如果拥有插入点的窗口是使用CS_OWNDC类样式创建的，则指定的坐标受与该窗口关联的设备上下文的映射模式的约束。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetCaretPos();

        /// <summary>
        /// 将指定的 32 位 (长) 值替换为指定窗口所属的类的额外类内存或 WNDCLASSEX 结构。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetClassLongA();

        /// <summary>
        /// 替换位于额外类内存中的指定偏移量或指定窗口所属类的 WNDCLASSEX 结构中的指定值。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetClassLongPtrA();

        /// <summary>
        /// 替换位于额外类内存中的指定偏移量或指定窗口所属类的 WNDCLASSEX 结构中的指定值。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetClassLongPtrW();

        /// <summary>
        /// 将指定的 32 位 (长) 值替换为指定窗口所属的类的额外类内存或 WNDCLASSEX 结构。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetClassLongW();

        /// <summary>
        /// 将 16 位 (WORD) 值替换为指定窗口所属窗口类的额外类内存。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetClassWord();

        /// <summary>
        /// 以指定的剪贴板格式将数据放在剪贴板上。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetClipboardData();

        /// <summary>
        /// 将指定的窗口添加到剪贴板查看器链。 剪贴板查看器窗口在剪贴板内容发生更改时收到WM_DRAWCLIPBOARD消息。 此函数用于向后兼容早期版本的 Windows。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetClipboardViewer();


        /// <summary>
        /// 使用指定的超时值和合并容错延迟创建计时器。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetCoalescableTimer();

        /// <summary>
        /// 设置光标形状。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetCursor();

        /// <summary>
        /// 将光标移动到指定的屏幕坐标。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetCursorPos();

        /// <summary>
        /// 替代对话框中子窗口的默认按监视器 DPI 缩放行为。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetDialogControlDpiChangeBehavior();

        /// <summary>
        /// Per-Monitor v2 上下文中的对话框会自动缩放 DPI。 使用此方法可以自定义其 DPI 更改行为。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetDialogDpiChangeBehavior();

        /// <summary>
        /// 设置当前进程的屏幕自动旋转首选项。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetDisplayAutoRotationPreferences();

        /// <summary>
        /// SetDisplayConfig 函数通过独占启用当前会话中的指定路径来修改显示拓扑、源和目标模式。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetDisplayConfig();

        /// <summary>
        /// 将对话框中控件的文本设置为指定整数值的字符串表示形式。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetDlgItemInt();

        /// <summary>
        /// 设置对话框中控件的标题或文本。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetDlgItemTextA();

        /// <summary>
        /// 设置对话框中控件的标题或文本。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetDlgItemTextW();

        /// <summary>
        /// 设置鼠标的双击时间。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetDoubleClickTime();

        /// <summary>
        /// 将键盘焦点设置为指定的窗口。 窗口必须附加到调用线程的消息队列。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetFocus();

        /// <summary>
        /// 将创建指定窗口的线程引入前台并激活窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetForegroundWindow();

        /// <summary>
        /// 配置从窗口为 Windows Touch 手势发送的消息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetGestureConfig();

        /// <summary>
        /// 将键盘键状态数组复制到调用线程的键盘输入状态表中。 这是 GetKeyboardState 和 GetKeyState 函数访问的同一个表。 对此表所做的更改不会影响任何其他线程的键盘输入。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetKeyboardState();

        /// <summary>
        /// 设置最后一个错误代码。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetLastErrorEx();

        /// <summary>
        /// 设置分层窗口的不透明度和透明度颜色键。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetLayeredWindowAttributes();

        /// <summary>
        /// 将新菜单分配给指定的窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetMenu();

        /// <summary>
        /// 将帮助上下文标识符与菜单相关联。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetMenuContextHelpId();

        /// <summary>
        /// 设置指定的菜单的默认菜单项。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetMenuDefaultItem();

        /// <summary>
        /// 设置指定菜单的信息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetMenuInfo();

        /// <summary>
        /// 将指定的位图与菜单项相关联。 无论菜单项是选中还是清除，系统都显示菜单项旁边的相应位图。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetMenuItemBitmaps();

        /// <summary>
        /// 更改有关菜单项的信息。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetMenuItemInfoA();

        /// <summary>
        /// 更改有关菜单项的信息。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetMenuItemInfoW();

        /// <summary>
        /// 设置当前线程的额外消息信息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetMessageExtraInfo();

        /// <summary>
        /// 更改指定子窗口的父窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetParent();

        /// <summary>
        /// 设置光标在物理坐标中的位置。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetPhysicalCursorPos();

        /// <summary>
        /// 仅在当前正在运行的进程没有父级或所有者的情况下创建窗口时，更改默认布局。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetProcessDefaultLayout();

        /// <summary>
        /// SetProcessDPIAware 可能会更改或不可用。 请改用 SetProcessDPIAwareness。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetProcessDPIAware();

        /// <summary>
        /// 将当前进程设置为每英寸指定点 (dpi) 感知上下文。 DPI 感知上下文来自DPI_AWARENESS_CONTEXT值。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetProcessDpiAwarenessContext();

        /// <summary>
        /// 免除调用进程的限制，防止桌面进程与 Windows 应用商店应用环境交互。 开发和调试工具使用此函数。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetProcessRestrictionExemption();

        /// <summary>
        /// 将指定的窗口工作站分配给调用进程。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetProcessWindowStation();

        /// <summary>
        /// 在指定窗口的属性列表中添加新条目或更改现有条目。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetPropA();

        /// <summary>
        /// 在指定窗口的属性列表中添加新条目或更改现有条目。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetPropW();

        /// <summary>
        /// SetRect 函数设置指定矩形的坐标。 这相当于将左、上、右和底部参数分配给 RECT 结构的相应成员。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetRect();

        /// <summary>
        /// SetRectEmpty 函数创建一个空矩形，其中所有坐标都设置为零。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetRectEmpty();

        /// <summary>
        /// SetScrollInfo 函数设置滚动条的参数，包括最小和最大滚动位置、页面大小以及滚动框的位置 (拇指) 。 如果请求，该函数还会重新绘制滚动条。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetScrollInfo();

        /// <summary>
        /// SetScrollPos 函数设置滚动框的位置 (拇指) 在指定的滚动条中，如果请求，请重新绘制滚动条以反映滚动框的新位置。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetScrollPos();

        /// <summary>
        /// SetScrollRange 函数设置指定滚动条的最小和最大滚动框位置。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetScrollRange();

        /// <summary>
        /// 设置指定显示元素的颜色。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetSysColors();

        /// <summary>
        /// 使应用程序能够自定义系统游标。 它将由 id 参数指定的系统游标的内容替换为 hcur 参数指定的游标的内容，然后销毁 hcur。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetSystemCursor();

        /// <summary>
        /// 设置在此线程上创建的游标所针对的 DPI 刻度。 缩放要对其显示的特定监视器的游标时，将考虑此值。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetThreadCursorCreationScaling();

        /// <summary>
        /// 将指定的桌面分配给调用线程。 桌面上的所有后续操作都使用授予桌面的访问权限。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetThreadDesktop();

        /// <summary>
        /// 将当前线程的 DPI 感知设置为所提供的值。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetThreadDpiAwarenessContext();

        /// <summary>
        /// 设置线程的DPI_HOSTING_BEHAVIOR。 此行为允许线程中创建的窗口托管具有不同DPI_AWARENESS_CONTEXT的子窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetThreadDpiHostingBehavior();

        /// <summary>
        /// 使用指定的超时值创建计时器。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetTimer();

        /// <summary>
        /// 设置有关指定窗口工作站或桌面对象的信息。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetUserObjectInformationA();

        /// <summary>
        /// 设置有关指定窗口工作站或桌面对象的信息。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetUserObjectInformationW();

        /// <summary>
        /// 设置用户对象的安全性。 例如，可以是窗口或 DDE 对话。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetUserObjectSecurity();

        /// <summary>
        /// 将帮助上下文标识符与指定的窗口相关联。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowContextHelpId();

        /// <summary>
        /// 将显示相关性设置存储在与窗口关联的 hWnd 上的内核模式下。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowDisplayAffinity();

        /// <summary>
        /// 设置窗口的反馈配置。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowFeedbackSetting();

        /// <summary>
        /// 更改指定窗口的属性。 该函数还会将 32 位 (长) 值设置为额外的窗口内存中的指定偏移量。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowLongA();

        /// <summary>
        /// 更改指定窗口的属性。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowLongPtrA();

        /// <summary>
        /// 更改指定窗口的属性。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowLongPtrW();

        /// <summary>
        /// 更改指定窗口的属性。 该函数还会将 32 位 (长) 值设置为额外的窗口内存中的指定偏移量。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowLongW();

        /// <summary>
        /// 设置显示状态和还原、最小化和最大化指定窗口的位置。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowPlacement();

        /// <summary>
        /// 更改子窗口、弹出窗口或顶级窗口的大小、位置和 Z 顺序。 这些窗口根据在屏幕上的外观进行排序。 最顶层的窗口接收最高排名，是 Z 顺序中的第一个窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowPos();

        /// <summary>
        /// SetWindowRgn 函数设置窗口的窗口区域。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowRgn();

        /// <summary>
        /// 将应用程序定义的挂钩过程安装到挂钩链中。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowsHookExA();

        /// <summary>
        /// 将应用程序定义的挂钩过程安装到挂钩链中。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowsHookExW();

        /// <summary>
        /// 如果指定窗口的标题栏具有一个) ，则更改其标题栏的文本 (。 如果指定的窗口是控件，控件的文本将更改。 但是，SetWindowText 无法更改另一个应用程序中控件的文本。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowTextA();

        /// <summary>
        /// 如果指定窗口的标题栏具有一个) ，则更改其标题栏的文本 (。 如果指定的窗口是控件，控件的文本将更改。 但是，SetWindowText 无法更改另一个应用程序中控件的文本。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowTextW();

        /// <summary>
        /// 为一系列事件设置事件挂钩函数。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SetWinEventHook();

        /// <summary>
        /// 使插入符号在屏幕的当前位置可见。 当插入符号变为可见时，它会自动开始闪烁。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ShowCaret();

        /// <summary>
        /// 显示或隐藏光标。 (ShowCursor)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ShowCursor();

        /// <summary>
        /// 显示或隐藏指定窗口拥有的所有弹出窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ShowOwnedPopups();

        /// <summary>
        /// ShowScrollBar 函数显示或隐藏指定的滚动条。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ShowScrollBar();

        /// <summary>
        /// 设置指定的窗口的显示状态。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ShowWindow();

        /// <summary>
        /// 设置窗口的显示状态，而无需等待操作完成。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ShowWindowAsync();

        /// <summary>
        /// 指示系统无法关闭，并设置在启动系统关闭时向用户显示的原因字符串。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ShutdownBlockReasonCreate();

        /// <summary>
        /// 指示系统可以关闭并释放原因字符串。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ShutdownBlockReasonDestroy();

        /// <summary>
        /// 检索 ShutdownBlockReasonCreate 函数设置的原因字符串。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ShutdownBlockReasonQuery();

        /// <summary>
        /// 确定哪个指针输入帧为指定的指针生成了最近检索的消息，并丢弃从同一指针输入帧生成的任何排队 (未检索) 指针输入消息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SkipPointerFrameMessages();

        /// <summary>
        /// 触发视觉信号以指示声音正在播放。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SoundSentry();

        /// <summary>
        /// SubtractRect 函数确定通过从另一个矩形中减去一个矩形而形成的矩形的坐标。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SubtractRect();

        /// <summary>
        /// 反转或还原左右鼠标按钮的含义。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SwapMouseButton();

        /// <summary>
        /// 使指定的桌面可见并激活它。 这使桌面能够接收来自用户的输入。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SwitchDesktop();

        /// <summary>
        /// 将焦点切换到指定的窗口，并将其带到前台。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SwitchToThisWindow();

        /// <summary>
        /// 检索或设置系统范围参数之一的值。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SystemParametersInfoA();

        /// <summary>
        /// 检索系统范围参数之一的值，同时考虑提供的 DPI 值。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SystemParametersInfoForDpi();

        /// <summary>
        /// 检索或设置系统范围参数之一的值。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr SystemParametersInfoW();

        /// <summary>
        /// TabbedTextOut 函数在指定位置写入一个字符串，将选项卡扩展到制表位数组中指定的值。 文本以当前选定的字体、背景色和文本颜色编写。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr TabbedTextOutA();

        /// <summary>
        /// TabbedTextOut 函数在指定位置写入一个字符串，将选项卡扩展到制表位数组中指定的值。 文本以当前选定的字体、背景色和文本颜色编写。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr TabbedTextOutW();

        /// <summary>
        /// 平铺指定父窗口的指定子窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr TileWindows();

        /// <summary>
        /// 将指定的虚拟键代码和键盘状态转换为相应的字符或字符。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ToAscii();

        /// <summary>
        /// 将指定的虚拟键代码和键盘状态转换为相应的字符或字符。 该函数使用输入语言和由输入区域设置标识符标识的物理键盘布局来翻译代码。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ToAsciiEx();

        /// <summary>
        /// 将触摸坐标转换为像素。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr TOUCH_COORD_TO_PIXEL();

        /// <summary>
        /// 将指定的虚拟键代码和键盘状态转换为相应的 Unicode 字符或字符。 (ToUnicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ToUnicode();

        /// <summary>
        /// 将指定的虚拟键代码和键盘状态转换为相应的 Unicode 字符或字符。 (ToUnicodeEx)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ToUnicodeEx();

        /// <summary>
        /// 当鼠标指针离开窗口或将鼠标悬停在窗口上指定时间时发布消息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr TrackMouseEvent();

        /// <summary>
        /// 在指定位置显示快捷菜单，并跟踪菜单上的项目选择。 快捷菜单可以在屏幕上的任意位置显示。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr TrackPopupMenu();

        /// <summary>
        /// 在指定位置显示快捷菜单，并跟踪快捷菜单上的项目选择。 快捷菜单可以在屏幕上的任意位置显示。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr TrackPopupMenuEx();

        /// <summary>
        /// 处理菜单命令的快捷键。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr TranslateAcceleratorA();

        /// <summary>
        /// 处理菜单命令的快捷键。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr TranslateAcceleratorW();

        /// <summary>
        /// 处理与指定 MDI 客户端窗口关联的多文档接口的窗口菜单命令的快捷键击 (MDI) 子窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr TranslateMDISysAccel();

        /// <summary>
        /// 将虚拟密钥消息转换为字符消息。 字符消息将发布到调用线程的消息队列，下次线程调用 GetMessage 或 PeekMessage 函数时读取该消息。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr TranslateMessage();

        /// <summary>
        /// 删除 SetWindowsHookEx 函数在挂钩链中安装的挂钩过程。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr UnhookWindowsHookEx();

        /// <summary>
        /// 删除之前对 SetWinEventHook 的调用创建的事件挂钩函数。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr UnhookWinEvent();

        /// <summary>
        /// UnionRect 函数创建两个矩形的并集。 并集是包含两个源矩形的最小矩形。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr UnionRect();

        /// <summary>
        /// (以前称为键盘布局) 卸载输入区域设置标识符。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr UnloadKeyboardLayout();

        /// <summary>
        /// 取消注册窗口类，释放类所需的内存。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr UnregisterClassA();

        /// <summary>
        /// 取消注册窗口类，释放类所需的内存。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr UnregisterClassW();

        /// <summary>
        /// 关闭指定的设备通知句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr UnregisterDeviceNotification();

        /// <summary>
        /// 释放以前由调用线程注册的热键。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr UnregisterHotKey();

        /// <summary>
        /// 允许调用方注销重定向指定类型的所有指针输入的目标窗口。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr UnregisterPointerInputTarget();

        /// <summary>
        /// UnregisterPointerInputTargetEx 可能会更改或不可用。 请改用 UnregisterPointerInputTarget。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr UnregisterPointerInputTargetEx();

        /// <summary>
        /// 取消注册电源设置通知。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr UnregisterPowerSettingNotification();

        /// <summary>
        /// 取消注册以在系统暂停或恢复时接收通知。 类似于 PowerUnregisterSuspendResumeNotification，但在用户模式下运行。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr UnregisterSuspendResumeNotification();

        /// <summary>
        /// 将窗口注册为不再支持触摸。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr UnregisterTouchWindow();

        /// <summary>
        /// 更新分层窗口的位置、大小、形状、内容和透明度。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr UpdateLayeredWindow();

        /// <summary>
        /// UpdateWindow 函数通过将WM_PAINT消息发送到窗口来更新指定窗口的工作区（如果窗口的更新区域不为空）。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr UpdateWindow();

        /// <summary>
        /// 向具有用户界面限制的作业授予或拒绝对 User 对象的句柄的访问权限。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr UserHandleGrantAccess();

        /// <summary>
        /// ValidateRect 函数通过从指定窗口的更新区域中删除矩形来验证矩形中的工作区。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ValidateRect();

        /// <summary>
        /// ValidateRgn 函数通过从指定窗口的当前更新区域中删除区域来验证区域中的工作区。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr ValidateRgn();

        /// <summary>
        /// 将字符转换为当前键盘的相应虚拟键代码和移位状态。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr VkKeyScanA();

        /// <summary>
        /// 将字符转换为相应的虚拟密钥代码并转移状态。 该函数使用输入语言和由输入区域设置标识符标识的物理键盘布局翻译字符。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr VkKeyScanExA();

        /// <summary>
        /// 将字符转换为相应的虚拟密钥代码并转移状态。 该函数使用输入语言和由输入区域设置标识符标识的物理键盘布局翻译字符。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr VkKeyScanExW();

        /// <summary>
        /// 将字符转换为当前键盘的相应虚拟键代码和移位状态。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr VkKeyScanW();

        /// <summary>
        /// 等待指定进程完成其初始输入，并且正在等待没有输入挂起的用户输入，或者直到超时间隔已过。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr WaitForInputIdle();

        /// <summary>
        /// 当线程在其消息队列中没有其他消息时，生成对其他线程的控制。 WaitMessage 函数会暂停线程，在线程的消息队列中放置新消息之前不会返回。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr WaitMessage();

        /// <summary>
        /// WindowFromDC 函数返回与指定显示设备上下文 (DC) 关联的窗口的句柄。 使用指定设备上下文的输出函数在此窗口中绘制。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr WindowFromDC();

        /// <summary>
        /// 检索包含指定物理点的窗口的句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr WindowFromPhysicalPoint();

        /// <summary>
        /// 检索包含指定点的窗口的句柄。
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr WindowFromPoint();

        /// <summary>
        /// 启动 Windows 帮助 (Winhelp.exe) 并传递指示应用程序请求的帮助性质的其他数据。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr WinHelpA();

        /// <summary>
        /// 启动 Windows 帮助 (Winhelp.exe) 并传递指示应用程序请求的帮助性质的其他数据。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr WinHelpW();

        /// <summary>
        /// 将数据写入指定的缓冲区。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr wsprintfA();

        /// <summary>
        /// 将数据写入指定的缓冲区。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr wsprintfW();

        /// <summary>
        ///  使用指向参数列表的指针将数据写入指定缓冲区。 (ANSI)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr wvsprintfA();

        /// <summary>
        ///  使用指向参数列表的指针将数据写入指定缓冲区。 (Unicode)
        /// </summary>
        [DllImport(_dllName, CharSet = CharSet.Auto)]
        public static extern IntPtr wvsprintf();

        #endregion
    }
}
