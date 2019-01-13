using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace MyExplorer3
{
    public class ListViewItemSorter : IComparer
    {
        /// <summary>
        /// 比較する方法
        /// </summary>
        public enum ComparerMode
        {
            /// <summary>
            /// 文字列として比較
            /// </summary>
            String,
            /// <summary>
            /// 数値（Int32型）として比較
            /// </summary>
            Integer,
            /// <summary>
            /// 日時（DataTime型）として比較
            /// </summary>
            DateTime,
            /// <summary>
            /// ファイル名として比較
            /// </summary>
            FileName,
            /// <summary>
            /// ファイルサイズとして比較
            /// </summary>
            FileSize
        };

        private ComparerMode[] _columnModes;
        private int _column;

        /// <summary>
        /// 並び替えるListView列の番号
        /// </summary>
        public int Column
        {
            set
            {
                //現在と同じ列の時は、昇順降順を切り替える
                if (_column == value)
                {
                    if (Order == SortOrder.Ascending)
                    {
                        Order = SortOrder.Descending;
                    }
                    else if (Order == SortOrder.Descending)
                    {
                        Order = SortOrder.Ascending;
                    }
                }
                _column = value;
            }
            get
            {
                return _column;
            }
        }

        /// <summary>
        /// 昇順か降順か
        /// </summary>
        public SortOrder Order { set; get; }

        /// <summary>
        /// 並び替えの方法
        /// </summary>
        public ComparerMode Mode { set; get; }

        /// <summary>
        /// 列ごとの並び替えの方法
        /// </summary>
        public ComparerMode[] ColumnModes
        {
            set
            {
                _columnModes = value;
            }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="col">並び替える列の番号</param>
        /// <param name="ord">昇順か降順か</param>
        /// <param name="cmod">並び替えの方法</param>
        public ListViewItemSorter(int col, SortOrder ord, ComparerMode cmod)
        {
            Column = col;
            Order = ord;
            Mode = cmod;
        }
        public ListViewItemSorter()
        {
            Column = 0;
            Order = SortOrder.Ascending;
            Mode = ComparerMode.String;
        }

        //xがyより小さいときはマイナスの数、大きいときはプラスの数、
        //同じときは0を返す
        public int Compare(object x, object y)
        {
            if (Order == SortOrder.None)
            {
                //並び替えない時
                return 0;
            }

            int result = 0;
            //ListViewItemの取得
            ListViewItem itemx = (ListViewItem)x;
            ListViewItem itemy = (ListViewItem)y;

            //並べ替えの方法を決定
            if (_columnModes != null && _columnModes.Length > Column)
            {
                Mode = _columnModes[Column];
            }

            //並び替えの方法別に、xとyを比較する
            switch (Mode)
            {
                case ComparerMode.String:
                    //文字列をとして比較
                    result = string.Compare(itemx.SubItems[Column].Text,
                        itemy.SubItems[Column].Text);
                    break;
                case ComparerMode.Integer:
                    //Int32に変換して比較
                    //.NET Framework 2.0からは、TryParseメソッドを使うこともできる
                    result = int.Parse(itemx.SubItems[Column].Text).CompareTo(
                        int.Parse(itemy.SubItems[Column].Text));
                    break;
                case ComparerMode.DateTime:
                    //DateTimeに変換して比較
                    //.NET Framework 2.0からは、TryParseメソッドを使うこともできる
                    result = DateTime.Compare(
                        DateTime.Parse(itemx.SubItems[Column].Text),
                        DateTime.Parse(itemy.SubItems[Column].Text));
                    break;
                case ComparerMode.FileName:
                    //Debug.WriteLine($"Compare: {itemx.Name}, {itemy.Name}");
                    result = CompareFileName(itemx.Name, itemy.Name);
                    break;
                case ComparerMode.FileSize:
                    result = CompareFileSize(itemx.SubItems[Column].Text, itemy.SubItems[Column].Text);
                    break;
            }

            //降順の時は結果を+-逆にする
            if (Order == SortOrder.Descending)
            {
                result = -result;
            }

            //結果を返す
            return result;
        }

        /// <summary>
        /// ファイル名の比較をします.
        /// </summary>
        /// <param name="path1"></param>
        /// <param name="path2"></param>
        /// <returns></returns>
        private int CompareFileName(string path1, string path2)
        {
            
            FileInfo fi1 = new FileInfo(path1);
            FileInfo fi2 = new FileInfo(path2);

            if (fi1.Attributes == FileAttributes.Directory && fi2.Attributes != FileAttributes.Directory)
            {
                return -1;
            }
            else if (fi1.Attributes != FileAttributes.Directory && fi2.Attributes == FileAttributes.Directory)
            {
                return 1;
            }

            return string.Compare(path1, path2);
        }

        /// <summary>
        /// 単位付きのファイルサイズを比較します.
        /// </summary>
        /// <param name="size1"></param>
        /// <param name="size2"></param>
        /// <returns></returns>
        private int CompareFileSize(string sizeWithUnit1, string sizeWithUnit2)
        {
            string size1 = "0";
            string unit1 = "";
            string size2 = "0";
            string unit2 = "";

            List<string> units = new List<string>() { "KB", "MB", "GB" };

            if (!string.IsNullOrEmpty(sizeWithUnit1))
            {
                size1 = sizeWithUnit1.Split(null)[0];
                unit1 = sizeWithUnit1.Split(null)[1];
            }
            if (!string.IsNullOrEmpty(sizeWithUnit2))
            {
                size2 = sizeWithUnit2.Split(null)[0];
                unit2 = sizeWithUnit2.Split(null)[1];
            }

            // 単位が違う場合は単位で比較
            if (unit1 != unit2)
            {
                return units.IndexOf(unit1).CompareTo(units.IndexOf(unit2));
            }

            return decimal.Parse(size1).CompareTo(decimal.Parse(size2));
        }
    }
}
