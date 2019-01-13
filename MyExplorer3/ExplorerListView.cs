using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
//using static MyExplorer3.NativeAPIMethods;

namespace MyExplorer3
{
    public partial class FileListView : ListView
    {

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


        public FileListView()
        {

            // WinAPI SHELLのおまじない
            // イメージリストを作成
            //SHFILEINFO shFileInfo = new SHFILEINFO();
            //IntPtr imageListHandle = SHGetFileInfo(String.Empty, 0, out shFileInfo, (uint)Marshal.SizeOf(shFileInfo), SHGFI_SMALLICON | SHGFI_SYSICONINDEX);
            //// ListViewにイメージリストを追加
            //SendMessage(this.Handle, LVM_SETIMAGELIST, new IntPtr(LVSIL_SMALL), imageListHandle);

            /********************************/

            // 初期選択ドライブの内容を表示
            //SetRootDirectory(Environment.GetLogicalDrives().First());

        }

     
        public void SetRootDirectory(string directoryRootPath)
        {
         

            // リストビューのヘッダーを設定
            this.View = View.Details;
            this.Clear();
            this.Columns.Add("名前");
            this.Columns.Add("種類");
            this.Columns.Add("更新日時");
            this.Columns.Add("サイズ");

            if(this.SmallImageList == null) throw new Exception("SmallImageList Error null");

            try
            {
                // フォルダ一覧
                DirectoryInfo dirList = new DirectoryInfo(directoryRootPath);
                foreach (DirectoryInfo info in dirList.GetDirectories())
                {
                    ListViewItem item = new ListViewItem(info.Name);

                    // フォルダ種類、アイコンの取得
                    String type = "xx";
                    int iconIndex = 0;

                    SHFILEINFO shFileInfo = new SHFILEINFO();
                    IntPtr hSuccess = SHGetFileInfo(info.FullName, 0, out shFileInfo, (uint)Marshal.SizeOf(shFileInfo),
                        SHGFI_ICON | SHGFI_LARGEICON | SHGFI_SMALLICON | SHGFI_SYSICONINDEX | SHGFI_TYPENAME);

                    if (hSuccess != IntPtr.Zero)
                    {
                        type = shFileInfo.szTypeName;
                        iconIndex = shFileInfo.iIcon;
                    }
                    else
                    {
                        throw new Exception("hSuccessに失敗");
                    }

                    Debug.WriteLine(iconIndex);

                    // 各列の内容を設定
                    item.ImageIndex = iconIndex;
                    item.SubItems.Add(type);
                    item.SubItems.Add(String.Format("{0:yyyy/MM/dd HH:mm:ss}", info.LastAccessTime));
                    item.SubItems.Add("");

                    // リストに追加
                    this.Items.Add(item);

                }

                // ファイル一覧
                //List<String> files = Directory.GetFiles(filePath).ToList<String>();
                //foreach (String file in files)
                //{
                //    FileInfo info = new FileInfo(file);
                //    ListViewItem item = new ListViewItem(info.Name);

                //    // ファイル種類、アイコンの取得
                //    String type = "";
                //    int iconIndex = 0;

                //    SHFILEINFO shFileInfo = new SHFILEINFO();
                //    IntPtr hSuccess = SHGetFileInfo(info.FullName, 0, out shFileInfo, (uint)Marshal.SizeOf(shFileInfo),
                //        SHGFI_ICON | SHGFI_LARGEICON | SHGFI_SMALLICON | SHGFI_SYSICONINDEX | SHGFI_TYPENAME);
                //    if (hSuccess != IntPtr.Zero)
                //    {
                //        type = shFileInfo.szTypeName;
                //        iconIndex = shFileInfo.iIcon;
                //    }

                //    // 各列の内容を設定
                //    item.ImageIndex = iconIndex;
                //    item.SubItems.Add(type);
                //    item.SubItems.Add(String.Format("{0:yyyy/MM/dd HH:mm:ss}", info.LastAccessTime));
                //    item.SubItems.Add(getFileSize(info.Length));

                //    // リストに追加
                //    listView1.Items.Add(item);
                //}
            }
            catch (IOException ie)
            {
                MessageBox.Show(ie.Message, "選択エラー");
            }

            // 列幅を自動調整
            this.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }


        private string getFileSize(long length)
        {
            return length.ToString();
        }



    }
}
