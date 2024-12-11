using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace VisualVideoEditor_Project
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.가져오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.오디오로_내보내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새프로젝트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.현재시간ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MainVideoView = new LibVLCSharp.WinForms.VideoView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnVideoPlayStop = new System.Windows.Forms.Button();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.mediaTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.urlTextBox = new MetroFramework.Controls.MetroTextBox();
            this.btnFavorites = new System.Windows.Forms.Button();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.totalDurationLabel = new MetroFramework.Controls.MetroLabel();
            this.currentTimeLabel = new MetroFramework.Controls.MetroLabel();
            this.lblState = new MetroFramework.Controls.MetroLabel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainVideoView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("한컴 고딕", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.설정ToolStripMenuItem,
            this.닫기ToolStripMenuItem,
            this.현재시간ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(23, 75);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(16, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1040, 26);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.가져오기ToolStripMenuItem,
            this.오디오로_내보내기ToolStripMenuItem,
            this.새프로젝트ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(200, 0, 4, 0);
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.설정ToolStripMenuItem.Text = "파일";
            // 
            // 가져오기ToolStripMenuItem
            // 
            this.가져오기ToolStripMenuItem.Image = global::VisualVideoEditor_Project.Properties.Resources.free_icon_play_8029490;
            this.가져오기ToolStripMenuItem.Name = "가져오기ToolStripMenuItem";
            this.가져오기ToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.가져오기ToolStripMenuItem.Text = "가져오기";
            this.가져오기ToolStripMenuItem.Click += new System.EventHandler(this.가져오기ToolStripMenuItem_Click);
            // 
            // 오디오로_내보내기ToolStripMenuItem
            // 
            this.오디오로_내보내기ToolStripMenuItem.Image = global::VisualVideoEditor_Project.Properties.Resources.free_icon_play_8029490;
            this.오디오로_내보내기ToolStripMenuItem.Name = "오디오로_내보내기ToolStripMenuItem";
            this.오디오로_내보내기ToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.오디오로_내보내기ToolStripMenuItem.Text = "오디오로_내보내기";
            this.오디오로_내보내기ToolStripMenuItem.Click += new System.EventHandler(this.오디오로_내보내기ToolStripMenuItem_Click);
            // 
            // 새프로젝트ToolStripMenuItem
            // 
            this.새프로젝트ToolStripMenuItem.Image = global::VisualVideoEditor_Project.Properties.Resources.free_icon_pause_play_9513367;
            this.새프로젝트ToolStripMenuItem.Name = "새프로젝트ToolStripMenuItem";
            this.새프로젝트ToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.새프로젝트ToolStripMenuItem.Text = "새 프로젝트";
            this.새프로젝트ToolStripMenuItem.Click += new System.EventHandler(this.새프로젝트ToolStripMenuItem_Click);
            // 
            // 닫기ToolStripMenuItem
            // 
            this.닫기ToolStripMenuItem.Name = "닫기ToolStripMenuItem";
            this.닫기ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(200, 0, 4, 0);
            this.닫기ToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.닫기ToolStripMenuItem.Text = "폼 닫기";
            this.닫기ToolStripMenuItem.Click += new System.EventHandler(this.닫기ToolStripMenuItem_Click);
            // 
            // 현재시간ToolStripMenuItem
            // 
            this.현재시간ToolStripMenuItem.Name = "현재시간ToolStripMenuItem";
            this.현재시간ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(200, 0, 5, 0);
            this.현재시간ToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.현재시간ToolStripMenuItem.Text = "현재시간";
            this.현재시간ToolStripMenuItem.Click += new System.EventHandler(this.현재시간ToolStripMenuItem_Click);
            this.현재시간ToolStripMenuItem.MouseLeave += new System.EventHandler(this.현재시간ToolStripMenuItem_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MainVideoView);
            this.groupBox1.Location = new System.Drawing.Point(30, 136);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(1024, 630);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drag and Drop MP4 Here";
            // 
            // MainVideoView
            // 
            this.MainVideoView.AllowDrop = true;
            this.MainVideoView.BackColor = System.Drawing.Color.Black;
            this.MainVideoView.Location = new System.Drawing.Point(22, 32);
            this.MainVideoView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainVideoView.MediaPlayer = null;
            this.MainVideoView.Name = "MainVideoView";
            this.MainVideoView.Size = new System.Drawing.Size(976, 600);
            this.MainVideoView.TabIndex = 5;
            this.MainVideoView.Text = "videoView1";
            this.MainVideoView.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainVideoView_DragDrop);
            this.MainVideoView.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainVideoView_DragEnter);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("한컴 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClear.Location = new System.Drawing.Point(58, 5);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 39);
            this.btnClear.TabIndex = 1;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "클리어";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnVideoPlayStop
            // 
            this.btnVideoPlayStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVideoPlayStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideoPlayStop.Font = new System.Drawing.Font("한컴 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnVideoPlayStop.Location = new System.Drawing.Point(61, 54);
            this.btnVideoPlayStop.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnVideoPlayStop.Name = "btnVideoPlayStop";
            this.btnVideoPlayStop.Size = new System.Drawing.Size(121, 40);
            this.btnVideoPlayStop.TabIndex = 0;
            this.btnVideoPlayStop.Text = "일시 정지";
            this.btnVideoPlayStop.UseVisualStyleBackColor = true;
            this.btnVideoPlayStop.Click += new System.EventHandler(this.btnVideoPlayStop_Click);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(0, 0);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.TabIndex = 0;
            this.metroCheckBox1.UseSelectable = true;
            // 
            // mediaTrackBar
            // 
            this.mediaTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.mediaTrackBar.Location = new System.Drawing.Point(392, 4);
            this.mediaTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mediaTrackBar.Name = "mediaTrackBar";
            this.mediaTrackBar.Size = new System.Drawing.Size(465, 40);
            this.mediaTrackBar.TabIndex = 4;
            this.mediaTrackBar.Text = "metroTrackBar1";
            this.mediaTrackBar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mediaTrackBar.UseWaitCursor = true;
            this.mediaTrackBar.Value = 0;
            this.mediaTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.mediaTrackBar_Scroll);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.urlTextBox.CustomButton.Image = null;
            this.urlTextBox.CustomButton.Location = new System.Drawing.Point(546, 1);
            this.urlTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.urlTextBox.CustomButton.Name = "";
            this.urlTextBox.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.urlTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.urlTextBox.CustomButton.TabIndex = 1;
            this.urlTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.urlTextBox.CustomButton.UseSelectable = true;
            this.urlTextBox.CustomButton.Visible = false;
            this.urlTextBox.Font = new System.Drawing.Font("한컴 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.urlTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.urlTextBox.Lines = new string[0];
            this.urlTextBox.Location = new System.Drawing.Point(331, 819);
            this.urlTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.urlTextBox.MaxLength = 32767;
            this.urlTextBox.Name = "UrlTextBox";
            this.urlTextBox.PasswordChar = '\0';
            this.urlTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.urlTextBox.SelectedText = "";
            this.urlTextBox.SelectionLength = 0;
            this.urlTextBox.SelectionStart = 0;
            this.urlTextBox.ShortcutsEnabled = true;
            this.urlTextBox.Size = new System.Drawing.Size(576, 31);
            this.urlTextBox.Style = MetroFramework.MetroColorStyle.Green;
            this.urlTextBox.TabIndex = 0;
            this.urlTextBox.UseSelectable = true;
            this.urlTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.urlTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.urlTextBox.Click += new System.EventHandler(this.urlTextBox_Click);
            this.urlTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlTextBox_KeyDown);
            // 
            // btnFavorites
            // 
            this.btnFavorites.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFavorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorites.Font = new System.Drawing.Font("한컴 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFavorites.Location = new System.Drawing.Point(901, 54);
            this.btnFavorites.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(129, 40);
            this.btnFavorites.TabIndex = 5;
            this.btnFavorites.Text = "즐겨찾기";
            this.btnFavorites.UseVisualStyleBackColor = true;
            this.btnFavorites.Click += new System.EventHandler(this.btnFavorites_Click);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(80, 25);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(777, 858);
            this.htmlLabel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(9, 10);
            this.htmlLabel1.TabIndex = 6;
            this.htmlLabel1.Text = "htmlLabel1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.488372F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.51163F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 475F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.Controls.Add(this.totalDurationLabel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFavorites, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.currentTimeLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.mediaTrackBar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnVideoPlayStop, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 768);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1033, 99);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // totalDurationLabel
            // 
            this.totalDurationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalDurationLabel.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.totalDurationLabel.Location = new System.Drawing.Point(867, 0);
            this.totalDurationLabel.Name = "totalDurationLabel";
            this.totalDurationLabel.Size = new System.Drawing.Size(163, 49);
            this.totalDurationLabel.TabIndex = 8;
            this.totalDurationLabel.Text = "00:00:00";
            this.totalDurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentTimeLabel.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.currentTimeLabel.Location = new System.Drawing.Point(238, 0);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(148, 49);
            this.currentTimeLabel.TabIndex = 2;
            this.currentTimeLabel.Text = "00:00:00";
            this.currentTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(0, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(100, 23);
            this.lblState.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1086, 881);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(23, 75, 23, 25);
            this.Text = "mainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainVideoView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;


        private System.Windows.Forms.GroupBox groupBox1;
        private LibVLCSharp.WinForms.VideoView MainVideoView;
        private ToolStripMenuItem 닫기ToolStripMenuItem;
        private ToolStripMenuItem 가져오기ToolStripMenuItem;
        private ToolStripMenuItem 오디오로_내보내기ToolStripMenuItem;
        private ToolStripMenuItem 새프로젝트ToolStripMenuItem;
        private MetroLabel currentTimeLabel;
        private MetroCheckBox metroCheckBox1;
        private Button btnVideoPlayStop;
        private Button btnClear;

        private MetroTrackBar mediaTrackBar;
        private MetroTextBox urlTextBox;
        private Button btnFavorites;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private ToolStripMenuItem 현재시간ToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private MetroLabel totalDurationLabel;
        private MetroLabel lblState;

    }
}

