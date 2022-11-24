using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WinAPI
{
    /// <summary>
    /// 
    /// 
    /// </summary>
    public class User32
    {
        #region user32.dll函数

        /// <summary>
        /// 设置输入区域设置标识符 (以前称为调用线程或当前进程的键盘布局句柄) 。 输入区域设置标识符指定区域设置和键盘的物理布局。
        /// 此函数仅影响当前进程或线程的布局。
        /// </summary>
        /// <param name="hkl">要激活的输入区域设置标识符。
        /// 1：在系统维护的已加载区域设置标识符的循环列表中选择下一个区域设置标识符。
        /// 0：在系统维护的已加载区域设置标识符的循环列表中选择以前的区域设置标识符。</param>
        /// <param name="Flags">指定如何激活输入区域设置标识符</param>
        /// <returns>返回值的类型为 HKL。 如果函数成功，则返回值为以前的输入区域设置标识符。 否则为零。</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr ActivateKeyboardLayout(IntPtr hkl, KLF Flags);

        /// <summary>
        /// 将给定窗口置于系统维护的剪贴板格式侦听器列表中。
        /// </summary>
        /// <param name="hkl">要放置在剪贴板格式侦听器列表中的窗口的句柄。</param>
        /// <returns>如果成功，则返回 TRUE ;否则返回 FALSE 。</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddClipboardFormatListener(IntPtr hwnd);

        /// <summary>
        /// 根据所需的客户端矩形大小计算窗口矩形的所需大小。 然后，窗口矩形可以传递给 CreateWindow 函数，以创建其工作区为所需大小的窗口。
        /// </summary>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "AdjustWindowRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AdjustWindowRect(ref RECT lpRect, WS dwStyle, [MarshalAs(UnmanagedType.Bool)] bool bMenu);

        /// <summary>
        /// 根据客户端矩形的所需大小计算窗口矩形的所需大小。 然后，窗口矩形可以传递给 CreateWindowEx 函数，以创建其工作区为所需大小的窗口。
        /// </summary>
        /// <returns></returns>
        public static extern IntPtr AdjustWindowRectEx();

        /// <summary>
        /// 根据所需大小的客户端矩形和提供的 DPI 计算窗口矩形的所需大小。
        /// </summary>
        /// <returns></returns>
        public static extern IntPtr AdjustWindowRectExForDpi();

        /// <summary>
        /// 允许指定进程使用 SetForegroundWindow 函数设置前台窗口。 调用过程必须已能够设置前台窗口。 有关详细信息，请参阅本主题后面的备注。
        /// </summary>
        public static extern IntPtr AllowSetForegroundWindow();

        /// <summary>
        /// 使你可以在显示或隐藏窗口时产生特殊效果。 有四种类型的动画：_roll、幻灯片、折叠或展开和 alpha 混合淡化。
        /// </summary>
        /// <returns></returns>
        public static extern IntPtr AAnimateWindow();

       
        /// 指示屏幕上是否存在拥有、可见、顶级弹出窗口或重叠窗口。 该函数将搜索整个屏幕，而不仅仅是调用应用程序的工作区。
        //AAnyPopup();


        //将新项追加到指定菜单栏的末尾、下拉菜单、子菜单或快捷菜单。 可以使用此函数指定菜单项的内容、外观和行为。 (ANSI)
        //AppendMenuA


        //将新项追加到指定菜单栏的末尾、下拉菜单、子菜单或快捷菜单。 可以使用此函数指定菜单项的内容、外观和行为。 (Unicode)
        //AppendMenuW

        //确定两个DPI_AWARENESS_CONTEXT值是否相同。
        //AreDpiAwarenessContextsEqual

        //排列指定父窗口的所有最小化(标志性) 子窗口。
        //ArrangeIconicWindows

        //将一个线程的输入处理机制附加到另一个线程的输入处理机制。
        //AttachThreadInput

        //为多窗口位置结构分配内存，并将句柄返回到结构。
        //BeginDeferWindowPos

        //BeginPaint 函数准备用于绘制的指定窗口，并使用有关绘图的信息填充 PAINTSTRUCT 结构。
        //BeginPaint

        //阻止键盘和鼠标输入事件到达应用程序。
        //BlockInput

        //将指定的窗口置于 Z 顺序的顶部。 如果窗口是顶级窗口，则会激活该窗口。 如果窗口是子窗口，则会激活与子窗口关联的顶级父窗口。
        //BringWindowToTop

        //将邮件发送到指定的收件人。 (BroadcastSystemMessageW)
        //BroadcastSystemMessage

        //将邮件发送到指定的收件人。 (BroadcastSystemMessageA)
        //BroadcastSystemMessageA

        //将邮件发送到指定的收件人。 (BroadcastSystemMessageExA)
        //BroadcastSystemMessageExA

        //将邮件发送到指定的收件人。 (BroadcastSystemMessageExW)
        //BroadcastSystemMessageExW

        //将邮件发送到指定的收件人。 (BroadcastSystemMessageW)
        //BroadcastSystemMessageW

        //使用指定的定位点、弹出窗口大小、标志和可选的排除矩形计算适当的弹出窗口位置。
        //CalculatePopupWindowPosition

        //将指定的消息和挂钩代码传递给与WH_SYSMSGFILTER和WH_MSGFILTER挂钩关联的挂钩过程。 (ANSI)
        //CallMsgFilterA

        //将指定的消息和挂钩代码传递给与WH_SYSMSGFILTER和WH_MSGFILTER挂钩关联的挂钩过程。 (Unicode)
        //CallMsgFilterW

        //将挂钩信息传递到当前挂钩链中的下一个挂钩过程。 挂钩过程可以在处理挂钩信息之前或之后调用此函数。
        //CallNextHookEx

        //将消息信息传递给指定的窗口过程。 (ANSI)
        //CallWindowProcA

        //将消息信息传递给指定的窗口过程。 (Unicode)
        //CallWindowProcW

        //级联指定父窗口的指定子窗口。
        //CascadeWindows

        //从剪贴板查看器链中删除指定的窗口。
        //ChangeClipboardChain

        //ChangeDisplaySettings 函数将默认显示设备的设置更改为指定的图形模式。 (ANSI)
        //ChangeDisplaySettingsA

        //ChangeDisplaySettingsEx 函数将指定显示设备的设置更改为指定的图形模式。 (ANSI)
        //ChangeDisplaySettingsExA

        //ChangeDisplaySettingsEx 函数将指定显示设备的设置更改为指定的图形模式。 (Unicode)
        //ChangeDisplaySettingsExW

        //ChangeDisplaySettings 函数将默认显示设备的设置更改为指定的图形模式。 (Unicode)
        //ChangeDisplaySettingsW

        //在用户界面特权隔离(UIPI) 消息筛选器中添加或删除消息。
        //ChangeWindowMessageFilter

        //修改指定窗口的用户界面特权隔离(UIPI) 消息筛选器。
        //ChangeWindowMessageFilterEx

        //将字符串或单个字符转换为小写。 如果操作数是一个字符串，则函数将就地转换字符。 (ANSI)
        //CharLowerA

        //将缓冲区中的大写字符转换为小写字符。 该函数将就地转换字符。 (ANSI)
        //CharLowerBuffA

        //将缓冲区中的大写字符转换为小写字符。 该函数将就地转换字符。 (Unicode)
        //CharLowerBuffW

        //将字符串或单个字符转换为小写。 如果操作数是一个字符串，则函数将就地转换字符。 (Unicode)
        //CharLowerW

        //检索指向字符串中下一个字符的指针。 此函数可以处理包含单字节字符或多字节字符的字符串。 (ANSI)
        //CharNextA

        //检索指向字符串中下一个字符的指针。 此函数可以处理包含单字节字符或多字节字符的字符串。
        //CharNextExA

        //检索指向字符串中下一个字符的指针。 此函数可以处理包含单字节字符或多字节字符的字符串。 (Unicode)
        //CharNextW

        //检索指向字符串中上述字符的指针。 此函数可以处理包含单字节字符或多字节字符的字符串。 (ANSI)
        //CharPrevA

        //检索指向字符串中上述字符的指针。 此函数可以处理包含单字节字符或多字节字符的字符串。
        //CharPrevExA

        //检索指向字符串中上述字符的指针。 此函数可以处理包含单字节字符或多字节字符的字符串。 (Unicode)
        //CharPrevW

        //将字符串转换为 OEM 定义的字符集。警告不使用。 (ANSI)
        //CharToOemA

        //将字符串中的指定字符数转换为 OEM 定义的字符集。 (ANSI)
        //CharToOemBuffA

        //将字符串中的指定字符数转换为 OEM 定义的字符集。 (Unicode)
        //CharToOemBuffW

        //将字符串转换为 OEM 定义的字符集。警告不使用。 (Unicode)
        //CharToOemW

        //将字符串或单个字符转换为大写。 如果操作数是一个字符串，则函数将就地转换字符。 (ANSI)
        //CharUpperA

        //将缓冲区中的小写字符转换为大写字符。 该函数将就地转换字符。 (ANSI)
        //CharUpperBuffA

        //将缓冲区中的小写字符转换为大写字符。 该函数将就地转换字符。 (Unicode)
        //CharUpperBuffW

        //将字符串或单个字符转换为大写。 如果操作数是一个字符串，则函数将就地转换字符。 (Unicode)
        //CharUpperW

        //更改按钮控件的检查状态。
        //CheckDlgButton

        //将指定菜单项的复选标记属性的状态设置为选中或清除。
        //CheckMenuItem

        //检查指定的菜单项并使其成为单选项。 同时，该函数清除关联组中所有其他菜单项，并清除这些项目的无线电项类型标志。
        //CheckMenuRadioItem

        //将复选标记添加到(检查) 组中的指定单选按钮，并从(中删除复选标记) 组中所有其他单选按钮。
        //CheckRadioButton

        //确定属于父窗口的子窗口包含指定的点（如果有）。 搜索仅限于即时子窗口。 孙子，和更深的后代窗口没有搜索。
        //ChildWindowFromPoint

        //确定属于指定父窗口的子窗口包含指定的点（如果有）。
        //ChildWindowFromPointEx

        //ClientToScreen 函数将指定点的工作区坐标转换为屏幕坐标。
        //ClientToScreen

        //将光标限制在屏幕上的矩形区域。
        //ClipCursor

        //关闭剪贴板。
        //CloseClipboard

        //关闭桌面对象的打开句柄。
        //CloseDesktop

        //关闭与手势信息句柄关联的资源。
        //CloseGestureInfoHandle

        //关闭触摸输入句柄，释放与之关联的进程内存，并使句柄失效。
        //CloseTouchInputHandle

        //最小化(但不销毁指定窗口) 。
        //CloseWindow

        //关闭打开的窗口工作站句柄。
        //CloseWindowStation

        //复制指定的加速器表。 此函数用于获取对应于加速器表句柄的加速器表数据，或确定加速器表数据的大小。 (ANSI)
        //CopyAcceleratorTableA

        //复制指定的加速器表。 此函数用于获取对应于加速器表句柄的加速器表数据，或确定加速器表数据的大小。 (Unicode)
        //CopyAcceleratorTableW

        //复制指定的游标。
        //CopyCursor

        //将指定图标从另一个模块复制到当前模块。
        //CopyIcon

        //创建新的图像(图标、光标或位图) ，并将指定图像的属性复制到新图像。 如有必要，该函数会拉伸位以适应新图像的所需大小。
        //CopyImage

        //CopyRect 函数将一个矩形的坐标复制到另一个矩形。
        //CopyRect

        //检索剪贴板上当前不同数据格式的数目。
        //CountClipboardFormats

        //创建加速器表。 (ANSI)
        //CreateAcceleratorTableA

        //创建加速器表。 (Unicode)
        //CreateAcceleratorTableW

        //为系统插入符号创建一个新形状，并将插入符号的所有权分配给指定窗口。 插入符号形状可以是线条、块或位图。
        //CreateCaret

        //创建具有指定大小、位模式和热点的游标。
        //CreateCursor

        //创建新的桌面，将其与调用进程的当前窗口工作站相关联，并将其分配给调用线程。 (ANSI)
        //CreateDesktopA

        //创建具有指定堆的新桌面，将其与调用进程的当前窗口工作站相关联，并将其分配给调用线程。 (ANSI)
        //CreateDesktopExA

        //创建具有指定堆的新桌面，将其与调用进程的当前窗口工作站相关联，并将其分配给调用线程。 (Unicode)
        //CreateDesktopExW

        //创建新的桌面，将其与调用进程的当前窗口工作站相关联，并将其分配给调用线程。 (Unicode)
        //CreateDesktopW

        //从对话框模板资源创建无模式对话框。 CreateDialog 宏使用 CreateDialogParam 函数。 (ANSI)
        //CreateDialogA

        //从内存中的对话框模板创建无模式对话框。 CreateDialogIndirect 宏使用 CreateDialogIndirectParam 函数。 (ANSI)
        //CreateDialogIndirectA

        //从内存中的对话框模板创建无模式对话框。 (ANSI)
        //CreateDialogIndirectParamA

        //从内存中的对话框模板创建无模式对话框。 (Unicode)
        //CreateDialogIndirectParamW

        //从内存中的对话框模板创建无模式对话框。 CreateDialogIndirect 宏使用 CreateDialogIndirectParam 函数。 (Unicode)
        //CreateDialogIndirectW

        //从对话框模板资源创建无模式对话框。 (ANSI)
        //CreateDialogParamA

        //从对话框模板资源创建无模式对话框。 (Unicode)
        //CreateDialogParamW

        //从对话框模板资源创建无模式对话框。 CreateDialog 宏使用 CreateDialogParam 函数。 (Unicode)
        //CreateDialogW

        //创建具有指定大小、颜色和位模式的图标。
        //CreateIcon

        //从描述图标的资源位创建图标或游标。 (CreateIconFromResource)
        //CreateIconFromResource

        //从描述图标的资源位创建图标或游标。 (CreateIconFromResourceEx)
        //CreateIconFromResourceEx

        //从 ICONINFO 结构创建图标或光标。
        //CreateIconIndirect

        //(MDI) 子窗口创建多文档接口。 (ANSI)
        //CreateMDIWindowA

        //(MDI) 子窗口创建多文档接口。 (Unicode)
        //CreateMDIWindowW

        //创建菜单。 菜单最初为空，但可以使用 InsertMenuItem、AppendMenu 和 InsertMenu 函数填充菜单项。
        //CreateMenu

        //创建下拉菜单、子菜单或快捷菜单。
        //CreatePopupMenu

        //为调用应用程序配置指针注入设备，并初始化应用可以注入的最大同时指针数。
        //CreateSyntheticPointerDevice

        //创建重叠、弹出窗口或子窗口。 (ANSI)
        //CreateWindowA

        //创建具有扩展窗口样式的重叠、弹出窗口或子窗口;否则，此函数与 CreateWindow 函数相同。 (ANSI)
        //CreateWindowExA

        //创建具有扩展窗口样式的重叠、弹出窗口或子窗口;否则，此函数与 CreateWindow 函数相同。 (Unicode)
        //CreateWindowExW

        //创建一个窗口工作站对象，将其与调用过程相关联，并将其分配给当前会话。 (ANSI)
        //CreateWindowStationA

        //创建一个窗口工作站对象，将其与调用过程相关联，并将其分配给当前会话。 (Unicode)
        //CreateWindowStationW

        //创建重叠、弹出窗口或子窗口。 (Unicode)
        //CreateWindowW

        //调用默认对话框窗口过程，为具有专用窗口类的对话框不处理的任何窗口消息提供默认处理。 (ANSI)
        //DefDlgProcA

        //调用默认对话框窗口过程，为具有专用窗口类的对话框不处理的任何窗口消息提供默认处理。 (Unicode)
        //DefDlgProcW

        //汇报指定窗口的指定多窗口位置结构。
        //DeferWindowPos

        //为多文档接口的窗口过程 (MDI) 框架窗口未处理的任何窗口消息提供默认处理。 (ANSI)
        //DefFrameProcA

        //为多文档接口的窗口过程 (MDI) 框架窗口未处理的任何窗口消息提供默认处理。 (Unicode)
        //DefFrameProcW

        //为多文档接口的窗口过程 (MDI) 子窗口未处理的任何窗口消息提供默认处理。 (ANSI)
        //DefMDIChildProcA

        //为多文档接口的窗口过程 (MDI) 子窗口未处理的任何窗口消息提供默认处理。 (Unicode)
        //DefMDIChildProcW

        //验证 RAWINPUTHEADER 结构的大小是否正确。
        //DefRawInputProc

        //调用默认窗口过程，为应用程序未处理的任何窗口消息提供默认处理。 (ANSI)
        //DefWindowProcA

        //调用默认窗口过程，为应用程序未处理的任何窗口消息提供默认处理。 (Unicode)
        //DefWindowProcW

        //从指定菜单中删除项。 如果菜单项打开菜单或子菜单，则此函数将销毁菜单或子菜单的句柄，并释放菜单或子菜单使用的内存。
        //DeleteMenu

        //取消注册已注册以接收 Shell 挂钩消息的指定 Shell 窗口。
        //DeregisterShellHookWindow

        //销毁加速器表。
        //DestroyAcceleratorTable

        //销毁插入符号的当前形状，从窗口中释放插入符号，并从屏幕中删除插入符号。
        //DestroyCaret

        //销毁游标并释放光标占用的任何内存。 请勿使用此函数销毁共享游标。
        //DestroyCursor

        //销毁图标并释放图标占用的任何内存。
        //DestroyIcon

        //销毁指定的菜单并释放菜单占用的任何内存。
        //DestroyMenu

        //销毁指定的指针注入设备。
        //DestroySyntheticPointerDevice

        //销毁指定的窗口。
        //DestroyWindow

        //从对话框模板资源创建模式对话框。 在指定的回调函数通过调用 EndDialog 函数终止模式对话框之前，DialogBox 不会返回控件。 (ANSI)
        //DialogBoxA

        //从内存中的对话框模板创建模式对话框。 在指定的回调函数通过调用 EndDialog 函数终止模式对话框之前，DialogBoxIndirect 不会返回控件。 (ANSI)
        //DialogBoxIndirectA

        //从内存中的对话框模板创建模式对话框。 (ANSI)
        //DialogBoxIndirectParamA

        //从内存中的对话框模板创建模式对话框。 (Unicode)
        //DialogBoxIndirectParamW

        //从内存中的对话框模板创建模式对话框。 在指定的回调函数通过调用 EndDialog 函数终止模式对话框之前，DialogBoxIndirect 不会返回控件。 (Unicode)
        //DialogBoxIndirectW

        //从对话框模板资源创建模式对话框。 (ANSI)
        //DialogBoxParamA

        //从对话框模板资源创建模式对话框。 (Unicode)
        //DialogBoxParamW

        //DisableProcessWindowsGhosting
        //从对话框模板资源创建模式对话框。 在指定的回调函数通过调用 EndDialog 函数终止模式对话框之前，DialogBox 不会返回控件。 (Unicode)

        //禁用调用 GUI 进程的窗口虚影功能。 窗口虚影是一项 Windows 管理器功能，允许用户最小化、移动或关闭未响应的应用程序的主窗口。
        //DialogBoxW

        //将消息调度到窗口过程。 它通常用于调度 GetMessage 函数检索的消息。 (DispatchMessageW)
        //DispatchMessage

        //将消息调度到窗口过程。 它通常用于调度 GetMessage 函数检索的消息。 (DispatchMessageA)
        //DispatchMessageA

        //将消息调度到窗口过程。 它通常用于调度 GetMessage 函数检索的消息。 (DispatchMessageW)
        //DispatchMessageW

        //DisplayConfigGetDeviceInfo 函数检索有关设备的显示配置信息。
        //DisplayConfigGetDeviceInfo

        //DisplayConfigSetDeviceInfo 函数设置目标的属性。
        //DisplayConfigSetDeviceInfo

        //将列表框的内容替换为指定目录中的子目录和文件的名称。 可以通过指定一组文件属性来筛选名称列表。 列表可以选择包含映射的驱动器。 (ANSI)
        //DlgDirListA

        //将组合框的内容替换为指定目录中的子目录和文件的名称。 可以通过指定一组文件属性来筛选名称列表。 名称列表可以包括映射的驱动器号。 (ANSI)
        //DlgDirListComboBoxA

        //将组合框的内容替换为指定目录中的子目录和文件的名称。 可以通过指定一组文件属性来筛选名称列表。 名称列表可以包括映射的驱动器号。 (Unicode)
        //DlgDirListComboBoxW

        //将列表框的内容替换为指定目录中的子目录和文件的名称。 可以通过指定一组文件属性来筛选名称列表。 列表可以选择包含映射的驱动器。 (Unicode)
        //DlgDirListW

        //使用 DlgDirListComboBox 函数从填充的组合框中检索当前所选内容。 所选内容解释为驱动器号、文件或目录名称。 (ANSI)
        //DlgDirSelectComboBoxExA

        //使用 DlgDirListComboBox 函数从填充的组合框中检索当前所选内容。 所选内容解释为驱动器号、文件或目录名称。 (Unicode)
        //DlgDirSelectComboBoxExW

        //从单选列表框中检索当前选定内容。 它假定列表框已由 DlgDirList 函数填充，并且所选内容是驱动器号、文件名或目录名称。 (ANSI)
        //DlgDirSelectExA

        //从单选列表框中检索当前选定内容。 它假定列表框已由 DlgDirList 函数填充，并且所选内容是驱动器号、文件名或目录名称。 (Unicode)
        //DlgDirSelectExW

        //捕获鼠标并跟踪其移动，直到用户释放左键、按 ESC 键或将鼠标移动到围绕指定点的拖动矩形外部。
        //DragDetect

        //对窗口的标题进行动画处理，以指示图标的打开或窗口最小化或最大化。
        //DrawAnimatedRects

        //DrawCaption 函数绘制窗口标题。
        //DrawCaption

        //DrawEdge 函数绘制矩形的一个或多个边缘。
        //DrawEdge

        //DrawFocusRect 函数在样式中绘制一个矩形，该矩形指示该矩形具有焦点。
        //DrawFocusRect

        //DrawFrameControl 函数绘制指定类型和样式的帧控件。
        //DrawFrameControl

        //将图标或光标绘制到指定的设备上下文中。
        //DrawIcon

        //将图标或光标绘制到指定的设备上下文中，执行指定的光栅操作，并按指定拉伸或压缩图标或光标。
        //DrawIconEx

        //重绘指定窗口的菜单栏。 如果在系统创建窗口后菜单栏发生更改，则必须调用此函数来绘制更改的菜单栏。
        //DrawMenuBar

        //DrawState 函数显示图像，并应用视觉效果来指示状态，例如已禁用或默认状态。 (ANSI)
        //DrawStateA

        //DrawState 函数显示图像，并应用视觉效果来指示状态，例如已禁用或默认状态。 (Unicode)
        //DrawStateW

        //DrawText 函数在指定的矩形中绘制带格式的文本。 它根据指定的方法设置文本格式， (展开制表符、对齐字符、断行等) 。 (DrawTextW)
        //DrawText

        //DrawText 函数绘制指定矩形中的格式化文本。 它根据指定的方法设置文本格式， (展开制表符、对齐字符、断行等) 。 (DrawTextA)
        //DrawTextA

        //DrawTextEx 函数绘制指定矩形中的格式化文本。 (ANSI)
        //DrawTextExA

        //DrawTextEx 函数绘制指定矩形中的格式化文本。 (Unicode)
        //DrawTextExW

        //DrawText 函数绘制指定矩形中的格式化文本。 它根据指定的方法设置文本格式， (展开制表符、对齐字符、断行等) 。 (DrawTextW)
        //DrawTextW

        //清空剪贴板并释放剪贴板中的数据句柄。 然后，该函数将剪贴板的所有权分配给当前打开剪贴板的窗口。
        //EmptyClipboard

        //启用、禁用或灰显指定的菜单项。
        //EnableMenuItem

        //使鼠标能够充当指针输入设备并发送WM_POINTER消息。
        //EnableMouseInPointer

        //在高 DPI 显示器中，启用指定顶级窗口的非工作区部分的自动显示缩放。 必须在初始化该窗口期间调用。
        //EnableNonClientDpiScaling

        //EnableScrollBar 函数启用或禁用一个或两个滚动条箭头。
        //EnableScrollBar

        //启用或禁用指定窗口或控件的鼠标和键盘输入。 禁用输入后，窗口不会接收鼠标单击和按下键等输入。 启用输入后，窗口将接收所有输入。
        //EnableWindow

        //同时更新单个屏幕刷新周期中一个或多个窗口的位置和大小。
        //EndDeferWindowPos

        //销毁模式对话框，导致系统结束对对话框的任何处理。
        //EndDialog

        //结束调用线程的活动菜单。
        //EndMenu

        //EndPaint 函数标记指定窗口中的绘制结束。 每次调用 BeginPaint 函数时，都需要此函数，但仅在绘制完成后才能完成。
        //EndPaint

        //强行关闭指定的窗口。
        //EndTask

        //通过将句柄传递给应用程序定义的回调函数，枚举属于指定父窗口的子窗口。
        //EnumChildWindows

        //枚举剪贴板上当前可用的数据格式。
        //EnumClipboardFormats

        //枚举与调用进程的指定窗口工作站关联的所有桌面。 该函数又将每个桌面的名称传递给应用程序定义的回调函数。 (ANSI)
        //EnumDesktopsA

        //枚举与调用进程的指定窗口工作站关联的所有桌面。 该函数又将每个桌面的名称传递给应用程序定义的回调函数。 (Unicode)
        //EnumDesktopsW

        //枚举与指定桌面关联的所有顶级窗口。 它将句柄传递给每个窗口，进而传递给应用程序定义的回调函数。
        //EnumDesktopWindows

        //EnumDisplayDevices 函数允许你获取有关当前会话中显示设备的信息。 (ANSI)
        //EnumDisplayDevicesA

        //EnumDisplayDevices 函数允许你获取有关当前会话中显示设备的信息。 (Unicode)
        //EnumDisplayDevicesW

        //EnumDisplayMonitors 函数枚举显示监视器 (包括与镜像驱动程序关联的不可见伪监视器) ，这些监视器与指定剪辑矩形的交集和设备上下文的可见区域相交的区域相交。 EnumDisplayMonitors 对枚举的每个监视器调用应用程序定义的 MonitorEnumProc 回调函数一次。 请注意，GetSystemMetrics (SM_CMONITORS) 仅计算显示监视器。
        //EnumDisplayMonitors

        //EnumDisplaySettings 函数检索有关显示设备的图形模式之一的信息。 若要检索显示设备的所有图形模式的信息，请对此函数进行一系列调用。 (ANSI)
        //EnumDisplaySettingsA

        //EnumDisplaySettingsEx 函数检索有关显示设备的图形模式之一的信息。 若要检索显示设备的所有图形模式的信息，请对此函数进行一系列调用。 (ANSI)
        //EnumDisplaySettingsExA

        //EnumDisplaySettingsEx 函数检索有关显示设备的图形模式之一的信息。 若要检索显示设备的所有图形模式的信息，请对此函数进行一系列调用。 (Unicode)
        //EnumDisplaySettingsExW

        //EnumDisplaySettings 函数检索有关显示设备的图形模式之一的信息。 若要检索显示设备的所有图形模式的信息，请对此函数进行一系列调用。 (Unicode)
        //EnumDisplaySettingsW

        //通过将窗口的属性列表中的所有条目（一个一个）传递给指定的回调函数来枚举这些条目。 枚举Props 会继续，直到枚举最后一个条目或回调函数返回 FALSE。 (ANSI)
        //EnumPropsA

        //通过将窗口的属性列表中的所有条目（一个一个）传递给指定的回调函数来枚举这些条目。 枚举PropsEx 将继续，直到枚举最后一个条目或回调函数返回 FALSE。 (ANSI)
        //EnumPropsExA

        //通过将窗口的属性列表中的所有条目（一个一个）传递给指定的回调函数来枚举这些条目。 枚举PropsEx 将继续，直到枚举最后一个条目或回调函数返回 FALSE。 (Unicode)
        //EnumPropsExW

        //通过将窗口的属性列表中的所有条目（一个一个）传递给指定的回调函数来枚举这些条目。 枚举Props 会继续，直到枚举最后一个条目或回调函数返回 FALSE。 (Unicode)
        //EnumPropsW

        //通过将句柄传递给应用程序定义的回调函数，枚举与线程关联的所有非子窗口。
        //EnumThreadWindows

        //通过将句柄传递到应用程序定义的回调函数，枚举屏幕上的所有顶级窗口。 枚举枚举到最后一个顶级窗口或回调函数返回 FALSE 为止。
        //EnumWindows

        //枚举当前会话中的所有窗口工作站。 该函数又将每个窗口站的名称传递给应用程序定义的回调函数。 (ANSI)
        //EnumWindowStationsA

        //枚举当前会话中的所有窗口工作站。 该函数又将每个窗口站的名称传递给应用程序定义的回调函数。 (Unicode)
        //EnumWindowStationsW

        //EqualRect 函数通过比较其左上角和右下角的坐标来确定两个指定的矩形是否相等。
        //EqualRect

        //将多边形的分数作为可能的触摸目标 (与与触摸接触区相交的所有其他多边形) 和多边形中调整的触摸点进行比较。
        //EvaluateProximityToPolygon

        //返回矩形的分数作为可能的触摸目标，与与触摸接触区域相交的所有其他矩形以及矩形内调整的触摸点进行比较。
        //EvaluateProximityToRect

        //ExcludeUpdateRgn 函数通过从剪辑区域中排除窗口中更新的区域，防止在窗口的无效区域中绘制。
        //ExcludeUpdateRgn

        //调用 ExitWindowsEx 函数以注销交互式用户。
        //ExitWindows

        //注销交互式用户、关闭系统或关闭并重启系统。
        //ExitWindowsEx

        //FillRect 函数使用指定的画笔填充矩形。 此函数包括左边框和上边框，但排除矩形的右边框和下边框。
        //FillRect

        //检索顶级窗口的句柄，该窗口的类名称和窗口名称与指定的字符串匹配。 此函数不搜索子窗口。 此函数不执行区分大小写的搜索。 (ANSI)
        //FindWindowA

        //检索一个窗口的句柄，该窗口的类名和窗口名称与指定的字符串匹配。 该函数搜索子窗口，从指定子窗口后面的子窗口开始。 此函数不执行区分大小写的搜索。 (ANSI)
        //FindWindowExA

        //检索一个窗口的句柄，该窗口的类名和窗口名称与指定的字符串匹配。 该函数搜索子窗口，从指定子窗口后面的子窗口开始。 此函数不执行区分大小写的搜索。 (Unicode)
        //FindWindowExW

        //检索顶级窗口的句柄，该窗口的类名称和窗口名称与指定的字符串匹配。 此函数不搜索子窗口。 此函数不执行区分大小写的搜索。 (Unicode)
        //FindWindowW

        //一次闪烁指定的窗口。 它不会更改窗口的活动状态。
        //FlashWindow

        //闪烁指定的窗口。 它不会更改窗口的活动状态。
        //FlashWindowEx

        //FrameRect 函数使用指定的画笔在指定矩形周围绘制边框。 边框的宽度和高度始终是一个逻辑单元。
        //FrameRect

        //从指定的 LPARAM 值检索应用程序命令。
        //GET_APPCOMMAND_LPARAM

        //从指定的 LPARAM 值检索输入设备类型。
        //GET_DEVICE_LPARAM

        //从指定的 LPARAM 值检索特定虚拟密钥的状态。 (GET_FLAGS_LPARAM)
        //GET_FLAGS_LPARAM

        //从指定的 LPARAM 值检索特定虚拟密钥的状态。 (GET_KEYSTATE_LPARAM)
        //GET_KEYSTATE_LPARAM

        //从指定的 WPARAM 值检索特定虚拟密钥的状态。
        //GET_KEYSTATE_WPARAM

        //从指定的 WPARAM 值检索命中测试值。
        //GET_NCHITTEST_WPARAM

        //使用指定的值检索指针 ID。
        //GET_POINTERID_WPARAM

        //从 WM_INPUT 中的 wParam 检索输入代码。
        //GET_RAWINPUT_CODE_WPARAM

        //从指定的 WPARAM 值检索滚轮增量值。
        //GET_WHEEL_DELTA_WPARAM

        //从指定的 WPARAM 值检索某些按钮的状态。
        //GET_XBUTTON_WPARAM

        //检索附加到调用线程消息队列的活动窗口的窗口句柄。
        //GetActiveWindow

        //如果指定窗口是应用程序切换 (ALT+TAB) 窗口，则检索指定窗口的状态信息。 (ANSI)
        //GetAltTabInfoA

        //如果指定窗口是应用程序切换 (ALT+TAB) 窗口，则检索指定窗口的状态信息。 (Unicode)
        //GetAltTabInfoW

        //检索指定窗口的上级句柄。
        //GetAncestor

        //确定调用函数时键是向上还是向下键，以及之前调用 GetAsyncKeyState 后是否按下了键。
        //GetAsyncKeyState

        //检索一个AR_STATE值，该值包含系统的屏幕自动旋转状态，例如是否支持自动轮换，以及是否由用户启用。
        //GetAutoRotationState

        //从DPI_AWARENESS_CONTEXT检索DPI_AWARENESS值。
        //GetAwarenessFromDpiAwarenessContext

        //如果捕获了鼠标的任何) ，则检索窗口 (句柄。 一次只能捕获一个窗口;此窗口接收鼠标输入，无论光标是否在其边框内。
        //GetCapture

        //检索反转插入点像素所需的时间。 用户可以设置此值。
        //GetCaretBlinkTime

        //将插入点的位置复制到指定的 POINT 结构。
        //GetCaretPos

        //(GetCurrentInputMessageSourceInSendMessage) 检索输入消息的源。
        //GetCIMSSM

        //检索有关窗口类的信息。 (ANSI)
        //GetClassInfoA

        //检索有关窗口类的信息，包括与窗口类关联的小图标的句柄。 GetClassInfo 函数不会检索小图标的句柄。 (ANSI)
        //GetClassInfoExA

        //检索有关窗口类的信息，包括与窗口类关联的小图标的句柄。 GetClassInfo 函数不会检索小图标的句柄。 (Unicode)
        //GetClassInfoExW

        //检索有关窗口类的信息。 (Unicode)
        //GetClassInfoW

        //从与指定窗口关联的 WNDCLASSEX 结构中检索指定的 32 位 (DWORD) 值。 (ANSI)
        //GetClassLongA

        //从与指定窗口关联的 WNDCLASSEX 结构检索指定的值。 (ANSI)
        //GetClassLongPtrA

        //从与指定窗口关联的 WNDCLASSEX 结构检索指定的值。 (Unicode)
        //GetClassLongPtrW

        //从与指定窗口关联的 WNDCLASSEX 结构中检索指定的 32 位 (DWORD) 值。 (Unicode)
        //GetClassLongW

        //检索指定窗口所属的类的名称。 (GetClassNameW)
        //GetClassName

        //检索指定窗口所属的类的名称。 (GetClassNameA)
        //GetClassNameA

        //检索指定窗口所属的类的名称。 (GetClassNameW)
        //GetClassNameW

        //将 16 位 (WORD) 值检索到指定窗口所属窗口类的额外类内存中。
        //GetClassWord

        //检索窗口工作区的坐标。
        //GetClientRect

        //以指定格式从剪贴板检索数据。 剪贴板之前必须已打开。
        //GetClipboardData

        //从剪贴板中检索指定注册格式的名称。 该函数将名称复制到指定的缓冲区。 (ANSI)
        //GetClipboardFormatNameA

        //从剪贴板中检索指定注册格式的名称。 该函数将名称复制到指定的缓冲区。 (Unicode)
        //GetClipboardFormatNameW

        //检索剪贴板的当前所有者的窗口句柄。
        //GetClipboardOwner

        //检索当前窗口工作站的剪贴板序列号。
        //GetClipboardSequenceNumber

        //检索剪贴板查看器链中第一个窗口的句柄。
        //GetClipboardViewer

        //检索光标被限制到的矩形区域的屏幕坐标。
        //GetClipCursor

        //检索有关指定组合框的信息。
        //GetComboBoxInfo

        //检索输入消息的源。
        //GetCurrentInputMessageSource

        //检索当前游标的句柄。
        //GetCursor

        //检索有关全局游标的信息。
        //GetCursorInfo

        //检索鼠标光标在屏幕坐标中的位置。
        //GetCursorPos

        //GetDC 函数检索设备上下文的句柄， (DC) 指定窗口的工作区或整个屏幕。
        //GetDC

        //GetDCEx 函数检索指定窗口或整个屏幕的工作区 (DC) 设备上下文的句柄。
        //GetDCEx

        //检索桌面窗口的句柄。 桌面窗口覆盖整个屏幕。 桌面窗口是其他窗口绘制的区域。
        //GetDesktopWindow

        //检索系统的对话框基单位，这些单位是系统字体中字符的平均宽度和高度。
        //GetDialogBaseUnits

        //检索对话中子窗口的按监视器 DPI 缩放行为替代。
        //GetDialogControlDpiChangeBehavior

        //通过对 SetDialogDpiChangeBehavior 的早期调用，返回可能在给定对话框中设置的标志。
        //GetDialogDpiChangeBehavior

        //检索当前进程的屏幕自动旋转首选项。
        //GetDisplayAutoRotationPreferences

        //检索 dwProcessId 参数指示的进程的屏幕自动旋转首选项。
        //GetDisplayAutoRotationPreferencesByProcessId

        //GetDisplayConfigBufferSizes 函数检索调用 QueryDisplayConfig 函数所需的缓冲区的大小。
        //GetDisplayConfigBufferSizes

        //检索指定控件的标识符。
        //GetDlgCtrlID

        //检索指定对话框中控件的句柄。
        //GetDlgItem

        //将对话框中指定控件的文本转换为整数值。
        //GetDlgItemInt

        //检索与对话框中的控件关联的标题或文本。 (ANSI)
        //GetDlgItemTextA

        //检索与对话框中的控件关联的标题或文本。 (Unicode)
        //GetDlgItemTextW

        //检索鼠标的当前双击时间。
        //GetDoubleClickTime

        //返回系统 DPI。
        //GetDpiForSystem

        //返回指定窗口的每英寸点 (dpi) 值。
        //GetDpiForWindow

        //从给定DPI_AWARENESS_CONTEXT句柄检索 DPI。 这样，便可以确定线程的 DPI，而无需检查在该线程中创建的窗口。
        //GetDpiFromDpiAwarenessContext

        //如果窗口附加到调用线程的消息队列，则检索具有键盘焦点的窗口的句柄。
        //GetFocus

        //检索前台窗口的句柄， (用户当前正在使用的窗口) 。 系统向创建前台窗口的线程分配略高于其他线程的优先级。
        //GetForegroundWindow

        //检索从窗口发送 Windows Touch 手势消息的配置。
        //GetGestureConfig

        //从其 GESTUREINFO 句柄中检索有关手势的其他信息。
        //GetGestureExtraArgs

        //检索一个 GESTUREINFO 结构，给定手势信息的句柄。
        //GetGestureInfo

        //检索图形用户界面的句柄计数， (GUI) 指定进程使用的对象。
        //GetGuiResources

        //检索有关活动窗口或指定 GUI 线程的信息。
        //GetGUIThreadInfo

        //检索有关指定图标或游标的信息。
        //GetIconInfo

        //检索有关指定图标或游标的信息。 GetIconInfoEx 使用较新的 ICONINFOEX 结构扩展 GetIconInfo。 (ANSI)
        //GetIconInfoExA

        //检索有关指定图标或游标的信息。 GetIconInfoEx 使用较新的 ICONINFOEX 结构扩展 GetIconInfo。 (Unicode)
        //GetIconInfoExW

        //确定调用线程的消息队列中是否存在鼠标按钮或键盘消息。
        //GetInputState

        //检索当前代码页。
        //GetKBCodePage

        //检索以前称为键盘布局) 的活动输入区域设置标识符 (。
        //GetKeyboardLayout

        //检索以前称为键盘布局 (输入区域设置标识符) 对应于系统中当前输入区域设置集的输入区域设置。 该函数将标识符复制到指定的缓冲区。
        //GetKeyboardLayoutList

        //检索活动输入区域设置标识符的名称， (以前称为系统的键盘布局) 。 (ANSI)
        //GetKeyboardLayoutNameA

        //检索活动输入区域设置标识符的名称， (以前称为系统的键盘布局) 。 (Unicode)
        //GetKeyboardLayoutNameW

        //将 256 个虚拟密钥的状态复制到指定的缓冲区。
        //GetKeyboardState

        //检索有关当前键盘的信息。
        //GetKeyboardType

        //检索表示密钥名称的字符串。 (ANSI)
        //GetKeyNameTextA

        //检索表示密钥名称的字符串。 (Unicode)
        //GetKeyNameTextW

        //检索指定虚拟密钥的状态。 状态指定每次) 按下键时，键是向上、关闭还是切换 (，每次按下键时都会交替切换。
        //GetKeyState

        //确定指定窗口拥有的弹出窗口最近处于活动状态。
        //GetLastActivePopup

        //检索最后一个输入事件的时间。
        //GetLastInputInfo

        //检索分层窗口的不透明度和透明度颜色键。
        //GetLayeredWindowAttributes

        //检索指定列表框中每列的项目数。
        //GetListBoxInfo

        //检索分配给指定窗口的菜单的句柄。
        //getMenu

        //检索有关指定的菜单栏的信息。
        //GetMenuBarInfo

        //检索默认复选标记位图的维度。
        //GetMenuCheckMarkDimensions

        //检索与指定菜单关联的帮助上下文标识符。
        //GetMenuContextHelpId

        //确定指定菜单上的默认菜单项。
        //GetMenuDefaultItem

        //检索有关指定菜单的信息。
        //GetMenuInfo

        //确定指定菜单中的项数。
        //GetMenuItemCount

        //检索位于菜单中指定位置的菜单项的菜单项标识符。
        //GetMenuItemID

        //检索有关菜单项的信息。 (ANSI)
        //GetMenuItemInfoA

        //检索有关菜单项的信息。 (Unicode)
        //GetMenuItemInfoW

        //检索指定菜单项的边界矩形。
        //GetMenuItemRect

        //检索与指定菜单项关联的菜单标志。
        //GetMenuState

        //将指定菜单项的文本字符串复制到指定的缓冲区中。 (ANSI)
        //GetMenuStringA

        //将指定菜单项的文本字符串复制到指定的缓冲区中。 (Unicode)
        //GetMenuStringW

        //从调用线程的消息队列中检索消息。 该函数将调度传入的已发送邮件，直到发布的消息可供检索。 (GetMessageW)
        //GetMessage

        //从调用线程的消息队列中检索消息。 该函数将调度传入的已发送邮件，直到发布的消息可供检索。 (GetMessageA)
        //GetMessageA

        //检索当前线程的额外消息信息。 额外消息信息是与当前线程的消息队列关联的应用程序或驱动程序定义值。
        //GetMessageExtraInfo

        //检索 GetMessage 函数检索的最后一条消息的游标位置。
        //GetMessagePos

        //检索 GetMessage 函数检索最后一条消息的消息时间。
        //GetMessageTime

        //从调用线程的消息队列中检索消息。 该函数将调度传入的已发送邮件，直到发布的消息可供检索。 (GetMessageW)
        //GetMessageW

        //GetMonitorInfo 函数检索有关显示监视器的信息。 (ANSI)
        //GetMonitorInfoA

        //GetMonitorInfo 函数检索有关显示监视器的信息。 (Unicode)
        //GetMonitorInfoW

        //检索鼠标或笔前 64 个坐标的历史记录。
        //GetMouseMovePointsEx

        //检索位于 (之前的控件组中第一个控件的句柄，或) 对话框中的指定控件。
        //GetNextDlgGroupItem

        //检索第一个控件的句柄，该控件具有前面 (或) 指定控件之前的WS_TABSTOP样式。
        //GetNextDlgTabItem

        //检索 Z 顺序中下一个或上一个窗口的句柄。 下一个窗口位于指定窗口下方;上一个窗口位于上面。
        //GetNextWindow

        //检索当前打开剪贴板的窗口的句柄。
        //GetOpenClipboardWindow

        //检索指定窗口的父或所有者的句柄。
        //GetParent

        //检索光标在物理坐标中的位置。
        //GetPhysicalCursorPos

        //检索与指定指针关联的游标标识符。
        //GetPointerCursorId

        //获取有关指针设备的信息。
        //GetPointerDevice

        //获取映射到与指针设备关联的游标的游标 ID。
        //GetPointerDeviceCursors

        //获取POINTER_DEVICE_INFO结构中不包含的设备属性。
        //GetPointerDeviceProperties

        //获取) 中指针设备的 x 和 y 范围 (， (当前分辨率) 指针设备映射到的显示器的 x 和 y 范围。
        //GetPointerDeviceRects

        //获取有关附加到系统的指针设备的信息。
        //GetPointerDevices

        //获取与当前消息关联的指定指针的整个信息帧。
        //GetPointerFrameInfo

        //获取整个信息帧 (，包括与当前消息关联的指定指针的合并输入帧) 。
        //GetPointerFrameInfoHistory

        //获取与当前消息关联的类型PT_PEN) 的指定指针 (的基于笔的信息的整个帧。
        //GetPointerFramePenInfo

        //获取基于笔的信息的完整帧， (包括与当前消息关联的指定指针的合并输入帧) (类型PT_PEN) 。
        //GetPointerFramePenInfoHistory

        //获取与当前消息关联的类型PT_TOUCH) 的指定指针 (的基于触摸的信息的整个帧。
        //GetPointerFrameTouchInfo

        //获取 (基于触摸的信息的整个帧，包括与当前消息关联的指定指针的合并输入帧) PT_TOUCH) (。
        //GetPointerFrameTouchInfoHistory

        //获取与当前消息关联的指定指针的信息。
        //GetPointerInfo

        //获取与单个输入关联的信息（如果有）合并到指定指针的当前消息中。
        //GetPointerInfoHistory

        //获取与当前消息关联的指针信息坐标的一个或多个转换。
        //GetPointerInputTransform

        //获取与当前消息关联的类型PT_PEN) 的指定指针 (的基于笔的信息。
        //GetPointerPenInfo

        //获取与单个输入（如果有）关联的基于笔的信息，这些信息已合并到指定指针 (类型PT_PEN) 的当前消息中。
        //GetPointerPenInfoHistory

        //获取与当前消息关联的类型PT_TOUCH) 的指定指针 (的基于触摸的信息。
        //GetPointerTouchInfo

        //获取与单个输入（如果有）关联的基于触摸的信息，这些信息已合并到指定指针的当前消息中，PT_TOUCH) 类型 (。
        //GetPointerTouchInfoHistory

        //检索指定指针的指针类型。
        //GetPointerType

        //检索指定列表中的第一个可用剪贴板格式。
        //GetPriorityClipboardFormat

        //检索在没有父级或所有者的情况下创建窗口时使用的默认布局。
        //GetProcessDefaultLayout

        //检索调用进程的当前窗口工作站的句柄。
        //GetProcessWindowStation

        //从指定窗口的属性列表中检索数据句柄。 字符串标识要检索的句柄。 必须通过对 SetProp 函数的上一次调用将字符串和句柄添加到属性列表中。 (ANSI)
        //GetPropA

        //从指定窗口的属性列表中检索数据句柄。 字符串标识要检索的句柄。 必须通过对 SetProp 函数的上一次调用将字符串和句柄添加到属性列表中。 (Unicode)
        //GetPropW

        //检索在调用线程的消息队列中找到的消息类型。
        //GetQueueStatus

        //执行原始输入数据的缓冲读取。
        //GetRawInputBuffer

        //从指定设备检索原始输入。
        //GetRawInputData

        //检索有关原始输入设备的信息。 (ANSI)
        //GetRawInputDeviceInfoA

        //检索有关原始输入设备的信息。 (Unicode)
        //GetRawInputDeviceInfoW

        //枚举附加到系统的原始输入设备。
        //GetRawInputDeviceList

        //从指针设备获取原始输入数据。
        //GetRawPointerDeviceData

        //检索有关当前应用程序的原始输入设备的信息。
        //GetRegisteredRawInputDevices

        //GetScrollBarInfo 函数检索有关指定滚动条的信息。
        //GetScrollBarInfo

        //GetScrollInfo 函数检索滚动条的参数，包括最小和最大滚动位置、页面大小以及滚动框的位置 (拇指) 。
        //GetScrollInfo

        //GetScrollPos 函数检索指定滚动条中滚动框的当前位置 (拇指) 。
        //GetScrollPos

        //GetScrollRange 函数检索指定的滚动条的当前最小和最大滚动框 (拇指) 位置。
        //GetScrollRange

        //检索 Shell 桌面窗口的句柄。
        //GetShellWindow

        //检索由指定菜单项激活的下拉菜单或子菜单的句柄。
        //GetSubMenu

        //检索指定显示元素的当前颜色。
        //GetSysColor

        //GetSysColorBrush 函数检索标识与指定颜色索引对应的逻辑画笔的句柄。
        //GetSysColorBrush

        //检索与给定进程关联的系统 DPI。 这可用于避免在具有不同系统 DPI 值的多个系统感知进程之间共享 DPI 敏感信息时出现的兼容性问题。
        //GetSystemDpiForProcess

        //使应用程序能够访问窗口菜单 (也称为系统菜单或控件菜单) 进行复制和修改。
        //GetSystemMenu

        //检索指定的系统指标或系统配置设置。
        //GetSystemMetrics

        //检索考虑到提供的 DPI 的指定系统指标或系统配置设置。
        //GetSystemMetricsForDpi

        //GetTabbedTextExtent 函数计算字符串的宽度和高度。 (ANSI)
        //GetTabbedTextExtentA

        //GetTabbedTextExtent 函数计算字符串的宽度和高度。 (Unicode)
        //GetTabbedTextExtentW

        //检索分配给指定线程的桌面的句柄。
        //GetThreadDesktop

        //获取当前线程的DPI_AWARENESS_CONTEXT。
        //GetThreadDpiAwarenessContext

        //从当前线程检索DPI_HOSTING_BEHAVIOR。
        //GetThreadDpiHostingBehavior

        //检索有关指定标题栏的信息。
        //GetTitleBarInfo

        //检查与指定父窗口关联的子窗口的 Z 顺序，并检索 Z 顺序顶部子窗口的句柄。
        //GetTopWindow

        //检索与特定触摸输入句柄关联的触摸输入的详细信息。
        //GetTouchInputInfo

        //获取指针数据，然后再完成触摸预测处理。
        //GetUnpredictedMessagePos

        //检索当前支持的剪贴板格式。
        //GetUpdatedClipboardFormats

        //GetUpdateRect 函数检索最小矩形的坐标，该矩形完全封闭指定窗口的更新区域。
        //GetUpdateRect

        //GetUpdateRgn 函数通过将窗口的更新区域复制到指定区域来检索窗口的更新区域。 更新区域的坐标相对于窗口左上角 (，即客户端坐标) 。
        //GetUpdateRgn

        //检索有关指定窗口工作站或桌面对象的信息。 (ANSI)
        //GetUserObjectInformationA

        //检索有关指定窗口工作站或桌面对象的信息。 (Unicode)
        //GetUserObjectInformationW

        //检索指定用户对象的安全信息。
        //GetUserObjectSecurity

        //检索具有指定关系 (Z-Order 或所有者) 到指定窗口的窗口的句柄。
        //GetWindow

        //检索与指定窗口关联的帮助上下文标识符（如果有）。
        //GetWindowContextHelpId

        //GetWindowDC 函数检索整个窗口的设备上下文 (DC) ，包括标题栏、菜单和滚动条。
        //GetWindowDC

        //从给定窗口的任何进程检索当前显示相关性设置。
        //GetWindowDisplayAffinity

        //返回与窗口关联的DPI_AWARENESS_CONTEXT。
        //GetWindowDpiAwarenessContext

        //返回指定窗口的DPI_HOSTING_BEHAVIOR。
        //GetWindowDpiHostingBehavior

        //检索窗口的反馈配置。
        //GetWindowFeedbackSetting

        //检索有关指定窗口的信息。 (GetWindowInfo)
        //GetWindowInfo

        //检索有关指定窗口的信息。 (GetWindowLongA)
        //GetWindowLongA

        //检索有关指定窗口的信息。 该函数还会在额外的窗口内存中检索指定偏移量处的值。 (ANSI)
        //GetWindowLongPtrA

        //检索有关指定窗口的信息。 该函数还会在额外的窗口内存中检索指定偏移量处的值。 (Unicode)
        //GetWindowLongPtrW

        //检索有关指定窗口的信息。 (GetWindowLongW)
        //GetWindowLongW

        //检索与指定窗口句柄关联的模块的完整路径和文件名。 (ANSI)
        //GetWindowModuleFileNameA

        //检索与指定窗口句柄关联的模块的完整路径和文件名。 (Unicode)
        //GetWindowModuleFileNameW

        //检索显示状态和已还原、最小化和最大化指定窗口的位置。
        //GetWindowPlacement

        //检索指定窗口的边界矩形的维度。 维度以相对于屏幕左上角的屏幕坐标提供。
        //GetWindowRect

        //GetWindowRgn 函数获取窗口区域的窗口区域的副本。
        //GetWindowRgn

        //GetWindowRgnBox 函数检索窗口区域最紧密边界矩形的维度。
        //GetWindowRgnBox

        //如果指定窗口的标题栏有一个) ，则将其文本复制到缓冲区中 (。 如果指定的窗口是控件，则会复制控件的文本。 但是，GetWindowText 无法检索另一个应用程序中控件的文本。 (ANSI)
        //GetWindowTextA

        //如果窗口具有标题栏 () ，则检索指定窗口的标题栏文本的长度（以字符为单位）。 (ANSI)
        //GetWindowTextLengthA

        //如果窗口具有标题栏 () ，则检索指定窗口的标题栏文本的长度（以字符为单位）。 (Unicode)
        //GetWindowTextLengthW

        //如果指定窗口的标题栏有一个) ，则将其文本复制到缓冲区中 (。 如果指定的窗口是控件，则会复制控件的文本。 但是，GetWindowText 无法检索另一个应用程序中控件的文本。 (Unicode)
        //GetWindowTextW

        //检索创建指定窗口的线程的标识符，以及创建窗口的进程标识符（可选）。
        //GetWindowThreadProcessId

        //GID_ROTATE_ANGLE_FROM_ARGUMENT宏用于在接收WM_GESTURE结构中的值时解释 GID_ROTATE ullArgument 值。
        //GID_ROTATE_ANGLE_FROM_ARGUMENT

        //将弧度值转换为旋转手势消息的参数。
        //GID_ROTATE_ANGLE_TO_ARGUMENT

        //GrayString 函数在指定位置绘制灰色文本。 (ANSI)
        //GrayStringA

        //GrayString 函数在指定位置绘制灰色文本。 (Unicode)
        //GrayStringW

        //检查指定的指针消息是否被视为有意而不是意外。
        //HAS_POINTER_CONFIDENCE_WPARAM

        //从屏幕中删除插入符号。 隐藏插入符号不会销毁其当前形状或使插入点失效。
        //HideCaret

        //在菜单栏中的项中添加或删除突出显示。
        //HiliteMenuItem

        //InflateRect 函数增加或减小指定矩形的宽度和高度。
        //InflateRect

        //为呼叫应用程序配置触摸注入上下文，并初始化应用可以注入的最大同时联系人数。
        //InitializeTouchInjection

        //模拟指针输入 (笔或触摸) 。
        //InjectSyntheticPointerInput

        //模拟触摸输入。
        //InjectTouchInput

        //确定当前窗口过程是处理从同一进程中的另一个线程发送的消息 (，还是通过调用 SendMessage 函数) 从另一个线程发送的消息。
        //InSendMessage

        //确定当前窗口过程正在处理从同一进程中的另一个线程发送的消息 (还是另一个进程) 。
        //InSendMessageEx

        //将新菜单项插入菜单，将其他项向下移动。 (ANSI)
        //InsertMenuA

        //在菜单中的指定位置插入新菜单项。 (ANSI)
        //InsertMenuItemA

        //在菜单中的指定位置插入新菜单项。 (Unicode)
        //InsertMenuItemW

        //将新菜单项插入菜单，将其他项向下移动。 (Unicode)
        //InsertMenuW

        //如果指定窗口的标题栏有一个) ，则将其文本复制到缓冲区中 (。
        //InternalGetWindowText

        //IntersectRect 函数计算两个源矩形的交集，并将交集矩形的坐标置于目标矩形中。
        //IntersectRect

        //InvalidateRect 函数向指定窗口的更新区域添加一个矩形。 更新区域表示必须重新绘制的窗口工作区的一部分。
        //InvalidateRect

        //InvalidateRgn 函数通过将其添加到窗口的当前更新区域，使指定区域中的工作区失效。
        //InvalidateRgn

        //InvertRect 函数通过对矩形内部每个像素的颜色值执行逻辑 NOT 操作来反转窗口中的矩形。
        //InvertRect

        //确定值是否为资源的整数标识符。
        //IS_INTRESOURCE

        //检查指定的指针输入是突然结束还是无效，指示交互未完成。
        //IS_POINTER_CANCELED_WPARAM

        //检查指定的指针是否执行了第五个操作。
        //IS_POINTER_FIFTHBUTTON_WPARAM

        //检查指定的指针是否执行了第一个操作。
        //IS_POINTER_FIRSTBUTTON_WPARAM

        //检查指针宏是否设置指定的标志。
        //IS_POINTER_FLAG_SET_WPARAM

        //检查指定的指针是否执行了第四个操作。
        //IS_POINTER_FOURTHBUTTON_WPARAM

        //检查指定的指针是否处于联系中。
        //IS_POINTER_INCONTACT_WPARAM

        //检查指定的指针是否在范围内。
        //IS_POINTER_INRANGE_WPARAM

        //检查指定的指针是否为新指针。
        //IS_POINTER_NEW_WPARAM

        //检查指定的指针是否执行了第二个操作。
        //IS_POINTER_SECONDBUTTON_WPARAM

        //检查指定的指针是否执行了第三个操作。
        //IS_POINTER_THIRDBUTTON_WPARAM

        //确定字符是否为字母字符。 此决定基于用户在设置期间或通过控制面板选择的语言的语义。 (ANSI)
        //IsCharAlphaA

        //确定字符是字母还是数字字符。 此决定基于用户在设置期间或通过控制面板选择的语言的语义。 (ANSI)
        //IsCharAlphaNumericA

        //确定字符是字母还是数字字符。 此决定基于用户在设置期间或通过控制面板选择的语言的语义。 (Unicode)
        //IsCharAlphaNumericW

        //确定字符是否为字母字符。 此决定基于用户在设置期间或通过控制面板选择的语言的语义。 (Unicode)
        //IsCharAlphaW

        //确定字符是否为小写。 此决定基于用户在设置期间或通过控制面板选择的语言的语义。
        //IsCharLowerA

        //IsCharLowerW
        //

        //确定字符是否为大写。 此决定基于用户在设置期间或通过控制面板选择的语言的语义。 (ANSI)
        //IsCharUpperA

        //确定字符是否为大写。 此决定基于用户在设置期间或通过控制面板选择的语言的语义。 (Unicode)
        //IsCharUpperW

        //确定窗口是指定父窗口的子窗口还是子窗口。
        //IsChild

        //确定剪贴板是否包含指定格式的数据。
        //IsClipboardFormatAvailable

        //确定消息是否适用于指定的对话框，如果是，则处理该消息。 (ANSI)
        //IsDialogMessageA

        //确定消息是否适用于指定的对话框，如果是，则处理该消息。 (Unicode)
        //IsDialogMessageW

        //IsDlgButtonChecked 函数确定是检查按钮控件还是检查三态按钮控件、未选中还是不确定。
        //IsDlgButtonChecked

        //确定调用线程是否已经是 GUI 线程。 它还可以选择将线程转换为 GUI 线程。
        //IsGUIThread

        //确定系统是否认为指定的应用程序未响应。
        //IsHungAppWindow

        //确定指定的窗口是否最小化 (标志性的) 。
        //IsIconic

        //确定进程是否属于 Windows 应用商店应用。
        //IsImmersiveProcess

        //确定句柄是否为菜单句柄。
        //IsMenu

        //指示是否为鼠标设置 EnableMouseInPointer 作为指针输入设备并发送WM_POINTER消息。
        //IsMouseInPointerEnabled

        //IsProcessDPIAware 可能已更改或不可用。 请改用 GetProcessDPIAwareness。
        //IsProcessDPIAware

        //IsRectEmpty 函数确定指定的矩形是否为空。
        //IsRectEmpty

        //检查指定的窗口是否支持触摸，并且（可选）检索为窗口的触摸功能设置的修饰标志。
        //IsTouchWindow

        //确定指定的DPI_AWARENESS_CONTEXT是否有效且受当前系统支持。
        //IsValidDpiAwarenessContext

        //确定指定的窗口句柄是否标识现有窗口。
        //IsWindow

        //确定是否为鼠标和键盘输入启用指定的窗口。
        //IsWindowEnabled

        //确定指定的窗口是否为本机 Unicode 窗口。
        //IsWindowUnicode

        //确定指定窗口的可见性状态。
        //IsWindowVisible

        //确定是否安装了 WinEvent 挂钩，该挂钩可能会收到指定事件的通知。
        //IsWinEventHookInstalled

        //确定从当前线程队列中读取的最后一条消息是否源自 WOW64 进程。
        //IsWow64Message

        //确定窗口是否最大化。
        //IsZoomed

        //合成击键。
        //keybd_event

        //销毁指定的计时器。
        //KillTimer

        //加载指定的加速器表。 (ANSI)
        //LoadAcceleratorsA

        //加载指定的加速器表。 (Unicode)
        //LoadAcceleratorsW

        //LoadBitmap 函数从模块的可执行文件加载指定的位图资源。 (ANSI)
        //LoadBitmapA

        //LoadBitmap 函数从模块的可执行文件加载指定的位图资源。 (Unicode)
        //LoadBitmapW

        //从与应用程序实例关联的可执行 (.EXE) 文件中加载指定的游标资源。 (ANSI)
        //LoadCursorA

        //基于文件中包含的数据创建游标。 (ANSI)
        //LoadCursorFromFileA

        //基于文件中包含的数据创建游标。 (Unicode)
        //LoadCursorFromFileW

        //从与应用程序实例关联的可执行 (.EXE) 文件中加载指定的游标资源。 (Unicode)
        //LoadCursorW

        //从与应用程序实例关联的可执行文件 (.exe) 文件加载指定的图标资源。 (ANSI)
        //LoadIconA

        //从与应用程序实例关联的可执行文件 (.exe) 文件加载指定的图标资源。 (Unicode)
        //LoadIconW

        //加载图标、游标、动画游标或位图。 (ANSI)
        //LoadImageA

        //加载图标、游标、动画游标或位图。 (Unicode)
        //LoadImageW

        //将以前称为键盘布局的新输入区域设置标识符加载到系统中) (。 (ANSI)
        //LoadKeyboardLayoutA

        //将以前称为键盘布局的新输入区域设置标识符加载到系统中) (。 (Unicode)
        //LoadKeyboardLayoutW

        //从与应用程序实例关联的可执行文件 (.exe) 加载指定的菜单资源。 (ANSI)
        //LoadMenuA

        //在内存中加载指定的菜单模板。 (ANSI)
        //LoadMenuIndirectA

        //在内存中加载指定的菜单模板。 (Unicode)
        //LoadMenuIndirectW

        //从与应用程序实例关联的可执行文件 (.exe) 加载指定的菜单资源。 (Unicode)
        //LoadMenuW

        //从与指定模块关联的可执行文件加载字符串资源，将字符串复制到缓冲区中，并追加终止 null 字符。 (ANSI)
        //LoadStringA

        //从与指定模块关联的可执行文件加载字符串资源，将字符串复制到缓冲区中，并追加终止 null 字符。 (Unicode)
        //LoadStringW

        //前台进程可以调用 LockSetForegroundWindow 函数以禁用对 SetForegroundWindow 函数的调用。
        //LockSetForegroundWindow

        //LockWindowUpdate 函数在指定窗口中禁用或启用绘图。 一次只能锁定一个窗口。
        //LockWindowUpdate

        //锁定工作站的显示器。
        //LockWorkStation

        //将窗口中某个点的逻辑坐标转换为物理坐标。
        //LogicalToPhysicalPoint

        //将窗口中的点从逻辑坐标转换为物理坐标，无论每英寸点 (dpi) 调用方感知。
        //LogicalToPhysicalPointForPerMonitorDPI

        //在图标或光标数据中搜索最适合当前显示设备的图标或光标。 (LookupIconIdFromDirectory)
        //LookupIconIdFromDirectory

        //在图标或光标数据中搜索最适合当前显示设备的图标或光标。 (LookupIconIdFromDirectoryEx)
        //LookupIconIdFromDirectoryEx

        //将整数值转换为与资源管理功能兼容的资源类型。 此宏用于代替包含资源名称的字符串。 (ANSI)
        //MAKEINTRESOURCEA

        //将整数值转换为与资源管理功能兼容的资源类型。 此宏用于代替包含资源名称的字符串。 (Unicode)
        //MAKEINTRESOURCEW

        //创建一个值，以便在消息中用作 lParam 参数。 宏连接指定的值。
        //MAKELPARAM

        //创建一个值，该值用作窗口过程的返回值。 宏连接指定的值。
        //MAKELRESULT

        //创建一个值，以便在消息中用作 wParam 参数。 宏连接指定的值。
        //MAKEWPARAM

        //将指定的对话框单位转换为屏幕单位 (像素) 。
        //MapDialogRect

        //将 (映射) 虚拟密钥代码转换为扫描代码或字符值，或者将扫描代码转换为虚拟密钥代码。 (ANSI)
        //MapVirtualKeyA

        //将 (映射) 虚拟密钥代码转换为扫描代码或字符值，或者将扫描代码转换为虚拟密钥代码。 该函数使用输入语言和输入区域设置标识符翻译代码。 (ANSI)
        //MapVirtualKeyExA

        //将 (映射) 虚拟密钥代码转换为扫描代码或字符值，或将扫描代码转换为虚拟密钥代码。 该函数使用输入语言和输入区域设置标识符翻译代码。 (Unicode)
        //MapVirtualKeyExW

        //将 (映射) 虚拟密钥代码转换为扫描代码或字符值，或将扫描代码转换为虚拟密钥代码。 (Unicode)
        //MapVirtualKeyW

        //MapWindowPoints 函数将 (映射) 一组相对于一个窗口的坐标空间的点转换为相对于另一个窗口的坐标空间。
        //MapWindowPoints

        //确定位于指定位置的菜单项（如果有）。
        //MenuItemFromPoint

        //播放波形声音。 每个声音类型的波形声音由注册表中的一个条目标识。
        //MessageBeep

        //显示一个模式对话框，其中包含系统图标、一组按钮和一条简短的应用程序特定消息，例如状态或错误信息。 消息框返回一个整数值，该值指示用户单击的按钮。 (MessageBoxW)
        //MessageBox

        //显示一个模式对话框，其中包含系统图标、一组按钮和一条简短的应用程序特定消息，例如状态或错误信息。 消息框返回一个整数值，该值指示用户单击的按钮。 (MessageBoxA)
        //MessageBoxA

        //创建、显示和操作消息框。 (ANSI)
        //MessageBoxExA

        //创建、显示和操作消息框。 (Unicode)
        //MessageBoxExW

        //创建、显示和操作消息框。 消息框包含应用程序定义的消息文本和标题、任何图标以及预定义的按下按钮的任意组合。 (ANSI)
        //MessageBoxIndirectA

        //创建、显示和操作消息框。 消息框包含应用程序定义的消息文本和标题、任何图标以及预定义的按下按钮的任意组合。 (Unicode)
        //MessageBoxIndirectW

        //显示一个模式对话框，其中包含系统图标、一组按钮和一条简短的应用程序特定消息，例如状态或错误信息。 消息框返回一个整数值，该值指示用户单击的按钮。 (MessageBoxW)
        //MessageBoxW

        //更改现有菜单项。 (ANSI)
        //ModifyMenuA

        //更改现有菜单项。 (Unicode)
        //ModifyMenuW

        //MonitorFromPoint 函数检索包含指定点的显示监视器的句柄。
        //MonitorFromPoint

        //MonitorFromRect 函数检索具有具有指定矩形交集最大区域的显示监视器的句柄。
        //MonitorFromRect

        //MonitorFromWindow 函数检索显示监视器的句柄，该监视器具有与指定窗口的边界矩形相交的最大区域。
        //MonitorFromWindow

        //mouse_event函数合成鼠标运动和按钮单击。
        //mouse_event

        //更改指定窗口的位置和尺寸。
        //MoveWindow

        //等待一个或多个指定对象处于信号状态或超时间隔过。 这些对象可以包括输入事件对象。
        //MsgWaitForMultipleObjects

        //等待一个或多个指定对象处于信号状态、I/O 完成例程或异步过程调用 (APC) 排队到线程或超时间隔。 对象的数组可以包括输入事件对象。
        //MsgWaitForMultipleObjectsEx

        //检索 RAWINPUT 结构数组中下一个结构的位置。
        //NEXTRAWINPUTBLOCK

        //向系统发出信号，指出发生了预定义事件。 如果任何客户端应用程序为该事件注册了挂钩函数，系统将调用客户端的挂钩函数。
        //NotifyWinEvent

        //将 OEMASCII 代码 0 映射到 OEM 扫描代码和移位状态0x0FF。 该函数提供的信息允许程序通过模拟键盘输入将 OEM 文本发送到另一个程序。
        //OemKeyScan

        //将 OEM 定义的字符集中的字符串转换为 ANSI 或宽字符字符串。警告不使用。 (ANSI)
        //OemToCharA

        //将 OEM 定义的字符集中的指定字符数转换为 ANSI 或宽字符字符串。 (ANSI)
        //OemToCharBuffA

        //将 OEM 定义的字符集中的指定字符数转换为 ANSI 或宽字符字符串。 (Unicode)
        //OemToCharBuffW

        //将 OEM 定义的字符集中的字符串转换为 ANSI 或宽字符字符串。警告不使用。 (Unicode)
        //OemToCharW

        //OffsetRect 函数按指定的偏移量移动指定的矩形。
        //OffsetRect

        //打开剪贴板进行检查，并阻止其他应用程序修改剪贴板内容。
        //OpenClipboard

        //打开指定的桌面对象。 (ANSI)
        //OpenDesktopA

        //打开指定的桌面对象。 (Unicode)
        //OpenDesktopW

        //将最小化的 (标志性的) 窗口还原到其以前的大小和位置;然后激活窗口。
        //OpenIcon

        //打开接收用户输入的桌面。
        //OpenInputDesktop

        //打开指定的窗口工作站。 (ANSI)
        //OpenWindowStationA

        //打开指定的窗口工作站。 (Unicode)
        //OpenWindowStationW

        //返回邻近评估分数和调整的触摸点坐标作为WM_TOUCHHITTESTING回调的打包值。
        //PackTouchHitTestingProximityEvaluation

        //PaintDesktop 函数使用桌面模式或壁纸填充指定设备上下文中的剪辑区域。 该函数主要用于 shell 桌面。
        //PaintDesktop

        //调度传入的非排队消息，检查已发布消息的线程消息队列，并检索消息 (是否存在任何) 。 (ANSI)
        //PeekMessageA

        //调度传入的非排队消息，检查已发布消息的线程消息队列，并检索消息 (是否存在任何) 。 (Unicode)
        //PeekMessageW

        //将窗口中某个点的物理坐标转换为逻辑坐标。
        //PhysicalToLogicalPoint

        //将窗口中的点从物理坐标转换为逻辑坐标，无论每英寸点 (dpi) 调用方感知。
        //PhysicalToLogicalPointForPerMonitorDPI

        //POINTSTOPOINT 宏将 POINTS 结构的内容复制到 POINT 结构中。
        //POINTSTOPOINT

        //POINTTOPOINTS 宏将 POINT 结构转换为 POINTS 结构。
        //POINTTOPOINTS

        //将 (帖子) 与创建指定窗口的线程关联的消息队列中，并返回，而无需等待线程处理消息。 (ANSI)
        //PostMessageA

        //将 (帖子) 与创建指定窗口的线程关联的消息队列中，并返回，而无需等待线程处理消息。 (Unicode)
        //PostMessageW

        //向系统指示线程已发出终止 (退出) 的请求。 它通常用于响应WM_DESTROY消息。
        //PostQuitMessage

        //将消息发布到指定线程的消息队列。 它返回时不等待线程处理消息。 (ANSI)
        //PostThreadMessageA

        //将消息发布到指定线程的消息队列。 它返回时不等待线程处理消息。 (Unicode)
        //PostThreadMessageW

        //PrintWindow 函数将视觉窗口复制到指定的设备上下文中， (DC) ，通常是打印机 DC。
        //PrintWindow

        //创建从指定文件中提取的图标的句柄数组。 (ANSI)
        //PrivateExtractIconsA

        //创建从指定文件中提取的图标的句柄数组。 (Unicode)
        //PrivateExtractIconsW

        //PtInRect 函数确定指定的点是否位于指定的矩形内。
        //PtInRect

        //QueryDisplayConfig 函数在当前设置中检索有关所有显示设备或视图的所有可能显示路径的信息。
        //QueryDisplayConfig

        //检索指定点的子窗口的句柄。 搜索仅限于即时子窗口;孙子和更深的后代窗口没有搜索。
        //RealChildWindowFromPoint

        //检索指定窗口类型的字符串。 (ANSI)
        //RealGetWindowClassA

        //检索指定窗口类型的字符串。 (Unicode)
        //RealGetWindowClassW

        //RedrawWindow 函数更新窗口的工作区中的指定矩形或区域。
        //RedrawWindow

        //注册一个窗口类，以便在对 CreateWindow 或 CreateWindowEx 函数的调用中随后使用。 (RegisterClassA)
        //RegisterClassA

        //注册一个窗口类，以便在对 CreateWindow 或 CreateWindowEx 函数的调用中随后使用。 (RegisterClassExA)
        //RegisterClassExA

        //注册一个窗口类，以便在对 CreateWindow 或 CreateWindowEx 函数的调用中随后使用。 (RegisterClassExW)
        //RegisterClassExW

        //注册一个窗口类，以便在对 CreateWindow 或 CreateWindowEx 函数的调用中随后使用。 (RegisterClassW)
        //RegisterClassW

        //注册新的剪贴板格式。 然后，此格式可用作有效的剪贴板格式。 (ANSI)
        //RegisterClipboardFormatA

        //注册新的剪贴板格式。 然后，此格式可用作有效的剪贴板格式。 (Unicode)
        //RegisterClipboardFormatW

        //注册窗口将为其接收通知的设备或设备类型。 (ANSI)
        //RegisterDeviceNotificationA

        //注册窗口将为其接收通知的设备或设备类型。 (Unicode)
        //RegisterDeviceNotificationW

        //允许应用或 UI 框架注册和注销窗口以接收通知以消除其工具提示窗口。
        //RegisterForTooltipDismissNotification

        //定义系统范围的热键。
        //RegisterHotKey

        //注册一个窗口来处理WM_POINTERDEVICECHANGE、WM_POINTERDEVICEINRANGE和WM_POINTERDEVICEOUTOFRANGE指针设备通知。
        //RegisterPointerDeviceNotifications

        //允许调用方注册将指定类型的所有指针输入重定向到的目标窗口。
        //RegisterPointerInputTarget

        //RegisterPointerInputTargetEx 可能会更改或不可用。 请改用 RegisterPointerInputTarget。
        //RegisterPointerInputTargetEx

        //注册应用程序以接收特定电源设置事件的电源设置通知。
        //RegisterPowerSettingNotification

        //注册提供原始输入数据的设备。
        //RegisterRawInputDevices

        //注册指定的 Shell 窗口，以接收对 Shell 应用程序有用的事件或通知的某些消息。
        //RegisterShellHookWindow

        //注册以在系统暂停或恢复时接收通知。 类似于 PowerRegisterSuspendResumeNotification，但在用户模式下运行，可以采用窗口句柄。
        //RegisterSuspendResumeNotification

        //注册一个窗口来处理WM_TOUCHHITTESTING通知。
        //RegisterTouchHitTestingWindow

        //将窗口注册为支持触摸。
        //RegisterTouchWindow

        //定义保证在整个系统中唯一的新窗口消息。 发送或发布消息时，可以使用消息值。 (ANSI)
        //RegisterWindowMessageA

        //定义保证在整个系统中唯一的新窗口消息。 发送或发布消息时，可以使用消息值。 (Unicode)
        //RegisterWindowMessageW

        //从当前线程中的窗口释放鼠标捕获并还原正常的鼠标输入处理。
        //ReleaseCapture

        //ReleaseDC 函数 (DC) 发布设备上下文，释放它供其他应用程序使用。 ReleaseDC 函数的效果取决于 DC 的类型。 它只释放公用 DC 和窗口 DC。 它对类或专用 DC 没有影响。
        //ReleaseDC

        //从系统维护的剪贴板格式侦听器列表中删除给定窗口。
        //RemoveClipboardFormatListener

        //删除菜单项或从指定菜单中分离子菜单。
        //RemoveMenu

        //从指定窗口的属性列表中删除一个条目。 指定的字符串标识要删除的条目。 (ANSI)
        //RemovePropA

        //从指定窗口的属性列表中删除一个条目。 指定的字符串标识要删除的条目。 (Unicode)
        //RemovePropW

        //通过 SendMessage 函数回复从另一个线程发送的消息。
        //ReplyMessage

        //ScreenToClient 函数将屏幕上指定点的屏幕坐标转换为工作区坐标。
        //ScreenToClient

        //ScrollDC 函数水平和垂直滚动一个位矩形。
        //ScrollDC

        //ScrollWindow 函数滚动指定窗口的工作区的内容。
        //ScrollWindow

        //ScrollWindowEx 函数滚动指定窗口的工作区的内容。
        //ScrollWindowEx

        //将消息发送到对话框中的指定控件。 (ANSI)
        //SendDlgItemMessageA

        //将消息发送到对话框中的指定控件。 (Unicode)
        //SendDlgItemMessageW

        //合成击键、鼠标动作和按钮单击。
        //SendInput

        //将指定的消息发送到窗口或窗口。 SendMessage 函数调用指定窗口的窗口过程，在窗口过程处理消息之前不会返回。 (SendMessageW)
        //SendMessage

        //将指定的消息发送到窗口或窗口。 SendMessage 函数调用指定窗口的窗口过程，在窗口过程处理消息之前不会返回。 (SendMessageA)
        //SendMessageA

        //将指定的消息发送到窗口或窗口。 (SendMessageCallbackA)
        //SendMessageCallbackA

        //将指定的消息发送到窗口或窗口。 (SendMessageCallbackW)
        //SendMessageCallbackW

        //将指定的消息发送到一个或多个窗口。 (ANSI)
        //SendMessageTimeoutA

        //将指定的消息发送到一个或多个窗口。 (Unicode)
        //SendMessageTimeoutW

        //将指定的消息发送到窗口或窗口。 SendMessage 函数调用指定窗口的窗口过程，在窗口过程处理消息之前不会返回。 (SendMessageW)
        //SendMessageW

        //将指定的消息发送到窗口或窗口。 (SendNotifyMessageA)
        //SendNotifyMessageA

        //将指定的消息发送到窗口或窗口。 (SendNotifyMessageW)
        //SendNotifyMessageW

        //激活窗口。 窗口必须附加到调用线程的消息队列。
        //SetActiveWindow

        //SetAdditionalForegroundBoostProcesses 是一种性能辅助 API，可帮助应用程序使用多进程应用程序模型，其中多个进程会作为数据或呈现提供前台体验。
        //SetAdditionalForegroundBoostProcesses

        //将鼠标捕获设置为属于当前线程的指定窗口。
        //SetCapture

        //将插入点闪烁时间设置为指定的毫秒数。 闪烁时间是倒转插入点像素所需的已用时间（以毫秒为单位）。
        //SetCaretBlinkTime

        //将插入点移动到指定的坐标。 如果拥有插入点的窗口是使用CS_OWNDC类样式创建的，则指定的坐标受与该窗口关联的设备上下文的映射模式的约束。
        //SetCaretPos

        //将指定的 32 位 (长) 值替换为指定窗口所属的类的额外类内存或 WNDCLASSEX 结构。 (ANSI)
        //SetClassLongA

        //替换位于额外类内存中的指定偏移量或指定窗口所属类的 WNDCLASSEX 结构中的指定值。 (ANSI)
        //SetClassLongPtrA

        //替换位于额外类内存中的指定偏移量或指定窗口所属类的 WNDCLASSEX 结构中的指定值。 (Unicode)
        //SetClassLongPtrW

        //将指定的 32 位 (长) 值替换为指定窗口所属的类的额外类内存或 WNDCLASSEX 结构。 (Unicode)
        //SetClassLongW

        //将 16 位 (WORD) 值替换为指定窗口所属窗口类的额外类内存。
        //SetClassWord

        //以指定的剪贴板格式将数据放在剪贴板上。
        //SetClipboardData

        //将指定的窗口添加到剪贴板查看器链。 剪贴板查看器窗口在剪贴板内容发生更改时收到WM_DRAWCLIPBOARD消息。 此函数用于向后兼容早期版本的 Windows。
        //SetClipboardViewer


        //使用指定的超时值和合并容错延迟创建计时器。
        //SetCoalescableTimer

        //设置光标形状。
        //SetCursor

        //将光标移动到指定的屏幕坐标。
        //SetCursorPos

        //替代对话框中子窗口的默认按监视器 DPI 缩放行为。
        //SetDialogControlDpiChangeBehavior

        //Per-Monitor v2 上下文中的对话框会自动缩放 DPI。 使用此方法可以自定义其 DPI 更改行为。
        //SetDialogDpiChangeBehavior

        //设置当前进程的屏幕自动旋转首选项。
        //SetDisplayAutoRotationPreferences

        //SetDisplayConfig 函数通过独占启用当前会话中的指定路径来修改显示拓扑、源和目标模式。
        //SetDisplayConfig

        //将对话框中控件的文本设置为指定整数值的字符串表示形式。
        //SetDlgItemInt

        //设置对话框中控件的标题或文本。 (ANSI)
        //SetDlgItemTextA

        //设置对话框中控件的标题或文本。 (Unicode)
        //SetDlgItemTextW

        //设置鼠标的双击时间。
        //SetDoubleClickTime

        //将键盘焦点设置为指定的窗口。 窗口必须附加到调用线程的消息队列。
        //SetFocus

        //将创建指定窗口的线程引入前台并激活窗口。
        //SetForegroundWindow

        //配置从窗口为 Windows Touch 手势发送的消息。
        //SetGestureConfig

        //将键盘键状态数组复制到调用线程的键盘输入状态表中。 这是 GetKeyboardState 和 GetKeyState 函数访问的同一个表。 对此表所做的更改不会影响任何其他线程的键盘输入。
        //SetKeyboardState

        //设置最后一个错误代码。
        //SetLastErrorEx

        //设置分层窗口的不透明度和透明度颜色键。
        //SetLayeredWindowAttributes

        //将新菜单分配给指定的窗口。
        //SetMenu

        //将帮助上下文标识符与菜单相关联。
        //SetMenuContextHelpId

        //设置指定的菜单的默认菜单项。
        //SetMenuDefaultItem

        //设置指定菜单的信息。
        //SetMenuInfo

        //将指定的位图与菜单项相关联。 无论菜单项是选中还是清除，系统都显示菜单项旁边的相应位图。
        //SetMenuItemBitmaps

        //更改有关菜单项的信息。 (ANSI)
        //SetMenuItemInfoA

        //更改有关菜单项的信息。 (Unicode)
        //SetMenuItemInfoW

        //设置当前线程的额外消息信息。
        //SetMessageExtraInfo

        //更改指定子窗口的父窗口。
        //SetParent

        //设置光标在物理坐标中的位置。
        //SetPhysicalCursorPos

        //仅在当前正在运行的进程没有父级或所有者的情况下创建窗口时，更改默认布局。
        //SetProcessDefaultLayout

        //SetProcessDPIAware 可能会更改或不可用。 请改用 SetProcessDPIAwareness。
        //SetProcessDPIAware

        //将当前进程设置为每英寸指定点 (dpi) 感知上下文。 DPI 感知上下文来自DPI_AWARENESS_CONTEXT值。
        //SetProcessDpiAwarenessContext

        //免除调用进程的限制，防止桌面进程与 Windows 应用商店应用环境交互。 开发和调试工具使用此函数。
        //SetProcessRestrictionExemption

        //将指定的窗口工作站分配给调用进程。
        //SetProcessWindowStation

        //在指定窗口的属性列表中添加新条目或更改现有条目。 (ANSI)
        //SetPropA

        //在指定窗口的属性列表中添加新条目或更改现有条目。 (Unicode)
        //SetPropW

        //SetRect 函数设置指定矩形的坐标。 这相当于将左、上、右和底部参数分配给 RECT 结构的相应成员。
        //SetRect

        //SetRectEmpty 函数创建一个空矩形，其中所有坐标都设置为零。
        //SetRectEmpty

        //SetScrollInfo 函数设置滚动条的参数，包括最小和最大滚动位置、页面大小以及滚动框的位置 (拇指) 。 如果请求，该函数还会重新绘制滚动条。
        //SetScrollInfo

        //SetScrollPos 函数设置滚动框的位置 (拇指) 在指定的滚动条中，如果请求，请重新绘制滚动条以反映滚动框的新位置。
        //SetScrollPos

        //SetScrollRange 函数设置指定滚动条的最小和最大滚动框位置。
        //SetScrollRange

        //设置指定显示元素的颜色。
        //SetSysColors

        //使应用程序能够自定义系统游标。 它将由 id 参数指定的系统游标的内容替换为 hcur 参数指定的游标的内容，然后销毁 hcur。
        //SetSystemCursor

        //设置在此线程上创建的游标所针对的 DPI 刻度。 缩放要对其显示的特定监视器的游标时，将考虑此值。
        //SetThreadCursorCreationScaling

        //将指定的桌面分配给调用线程。 桌面上的所有后续操作都使用授予桌面的访问权限。
        //SetThreadDesktop

        //将当前线程的 DPI 感知设置为所提供的值。
        //SetThreadDpiAwarenessContext

        //设置线程的DPI_HOSTING_BEHAVIOR。 此行为允许线程中创建的窗口托管具有不同DPI_AWARENESS_CONTEXT的子窗口。
        //SetThreadDpiHostingBehavior

        //使用指定的超时值创建计时器。
        //SetTimer

        //设置有关指定窗口工作站或桌面对象的信息。 (ANSI)
        //SetUserObjectInformationA

        //设置有关指定窗口工作站或桌面对象的信息。 (Unicode)
        //SetUserObjectInformationW

        //设置用户对象的安全性。 例如，可以是窗口或 DDE 对话。
        //SetUserObjectSecurity

        //将帮助上下文标识符与指定的窗口相关联。
        //SetWindowContextHelpId

        //将显示相关性设置存储在与窗口关联的 hWnd 上的内核模式下。
        //SetWindowDisplayAffinity

        //设置窗口的反馈配置。
        //SetWindowFeedbackSetting

        //更改指定窗口的属性。 该函数还会将 32 位 (长) 值设置为额外的窗口内存中的指定偏移量。 (ANSI)
        //SetWindowLongA

        //更改指定窗口的属性。 (ANSI)
        //SetWindowLongPtrA

        //更改指定窗口的属性。 (Unicode)
        //SetWindowLongPtrW

        //更改指定窗口的属性。 该函数还会将 32 位 (长) 值设置为额外的窗口内存中的指定偏移量。 (Unicode)
        //SetWindowLongW

        //设置显示状态和还原、最小化和最大化指定窗口的位置。
        //SetWindowPlacement

        //更改子窗口、弹出窗口或顶级窗口的大小、位置和 Z 顺序。 这些窗口根据在屏幕上的外观进行排序。 最顶层的窗口接收最高排名，是 Z 顺序中的第一个窗口。
        //SetWindowPos

        //SetWindowRgn 函数设置窗口的窗口区域。
        //SetWindowRgn

        //将应用程序定义的挂钩过程安装到挂钩链中。 (ANSI)
        //SetWindowsHookExA

        //将应用程序定义的挂钩过程安装到挂钩链中。 (Unicode)
        //SetWindowsHookExW

        //如果指定窗口的标题栏具有一个) ，则更改其标题栏的文本 (。 如果指定的窗口是控件，控件的文本将更改。 但是，SetWindowText 无法更改另一个应用程序中控件的文本。 (ANSI)
        //SetWindowTextA

        //如果指定窗口的标题栏具有一个) ，则更改其标题栏的文本 (。 如果指定的窗口是控件，控件的文本将更改。 但是，SetWindowText 无法更改另一个应用程序中控件的文本。 (Unicode)
        //SetWindowTextW

        //为一系列事件设置事件挂钩函数。
        //SetWinEventHook

        //使插入符号在屏幕的当前位置可见。 当插入符号变为可见时，它会自动开始闪烁。
        //ShowCaret

        //显示或隐藏光标。 (ShowCursor)
        //ShowCursor

        //显示或隐藏指定窗口拥有的所有弹出窗口。
        //ShowOwnedPopups

        //ShowScrollBar 函数显示或隐藏指定的滚动条。
        //ShowScrollBar

        //设置指定的窗口的显示状态。
        //ShowWindow

        //设置窗口的显示状态，而无需等待操作完成。
        //ShowWindowAsync

        //指示系统无法关闭，并设置在启动系统关闭时向用户显示的原因字符串。
        //ShutdownBlockReasonCreate

        //指示系统可以关闭并释放原因字符串。
        //ShutdownBlockReasonDestroy

        //检索 ShutdownBlockReasonCreate 函数设置的原因字符串。
        //ShutdownBlockReasonQuery

        //确定哪个指针输入帧为指定的指针生成了最近检索的消息，并丢弃从同一指针输入帧生成的任何排队 (未检索) 指针输入消息。
        //SkipPointerFrameMessages

        //触发视觉信号以指示声音正在播放。
        //SoundSentry

        //SubtractRect 函数确定通过从另一个矩形中减去一个矩形而形成的矩形的坐标。
        //SubtractRect

        //反转或还原左右鼠标按钮的含义。
        //SwapMouseButton

        //使指定的桌面可见并激活它。 这使桌面能够接收来自用户的输入。
        //SwitchDesktop

        //将焦点切换到指定的窗口，并将其带到前台。
        //SwitchToThisWindow

        //检索或设置系统范围参数之一的值。 (ANSI)
        //SystemParametersInfoA

        //检索系统范围参数之一的值，同时考虑提供的 DPI 值。
        //SystemParametersInfoForDpi

        //检索或设置系统范围参数之一的值。 (Unicode)
        //SystemParametersInfoW

        //TabbedTextOut 函数在指定位置写入一个字符串，将选项卡扩展到制表位数组中指定的值。 文本以当前选定的字体、背景色和文本颜色编写。 (ANSI)
        //TabbedTextOutA

        //TabbedTextOut 函数在指定位置写入一个字符串，将选项卡扩展到制表位数组中指定的值。 文本以当前选定的字体、背景色和文本颜色编写。 (Unicode)
        //TabbedTextOutW

        //平铺指定父窗口的指定子窗口。
        //TileWindows

        //将指定的虚拟键代码和键盘状态转换为相应的字符或字符。
        //ToAscii

        //将指定的虚拟键代码和键盘状态转换为相应的字符或字符。 该函数使用输入语言和由输入区域设置标识符标识的物理键盘布局来翻译代码。
        //ToAsciiEx

        //将触摸坐标转换为像素。
        //TOUCH_COORD_TO_PIXEL

        //将指定的虚拟键代码和键盘状态转换为相应的 Unicode 字符或字符。 (ToUnicode)
        //ToUnicode

        //将指定的虚拟键代码和键盘状态转换为相应的 Unicode 字符或字符。 (ToUnicodeEx)
        //ToUnicodeEx

        //当鼠标指针离开窗口或将鼠标悬停在窗口上指定时间时发布消息。
        //TrackMouseEvent

        //在指定位置显示快捷菜单，并跟踪菜单上的项目选择。 快捷菜单可以在屏幕上的任意位置显示。
        //TrackPopupMenu

        //在指定位置显示快捷菜单，并跟踪快捷菜单上的项目选择。 快捷菜单可以在屏幕上的任意位置显示。
        //TrackPopupMenuEx

        //处理菜单命令的快捷键。 (ANSI)
        //TranslateAcceleratorA

        //处理菜单命令的快捷键。 (Unicode)
        //TranslateAcceleratorW

        //处理与指定 MDI 客户端窗口关联的多文档接口的窗口菜单命令的快捷键击 (MDI) 子窗口。
        //TranslateMDISysAccel

        //将虚拟密钥消息转换为字符消息。 字符消息将发布到调用线程的消息队列，下次线程调用 GetMessage 或 PeekMessage 函数时读取该消息。
        //TranslateMessage

        //删除 SetWindowsHookEx 函数在挂钩链中安装的挂钩过程。
        //UnhookWindowsHookEx

        //删除之前对 SetWinEventHook 的调用创建的事件挂钩函数。
        //UnhookWinEvent

        //UnionRect 函数创建两个矩形的并集。 并集是包含两个源矩形的最小矩形。
        //UnionRect

        //(以前称为键盘布局) 卸载输入区域设置标识符。
        //UnloadKeyboardLayout

        //取消注册窗口类，释放类所需的内存。 (ANSI)
        //UnregisterClassA

        //取消注册窗口类，释放类所需的内存。 (Unicode)
        //UnregisterClassW

        //关闭指定的设备通知句柄。
        //UnregisterDeviceNotification

        //释放以前由调用线程注册的热键。
        //UnregisterHotKey

        //允许调用方注销重定向指定类型的所有指针输入的目标窗口。
        //UnregisterPointerInputTarget

        //UnregisterPointerInputTargetEx 可能会更改或不可用。 请改用 UnregisterPointerInputTarget。
        //UnregisterPointerInputTargetEx

        //取消注册电源设置通知。
        //UnregisterPowerSettingNotification

        //取消注册以在系统暂停或恢复时接收通知。 类似于 PowerUnregisterSuspendResumeNotification，但在用户模式下运行。
        //UnregisterSuspendResumeNotification

        //将窗口注册为不再支持触摸。
        //UnregisterTouchWindow

        //更新分层窗口的位置、大小、形状、内容和透明度。
        //UpdateLayeredWindow

        //UpdateWindow 函数通过将WM_PAINT消息发送到窗口来更新指定窗口的工作区（如果窗口的更新区域不为空）。
        //UpdateWindow

        //向具有用户界面限制的作业授予或拒绝对 User 对象的句柄的访问权限。
        //UserHandleGrantAccess

        //ValidateRect 函数通过从指定窗口的更新区域中删除矩形来验证矩形中的工作区。
        //ValidateRect

        //ValidateRgn 函数通过从指定窗口的当前更新区域中删除区域来验证区域中的工作区。
        //ValidateRgn

        //将字符转换为当前键盘的相应虚拟键代码和移位状态。 (ANSI)
        //VkKeyScanA

        //将字符转换为相应的虚拟密钥代码并转移状态。 该函数使用输入语言和由输入区域设置标识符标识的物理键盘布局翻译字符。 (ANSI)
        //VkKeyScanExA

        //将字符转换为相应的虚拟密钥代码并转移状态。 该函数使用输入语言和由输入区域设置标识符标识的物理键盘布局翻译字符。 (Unicode)
        //VkKeyScanExW

        //将字符转换为当前键盘的相应虚拟键代码和移位状态。 (Unicode)
        //VkKeyScanW

        //等待指定进程完成其初始输入，并且正在等待没有输入挂起的用户输入，或者直到超时间隔已过。
        //WaitForInputIdle

        //当线程在其消息队列中没有其他消息时，生成对其他线程的控制。 WaitMessage 函数会暂停线程，在线程的消息队列中放置新消息之前不会返回。
        //WaitMessage

        //WindowFromDC 函数返回与指定显示设备上下文 (DC) 关联的窗口的句柄。 使用指定设备上下文的输出函数在此窗口中绘制。
        //WindowFromDC

        //检索包含指定物理点的窗口的句柄。
        //WindowFromPhysicalPoint

        //检索包含指定点的窗口的句柄。
        //WindowFromPoint

        //启动 Windows 帮助 (Winhelp.exe) 并传递指示应用程序请求的帮助性质的其他数据。 (ANSI)
        //WinHelpA

        //启动 Windows 帮助 (Winhelp.exe) 并传递指示应用程序请求的帮助性质的其他数据。 (Unicode)
        //WinHelpW

        //将数据写入指定的缓冲区。 (ANSI)
        //wsprintfA

        //将数据写入指定的缓冲区。 (Unicode)
        //public static extern IntPtr wsprintfW()

        // 使用指向参数列表的指针将数据写入指定缓冲区。 (ANSI)
        //wvsprintfA();
       
        // 使用指向参数列表的指针将数据写入指定缓冲区。 (Unicode)
        //wvsprintfW();

        #endregion


    }
    

    #region Enum

    public enum KLF : uint
    {
        KLF_ACTIVATE = 0x00000001,
        KLF_SUBSTITUTE_OK = 0x00000002,
        KLF_REORDER = 0x00000008,
        KLF_RESET = 0x40000000,
        KLF_SETFORPROCESS = 0x00000100,
        KLF_SHIFTLOCK = 0x00010000
    }

    [Flags]
    public enum WS : uint
    {
        /// <summary>
        /// 窗口具有细线边框
        /// </summary>
        WS_BORDER = 0x00800000,

        /// <summary>
        /// 窗口具有标题栏 (包括 WS_BORDER 样式) 。
        /// </summary>
        WS_CAPTION = 0x00C00000,
        WS_OVERLAPPED = 0x00000000,
        WS_POPUP = 0x80000000,
        WS_CHILD = 0x40000000,
        WS_MINIMIZE = 0x20000000,
        WS_VISIBLE = 0x10000000,
        WS_DISABLED = 0x08000000,
        WS_CLIPSIBLINGS = 0x04000000,
        WS_CLIPCHILDREN = 0x02000000,
        WS_MAXIMIZE = 0x01000000,
        
       
        WS_DLGFRAME = 0x00400000,
        WS_VSCROLL = 0x00200000,
        WS_HSCROLL = 0x00100000,
        WS_SYSMENU = 0x00080000,
        WS_THICKFRAME = 0x00040000,
        WS_GROUP = 0x00020000,
        WS_TABSTOP = 0x00010000,
        WS_MINIMIZEBOX = 0x00020000,
        WS_MAXIMIZEBOX = 0x00010000,
        WS_TILED = WS_OVERLAPPED,
        WS_ICONIC = WS_MINIMIZE,
        WS_SIZEBOX = WS_THICKFRAME,
        WS_TILEDWINDOW = WS_OVERLAPPEDWINDOW,
        WS_OVERLAPPEDWINDOW = (WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX),
        WS_POPUPWINDOW = (WS_POPUP | WS_BORDER | WS_SYSMENU),
        WS_CHILDWINDOW = WS_CHILD
    }


    #endregion

    #region struct

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

    #endregion
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace WinAPI
//{
//    // ReSharper disable InconsistentNaming
//    public enum SECURITY_IMPERSONATION_LEVEL
//    {
//        SecurityAnonymous,
//        SecurityIdentification,
//        SecurityImpersonation,
//        SecurityDelegation,
//    }

//    public enum WH
//    {
//        WH_MSGFILTER = -1,
//        WH_JOURNALRECORD = 0,
//        WH_JOURNALPLAYBACK = 1,
//        WH_KEYBOARD = 2,
//        WH_GETMESSAGE = 3,
//        WH_CALLWNDPROC = 4,
//        WH_CBT = 5,
//        WH_SYSMSGFILTER = 6,
//        WH_MOUSE = 7,
//        WH_HARDWARE = 8,
//        WH_DEBUG = 9,
//        WH_SHELL = 10,
//        WH_FOREGROUNDIDLE = 11,
//        WH_CALLWNDPROCRET = 12,
//        WH_KEYBOARD_LL = 13,
//        WH_MOUSE_LL = 14
//    }

//    public enum DEVICE_NOTIFY : uint
//    {
//        DEVICE_NOTIFY_WINDOW_HANDLE = 0,
//        DEVICE_NOTIFY_SERVICE_HANDLE = 1,
//        DEVICE_NOTIFY_ALL_INTERFACE_CLASSES = 4
//    }

//    [Flags]
//    public enum LR : uint
//    {
//        LR_DEFAULTCOLOR = 0x00000000,
//        LR_MONOCHROME = 0x00000001,
//        LR_COLOR = 0x00000002,
//        LR_COPYRETURNORG = 0x00000004,
//        LR_COPYDELETEORG = 0x00000008,
//        LR_LOADFROMFILE = 0x00000010,
//        LR_LOADTRANSPARENT = 0x00000020,
//        LR_DEFAULTSIZE = 0x00000040,
//        LR_VGACOLOR = 0x00000080,
//        LR_LOADMAP3DCOLORS = 0x00001000,
//        LR_CREATEDIBSECTION = 0x00002000,
//        LR_COPYFROMRESOURCE = 0x00004000,
//        LR_SHARED = 0x00008000
//    }

//    [Flags]
//    public enum DCX : uint
//    {
//        DCX_WINDOW = 0x00000001,
//        DCX_CACHE = 0x00000002,
//        DCX_NORESETATTRS = 0x00000004,
//        DCX_CLIPCHILDREN = 0x00000008,
//        DCX_CLIPSIBLINGS = 0x00000010,
//        DCX_PARENTCLIP = 0x00000020,
//        DCX_EXCLUDERGN = 0x00000040,
//        DCX_INTERSECTRGN = 0x00000080,
//        DCX_EXCLUDEUPDATE = 0x00000100,
//        DCX_INTERSECTUPDATE = 0x00000200,
//        DCX_LOCKWINDOWUPDATE = 0x00000400,
//        DCX_VALIDATE = 0x00200000
//    }

//    [Flags]
//    public enum CWP
//    {
//        CWP_ALL = 0x0000,
//        CWP_SKIPDISABLED = 0x0002,
//        CWP_SKIPINVISIBLE = 0x0001,
//        CWP_SKIPTRANSPARENT = 0x0004
//    }

//    [Flags]
//    public enum BSF : uint
//    {
//        BSF_ALLOWSFW = 0x00000080,
//        BSF_FLUSHDISK = 0x00000004,
//        BSF_FORCEIFHUNG = 0x00000020,
//        BSF_IGNORECURRENTTASK = 0x00000002,
//        BSF_NOHANG = 0x00000008,
//        BSF_NOTIMEOUTIFNOTHUNG = 0x00000040,
//        BSF_POSTMESSAGE = 0x00000010,
//        BSF_QUERY = 0x00000001,
//        BSF_SENDNOTIFYMESSAGE = 0x00000100,
//        BSF_LUID = 0x00000400
//    }

//    public enum KLF : uint
//    {
//        KLF_ACTIVATE = 0x00000001,
//        KLF_SUBSTITUTE_OK = 0x00000002,
//        KLF_REORDER = 0x00000008,
//        KLF_RESET = 0x40000000,
//        KLF_SETFORPROCESS = 0x00000100,
//        KLF_SHIFTLOCK = 0x00010000
//    }

//    public enum TA : uint
//    {
//        TA_INACTIVE_MENU = 0,
//        TA_ACTIVE_MENU = 1
//    }

//    [Flags]
//    public enum SMTO : uint
//    {
//        SMTO_NORMAL = 0x0000,
//        SMTO_BLOCK = 0x0001,
//        SMTO_ABORTIFHUNG = 0x0002,
//        SMTO_NOTIMEOUTIFNOTHUNG = 0x0008,
//        SMTO_ERRORONEXIT = 0x0020
//    }

//    public enum GW : uint
//    {
//        GW_HWNDFIRST = 0,
//        GW_HWNDLAST = 1,
//        GW_HWNDNEXT = 2,
//        GW_HWNDPREV = 3,
//        GW_OWNER = 4,
//        GW_CHILD = 5,
//        GW_ENABLEDPOPUP = 6,
//        GW_MAX = 6
//    }

//    [Flags]
//    public enum WS_EX : uint
//    {
//        WS_EX_DLGMODALFRAME = 0x00000001,
//        WS_EX_NOPARENTNOTIFY = 0x00000004,
//        WS_EX_TOPMOST = 0x00000008,
//        WS_EX_ACCEPTFILES = 0x00000010,
//        WS_EX_TRANSPARENT = 0x00000020,
//        WS_EX_MDICHILD = 0x00000040,
//        WS_EX_TOOLWINDOW = 0x00000080,
//        WS_EX_WINDOWEDGE = 0x00000100,
//        WS_EX_CLIENTEDGE = 0x00000200,
//        WS_EX_CONTEXTHELP = 0x00000400,
//        WS_EX_RIGHT = 0x00001000,
//        WS_EX_LEFT = 0x00000000,
//        WS_EX_RTLREADING = 0x00002000,
//        WS_EX_LTRREADING = 0x00000000,
//        WS_EX_LEFTSCROLLBAR = 0x00004000,
//        WS_EX_RIGHTSCROLLBAR = 0x00000000,
//        WS_EX_CONTROLPARENT = 0x00010000,
//        WS_EX_STATICEDGE = 0x00020000,
//        WS_EX_APPWINDOW = 0x00040000,
//        WS_EX_OVERLAPPEDWINDOW = (WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE),
//        WS_EX_PALETTEWINDOW = (WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST),
//        WS_EX_LAYERED = 0x00080000,
//        WS_EX_NOINHERITLAYOUT = 0x00100000,
//        WS_EX_LAYOUTRTL = 0x00400000,
//        WS_EX_COMPOSITED = 0x02000000,
//        WS_EX_NOACTIVATE = 0x08000000
//    }

//    public enum HT
//    {
//        HTERROR = -2,
//        HTTRANSPARENT = -1,
//        HTNOWHERE = 0,
//        HTCLIENT = 1,
//        HTCAPTION = 2,
//        HTSYSMENU = 3,
//        HTGROWBOX = 4,
//        HTSIZE = HTGROWBOX,
//        HTMENU = 5,
//        HTHSCROLL = 6,
//        HTVSCROLL = 7,
//        HTMINBUTTON = 8,
//        HTMAXBUTTON = 9,
//        HTLEFT = 10,
//        HTRIGHT = 11,
//        HTTOP = 12,
//        HTTOPLEFT = 13,
//        HTTOPRIGHT = 14,
//        HTBOTTOM = 15,
//        HTBOTTOMLEFT = 16,
//        HTBOTTOMRIGHT = 17,
//        HTBORDER = 18,
//        HTREDUCE = HTMINBUTTON,
//        HTZOOM = HTMAXBUTTON,
//        HTSIZEFIRST = HTLEFT,
//        HTSIZELAST = HTBOTTOMRIGHT,
//        HTOBJECT = 19,
//        HTCLOSE = 20,
//        HTHELP = 21
//    }

//    [Flags]
//    public enum WS : uint
//    {
//        WS_OVERLAPPED = 0x00000000,
//        WS_POPUP = 0x80000000,
//        WS_CHILD = 0x40000000,
//        WS_MINIMIZE = 0x20000000,
//        WS_VISIBLE = 0x10000000,
//        WS_DISABLED = 0x08000000,
//        WS_CLIPSIBLINGS = 0x04000000,
//        WS_CLIPCHILDREN = 0x02000000,
//        WS_MAXIMIZE = 0x01000000,
//        WS_CAPTION = 0x00C00000,
//        WS_BORDER = 0x00800000,
//        WS_DLGFRAME = 0x00400000,
//        WS_VSCROLL = 0x00200000,
//        WS_HSCROLL = 0x00100000,
//        WS_SYSMENU = 0x00080000,
//        WS_THICKFRAME = 0x00040000,
//        WS_GROUP = 0x00020000,
//        WS_TABSTOP = 0x00010000,
//        WS_MINIMIZEBOX = 0x00020000,
//        WS_MAXIMIZEBOX = 0x00010000,
//        WS_TILED = WS_OVERLAPPED,
//        WS_ICONIC = WS_MINIMIZE,
//        WS_SIZEBOX = WS_THICKFRAME,
//        WS_TILEDWINDOW = WS_OVERLAPPEDWINDOW,
//        WS_OVERLAPPEDWINDOW = (WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX),
//        WS_POPUPWINDOW = (WS_POPUP | WS_BORDER | WS_SYSMENU),
//        WS_CHILDWINDOW = WS_CHILD
//    }

//    [Flags]
//    public enum BF : uint
//    {
//        BF_LEFT = 0x0001,
//        BF_TOP = 0x0002,
//        BF_RIGHT = 0x0004,
//        BF_BOTTOM = 0x0008,
//        BF_TOPLEFT = (BF_TOP | BF_LEFT),
//        BF_TOPRIGHT = (BF_TOP | BF_RIGHT),
//        BF_BOTTOMLEFT = (BF_BOTTOM | BF_LEFT),
//        BF_BOTTOMRIGHT = (BF_BOTTOM | BF_RIGHT),
//        BF_RECT = (BF_LEFT | BF_TOP | BF_RIGHT | BF_BOTTOM),
//        BF_DIAGONAL = 0x0010,
//        BF_DIAGONAL_ENDTOPRIGHT = (BF_DIAGONAL | BF_TOP | BF_RIGHT),
//        BF_DIAGONAL_ENDTOPLEFT = (BF_DIAGONAL | BF_TOP | BF_LEFT),
//        BF_DIAGONAL_ENDBOTTOMLEFT = (BF_DIAGONAL | BF_BOTTOM | BF_LEFT),
//        BF_DIAGONAL_ENDBOTTOMRIGHT = (BF_DIAGONAL | BF_BOTTOM | BF_RIGHT),
//        BF_MIDDLE = 0x0800,
//        BF_SOFT = 0x1000,
//        BF_ADJUST = 0x2000,
//        BF_FLAT = 0x4000,
//        BF_MONO = 0x8000
//    }

//    public enum TU : uint
//    {
//        TU_MENU_ACTIVE = 0
//    }

//    public enum GA : uint
//    {
//        GA_PARENT = 1,
//        GA_ROOT = 2,
//        GA_ROOTOWNER = 3
//    }

//    public enum DI : uint
//    {
//        DI_MASK = 0x0001,
//        DI_IMAGE = 0x0002,
//        DI_NORMAL = 0x0003,
//        DI_COMPAT = 0x0004,
//        DI_DEFAULTSIZE = 0x0008,
//        DI_NOMIRROR = 0x0010
//    }

//    public enum PW : uint
//    {
//        PW_CLIENTONLY = 0x00000001
//    }

//    public enum GR : uint
//    {
//        GR_GDIOBJECTS = 0,
//        GR_USEROBJECTS = 1,
//        GR_GDIOBJECTS_PEAK = 2,
//        GR_USEROBJECTS_PEAK = 4
//    }

//    public enum SB : uint
//    {
//        SB_HORZ = 0,
//        SB_VERT = 1,
//        SB_CTL = 2,
//        SB_BOTH = 3
//    }

//    public enum ESB : uint
//    {
//        ESB_ENABLE_BOTH = 0x0000,
//        ESB_DISABLE_BOTH = 0x0003,
//        ESB_DISABLE_LEFT = 0x0001,
//        ESB_DISABLE_RIGHT = 0x0002,
//        ESB_DISABLE_UP = 0x0001,
//        ESB_DISABLE_DOWN = 0x0002,
//        ESB_DISABLE_LTUP = ESB_DISABLE_LEFT,
//        ESB_DISABLE_RTDN = ESB_DISABLE_RIGHT
//    }

//    [Flags]
//    public enum GMDI : uint
//    {
//        GMDI_NONE = 0,
//        GMDI_USEDISABLED = 0x0001,
//        GMDI_GOINTOPOPUPS = 0x0002
//    }

//    [Flags]
//    public enum MF : uint
//    {
//        MF_INSERT = 0x00000000,
//        MF_CHANGE = 0x00000080,
//        MF_APPEND = 0x00000100,
//        MF_DELETE = 0x00000200,
//        MF_REMOVE = 0x00001000,

//        MF_BYCOMMAND = 0x00000000,
//        MF_BYPOSITION = 0x00000400,

//        MF_SEPARATOR = 0x00000800,

//        MF_ENABLED = 0x00000000,
//        MF_GRAYED = 0x00000001,
//        MF_DISABLED = 0x00000002,

//        MF_UNCHECKED = 0x00000000,
//        MF_CHECKED = 0x00000008,
//        MF_USECHECKBITMAPS = 0x00000200,

//        MF_STRING = 0x00000000,
//        MF_BITMAP = 0x00000004,
//        MF_OWNERDRAW = 0x00000100,

//        MF_POPUP = 0x00000010,
//        MF_MENUBARBREAK = 0x00000020,
//        MF_MENUBREAK = 0x00000040,

//        MF_UNHILITE = 0x00000000,
//        MF_HILITE = 0x00000080,
//        MF_DEFAULT = 0x00001000,
//        MF_SYSMENU = 0x00002000,
//        MF_HELP = 0x00004000,
//        MF_RIGHTJUSTIFY = 0x00004000,

//        MF_MOUSESELECT = 0x00008000,
//        MF_END = 0x00000080
//    }

//    [Flags]
//    public enum SW : uint
//    {
//        SW_SCROLLCHILDREN = 0x0001,
//        SW_INVALIDATE = 0x0002,
//        SW_ERASE = 0x0004,
//        SW_SMOOTHSCROLL = 0x0010
//    }

//    [Flags]
//    public enum WINEVENT : uint
//    {
//        WINEVENT_OUTOFCONTEXT = 0x0000,
//        WINEVENT_SKIPOWNTHREAD = 0x0001,
//        WINEVENT_SKIPOWNPROCESS = 0x0002,
//        WINEVENT_INCONTEXT = 0x0004
//    }

//    [Flags]
//    public enum AW : uint
//    {
//        AW_HOR_POSITIVE = 0x00000001,
//        AW_HOR_NEGATIVE = 0x00000002,
//        AW_VER_POSITIVE = 0x00000004,
//        AW_VER_NEGATIVE = 0x00000008,
//        AW_CENTER = 0x00000010,
//        AW_HIDE = 0x00010000,
//        AW_ACTIVATE = 0x00020000,
//        AW_SLIDE = 0x00040000,
//        AW_BLEND = 0x00080000
//    }

//    [Flags]
//    public enum SWP : uint
//    {
//        SWP_NOSIZE = 0x0001,
//        SWP_NOMOVE = 0x0002,
//        SWP_NOZORDER = 0x0004,
//        SWP_NOREDRAW = 0x0008,
//        SWP_NOACTIVATE = 0x0010,
//        SWP_FRAMECHANGED = 0x0020,
//        SWP_SHOWWINDOW = 0x0040,
//        SWP_HIDEWINDOW = 0x0080,
//        SWP_NOCOPYBITS = 0x0100,
//        SWP_NOOWNERZORDER = 0x0200,
//        SWP_NOSENDCHANGING = 0x0400,
//        SWP_DRAWFRAME = SWP_FRAMECHANGED,
//        SWP_NOREPOSITION = SWP_NOOWNERZORDER,
//        SWP_DEFERERASE = 0x2000,
//        SWP_ASYNCWINDOWPOS = 0x4000
//    }

//    [Flags]
//    public enum EWX : uint
//    {
//        EWX_LOGOFF = 0,
//        EWX_SHUTDOWN = 0x00000001,
//        EWX_REBOOT = 0x00000002,
//        EWX_FORCE = 0x00000004,
//        EWX_POWEROFF = 0x00000008,
//        EWX_FORCEIFHUNG = 0x00000010,
//        EWX_QUICKRESOLVE = 0x00000020,
//        EWX_RESTARTAPPS = 0x00000040
//    }

//    [Flags]
//    public enum TPM : uint
//    {
//        TPM_LEFTBUTTON = 0x0000,
//        TPM_RIGHTBUTTON = 0x0002,
//        TPM_LEFTALIGN = 0x0000,
//        TPM_CENTERALIGN = 0x0004,
//        TPM_RIGHTALIGN = 0x0008,
//        TPM_TOPALIGN = 0x0000,
//        TPM_VCENTERALIGN = 0x0010,
//        TPM_BOTTOMALIGN = 0x0020,
//        TPM_HORIZONTAL = 0x0000,
//        TPM_VERTICAL = 0x0040,
//        TPM_NONOTIFY = 0x0080,
//        TPM_RETURNCMD = 0x0100,
//        TPM_RECURSE = 0x0001,
//        TPM_HORPOSANIMATION = 0x0400,
//        TPM_HORNEGANIMATION = 0x0800,
//        TPM_VERPOSANIMATION = 0x1000,
//        TPM_VERNEGANIMATION = 0x2000,
//        TPM_NOANIMATION = 0x4000,
//        TPM_LAYOUTRTL = 0x8000,
//        TPM_WORKAREA = 0x10000
//    }

//    public enum CP : ushort
//    {
//        CP_ACP = 0,
//        CP_MACCP = 2,
//        CP_OEMCP = 1
//    }

//    [Flags]
//    public enum KEYEVENTF : uint
//    {
//        KEYEVENTF_EXTENDEDKEY = 0x0001,
//        KEYEVENTF_KEYUP = 0x0002,
//        KEYEVENTF_UNICODE = 0x0004,
//        KEYEVENTF_SCANCODE = 0x0008
//    }

//    [Flags]
//    public enum MOUSEEVENTF : uint
//    {
//        MOUSEEVENTF_MOVE = 0x0001,
//        MOUSEEVENTF_LEFTDOWN = 0x0002,
//        MOUSEEVENTF_LEFTUP = 0x0004,
//        MOUSEEVENTF_RIGHTDOWN = 0x0008,
//        MOUSEEVENTF_RIGHTUP = 0x0010,
//        MOUSEEVENTF_MIDDLEDOWN = 0x0020,
//        MOUSEEVENTF_MIDDLEUP = 0x0040,
//        MOUSEEVENTF_XDOWN = 0x0080,
//        MOUSEEVENTF_XUP = 0x0100,
//        MOUSEEVENTF_WHEEL = 0x0800,
//        MOUSEEVENTF_HWHEEL = 0x01000,
//        MOUSEEVENTF_MOVE_NOCOALESCE = 0x2000,
//        MOUSEEVENTF_VIRTUALDESK = 0x4000,
//        MOUSEEVENTF_ABSOLUTE = 0x8000
//    }

//    [Flags]
//    public enum QS : uint
//    {
//        QS_ALLEVENTS = (QS_INPUT | QS_POSTMESSAGE | QS_TIMER | QS_PAINT | QS_HOTKEY),
//        QS_ALLINPUT = (QS_INPUT | QS_POSTMESSAGE | QS_TIMER | QS_PAINT | QS_HOTKEY | QS_SENDMESSAGE),
//        QS_ALLPOSTMESSAGE = 0x0100,
//        QS_HOTKEY = 0x0080,
//        QS_INPUT = (QS_MOUSE | QS_KEY | QS_RAWINPUT),
//        QS_KEY = 0x0001,
//        QS_MOUSE = (QS_MOUSEMOVE | QS_MOUSEBUTTON),
//        QS_MOUSEBUTTON = 0x0004,
//        QS_MOUSEMOVE = 0x0002,
//        QS_PAINT = 0x0020,
//        QS_POSTMESSAGE = 0x0008,
//        QS_RAWINPUT = 0x0400,
//        QS_SENDMESSAGE = 0x0040,
//        QS_TIMER = 0x0010
//    }

//    public enum DF : uint
//    {
//        DF_NONE = 0,
//        DF_ALLOWOTHERACCOUNTHOOK = 0x0001
//    }

//    public enum MONITOR : uint
//    {
//        MONITOR_DEFAULTTONULL = 0x00000000,
//        MONITOR_DEFAULTTOPRIMARY = 0x00000001,
//        MONITOR_DEFAULTTONEAREST = 0x00000002
//    }

//    public enum EDD : uint
//    {
//        EDD_NONE = 0,
//        EDD_GET_DEVICE_INTERFACE_NAME = 0x00000001
//    }

//    public enum ULW : uint
//    {
//        ULW_COLORKEY = 0x00000001,
//        ULW_ALPHA = 0x00000002,
//        ULW_OPAQUE = 0x00000004,
//        ULW_EX_NORESIZE = 0x00000008
//    }

//    public enum EDS : uint
//    {
//        EDS_RAWMODE = 0x00000002,
//        EDS_ROTATEDMODE = 0x00000004
//    }

//    [Flags]
//    public enum LWA : uint
//    {
//        LWA_ALPHA = 0x00000002,
//        LWA_COLORKEY = 0x00000001
//    }

//    public enum CWF : uint
//    {
//        CWF_NONE = 0,
//        CWF_CREATE_ONLY = 0x00000001
//    }

//    [Flags]
//    public enum CDS : uint
//    {
//        CDS_DYNAMIC = 0,
//        CDS_UPDATEREGISTRY = 0x00000001,
//        CDS_TEST = 0x00000002,
//        CDS_FULLSCREEN = 0x00000004,
//        CDS_GLOBAL = 0x00000008,
//        CDS_SET_PRIMARY = 0x00000010,
//        CDS_VIDEOPARAMETERS = 0x00000020,
//        CDS_ENABLE_UNSAFE_MODES = 0x00000100,
//        CDS_DISABLE_UNSAFE_MODES = 0x00000200,
//        CDS_RESET = 0x40000000,
//        CDS_RESET_EX = 0x20000000,
//        CDS_NORESET = 0x10000000
//    }

//    [Flags]
//    public enum MWMO
//    {
//        MWMO_ANY = 0,
//        MWMO_ALERTABLE = 0x0002,
//        MWMO_INPUTAVAILABLE = 0x0004,
//        MWMO_WAITALL = 0x0001
//    }

//    [Flags]
//    public enum RDW : uint
//    {
//        RDW_INVALIDATE = 0x0001,
//        RDW_INTERNALPAINT = 0x0002,
//        RDW_ERASE = 0x0004,
//        RDW_VALIDATE = 0x0008,
//        RDW_NOINTERNALPAINT = 0x0010,
//        RDW_NOERASE = 0x0020,
//        RDW_NOCHILDREN = 0x0040,
//        RDW_ALLCHILDREN = 0x0080,
//        RDW_UPDATENOW = 0x0100,
//        RDW_ERASENOW = 0x0200,
//        RDW_FRAME = 0x0400,
//        RDW_NOFRAME = 0x0800,
//    }

//    [Flags]
//    public enum DC : uint
//    {
//        DC_ACTIVE = 0x0001,
//        DC_SMALLCAP = 0x0002,
//        DC_ICON = 0x0004,
//        DC_TEXT = 0x0008,
//        DC_INBUTTON = 0x0010,
//        DC_GRADIENT = 0x0020,
//        DC_BUTTONS = 0x1000
//    }

//    public enum WM : uint
//    {
//        /// <summary>
//        /// The WM_NULL message performs no operation. An application sends the WM_NULL message if it wants to post a message that the recipient window will 
//        /// ignore.
//        /// </summary>
//        WM_NULL = 0x0000,

//        /// <summary>
//        /// The WM_CREATE message is sent when an application requests that a window be created by calling the CreateWindowEx or CreateWindow function. (The 
//        /// message is sent before the function returns.) The window procedure of the new window receives this message after the window is created, but before 
//        /// the window becomes visible.
//        /// </summary>
//        WM_CREATE = 0x0001,

//        /// <summary>
//        /// The WM_DESTROY message is sent when a window is being destroyed. It is sent to the window procedure of the window being destroyed after the window 
//        /// is removed from the screen. This message is sent first to the window being destroyed and then to the child windows (if any) as they are destroyed. 
//        /// During the processing of the message, it can be assumed that all child windows still exist.
//        /// </summary>
//        WM_DESTROY = 0x0002,

//        /// <summary>
//        /// The WM_MOVE message is sent after a window has been moved. 
//        /// </summary>
//        WM_MOVE = 0x0003,

//        /// <summary>
//        /// The WM_SIZE message is sent to a window after its size has changed.
//        /// </summary>
//        WM_SIZE = 0x0005,

//        /// <summary>
//        /// The WM_ACTIVATE message is sent to both the window being activated and the window being deactivated. If the windows use the same input queue, the 
//        /// message is sent synchronously, first to the window procedure of the top-level window being deactivated, then to the window procedure of the top-
//        /// level window being activated. If the windows use different input queues, the message is sent asynchronously, so the window is activated 
//        /// immediately. 
//        /// </summary>
//        WM_ACTIVATE = 0x0006,

//        /// <summary>
//        /// The WM_SETFOCUS message is sent to a window after it has gained the keyboard focus. 
//        /// </summary>
//        WM_SETFOCUS = 0x0007,

//        /// <summary>
//        /// The WM_KILLFOCUS message is sent to a window immediately before it loses the keyboard focus. 
//        /// </summary>
//        WM_KILLFOCUS = 0x0008,

//        /// <summary>
//        /// The WM_ENABLE message is sent when an application changes the enabled state of a window. It is sent to the window whose enabled state is changing. 
//        /// This message is sent before the EnableWindow function returns, but after the enabled state (WS_DISABLED style bit) of the window has changed. 
//        /// </summary>
//        WM_ENABLE = 0x000A,

//        /// <summary>
//        /// An application sends the WM_SETREDRAW message to a window to allow changes in that window to be redrawn or to prevent changes in that window from 
//        /// being redrawn. 
//        /// </summary>
//        WM_SETREDRAW = 0x000B,

//        /// <summary>
//        /// An application sends a WM_SETTEXT message to set the text of a window. 
//        /// </summary>
//        WM_SETTEXT = 0x000C,

//        /// <summary>
//        /// An application sends a WM_GETTEXT message to copy the text that corresponds to a window into a buffer provided by the caller. 
//        /// </summary>
//        WM_GETTEXT = 0x000D,

//        /// <summary>
//        /// An application sends a WM_GETTEXTLENGTH message to determine the length, in characters, of the text associated with a window. 
//        /// </summary>
//        WM_GETTEXTLENGTH = 0x000E,

//        /// <summary>
//        /// The WM_PAINT message is sent when the system or another application makes a request to paint a portion of an application's window. The message is 
//        /// sent when the UpdateWindow or RedrawWindow function is called, or by the DispatchMessage function when the application obtains a WM_PAINT message 
//        /// by using the GetMessage or PeekMessage function. 
//        /// </summary>
//        WM_PAINT = 0x000F,

//        /// <summary>
//        /// The WM_CLOSE message is sent as a signal that a window or an application should terminate.
//        /// </summary>
//        WM_CLOSE = 0x0010,

//        /// <summary>
//        /// The WM_QUERYENDSESSION message is sent when the user chooses to end the session or when an application calls one of the system shutdown functions. 
//        /// If any application returns zero, the session is not ended. The system stops sending WM_QUERYENDSESSION messages as soon as one application returns 
//        /// zero. After processing this message, the system sends the WM_ENDSESSION message with the wParam parameter set to the results of the 
//        /// WM_QUERYENDSESSION message.
//        /// </summary>
//        WM_QUERYENDSESSION = 0x0011,

//        /// <summary>
//        /// The WM_QUERYOPEN message is sent to an icon when the user requests that the window be restored to its previous size and position.
//        /// </summary>
//        WM_QUERYOPEN = 0x0013,

//        /// <summary>
//        /// The WM_ENDSESSION message is sent to an application after the system processes the results of the WM_QUERYENDSESSION message. The WM_ENDSESSION 
//        /// message informs the application whether the session is ending.
//        /// </summary>
//        WM_ENDSESSION = 0x0016,

//        /// <summary>
//        /// The WM_QUIT message indicates a request to terminate an application and is generated when the application calls the PostQuitMessage function. It 
//        /// causes the GetMessage function to return zero.
//        /// </summary>
//        WM_QUIT = 0x0012,

//        /// <summary>
//        /// The WM_ERASEBKGND message is sent when the window background must be erased (for example, when a window is resized). The message is sent to prepare 
//        /// an invalidated portion of a window for painting. 
//        /// </summary>
//        WM_ERASEBKGND = 0x0014,

//        /// <summary>
//        /// This message is sent to all top-level windows when a change is made to a system color setting. 
//        /// </summary>
//        WM_SYSCOLORCHANGE = 0x0015,

//        /// <summary>
//        /// The WM_SHOWWINDOW message is sent to a window when the window is about to be hidden or shown.
//        /// </summary>
//        WM_SHOWWINDOW = 0x0018,

//        /// <summary>
//        /// An application sends the WM_WININICHANGE message to all top-level windows after making a change to the WIN.INI file. The SystemParametersInfo 
//        /// function sends this message after an application uses the function to change a setting in WIN.INI. The WM_WININICHANGE message is provided only for 
//        /// compatibility with earlier versions of the system. Applications should use the WM_SETTINGCHANGE message.
//        /// </summary>
//        WM_WININICHANGE = 0x001A,

//        /// <summary>
//        /// An application sends the WM_WININICHANGE message to all top-level windows after making a change to the WIN.INI file. The SystemParametersInfo 
//        /// function sends this message after an application uses the function to change a setting in WIN.INI. The WM_WININICHANGE message is provided only for 
//        /// compatibility with earlier versions of the system. Applications should use the WM_SETTINGCHANGE message.
//        /// </summary>
//        WM_SETTINGCHANGE = WM_WININICHANGE,

//        /// <summary>
//        /// The WM_DEVMODECHANGE message is sent to all top-level windows whenever the user changes device-mode settings. 
//        /// </summary>
//        WM_DEVMODECHANGE = 0x001B,

//        /// <summary>
//        /// The WM_ACTIVATEAPP message is sent when a window belonging to a different application than the active window is about to be activated. The message 
//        /// is sent to the application whose window is being activated and to the application whose window is being deactivated.
//        /// </summary>
//        WM_ACTIVATEAPP = 0x001C,

//        /// <summary>
//        /// An application sends the WM_FONTCHANGE message to all top-level windows in the system after changing the pool of font resources. 
//        /// </summary>
//        WM_FONTCHANGE = 0x001D,

//        /// <summary>
//        /// A message that is sent whenever there is a change in the system time.
//        /// </summary>
//        WM_TIMECHANGE = 0x001E,

//        /// <summary>
//        /// The WM_CANCELMODE message is sent to cancel certain modes, such as mouse capture. For example, the system sends this message to the active window 
//        /// when a dialog box or message box is displayed. Certain functions also send this message explicitly to the specified window regardless of whether it 
//        /// is the active window. For example, the EnableWindow function sends this message when disabling the specified window.
//        /// </summary>
//        WM_CANCELMODE = 0x001F,

//        /// <summary>
//        /// The WM_SETCURSOR message is sent to a window if the mouse causes the cursor to move within a window and mouse input is not captured. 
//        /// </summary>
//        WM_SETCURSOR = 0x0020,

//        /// <summary>
//        /// The WM_MOUSEACTIVATE message is sent when the cursor is in an inactive window and the user presses a mouse button. The parent window receives this 
//        /// message only if the child window passes it to the DefWindowProc function.
//        /// </summary>
//        WM_MOUSEACTIVATE = 0x0021,

//        /// <summary>
//        /// The WM_CHILDACTIVATE message is sent to a child window when the user clicks the window's title bar or when the window is activated, moved, or 
//        /// sized.
//        /// </summary>
//        WM_CHILDACTIVATE = 0x0022,

//        /// <summary>
//        /// The WM_QUEUESYNC message is sent by a computer-based training (CBT) application to separate user-input messages from other messages sent through 
//        /// the WH_JOURNALPLAYBACK Hook procedure. 
//        /// </summary>
//        WM_QUEUESYNC = 0x0023,

//        /// <summary>
//        /// The WM_GETMINMAXINFO message is sent to a window when the size or position of the window is about to change. An application can use this message to 
//        /// override the window's default maximized size and position, or its default minimum or maximum tracking size. 
//        /// </summary>
//        WM_GETMINMAXINFO = 0x0024,

//        /// <summary>
//        /// Windows NT 3.51 and earlier: The WM_PAINTICON message is sent to a minimized window when the icon is to be painted. This message is not sent by 
//        /// newer versions of Microsoft Windows, except in unusual circumstances explained in the Remarks.
//        /// </summary>
//        WM_PAINTICON = 0x0026,

//        /// <summary>
//        /// Windows NT 3.51 and earlier: The WM_ICONERASEBKGND message is sent to a minimized window when the background of the icon must be filled before 
//        /// painting the icon. A window receives this message only if a class icon is defined for the window; otherwise, WM_ERASEBKGND is sent. This message is 
//        /// not sent by newer versions of Windows.
//        /// </summary>
//        WM_ICONERASEBKGND = 0x0027,

//        /// <summary>
//        /// The WM_NEXTDLGCTL message is sent to a dialog box procedure to set the keyboard focus to a different control in the dialog box. 
//        /// </summary>
//        WM_NEXTDLGCTL = 0x0028,

//        /// <summary>
//        /// The WM_SPOOLERSTATUS message is sent from Print Manager whenever a job is added to or removed from the Print Manager queue. 
//        /// </summary>
//        WM_SPOOLERSTATUS = 0x002A,

//        /// <summary>
//        /// The WM_DRAWITEM message is sent to the parent window of an owner-drawn button, combo box, list box, or menu when a visual aspect of the button, 
//        /// combo box, list box, or menu has changed.
//        /// </summary>
//        WM_DRAWITEM = 0x002B,

//        /// <summary>
//        /// The WM_MEASUREITEM message is sent to the owner window of a combo box, list box, list view control, or menu item when the control or menu is 
//        /// created.
//        /// </summary>
//        WM_MEASUREITEM = 0x002C,

//        /// <summary>
//        /// Sent to the owner of a list box or combo box when the list box or combo box is destroyed or when items are removed by the LB_DELETESTRING, 
//        /// LB_RESETCONTENT, CB_DELETESTRING, or CB_RESETCONTENT message. The system sends a WM_DELETEITEM message for each deleted item. The system sends the 
//        /// WM_DELETEITEM message for any deleted list box or combo box item with nonzero item data.
//        /// </summary>
//        WM_DELETEITEM = 0x002D,

//        /// <summary>
//        /// Sent by a list box with the LBS_WANTKEYBOARDINPUT style to its owner in response to a WM_KEYDOWN message. 
//        /// </summary>
//        WM_VKEYTOITEM = 0x002E,

//        /// <summary>
//        /// Sent by a list box with the LBS_WANTKEYBOARDINPUT style to its owner in response to a WM_CHAR message. 
//        /// </summary>
//        WM_CHARTOITEM = 0x002F,

//        /// <summary>
//        /// An application sends a WM_SETFONT message to specify the font that a control is to use when drawing text. 
//        /// </summary>
//        WM_SETFONT = 0x0030,

//        /// <summary>
//        /// An application sends a WM_GETFONT message to a control to retrieve the font with which the control is currently drawing its text. 
//        /// </summary>
//        WM_GETFONT = 0x0031,

//        /// <summary>
//        /// An application sends a WM_SETHOTKEY message to a window to associate a hot key with the window. When the user presses the hot key, the system 
//        /// activates the window. 
//        /// </summary>
//        WM_SETHOTKEY = 0x0032,

//        /// <summary>
//        /// An application sends a WM_GETHOTKEY message to determine the hot key associated with a window. 
//        /// </summary>
//        WM_GETHOTKEY = 0x0033,

//        /// <summary>
//        /// The WM_QUERYDRAGICON message is sent to a minimized (iconic) window. The window is about to be dragged by the user but does not have an icon 
//        /// defined for its class. An application can return a handle to an icon or cursor. The system displays this cursor or icon while the user drags the 
//        /// icon.
//        /// </summary>
//        WM_QUERYDRAGICON = 0x0037,

//        /// <summary>
//        /// The system sends the WM_COMPAREITEM message to determine the relative position of a new item in the sorted list of an owner-drawn combo box or list 
//        /// box. Whenever the application adds a new item, the system sends this message to the owner of a combo box or list box created with the CBS_SORT or 
//        /// LBS_SORT style. 
//        /// </summary>
//        WM_COMPAREITEM = 0x0039,

//        /// <summary>
//        /// Active Accessibility sends the WM_GETOBJECT message to obtain information about an accessible object contained in a server application. 
//        /// Applications never send this message directly. It is sent only by Active Accessibility in response to calls to AccessibleObjectFromPoint, 
//        /// AccessibleObjectFromEvent, or AccessibleObjectFromWindow. However, server applications handle this message. 
//        /// </summary>
//        WM_GETOBJECT = 0x003D,

//        /// <summary>
//        /// The WM_COMPACTING message is sent to all top-level windows when the system detects more than 12.5 percent of system time over a 30- to 60-second 
//        /// interval is being spent compacting memory. This indicates that system memory is low.
//        /// </summary>
//        WM_COMPACTING = 0x0041,

//        /// <summary>
//        /// WM_COMMNOTIFY is Obsolete for Win32-Based Applications
//        /// </summary>
//        [Obsolete]
//        WM_COMMNOTIFY = 0x0044,

//        /// <summary>
//        /// The WM_WINDOWPOSCHANGING message is sent to a window whose size, position, or place in the Z order is about to change as a result of a call to the 
//        /// SetWindowPos function or another window-management function.
//        /// </summary>
//        WM_WINDOWPOSCHANGING = 0x0046,

//        /// <summary>
//        /// The WM_WINDOWPOSCHANGED message is sent to a window whose size, position, or place in the Z order has changed as a result of a call to the 
//        /// SetWindowPos function or another window-management function.
//        /// </summary>
//        WM_WINDOWPOSCHANGED = 0x0047,

//        /// <summary>
//        /// Notifies applications that the system, typically a battery-powered personal computer, is about to enter a suspended mode.
//        /// Use: POWERBROADCAST
//        /// </summary>
//        [Obsolete]
//        WM_POWER = 0x0048,

//        /// <summary>
//        /// An application sends the WM_COPYDATA message to pass data to another application. 
//        /// </summary>
//        WM_COPYDATA = 0x004A,

//        /// <summary>
//        /// The WM_CANCELJOURNAL message is posted to an application when a user cancels the application's journaling activities. The message is posted with a 
//        /// NULL window handle. 
//        /// </summary>
//        WM_CANCELJOURNAL = 0x004B,

//        /// <summary>
//        /// Sent by a common control to its parent window when an event has occurred or the control requires some information. 
//        /// </summary>
//        WM_NOTIFY = 0x004E,

//        /// <summary>
//        /// The WM_INPUTLANGCHANGEREQUEST message is posted to the window with the focus when the user chooses a new input language, either with the hotkey 
//        /// (specified in the Keyboard control panel application) or from the indicator on the system taskbar. An application can accept the change by passing 
//        /// the message to the DefWindowProc function or reject the change (and prevent it from taking place) by returning immediately. 
//        /// </summary>
//        WM_INPUTLANGCHANGEREQUEST = 0x0050,

//        /// <summary>
//        /// The WM_INPUTLANGCHANGE message is sent to the topmost affected window after an application's input language has been changed. You should make any 
//        /// application-specific settings and pass the message to the DefWindowProc function, which passes the message to all first-level child windows. These 
//        /// child windows can pass the message to DefWindowProc to have it pass the message to their child windows, and so on. 
//        /// </summary>
//        WM_INPUTLANGCHANGE = 0x0051,

//        /// <summary>
//        /// Sent to an application that has initiated a training card with Microsoft Windows Help. The message informs the application when the user clicks an 
//        /// authorable button. An application initiates a training card by specifying the HELP_TCARD command in a call to the WinHelp function.
//        /// </summary>
//        WM_TCARD = 0x0052,

//        /// <summary>
//        /// Indicates that the user pressed the F1 key. If a menu is active when F1 is pressed, WM_HELP is sent to the window associated with the menu; 
//        /// otherwise, WM_HELP is sent to the window that has the keyboard focus. If no window has the keyboard focus, WM_HELP is sent to the currently active 
//        /// window. 
//        /// </summary>
//        WM_HELP = 0x0053,

//        /// <summary>
//        /// The WM_USERCHANGED message is sent to all windows after the user has logged on or off. When the user logs on or off, the system updates the user-
//        /// specific settings. The system sends this message immediately after updating the settings.
//        /// </summary>
//        WM_USERCHANGED = 0x0054,

//        /// <summary>
//        /// Determines if a window accepts ANSI or Unicode structures in the WM_NOTIFY notification message. WM_NOTIFYFORMAT messages are sent from a common 
//        /// control to its parent window and from the parent window to the common control.
//        /// </summary>
//        WM_NOTIFYFORMAT = 0x0055,

//        /// <summary>
//        /// The WM_CONTEXTMENU message notifies a window that the user clicked the right mouse button (right-clicked) in the window.
//        /// </summary>
//        WM_CONTEXTMENU = 0x007B,

//        /// <summary>
//        /// The WM_STYLECHANGING message is sent to a window when the SetWindowLong function is about to change one or more of the window's styles.
//        /// </summary>
//        WM_STYLECHANGING = 0x007C,

//        /// <summary>
//        /// The WM_STYLECHANGED message is sent to a window after the SetWindowLong function has changed one or more of the window's styles
//        /// </summary>
//        WM_STYLECHANGED = 0x007D,

//        /// <summary>
//        /// The WM_DISPLAYCHANGE message is sent to all windows when the display resolution has changed.
//        /// </summary>
//        WM_DISPLAYCHANGE = 0x007E,

//        /// <summary>
//        /// The WM_GETICON message is sent to a window to retrieve a handle to the large or small icon associated with a window. The system displays the large 
//        /// icon in the ALT+TAB dialog, and the small icon in the window caption. 
//        /// </summary>
//        WM_GETICON = 0x007F,

//        /// <summary>
//        /// An application sends the WM_SETICON message to associate a new large or small icon with a window. The system displays the large icon in the ALT+TAB 
//        /// dialog box, and the small icon in the window caption. 
//        /// </summary>
//        WM_SETICON = 0x0080,

//        /// <summary>
//        /// The WM_NCCREATE message is sent prior to the WM_CREATE message when a window is first created.
//        /// </summary>
//        WM_NCCREATE = 0x0081,

//        /// <summary>
//        /// The WM_NCDESTROY message informs a window that its nonclient area is being destroyed. The DestroyWindow function sends the WM_NCDESTROY message to 
//        /// the window following the WM_DESTROY message. WM_DESTROY is used to free the allocated memory object associated with the window.  The WM_NCDESTROY 
//        /// message is sent after the child windows have been destroyed. In contrast, WM_DESTROY is sent before the child windows are destroyed.
//        /// </summary>
//        WM_NCDESTROY = 0x0082,

//        /// <summary>
//        /// The WM_NCCALCSIZE message is sent when the size and position of a window's client area must be calculated. By processing this message, an 
//        /// application can control the content of the window's client area when the size or position of the window changes.
//        /// </summary>
//        WM_NCCALCSIZE = 0x0083,

//        /// <summary>
//        /// The WM_NCHITTEST message is sent to a window when the cursor moves, or when a mouse button is pressed or released. If the mouse is not captured, 
//        /// the message is sent to the window beneath the cursor. Otherwise, the message is sent to the window that has captured the mouse.
//        /// </summary>
//        WM_NCHITTEST = 0x0084,

//        /// <summary>
//        /// The WM_NCPAINT message is sent to a window when its frame must be painted. 
//        /// </summary>
//        WM_NCPAINT = 0x0085,

//        /// <summary>
//        /// The WM_NCACTIVATE message is sent to a window when its nonclient area needs to be changed to indicate an active or inactive state.
//        /// </summary>
//        WM_NCACTIVATE = 0x0086,

//        /// <summary>
//        /// The WM_GETDLGCODE message is sent to the window procedure associated with a control. By default, the system handles all keyboard input to the 
//        /// control; the system interprets certain types of keyboard input as dialog box navigation keys. To override this default behavior, the control can 
//        /// respond to the WM_GETDLGCODE message to indicate the types of input it wants to process itself.
//        /// </summary>
//        WM_GETDLGCODE = 0x0087,

//        /// <summary>
//        /// The WM_SYNCPAINT message is used to synchronize painting while avoiding linking independent GUI threads.
//        /// </summary>
//        WM_SYNCPAINT = 0x0088,

//        /// <summary>
//        /// The WM_NCMOUSEMOVE message is posted to a window when the cursor is moved within the nonclient area of the window. This message is posted to the 
//        /// window that contains the cursor. If a window has captured the mouse, this message is not posted.
//        /// </summary>
//        WM_NCMOUSEMOVE = 0x00A0,

//        /// <summary>
//        /// The WM_NCLBUTTONDOWN message is posted when the user presses the left mouse button while the cursor is within the nonclient area of a window. This 
//        /// message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
//        /// </summary>
//        WM_NCLBUTTONDOWN = 0x00A1,

//        /// <summary>
//        /// The WM_NCLBUTTONUP message is posted when the user releases the left mouse button while the cursor is within the nonclient area of a window. This 
//        /// message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
//        /// </summary>
//        WM_NCLBUTTONUP = 0x00A2,

//        /// <summary>
//        /// The WM_NCLBUTTONDBLCLK message is posted when the user double-clicks the left mouse button while the cursor is within the nonclient area of a 
//        /// window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
//        /// </summary>
//        WM_NCLBUTTONDBLCLK = 0x00A3,

//        /// <summary>
//        /// The WM_NCRBUTTONDOWN message is posted when the user presses the right mouse button while the cursor is within the nonclient area of a window. This 
//        /// message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
//        /// </summary>
//        WM_NCRBUTTONDOWN = 0x00A4,

//        /// <summary>
//        /// The WM_NCRBUTTONUP message is posted when the user releases the right mouse button while the cursor is within the nonclient area of a window. This 
//        /// message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
//        /// </summary>
//        WM_NCRBUTTONUP = 0x00A5,

//        /// <summary>
//        /// The WM_NCRBUTTONDBLCLK message is posted when the user double-clicks the right mouse button while the cursor is within the nonclient area of a 
//        /// window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
//        /// </summary>
//        WM_NCRBUTTONDBLCLK = 0x00A6,

//        /// <summary>
//        /// The WM_NCMBUTTONDOWN message is posted when the user presses the middle mouse button while the cursor is within the nonclient area of a window. 
//        /// This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
//        /// </summary>
//        WM_NCMBUTTONDOWN = 0x00A7,

//        /// <summary>
//        /// The WM_NCMBUTTONUP message is posted when the user releases the middle mouse button while the cursor is within the nonclient area of a window. 
//        /// This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
//        /// </summary>
//        WM_NCMBUTTONUP = 0x00A8,

//        /// <summary>
//        /// The WM_NCMBUTTONDBLCLK message is posted when the user double-clicks the middle mouse button while the cursor is within the nonclient area of a 
//        /// window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
//        /// </summary>
//        WM_NCMBUTTONDBLCLK = 0x00A9,

//        /// <summary>
//        /// The WM_NCXBUTTONDOWN message is posted when the user presses the first or second X button while the cursor is in the nonclient area of a window. 
//        /// This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
//        /// </summary>
//        WM_NCXBUTTONDOWN = 0x00AB,

//        /// <summary>
//        /// The WM_NCXBUTTONUP message is posted when the user releases the first or second X button while the cursor is in the nonclient area of a window. 
//        /// This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
//        /// </summary>
//        WM_NCXBUTTONUP = 0x00AC,

//        /// <summary>
//        /// The WM_NCXBUTTONDBLCLK message is posted when the user double-clicks the first or second X button while the cursor is in the nonclient area of a 
//        /// window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
//        /// </summary>
//        WM_NCXBUTTONDBLCLK = 0x00AD,

//        /// <summary>
//        /// The WM_INPUT_DEVICE_CHANGE message is sent to the window that registered to receive raw input. A window receives this message through its 
//        /// WindowProc function.
//        /// </summary>
//        WM_INPUT_DEVICE_CHANGE = 0x00FE,

//        /// <summary>
//        /// The WM_INPUT message is sent to the window that is getting raw input. 
//        /// </summary>
//        WM_INPUT = 0x00FF,

//        /// <summary>
//        /// The WM_KEYDOWN message is posted to the window with the keyboard focus when a nonsystem key is pressed. A nonsystem key is a key that is pressed 
//        /// when the ALT key is not pressed. 
//        /// </summary>
//        WM_KEYDOWN = 0x0100,

//        /// <summary>
//        /// The WM_KEYUP message is posted to the window with the keyboard focus when a nonsystem key is released. A nonsystem key is a key that is pressed 
//        /// when the ALT key is not pressed, or a keyboard key that is pressed when a window has the keyboard focus. 
//        /// </summary>
//        WM_KEYUP = 0x0101,

//        /// <summary>
//        /// The WM_CHAR message is posted to the window with the keyboard focus when a WM_KEYDOWN message is translated by the TranslateMessage function. The 
//        /// WM_CHAR message contains the character code of the key that was pressed. 
//        /// </summary>
//        WM_CHAR = 0x0102,

//        /// <summary>
//        /// The WM_DEADCHAR message is posted to the window with the keyboard focus when a WM_KEYUP message is translated by the TranslateMessage function. 
//        /// WM_DEADCHAR specifies a character code generated by a dead key. A dead key is a key that generates a character, such as the umlaut (double-dot), 
//        /// that is combined with another character to form a composite character. For example, the umlaut-O character (Ö) is generated by typing the dead key 
//        /// for the umlaut character, and then typing the O key. 
//        /// </summary>
//        WM_DEADCHAR = 0x0103,

//        /// <summary>
//        /// The WM_SYSKEYDOWN message is posted to the window with the keyboard focus when the user presses the F10 key (which activates the menu bar) or holds 
//        /// down the ALT key and then presses another key. It also occurs when no window currently has the keyboard focus; in this case, the WM_SYSKEYDOWN 
//        /// message is sent to the active window. The window that receives the message can distinguish between these two contexts by checking the context code 
//        /// in the lParam parameter. 
//        /// </summary>
//        WM_SYSKEYDOWN = 0x0104,

//        /// <summary>
//        /// The WM_SYSKEYUP message is posted to the window with the keyboard focus when the user releases a key that was pressed while the ALT key was held 
//        /// down. It also occurs when no window currently has the keyboard focus; in this case, the WM_SYSKEYUP message is sent to the active window. The 
//        /// window that receives the message can distinguish between these two contexts by checking the context code in the lParam parameter. 
//        /// </summary>
//        WM_SYSKEYUP = 0x0105,

//        /// <summary>
//        /// The WM_SYSCHAR message is posted to the window with the keyboard focus when a WM_SYSKEYDOWN message is translated by the TranslateMessage function. 
//        /// It specifies the character code of a system character key — that is, a character key that is pressed while the ALT key is down. 
//        /// </summary>
//        WM_SYSCHAR = 0x0106,

//        /// <summary>
//        /// The WM_SYSDEADCHAR message is sent to the window with the keyboard focus when a WM_SYSKEYDOWN message is translated by the TranslateMessage 
//        /// function. WM_SYSDEADCHAR specifies the character code of a system dead key — that is, a dead key that is pressed while holding down the ALT key. 
//        /// </summary>
//        WM_SYSDEADCHAR = 0x0107,

//        /// <summary>
//        /// The WM_UNICHAR message is posted to the window with the keyboard focus when a WM_KEYDOWN message is translated by the TranslateMessage function. 
//        /// The WM_UNICHAR message contains the character code of the key that was pressed. The WM_UNICHAR message is equivalent to WM_CHAR, but it uses 
//        /// Unicode Transformation Format (UTF)-32, whereas WM_CHAR uses UTF-16. It is designed to send or post Unicode characters to ANSI windows and it can 
//        /// can handle Unicode Supplementary Plane characters.
//        /// </summary>
//        WM_UNICHAR = 0x0109,

//        /// <summary>
//        /// Sent immediately before the IME generates the composition string as a result of a keystroke. A window receives this message through its WindowProc 
//        /// function. 
//        /// </summary>
//        WM_IME_STARTCOMPOSITION = 0x010D,

//        /// <summary>
//        /// Sent to an application when the IME ends composition. A window receives this message through its WindowProc function. 
//        /// </summary>
//        WM_IME_ENDCOMPOSITION = 0x010E,

//        /// <summary>
//        /// Sent to an application when the IME changes composition status as a result of a keystroke. A window receives this message through its WindowProc 
//        /// function. 
//        /// </summary>
//        WM_IME_COMPOSITION = 0x010F,

//        /// <summary>
//        /// The WM_INITDIALOG message is sent to the dialog box procedure immediately before a dialog box is displayed. Dialog box procedures typically use 
//        /// this message to initialize controls and carry out any other initialization tasks that affect the appearance of the dialog box. 
//        /// </summary>
//        WM_INITDIALOG = 0x0110,

//        /// <summary>
//        /// The WM_COMMAND message is sent when the user selects a command item from a menu, when a control sends a notification message to its parent window, 
//        /// or when an accelerator keystroke is translated. 
//        /// </summary>
//        WM_COMMAND = 0x0111,

//        /// <summary>
//        /// A window receives this message when the user chooses a command from the Window menu, clicks the maximize button, minimize button, restore button, 
//        /// close button, or moves the form. You can stop the form from moving by filtering this out.
//        /// </summary>
//        WM_SYSCOMMAND = 0x0112,

//        /// <summary>
//        /// The WM_TIMER message is posted to the installing thread's message queue when a timer expires. The message is posted by the GetMessage or 
//        /// PeekMessage function. 
//        /// </summary>
//        WM_TIMER = 0x0113,

//        /// <summary>
//        /// The WM_HSCROLL message is sent to a window when a scroll event occurs in the window's standard horizontal scroll bar. This message is also sent to 
//        /// the owner of a horizontal scroll bar control when a scroll event occurs in the control. 
//        /// </summary>
//        WM_HSCROLL = 0x0114,

//        /// <summary>
//        /// The WM_VSCROLL message is sent to a window when a scroll event occurs in the window's standard vertical scroll bar. This message is also sent to 
//        /// the owner of a vertical scroll bar control when a scroll event occurs in the control. 
//        /// </summary>
//        WM_VSCROLL = 0x0115,

//        /// <summary>
//        /// The WM_INITMENU message is sent when a menu is about to become active. It occurs when the user clicks an item on the menu bar or presses a menu 
//        /// key. This allows the application to modify the menu before it is displayed. 
//        /// </summary>
//        WM_INITMENU = 0x0116,

//        /// <summary>
//        /// The WM_INITMENUPOPUP message is sent when a drop-down menu or submenu is about to become active. This allows an application to modify the menu 
//        /// before it is displayed, without changing the entire menu. 
//        /// </summary>
//        WM_INITMENUPOPUP = 0x0117,

//        /// <summary>
//        /// The WM_MENUSELECT message is sent to a menu's owner window when the user selects a menu item. 
//        /// </summary>
//        WM_MENUSELECT = 0x011F,

//        /// <summary>
//        /// The WM_MENUCHAR message is sent when a menu is active and the user presses a key that does not correspond to any mnemonic or accelerator key. This 
//        /// message is sent to the window that owns the menu. 
//        /// </summary>
//        WM_MENUCHAR = 0x0120,

//        /// <summary>
//        /// The WM_ENTERIDLE message is sent to the owner window of a modal dialog box or menu that is entering an idle state. A modal dialog box or menu 
//        /// enters an idle state when no messages are waiting in its queue after it has processed one or more previous messages. 
//        /// </summary>
//        WM_ENTERIDLE = 0x0121,

//        /// <summary>
//        /// The WM_MENURBUTTONUP message is sent when the user releases the right mouse button while the cursor is on a menu item. 
//        /// </summary>
//        WM_MENURBUTTONUP = 0x0122,

//        /// <summary>
//        /// The WM_MENUDRAG message is sent to the owner of a drag-and-drop menu when the user drags a menu item. 
//        /// </summary>
//        WM_MENUDRAG = 0x0123,

//        /// <summary>
//        /// The WM_MENUGETOBJECT message is sent to the owner of a drag-and-drop menu when the mouse cursor enters a menu item or moves from the center of the 
//        /// item to the top or bottom of the item. 
//        /// </summary>
//        WM_MENUGETOBJECT = 0x0124,

//        /// <summary>
//        /// The WM_UNINITMENUPOPUP message is sent when a drop-down menu or submenu has been destroyed. 
//        /// </summary>
//        WM_UNINITMENUPOPUP = 0x0125,

//        /// <summary>
//        /// The WM_MENUCOMMAND message is sent when the user makes a selection from a menu. 
//        /// </summary>
//        WM_MENUCOMMAND = 0x0126,

//        /// <summary>
//        /// An application sends the WM_CHANGEUISTATE message to indicate that the user interface (UI) state should be changed.
//        /// </summary>
//        WM_CHANGEUISTATE = 0x0127,

//        /// <summary>
//        /// An application sends the WM_UPDATEUISTATE message to change the user interface (UI) state for the specified window and all its child windows.
//        /// </summary>
//        WM_UPDATEUISTATE = 0x0128,

//        /// <summary>
//        /// An application sends the WM_QUERYUISTATE message to retrieve the user interface (UI) state for a window.
//        /// </summary>
//        WM_QUERYUISTATE = 0x0129,

//        /// <summary>
//        /// The WM_CTLCOLORMSGBOX message is sent to the owner window of a message box before Windows draws the message box. By responding to this message, the 
//        /// owner window can set the text and background colors of the message box by using the given display device context handle. 
//        /// </summary>
//        WM_CTLCOLORMSGBOX = 0x0132,

//        /// <summary>
//        /// An edit control that is not read-only or disabled sends the WM_CTLCOLOREDIT message to its parent window when the control is about to be drawn. By 
//        /// responding to this message, the parent window can use the specified device context handle to set the text and background colors of the edit 
//        /// control. 
//        /// </summary>
//        WM_CTLCOLOREDIT = 0x0133,

//        /// <summary>
//        /// Sent to the parent window of a list box before the system draws the list box. By responding to this message, the parent window can set the text and 
//        /// background colors of the list box by using the specified display device context handle. 
//        /// </summary>
//        WM_CTLCOLORLISTBOX = 0x0134,

//        /// <summary>
//        /// The WM_CTLCOLORBTN message is sent to the parent window of a button before drawing the button. The parent window can change the button's text and 
//        /// background colors. However, only owner-drawn buttons respond to the parent window processing this message. 
//        /// </summary>
//        WM_CTLCOLORBTN = 0x0135,

//        /// <summary>
//        /// The WM_CTLCOLORDLG message is sent to a dialog box before the system draws the dialog box. By responding to this message, the dialog box can set 
//        /// its text and background colors using the specified display device context handle. 
//        /// </summary>
//        WM_CTLCOLORDLG = 0x0136,

//        /// <summary>
//        /// The WM_CTLCOLORSCROLLBAR message is sent to the parent window of a scroll bar control when the control is about to be drawn. By responding to this 
//        /// message, the parent window can use the display context handle to set the background color of the scroll bar control. 
//        /// </summary>
//        WM_CTLCOLORSCROLLBAR = 0x0137,

//        /// <summary>
//        /// A static control, or an edit control that is read-only or disabled, sends the WM_CTLCOLORSTATIC message to its parent window when the control is 
//        /// about to be drawn. By responding to this message, the parent window can use the specified device context handle to set the text and background 
//        /// colors of the static control. 
//        /// </summary>
//        WM_CTLCOLORSTATIC = 0x0138,

//        /// <summary>
//        /// Use WM_MOUSEFIRST to specify the first mouse message. Use the PeekMessage() Function.
//        /// </summary>
//        WM_MOUSEFIRST = 0x0200,

//        /// <summary>
//        /// The WM_MOUSEMOVE message is posted to a window when the cursor moves. If the mouse is not captured, the message is posted to the window that 
//        /// contains the cursor. Otherwise, the message is posted to the window that has captured the mouse.
//        /// </summary>
//        WM_MOUSEMOVE = 0x0200,

//        /// <summary>
//        /// The WM_LBUTTONDOWN message is posted when the user presses the left mouse button while the cursor is in the client area of a window. If the mouse 
//        /// is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the 
//        /// mouse.
//        /// </summary>
//        WM_LBUTTONDOWN = 0x0201,

//        /// <summary>
//        /// The WM_LBUTTONUP message is posted when the user releases the left mouse button while the cursor is in the client area of a window. If the mouse 
//        /// is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the 
//        /// mouse.
//        /// </summary>
//        WM_LBUTTONUP = 0x0202,

//        /// <summary>
//        /// The WM_LBUTTONDBLCLK message is posted when the user double-clicks the left mouse button while the cursor is in the client area of a window. If the 
//        /// mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the 
//        /// mouse.
//        /// </summary>
//        WM_LBUTTONDBLCLK = 0x0203,

//        /// <summary>
//        /// The WM_RBUTTONDOWN message is posted when the user presses the right mouse button while the cursor is in the client area of a window. If the mouse 
//        /// is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the 
//        /// mouse.
//        /// </summary>
//        WM_RBUTTONDOWN = 0x0204,

//        /// <summary>
//        /// The WM_RBUTTONUP message is posted when the user releases the right mouse button while the cursor is in the client area of a window. If the mouse 
//        /// is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the 
//        /// mouse.
//        /// </summary>
//        WM_RBUTTONUP = 0x0205,

//        /// <summary>
//        /// The WM_RBUTTONDBLCLK message is posted when the user double-clicks the right mouse button while the cursor is in the client area of a window. If 
//        /// the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured 
//        /// the mouse.
//        /// </summary>
//        WM_RBUTTONDBLCLK = 0x0206,

//        /// <summary>
//        /// The WM_MBUTTONDOWN message is posted when the user presses the middle mouse button while the cursor is in the client area of a window. If the mouse 
//        /// is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the 
//        /// mouse.
//        /// </summary>
//        WM_MBUTTONDOWN = 0x0207,

//        /// <summary>
//        /// The WM_MBUTTONUP message is posted when the user releases the middle mouse button while the cursor is in the client area of a window. If the mouse 
//        /// is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the 
//        /// mouse.
//        /// </summary>
//        WM_MBUTTONUP = 0x0208,

//        /// <summary>
//        /// The WM_MBUTTONDBLCLK message is posted when the user double-clicks the middle mouse button while the cursor is in the client area of a window. If 
//        /// the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured 
//        /// the mouse.
//        /// </summary>
//        WM_MBUTTONDBLCLK = 0x0209,

//        /// <summary>
//        /// The WM_MOUSEWHEEL message is sent to the focus window when the mouse wheel is rotated. The DefWindowProc function propagates the message to the 
//        /// window's parent. There should be no internal forwarding of the message, since DefWindowProc propagates it up the parent chain until it finds a 
//        /// window that processes it.
//        /// </summary>
//        WM_MOUSEWHEEL = 0x020A,

//        /// <summary>
//        /// The WM_XBUTTONDOWN message is posted when the user presses the first or second X button while the cursor is in the client area of a window. If the 
//        /// mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the 
//        /// mouse. 
//        /// </summary>
//        WM_XBUTTONDOWN = 0x020B,

//        /// <summary>
//        /// The WM_XBUTTONUP message is posted when the user releases the first or second X button while the cursor is in the client area of a window. If the 
//        /// mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the 
//        /// mouse.
//        /// </summary>
//        WM_XBUTTONUP = 0x020C,

//        /// <summary>
//        /// The WM_XBUTTONDBLCLK message is posted when the user double-clicks the first or second X button while the cursor is in the client area of a window. 
//        /// If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has 
//        /// captured the mouse.
//        /// </summary>
//        WM_XBUTTONDBLCLK = 0x020D,

//        /// <summary>
//        /// The WM_MOUSEHWHEEL message is sent to the focus window when the mouse's horizontal scroll wheel is tilted or rotated. The DefWindowProc function 
//        /// propagates the message to the window's parent. There should be no internal forwarding of the message, since DefWindowProc propagates it up the 
//        /// parent chain until it finds a window that processes it.
//        /// </summary>
//        WM_MOUSEHWHEEL = 0x020E,

//        /// <summary>
//        /// Use WM_MOUSELAST to specify the last mouse message. Used with PeekMessage() Function.
//        /// </summary>
//        WM_MOUSELAST = 0x020E,

//        /// <summary>
//        /// The WM_PARENTNOTIFY message is sent to the parent of a child window when the child window is created or destroyed, or when the user clicks a mouse 
//        /// button while the cursor is over the child window. When the child window is being created, the system sends WM_PARENTNOTIFY just before the 
//        /// CreateWindow or CreateWindowEx function that creates the window returns. When the child window is being destroyed, the system sends the message 
//        /// before any processing to destroy the window takes place.
//        /// </summary>
//        WM_PARENTNOTIFY = 0x0210,

//        /// <summary>
//        /// The WM_ENTERMENULOOP message informs an application's main window procedure that a menu modal loop has been entered. 
//        /// </summary>
//        WM_ENTERMENULOOP = 0x0211,

//        /// <summary>
//        /// The WM_EXITMENULOOP message informs an application's main window procedure that a menu modal loop has been exited. 
//        /// </summary>
//        WM_EXITMENULOOP = 0x0212,

//        /// <summary>
//        /// The WM_NEXTMENU message is sent to an application when the right or left arrow key is used to switch between the menu bar and the system menu. 
//        /// </summary>
//        WM_NEXTMENU = 0x0213,

//        /// <summary>
//        /// The WM_SIZING message is sent to a window that the user is resizing. By processing this message, an application can monitor the size and position 
//        /// of the drag rectangle and, if needed, change its size or position. 
//        /// </summary>
//        WM_SIZING = 0x0214,

//        /// <summary>
//        /// The WM_CAPTURECHANGED message is sent to the window that is losing the mouse capture.
//        /// </summary>
//        WM_CAPTURECHANGED = 0x0215,

//        /// <summary>
//        /// The WM_MOVING message is sent to a window that the user is moving. By processing this message, an application can monitor the position of the drag 
//        /// rectangle and, if needed, change its position.
//        /// </summary>
//        WM_MOVING = 0x0216,

//        /// <summary>
//        /// Notifies applications that a power-management event has occurred.
//        /// </summary>
//        WM_POWERBROADCAST = 0x0218,

//        /// <summary>
//        /// Notifies an application of a change to the hardware configuration of a device or the computer.
//        /// </summary>
//        WM_DEVICECHANGE = 0x0219,

//        /// <summary>
//        /// An application sends the WM_MDICREATE message to a multiple-document interface (MDI) client window to create an MDI child window. 
//        /// </summary>
//        WM_MDICREATE = 0x0220,

//        /// <summary>
//        /// An application sends the WM_MDIDESTROY message to a multiple-document interface (MDI) client window to close an MDI child window. 
//        /// </summary>
//        WM_MDIDESTROY = 0x0221,

//        /// <summary>
//        /// An application sends the WM_MDIACTIVATE message to a multiple-document interface (MDI) client window to instruct the client window to activate a 
//        /// different MDI child window. 
//        /// </summary>
//        WM_MDIACTIVATE = 0x0222,

//        /// <summary>
//        /// An application sends the WM_MDIRESTORE message to a multiple-document interface (MDI) client window to restore an MDI child window from maximized 
//        /// or minimized size. 
//        /// </summary>
//        WM_MDIRESTORE = 0x0223,

//        /// <summary>
//        /// An application sends the WM_MDINEXT message to a multiple-document interface (MDI) client window to activate the next or previous child window. 
//        /// </summary>
//        WM_MDINEXT = 0x0224,

//        /// <summary>
//        /// An application sends the WM_MDIMAXIMIZE message to a multiple-document interface (MDI) client window to maximize an MDI child window. The system 
//        /// resizes the child window to make its client area fill the client window. The system places the child window's window menu icon in the rightmost 
//        /// position of the frame window's menu bar, and places the child window's restore icon in the leftmost position. The system also appends the title bar 
//        /// text of the child window to that of the frame window. 
//        /// </summary>
//        WM_MDIMAXIMIZE = 0x0225,

//        /// <summary>
//        /// An application sends the WM_MDITILE message to a multiple-document interface (MDI) client window to arrange all of its MDI child windows in a tile 
//        /// format. 
//        /// </summary>
//        WM_MDITILE = 0x0226,

//        /// <summary>
//        /// An application sends the WM_MDICASCADE message to a multiple-document interface (MDI) client window to arrange all its child windows in a cascade 
//        /// format. 
//        /// </summary>
//        WM_MDICASCADE = 0x0227,

//        /// <summary>
//        /// An application sends the WM_MDIICONARRANGE message to a multiple-document interface (MDI) client window to arrange all minimized MDI child windows. 
//        /// It does not affect child windows that are not minimized. 
//        /// </summary>
//        WM_MDIICONARRANGE = 0x0228,

//        /// <summary>
//        /// An application sends the WM_MDIGETACTIVE message to a multiple-document interface (MDI) client window to retrieve the handle to the active MDI 
//        /// child window. 
//        /// </summary>
//        WM_MDIGETACTIVE = 0x0229,

//        /// <summary>
//        /// An application sends the WM_MDISETMENU message to a multiple-document interface (MDI) client window to replace the entire menu of an MDI frame 
//        /// window, to replace the window menu of the frame window, or both. 
//        /// </summary>
//        WM_MDISETMENU = 0x0230,

//        /// <summary>
//        /// The WM_ENTERSIZEMOVE message is sent one time to a window after it enters the moving or sizing modal loop. The window enters the moving or sizing 
//        /// modal loop when the user clicks the window's title bar or sizing border, or when the window passes the WM_SYSCOMMAND message to the DefWindowProc 
//        /// function and the wParam parameter of the message specifies the SC_MOVE or SC_SIZE value. The operation is complete when DefWindowProc returns. 
//        /// The system sends the WM_ENTERSIZEMOVE message regardless of whether the dragging of full windows is enabled.
//        /// </summary>
//        WM_ENTERSIZEMOVE = 0x0231,

//        /// <summary>
//        /// The WM_EXITSIZEMOVE message is sent one time to a window, after it has exited the moving or sizing modal loop. The window enters the moving or 
//        /// sizing modal loop when the user clicks the window's title bar or sizing border, or when the window passes the WM_SYSCOMMAND message to the 
//        /// DefWindowProc function and the wParam parameter of the message specifies the SC_MOVE or SC_SIZE value. The operation is complete when DefWindowProc 
//        /// returns. 
//        /// </summary>
//        WM_EXITSIZEMOVE = 0x0232,

//        /// <summary>
//        /// Sent when the user drops a file on the window of an application that has registered itself as a recipient of dropped files.
//        /// </summary>
//        WM_DROPFILES = 0x0233,

//        /// <summary>
//        /// An application sends the WM_MDIREFRESHMENU message to a multiple-document interface (MDI) client window to refresh the window menu of the MDI frame 
//        /// window. 
//        /// </summary>
//        WM_MDIREFRESHMENU = 0x0234,

//        /// <summary>
//        /// Sent to an application when a window is activated. A window receives this message through its WindowProc function. 
//        /// </summary>
//        WM_IME_SETCONTEXT = 0x0281,

//        /// <summary>
//        /// Sent to an application to notify it of changes to the IME window. A window receives this message through its WindowProc function. 
//        /// </summary>
//        WM_IME_NOTIFY = 0x0282,

//        /// <summary>
//        /// Sent by an application to direct the IME window to carry out the requested command. The application uses this message to control the IME window 
//        /// that it has created. To send this message, the application calls the SendMessage function with the following parameters.
//        /// </summary>
//        WM_IME_CONTROL = 0x0283,

//        /// <summary>
//        /// Sent to an application when the IME window finds no space to extend the area for the composition window. A window receives this message through its 
//        /// WindowProc function. 
//        /// </summary>
//        WM_IME_COMPOSITIONFULL = 0x0284,

//        /// <summary>
//        /// Sent to an application when the operating system is about to change the current IME. A window receives this message through its WindowProc 
//        /// function. 
//        /// </summary>
//        WM_IME_SELECT = 0x0285,

//        /// <summary>
//        /// Sent to an application when the IME gets a character of the conversion result. A window receives this message through its WindowProc function. 
//        /// </summary>
//        WM_IME_CHAR = 0x0286,

//        /// <summary>
//        /// Sent to an application to provide commands and request information. A window receives this message through its WindowProc function. 
//        /// </summary>
//        WM_IME_REQUEST = 0x0288,

//        /// <summary>
//        /// Sent to an application by the IME to notify the application of a key press and to keep message order. A window receives this message through its 
//        /// WindowProc function. 
//        /// </summary>
//        WM_IME_KEYDOWN = 0x0290,

//        /// <summary>
//        /// Sent to an application by the IME to notify the application of a key release and to keep message order. A window receives this message through its 
//        /// WindowProc function. 
//        /// </summary>
//        WM_IME_KEYUP = 0x0291,

//        /// <summary>
//        /// The WM_MOUSEHOVER message is posted to a window when the cursor hovers over the client area of the window for the period of time specified in a 
//        /// prior call to TrackMouseEvent.
//        /// </summary>
//        WM_MOUSEHOVER = 0x02A1,

//        /// <summary>
//        /// The WM_MOUSELEAVE message is posted to a window when the cursor leaves the client area of the window specified in a prior call to TrackMouseEvent.
//        /// </summary>
//        WM_MOUSELEAVE = 0x02A3,

//        /// <summary>
//        /// The WM_NCMOUSEHOVER message is posted to a window when the cursor hovers over the nonclient area of the window for the period of time specified in 
//        /// a prior call to TrackMouseEvent.
//        /// </summary>
//        WM_NCMOUSEHOVER = 0x02A0,

//        /// <summary>
//        /// The WM_NCMOUSELEAVE message is posted to a window when the cursor leaves the nonclient area of the window specified in a prior call to 
//        /// TrackMouseEvent.
//        /// </summary>
//        WM_NCMOUSELEAVE = 0x02A2,

//        /// <summary>
//        /// The WM_WTSSESSION_CHANGE message notifies applications of changes in session state.
//        /// </summary>
//        WM_WTSSESSION_CHANGE = 0x02B1,
//        WM_TABLET_FIRST = 0x02c0,
//        WM_TABLET_LAST = 0x02df,

//        /// <summary>
//        /// An application sends a WM_CUT message to an edit control or combo box to delete (cut) the current selection, if any, in the edit control and copy 
//        /// the deleted text to the clipboard in CF_TEXT format. 
//        /// </summary>
//        WM_CUT = 0x0300,

//        /// <summary>
//        /// An application sends the WM_COPY message to an edit control or combo box to copy the current selection to the clipboard in CF_TEXT format. 
//        /// </summary>
//        WM_COPY = 0x0301,

//        /// <summary>
//        /// An application sends a WM_PASTE message to an edit control or combo box to copy the current content of the clipboard to the edit control at the 
//        /// current caret position. Data is inserted only if the clipboard contains data in CF_TEXT format. 
//        /// </summary>
//        WM_PASTE = 0x0302,

//        /// <summary>
//        /// An application sends a WM_CLEAR message to an edit control or combo box to delete (clear) the current selection, if any, from the edit control. 
//        /// </summary>
//        WM_CLEAR = 0x0303,

//        /// <summary>
//        /// An application sends a WM_UNDO message to an edit control to undo the last operation. When this message is sent to an edit control, the previously 
//        /// deleted text is restored or the previously added text is deleted.
//        /// </summary>
//        WM_UNDO = 0x0304,

//        /// <summary>
//        /// The WM_RENDERFORMAT message is sent to the clipboard owner if it has delayed rendering a specific clipboard format and if an application has 
//        /// requested data in that format. The clipboard owner must render data in the specified format and place it on the clipboard by calling the 
//        /// SetClipboardData function. 
//        /// </summary>
//        WM_RENDERFORMAT = 0x0305,

//        /// <summary>
//        /// The WM_RENDERALLFORMATS message is sent to the clipboard owner before it is destroyed, if the clipboard owner has delayed rendering one or more 
//        /// clipboard formats. For the content of the clipboard to remain available to other applications, the clipboard owner must render data in all the 
//        /// formats it is capable of generating, and place the data on the clipboard by calling the SetClipboardData function. 
//        /// </summary>
//        WM_RENDERALLFORMATS = 0x0306,

//        /// <summary>
//        /// The WM_DESTROYCLIPBOARD message is sent to the clipboard owner when a call to the EmptyClipboard function empties the clipboard. 
//        /// </summary>
//        WM_DESTROYCLIPBOARD = 0x0307,

//        /// <summary>
//        /// The WM_DRAWCLIPBOARD message is sent to the first window in the clipboard viewer chain when the content of the clipboard changes. This enables a 
//        /// clipboard viewer window to display the new content of the clipboard. 
//        /// </summary>
//        WM_DRAWCLIPBOARD = 0x0308,

//        /// <summary>
//        /// The WM_PAINTCLIPBOARD message is sent to the clipboard owner by a clipboard viewer window when the clipboard contains data in the CF_OWNERDISPLAY 
//        /// format and the clipboard viewer's client area needs repainting. 
//        /// </summary>
//        WM_PAINTCLIPBOARD = 0x0309,

//        /// <summary>
//        /// The WM_VSCROLLCLIPBOARD message is sent to the clipboard owner by a clipboard viewer window when the clipboard contains data in the CF_OWNERDISPLAY 
//        /// format and an event occurs in the clipboard viewer's vertical scroll bar. The owner should scroll the clipboard image and update the scroll bar 
//        /// values. 
//        /// </summary>
//        WM_VSCROLLCLIPBOARD = 0x030A,

//        /// <summary>
//        /// The WM_SIZECLIPBOARD message is sent to the clipboard owner by a clipboard viewer window when the clipboard contains data in the CF_OWNERDISPLAY 
//        /// format and the clipboard viewer's client area has changed size. 
//        /// </summary>
//        WM_SIZECLIPBOARD = 0x030B,

//        /// <summary>
//        /// The WM_ASKCBFORMATNAME message is sent to the clipboard owner by a clipboard viewer window to request the name of a CF_OWNERDISPLAY clipboard 
//        /// format.
//        /// </summary>
//        WM_ASKCBFORMATNAME = 0x030C,

//        /// <summary>
//        /// The WM_CHANGECBCHAIN message is sent to the first window in the clipboard viewer chain when a window is being removed from the chain. 
//        /// </summary>
//        WM_CHANGECBCHAIN = 0x030D,

//        /// <summary>
//        /// The WM_HSCROLLCLIPBOARD message is sent to the clipboard owner by a clipboard viewer window. This occurs when the clipboard contains data in the 
//        /// CF_OWNERDISPLAY format and an event occurs in the clipboard viewer's horizontal scroll bar. The owner should scroll the clipboard image and update 
//        /// the scroll bar values. 
//        /// </summary>
//        WM_HSCROLLCLIPBOARD = 0x030E,

//        /// <summary>
//        /// This message informs a window that it is about to receive the keyboard focus, giving the window the opportunity to realize its logical palette when 
//        /// it receives the focus. 
//        /// </summary>
//        WM_QUERYNEWPALETTE = 0x030F,

//        /// <summary>
//        /// The WM_PALETTEISCHANGING message informs applications that an application is going to realize its logical palette. 
//        /// </summary>
//        WM_PALETTEISCHANGING = 0x0310,

//        /// <summary>
//        /// This message is sent by the OS to all top-level and overlapped windows after the window with the keyboard focus realizes its logical palette. 
//        /// This message enables windows that do not have the keyboard focus to realize their logical palettes and update their client areas.
//        /// </summary>
//        WM_PALETTECHANGED = 0x0311,

//        /// <summary>
//        /// The WM_HOTKEY message is posted when the user presses a hot key registered by the RegisterHotKey function. The message is placed at the top of the 
//        /// message queue associated with the thread that registered the hot key. 
//        /// </summary>
//        WM_HOTKEY = 0x0312,

//        /// <summary>
//        /// The WM_PRINT message is sent to a window to request that it draw itself in the specified device context, most commonly in a printer device context.
//        /// </summary>
//        WM_PRINT = 0x0317,

//        /// <summary>
//        /// The WM_PRINTCLIENT message is sent to a window to request that it draw its client area in the specified device context, most commonly in a printer 
//        /// device context.
//        /// </summary>
//        WM_PRINTCLIENT = 0x0318,

//        /// <summary>
//        /// The WM_APPCOMMAND message notifies a window that the user generated an application command event, for example, by clicking an application command 
//        /// button using the mouse or typing an application command key on the keyboard.
//        /// </summary>
//        WM_APPCOMMAND = 0x0319,

//        /// <summary>
//        /// The WM_THEMECHANGED message is broadcast to every window following a theme change event. Examples of theme change events are the activation of a 
//        /// theme, the deactivation of a theme, or a transition from one theme to another.
//        /// </summary>
//        WM_THEMECHANGED = 0x031A,

//        /// <summary>
//        /// Sent when the contents of the clipboard have changed.
//        /// </summary>
//        WM_CLIPBOARDUPDATE = 0x031D,

//        /// <summary>
//        /// The system will send a window the WM_DWMCOMPOSITIONCHANGED message to indicate that the availability of desktop composition has changed.
//        /// </summary>
//        WM_DWMCOMPOSITIONCHANGED = 0x031E,

//        /// <summary>
//        /// WM_DWMNCRENDERINGCHANGED is called when the non-client area rendering status of a window has changed. Only windows that have set the flag 
//        /// DWM_BLURBEHIND.fTransitionOnMaximized to true will get this message. 
//        /// </summary>
//        WM_DWMNCRENDERINGCHANGED = 0x031F,

//        /// <summary>
//        /// Sent to all top-level windows when the colorization color has changed. 
//        /// </summary>
//        WM_DWMCOLORIZATIONCOLORCHANGED = 0x0320,

//        /// <summary>
//        /// WM_DWMWINDOWMAXIMIZEDCHANGE will let you know when a DWM composed window is maximized. You also have to register for this message as well. You'd 
//        /// have other windowd go opaque when this message is sent.
//        /// </summary>
//        WM_DWMWINDOWMAXIMIZEDCHANGE = 0x0321,

//        /// <summary>
//        /// Sent to request extended title bar information. A window receives this message through its WindowProc function.
//        /// </summary>
//        WM_GETTITLEBARINFOEX = 0x033F,
//        WM_HANDHELDFIRST = 0x0358,
//        WM_HANDHELDLAST = 0x035F,
//        WM_AFXFIRST = 0x0360,
//        WM_AFXLAST = 0x037F,
//        WM_PENWINFIRST = 0x0380,
//        WM_PENWINLAST = 0x038F,

//        /// <summary>
//        /// The WM_APP constant is used by applications to help define private messages, usually of the form WM_APP+X, where X is an integer value. 
//        /// </summary>
//        WM_APP = 0x8000,

//        /// <summary>
//        /// The WM_USER constant is used by applications to help define private messages for use by private window classes, usually of the form WM_USER+X, 
//        /// where X is an integer value. 
//        /// </summary>
//        WM_USER = 0x0400,

//        /// <summary>
//        /// An application sends the WM_CPL_LAUNCH message to Windows Control Panel to request that a Control Panel application be started. 
//        /// </summary>
//        WM_CPL_LAUNCH = WM_USER + 0x1000,

//        /// <summary>
//        /// The WM_CPL_LAUNCHED message is sent when a Control Panel application, started by the WM_CPL_LAUNCH message, has closed. The WM_CPL_LAUNCHED message 
//        /// is sent to the window identified by the wParam parameter of the WM_CPL_LAUNCH message that started the application. 
//        /// </summary>
//        WM_CPL_LAUNCHED = WM_USER + 0x1001,

//        /// <summary>
//        /// WM_SYSTIMER is a well-known yet still undocumented message. Windows uses WM_SYSTIMER for internal actions like scrolling.
//        /// </summary>
//        WM_SYSTIMER = 0x118
//    }

//    public enum DBT : uint
//    {
//        DBT_DEVICEARRIVAL = 32768,

//        /// DBT_DEVICEQUERYREMOVE -> 0x8001
//        DBT_DEVICEQUERYREMOVE = 32769,

//        /// DBT_DEVICEQUERYREMOVEFAILED -> 0x8002
//        DBT_DEVICEQUERYREMOVEFAILED = 32770,

//        /// DBT_DEVICEREMOVEPENDING -> 0x8003
//        DBT_DEVICEREMOVEPENDING = 32771,

//        /// DBT_DEVICEREMOVECOMPLETE -> 0x8004
//        DBT_DEVICEREMOVECOMPLETE = 32772,

//        /// DBT_DEVICETYPESPECIFIC -> 0x8005
//        DBT_DEVICETYPESPECIFIC = 32773,

//        /// DBT_CUSTOMEVENT -> 0x8006
//        DBT_CUSTOMEVENT = 32774,

//        /// DBT_DEVINSTENUMERATED -> 0x8007
//        DBT_DEVINSTENUMERATED = 32775,

//        /// DBT_DEVINSTSTARTED -> 0x8008
//        DBT_DEVINSTSTARTED = 32776,

//        /// DBT_DEVINSTREMOVED -> 0x8009
//        DBT_DEVINSTREMOVED = 32777,

//        /// DBT_DEVINSTPROPERTYCHANGED -> 0x800A
//        DBT_DEVINSTPROPERTYCHANGED = 32778,

//        /// DBT_DEVTYP_OEM -> 0x00000000
//        DBT_DEVTYP_OEM = 0,

//        /// DBT_DEVTYP_DEVNODE -> 0x00000001
//        DBT_DEVTYP_DEVNODE = 1,

//        /// DBT_DEVTYP_VOLUME -> 0x00000002
//        DBT_DEVTYP_VOLUME = 2,

//        /// DBT_DEVTYP_PORT -> 0x00000003
//        DBT_DEVTYP_PORT = 3,

//        /// DBT_DEVTYP_NET -> 0x00000004
//        DBT_DEVTYP_NET = 4,

//        /// DBT_DEVTYP_DEVICEINTERFACE -> 0x00000005
//        DBT_DEVTYP_DEVICEINTERFACE = 5,

//        /// DBT_DEVTYP_HANDLE -> 0x00000006
//        DBT_DEVTYP_HANDLE = 6,

//        /// DBT_DEVTYP_DEVINST -> 0x00000007
//        DBT_DEVTYP_DEVINST = 7,

//    }

//    public enum SM
//    {
//        SM_CXSCREEN = 0,

//        /// SM_CYSCREEN -> 1
//        SM_CYSCREEN = 1,

//        /// SM_CXVSCROLL -> 2
//        SM_CXVSCROLL = 2,

//        /// SM_CYHSCROLL -> 3
//        SM_CYHSCROLL = 3,

//        /// SM_CYCAPTION -> 4
//        SM_CYCAPTION = 4,

//        /// SM_CXBORDER -> 5
//        SM_CXBORDER = 5,

//        /// SM_CYBORDER -> 6
//        SM_CYBORDER = 6,

//        /// SM_CXDLGFRAME -> 7
//        SM_CXDLGFRAME = 7,

//        /// SM_CYDLGFRAME -> 8
//        SM_CYDLGFRAME = 8,

//        /// SM_CYVTHUMB -> 9
//        SM_CYVTHUMB = 9,

//        /// SM_CXHTHUMB -> 10
//        SM_CXHTHUMB = 10,

//        /// SM_CXICON -> 11
//        SM_CXICON = 11,

//        /// SM_CYICON -> 12
//        SM_CYICON = 12,

//        /// SM_CXCURSOR -> 13
//        SM_CXCURSOR = 13,

//        /// SM_CYCURSOR -> 14
//        SM_CYCURSOR = 14,

//        /// SM_CYMENU -> 15
//        SM_CYMENU = 15,

//        /// SM_CXFULLSCREEN -> 16
//        SM_CXFULLSCREEN = 16,

//        /// SM_CYFULLSCREEN -> 17
//        SM_CYFULLSCREEN = 17,

//        /// SM_CYKANJIWINDOW -> 18
//        SM_CYKANJIWINDOW = 18,

//        /// SM_MOUSEPRESENT -> 19
//        SM_MOUSEPRESENT = 19,

//        /// SM_CYVSCROLL -> 20
//        SM_CYVSCROLL = 20,

//        /// SM_CXHSCROLL -> 21
//        SM_CXHSCROLL = 21,

//        /// SM_DEBUG -> 22
//        SM_DEBUG = 22,

//        /// SM_SWAPBUTTON -> 23
//        SM_SWAPBUTTON = 23,

//        /// SM_RESERVED1 -> 24
//        SM_RESERVED1 = 24,

//        /// SM_RESERVED2 -> 25
//        SM_RESERVED2 = 25,

//        /// SM_RESERVED3 -> 26
//        SM_RESERVED3 = 26,

//        /// SM_RESERVED4 -> 27
//        SM_RESERVED4 = 27,

//        /// SM_CXMIN -> 28
//        SM_CXMIN = 28,

//        /// SM_CYMIN -> 29
//        SM_CYMIN = 29,

//        /// SM_CXSIZE -> 30
//        SM_CXSIZE = 30,

//        /// SM_CYSIZE -> 31
//        SM_CYSIZE = 31,

//        /// SM_CXFRAME -> 32
//        SM_CXFRAME = 32,

//        /// SM_CYFRAME -> 33
//        SM_CYFRAME = 33,

//        /// SM_CXMINTRACK -> 34
//        SM_CXMINTRACK = 34,

//        /// SM_CYMINTRACK -> 35
//        SM_CYMINTRACK = 35,

//        /// SM_CXDOUBLECLK -> 36
//        SM_CXDOUBLECLK = 36,

//        /// SM_CYDOUBLECLK -> 37
//        SM_CYDOUBLECLK = 37,

//        /// SM_CXICONSPACING -> 38
//        SM_CXICONSPACING = 38,

//        /// SM_CYICONSPACING -> 39
//        SM_CYICONSPACING = 39,

//        /// SM_MENUDROPALIGNMENT -> 40
//        SM_MENUDROPALIGNMENT = 40,

//        /// SM_PENWINDOWS -> 41
//        SM_PENWINDOWS = 41,

//        /// SM_DBCSENABLED -> 42
//        SM_DBCSENABLED = 42,

//        /// SM_CMOUSEBUTTONS -> 43
//        SM_CMOUSEBUTTONS = 43,

//        /// SM_CXFIXEDFRAME -> SM_CXDLGFRAME
//        SM_CXFIXEDFRAME = SM_CXDLGFRAME,

//        /// SM_CYFIXEDFRAME -> SM_CYDLGFRAME
//        SM_CYFIXEDFRAME = SM_CYDLGFRAME,

//        /// SM_CXSIZEFRAME -> SM_CXFRAME
//        SM_CXSIZEFRAME = SM_CXFRAME,

//        /// SM_CYSIZEFRAME -> SM_CYFRAME
//        SM_CYSIZEFRAME = SM_CYFRAME,

//        /// SM_SECURE -> 44
//        SM_SECURE = 44,

//        /// SM_CXEDGE -> 45
//        SM_CXEDGE = 45,

//        /// SM_CYEDGE -> 46
//        SM_CYEDGE = 46,

//        /// SM_CXMINSPACING -> 47
//        SM_CXMINSPACING = 47,

//        /// SM_CYMINSPACING -> 48
//        SM_CYMINSPACING = 48,

//        /// SM_CXSMICON -> 49
//        SM_CXSMICON = 49,

//        /// SM_CYSMICON -> 50
//        SM_CYSMICON = 50,

//        /// SM_CYSMCAPTION -> 51
//        SM_CYSMCAPTION = 51,

//        /// SM_CXSMSIZE -> 52
//        SM_CXSMSIZE = 52,

//        /// SM_CYSMSIZE -> 53
//        SM_CYSMSIZE = 53,

//        /// SM_CXMENUSIZE -> 54
//        SM_CXMENUSIZE = 54,

//        /// SM_CYMENUSIZE -> 55
//        SM_CYMENUSIZE = 55,

//        /// SM_ARRANGE -> 56
//        SM_ARRANGE = 56,

//        /// SM_CXMINIMIZED -> 57
//        SM_CXMINIMIZED = 57,

//        /// SM_CYMINIMIZED -> 58
//        SM_CYMINIMIZED = 58,

//        /// SM_CXMAXTRACK -> 59
//        SM_CXMAXTRACK = 59,

//        /// SM_CYMAXTRACK -> 60
//        SM_CYMAXTRACK = 60,

//        /// SM_CXMAXIMIZED -> 61
//        SM_CXMAXIMIZED = 61,

//        /// SM_CYMAXIMIZED -> 62
//        SM_CYMAXIMIZED = 62,

//        /// SM_NETWORK -> 63
//        SM_NETWORK = 63,

//        /// SM_CLEANBOOT -> 67
//        SM_CLEANBOOT = 67,

//        /// SM_CXDRAG -> 68
//        SM_CXDRAG = 68,

//        /// SM_CYDRAG -> 69
//        SM_CYDRAG = 69,

//        /// SM_SHOWSOUNDS -> 70
//        SM_SHOWSOUNDS = 70,

//        /// SM_CXMENUCHECK -> 71
//        SM_CXMENUCHECK = 71,

//        /// SM_CYMENUCHECK -> 72
//        SM_CYMENUCHECK = 72,

//        /// SM_SLOWMACHINE -> 73
//        SM_SLOWMACHINE = 73,

//        /// SM_MIDEASTENABLED -> 74
//        SM_MIDEASTENABLED = 74,

//        /// SM_MOUSEWHEELPRESENT -> 75
//        SM_MOUSEWHEELPRESENT = 75,

//        /// SM_XVIRTUALSCREEN -> 76
//        SM_XVIRTUALSCREEN = 76,

//        /// SM_YVIRTUALSCREEN -> 77
//        SM_YVIRTUALSCREEN = 77,

//        /// SM_CXVIRTUALSCREEN -> 78
//        SM_CXVIRTUALSCREEN = 78,

//        /// SM_CYVIRTUALSCREEN -> 79
//        SM_CYVIRTUALSCREEN = 79,

//        /// SM_CMONITORS -> 80
//        SM_CMONITORS = 80,

//        /// SM_SAMEDISPLAYFORMAT -> 81
//        SM_SAMEDISPLAYFORMAT = 81,

//        /// SM_IMMENABLED -> 82
//        SM_IMMENABLED = 82,

//        /// SM_CXFOCUSBORDER -> 83
//        SM_CXFOCUSBORDER = 83,

//        /// SM_CYFOCUSBORDER -> 84
//        SM_CYFOCUSBORDER = 84,

//        /// SM_TABLETPC -> 86
//        SM_TABLETPC = 86,

//        /// SM_MEDIACENTER -> 87
//        SM_MEDIACENTER = 87,

//        /// SM_STARTER -> 88
//        SM_STARTER = 88,

//        /// SM_SERVERR2 -> 89
//        SM_SERVERR2 = 89,

//        /// SM_CMETRICS -> 93
//        SM_CMETRICS = 93,

//        /// SM_REMOTESESSION -> 0x1000
//        SM_REMOTESESSION = 4096,

//        /// SM_SHUTTINGDOWN -> 0x2000
//        SM_SHUTTINGDOWN = 8192,

//        /// SM_REMOTECONTROL -> 0x2001
//        SM_REMOTECONTROL = 8193,

//        /// SM_CARETBLINKINGENABLED -> 0x2002
//        SM_CARETBLINKINGENABLED = 8194,

//        /// SM_MOUSEHORIZONTALWHEELPRESENT -> 91
//        SM_MOUSEHORIZONTALWHEELPRESENT = 91,

//        /// SM_CXPADDEDBORDER -> 92
//        SM_CXPADDEDBORDER = 92,

//    }

//    public enum MDITILE
//    {
//        /// MDIS_ALLCHILDSTYLES -> 0x0001
//        MDIS_ALLCHILDSTYLES = 1,

//        /// MDITILE_VERTICAL -> 0x0000
//        MDITILE_VERTICAL = 0,

//        /// MDITILE_HORIZONTAL -> 0x0001
//        MDITILE_HORIZONTAL = 1,

//        /// MDITILE_SKIPDISABLED -> 0x0002
//        MDITILE_SKIPDISABLED = 2,

//        /// MDITILE_ZORDER -> 0x0004
//        MDITILE_ZORDER = 4,
//    }

//    public enum CS
//    {
//        /// CS_VREDRAW -> 0x0001
//        CS_VREDRAW = 1,

//        /// CS_HREDRAW -> 0x0002
//        CS_HREDRAW = 2,

//        /// CS_DBLCLKS -> 0x0008
//        CS_DBLCLKS = 8,

//        /// CS_OWNDC -> 0x0020
//        CS_OWNDC = 32,

//        /// CS_CLASSDC -> 0x0040
//        CS_CLASSDC = 64,

//        /// CS_PARENTDC -> 0x0080
//        CS_PARENTDC = 128,

//        /// CS_NOCLOSE -> 0x0200
//        CS_NOCLOSE = 512,

//        /// CS_SAVEBITS -> 0x0800
//        CS_SAVEBITS = 2048,

//        /// CS_BYTEALIGNCLIENT -> 0x1000
//        CS_BYTEALIGNCLIENT = 4096,

//        /// CS_BYTEALIGNWINDOW -> 0x2000
//        CS_BYTEALIGNWINDOW = 8192,

//        /// CS_GLOBALCLASS -> 0x4000
//        CS_GLOBALCLASS = 16384,

//        /// CS_IME -> 0x00010000
//        CS_IME = 65536,

//        /// CS_DROPSHADOW -> 0x00020000
//        CS_DROPSHADOW = 131072,

//    }

//    public enum CB
//    {
//        /// CB_GETEDITSEL -> 0x0140
//        CB_GETEDITSEL = 320,

//        /// CB_LIMITTEXT -> 0x0141
//        CB_LIMITTEXT = 321,

//        /// CB_SETEDITSEL -> 0x0142
//        CB_SETEDITSEL = 322,

//        /// CB_ADDSTRING -> 0x0143
//        CB_ADDSTRING = 323,

//        /// CB_DELETESTRING -> 0x0144
//        CB_DELETESTRING = 324,

//        /// CB_DIR -> 0x0145
//        CB_DIR = 325,

//        /// CB_GETCOUNT -> 0x0146
//        CB_GETCOUNT = 326,

//        /// CB_GETCURSEL -> 0x0147
//        CB_GETCURSEL = 327,

//        /// CB_GETLBTEXT -> 0x0148
//        CB_GETLBTEXT = 328,

//        /// CB_GETLBTEXTLEN -> 0x0149
//        CB_GETLBTEXTLEN = 329,

//        /// CB_INSERTSTRING -> 0x014A
//        CB_INSERTSTRING = 330,

//        /// CB_RESETCONTENT -> 0x014B
//        CB_RESETCONTENT = 331,

//        /// CB_FINDSTRING -> 0x014C
//        CB_FINDSTRING = 332,

//        /// CB_SELECTSTRING -> 0x014D
//        CB_SELECTSTRING = 333,

//        /// CB_SETCURSEL -> 0x014E
//        CB_SETCURSEL = 334,

//        /// CB_SHOWDROPDOWN -> 0x014F
//        CB_SHOWDROPDOWN = 335,

//        /// CB_GETITEMDATA -> 0x0150
//        CB_GETITEMDATA = 336,

//        /// CB_SETITEMDATA -> 0x0151
//        CB_SETITEMDATA = 337,

//        /// CB_GETDROPPEDCONTROLRECT -> 0x0152
//        CB_GETDROPPEDCONTROLRECT = 338,

//        /// CB_SETITEMHEIGHT -> 0x0153
//        CB_SETITEMHEIGHT = 339,

//        /// CB_GETITEMHEIGHT -> 0x0154
//        CB_GETITEMHEIGHT = 340,

//        /// CB_SETEXTENDEDUI -> 0x0155
//        CB_SETEXTENDEDUI = 341,

//        /// CB_GETEXTENDEDUI -> 0x0156
//        CB_GETEXTENDEDUI = 342,

//        /// CB_GETDROPPEDSTATE -> 0x0157
//        CB_GETDROPPEDSTATE = 343,

//        /// CB_FINDSTRINGEXACT -> 0x0158
//        CB_FINDSTRINGEXACT = 344,

//        /// CB_SETLOCALE -> 0x0159
//        CB_SETLOCALE = 345,

//        /// CB_GETLOCALE -> 0x015A
//        CB_GETLOCALE = 346,

//        /// CB_GETTOPINDEX -> 0x015b
//        CB_GETTOPINDEX = 347,

//        /// CB_SETTOPINDEX -> 0x015c
//        CB_SETTOPINDEX = 348,

//        /// CB_GETHORIZONTALEXTENT -> 0x015d
//        CB_GETHORIZONTALEXTENT = 349,

//        /// CB_SETHORIZONTALEXTENT -> 0x015e
//        CB_SETHORIZONTALEXTENT = 350,

//        /// CB_GETDROPPEDWIDTH -> 0x015f
//        CB_GETDROPPEDWIDTH = 351,

//        /// CB_SETDROPPEDWIDTH -> 0x0160
//        CB_SETDROPPEDWIDTH = 352,

//        /// CB_INITSTORAGE -> 0x0161
//        CB_INITSTORAGE = 353,

//        /// CB_GETCOMBOBOXINFO -> 0x0164
//        CB_GETCOMBOBOXINFO = 356,

//    }

//    public enum CBS
//    {
//        /// CBS_SIMPLE -> 0x0001L
//        CBS_SIMPLE = 1,

//        /// CBS_DROPDOWN -> 0x0002L
//        CBS_DROPDOWN = 2,

//        /// CBS_DROPDOWNLIST -> 0x0003L
//        CBS_DROPDOWNLIST = 3,

//        /// CBS_OWNERDRAWFIXED -> 0x0010L
//        CBS_OWNERDRAWFIXED = 16,

//        /// CBS_OWNERDRAWVARIABLE -> 0x0020L
//        CBS_OWNERDRAWVARIABLE = 32,

//        /// CBS_AUTOHSCROLL -> 0x0040L
//        CBS_AUTOHSCROLL = 64,

//        /// CBS_OEMCONVERT -> 0x0080L
//        CBS_OEMCONVERT = 128,

//        /// CBS_SORT -> 0x0100L
//        CBS_SORT = 256,

//        /// CBS_HASSTRINGS -> 0x0200L
//        CBS_HASSTRINGS = 512,

//        /// CBS_NOINTEGRALHEIGHT -> 0x0400L
//        CBS_NOINTEGRALHEIGHT = 1024,

//        /// CBS_DISABLENOSCROLL -> 0x0800L
//        CBS_DISABLENOSCROLL = 2048,

//        /// CBS_UPPERCASE -> 0x2000L
//        CBS_UPPERCASE = 8192,

//        /// CBS_LOWERCASE -> 0x4000L
//        CBS_LOWERCASE = 16384,

//    }

//    public enum DS
//    {
//        /// DS_ABSALIGN -> 0x01L
//        DS_ABSALIGN = 1,

//        /// DS_SYSMODAL -> 0x02L
//        DS_SYSMODAL = 2,

//        /// DS_LOCALEDIT -> 0x20L
//        DS_LOCALEDIT = 32,

//        /// DS_SETFONT -> 0x40L
//        DS_SETFONT = 64,

//        /// DS_MODALFRAME -> 0x80L
//        DS_MODALFRAME = 128,

//        /// DS_NOIDLEMSG -> 0x100L
//        DS_NOIDLEMSG = 256,

//        /// DS_SETFOREGROUND -> 0x200L
//        DS_SETFOREGROUND = 512,

//        /// DS_3DLOOK -> 0x0004L
//        DS_3DLOOK = 4,

//        /// DS_FIXEDSYS -> 0x0008L
//        DS_FIXEDSYS = 8,

//        /// DS_NOFAILCREATE -> 0x0010L
//        DS_NOFAILCREATE = 16,

//        /// DS_CONTROL -> 0x0400L
//        DS_CONTROL = 1024,

//        /// DS_CENTER -> 0x0800L
//        DS_CENTER = 2048,

//        /// DS_CENTERMOUSE -> 0x1000L
//        DS_CENTERMOUSE = 4096,

//        /// DS_CONTEXTHELP -> 0x2000L
//        DS_CONTEXTHELP = 8192,

//        /// DS_SHELLFONT -> (DS_SETFONT | DS_FIXEDSYS)
//        DS_SHELLFONT = (DS_SETFONT | DS_FIXEDSYS),

//    }

//    public enum RIDI
//    {
//        /// RIDI_PREPARSEDDATA -> 0x20000005
//        RIDI_PREPARSEDDATA = 536870917,

//        /// RIDI_DEVICENAME -> 0x20000007
//        RIDI_DEVICENAME = 536870919,

//        /// RIDI_DEVICEINFO -> 0x2000000b
//        RIDI_DEVICEINFO = 536870923,
//    }

//    public enum LB
//    {
//        /// LB_ADDSTRING -> 0x0180
//        LB_ADDSTRING = 384,

//        /// LB_INSERTSTRING -> 0x0181
//        LB_INSERTSTRING = 385,

//        /// LB_DELETESTRING -> 0x0182
//        LB_DELETESTRING = 386,

//        /// LB_SELITEMRANGEEX -> 0x0183
//        LB_SELITEMRANGEEX = 387,

//        /// LB_RESETCONTENT -> 0x0184
//        LB_RESETCONTENT = 388,

//        /// LB_SETSEL -> 0x0185
//        LB_SETSEL = 389,

//        /// LB_SETCURSEL -> 0x0186
//        LB_SETCURSEL = 390,

//        /// LB_GETSEL -> 0x0187
//        LB_GETSEL = 391,

//        /// LB_GETCURSEL -> 0x0188
//        LB_GETCURSEL = 392,

//        /// LB_GETTEXT -> 0x0189
//        LB_GETTEXT = 393,

//        /// LB_GETTEXTLEN -> 0x018A
//        LB_GETTEXTLEN = 394,

//        /// LB_GETCOUNT -> 0x018B
//        LB_GETCOUNT = 395,

//        /// LB_SELECTSTRING -> 0x018C
//        LB_SELECTSTRING = 396,

//        /// LB_DIR -> 0x018D
//        LB_DIR = 397,

//        /// LB_GETTOPINDEX -> 0x018E
//        LB_GETTOPINDEX = 398,

//        /// LB_FINDSTRING -> 0x018F
//        LB_FINDSTRING = 399,

//        /// LB_GETSELCOUNT -> 0x0190
//        LB_GETSELCOUNT = 400,

//        /// LB_GETSELITEMS -> 0x0191
//        LB_GETSELITEMS = 401,

//        /// LB_SETTABSTOPS -> 0x0192
//        LB_SETTABSTOPS = 402,

//        /// LB_GETHORIZONTALEXTENT -> 0x0193
//        LB_GETHORIZONTALEXTENT = 403,

//        /// LB_SETHORIZONTALEXTENT -> 0x0194
//        LB_SETHORIZONTALEXTENT = 404,

//        /// LB_SETCOLUMNWIDTH -> 0x0195
//        LB_SETCOLUMNWIDTH = 405,

//        /// LB_ADDFILE -> 0x0196
//        LB_ADDFILE = 406,

//        /// LB_SETTOPINDEX -> 0x0197
//        LB_SETTOPINDEX = 407,

//        /// LB_GETITEMRECT -> 0x0198
//        LB_GETITEMRECT = 408,

//        /// LB_GETITEMDATA -> 0x0199
//        LB_GETITEMDATA = 409,

//        /// LB_SETITEMDATA -> 0x019A
//        LB_SETITEMDATA = 410,

//        /// LB_SELITEMRANGE -> 0x019B
//        LB_SELITEMRANGE = 411,

//        /// LB_SETANCHORINDEX -> 0x019C
//        LB_SETANCHORINDEX = 412,

//        /// LB_GETANCHORINDEX -> 0x019D
//        LB_GETANCHORINDEX = 413,

//        /// LB_SETCARETINDEX -> 0x019E
//        LB_SETCARETINDEX = 414,

//        /// LB_GETCARETINDEX -> 0x019F
//        LB_GETCARETINDEX = 415,

//        /// LB_SETITEMHEIGHT -> 0x01A0
//        LB_SETITEMHEIGHT = 416,

//        /// LB_GETITEMHEIGHT -> 0x01A1
//        LB_GETITEMHEIGHT = 417,

//        /// LB_FINDSTRINGEXACT -> 0x01A2
//        LB_FINDSTRINGEXACT = 418,

//        /// LB_SETLOCALE -> 0x01A5
//        LB_SETLOCALE = 421,

//        /// LB_GETLOCALE -> 0x01A6
//        LB_GETLOCALE = 422,

//        /// LB_SETCOUNT -> 0x01A7
//        LB_SETCOUNT = 423,

//        /// LB_INITSTORAGE -> 0x01A8
//        LB_INITSTORAGE = 424,

//        /// LB_ITEMFROMPOINT -> 0x01A9
//        LB_ITEMFROMPOINT = 425,

//        /// LB_GETLISTBOXINFO -> 0x01B2
//        LB_GETLISTBOXINFO = 434,
//    }

//    public enum SPI
//    {
//        /// SPI_GETBEEP -> 0x0001
//        SPI_GETBEEP = 1,

//        /// SPI_SETBEEP -> 0x0002
//        SPI_SETBEEP = 2,

//        /// SPI_GETMOUSE -> 0x0003
//        SPI_GETMOUSE = 3,

//        /// SPI_SETMOUSE -> 0x0004
//        SPI_SETMOUSE = 4,

//        /// SPI_GETBORDER -> 0x0005
//        SPI_GETBORDER = 5,

//        /// SPI_SETBORDER -> 0x0006
//        SPI_SETBORDER = 6,

//        /// SPI_GETKEYBOARDSPEED -> 0x000A
//        SPI_GETKEYBOARDSPEED = 10,

//        /// SPI_SETKEYBOARDSPEED -> 0x000B
//        SPI_SETKEYBOARDSPEED = 11,

//        /// SPI_LANGDRIVER -> 0x000C
//        SPI_LANGDRIVER = 12,

//        /// SPI_ICONHORIZONTALSPACING -> 0x000D
//        SPI_ICONHORIZONTALSPACING = 13,

//        /// SPI_GETSCREENSAVETIMEOUT -> 0x000E
//        SPI_GETSCREENSAVETIMEOUT = 14,

//        /// SPI_SETSCREENSAVETIMEOUT -> 0x000F
//        SPI_SETSCREENSAVETIMEOUT = 15,

//        /// SPI_GETSCREENSAVEACTIVE -> 0x0010
//        SPI_GETSCREENSAVEACTIVE = 16,

//        /// SPI_SETSCREENSAVEACTIVE -> 0x0011
//        SPI_SETSCREENSAVEACTIVE = 17,

//        /// SPI_GETGRIDGRANULARITY -> 0x0012
//        SPI_GETGRIDGRANULARITY = 18,

//        /// SPI_SETGRIDGRANULARITY -> 0x0013
//        SPI_SETGRIDGRANULARITY = 19,

//        /// SPI_SETDESKWALLPAPER -> 0x0014
//        SPI_SETDESKWALLPAPER = 20,

//        /// SPI_SETDESKPATTERN -> 0x0015
//        SPI_SETDESKPATTERN = 21,

//        /// SPI_GETKEYBOARDDELAY -> 0x0016
//        SPI_GETKEYBOARDDELAY = 22,

//        /// SPI_SETKEYBOARDDELAY -> 0x0017
//        SPI_SETKEYBOARDDELAY = 23,

//        /// SPI_ICONVERTICALSPACING -> 0x0018
//        SPI_ICONVERTICALSPACING = 24,

//        /// SPI_GETICONTITLEWRAP -> 0x0019
//        SPI_GETICONTITLEWRAP = 25,

//        /// SPI_SETICONTITLEWRAP -> 0x001A
//        SPI_SETICONTITLEWRAP = 26,

//        /// SPI_GETMENUDROPALIGNMENT -> 0x001B
//        SPI_GETMENUDROPALIGNMENT = 27,

//        /// SPI_SETMENUDROPALIGNMENT -> 0x001C
//        SPI_SETMENUDROPALIGNMENT = 28,

//        /// SPI_SETDOUBLECLKWIDTH -> 0x001D
//        SPI_SETDOUBLECLKWIDTH = 29,

//        /// SPI_SETDOUBLECLKHEIGHT -> 0x001E
//        SPI_SETDOUBLECLKHEIGHT = 30,

//        /// SPI_GETICONTITLELOGFONT -> 0x001F
//        SPI_GETICONTITLELOGFONT = 31,

//        /// SPI_SETDOUBLECLICKTIME -> 0x0020
//        SPI_SETDOUBLECLICKTIME = 32,

//        /// SPI_SETMOUSEBUTTONSWAP -> 0x0021
//        SPI_SETMOUSEBUTTONSWAP = 33,

//        /// SPI_SETICONTITLELOGFONT -> 0x0022
//        SPI_SETICONTITLELOGFONT = 34,

//        /// SPI_GETFASTTASKSWITCH -> 0x0023
//        SPI_GETFASTTASKSWITCH = 35,

//        /// SPI_SETFASTTASKSWITCH -> 0x0024
//        SPI_SETFASTTASKSWITCH = 36,

//        /// SPI_SETDRAGFULLWINDOWS -> 0x0025
//        SPI_SETDRAGFULLWINDOWS = 37,

//        /// SPI_GETDRAGFULLWINDOWS -> 0x0026
//        SPI_GETDRAGFULLWINDOWS = 38,

//        /// SPI_GETNONCLIENTMETRICS -> 0x0029
//        SPI_GETNONCLIENTMETRICS = 41,

//        /// SPI_SETNONCLIENTMETRICS -> 0x002A
//        SPI_SETNONCLIENTMETRICS = 42,

//        /// SPI_GETMINIMIZEDMETRICS -> 0x002B
//        SPI_GETMINIMIZEDMETRICS = 43,

//        /// SPI_SETMINIMIZEDMETRICS -> 0x002C
//        SPI_SETMINIMIZEDMETRICS = 44,

//        /// SPI_GETICONMETRICS -> 0x002D
//        SPI_GETICONMETRICS = 45,

//        /// SPI_SETICONMETRICS -> 0x002E
//        SPI_SETICONMETRICS = 46,

//        /// SPI_SETWORKAREA -> 0x002F
//        SPI_SETWORKAREA = 47,

//        /// SPI_GETWORKAREA -> 0x0030
//        SPI_GETWORKAREA = 48,

//        /// SPI_SETPENWINDOWS -> 0x0031
//        SPI_SETPENWINDOWS = 49,

//        /// SPI_GETHIGHCONTRAST -> 0x0042
//        SPI_GETHIGHCONTRAST = 66,

//        /// SPI_SETHIGHCONTRAST -> 0x0043
//        SPI_SETHIGHCONTRAST = 67,

//        /// SPI_GETKEYBOARDPREF -> 0x0044
//        SPI_GETKEYBOARDPREF = 68,

//        /// SPI_SETKEYBOARDPREF -> 0x0045
//        SPI_SETKEYBOARDPREF = 69,

//        /// SPI_GETSCREENREADER -> 0x0046
//        SPI_GETSCREENREADER = 70,

//        /// SPI_SETSCREENREADER -> 0x0047
//        SPI_SETSCREENREADER = 71,

//        /// SPI_GETANIMATION -> 0x0048
//        SPI_GETANIMATION = 72,

//        /// SPI_SETANIMATION -> 0x0049
//        SPI_SETANIMATION = 73,

//        /// SPI_GETFONTSMOOTHING -> 0x004A
//        SPI_GETFONTSMOOTHING = 74,

//        /// SPI_SETFONTSMOOTHING -> 0x004B
//        SPI_SETFONTSMOOTHING = 75,

//        /// SPI_SETDRAGWIDTH -> 0x004C
//        SPI_SETDRAGWIDTH = 76,

//        /// SPI_SETDRAGHEIGHT -> 0x004D
//        SPI_SETDRAGHEIGHT = 77,

//        /// SPI_SETHANDHELD -> 0x004E
//        SPI_SETHANDHELD = 78,

//        /// SPI_GETLOWPOWERTIMEOUT -> 0x004F
//        SPI_GETLOWPOWERTIMEOUT = 79,

//        /// SPI_GETPOWEROFFTIMEOUT -> 0x0050
//        SPI_GETPOWEROFFTIMEOUT = 80,

//        /// SPI_SETLOWPOWERTIMEOUT -> 0x0051
//        SPI_SETLOWPOWERTIMEOUT = 81,

//        /// SPI_SETPOWEROFFTIMEOUT -> 0x0052
//        SPI_SETPOWEROFFTIMEOUT = 82,

//        /// SPI_GETLOWPOWERACTIVE -> 0x0053
//        SPI_GETLOWPOWERACTIVE = 83,

//        /// SPI_GETPOWEROFFACTIVE -> 0x0054
//        SPI_GETPOWEROFFACTIVE = 84,

//        /// SPI_SETLOWPOWERACTIVE -> 0x0055
//        SPI_SETLOWPOWERACTIVE = 85,

//        /// SPI_SETPOWEROFFACTIVE -> 0x0056
//        SPI_SETPOWEROFFACTIVE = 86,

//        /// SPI_SETCURSORS -> 0x0057
//        SPI_SETCURSORS = 87,

//        /// SPI_SETICONS -> 0x0058
//        SPI_SETICONS = 88,

//        /// SPI_GETDEFAULTINPUTLANG -> 0x0059
//        SPI_GETDEFAULTINPUTLANG = 89,

//        /// SPI_SETDEFAULTINPUTLANG -> 0x005A
//        SPI_SETDEFAULTINPUTLANG = 90,

//        /// SPI_SETLANGTOGGLE -> 0x005B
//        SPI_SETLANGTOGGLE = 91,

//        /// SPI_GETWINDOWSEXTENSION -> 0x005C
//        SPI_GETWINDOWSEXTENSION = 92,

//        /// SPI_SETMOUSETRAILS -> 0x005D
//        SPI_SETMOUSETRAILS = 93,

//        /// SPI_GETMOUSETRAILS -> 0x005E
//        SPI_GETMOUSETRAILS = 94,

//        /// SPI_SETSCREENSAVERRUNNING -> 0x0061
//        SPI_SETSCREENSAVERRUNNING = 97,

//        /// SPI_SCREENSAVERRUNNING -> SPI_SETSCREENSAVERRUNNING
//        SPI_SCREENSAVERRUNNING = SPI_SETSCREENSAVERRUNNING,

//        /// SPI_GETFILTERKEYS -> 0x0032
//        SPI_GETFILTERKEYS = 50,

//        /// SPI_SETFILTERKEYS -> 0x0033
//        SPI_SETFILTERKEYS = 51,

//        /// SPI_GETTOGGLEKEYS -> 0x0034
//        SPI_GETTOGGLEKEYS = 52,

//        /// SPI_SETTOGGLEKEYS -> 0x0035
//        SPI_SETTOGGLEKEYS = 53,

//        /// SPI_GETMOUSEKEYS -> 0x0036
//        SPI_GETMOUSEKEYS = 54,

//        /// SPI_SETMOUSEKEYS -> 0x0037
//        SPI_SETMOUSEKEYS = 55,

//        /// SPI_GETSHOWSOUNDS -> 0x0038
//        SPI_GETSHOWSOUNDS = 56,

//        /// SPI_SETSHOWSOUNDS -> 0x0039
//        SPI_SETSHOWSOUNDS = 57,

//        /// SPI_GETSTICKYKEYS -> 0x003A
//        SPI_GETSTICKYKEYS = 58,

//        /// SPI_SETSTICKYKEYS -> 0x003B
//        SPI_SETSTICKYKEYS = 59,

//        /// SPI_GETACCESSTIMEOUT -> 0x003C
//        SPI_GETACCESSTIMEOUT = 60,

//        /// SPI_SETACCESSTIMEOUT -> 0x003D
//        SPI_SETACCESSTIMEOUT = 61,

//        /// SPI_GETSERIALKEYS -> 0x003E
//        SPI_GETSERIALKEYS = 62,

//        /// SPI_SETSERIALKEYS -> 0x003F
//        SPI_SETSERIALKEYS = 63,

//        /// SPI_GETSOUNDSENTRY -> 0x0040
//        SPI_GETSOUNDSENTRY = 64,

//        /// SPI_SETSOUNDSENTRY -> 0x0041
//        SPI_SETSOUNDSENTRY = 65,

//        /// SPI_GETSNAPTODEFBUTTON -> 0x005F
//        SPI_GETSNAPTODEFBUTTON = 95,

//        /// SPI_SETSNAPTODEFBUTTON -> 0x0060
//        SPI_SETSNAPTODEFBUTTON = 96,

//        /// SPI_GETMOUSEHOVERWIDTH -> 0x0062
//        SPI_GETMOUSEHOVERWIDTH = 98,

//        /// SPI_SETMOUSEHOVERWIDTH -> 0x0063
//        SPI_SETMOUSEHOVERWIDTH = 99,

//        /// SPI_GETMOUSEHOVERHEIGHT -> 0x0064
//        SPI_GETMOUSEHOVERHEIGHT = 100,

//        /// SPI_SETMOUSEHOVERHEIGHT -> 0x0065
//        SPI_SETMOUSEHOVERHEIGHT = 101,

//        /// SPI_GETMOUSEHOVERTIME -> 0x0066
//        SPI_GETMOUSEHOVERTIME = 102,

//        /// SPI_SETMOUSEHOVERTIME -> 0x0067
//        SPI_SETMOUSEHOVERTIME = 103,

//        /// SPI_GETWHEELSCROLLLINES -> 0x0068
//        SPI_GETWHEELSCROLLLINES = 104,

//        /// SPI_SETWHEELSCROLLLINES -> 0x0069
//        SPI_SETWHEELSCROLLLINES = 105,

//        /// SPI_GETMENUSHOWDELAY -> 0x006A
//        SPI_GETMENUSHOWDELAY = 106,

//        /// SPI_SETMENUSHOWDELAY -> 0x006B
//        SPI_SETMENUSHOWDELAY = 107,

//        /// SPI_GETSHOWIMEUI -> 0x006E
//        SPI_GETSHOWIMEUI = 110,

//        /// SPI_SETSHOWIMEUI -> 0x006F
//        SPI_SETSHOWIMEUI = 111,

//        /// SPI_GETMOUSESPEED -> 0x0070
//        SPI_GETMOUSESPEED = 112,

//        /// SPI_SETMOUSESPEED -> 0x0071
//        SPI_SETMOUSESPEED = 113,

//        /// SPI_GETSCREENSAVERRUNNING -> 0x0072
//        SPI_GETSCREENSAVERRUNNING = 114,

//        /// SPI_GETDESKWALLPAPER -> 0x0073
//        SPI_GETDESKWALLPAPER = 115,

//        /// SPI_GETACTIVEWINDOWTRACKING -> 0x1000
//        SPI_GETACTIVEWINDOWTRACKING = 4096,

//        /// SPI_SETACTIVEWINDOWTRACKING -> 0x1001
//        SPI_SETACTIVEWINDOWTRACKING = 4097,

//        /// SPI_GETMENUANIMATION -> 0x1002
//        SPI_GETMENUANIMATION = 4098,

//        /// SPI_SETMENUANIMATION -> 0x1003
//        SPI_SETMENUANIMATION = 4099,

//        /// SPI_GETCOMBOBOXANIMATION -> 0x1004
//        SPI_GETCOMBOBOXANIMATION = 4100,

//        /// SPI_SETCOMBOBOXANIMATION -> 0x1005
//        SPI_SETCOMBOBOXANIMATION = 4101,

//        /// SPI_GETLISTBOXSMOOTHSCROLLING -> 0x1006
//        SPI_GETLISTBOXSMOOTHSCROLLING = 4102,

//        /// SPI_SETLISTBOXSMOOTHSCROLLING -> 0x1007
//        SPI_SETLISTBOXSMOOTHSCROLLING = 4103,

//        /// SPI_GETGRADIENTCAPTIONS -> 0x1008
//        SPI_GETGRADIENTCAPTIONS = 4104,

//        /// SPI_SETGRADIENTCAPTIONS -> 0x1009
//        SPI_SETGRADIENTCAPTIONS = 4105,

//        /// SPI_GETKEYBOARDCUES -> 0x100A
//        SPI_GETKEYBOARDCUES = 4106,

//        /// SPI_SETKEYBOARDCUES -> 0x100B
//        SPI_SETKEYBOARDCUES = 4107,

//        /// SPI_GETMENUUNDERLINES -> SPI_GETKEYBOARDCUES
//        SPI_GETMENUUNDERLINES = SPI_GETKEYBOARDCUES,

//        /// SPI_SETMENUUNDERLINES -> SPI_SETKEYBOARDCUES
//        SPI_SETMENUUNDERLINES = SPI_SETKEYBOARDCUES,

//        /// SPI_GETACTIVEWNDTRKZORDER -> 0x100C
//        SPI_GETACTIVEWNDTRKZORDER = 4108,

//        /// SPI_SETACTIVEWNDTRKZORDER -> 0x100D
//        SPI_SETACTIVEWNDTRKZORDER = 4109,

//        /// SPI_GETHOTTRACKING -> 0x100E
//        SPI_GETHOTTRACKING = 4110,

//        /// SPI_SETHOTTRACKING -> 0x100F
//        SPI_SETHOTTRACKING = 4111,

//        /// SPI_GETMENUFADE -> 0x1012
//        SPI_GETMENUFADE = 4114,

//        /// SPI_SETMENUFADE -> 0x1013
//        SPI_SETMENUFADE = 4115,

//        /// SPI_GETSELECTIONFADE -> 0x1014
//        SPI_GETSELECTIONFADE = 4116,

//        /// SPI_SETSELECTIONFADE -> 0x1015
//        SPI_SETSELECTIONFADE = 4117,

//        /// SPI_GETTOOLTIPANIMATION -> 0x1016
//        SPI_GETTOOLTIPANIMATION = 4118,

//        /// SPI_SETTOOLTIPANIMATION -> 0x1017
//        SPI_SETTOOLTIPANIMATION = 4119,

//        /// SPI_GETTOOLTIPFADE -> 0x1018
//        SPI_GETTOOLTIPFADE = 4120,

//        /// SPI_SETTOOLTIPFADE -> 0x1019
//        SPI_SETTOOLTIPFADE = 4121,

//        /// SPI_GETCURSORSHADOW -> 0x101A
//        SPI_GETCURSORSHADOW = 4122,

//        /// SPI_SETCURSORSHADOW -> 0x101B
//        SPI_SETCURSORSHADOW = 4123,

//        /// SPI_GETMOUSESONAR -> 0x101C
//        SPI_GETMOUSESONAR = 4124,

//        /// SPI_SETMOUSESONAR -> 0x101D
//        SPI_SETMOUSESONAR = 4125,

//        /// SPI_GETMOUSECLICKLOCK -> 0x101E
//        SPI_GETMOUSECLICKLOCK = 4126,

//        /// SPI_SETMOUSECLICKLOCK -> 0x101F
//        SPI_SETMOUSECLICKLOCK = 4127,

//        /// SPI_GETMOUSEVANISH -> 0x1020
//        SPI_GETMOUSEVANISH = 4128,

//        /// SPI_SETMOUSEVANISH -> 0x1021
//        SPI_SETMOUSEVANISH = 4129,

//        /// SPI_GETFLATMENU -> 0x1022
//        SPI_GETFLATMENU = 4130,

//        /// SPI_SETFLATMENU -> 0x1023
//        SPI_SETFLATMENU = 4131,

//        /// SPI_GETDROPSHADOW -> 0x1024
//        SPI_GETDROPSHADOW = 4132,

//        /// SPI_SETDROPSHADOW -> 0x1025
//        SPI_SETDROPSHADOW = 4133,

//        /// SPI_GETBLOCKSENDINPUTRESETS -> 0x1026
//        SPI_GETBLOCKSENDINPUTRESETS = 4134,

//        /// SPI_SETBLOCKSENDINPUTRESETS -> 0x1027
//        SPI_SETBLOCKSENDINPUTRESETS = 4135,

//        /// SPI_GETUIEFFECTS -> 0x103E
//        SPI_GETUIEFFECTS = 4158,

//        /// SPI_SETUIEFFECTS -> 0x103F
//        SPI_SETUIEFFECTS = 4159,

//        /// SPI_GETFOREGROUNDLOCKTIMEOUT -> 0x2000
//        SPI_GETFOREGROUNDLOCKTIMEOUT = 8192,

//        /// SPI_SETFOREGROUNDLOCKTIMEOUT -> 0x2001
//        SPI_SETFOREGROUNDLOCKTIMEOUT = 8193,

//        /// SPI_GETACTIVEWNDTRKTIMEOUT -> 0x2002
//        SPI_GETACTIVEWNDTRKTIMEOUT = 8194,

//        /// SPI_SETACTIVEWNDTRKTIMEOUT -> 0x2003
//        SPI_SETACTIVEWNDTRKTIMEOUT = 8195,

//        /// SPI_GETFOREGROUNDFLASHCOUNT -> 0x2004
//        SPI_GETFOREGROUNDFLASHCOUNT = 8196,

//        /// SPI_SETFOREGROUNDFLASHCOUNT -> 0x2005
//        SPI_SETFOREGROUNDFLASHCOUNT = 8197,

//        /// SPI_GETCARETWIDTH -> 0x2006
//        SPI_GETCARETWIDTH = 8198,

//        /// SPI_SETCARETWIDTH -> 0x2007
//        SPI_SETCARETWIDTH = 8199,

//        /// SPI_GETMOUSECLICKLOCKTIME -> 0x2008
//        SPI_GETMOUSECLICKLOCKTIME = 8200,

//        /// SPI_SETMOUSECLICKLOCKTIME -> 0x2009
//        SPI_SETMOUSECLICKLOCKTIME = 8201,

//        /// SPI_GETFONTSMOOTHINGTYPE -> 0x200A
//        SPI_GETFONTSMOOTHINGTYPE = 8202,

//        /// SPI_SETFONTSMOOTHINGTYPE -> 0x200B
//        SPI_SETFONTSMOOTHINGTYPE = 8203,

//        /// SPI_GETFONTSMOOTHINGCONTRAST -> 0x200C
//        SPI_GETFONTSMOOTHINGCONTRAST = 8204,

//        /// SPI_SETFONTSMOOTHINGCONTRAST -> 0x200D
//        SPI_SETFONTSMOOTHINGCONTRAST = 8205,

//        /// SPI_GETFOCUSBORDERWIDTH -> 0x200E
//        SPI_GETFOCUSBORDERWIDTH = 8206,

//        /// SPI_SETFOCUSBORDERWIDTH -> 0x200F
//        SPI_SETFOCUSBORDERWIDTH = 8207,

//        /// SPI_GETFOCUSBORDERHEIGHT -> 0x2010
//        SPI_GETFOCUSBORDERHEIGHT = 8208,

//        /// SPI_SETFOCUSBORDERHEIGHT -> 0x2011
//        SPI_SETFOCUSBORDERHEIGHT = 8209,

//        /// SPI_GETFONTSMOOTHINGORIENTATION -> 0x2012
//        SPI_GETFONTSMOOTHINGORIENTATION = 8210,

//        /// SPI_SETFONTSMOOTHINGORIENTATION -> 0x2013
//        SPI_SETFONTSMOOTHINGORIENTATION = 8211,

//        /// SPI_GETWHEELSCROLLCHARS -> 0x006C
//        SPI_GETWHEELSCROLLCHARS = 108,

//        /// SPI_SETWHEELSCROLLCHARS -> 0x006D
//        SPI_SETWHEELSCROLLCHARS = 109,

//        /// SPI_GETAUDIODESCRIPTION -> 0x0074
//        SPI_GETAUDIODESCRIPTION = 116,

//        /// SPI_SETAUDIODESCRIPTION -> 0x0075
//        SPI_SETAUDIODESCRIPTION = 117,

//        /// SPI_GETSCREENSAVESECURE -> 0x0076
//        SPI_GETSCREENSAVESECURE = 118,

//        /// SPI_SETSCREENSAVESECURE -> 0x0077
//        SPI_SETSCREENSAVESECURE = 119,

//        /// SPI_GETHUNGAPPTIMEOUT -> 0x0078
//        SPI_GETHUNGAPPTIMEOUT = 120,

//        /// SPI_SETHUNGAPPTIMEOUT -> 0x0079
//        SPI_SETHUNGAPPTIMEOUT = 121,

//        /// SPI_GETWAITTOKILLTIMEOUT -> 0x007A
//        SPI_GETWAITTOKILLTIMEOUT = 122,

//        /// SPI_SETWAITTOKILLTIMEOUT -> 0x007B
//        SPI_SETWAITTOKILLTIMEOUT = 123,

//        /// SPI_GETWAITTOKILLSERVICETIMEOUT -> 0x007C
//        SPI_GETWAITTOKILLSERVICETIMEOUT = 124,

//        /// SPI_SETWAITTOKILLSERVICETIMEOUT -> 0x007D
//        SPI_SETWAITTOKILLSERVICETIMEOUT = 125,

//        /// SPI_GETMOUSEDOCKTHRESHOLD -> 0x007E
//        SPI_GETMOUSEDOCKTHRESHOLD = 126,

//        /// SPI_SETMOUSEDOCKTHRESHOLD -> 0x007F
//        SPI_SETMOUSEDOCKTHRESHOLD = 127,

//        /// SPI_GETPENDOCKTHRESHOLD -> 0x0080
//        SPI_GETPENDOCKTHRESHOLD = 128,

//        /// SPI_SETPENDOCKTHRESHOLD -> 0x0081
//        SPI_SETPENDOCKTHRESHOLD = 129,

//        /// SPI_GETWINARRANGING -> 0x0082
//        SPI_GETWINARRANGING = 130,

//        /// SPI_SETWINARRANGING -> 0x0083
//        SPI_SETWINARRANGING = 131,

//        /// SPI_GETMOUSEDRAGOUTTHRESHOLD -> 0x0084
//        SPI_GETMOUSEDRAGOUTTHRESHOLD = 132,

//        /// SPI_SETMOUSEDRAGOUTTHRESHOLD -> 0x0085
//        SPI_SETMOUSEDRAGOUTTHRESHOLD = 133,

//        /// SPI_GETPENDRAGOUTTHRESHOLD -> 0x0086
//        SPI_GETPENDRAGOUTTHRESHOLD = 134,

//        /// SPI_SETPENDRAGOUTTHRESHOLD -> 0x0087
//        SPI_SETPENDRAGOUTTHRESHOLD = 135,

//        /// SPI_GETMOUSESIDEMOVETHRESHOLD -> 0x0088
//        SPI_GETMOUSESIDEMOVETHRESHOLD = 136,

//        /// SPI_SETMOUSESIDEMOVETHRESHOLD -> 0x0089
//        SPI_SETMOUSESIDEMOVETHRESHOLD = 137,

//        /// SPI_GETPENSIDEMOVETHRESHOLD -> 0x008A
//        SPI_GETPENSIDEMOVETHRESHOLD = 138,

//        /// SPI_SETPENSIDEMOVETHRESHOLD -> 0x008B
//        SPI_SETPENSIDEMOVETHRESHOLD = 139,

//        /// SPI_GETDRAGFROMMAXIMIZE -> 0x008C
//        SPI_GETDRAGFROMMAXIMIZE = 140,

//        /// SPI_SETDRAGFROMMAXIMIZE -> 0x008D
//        SPI_SETDRAGFROMMAXIMIZE = 141,

//        /// SPI_GETSNAPSIZING -> 0x008E
//        SPI_GETSNAPSIZING = 142,

//        /// SPI_SETSNAPSIZING -> 0x008F
//        SPI_SETSNAPSIZING = 143,

//        /// SPI_GETDOCKMOVING -> 0x0090
//        SPI_GETDOCKMOVING = 144,

//        /// SPI_SETDOCKMOVING -> 0x0091
//        SPI_SETDOCKMOVING = 145,

//        /// SPI_GETDISABLEOVERLAPPEDCONTENT -> 0x1040
//        SPI_GETDISABLEOVERLAPPEDCONTENT = 4160,

//        /// SPI_SETDISABLEOVERLAPPEDCONTENT -> 0x1041
//        SPI_SETDISABLEOVERLAPPEDCONTENT = 4161,

//        /// SPI_GETCLIENTAREAANIMATION -> 0x1042
//        SPI_GETCLIENTAREAANIMATION = 4162,

//        /// SPI_SETCLIENTAREAANIMATION -> 0x1043
//        SPI_SETCLIENTAREAANIMATION = 4163,

//        /// SPI_GETCLEARTYPE -> 0x1048
//        SPI_GETCLEARTYPE = 4168,

//        /// SPI_SETCLEARTYPE -> 0x1049
//        SPI_SETCLEARTYPE = 4169,

//        /// SPI_GETSPEECHRECOGNITION -> 0x104A
//        SPI_GETSPEECHRECOGNITION = 4170,

//        /// SPI_SETSPEECHRECOGNITION -> 0x104B
//        SPI_SETSPEECHRECOGNITION = 4171,

//        /// SPI_GETMINIMUMHITRADIUS -> 0x2014
//        SPI_GETMINIMUMHITRADIUS = 8212,

//        /// SPI_SETMINIMUMHITRADIUS -> 0x2015
//        SPI_SETMINIMUMHITRADIUS = 8213,

//        /// SPI_GETMESSAGEDURATION -> 0x2016
//        SPI_GETMESSAGEDURATION = 8214,

//        /// SPI_SETMESSAGEDURATION -> 0x2017
//        SPI_SETMESSAGEDURATION = 8215,

//    }

//    public enum FE
//    {
//        /// FE_FONTSMOOTHINGORIENTATIONBGR -> 0x0000
//        FE_FONTSMOOTHINGORIENTATIONBGR = 0,

//        /// FE_FONTSMOOTHINGORIENTATIONRGB -> 0x0001
//        FE_FONTSMOOTHINGORIENTATIONRGB = 1,

//        /// FE_FONTSMOOTHINGSTANDARD -> 0x0001
//        FE_FONTSMOOTHINGSTANDARD = 1,

//        /// FE_FONTSMOOTHINGCLEARTYPE -> 0x0002
//        FE_FONTSMOOTHINGCLEARTYPE = 2
//    }

//    public enum COLOR
//    {
//        /// COLOR_SCROLLBAR -> 0
//        COLOR_SCROLLBAR = 0,

//        /// COLOR_BACKGROUND -> 1
//        COLOR_BACKGROUND = 1,

//        /// COLOR_ACTIVECAPTION -> 2
//        COLOR_ACTIVECAPTION = 2,

//        /// COLOR_INACTIVECAPTION -> 3
//        COLOR_INACTIVECAPTION = 3,

//        /// COLOR_MENU -> 4
//        COLOR_MENU = 4,

//        /// COLOR_WINDOW -> 5
//        COLOR_WINDOW = 5,

//        /// COLOR_WINDOWFRAME -> 6
//        COLOR_WINDOWFRAME = 6,

//        /// COLOR_MENUTEXT -> 7
//        COLOR_MENUTEXT = 7,

//        /// COLOR_WINDOWTEXT -> 8
//        COLOR_WINDOWTEXT = 8,

//        /// COLOR_CAPTIONTEXT -> 9
//        COLOR_CAPTIONTEXT = 9,

//        /// COLOR_ACTIVEBORDER -> 10
//        COLOR_ACTIVEBORDER = 10,

//        /// COLOR_INACTIVEBORDER -> 11
//        COLOR_INACTIVEBORDER = 11,

//        /// COLOR_APPWORKSPACE -> 12
//        COLOR_APPWORKSPACE = 12,

//        /// COLOR_HIGHLIGHT -> 13
//        COLOR_HIGHLIGHT = 13,

//        /// COLOR_HIGHLIGHTTEXT -> 14
//        COLOR_HIGHLIGHTTEXT = 14,

//        /// COLOR_BTNFACE -> 15
//        COLOR_BTNFACE = 15,

//        /// COLOR_BTNSHADOW -> 16
//        COLOR_BTNSHADOW = 16,

//        /// COLOR_GRAYTEXT -> 17
//        COLOR_GRAYTEXT = 17,

//        /// COLOR_BTNTEXT -> 18
//        COLOR_BTNTEXT = 18,

//        /// COLOR_INACTIVECAPTIONTEXT -> 19
//        COLOR_INACTIVECAPTIONTEXT = 19,

//        /// COLOR_BTNHIGHLIGHT -> 20
//        COLOR_BTNHIGHLIGHT = 20,

//        /// COLOR_3DDKSHADOW -> 21
//        COLOR_3DDKSHADOW = 21,

//        /// COLOR_3DLIGHT -> 22
//        COLOR_3DLIGHT = 22,

//        /// COLOR_INFOTEXT -> 23
//        COLOR_INFOTEXT = 23,

//        /// COLOR_INFOBK -> 24
//        COLOR_INFOBK = 24,

//        /// COLOR_HOTLIGHT -> 26
//        COLOR_HOTLIGHT = 26,

//        /// COLOR_GRADIENTACTIVECAPTION -> 27
//        COLOR_GRADIENTACTIVECAPTION = 27,

//        /// COLOR_GRADIENTINACTIVECAPTION -> 28
//        COLOR_GRADIENTINACTIVECAPTION = 28,

//        /// COLOR_MENUHILIGHT -> 29
//        COLOR_MENUHILIGHT = 29,

//        /// COLOR_MENUBAR -> 30
//        COLOR_MENUBAR = 30,

//        /// COLOR_DESKTOP -> COLOR_BACKGROUND
//        COLOR_DESKTOP = COLOR_BACKGROUND,

//        /// COLOR_3DFACE -> COLOR_BTNFACE
//        COLOR_3DFACE = COLOR_BTNFACE,

//        /// COLOR_3DSHADOW -> COLOR_BTNSHADOW
//        COLOR_3DSHADOW = COLOR_BTNSHADOW,

//        /// COLOR_3DHIGHLIGHT -> COLOR_BTNHIGHLIGHT
//        COLOR_3DHIGHLIGHT = COLOR_BTNHIGHLIGHT,

//        /// COLOR_3DHILIGHT -> COLOR_BTNHIGHLIGHT
//        COLOR_3DHILIGHT = COLOR_BTNHIGHLIGHT,

//        /// COLOR_BTNHILIGHT -> COLOR_BTNHIGHLIGHT
//        COLOR_BTNHILIGHT = COLOR_BTNHIGHLIGHT,
//    }

//    public enum HKL
//    {
//        HKL_PREF = 0,
//        HKL_NEXT = 1
//    }

//    /// <summary>
//    ///     The weight of the font in the range 0 through 1000. For example, 400 is normal and 700 is bold. If this value is zero, a default weight is
//    ///     used.
//    /// </summary>
//    public enum FW
//    {
//        /// <summary>Don't care about the font weight.</summary>
//        FW_DONTCARE = 0,

//        /// <summary>Specifies a thin font weight.</summary>
//        FW_THIN = 100,

//        /// <summary>Specifies an extra light font weight.</summary>
//        FW_EXTRALIGHT = 200,

//        /// <summary>Specifies a light font weight.</summary>
//        FW_LIGHT = 300,

//        /// <summary>Specifies a normal font weight.</summary>
//        FW_NORMAL = 400,

//        /// <summary>Specifies a medium font weight.</summary>
//        FW_MEDIUM = 500,

//        /// <summary>Specifies a semi-bold font weight.</summary>
//        FW_SEMIBOLD = 600,

//        /// <summary>Specifies a bold font weight.</summary>
//        FW_BOLD = 700,

//        /// <summary>Specifies an extra-bold font weight.</summary>
//        FW_EXTRABOLD = 800,

//        /// <summary>Specifies a heavy font weight.</summary>
//        FW_HEAVY = 900,
//    }

//    /// <summary>
//    ///     The <see cref="CHARSET" /> Enumeration defines the possible sets of character glyphs that are defined in fonts for graphics output.
//    /// </summary>
//    public enum CHARSET : byte
//    {
//        /// <summary>Specifies the English character set.</summary>
//        ANSI_CHARSET = 0,

//        /// <summary>
//        ///     Specifies a character set based on the current system locale; for example, when the system locale is United States English, the default character
//        ///     set is <see cref="ANSI_CHARSET" />.
//        /// </summary>
//        DEFAULT_CHARSET = 1,

//        /// <summary>Specifies a character set of symbols.</summary>
//        SYMBOL_CHARSET = 2,

//        /// <summary>Specifies the Japanese character set.</summary>
//        SHIFTJIS_CHARSET = 128,

//        /// <summary>Specifies the Hangul Korean character set.</summary>
//        HANGEUL_CHARSET = 129,

//        /// <summary>Also spelled "Hangeul". Specifies the Hangul Korean character set.</summary>
//        HANGUL_CHARSET = 129,

//        /// <summary>Specifies the "simplified" Chinese character set for People's Republic of China.</summary>
//        GB2312_CHARSET = 134,

//        /// <summary>Specifies the "traditional" Chinese character set, used mostly in Taiwan and in the Hong Kong and Macao Special Administrative Regions.</summary>
//        CHINESEBIG5_CHARSET = 136,

//        /// <summary>Specifies a mapping to one of the OEM code pages, according to the current system locale setting.</summary>
//        OEM_CHARSET = 255,

//        /// <summary>Also spelled "Johap". Specifies the Johab Korean character set.</summary>
//        JOHAB_CHARSET = 130,

//        /// <summary>Specifies the Hebrew character set.</summary>
//        HEBREW_CHARSET = 177,

//        /// <summary>Specifies the Arabic character set.</summary>
//        ARABIC_CHARSET = 178,

//        /// <summary>Specifies the Greek character set.</summary>
//        GREEK_CHARSET = 161,

//        /// <summary>Specifies the Turkish character set.</summary>
//        TURKISH_CHARSET = 162,

//        /// <summary>Specifies the Vietnamese character set.</summary>
//        VIETNAMESE_CHARSET = 163,

//        /// <summary>Specifies the Thai character set.</summary>
//        THAI_CHARSET = 222,

//        /// <summary>Specifies a Eastern European character set.</summary>
//        EASTEUROPE_CHARSET = 238,

//        /// <summary>Specifies the Russian Cyrillic character set.</summary>
//        RUSSIAN_CHARSET = 204,

//        /// <summary>Specifies the Apple Macintosh character set.</summary>
//        MAC_CHARSET = 77,

//        /// <summary>Specifies the Baltic (Northeastern European) character set</summary>
//        BALTIC_CHARSET = 186,
//    }

//    /// <summary>
//    ///     The output precision. The output precision defines how closely the output must match the requested font's height, width, character orientation,
//    ///     escapement, pitch, and font type.
//    /// </summary>
//    public enum PRECIS : byte
//    {
//        /// <summary>The default font mapper behavior.</summary>
//        OUT_DEFAULT_PRECIS = 0,

//        /// <summary>This value is not used by the font mapper, but it is returned when raster fonts are enumerated.</summary>
//        OUT_STRING_PRECIS = 1,

//        /// <summary>Not used.</summary>
//        OUT_CHARACTER_PRECIS = 2,

//        /// <summary>This value is not used by the font mapper, but it is returned when TrueType, other outline-based fonts, and vector fonts are enumerated.</summary>
//        OUT_STROKE_PRECIS = 3,

//        /// <summary>Instructs the font mapper to choose a TrueType font when the system contains multiple fonts with the same name.</summary>
//        OUT_TT_PRECIS = 4,

//        /// <summary>Instructs the font mapper to choose a Device font when the system contains multiple fonts with the same name.</summary>
//        OUT_DEVICE_PRECIS = 5,

//        /// <summary>Instructs the font mapper to choose a raster font when the system contains multiple fonts with the same name.</summary>
//        OUT_RASTER_PRECIS = 6,

//        /// <summary>
//        ///     Instructs the font mapper to choose from only TrueType fonts. If there are no TrueType fonts installed in the system, the font mapper returns to
//        ///     default behavior.
//        /// </summary>
//        OUT_TT_ONLY_PRECIS = 7,

//        /// <summary>This value instructs the font mapper to choose from TrueType and other outline-based fonts.</summary>
//        OUT_OUTLINE_PRECIS = 8,

//        /// <summary>A value that specifies a preference for TrueType and other outline fonts.</summary>
//        OUT_SCREEN_OUTLINE_PRECIS = 9,

//        /// <summary>
//        ///     Instructs the font mapper to choose from only PostScript fonts. If there are no PostScript fonts installed in the system, the font mapper returns
//        ///     to default behavior.
//        /// </summary>
//        OUT_PS_ONLY_PRECIS = 10,
//    }

//    /// <summary>The clipping precision. The clipping precision defines how to clip characters that are partially outside the clipping region.</summary>
//    public enum CLIP : byte
//    {
//        /// <summary>Not used.</summary>
//        CLIP_DEFAULT_PRECIS = 0,

//        /// <summary>Specifies default clipping behavior.</summary>
//        CLIP_CHARACTER_PRECIS = 1,

//        /// <summary>
//        ///     <para>Not used by the font mapper, but is returned when raster, vector, or TrueType fonts are enumerated.</para>
//        ///     <para>For compatibility, this value is always returned when enumerating fonts.</para>
//        /// </summary>
//        CLIP_STROKE_PRECIS = 2,

//        /// <summary>Not used.</summary>
//        CLIP_MASK = 0xf,

//        /// <summary>
//        ///     <para>
//        ///         When this value is used, the rotation for all fonts depends on whether the orientation of the coordinate system is left-handed or
//        ///         right-handed.
//        ///     </para>
//        ///     <para>
//        ///         If not used, device fonts always rotate counterclockwise, but the rotation of other fonts is dependent on the orientation of the coordinate
//        ///         system.
//        ///     </para>
//        ///     <para>For more information about the orientation of coordinate systems, see the description of the nOrientation parameter.</para>
//        /// </summary>
//        CLIP_LH_ANGLES = (1 << 4),

//        /// <summary>Not used.</summary>
//        CLIP_TT_ALWAYS = (2 << 4),

//        /// <summary>
//        ///     Windows XP SP1: Turns off font association for the font. Note that this flag is not guaranteed to have any effect on any platform after Windows
//        ///     Server 2003.
//        /// </summary>
//        CLIP_DFA_DISABLE = (4 << 4),

//        /// <summary>You must specify this flag to use an embedded read-only font.</summary>
//        CLIP_EMBEDDED = (8 << 4),
//    }

//    /// <summary>
//    ///     The <see cref="QUALITY" /> Enumeration specifies how closely the attributes of the logical font should match those of the physical font when
//    ///     rendering text.
//    /// </summary>
//    public enum QUALITY : byte
//    {
//        /// <summary>
//        ///     Specifies that the character quality of the font does not matter, so <see cref="DRAFT_QUALITY" /> can be used.
//        /// </summary>
//        DEFAULT_QUALITY = 0,

//        /// <summary>
//        ///     Specifies that the character quality of the font is less important than the matching of logical attributes. For rasterized fonts, scaling SHOULD
//        ///     be enabled, which means that more font sizes are available.
//        /// </summary>
//        DRAFT_QUALITY = 1,

//        /// <summary>
//        ///     Specifies that the character quality of the font is more important than the matching of logical attributes. For rasterized fonts, scaling SHOULD
//        ///     be disabled, and the font closest in size SHOULD be chosen.
//        /// </summary>
//        PROOF_QUALITY = 2,

//        /// <summary>Specifies that anti-aliasing SHOULD NOT be used when rendering text.</summary>
//        NONANTIALIASED_QUALITY = 3,

//        /// <summary>Specifies that anti-aliasing SHOULD be used when rendering text, if the font supports it.</summary>
//        ANTIALIASED_QUALITY = 4,

//        /// <summary>Specifies that ClearType anti-aliasing SHOULD be used when rendering text, if the font supports it.</summary>
//        CLEARTYPE_QUALITY = 5,

//        /// <summary>Specifies that high-quality ClearType anti-aliasing SHOULD be used when rendering text, if the font supports it.</summary>
//        CLEARTYPE_NATURAL_QUALITY = 6,
//    }

//    /// <summary>
//    ///     The PitchFont enumeration defines values that are used for specifying characteristics of a font. The values are used to indicate whether the
//    ///     characters in a font have a fixed or variable width, or pitch.
//    /// </summary>
//    [Flags]
//    public enum PITCH_FAMILY : byte
//    {
//        /// <summary>The default pitch, which is implementation-dependent.</summary>
//        DEFAULT_PITCH = 0,

//        /// <summary>A fixed pitch, which means that all the characters in the font occupy the same width when output in a string.</summary>
//        FIXED_PITCH = 1,

//        /// <summary>
//        ///     A variable pitch, which means that the characters in the font occupy widths that are proportional to the actual widths of the glyphs when output
//        ///     in a string. For example, the "i" and space characters usually have much smaller widths than a "W" or "O" character.
//        /// </summary>
//        VARIABLE_PITCH = 2,

//        /// <summary>Specifies that we don't care about the font family.</summary>
//        FF_DONTCARE = (0 << 4),

//        /// <summary>Specifies a Roman font family.</summary>
//        FF_ROMAN = (1 << 4),

//        /// <summary>Specifies a Swiss font family.</summary>
//        FF_SWISS = (2 << 4),

//        /// <summary>Specifies a Modern font family.</summary>
//        FF_MODERN = (3 << 4),

//        /// <summary>Specifies a Script font family.</summary>
//        FF_SCRIPT = (4 << 4),

//        /// <summary>Species a Decorative font family.</summary>
//        FF_DECORATIVE = (5 << 4),
//    }

//    public enum EC
//    {

//        /// EC_ENABLEALL -> 0
//        EC_ENABLEALL = 0,

//        /// EC_ENABLEONE -> ST_BLOCKNEXT
//        EC_ENABLEONE = ST.ST_BLOCKNEXT,

//        /// EC_DISABLE -> ST_BLOCKED
//        EC_DISABLE = ST.ST_BLOCKED,

//        /// EC_QUERYWAITING -> 2
//        EC_QUERYWAITING = 2,
//    }

//    public enum GMEM
//    {
//        /// GMEM_FIXED -> 0x0000
//        GMEM_FIXED = 0,

//        /// GMEM_MOVEABLE -> 0x0002
//        GMEM_MOVEABLE = 2,

//        /// GMEM_NOCOMPACT -> 0x0010
//        GMEM_NOCOMPACT = 16,

//        /// GMEM_NODISCARD -> 0x0020
//        GMEM_NODISCARD = 32,

//        /// GMEM_ZEROINIT -> 0x0040
//        GMEM_ZEROINIT = 64,

//        /// GMEM_MODIFY -> 0x0080
//        GMEM_MODIFY = 128,

//        /// GMEM_DISCARDABLE -> 0x0100
//        GMEM_DISCARDABLE = 256,

//        /// GMEM_NOT_BANKED -> 0x1000
//        GMEM_NOT_BANKED = 4096,

//        /// GMEM_SHARE -> 0x2000
//        GMEM_SHARE = 8192,

//        /// GMEM_DDESHARE -> 0x2000
//        GMEM_DDESHARE = 8192,

//        /// GMEM_NOTIFY -> 0x4000
//        GMEM_NOTIFY = 16384,

//        /// GMEM_LOWER -> GMEM_NOT_BANKED
//        GMEM_LOWER = GMEM_NOT_BANKED,

//        /// GMEM_VALID_FLAGS -> 0x7F72
//        GMEM_VALID_FLAGS = 32626,

//        /// GMEM_INVALID_HANDLE -> 0x8000
//        GMEM_INVALID_HANDLE = 32768,

//    }

//    public enum CF
//    {
//        /// CF_TEXT -> 1
//        CF_TEXT = 1,

//        /// CF_BITMAP -> 2
//        CF_BITMAP = 2,

//        /// CF_METAFILEPICT -> 3
//        CF_METAFILEPICT = 3,

//        /// CF_SYLK -> 4
//        CF_SYLK = 4,

//        /// CF_DIF -> 5
//        CF_DIF = 5,

//        /// CF_TIFF -> 6
//        CF_TIFF = 6,

//        /// CF_OEMTEXT -> 7
//        CF_OEMTEXT = 7,

//        /// CF_DIB -> 8
//        CF_DIB = 8,

//        /// CF_PALETTE -> 9
//        CF_PALETTE = 9,

//        /// CF_PENDATA -> 10
//        CF_PENDATA = 10,

//        /// CF_RIFF -> 11
//        CF_RIFF = 11,

//        /// CF_WAVE -> 12
//        CF_WAVE = 12,

//        /// CF_UNICODETEXT -> 13
//        CF_UNICODETEXT = 13,

//        /// CF_ENHMETAFILE -> 14
//        CF_ENHMETAFILE = 14,

//        /// CF_HDROP -> 15
//        CF_HDROP = 15,

//        /// CF_LOCALE -> 16
//        CF_LOCALE = 16,

//        /// CF_DIBV5 -> 17
//        CF_DIBV5 = 17,

//        /// CF_OWNERDISPLAY -> 0x0080
//        CF_OWNERDISPLAY = 128,

//        /// CF_DSPTEXT -> 0x0081
//        CF_DSPTEXT = 129,

//        /// CF_DSPBITMAP -> 0x0082
//        CF_DSPBITMAP = 130,

//        /// CF_DSPMETAFILEPICT -> 0x0083
//        CF_DSPMETAFILEPICT = 131,

//        /// CF_DSPENHMETAFILE -> 0x008E
//        CF_DSPENHMETAFILE = 142,

//        /// CF_PRIVATEFIRST -> 0x0200
//        CF_PRIVATEFIRST = 512,

//        /// CF_PRIVATELAST -> 0x02FF
//        CF_PRIVATELAST = 767,

//        /// CF_GDIOBJFIRST -> 0x0300
//        CF_GDIOBJFIRST = 768,

//        /// CF_GDIOBJLAST -> 0x03FF
//        CF_GDIOBJLAST = 1023,

//    }

//    public enum VK
//    {
//        /// VK_LBUTTON -> 0x01
//        VK_LBUTTON = 1,

//        /// VK_RBUTTON -> 0x02
//        VK_RBUTTON = 2,

//        /// VK_CANCEL -> 0x03
//        VK_CANCEL = 3,

//        /// VK_MBUTTON -> 0x04
//        VK_MBUTTON = 4,

//        /// VK_XBUTTON1 -> 0x05
//        VK_XBUTTON1 = 5,

//        /// VK_XBUTTON2 -> 0x06
//        VK_XBUTTON2 = 6,

//        /// VK_BACK -> 0x08
//        VK_BACK = 8,

//        /// VK_TAB -> 0x09
//        VK_TAB = 9,

//        /// VK_CLEAR -> 0x0C
//        VK_CLEAR = 12,

//        /// VK_RETURN -> 0x0D
//        VK_RETURN = 13,

//        /// VK_SHIFT -> 0x10
//        VK_SHIFT = 16,

//        /// VK_CONTROL -> 0x11
//        VK_CONTROL = 17,

//        /// VK_MENU -> 0x12
//        VK_MENU = 18,

//        /// VK_PAUSE -> 0x13
//        VK_PAUSE = 19,

//        /// VK_CAPITAL -> 0x14
//        VK_CAPITAL = 20,

//        /// VK_KANA -> 0x15
//        VK_KANA = 21,

//        /// VK_HANGEUL -> 0x15
//        VK_HANGEUL = 21,

//        /// VK_HANGUL -> 0x15
//        VK_HANGUL = 21,

//        /// VK_JUNJA -> 0x17
//        VK_JUNJA = 23,

//        /// VK_FINAL -> 0x18
//        VK_FINAL = 24,

//        /// VK_HANJA -> 0x19
//        VK_HANJA = 25,

//        /// VK_KANJI -> 0x19
//        VK_KANJI = 25,

//        /// VK_ESCAPE -> 0x1B
//        VK_ESCAPE = 27,

//        /// VK_CONVERT -> 0x1C
//        VK_CONVERT = 28,

//        /// VK_NONCONVERT -> 0x1D
//        VK_NONCONVERT = 29,

//        /// VK_ACCEPT -> 0x1E
//        VK_ACCEPT = 30,

//        /// VK_MODECHANGE -> 0x1F
//        VK_MODECHANGE = 31,

//        /// VK_SPACE -> 0x20
//        VK_SPACE = 32,

//        /// VK_PRIOR -> 0x21
//        VK_PRIOR = 33,

//        /// VK_NEXT -> 0x22
//        VK_NEXT = 34,

//        /// VK_END -> 0x23
//        VK_END = 35,

//        /// VK_HOME -> 0x24
//        VK_HOME = 36,

//        /// VK_LEFT -> 0x25
//        VK_LEFT = 37,

//        /// VK_UP -> 0x26
//        VK_UP = 38,

//        /// VK_RIGHT -> 0x27
//        VK_RIGHT = 39,

//        /// VK_DOWN -> 0x28
//        VK_DOWN = 40,

//        /// VK_SELECT -> 0x29
//        VK_SELECT = 41,

//        /// VK_PRINT -> 0x2A
//        VK_PRINT = 42,

//        /// VK_EXECUTE -> 0x2B
//        VK_EXECUTE = 43,

//        /// VK_SNAPSHOT -> 0x2C
//        VK_SNAPSHOT = 44,

//        /// VK_INSERT -> 0x2D
//        VK_INSERT = 45,

//        /// VK_DELETE -> 0x2E
//        VK_DELETE = 46,

//        /// VK_HELP -> 0x2F
//        VK_HELP = 47,

//        /// VK_LWIN -> 0x5B
//        VK_LWIN = 91,

//        /// VK_RWIN -> 0x5C
//        VK_RWIN = 92,

//        /// VK_APPS -> 0x5D
//        VK_APPS = 93,

//        /// VK_SLEEP -> 0x5F
//        VK_SLEEP = 95,

//        /// VK_NUMPAD0 -> 0x60
//        VK_NUMPAD0 = 96,

//        /// VK_NUMPAD1 -> 0x61
//        VK_NUMPAD1 = 97,

//        /// VK_NUMPAD2 -> 0x62
//        VK_NUMPAD2 = 98,

//        /// VK_NUMPAD3 -> 0x63
//        VK_NUMPAD3 = 99,

//        /// VK_NUMPAD4 -> 0x64
//        VK_NUMPAD4 = 100,

//        /// VK_NUMPAD5 -> 0x65
//        VK_NUMPAD5 = 101,

//        /// VK_NUMPAD6 -> 0x66
//        VK_NUMPAD6 = 102,

//        /// VK_NUMPAD7 -> 0x67
//        VK_NUMPAD7 = 103,

//        /// VK_NUMPAD8 -> 0x68
//        VK_NUMPAD8 = 104,

//        /// VK_NUMPAD9 -> 0x69
//        VK_NUMPAD9 = 105,

//        /// VK_MULTIPLY -> 0x6A
//        VK_MULTIPLY = 106,

//        /// VK_ADD -> 0x6B
//        VK_ADD = 107,

//        /// VK_SEPARATOR -> 0x6C
//        VK_SEPARATOR = 108,

//        /// VK_SUBTRACT -> 0x6D
//        VK_SUBTRACT = 109,

//        /// VK_DECIMAL -> 0x6E
//        VK_DECIMAL = 110,

//        /// VK_DIVIDE -> 0x6F
//        VK_DIVIDE = 111,

//        /// VK_F1 -> 0x70
//        VK_F1 = 112,

//        /// VK_F2 -> 0x71
//        VK_F2 = 113,

//        /// VK_F3 -> 0x72
//        VK_F3 = 114,

//        /// VK_F4 -> 0x73
//        VK_F4 = 115,

//        /// VK_F5 -> 0x74
//        VK_F5 = 116,

//        /// VK_F6 -> 0x75
//        VK_F6 = 117,

//        /// VK_F7 -> 0x76
//        VK_F7 = 118,

//        /// VK_F8 -> 0x77
//        VK_F8 = 119,

//        /// VK_F9 -> 0x78
//        VK_F9 = 120,

//        /// VK_F10 -> 0x79
//        VK_F10 = 121,

//        /// VK_F11 -> 0x7A
//        VK_F11 = 122,

//        /// VK_F12 -> 0x7B
//        VK_F12 = 123,

//        /// VK_F13 -> 0x7C
//        VK_F13 = 124,

//        /// VK_F14 -> 0x7D
//        VK_F14 = 125,

//        /// VK_F15 -> 0x7E
//        VK_F15 = 126,

//        /// VK_F16 -> 0x7F
//        VK_F16 = 127,

//        /// VK_F17 -> 0x80
//        VK_F17 = 128,

//        /// VK_F18 -> 0x81
//        VK_F18 = 129,

//        /// VK_F19 -> 0x82
//        VK_F19 = 130,

//        /// VK_F20 -> 0x83
//        VK_F20 = 131,

//        /// VK_F21 -> 0x84
//        VK_F21 = 132,

//        /// VK_F22 -> 0x85
//        VK_F22 = 133,

//        /// VK_F23 -> 0x86
//        VK_F23 = 134,

//        /// VK_F24 -> 0x87
//        VK_F24 = 135,

//        /// VK_NUMLOCK -> 0x90
//        VK_NUMLOCK = 144,

//        /// VK_SCROLL -> 0x91
//        VK_SCROLL = 145,

//        /// VK_OEM_NEC_EQUAL -> 0x92
//        VK_OEM_NEC_EQUAL = 146,

//        /// VK_OEM_FJ_JISHO -> 0x92
//        VK_OEM_FJ_JISHO = 146,

//        /// VK_OEM_FJ_MASSHOU -> 0x93
//        VK_OEM_FJ_MASSHOU = 147,

//        /// VK_OEM_FJ_TOUROKU -> 0x94
//        VK_OEM_FJ_TOUROKU = 148,

//        /// VK_OEM_FJ_LOYA -> 0x95
//        VK_OEM_FJ_LOYA = 149,

//        /// VK_OEM_FJ_ROYA -> 0x96
//        VK_OEM_FJ_ROYA = 150,

//        /// VK_LSHIFT -> 0xA0
//        VK_LSHIFT = 160,

//        /// VK_RSHIFT -> 0xA1
//        VK_RSHIFT = 161,

//        /// VK_LCONTROL -> 0xA2
//        VK_LCONTROL = 162,

//        /// VK_RCONTROL -> 0xA3
//        VK_RCONTROL = 163,

//        /// VK_LMENU -> 0xA4
//        VK_LMENU = 164,

//        /// VK_RMENU -> 0xA5
//        VK_RMENU = 165,

//        /// VK_BROWSER_BACK -> 0xA6
//        VK_BROWSER_BACK = 166,

//        /// VK_BROWSER_FORWARD -> 0xA7
//        VK_BROWSER_FORWARD = 167,

//        /// VK_BROWSER_REFRESH -> 0xA8
//        VK_BROWSER_REFRESH = 168,

//        /// VK_BROWSER_STOP -> 0xA9
//        VK_BROWSER_STOP = 169,

//        /// VK_BROWSER_SEARCH -> 0xAA
//        VK_BROWSER_SEARCH = 170,

//        /// VK_BROWSER_FAVORITES -> 0xAB
//        VK_BROWSER_FAVORITES = 171,

//        /// VK_BROWSER_HOME -> 0xAC
//        VK_BROWSER_HOME = 172,

//        /// VK_VOLUME_MUTE -> 0xAD
//        VK_VOLUME_MUTE = 173,

//        /// VK_VOLUME_DOWN -> 0xAE
//        VK_VOLUME_DOWN = 174,

//        /// VK_VOLUME_UP -> 0xAF
//        VK_VOLUME_UP = 175,

//        /// VK_MEDIA_NEXT_TRACK -> 0xB0
//        VK_MEDIA_NEXT_TRACK = 176,

//        /// VK_MEDIA_PREV_TRACK -> 0xB1
//        VK_MEDIA_PREV_TRACK = 177,

//        /// VK_MEDIA_STOP -> 0xB2
//        VK_MEDIA_STOP = 178,

//        /// VK_MEDIA_PLAY_PAUSE -> 0xB3
//        VK_MEDIA_PLAY_PAUSE = 179,

//        /// VK_LAUNCH_MAIL -> 0xB4
//        VK_LAUNCH_MAIL = 180,

//        /// VK_LAUNCH_MEDIA_SELECT -> 0xB5
//        VK_LAUNCH_MEDIA_SELECT = 181,

//        /// VK_LAUNCH_APP1 -> 0xB6
//        VK_LAUNCH_APP1 = 182,

//        /// VK_LAUNCH_APP2 -> 0xB7
//        VK_LAUNCH_APP2 = 183,

//        /// VK_OEM_1 -> 0xBA
//        VK_OEM_1 = 186,

//        /// VK_OEM_PLUS -> 0xBB
//        VK_OEM_PLUS = 187,

//        /// VK_OEM_COMMA -> 0xBC
//        VK_OEM_COMMA = 188,

//        /// VK_OEM_MINUS -> 0xBD
//        VK_OEM_MINUS = 189,

//        /// VK_OEM_PERIOD -> 0xBE
//        VK_OEM_PERIOD = 190,

//        /// VK_OEM_2 -> 0xBF
//        VK_OEM_2 = 191,

//        /// VK_OEM_3 -> 0xC0
//        VK_OEM_3 = 192,

//        /// VK_OEM_4 -> 0xDB
//        VK_OEM_4 = 219,

//        /// VK_OEM_5 -> 0xDC
//        VK_OEM_5 = 220,

//        /// VK_OEM_6 -> 0xDD
//        VK_OEM_6 = 221,

//        /// VK_OEM_7 -> 0xDE
//        VK_OEM_7 = 222,

//        /// VK_OEM_8 -> 0xDF
//        VK_OEM_8 = 223,

//        /// VK_OEM_AX -> 0xE1
//        VK_OEM_AX = 225,

//        /// VK_OEM_102 -> 0xE2
//        VK_OEM_102 = 226,

//        /// VK_ICO_HELP -> 0xE3
//        VK_ICO_HELP = 227,

//        /// VK_ICO_00 -> 0xE4
//        VK_ICO_00 = 228,

//        /// VK_PROCESSKEY -> 0xE5
//        VK_PROCESSKEY = 229,

//        /// VK_ICO_CLEAR -> 0xE6
//        VK_ICO_CLEAR = 230,

//        /// VK_PACKET -> 0xE7
//        VK_PACKET = 231,

//        /// VK_OEM_RESET -> 0xE9
//        VK_OEM_RESET = 233,

//        /// VK_OEM_JUMP -> 0xEA
//        VK_OEM_JUMP = 234,

//        /// VK_OEM_PA1 -> 0xEB
//        VK_OEM_PA1 = 235,

//        /// VK_OEM_PA2 -> 0xEC
//        VK_OEM_PA2 = 236,

//        /// VK_OEM_PA3 -> 0xED
//        VK_OEM_PA3 = 237,

//        /// VK_OEM_WSCTRL -> 0xEE
//        VK_OEM_WSCTRL = 238,

//        /// VK_OEM_CUSEL -> 0xEF
//        VK_OEM_CUSEL = 239,

//        /// VK_OEM_ATTN -> 0xF0
//        VK_OEM_ATTN = 240,

//        /// VK_OEM_FINISH -> 0xF1
//        VK_OEM_FINISH = 241,

//        /// VK_OEM_COPY -> 0xF2
//        VK_OEM_COPY = 242,

//        /// VK_OEM_AUTO -> 0xF3
//        VK_OEM_AUTO = 243,

//        /// VK_OEM_ENLW -> 0xF4
//        VK_OEM_ENLW = 244,

//        /// VK_OEM_BACKTAB -> 0xF5
//        VK_OEM_BACKTAB = 245,

//        /// VK_ATTN -> 0xF6
//        VK_ATTN = 246,

//        /// VK_CRSEL -> 0xF7
//        VK_CRSEL = 247,

//        /// VK_EXSEL -> 0xF8
//        VK_EXSEL = 248,

//        /// VK_EREOF -> 0xF9
//        VK_EREOF = 249,

//        /// VK_PLAY -> 0xFA
//        VK_PLAY = 250,

//        /// VK_ZOOM -> 0xFB
//        VK_ZOOM = 251,

//        /// VK_NONAME -> 0xFC
//        VK_NONAME = 252,

//        /// VK_PA1 -> 0xFD
//        VK_PA1 = 253,

//        /// VK_OEM_CLEAR -> 0xFE
//        VK_OEM_CLEAR = 254,

//    }

//    public enum ST
//    {
//        /// ST_BLOCKNEXT -> 0x0080
//        ST_BLOCKNEXT = 128,

//        /// ST_BLOCKED -> 0x0008
//        ST_BLOCKED = 8,
//    }

//    public enum BS
//    {
//        /// BS_PUSHBUTTON -> 0x00000000L
//        BS_PUSHBUTTON = 0,

//        /// BS_DEFPUSHBUTTON -> 0x00000001L
//        BS_DEFPUSHBUTTON = 1,

//        /// BS_CHECKBOX -> 0x00000002L
//        BS_CHECKBOX = 2,

//        /// BS_AUTOCHECKBOX -> 0x00000003L
//        BS_AUTOCHECKBOX = 3,

//        /// BS_RADIOBUTTON -> 0x00000004L
//        BS_RADIOBUTTON = 4,

//        /// BS_3STATE -> 0x00000005L
//        BS_3STATE = 5,

//        /// BS_AUTO3STATE -> 0x00000006L
//        BS_AUTO3STATE = 6,

//        /// BS_GROUPBOX -> 0x00000007L
//        BS_GROUPBOX = 7,

//        /// BS_USERBUTTON -> 0x00000008L
//        BS_USERBUTTON = 8,

//        /// BS_AUTORADIOBUTTON -> 0x00000009L
//        BS_AUTORADIOBUTTON = 9,

//        /// BS_PUSHBOX -> 0x0000000AL
//        BS_PUSHBOX = 10,

//        /// BS_OWNERDRAW -> 0x0000000BL
//        BS_OWNERDRAW = 11,

//        /// BS_TYPEMASK -> 0x0000000FL
//        BS_TYPEMASK = 15,

//        /// BS_LEFTTEXT -> 0x00000020L
//        BS_LEFTTEXT = 32,

//        /// BS_TEXT -> 0x00000000L
//        BS_TEXT = 0,

//        /// BS_ICON -> 0x00000040L
//        BS_ICON = 64,

//        /// BS_BITMAP -> 0x00000080L
//        BS_BITMAP = 128,

//        /// BS_LEFT -> 0x00000100L
//        BS_LEFT = 256,

//        /// BS_RIGHT -> 0x00000200L
//        BS_RIGHT = 512,

//        /// BS_CENTER -> 0x00000300L
//        BS_CENTER = 768,

//        /// BS_TOP -> 0x00000400L
//        BS_TOP = 1024,

//        /// BS_BOTTOM -> 0x00000800L
//        BS_BOTTOM = 2048,

//        /// BS_VCENTER -> 0x00000C00L
//        BS_VCENTER = 3072,

//        /// BS_PUSHLIKE -> 0x00001000L
//        BS_PUSHLIKE = 4096,

//        /// BS_MULTILINE -> 0x00002000L
//        BS_MULTILINE = 8192,

//        /// BS_NOTIFY -> 0x00004000L
//        BS_NOTIFY = 16384,

//        /// BS_FLAT -> 0x00008000L
//        BS_FLAT = 32768,

//        /// BS_RIGHTBUTTON -> BS_LEFTTEXT
//        BS_RIGHTBUTTON = BS_LEFTTEXT,
//    }

//    // ReSharper restore InconsistentNaming
//}
