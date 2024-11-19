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
            // CreateAccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 368);
            this.Controls.Add(this.SettingLogin);
            this.Name = "CreateAccForm";
            this.Text = "CreateAccForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SettingLogin;
    }
}