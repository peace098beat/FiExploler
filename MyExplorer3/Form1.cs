using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using static MyExplorer3.NativeAPIMethods;

namespace MyExplorer3
{
    public partial class Form1 : Form
    {

        // 選択された項目を保持
        private String selectedItem = "";
        private ListViewItemSorter fileListSorter;
        private string targetRootPath;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /********************************/
            //// WinAPI SHELLのおまじない
            //// イメージリストを作成
            SHFILEINFO shFileInfo = new SHFILEINFO();
            IntPtr imageListHandle = SHGetFileInfo(String.Empty, 0, out shFileInfo, (uint)Marshal.SizeOf(shFileInfo), SHGFI_SMALLICON | SHGFI_SYSICONINDEX);
            // ListViewにイメージリストを追加
            SendMessage(listView1.Handle, LVM_SETIMAGELIST, new IntPtr(LVSIL_SMALL), imageListHandle);

            /********************************/

            // 初期選択ドライブの内容を表示
            SetListViewRootPath(Environment.GetLogicalDrives().First());

            /********************************/

            // ソートクラスの設定
            fileListSorter = new ListViewItemSorter(0, SortOrder.Ascending, ListViewItemSorter.ComparerMode.String);
            fileListSorter.ColumnModes = new ListViewItemSorter.ComparerMode[]
            {
                ListViewItemSorter.ComparerMode.String, // FileNameでは上手くいかなかった[BUG]
                ListViewItemSorter.ComparerMode.String,
                ListViewItemSorter.ComparerMode.String,
                ListViewItemSorter.ComparerMode.FileSize
            };
            listView1.ListViewItemSorter = fileListSorter;

            // ソートマークの設定
            SetSortMark(listView1.Handle, 0, fileListSorter.Order);
            /********************************/

        }

        /// <summary>
        /// リストビューのヘッダーソートマークの制御.
        /// </summary>
        /// <param name="listViewHandle"></param>
        /// <param name="colIdx"></param>
        /// <param name="order"></param>
        public static void SetSortMark(IntPtr listViewHandle, int colIdx, SortOrder order)
        {
            IntPtr hColHeader = SendMessage(listViewHandle, LVM_GETHEADER, IntPtr.Zero, IntPtr.Zero);
            HDITEM hdItem = new HDITEM();
            IntPtr colHeader = new IntPtr(colIdx);

            hdItem.mask = HDI_FORMAT;
            IntPtr rtn = SendMessageITEM(hColHeader, HDM_GETITEM, colHeader, ref hdItem);

            if (order == SortOrder.Ascending)
            {
                hdItem.fmt &= ~HDF_SORTDOWN;
                hdItem.fmt |= HDF_SORTUP;
            }
            else if (order == SortOrder.Descending)
            {
                hdItem.fmt &= ~HDF_SORTUP;
                hdItem.fmt |= HDF_SORTDOWN;
            }
            else if (order == SortOrder.None)
            {
                hdItem.fmt &= ~HDF_SORTDOWN & ~HDF_SORTUP;
            }

            rtn = SendMessageITEM(hColHeader, HDM_SETITEM, colHeader, ref hdItem);
        }

     

        /// <summary>
        /// ListViewのルートパスを変更する
        /// </summary>
        private void SetListViewRootPath(string filePath)
        {
            // リストビューのヘッダーを設定
            listView1.View = View.Details;
            listView1.Clear();
            listView1.Columns.Add("名前");
            listView1.Columns.Add("種類");
            listView1.Columns.Add("更新日時");
            listView1.Columns.Add("サイズ");

            Debug.WriteLine($"==================");

            try
            {
                // フォルダ一覧
                DirectoryInfo dirList = new DirectoryInfo(filePath);
                foreach (DirectoryInfo info in dirList.GetDirectories())
                {
                    ListViewItem item = new ListViewItem(info.Name);
                    item.Name = info.Name;

                    // フォルダ種類、アイコンの取得
                    String type = "";
                    int iconIndex = 0;

                    SHFILEINFO shFileInfo = new SHFILEINFO();
                    IntPtr hSuccess = SHGetFileInfo(info.FullName, 0, out shFileInfo, (uint)Marshal.SizeOf(shFileInfo),
                        SHGFI_ICON | SHGFI_LARGEICON | SHGFI_SMALLICON | SHGFI_SYSICONINDEX | SHGFI_TYPENAME);

                    if (hSuccess != IntPtr.Zero)
                    {
                        type = shFileInfo.szTypeName;
                        iconIndex = shFileInfo.iIcon;
                    }

                    // 各列の内容を設定
                    item.ImageIndex = iconIndex;
                    item.SubItems.Add(type);
                    item.SubItems.Add(String.Format("{0:yyyy/MM/dd HH:mm:ss}", info.LastAccessTime));
                    item.SubItems.Add("");

                    // リストに追加
                    listView1.Items.Add(item);

                }

                // ファイル一覧
                List<String> files = Directory.GetFiles(filePath).ToList<String>();
                foreach (String file in files)
                {
                    FileInfo info = new FileInfo(file);
                    ListViewItem item = new ListViewItem(info.Name);
                    item.Name = info.Name;

                    // ファイル種類、アイコンの取得
                    String type = "";
                    int iconIndex = 0;

                    SHFILEINFO shFileInfo = new SHFILEINFO();
                    IntPtr hSuccess = SHGetFileInfo(info.FullName, 0, out shFileInfo, (uint)Marshal.SizeOf(shFileInfo),
                        SHGFI_ICON | SHGFI_LARGEICON | SHGFI_SMALLICON | SHGFI_SYSICONINDEX | SHGFI_TYPENAME);
                    if (hSuccess != IntPtr.Zero)
                    {
                        type = shFileInfo.szTypeName;
                        iconIndex = shFileInfo.iIcon;
                    }

                    // 各列の内容を設定
                    item.ImageIndex = iconIndex;
                    item.SubItems.Add(type);
                    item.SubItems.Add(String.Format("{0:yyyy/MM/dd HH:mm:ss}", info.LastAccessTime));
                    item.SubItems.Add(getFileSize(info.Length));

                    // リストに追加
                    listView1.Items.Add(item);
                }
            }
            catch (IOException ie)
            {
                MessageBox.Show(ie.Message, "選択エラー");
            }

            // 列幅を自動調整
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            this.targetRootPath = filePath;
        }

        /// <summary>
        /// ファイルサイズを文字列にする
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        private string getFileSize(long fileSize)
        {
            String ret = fileSize + " バイト";
            if (fileSize > (1024f * 1024f * 1024f))
            {
                ret = Math.Round((fileSize / 1024f / 1024f / 1024f), 2).ToString() + " GB";
            }
            else if (fileSize > (1024f * 1024f))
            {
                ret = Math.Round((fileSize / 1024f / 1024f), 2).ToString() + " MB";
            }
            else if (fileSize > 1024f)
            {
                ret = Math.Round((fileSize / 1024f)).ToString() + " KB";
            }

            return ret;
        }


        /*****************************************************************/

        private void listView1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("listView1_Click");

            ListViewItem item = listView1.SelectedItems[0];

            string path = Path.Combine(this.targetRootPath, item.Name);

            // 移動
            this.SetListViewRootPath(path);

        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            Debug.WriteLine("listView1_ColumnClick");

            fileListSorter.Column = e.Column;
            listView1.Sort();

            // 初期化
            foreach (ColumnHeader c in listView1.Columns)
            {
                SetSortMark(listView1.Handle, c.Index, SortOrder.None);
            }

            SetSortMark(listView1.Handle, e.Column, fileListSorter.Order);

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            Debug.WriteLine("listView1_DoubleClick");

        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            Debug.WriteLine("listView1_ItemActivate");

        }

        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            Debug.WriteLine("listView1_ItemDrag");

        }

        private void listView1_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            Debug.WriteLine("listView1_ItemMouseHover");

        }

        /*****************************************************************/

    }
}
