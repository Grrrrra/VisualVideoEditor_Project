using System.Windows.Forms;

namespace VisualVideoEditor_Project.VideoEditor.Forms
{
    partial class CurrentTimeForm
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
        private void InitializeComponents()
        {
            this.lblCurrentTime = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Location = new System.Drawing.Point(76, 100); // Y 위치 조정
            this.lblCurrentTime.Name = "lblCurrentTime"; // Name 속성 추가
            this.lblCurrentTime.Size = new System.Drawing.Size(150, 40); // 사이즈 조정
            this.lblCurrentTime.TabIndex = 0;
            this.lblCurrentTime.Text = "현재 시간"; // 초기 텍스트 설정
            this.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; // 중앙 정렬
            this.lblCurrentTime.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold); // 폰트 설정
            // 
            // CurrentTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 243); 
            this.Controls.Add(this.lblCurrentTime); // lblCurrentTime를 폼에 추가
            this.Name = "CurrentTimeForm";
            this.Text = "현재 시간"; // 폼 제목 변경
            this.MaximizeBox = false; // 최대화 버튼 비활성화
            this.MinimizeBox = false; // 최소화 버튼 비활성화
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; // 크기 변경 불가능
            this.StartPosition = FormStartPosition.CenterScreen; // 폼 시작 위치 설정
            this.Shown += new System.EventHandler(this.CurrentTimeForm_Shown); // Shown 이벤트 핸들러 등록
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblCurrentTime; // 레이블 선언
    }

}