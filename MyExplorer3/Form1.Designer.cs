﻿namespace MyExplorer3
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新規作成NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.上書き保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.名前を付けて保存AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.印刷PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.印刷プレビューVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.元に戻すUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.やり直しRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.切り取りTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.コピーCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.貼り付けPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.すべて選択AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ツールTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.カスタマイズCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.オプションOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.内容CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.インデックスIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.検索SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.バージョン情報AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.編集EToolStripMenuItem,
            this.ツールTToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規作成NToolStripMenuItem,
            this.開くOToolStripMenuItem,
            this.toolStripSeparator,
            this.上書き保存SToolStripMenuItem,
            this.名前を付けて保存AToolStripMenuItem,
            this.toolStripSeparator1,
            this.印刷PToolStripMenuItem,
            this.印刷プレビューVToolStripMenuItem,
            this.toolStripSeparator2,
            this.終了XToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 新規作成NToolStripMenuItem
            // 
            this.新規作成NToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("新規作成NToolStripMenuItem.Image")));
            this.新規作成NToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新規作成NToolStripMenuItem.Name = "新規作成NToolStripMenuItem";
            this.新規作成NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新規作成NToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.新規作成NToolStripMenuItem.Text = "新規作成(&N)";
            // 
            // 開くOToolStripMenuItem
            // 
            this.開くOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("開くOToolStripMenuItem.Image")));
            this.開くOToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.開くOToolStripMenuItem.Name = "開くOToolStripMenuItem";
            this.開くOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.開くOToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.開くOToolStripMenuItem.Text = "開く(&O)";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(198, 6);
            // 
            // 上書き保存SToolStripMenuItem
            // 
            this.上書き保存SToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("上書き保存SToolStripMenuItem.Image")));
            this.上書き保存SToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.上書き保存SToolStripMenuItem.Name = "上書き保存SToolStripMenuItem";
            this.上書き保存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.上書き保存SToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.上書き保存SToolStripMenuItem.Text = "上書き保存(&S)";
            // 
            // 名前を付けて保存AToolStripMenuItem
            // 
            this.名前を付けて保存AToolStripMenuItem.Name = "名前を付けて保存AToolStripMenuItem";
            this.名前を付けて保存AToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.名前を付けて保存AToolStripMenuItem.Text = "名前を付けて保存(&A)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // 印刷PToolStripMenuItem
            // 
            this.印刷PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("印刷PToolStripMenuItem.Image")));
            this.印刷PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.印刷PToolStripMenuItem.Name = "印刷PToolStripMenuItem";
            this.印刷PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.印刷PToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.印刷PToolStripMenuItem.Text = "印刷(&P)";
            // 
            // 印刷プレビューVToolStripMenuItem
            // 
            this.印刷プレビューVToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("印刷プレビューVToolStripMenuItem.Image")));
            this.印刷プレビューVToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.印刷プレビューVToolStripMenuItem.Name = "印刷プレビューVToolStripMenuItem";
            this.印刷プレビューVToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.印刷プレビューVToolStripMenuItem.Text = "印刷プレビュー(&V)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(198, 6);
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.終了XToolStripMenuItem.Text = "終了(&X)";
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.元に戻すUToolStripMenuItem,
            this.やり直しRToolStripMenuItem,
            this.toolStripSeparator3,
            this.切り取りTToolStripMenuItem,
            this.コピーCToolStripMenuItem,
            this.貼り付けPToolStripMenuItem,
            this.toolStripSeparator4,
            this.すべて選択AToolStripMenuItem});
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.編集EToolStripMenuItem.Text = "編集(&E)";
            // 
            // 元に戻すUToolStripMenuItem
            // 
            this.元に戻すUToolStripMenuItem.Name = "元に戻すUToolStripMenuItem";
            this.元に戻すUToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.元に戻すUToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.元に戻すUToolStripMenuItem.Text = "元に戻す(&U)";
            // 
            // やり直しRToolStripMenuItem
            // 
            this.やり直しRToolStripMenuItem.Name = "やり直しRToolStripMenuItem";
            this.やり直しRToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.やり直しRToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.やり直しRToolStripMenuItem.Text = "やり直し(&R)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(187, 6);
            // 
            // 切り取りTToolStripMenuItem
            // 
            this.切り取りTToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("切り取りTToolStripMenuItem.Image")));
            this.切り取りTToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.切り取りTToolStripMenuItem.Name = "切り取りTToolStripMenuItem";
            this.切り取りTToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.切り取りTToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.切り取りTToolStripMenuItem.Text = "切り取り(&T)";
            // 
            // コピーCToolStripMenuItem
            // 
            this.コピーCToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("コピーCToolStripMenuItem.Image")));
            this.コピーCToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.コピーCToolStripMenuItem.Name = "コピーCToolStripMenuItem";
            this.コピーCToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.コピーCToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.コピーCToolStripMenuItem.Text = "コピー(&C)";
            // 
            // 貼り付けPToolStripMenuItem
            // 
            this.貼り付けPToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("貼り付けPToolStripMenuItem.Image")));
            this.貼り付けPToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.貼り付けPToolStripMenuItem.Name = "貼り付けPToolStripMenuItem";
            this.貼り付けPToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.貼り付けPToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.貼り付けPToolStripMenuItem.Text = "貼り付け(&P)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(187, 6);
            // 
            // すべて選択AToolStripMenuItem
            // 
            this.すべて選択AToolStripMenuItem.Name = "すべて選択AToolStripMenuItem";
            this.すべて選択AToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.すべて選択AToolStripMenuItem.Text = "すべて選択(&A)";
            // 
            // ツールTToolStripMenuItem
            // 
            this.ツールTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.カスタマイズCToolStripMenuItem,
            this.オプションOToolStripMenuItem});
            this.ツールTToolStripMenuItem.Name = "ツールTToolStripMenuItem";
            this.ツールTToolStripMenuItem.Size = new System.Drawing.Size(74, 22);
            this.ツールTToolStripMenuItem.Text = "ツール(&T)";
            // 
            // カスタマイズCToolStripMenuItem
            // 
            this.カスタマイズCToolStripMenuItem.Name = "カスタマイズCToolStripMenuItem";
            this.カスタマイズCToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.カスタマイズCToolStripMenuItem.Text = "カスタマイズ(&C)";
            // 
            // オプションOToolStripMenuItem
            // 
            this.オプションOToolStripMenuItem.Name = "オプションOToolStripMenuItem";
            this.オプションOToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.オプションOToolStripMenuItem.Text = "オプション(&O)";
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.内容CToolStripMenuItem,
            this.インデックスIToolStripMenuItem,
            this.検索SToolStripMenuItem,
            this.toolStripSeparator5,
            this.バージョン情報AToolStripMenuItem});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // 内容CToolStripMenuItem
            // 
            this.内容CToolStripMenuItem.Name = "内容CToolStripMenuItem";
            this.内容CToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.内容CToolStripMenuItem.Text = "内容(&C)";
            // 
            // インデックスIToolStripMenuItem
            // 
            this.インデックスIToolStripMenuItem.Name = "インデックスIToolStripMenuItem";
            this.インデックスIToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.インデックスIToolStripMenuItem.Text = "インデックス(&I)";
            // 
            // 検索SToolStripMenuItem
            // 
            this.検索SToolStripMenuItem.Name = "検索SToolStripMenuItem";
            this.検索SToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.検索SToolStripMenuItem.Text = "検索(&S)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(187, 6);
            // 
            // バージョン情報AToolStripMenuItem
            // 
            this.バージョン情報AToolStripMenuItem.Name = "バージョン情報AToolStripMenuItem";
            this.バージョン情報AToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.バージョン情報AToolStripMenuItem.Text = "バージョン情報(&A)...";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 401);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 23);
            this.statusStrip1.TabIndex = 0;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(134, 18);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 401);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(530, 401);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            this.listView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView1_ItemDrag);
            this.listView1.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.listView1_ItemMouseHover);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新規作成NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くOToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem 上書き保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 名前を付けて保存AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 印刷PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 印刷プレビューVToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 元に戻すUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem やり直しRToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 切り取りTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem コピーCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 貼り付けPToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem すべて選択AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ツールTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem カスタマイズCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem オプションOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 内容CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem インデックスIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 検索SToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報AToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView1;
    }
}

