namespace VisualVideoEditor_Project
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.SettingLogin = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.IDlabel = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.Pwdlabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnNewLogin = new System.Windows.Forms.Button();
            this.stateLoginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SettingLogin
            // 
            this.SettingLogin.AutoSize = true;
            this.SettingLogin.Font = new System.Drawing.Font("한컴 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SettingLogin.Location = new System.Drawing.Point(114, 24);
            this.SettingLogin.Name = "SettingLogin";
            this.SettingLogin.Size = new System.Drawing.Size(206, 31);
            this.SettingLogin.TabIndex = 0;
            this.SettingLogin.Text = "안녕하세요. 퀵컷입니다.";
            this.SettingLogin.UseCompatibleTextRendering = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 21);
            this.textBox1.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(57, 218);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(141, 54);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(87, 88);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(41, 12);
            this.IDlabel.TabIndex = 3;
            this.IDlabel.Text = "아이디";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(238, 218);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 54);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "종료";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // Pwdlabel
            // 
            this.Pwdlabel.AutoSize = true;
            this.Pwdlabel.Location = new System.Drawing.Point(87, 146);
            this.Pwdlabel.Name = "Pwdlabel";
            this.Pwdlabel.Size = new System.Drawing.Size(53, 12);
            this.Pwdlabel.TabIndex = 5;
            this.Pwdlabel.Text = "비밀번호";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 21);
            this.textBox2.TabIndex = 6;
            // 
            // btnNewLogin
            // 
            this.btnNewLogin.Location = new System.Drawing.Point(150, 193);
            this.btnNewLogin.Name = "btnNewLogin";
            this.btnNewLogin.Size = new System.Drawing.Size(141, 19);
            this.btnNewLogin.TabIndex = 7;
            this.btnNewLogin.Text = "회원가입";
            this.btnNewLogin.UseVisualStyleBackColor = true;
            // 
            // stateLoginLabel
            // 
            this.stateLoginLabel.AutoSize = true;
            this.stateLoginLabel.Location = new System.Drawing.Point(67, 307);
            this.stateLoginLabel.Name = "stateLoginLabel";
            this.stateLoginLabel.Size = new System.Drawing.Size(109, 12);
            this.stateLoginLabel.TabIndex = 8;
            this.stateLoginLabel.Text = "로그인을 해주세요.";
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(433, 348);
            this.Controls.Add(this.stateLoginLabel);
            this.Controls.Add(this.btnNewLogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Pwdlabel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SettingLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SettingLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label Pwdlabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnNewLogin;
        private System.Windows.Forms.Label stateLoginLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}