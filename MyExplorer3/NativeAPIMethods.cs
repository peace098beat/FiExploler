using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;

namespace MyExplorer3
{
    static class NativeAPIMethods
    {
        /// <summary>
        /// SHELL経由でファイルの情報を取得
        /// </summary>
        /// <param name="pszPath">ファイル名</param>
        /// <param name="dwFileAttributes">?</param>
        /// <param name="psfi">結果を返すためのSHFILEINFO構造体</param>
        /// <param name="cbFileInfo">psfiの構造体のサイズ</param>
        /// <param name="uFlags">どの情報を取得するかのフラグ</param>
        /// <returns></returns>
        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, out SHFILEINFO psfi, uint cbFileInfo, uint uFlags);

        /// <summary>
        /// イメージリストを登録
        /// </summary>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// SHGetFileInfo関数で使用する構造体
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public int iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        // ファイル情報用
        public const int SHGFI_LARGEICON = 0x00000000;
        public const int SHGFI_SMALLICON = 0x00000001;
        public const int SHGFI_USEFILEATTRIBUTES = 0x00000010;
        public const int SHGFI_OVERLAYINDEX = 0x00000040;
        public const int SHGFI_ICON = 0x00000100;
        public const int SHGFI_SYSICONINDEX = 0x00004000;
        public const int SHGFI_TYPENAME = 0x000000400;

        // TreeView用
        public const int TVSIL_NORMAL = 0x0000;
        public const int TVSIL_STATE = 0x0002;
        public const int TVM_SETIMAGELIST = 0x1109;

        // ListView用
        public const int LVSIL_NORMAL = 0;
        public const int LVSIL_SMALL = 1;
        public const int LVM_SETIMAGELIST = 0x1003;

        [StructLayout(LayoutKind.Sequential)]
        public struct HDITEM
        {
            public Int32 mask;
            public Int32 cxy;
            [MarshalAs(UnmanagedType.LPTStr)]
            public String pszText;
            public IntPtr hbm;
            public Int32 cchTextMax;
            public Int32 fmt;
            public Int32 lParam;
            public Int32 iImage;
            public Int32 iOrder;
        };

        // Parameters for ListView-Headers
        public const Int32 HDI_FORMAT = 0x0004;
        public const Int32 HDF_LEFT = 0x0000;
        public const Int32 HDF_STRING = 0x4000;
        public const Int32 HDF_SORTUP = 0x0400;
        public const Int32 HDF_SORTDOWN = 0x0200;
        public const Int32 LVM_GETHEADER = 0x1000 + 31;  // LVM_FIRST + 31
        public const Int32 HDM_GETITEM = 0x1200 + 11;  // HDM_FIRST + 11
        public const Int32 HDM_SETITEM = 0x1200 + 12;  // HDM_FIRST + 12

        /// <summary>
        /// リストビューヘッダのイメージ登録
        /// </summary>
        /// <param name="Handle"></param>
        /// <param name="msg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern IntPtr SendMessageITEM(IntPtr Handle, Int32 msg, IntPtr wParam, ref HDITEM lParam);




    }
}
