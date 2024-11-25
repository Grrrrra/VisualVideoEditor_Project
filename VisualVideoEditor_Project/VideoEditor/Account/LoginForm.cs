using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace VisualVideoEditor_Project
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void metroButtonLogin_Click(object sender, EventArgs e)
        {
            string userId = metroTextBoxId.Text; // 아이디 입력 필드
            string password = metroTextBoxPassword.Text; // 패스워드 입력 필드

            // 사용자 인증 로직
            if (IsLoginValid(userId, password))
            {
                string username = Properties.Settings.Default.Username; // 저장된 사용자 이름 가져오기
                MessageBox.Show("로그인 성공!");
                // MainForm으로 이동
                MainForm mainForm = new MainForm(username, this);
                mainForm.Show(); // MainForm을 표시
                this.Hide(); // 현재 로그인 폼 숨기기
            }
            else
            {
                MessageBox.Show("로그인 정보가 잘못되었습니다.");
            }
        }

        private bool IsLoginValid(string userId, string password)
        {
            // 저장된 사용자 정보와 비교
            return userId == Properties.Settings.Default.UserId &&
                   password == Properties.Settings.Default.Password;
        }

        private void metroButtonCreateAccount_Click(object sender, EventArgs e)
        {
            // CreateAccount 폼을 로그인 폼 인스턴스를 인자로 전달하여 생성
            CreateAccount createAccountForm = new CreateAccount(this);
            createAccountForm.Show(); // 회원가입 폼을 표시
            this.Hide(); // 로그인 폼 숨기기
        }

        private bool CheckCredentials(string username, string password)
        {
            // 여기에 데이터베이스를 확인하고 사용자 인증을 수행합니다.
            // 예시로 간단한 조건을 사용합니다.
            return username == "testUser" && password == "testPassword"; // 예시: 고정된 사용자 정보
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // 폼 로드 시 필요한 초기화 작업
        }
    }
}
