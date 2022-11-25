using System;
using System.Collections.Generic;
using System.Text;

namespace WinAPI
{
    /// <summary>
    /// dcrenl:2022-11-24 13:06:40
    /// user32.dll使用到的enum
    /// </summary>
    #region


    /// <summary>
    /// dcrenl:2022-11-24 13:06:40
    /// https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-activatekeyboardlayout
    /// </summary>
    //[Flags]
    public enum KLF : uint
    {
        /// <summary>
        /// 如果设置了此位，则通过将区域设置标识符移动到列表头来重新排序系统加载的区域设置标识符的循环列表。 如果未设置此位，则无需更改顺序即可旋转列表。
        /// 例如，如果用户激活了英语区域设置标识符，并按该) 顺序加载了法语、德语和西班牙语区域设置标识符 
        /// (，则激活带有 KLF_REORDER 位集的德语区域设置标识符将生成以下顺序：德语、英语、法语、西班牙语。 
        /// 激活没有 KLF_REORDER 位集的德语区域设置标识符将生成以下顺序：德语、西班牙语、英语、法语。
        /// 如果加载不到三个区域设置标识符，则此标志的值无关紧要。
        /// </summary>
        KLF_REORDER = 0x00000008,

        /// <summary>
        /// 如果未设置但 未设置KLF_SHIFTLOCK ，则再次按 Caps Lock 键关闭 Caps Lock 状态。 
        /// 如果同时设置并 KLF_SHIFTLOCK ，则通过按任一 SHIFT 键关闭 Caps Lock 状态。
        /// 这两种方法互斥，设置将作为注册表中用户配置文件的一部分保留。
        /// </summary>
        KLF_RESET = 0x40000000,

        /// <summary>
        /// 如果未设置但 未设置KLF_SHIFTLOCK ，则再次按 Caps Lock 键关闭 Caps Lock 状态。 
        /// 如果同时设置并 KLF_SHIFTLOCK ，则通过按任一 SHIFT 键关闭 Caps Lock 状态。
        /// 这两种方法互斥，设置将作为注册表中用户配置文件的一部分保留。
        /// </summary>
        KLF_SETFORPROCESS = 0x00000100,

        /// <summary>
        /// 这与 KLF_RESET一起使用。 有关说明 ，请参阅KLF_RESET 。
        /// </summary>
        KLF_SHIFTLOCK = 0x00010000,

        KLF_ACTIVATE = 0x00000001,
        KLF_SUBSTITUTE_OK = 0x00000002
    }

    /// <summary>
    /// dcrenl:2022-11-24 13:06:40 
    /// https://learn.microsoft.com/zh-cn/windows/win32/winmsg/window-styles
    /// </summary>
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

        /// <summary>
        /// 窗口是子窗口。 具有此样式的窗口不能有菜单栏。 此样式不能与 WS_POPUP样式一 起使用。
        /// </summary>
        WS_CHILD = 0x40000000,

        /// <summary>
        /// 与 WS_CHILD 样式相同。
        /// </summary>
        WS_CHILDWINDOW = WS_CHILD,

        /// <summary>
        /// 在父窗口中绘制时，排除子窗口占用的区域。 创建父窗口时会使用此样式。
        /// </summary>
        WS_CLIPCHILDREN = 0x02000000,

        /// <summary>
        /// 将子窗口相对于彼此剪裁;也就是说，当特定子窗口收到 WM_PAINT 消息时， WS_CLIPSIBLINGS 样式会将所有其他重叠子窗口剪辑到要更新的子窗口区域。 如果未指定 WS_CLIPSIBLINGS 并且子窗口重叠，则当在子窗口的工作区内绘制时，可以在相邻子窗口的工作区内绘制。
        /// </summary>
        WS_CLIPSIBLINGS = 0x04000000,

        /// <summary>
        /// 窗口最初处于禁用状态。 禁用的窗口无法从用户接收输入。 若要在创建窗口后进行更改，请使用 EnableWindow 函数。
        /// </summary>
        WS_DISABLED = 0x08000000,

        /// <summary>
        /// 窗口具有通常与对话框一起使用的样式边框。 具有此样式的窗口不能有标题栏。
        /// </summary>
        WS_DLGFRAME = 0x00400000,

        /// <summary>
        /// 窗口是一组控件的第一个控件。 该组包含此第一个控件及其之后定义的所有控件，最多包含 WS_GROUP 样式的下一个控件。 
        /// 每个组中的第一个控件通常具有 WS_TABSTOP 样式，以便用户可以从组移动到组。 
        /// 用户随后可以使用方向键将组中的一个控件中的键盘焦点更改为组中的下一个控件。        可以打开和关闭此样式以更改对话框导航。 若要在创建窗口后更改此样式，请使用 SetWindowLong 函数。
        /// </summary>
        WS_GROUP = 0x00020000,

        /// <summary>
        /// 窗口具有水平滚动条。
        /// </summary>
        WS_HSCROLL = 0x00100000,

        /// <summary>
        /// 窗口最初最小化。 与 WS_MINIMIZE 样式相同。
        /// </summary>
        WS_ICONIC = WS_MINIMIZE,

        /// <summary>
        /// 窗口最初最大化。
        /// </summary>
        WS_MAXIMIZE = 0x01000000,

        /// <summary>
        /// 窗口具有最大化按钮。 不能与 WS_EX_CONTEXTHELP 样式组合。 还必须指定 WS_SYSMENU 样式。
        /// </summary>
        WS_MAXIMIZEBOX = 0x00010000,

        /// <summary>
        /// 窗口最初最小化。 与 WS_ICONIC 样式相同。
        /// </summary>
        WS_MINIMIZE = 0x20000000,

        /// <summary>
        /// 窗口具有最小化按钮。 不能与 WS_EX_CONTEXTHELP 样式组合。 还必须指定 WS_SYSMENU 样式。
        /// </summary>
        WS_MINIMIZEBOX = 0x00020000,

        /// <summary>
        /// 窗口是重叠的窗口。 重叠的窗口具有标题栏和边框。 与 WS_TILED 样式相同。
        /// </summary>
        WS_OVERLAPPED = 0x00000000,

        /// <summary>
        /// 窗口是重叠的窗口。 与 WS_TILEDWINDOW 样式相同。
        /// </summary>
        WS_OVERLAPPEDWINDOW = (WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX),

        /// <summary>
        /// 窗口是弹出窗口。 此样式不能与 WS_CHILD样式一 起使用。
        /// </summary>
        WS_POPUP = 0x80000000,

        /// <summary>
        /// 窗口是弹出窗口。 必须组合 WS_CAPTION 和 WS_POPUPWINDOW 样式以使窗口菜单可见。
        /// </summary>
        WS_POPUPWINDOW = (WS_POPUP | WS_BORDER | WS_SYSMENU),

        /// <summary>
        /// 窗口具有大小调整边框。 与 WS_THICKFRAME 样式相同。
        /// </summary>
        WS_SIZEBOX = WS_THICKFRAME,

        /// <summary>
        /// 窗口的标题栏上有一个窗口菜单。 还必须指定 WS_CAPTION 样式。
        /// </summary>
        WS_SYSMENU = 0x00080000,

        /// <summary>
        /// 窗口是一个控件，当用户按下 TAB 键时，可以接收键盘焦点。 按 Tab 键会将键盘焦点更改为 具有WS_TABSTOP 样式的下一个控件。
        /// 可以打开和关闭此样式以更改对话框导航。 若要在创建窗口后更改此样式，请使用 SetWindowLong 函数。 
        /// 若要使用户创建的窗口和无模式对话框使用制表位，请更改消息循环以调用 IsDialogMessage 函数。
        /// </summary>
        WS_TABSTOP = 0x00010000,

        /// <summary>
        /// 窗口具有大小调整边框。 与 WS_SIZEBOX 样式相同。
        /// </summary>
        WS_THICKFRAME = 0x00040000,

        /// <summary>
        /// 窗口是重叠的窗口。 重叠窗口具有标题栏和边框。 与 WS_OVERLAPPED 样式相同。
        /// </summary>
        WS_TILED = WS_OVERLAPPED,

        /// <summary>
        /// 窗口是重叠的窗口。 与 WS_OVERLAPPEDWINDOW 样式相同。
        /// </summary>
        WS_TILEDWINDOW = WS_OVERLAPPEDWINDOW,

        /// <summary>
        /// 窗口最初可见。        可以使用 ShowWindow 或 SetWindowPos 函数打开和关闭此样式。
        /// </summary>
        WS_VISIBLE = 0x10000000,

        /// <summary>
        /// 该窗口具有垂直滚动条。
        /// </summary>
        WS_VSCROLL = 0x00200000,

    }

    [Flags]
    public enum AW : uint
    {
        AW_HOR_POSITIVE = 0x00000001,
        AW_HOR_NEGATIVE = 0x00000002,
        AW_VER_POSITIVE = 0x00000004,
        AW_VER_NEGATIVE = 0x00000008,
        AW_CENTER = 0x00000010,
        AW_HIDE = 0x00010000,
        AW_ACTIVATE = 0x00020000,
        AW_SLIDE = 0x00040000,
        AW_BLEND = 0x00080000
    }

    [Flags]
    public enum MF : uint
    {
        /// <summary>
        /// 使用位图作为菜单项。 lpNewItem 参数包含位图的句柄。
        /// </summary>
        MF_BITMAP = 0x00000004,
        /// <summary>
        /// 在菜单项旁边放置复选标记。 如果应用程序提供复选标记位图 (请参阅 SetMenuItemBitmaps，此标志会显示菜单项旁边的复选标记位图。
        /// </summary>
        MF_CHECKED = 0x00000008,
        /// <summary>
        /// 禁用菜单项，使其无法选中，但标志不会灰显。
        /// </summary>
        MF_DISABLED = 0x00000002,
        /// <summary>
        /// 启用菜单项，以便可以选择菜单项，并从其灰色状态还原它。
        /// </summary>
        MF_ENABLED = 0x00000000,
        /// <summary>
        /// 禁用菜单项并将其灰显，以便无法选择它。
        /// </summary>
        MF_GRAYED = 0x00000001,
        /// <summary>
        /// 与菜单栏 的MF_MENUBREAK 标志相同。 对于下拉菜单、子菜单或快捷菜单，新列与旧列之间将用一条竖线分隔。
        /// </summary>
        MF_MENUBARBREAK = 0x00000020,
        /// <summary>
        /// 将项放在菜单栏的新行 () 或 (的下拉菜单、子菜单或快捷菜单) 中，而不分隔列。
        /// </summary>
        MF_MENUBREAK = 0x00000040,
        /// <summary>
        /// 指定该项是所有者绘制的项。 首次显示菜单之前，拥有菜单的窗口会收到 WM_MEASUREITEM 消息以检索菜单项的宽度和高度。 然后 ，只要 必须更新菜单项的外观，WM_DRAWITEM消息就会发送到所有者窗口的窗口过程。
        /// </summary>
        MF_OWNERDRAW = 0x00000100,
        /// <summary>
        /// 指定菜单项打开下拉菜单或子菜单。 uIDNewItem 参数指定下拉菜单或子菜单的句柄。 此标志用于向菜单栏添加菜单名称，或将子菜单打开到下拉菜单、子菜单或快捷菜单的菜单项。
        /// </summary>
        MF_POPUP = 0x00000010,
        /// <summary>
        /// 绘制一条水平分割线。 此标志仅在下拉菜单、子菜单或快捷菜单中使用。 行不能灰显、禁用或突出显示。 忽略 lpNewItem 和 uIDNewItem 参数。
        /// </summary>
        MF_SEPARATOR = 0x00000800,
        /// <summary>
        /// 指定菜单项是文本字符串; lpNewItem 参数是指向字符串的指针。
        /// </summary>
        MF_STRING = 0x00000000,
        /// <summary>
        /// 不会在项旁边放置复选标记， (默认) 。 如果应用程序提供复选标记位图 (请参阅 SetMenuItemBitmaps) ，此标志会显示菜单项旁边的清除位图。
        /// </summary>
        MF_UNCHECKED = 0x00000000,
    }

    /// <summary>
    /// dcrenl:2022-11-24 13:06:40
    /// 标识线程、进程或窗口 (dpi) 设置的每英寸点数。
    /// https://learn.microsoft.com/zh-cn/windows/win32/api/windef/ne-windef-dpi_awareness
    /// </summary>
    [Flags]
    public enum DPI_AWARENESS : int
    {
        /// <summary>
        /// DPI 感知无效。 这是无效的 DPI 感知值。
        /// </summary>
        DPI_AWARENESS_INVALID = -1,
        /// <summary>
        /// DPI 不知道。 此过程不会缩放 DPI 更改，并且始终假定其比例系数为 100%， (96 DPI) 。 系统会根据任何其他 DPI 设置自动缩放它。
        /// </summary>
        DPI_AWARENESS_UNAWARE = 0,
        /// <summary>
        /// 系统 DPI 感知。 此过程不会缩放 DPI 更改。 它将查询 DPI 一次，并在进程的生存期内使用该值。 
        /// 如果 DPI 发生更改，该过程将不会调整为新的 DPI 值。 当 DPI 从系统值更改时，系统会自动纵向扩展或缩减它。
        /// </summary>
        DPI_AWARENESS_SYSTEM_AWARE = 1,
        /// <summary>
        /// 每个监视器 DPI 感知。 此过程会在创建 DPI 时检查 DPI，并在 DPI 发生更改时调整比例因子。 系统不会自动缩放这些进程。
        /// </summary>
        DPI_AWARENESS_PER_MONITOR_AWARE = 2
    };

    [Flags]
    public enum BSF : uint
    {
        BSF_ALLOWSFW = 0x00000080,
        BSF_FLUSHDISK = 0x00000004,
        BSF_FORCEIFHUNG = 0x00000020,
        BSF_IGNORECURRENTTASK = 0x00000002,
        BSF_NOHANG = 0x00000008,
        BSF_NOTIMEOUTIFNOTHUNG = 0x00000040,
        BSF_POSTMESSAGE = 0x00000010,
        BSF_QUERY = 0x00000001,
        BSF_SENDNOTIFYMESSAGE = 0x00000100,
        BSF_LUID = 0x00000400
    }

    #endregion
}
