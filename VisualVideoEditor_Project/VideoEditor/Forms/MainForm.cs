using System;
using System.Drawing; // Graphics 사용을 위한 네임스페이스
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework.Components;

namespace VisualVideoEditor_Project
{
    public partial class MainForm : MetroForm
    {
        private LoginForm loginForm; // 로그인 폼 인스턴스
        private MetroStyleManager styleManager; // 스타일 매니저
        private string username; // 사용자 이름 저장

        public MainForm(string username, LoginForm form)
        {
            InitializeComponent();
            InitializeStyleManager();
            InitializeDragAndDrop();
            LoadSettings(); // 설정 로드

            this.username = username; // 사용자 이름 저장
            SetGreetingMessage(); // 인사 메시지 설정
            this.loginForm = form; // 로그인 폼 인스턴스 저장
            this.FormClosing += MainForm_FormClosing; // 폼 종료 이벤트 핸들러 추가
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
            }
        }

        private void SetGreetingMessage()
        {
            // MetroForm의 제목을 사용자 이름을 포함한 인사 메시지로 설정
            this.Text = $"안녕하세요! {username}님! Quickcut에 오신 것을 환영합니다!";
        }

        private void 도움말ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 도움말 메뉴 클릭 시 동작
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 폼 로드 시 필요한 초기화 작업
        }

        private void ModeSelect_Enter(object sender, EventArgs e)
        {
            // 모드 선택 시 동작
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
            // 레이블 클릭 시 동작
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // 그룹 박스 1 진입 시 동작
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            // 그룹 박스 2 진입 시 동작
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼이 클릭되었습니다!");
        }
    }
}
