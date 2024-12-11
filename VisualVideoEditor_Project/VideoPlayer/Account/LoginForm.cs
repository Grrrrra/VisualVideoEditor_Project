using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using VisualVideoEditor_Project.VideoEditor.Account; // AccountUser 네임스페이스 추가

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
                // 사용자 정보를 기반으로 AccountUser 객체 생성
                AccountUser loggedInUser = new AccountUser
                {
                    Username = Properties.Settings.Default.Username, // 저장된 사용자 이름 가져오기
                    UserId = userId, // 사용자 ID
                    Password = password // 패스워드
                };

                MessageBox.Show("로그인 성공!");

                // MainForm으로 이동
                MainForm mainForm = new MainForm(loggedInUser, this); // AccountUser 객체와 로그인 폼 인스턴스를 전달
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
    }
}
