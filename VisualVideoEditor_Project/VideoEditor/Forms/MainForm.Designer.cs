using LibVLCSharp.Shared;
<<<<<<< HEAD
using LibVLCSharp.WinForms;
=======
>>>>>>> 611bee9f20765e6f98f3e1019cdd106599328821
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
<<<<<<< HEAD
            this.오디오로_내보내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새프로젝트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.현재시간ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MainVideoView = new LibVLCSharp.WinForms.VideoView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnVideoPlayStop = new System.Windows.Forms.Button();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.timelineTimer = new System.Windows.Forms.Timer(this.components);
            this.mediaTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.urlTextBox = new MetroFramework.Controls.MetroTextBox();
            this.btnFavorites = new System.Windows.Forms.Button();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.totalDurationLabel = new MetroFramework.Controls.MetroLabel();
            this.currentTimeLabel = new MetroFramework.Controls.MetroLabel();
            this.durationCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.lblState = new MetroFramework.Controls.MetroLabel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainVideoView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
=======
            this.내보내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새프로젝트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.컷편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.실행취소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복구ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사본ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자르기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MainVideoView = new LibVLCSharp.WinForms.VideoView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelTimeline = new MetroFramework.Controls.MetroPanel();
            this.ModeSelect = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnVideoPlayStop = new System.Windows.Forms.Button();
            this.txtUrl = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.timelineTimer = new System.Windows.Forms.Timer(this.components);
            this.btnCutVideo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainVideoView)).BeginInit();
            this.ModeSelect.SuspendLayout();
>>>>>>> 611bee9f20765e6f98f3e1019cdd106599328821
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
<<<<<<< HEAD
=======
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
>>>>>>> 611bee9f20765e6f98f3e1019cdd106599328821
            this.menuStrip1.Font = new System.Drawing.Font("한컴 고딕", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.설정ToolStripMenuItem,
<<<<<<< HEAD
            this.닫기ToolStripMenuItem,
            this.현재시간ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(23, 75);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(904, 30);
=======
            this.컷편집ToolStripMenuItem,
            this.닫기ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(281, 58);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(757, 26);
>>>>>>> 611bee9f20765e6f98f3e1019cdd106599328821
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.가져오기ToolStripMenuItem,
<<<<<<< HEAD
            this.오디오로_내보내기ToolStripMenuItem,
            this.새프로젝트ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(200, 0, 4, 0);
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
=======
            this.내보내기ToolStripMenuItem,
            this.새프로젝트ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(200, 0, 4, 0);
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
>>>>>>> 611bee9f20765e6f98f3e1019cdd106599328821
            this.설정ToolStripMenuItem.Text = "파일";
            this.설정ToolStripMenuItem.Click += new System.EventHandler(this.설정ToolStripMenuItem_Click);
            // 
            // 가져오기ToolStripMenuItem
            // 
            this.가져오기ToolStripMenuItem.Name = "가져오기ToolStripMenuItem";
            this.가져오기ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.가져오기ToolStripMenuItem.Text = "가져오기";
            this.가져오기ToolStripMenuItem.Click += new System.EventHandler(this.가져오기ToolStripMenuItem_Click);
            // 
            // 내보내기ToolStripMenuItem
            // 
            this.내보내기ToolStripMenuItem.Name = "내보내기ToolStripMenuItem";
            this.내보내기ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.내보내기ToolStripMenuItem.Text = "내보내기";
            // 
            // 새프로젝트ToolStripMenuItem
            // 
            this.새프로젝트ToolStripMenuItem.Name = "새프로젝트ToolStripMenuItem";
            this.새프로젝트ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.새프로젝트ToolStripMenuItem.Text = "새 프로젝트";
            // 
            // 가져오기ToolStripMenuItem
            // 
<<<<<<< HEAD
            this.가져오기ToolStripMenuItem.Image = global::VisualVideoEditor_Project.Properties.Resources.free_icon_play_8029490;
            this.가져오기ToolStripMenuItem.Name = "가져오기ToolStripMenuItem";
            this.가져오기ToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.가져오기ToolStripMenuItem.Text = "가져오기";
            this.가져오기ToolStripMenuItem.Click += new System.EventHandler(this.가져오기ToolStripMenuItem_Click);
            // 
            // 오디오로_내보내기ToolStripMenuItem
            // 
            this.오디오로_내보내기ToolStripMenuItem.Image = global::VisualVideoEditor_Project.Properties.Resources.free_icon_play_8029490;
            this.오디오로_내보내기ToolStripMenuItem.Name = "오디오로_내보내기ToolStripMenuItem";
            this.오디오로_내보내기ToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.오디오로_내보내기ToolStripMenuItem.Text = "오디오로_내보내기";
            this.오디오로_내보내기ToolStripMenuItem.Click += new System.EventHandler(this.오디오로_내보내기ToolStripMenuItem_Click);
            // 
            // 새프로젝트ToolStripMenuItem
            // 
            this.새프로젝트ToolStripMenuItem.Image = global::VisualVideoEditor_Project.Properties.Resources.free_icon_pause_play_9513367;
            this.새프로젝트ToolStripMenuItem.Name = "새프로젝트ToolStripMenuItem";
            this.새프로젝트ToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.새프로젝트ToolStripMenuItem.Text = "새 프로젝트";
            this.새프로젝트ToolStripMenuItem.Click += new System.EventHandler(this.새프로젝트ToolStripMenuItem_Click);
=======
            this.컷편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.실행취소ToolStripMenuItem,
            this.복구ToolStripMenuItem,
            this.사본ToolStripMenuItem,
            this.자르기ToolStripMenuItem,
            this.붙여넣기ToolStripMenuItem,
            this.삭제ToolStripMenuItem});
            this.컷편집ToolStripMenuItem.Name = "컷편집ToolStripMenuItem";
            this.컷편집ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(200, 0, 4, 0);
            this.컷편집ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.컷편집ToolStripMenuItem.Text = "편집";
            // 
            // 실행취소ToolStripMenuItem
            // 
            this.실행취소ToolStripMenuItem.Name = "실행취소ToolStripMenuItem";
            this.실행취소ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.실행취소ToolStripMenuItem.Text = "실행취소";
            // 
            // 복구ToolStripMenuItem
            // 
            this.복구ToolStripMenuItem.Name = "복구ToolStripMenuItem";
            this.복구ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.복구ToolStripMenuItem.Text = "복구";
            // 
            // 사본ToolStripMenuItem
            // 
            this.사본ToolStripMenuItem.Name = "사본ToolStripMenuItem";
            this.사본ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.사본ToolStripMenuItem.Text = "사본";
            // 
            // 자르기ToolStripMenuItem
            // 
            this.자르기ToolStripMenuItem.Name = "자르기ToolStripMenuItem";
            this.자르기ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.자르기ToolStripMenuItem.Text = "자르기";
            // 
            // 붙여넣기ToolStripMenuItem
            // 
            this.붙여넣기ToolStripMenuItem.Name = "붙여넣기ToolStripMenuItem";
            this.붙여넣기ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.붙여넣기ToolStripMenuItem.Text = "붙여넣기";
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.삭제ToolStripMenuItem.Text = "삭제";
>>>>>>> 611bee9f20765e6f98f3e1019cdd106599328821
            // 
            // 닫기ToolStripMenuItem
            // 
            this.닫기ToolStripMenuItem.Name = "닫기ToolStripMenuItem";
            this.닫기ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(200, 0, 4, 0);
<<<<<<< HEAD
            this.닫기ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.닫기ToolStripMenuItem.Text = "폼 닫기";
            this.닫기ToolStripMenuItem.Click += new System.EventHandler(this.닫기ToolStripMenuItem_Click);
            // 
            // 현재시간ToolStripMenuItem
            // 
            this.현재시간ToolStripMenuItem.Name = "현재시간ToolStripMenuItem";
            this.현재시간ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(200, 0, 5, 0);
            this.현재시간ToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.현재시간ToolStripMenuItem.Text = "현재시간";
            this.현재시간ToolStripMenuItem.Click += new System.EventHandler(this.현재시간ToolStripMenuItem_Click);
            this.현재시간ToolStripMenuItem.MouseEnter += new System.EventHandler(this.현재시간ToolStripMenuItem_MouseEnter);
            this.현재시간ToolStripMenuItem.MouseLeave += new System.EventHandler(this.현재시간ToolStripMenuItem_MouseLeave);
=======
            this.닫기ToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.닫기ToolStripMenuItem.Text = "폼 닫기";
            this.닫기ToolStripMenuItem.Click += new System.EventHandler(this.닫기ToolStripMenuItem_Click);
>>>>>>> 611bee9f20765e6f98f3e1019cdd106599328821
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MainVideoView);
<<<<<<< HEAD
            this.groupBox1.Location = new System.Drawing.Point(26, 109);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(896, 504);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drag and Drop MP4 Here";
=======
            this.groupBox1.Location = new System.Drawing.Point(254, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(823, 403);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drag and Drop MP4 Here";
            // 
            // MainVideoView
            // 
            this.MainVideoView.AllowDrop = true;
            this.MainVideoView.BackColor = System.Drawing.Color.Black;
            this.MainVideoView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainVideoView.Location = new System.Drawing.Point(3, 17);
            this.MainVideoView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainVideoView.MediaPlayer = null;
            this.MainVideoView.Name = "MainVideoView";
            this.MainVideoView.Size = new System.Drawing.Size(817, 383);
            this.MainVideoView.TabIndex = 5;
            this.MainVideoView.Text = "videoView1";
            this.MainVideoView.Click += new System.EventHandler(this.MainVideoView_Click);
            this.MainVideoView.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainVideoView_DragDrop);
            this.MainVideoView.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainVideoView_DragEnter);
>>>>>>> 611bee9f20765e6f98f3e1019cdd106599328821
            // 
            // MainVideoView
            // 
<<<<<<< HEAD
            this.MainVideoView.AllowDrop = true;
            this.MainVideoView.BackColor = System.Drawing.Color.Black;
            this.MainVideoView.Location = new System.Drawing.Point(19, 26);
            this.MainVideoView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainVideoView.MediaPlayer = null;
            this.MainVideoView.Name = "MainVideoView";
            this.MainVideoView.Size = new System.Drawing.Size(854, 480);
            this.MainVideoView.TabIndex = 5;
            this.MainVideoView.Text = "videoView1";
            this.MainVideoView.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainVideoView_DragDrop);
            this.MainVideoView.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainVideoView_DragEnter);
=======
            this.groupBox2.Location = new System.Drawing.Point(12, 496);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1065, 201);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "stateBox";
            // 
            // panelTimeline
            // 
            this.panelTimeline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTimeline.HorizontalScrollbarBarColor = true;
            this.panelTimeline.HorizontalScrollbarHighlightOnWheel = false;
            this.panelTimeline.HorizontalScrollbarSize = 8;
            this.panelTimeline.Location = new System.Drawing.Point(20, 639);
            this.panelTimeline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTimeline.Name = "panelTimeline";
            this.panelTimeline.Size = new System.Drawing.Size(1052, 50);
            this.panelTimeline.TabIndex = 5;
            this.panelTimeline.VerticalScrollbarBarColor = true;
            this.panelTimeline.VerticalScrollbarHighlightOnWheel = false;
            this.panelTimeline.VerticalScrollbarSize = 9;
            this.panelTimeline.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTimeline_Paint);
>>>>>>> 611bee9f20765e6f98f3e1019cdd106599328821
            // 
            // btnClear
            // 
<<<<<<< HEAD
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("한컴 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(44, 4);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 31);
            this.btnClear.TabIndex = 1;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "클리어";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnVideoPlayStop
            // 
            this.btnVideoPlayStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVideoPlayStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideoPlayStop.Font = new System.Drawing.Font("한컴 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnVideoPlayStop.Location = new System.Drawing.Point(47, 43);
            this.btnVideoPlayStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVideoPlayStop.Name = "btnVideoPlayStop";
            this.btnVideoPlayStop.Size = new System.Drawing.Size(121, 32);
            this.btnVideoPlayStop.TabIndex = 0;
            this.btnVideoPlayStop.Text = "정지";
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
            this.mediaTrackBar.Location = new System.Drawing.Point(346, 3);
            this.mediaTrackBar.Name = "mediaTrackBar";
            this.mediaTrackBar.Size = new System.Drawing.Size(407, 32);
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
            this.urlTextBox.CustomButton.Location = new System.Drawing.Point(480, 1);
            this.urlTextBox.CustomButton.Name = "";
            this.urlTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.urlTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.urlTextBox.CustomButton.TabIndex = 1;
            this.urlTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.urlTextBox.CustomButton.UseSelectable = true;
            this.urlTextBox.CustomButton.Visible = false;
            this.urlTextBox.Font = new System.Drawing.Font("한컴 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.urlTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.urlTextBox.Lines = new string[0];
            this.urlTextBox.Location = new System.Drawing.Point(290, 655);
            this.urlTextBox.MaxLength = 32767;
            this.urlTextBox.Name = "UrlTextBox";
            this.urlTextBox.PasswordChar = '\0';
            this.urlTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.urlTextBox.SelectedText = "";
            this.urlTextBox.SelectionLength = 0;
            this.urlTextBox.SelectionStart = 0;
            this.urlTextBox.ShortcutsEnabled = true;
            this.urlTextBox.Size = new System.Drawing.Size(504, 25);
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
            this.btnFavorites.Location = new System.Drawing.Point(788, 43);
            this.btnFavorites.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(113, 32);
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
            this.htmlLabel1.Location = new System.Drawing.Point(680, 686);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(8, 8);
            this.htmlLabel1.TabIndex = 6;
            this.htmlLabel1.Text = "htmlLabel1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.488372F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.51163F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 416F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel1.Controls.Add(this.totalDurationLabel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFavorites, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.currentTimeLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.mediaTrackBar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnVideoPlayStop, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 614);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(904, 79);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // totalDurationLabel
            // 
            this.totalDurationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalDurationLabel.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.totalDurationLabel.Location = new System.Drawing.Point(762, 0);
            this.totalDurationLabel.Name = "totalDurationLabel";
            this.totalDurationLabel.Size = new System.Drawing.Size(139, 39);
            this.totalDurationLabel.TabIndex = 8;
            this.totalDurationLabel.Text = "00:00:00";
            this.totalDurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentTimeLabel.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.currentTimeLabel.Location = new System.Drawing.Point(211, 0);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(129, 39);
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
=======
            this.ModeSelect.Controls.Add(this.btnCutVideo);
            this.ModeSelect.Controls.Add(this.btnClear);
            this.ModeSelect.Controls.Add(this.btnVideoPlayStop);
            this.ModeSelect.Location = new System.Drawing.Point(12, 87);
            this.ModeSelect.Name = "ModeSelect";
            this.ModeSelect.Size = new System.Drawing.Size(236, 403);
            this.ModeSelect.TabIndex = 4;
            this.ModeSelect.TabStop = false;
            this.ModeSelect.Text = "ModeSelect";
            this.ModeSelect.Enter += new System.EventHandler(this.ModeSelect_Enter);
>>>>>>> 611bee9f20765e6f98f3e1019cdd106599328821
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("한컴 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClear.Location = new System.Drawing.Point(120, 343);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 54);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "클리어";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnVideoPlayStop
            // 
            this.btnVideoPlayStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideoPlayStop.Font = new System.Drawing.Font("한컴 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnVideoPlayStop.Location = new System.Drawing.Point(6, 343);
            this.btnVideoPlayStop.Name = "btnVideoPlayStop";
            this.btnVideoPlayStop.Size = new System.Drawing.Size(106, 54);
            this.btnVideoPlayStop.TabIndex = 0;
            this.btnVideoPlayStop.Text = "멈춤";
            this.btnVideoPlayStop.UseVisualStyleBackColor = true;
            this.btnVideoPlayStop.Click += new System.EventHandler(this.btnVideoPlayStop_Click);
            // 
            // txtUrl
            // 
            // 
            // 
            // 
            this.txtUrl.CustomButton.Image = null;
            this.txtUrl.CustomButton.Location = new System.Drawing.Point(572, 2);
            this.txtUrl.CustomButton.Name = "     ";
            this.txtUrl.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtUrl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUrl.CustomButton.TabIndex = 1;
            this.txtUrl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUrl.CustomButton.UseSelectable = true;
            this.txtUrl.CustomButton.Visible = false;
            this.txtUrl.Lines = new string[0];
            this.txtUrl.Location = new System.Drawing.Point(20, 470);
            this.txtUrl.MaxLength = 32767;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.PasswordChar = '\0';
            this.txtUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUrl.SelectedText = "";
            this.txtUrl.SelectionLength = 0;
            this.txtUrl.SelectionStart = 0;
            this.txtUrl.ShortcutsEnabled = true;
            this.txtUrl.Size = new System.Drawing.Size(600, 30);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.UseSelectable = true;
            this.txtUrl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUrl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(886, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "현재 시간";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(0, 0);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.TabIndex = 0;
            this.metroCheckBox1.UseSelectable = true;
            // 
            // btnCutVideo
            // 
            this.btnCutVideo.Location = new System.Drawing.Point(6, 20);
            this.btnCutVideo.Name = "btnCutVideo";
            this.btnCutVideo.Size = new System.Drawing.Size(224, 51);
            this.btnCutVideo.TabIndex = 6;
            this.btnCutVideo.Text = "영상 컷 편집 ";
            this.btnCutVideo.UseVisualStyleBackColor = true;
            this.btnCutVideo.Click += new System.EventHandler(this.btnCutVideo_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(950, 705);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
=======
            this.ClientSize = new System.Drawing.Size(1092, 709);
            this.Controls.Add(this.panelTimeline);
            this.Controls.Add(this.ModeSelect);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
>>>>>>> 611bee9f20765e6f98f3e1019cdd106599328821
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
<<<<<<< HEAD
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
=======
            this.Load += new System.EventHandler(this.Form1_Load);
>>>>>>> 611bee9f20765e6f98f3e1019cdd106599328821
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainVideoView)).EndInit();
<<<<<<< HEAD
            this.tableLayoutPanel1.ResumeLayout(false);
=======
            this.ModeSelect.ResumeLayout(false);
>>>>>>> 611bee9f20765e6f98f3e1019cdd106599328821
            this.ResumeLayout(false);
            this.PerformLayout();

        }
<<<<<<< HEAD
=======
        private void InitializeStyleManager()
        {
            styleManager = new MetroStyleManager();
            styleManager.Owner = this; // 스타일 매니저의 소유자를 현재 폼으로 설정
            this.StyleManager = styleManager; // 폼의 스타일 매니저 설정
            this.StyleManager.Style = MetroFramework.MetroColorStyle.Magenta; // 레드 테마
            this.StyleManager.Theme = MetroFramework.MetroThemeStyle.Light; // 다크 테마
        }
        private void InitializeLibVLC()
        {
            Core.Initialize(); // LibVLC 초기화
            _libVLC = new LibVLC(); // LibVLC 인스턴스 생성
            _mp = new MediaPlayer(_libVLC); // MediaPlayer 인스턴스 생성
                                            // MediaPlayer를 MainVideoView에 설정
            try
            {
                MainVideoView.MediaPlayer = _mp; // 비디오 뷰에 MediaPlayer 설정
            }
            catch (Exception ex)
            {
                MessageBox.Show($"MediaPlayer 설정 중 오류 발생: {ex.Message}");
            }
        }
        private void InitializeTimer()
        {
            timelineTimer = new System.Windows.Forms.Timer();
            timelineTimer.Interval = 100; // 100ms 간격으로 업데이트
            timelineTimer.Tick += (s, e) => UpdateTimeline(); // 타임라인 업데이트
            timelineTimer.Start();
        }
        private void InitializeDragAndDrop()
        {
            MainVideoView.AllowDrop = true; // 드래그 앤 드롭 허용
            MainVideoView.DragEnter += MainVideoView_DragEnter; // 드래그 진입 이벤트
            MainVideoView.DragDrop += MainVideoView_DragDrop; // 드래그 드롭 이벤트
        }

        private void GroupBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void GroupBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (Path.GetExtension(file).ToLower() == ".mp4")
                {
                }
                else
                {
                    MessageBox.Show("MP4 파일만 드래그 앤 드랍할 수 있습니다.");
                }
            }
        }
>>>>>>> 611bee9f20765e6f98f3e1019cdd106599328821
        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
<<<<<<< HEAD
=======
        private System.Windows.Forms.ToolStripMenuItem 컷편집ToolStripMenuItem;
>>>>>>> 611bee9f20765e6f98f3e1019cdd106599328821
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

<<<<<<< HEAD

        private MetroTrackBar mediaTrackBar;
        private MetroTextBox urlTextBox;
        private Button btnFavorites;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private ToolStripMenuItem 현재시간ToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private MetroLabel totalDurationLabel;
        private Timer timelineTimer;
        private MetroLabel lblState;
=======
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox ModeSelect;
        private LibVLCSharp.WinForms.VideoView MainVideoView;
        private MetroTextBox txtUrl;
        private MetroPanel panelTimeline;
        private ToolStripMenuItem 닫기ToolStripMenuItem;
        private ToolStripMenuItem 가져오기ToolStripMenuItem;
        private ToolStripMenuItem 내보내기ToolStripMenuItem;
        private ToolStripMenuItem 새프로젝트ToolStripMenuItem;
        private ToolStripMenuItem 실행취소ToolStripMenuItem;
        private ToolStripMenuItem 복구ToolStripMenuItem;
        private ToolStripMenuItem 사본ToolStripMenuItem;
        private ToolStripMenuItem 자르기ToolStripMenuItem;
        private ToolStripMenuItem 붙여넣기ToolStripMenuItem;
        private ToolStripMenuItem 삭제ToolStripMenuItem;
        private MetroLabel label1;
        private MetroCheckBox metroCheckBox1;
        private Button btnVideoPlayStop;
        private Button btnClear;
        private Timer timelineTimer;
        private Button btnCutVideo;
>>>>>>> 611bee9f20765e6f98f3e1019cdd106599328821
    }
}

