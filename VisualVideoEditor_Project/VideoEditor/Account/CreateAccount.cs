using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using VisualVideoEditor_Project.VideoEditor.Account;

namespace VisualVideoEditor_Project
{
    public partial class CreateAccount : MetroForm
    {
        private LoginForm loginForm; // 로그인 폼 인스턴스를 저장할 변수
        private IUserInfo userInfo; // IUserInfo 인터페이스 인스턴스

        public CreateAccount(LoginForm form) // 로그인 폼을 인자로 받음
        {
            InitializeComponent();
            this.loginForm = form; // 로그인 폼 인스턴스 초기화
            userInfo = new UserInfo(); // UserInfo 인스턴스 초기화
            // 텍스트박스의 TextChanged 이벤트에 핸들러 추가
            metroTextBoxUserName.TextChanged += TextBox_TextChanged;
            metroTextBoxId.TextChanged += TextBox_TextChanged;
            metroTextBoxPassword.TextChanged += TextBox_TextChanged;
            metroTextBoxReEnter.TextChanged += TextBox_TextChanged; // 비밀번호 재입력 박스 추가
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            // 저장된 회원가입 정보를 불러옵니다.
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            try
            {
                metroTextBoxUserName.Text = Properties.Settings.Default.Username;
                metroTextBoxId.Text = Properties.Settings.Default.UserId;
                metroTextBoxPassword.Text = Properties.Settings.Default.Password;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"정보 불러오기 오류: {ex.Message}");
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // 초기 상태에서 버튼 비활성화
            metroButtonCreateAccount.Enabled = false;

            // 조건 1: 닉네임이 영어 또는 한글로만 구성되어 있는지 확인
            bool isUserNameValid = !string.IsNullOrWhiteSpace(metroTextBoxUserName.Text) &&
                                   System.Text.RegularExpressions.Regex.IsMatch(metroTextBoxUserName.Text, @"^[a-zA-Z가-힣]+$");

            // 조건 2: 패스워드와 패스워드 재입력 확인
            bool isPasswordValid = !string.IsNullOrWhiteSpace(metroTextBoxPassword.Text) &&
                                   metroTextBoxPassword.Text == metroTextBoxReEnter.Text;

            // 조건 3: 모든 텍스트 박스가 비어있지 않은지 확인
            bool isUserIdValid = !string.IsNullOrWhiteSpace(metroTextBoxId.Text);

            // 모든 조건이 만족하면 버튼 활성화
            metroButtonCreateAccount.Enabled = isUserNameValid && isUserIdValid && isPasswordValid;
        }

        private void metroButtonCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                userInfo.Username = metroTextBoxUserName.Text;
                userInfo.UserId = metroTextBoxId.Text;
                userInfo.Password = metroTextBoxPassword.Text;
                userInfo.LastAccessDate = DateTime.Now; // 현재 날짜로 설정

                if (userInfo.IsUserExists(userInfo.Username, userInfo.UserId))
                {
                    MessageBox.Show("이미 존재하는 회원입니다.");
                    return;
                }

                userInfo.Save(); // 사용자 정보 저장
                MessageBox.Show("회원가입이 완료되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"회원가입 오류: {ex.Message}");
            }
        }

        private void metroButtonGoBack_Click(object sender, EventArgs e)
        {
            this.loginForm.Show(); // 로그인 폼을 다시 표시
            this.Close(); // 현재 CreateAccount 폼을 닫음
        }

        private void metroButtonReset_Click(object sender, EventArgs e)
        {
            try
            {
                userInfo.Reset(); // UserInfo 클래스의 Reset 메서드 호출
                MessageBox.Show("회원 정보가 초기화되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"초기화 오류: {ex.Message}");
            }
        }
    }
}
