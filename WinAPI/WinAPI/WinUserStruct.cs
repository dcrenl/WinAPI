using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace WinAPI
{
    #region

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
