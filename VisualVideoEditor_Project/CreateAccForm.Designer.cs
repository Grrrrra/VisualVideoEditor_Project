namespace VisualVideoEditor_Project
{
    partial class CreateAccForm
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
            this.SettingLogin = new System.Windows.Forms.Label();
            this.btnAccession = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.password1txt = new System.Windows.Forms.TextBox();
            this.password2txt = new System.Windows.Forms.TextBox();
            this.createId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SettingLogin
            // 
            this.SettingLogin.AutoSize = true;
            this.SettingLogin.Font = new System.Drawing.Font("한컴 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SettingLogin.Location = new System.Drawing.Point(154, 32);
            this.SettingLogin.Name = "SettingLogin";
            this.SettingLogin.Size = new System.Drawing.Size(80, 31);
            this.SettingLogin.TabIndex = 1;
            this.SettingLogin.Text = "회원가입";
            this.SettingLogin.UseCompatibleTextRendering = true;
            this.SettingLogin.Click += new System.EventHandler(this.SettingLogin_Click);
            // 
            // btnAccession
            // 
            this.btnAccession.Location = new System.Drawing.Point(136, 267);
            this.btnAccession.Name = "btnAccession";
            this.btnAccession.Size = new System.Drawing.Size(115, 55);
            this.btnAccession.TabIndex = 2;
            this.btnAccession.Text = "가입";
            this.btnAccession.UseVisualStyleBackColor = true;
            this.btnAccession.Click += new System.EventHandler(this.btnAccession_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.Color.OldLace;
            this.userName.Font = new System.Drawing.Font("굴림체", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userName.Location = new System.Drawing.Point(21, 90);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(39, 15);
            this.userName.TabIndex = 3;
            this.userName.Text = "이름";
            this.userName.Click += new System.EventHandler(this.userName_Click);
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(168, 90);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(199, 21);
            this.nametxt.TabIndex = 7;
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(168, 127);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(199, 21);
            this.idtxt.TabIndex = 8;
            // 
            // password1txt
            // 
            this.password1txt.Location = new System.Drawing.Point(168, 165);
            this.password1txt.Name = "password1txt";
            this.password1txt.Size = new System.Drawing.Size(199, 21);
            this.password1txt.TabIndex = 9;
            // 
            // password2txt
            // 
            this.password2txt.Location = new System.Drawing.Point(168, 200);
            this.password2txt.Name = "password2txt";
            this.password2txt.Size = new System.Drawing.Size(199, 21);
            this.password2txt.TabIndex = 10;
            // 
            // createId
            // 
            this.createId.AutoSize = true;
            this.createId.BackColor = System.Drawing.Color.OldLace;
            this.createId.Font = new System.Drawing.Font("굴림체", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.createId.Location = new System.Drawing.Point(21, 127);
            this.createId.Name = "createId";
            this.createId.Size = new System.Drawing.Size(55, 15);
            this.createId.TabIndex = 11;
            this.createId.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OldLace;
            this.label2.Font = new System.Drawing.Font("굴림체", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(21, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OldLace;
            this.label3.Font = new System.Drawing.Font("굴림체", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(21, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "비밀번호 재확인";
            // 
            // CreateAccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 348);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createId);
            this.Controls.Add(this.password2txt);
            this.Controls.Add(this.password1txt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.btnAccession);
            this.Controls.Add(this.SettingLogin);
            this.Name = "CreateAccForm";
            this.Text = "CreateAccForm";
            this.Load += new System.EventHandler(this.CreateAccForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SettingLogin;
        private System.Windows.Forms.Button btnAccession;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox password1txt;
        private System.Windows.Forms.TextBox password2txt;
        private System.Windows.Forms.Label createId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}