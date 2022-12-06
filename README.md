# WinAPI

#### 介绍
使用C#调用windows环境下的user32.dll函数.
所有函数都在以下网址可以找到：https://learn.microsoft.com/zh-cn/windows/win32/api/winuser/

#### 软件架构

核心分为三个类文件

***WinUser*** 使用`DllImport`引入user32.dll下的方法

***WinUserEnum*** 方法中需要用到的常量

***WinUserStruct*** 方法中使用到的结构体

#### 使用说明

可以引用整个项目或者将项目下的三个类文件复制到自己项目中
也可将项目中的类进行剪裁去除不需要的方法

#### 参与贡献

1.  Fork 本仓库
2.  新建 Feat_xxx 分支
3.  提交代码
4.  新建 Pull Request
