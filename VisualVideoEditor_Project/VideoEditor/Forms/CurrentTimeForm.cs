using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace VisualVideoEditor_Project.VideoEditor.Forms
{
    public partial class CurrentTimeForm : MetroForm
    {
        private Timer _timer;

        public CurrentTimeForm()
        {
            InitializeComponents(); // UI 구성 요소 초기화
            InitializeTimer(); // 타이머 초기화
        }

        private void InitializeTimer()
        {
            _timer = new Timer();
            _timer.Interval = 1000; // 1초마다 업데이트
            _timer.Tick += Timer_Tick;
            _timer.Start(); // 타이머 시작
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateCurrentTime(); // 현재 시간 업데이트
        }

        private void UpdateCurrentTime()
        {
            lblCurrentTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // 현재 시간 표시
        }

        private void CurrentTimeForm_Shown(object sender, EventArgs e)
        {
            UpdateCurrentTime(); // 폼이 표시될 때 현재 시간 업데이트
        }
    }
}
