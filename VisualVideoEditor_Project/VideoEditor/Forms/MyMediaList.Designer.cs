namespace VisualVideoEditor_Project.VideoEditor.Forms
{
    partial class MyMediaList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            this.tabMediaList = new MetroFramework.Controls.MetroTabControl();
            this.tpLocalMedia = new MetroFramework.Controls.MetroTabPage();
            this.tlpPcList = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemove = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.lvPcList = new MetroFramework.Controls.MetroListView();
            this.chFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileDir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtVideoPath = new System.Windows.Forms.TextBox();
            this.lbStreamList = new System.Windows.Forms.ListBox();
            this.tabMediaList.SuspendLayout();
            this.tpLocalMedia.SuspendLayout();
            this.tlpPcList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMediaList
            // 
            this.tabMediaList.Controls.Add(this.tpLocalMedia);
            this.tabMediaList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMediaList.Location = new System.Drawing.Point(5, 60);
            this.tabMediaList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMediaList.Name = "tabMediaList";
            this.tabMediaList.Padding = new System.Drawing.Point(6, 6);
            this.tabMediaList.SelectedIndex = 0;
            this.tabMediaList.Size = new System.Drawing.Size(396, 456);
            this.tabMediaList.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMediaList.TabIndex = 0;
            this.tabMediaList.UseSelectable = true;
            // 
            // tpLocalMedia
            // 
            this.tpLocalMedia.Controls.Add(this.tlpPcList);
            this.tpLocalMedia.Enabled = true;
            this.tpLocalMedia.HorizontalScrollbarBarColor = true;
            this.tpLocalMedia.HorizontalScrollbarHighlightOnWheel = false;
            this.tpLocalMedia.HorizontalScrollbarSize = 12;
            this.tpLocalMedia.Location = new System.Drawing.Point(4, 34);
            this.tpLocalMedia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpLocalMedia.Name = "tpLocalMedia";
            this.tpLocalMedia.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpLocalMedia.Size = new System.Drawing.Size(388, 418);
            this.tpLocalMedia.TabIndex = 0;
            this.tpLocalMedia.Text = "로컬 미디어";
            this.tpLocalMedia.VerticalScrollbarBarColor = true;
            this.tpLocalMedia.VerticalScrollbarHighlightOnWheel = false;
            this.tpLocalMedia.VerticalScrollbarSize = 13;
            this.tpLocalMedia.Visible = true;
            // 
            // tlpPcList
            // 
            this.tlpPcList.BackColor = System.Drawing.SystemColors.Window;
            this.tlpPcList.ColumnCount = 3;
            this.tlpPcList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPcList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpPcList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpPcList.Controls.Add(this.btnRemove, 2, 1);
            this.tlpPcList.Controls.Add(this.btnAdd, 1, 1);
            this.tlpPcList.Controls.Add(this.lvPcList, 0, 0);
            this.tlpPcList.Controls.Add(this.txtVideoPath, 0, 1);
            this.tlpPcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPcList.Location = new System.Drawing.Point(3, 2);
            this.tlpPcList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpPcList.Name = "tlpPcList";
            this.tlpPcList.RowCount = 2;
            this.tlpPcList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPcList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPcList.Size = new System.Drawing.Size(382, 414);
            this.tlpPcList.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.Location = new System.Drawing.Point(305, 376);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(74, 36);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "삭제";
            this.btnRemove.UseSelectable = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(225, 376);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 36);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lvPcList
            // 
            this.lvPcList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFileName,
            this.chFileDir});
            this.tlpPcList.SetColumnSpan(this.lvPcList, 3);
            this.lvPcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPcList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvPcList.FullRowSelect = true;
            this.lvPcList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPcList.HideSelection = false;
            this.lvPcList.LabelEdit = true;
            this.lvPcList.Location = new System.Drawing.Point(3, 2);
            this.lvPcList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvPcList.Name = "lvPcList";
            this.lvPcList.OwnerDraw = true;
            this.lvPcList.Size = new System.Drawing.Size(376, 370);
            this.lvPcList.TabIndex = 4;
            this.lvPcList.UseCompatibleStateImageBehavior = false;
            this.lvPcList.UseSelectable = true;
            this.lvPcList.View = System.Windows.Forms.View.Details;
            this.lvPcList.ItemActivate += new System.EventHandler(this.LvPcList_ItemActivate);
            // 
            // chFileName
            // 
            this.chFileName.Text = "Name";
            this.chFileName.Width = 150;
            // 
            // chFileDir
            // 
            this.chFileDir.Text = "Directory";
            this.chFileDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chFileDir.Width = 186;
            // 
            // txtVideoPath
            // 
            this.txtVideoPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVideoPath.Location = new System.Drawing.Point(3, 381);
            this.txtVideoPath.Name = "txtVideoPath";
            this.txtVideoPath.Size = new System.Drawing.Size(216, 25);
            this.txtVideoPath.TabIndex = 1;
            this.txtVideoPath.Text = "경로를 입력하세요.";
            this.txtVideoPath.Click += new System.EventHandler(this.txtVideoPath_Click);
            // 
            // lbStreamList
            // 
            this.lbStreamList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStreamList.FormattingEnabled = true;
            this.lbStreamList.ItemHeight = 15;
            this.lbStreamList.Location = new System.Drawing.Point(3, 2);
            this.lbStreamList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbStreamList.Name = "lbStreamList";
            this.lbStreamList.Size = new System.Drawing.Size(382, 414);
            this.lbStreamList.TabIndex = 0;
            // 
            // MyMediaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 521);
            this.Controls.Add(this.tabMediaList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MyMediaList";
            this.Padding = new System.Windows.Forms.Padding(5, 60, 5, 5);
            this.Text = "즐겨찾기 리스트";
            this.tabMediaList.ResumeLayout(false);
            this.tpLocalMedia.ResumeLayout(false);
            this.tlpPcList.ResumeLayout(false);
            this.tlpPcList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl tabMediaList;
        private MetroFramework.Controls.MetroTabPage tpLocalMedia;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnRemove;
        private System.Windows.Forms.TableLayoutPanel tlpPcList;
        private MetroFramework.Controls.MetroListView lvPcList;
        private System.Windows.Forms.ColumnHeader chFileName;
        private System.Windows.Forms.ColumnHeader chFileDir;
        private System.Windows.Forms.ListBox lbStreamList; // ListBox는 변동 없음
        private System.Windows.Forms.TextBox txtVideoPath;
    }
}