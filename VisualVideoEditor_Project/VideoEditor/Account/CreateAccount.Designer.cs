namespace VisualVideoEditor_Project
{
    partial class CreateAccount
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">true면 관리되는 리소스를 삭제합니다. 그렇지 않으면 해당 리소스를 무시합니다.</param>
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
        /// 이 메서드는 디자이너에서 요구할 때 사용할 수 있습니다.
        /// 사용자가 코드를 수정하지 않도록 코드를 편집하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabelUserName = new MetroFramework.Controls.MetroLabel();
            this.metroLabelId = new MetroFramework.Controls.MetroLabel();
            this.metroLabelPassword = new MetroFramework.Controls.MetroLabel();
            this.metroLabelReEnter = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxUserName = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxId = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxReEnter = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonCreateAccount = new MetroFramework.Controls.MetroButton();
            this.metroButtonGoBack = new MetroFramework.Controls.MetroButton();
            this.metroButtonReset = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabelUserName
            // 
            this.metroLabelUserName.AutoSize = true;
            this.metroLabelUserName.Location = new System.Drawing.Point(27, 55);
            this.metroLabelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelUserName.Name = "metroLabelUserName";
            this.metroLabelUserName.Size = new System.Drawing.Size(83, 19);
            this.metroLabelUserName.TabIndex = 0;
            this.metroLabelUserName.Text = "사용자 이름";
            // 
            // metroLabelId
            // 
            this.metroLabelId.AutoSize = true;
            this.metroLabelId.Location = new System.Drawing.Point(27, 92);
            this.metroLabelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelId.Name = "metroLabelId";
            this.metroLabelId.Size = new System.Drawing.Size(21, 19);
            this.metroLabelId.TabIndex = 1;
            this.metroLabelId.Text = "ID";
            // 
            // metroLabelPassword
            // 
            this.metroLabelPassword.AutoSize = true;
            this.metroLabelPassword.Location = new System.Drawing.Point(27, 129);
            this.metroLabelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelPassword.Name = "metroLabelPassword";
            this.metroLabelPassword.Size = new System.Drawing.Size(65, 19);
            this.metroLabelPassword.TabIndex = 2;
            this.metroLabelPassword.Text = "패스워드";
            // 
            // metroLabelReEnter
            // 
            this.metroLabelReEnter.AutoSize = true;
            this.metroLabelReEnter.Location = new System.Drawing.Point(27, 166);
            this.metroLabelReEnter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelReEnter.Name = "metroLabelReEnter";
            this.metroLabelReEnter.Size = new System.Drawing.Size(111, 19);
            this.metroLabelReEnter.TabIndex = 3;
            this.metroLabelReEnter.Text = "패스워드 재입력";
            // 
            // metroTextBoxUserName
            // 
            this.metroTextBoxUserName.CustomButton.Image = null;
            this.metroTextBoxUserName.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.metroTextBoxUserName.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroTextBoxUserName.CustomButton.Name = "";
            this.metroTextBoxUserName.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBoxUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxUserName.CustomButton.TabIndex = 1;
            this.metroTextBoxUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxUserName.CustomButton.UseSelectable = true;
            this.metroTextBoxUserName.CustomButton.Visible = false;
            this.metroTextBoxUserName.Lines = new string[0];
            this.metroTextBoxUserName.Location = new System.Drawing.Point(163, 55);
            this.metroTextBoxUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroTextBoxUserName.MaxLength = 32767;
            this.metroTextBoxUserName.Name = "metroTextBoxUserName";
            this.metroTextBoxUserName.PasswordChar = '\0';
            this.metroTextBoxUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxUserName.SelectedText = "";
            this.metroTextBoxUserName.SelectionLength = 0;
            this.metroTextBoxUserName.SelectionStart = 0;
            this.metroTextBoxUserName.ShortcutsEnabled = true;
            this.metroTextBoxUserName.Size = new System.Drawing.Size(233, 21);
            this.metroTextBoxUserName.TabIndex = 4;
            this.metroTextBoxUserName.UseSelectable = true;
            this.metroTextBoxUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxId
            // 
            // 
            // 
            // 
            this.metroTextBoxId.CustomButton.Image = null;
            this.metroTextBoxId.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.metroTextBoxId.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroTextBoxId.CustomButton.Name = "";
            this.metroTextBoxId.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBoxId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxId.CustomButton.TabIndex = 1;
            this.metroTextBoxId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxId.CustomButton.UseSelectable = true;
            this.metroTextBoxId.CustomButton.Visible = false;
            this.metroTextBoxId.Lines = new string[0];
            this.metroTextBoxId.Location = new System.Drawing.Point(163, 92);
            this.metroTextBoxId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroTextBoxId.MaxLength = 32767;
            this.metroTextBoxId.Name = "metroTextBoxId";
            this.metroTextBoxId.PasswordChar = '\0';
            this.metroTextBoxId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxId.SelectedText = "";
            this.metroTextBoxId.SelectionLength = 0;
            this.metroTextBoxId.SelectionStart = 0;
            this.metroTextBoxId.ShortcutsEnabled = true;
            this.metroTextBoxId.Size = new System.Drawing.Size(233, 21);
            this.metroTextBoxId.TabIndex = 5;
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
            this.metroTextBoxPassword.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.metroTextBoxPassword.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroTextBoxPassword.CustomButton.Name = "";
            this.metroTextBoxPassword.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPassword.CustomButton.TabIndex = 1;
            this.metroTextBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPassword.CustomButton.UseSelectable = true;
            this.metroTextBoxPassword.CustomButton.Visible = false;
            this.metroTextBoxPassword.Lines = new string[0];
            this.metroTextBoxPassword.Location = new System.Drawing.Point(163, 129);
            this.metroTextBoxPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroTextBoxPassword.MaxLength = 32767;
            this.metroTextBoxPassword.Name = "metroTextBoxPassword";
            this.metroTextBoxPassword.PasswordChar = '*';
            this.metroTextBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPassword.SelectedText = "";
            this.metroTextBoxPassword.SelectionLength = 0;
            this.metroTextBoxPassword.SelectionStart = 0;
            this.metroTextBoxPassword.ShortcutsEnabled = true;
            this.metroTextBoxPassword.Size = new System.Drawing.Size(233, 21);
            this.metroTextBoxPassword.TabIndex = 6;
            this.metroTextBoxPassword.UseSelectable = true;
            this.metroTextBoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxReEnter
            // 
            // 
            this.metroTextBoxReEnter.CustomButton.Image = null;
            this.metroTextBoxReEnter.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.metroTextBoxReEnter.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroTextBoxReEnter.CustomButton.Name = "";
            this.metroTextBoxReEnter.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBoxReEnter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxReEnter.CustomButton.TabIndex = 1;
            this.metroTextBoxReEnter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxReEnter.CustomButton.UseSelectable = true;
            this.metroTextBoxReEnter.CustomButton.Visible = false;
            this.metroTextBoxReEnter.Lines = new string[0];
            this.metroTextBoxReEnter.Location = new System.Drawing.Point(163, 166);
            this.metroTextBoxReEnter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroTextBoxReEnter.MaxLength = 32767;
            this.metroTextBoxReEnter.Name = "metroTextBoxReEnter";
            this.metroTextBoxReEnter.PasswordChar = '*';
            this.metroTextBoxReEnter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxReEnter.SelectedText = "";
            this.metroTextBoxReEnter.SelectionLength = 0;
            this.metroTextBoxReEnter.SelectionStart = 0;
            this.metroTextBoxReEnter.ShortcutsEnabled = true;
            this.metroTextBoxReEnter.Size = new System.Drawing.Size(233, 21);
            this.metroTextBoxReEnter.TabIndex = 7;
            this.metroTextBoxReEnter.UseSelectable = true;
            this.metroTextBoxReEnter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxReEnter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonCreateAccount
            // 
            this.metroButtonCreateAccount.Enabled = false;
            this.metroButtonCreateAccount.Location = new System.Drawing.Point(163, 203);
            this.metroButtonCreateAccount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroButtonCreateAccount.Name = "metroButtonCreateAccount";
            this.metroButtonCreateAccount.Size = new System.Drawing.Size(117, 21);
            this.metroButtonCreateAccount.TabIndex = 8;
            this.metroButtonCreateAccount.Text = "회원가입";
            this.metroButtonCreateAccount.UseSelectable = true;
            this.metroButtonCreateAccount.Click += new System.EventHandler(this.metroButtonCreateAccount_Click);
            // 
            // metroButtonGoBack
            // 
            this.metroButtonGoBack.Location = new System.Drawing.Point(290, 203);
            this.metroButtonGoBack.Name = "metroButtonGoBack";
            this.metroButtonGoBack.Size = new System.Drawing.Size(117, 21);
            this.metroButtonGoBack.TabIndex = 5;
            this.metroButtonGoBack.Text = "뒤로가기";
            this.metroButtonGoBack.Click += new System.EventHandler(this.metroButtonGoBack_Click);
            // 
            // metroButtonReset
            // 
            this.metroButtonReset.Location = new System.Drawing.Point(50, 200);
            this.metroButtonReset.Name = "metroButtonReset";
            this.metroButtonReset.Size = new System.Drawing.Size(70, 30);
            this.metroButtonReset.Text = "클릭";
            this.metroButtonReset.UseSelectable = true;
            this.Controls.Add(this.metroButtonReset);
            this.metroButtonReset.Click += new System.EventHandler(this.metroButtonReset_Click);

            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 275);
            this.Controls.Add(this.metroButtonGoBack);
            this.Controls.Add(this.metroButtonCreateAccount);
            this.Controls.Add(this.metroTextBoxReEnter);
            this.Controls.Add(this.metroTextBoxPassword);
            this.Controls.Add(this.metroTextBoxId);
            this.Controls.Add(this.metroTextBoxUserName);
            this.Controls.Add(this.metroLabelReEnter);
            this.Controls.Add(this.metroLabelPassword);
            this.Controls.Add(this.metroLabelId);
            this.Controls.Add(this.metroLabelUserName);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CreateAccount";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 18);
            this.Text = "회원가입";
            this.TransparencyKey = System.Drawing.Color.DodgerBlue;
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelUserName;
        private MetroFramework.Controls.MetroLabel metroLabelId;
        private MetroFramework.Controls.MetroLabel metroLabelPassword;
        private MetroFramework.Controls.MetroLabel metroLabelReEnter;
        private MetroFramework.Controls.MetroTextBox metroTextBoxUserName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxId;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPassword;
        private MetroFramework.Controls.MetroTextBox metroTextBoxReEnter;
        private MetroFramework.Controls.MetroButton metroButtonCreateAccount;
        private MetroFramework.Controls.MetroButton metroButtonGoBack;
        private MetroFramework.Controls.MetroButton metroButtonReset;
    }
}
