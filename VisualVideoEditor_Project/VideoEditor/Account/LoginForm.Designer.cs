namespace VisualVideoEditor_Project
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxId = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonLogin = new MetroFramework.Controls.MetroButton();
            this.metroButtonCreateAccount = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "아이디";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 120);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "패스워드";
            // 
            // metroTextBoxId
            // 
      
            this.metroTextBoxId.CustomButton.Image = null;
            this.metroTextBoxId.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.metroTextBoxId.CustomButton.Name = "";
            this.metroTextBoxId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxId.CustomButton.TabIndex = 1;
            this.metroTextBoxId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxId.CustomButton.UseSelectable = true;
            this.metroTextBoxId.CustomButton.Visible = false;
            this.metroTextBoxId.Lines = new string[0];
            this.metroTextBoxId.Location = new System.Drawing.Point(100, 60);
            this.metroTextBoxId.MaxLength = 32767;
            this.metroTextBoxId.Name = "metroTextBoxId";
            this.metroTextBoxId.PasswordChar = '\0';
            this.metroTextBoxId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxId.SelectedText = "";
            this.metroTextBoxId.SelectionLength = 0;
            this.metroTextBoxId.SelectionStart = 0;
            this.metroTextBoxId.ShortcutsEnabled = true;
            this.metroTextBoxId.Size = new System.Drawing.Size(200, 23);
            this.metroTextBoxId.TabIndex = 2;
            this.metroTextBoxId.UseSelectable = true;
            this.metroTextBoxId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);

            // 
            // metroTextBoxPassword
            // 
            // 
            // 
            // 
            this.metroTextBoxPassword.CustomButton.Image = null;
            this.metroTextBoxPassword.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.metroTextBoxPassword.CustomButton.Name = "";
            this.metroTextBoxPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPassword.CustomButton.TabIndex = 1;
            this.metroTextBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPassword.CustomButton.UseSelectable = true;
            this.metroTextBoxPassword.CustomButton.Visible = false;
            this.metroTextBoxPassword.Lines = new string[0];
            this.metroTextBoxPassword.Location = new System.Drawing.Point(100, 120);
            this.metroTextBoxPassword.MaxLength = 32767;
            this.metroTextBoxPassword.Name = "metroTextBoxPassword";
            this.metroTextBoxPassword.PasswordChar = '*';
            this.metroTextBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPassword.SelectedText = "";
            this.metroTextBoxPassword.SelectionLength = 0;
            this.metroTextBoxPassword.SelectionStart = 0;
            this.metroTextBoxPassword.ShortcutsEnabled = true;
            this.metroTextBoxPassword.Size = new System.Drawing.Size(200, 23);
            this.metroTextBoxPassword.TabIndex = 3;
            this.metroTextBoxPassword.UseSelectable = true;
            this.metroTextBoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonLogin
            // 
            this.metroButtonLogin.BackColor = System.Drawing.Color.Khaki;
            this.metroButtonLogin.Location = new System.Drawing.Point(100, 160);
            this.metroButtonLogin.Name = "metroButtonLogin";
            this.metroButtonLogin.Size = new System.Drawing.Size(75, 23);
            this.metroButtonLogin.TabIndex = 4;
            this.metroButtonLogin.Text = "로그인";
            this.metroButtonLogin.UseSelectable = true;
            this.metroButtonLogin.Click += new System.EventHandler(this.metroButtonLogin_Click);
            // 
            // metroButtonCreateAccount
            // 
            this.metroButtonCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.metroButtonCreateAccount.Location = new System.Drawing.Point(200, 160);
            this.metroButtonCreateAccount.Name = "metroButtonCreateAccount";
            this.metroButtonCreateAccount.Size = new System.Drawing.Size(100, 23);
            this.metroButtonCreateAccount.TabIndex = 5;
            this.metroButtonCreateAccount.Text = "회원가입";
            this.metroButtonCreateAccount.UseSelectable = true;
            this.metroButtonCreateAccount.Click += new System.EventHandler(this.metroButtonCreateAccount_Click);
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 220);
            this.Controls.Add(this.metroButtonCreateAccount);
            this.Controls.Add(this.metroButtonLogin);
            this.Controls.Add(this.metroTextBoxPassword);
            this.Controls.Add(this.metroTextBoxId);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "LoginForm";
            this.Text = "로그인";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxId; // 아이디 입력 TextBox
        private MetroFramework.Controls.MetroTextBox metroTextBoxPassword; // 패스워드 입력 TextBox
        private MetroFramework.Controls.MetroButton metroButtonLogin; // 로그인 버튼
        private MetroFramework.Controls.MetroButton metroButtonCreateAccount; // 회원가입 버튼
    }
}
