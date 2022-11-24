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

        /// <summary>
        /// 指示屏幕上是否存在拥有、可见、顶级弹出窗口或重叠窗口。 该函数将搜索整个屏幕，而不仅仅是调用应用程序的工作区。
        /// </summary>
        /// <returns></returns>
        public static extern IntPtr AAnyPopup();


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

        /// <summary>
        /// 使用指向参数列表的指针将数据写入指定缓冲区。 (ANSI)
        /// </summary>
        /// <returns></returns>
        public static extern IntPtr wvsprintfA();

        /// <summary>
        /// 使用指向参数列表的指针将数据写入指定缓冲区。 (Unicode)
        /// </summary>
        /// <returns></returns>
        public static extern IntPtr wvsprintfW();

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
