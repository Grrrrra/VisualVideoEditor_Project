using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;
using MetroFramework.Controls;
using System.Configuration; // 설정 파일을 다루기 위한 네임스페이스


namespace VisualVideoEditor_Project
{
    public partial class MainForm : MetroForm
    {

        private MetroButton metroButton1;
        private MetroTextBox metroTextBox1;
        private LoginForm loginForm;
        private MetroStyleManager styleManager;

        public MainForm(string username, LoginForm form)
        {
            InitializeComponent();
            InitializeStyleManager();
            InitializeDragAndDrop();
            LoadSettings(); // 설정 로드

            SetGreetingMessage(username); // 인사 메시지 설정
            this.loginForm = form; // 로그인 폼 인스턴스를 저장
            this.FormClosing += MainForm_FormClosing;

        }
        private void LoadSettings()
        {
            // 설정에서 값 로드 (예: LastAccessDate)
            if (Properties.Settings.Default.LastAccessDate != DateTime.MinValue)
            {
                DateTime lastAccessDate = Properties.Settings.Default.LastAccessDate;
                // 추가 로직이 필요할 수 있습니다.
            }
        }
        private void SaveSettings()
        {
            // 설정 저장 (예: LastAccessDate)
            Properties.Settings.Default.LastAccessDate = DateTime.Now;
            Properties.Settings.Default.Save();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 프로그램 종료 시 로그인 폼도 닫기
            if (loginForm != null && !loginForm.IsDisposed)
            {
                loginForm.Close(); // 로그인 폼 종료
            //로그인 폼이 지금 시작 폼으로 설정되어 있어서 this.Hide()된 폼을 MainForm.cs파일 종료시 같이 종료시켜 프로그램을 완전히 종료시키는 경우,
            //프로그램을 완전히 종료시킴.
            }
        }
      
        private void 도움말ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ModeSelect_Enter(object sender, EventArgs e)
        {
            
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼이 클릭되었습니다!");
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
