using MetroFramework.Forms;
using System;
using System.Threading;
using System.Windows.Forms;

namespace VisualVideoEditor_Project.VideoEditor.Forms
{
    public partial class CurrentTimeForm : MetroForm
    {
        private Thread _timeThread; // 시간 업데이트를 위한 스레드
        private bool _running; // 스레드 실행 여부

        public CurrentTimeForm()
        {
            InitializeComponents(); // UI 구성 요소 초기화
            _running = true; // 스레드 실행 플래그 초기화
            _timeThread = new Thread(UpdateTime); // 시간 업데이트 스레드 생성
            _timeThread.IsBackground = true; // 백그라운드 스레드로 설정
            _timeThread.Start(); // 스레드 시작
        }

        private void UpdateTime()
        {
            try
            {
                while (_running) // 스레드가 실행 중일 때 반복
                {
                    // UI 업데이트는 메인 스레드에서만 가능하므로 Invoke 사용
                    if (lblCurrentTime.InvokeRequired)
                    {
                        // UI 스레드에서 UpdateCurrentTime 메서드를 호출
                        lblCurrentTime.Invoke(new Action(UpdateCurrentTime));
                    }
                    else
                    {
                        // 현재 시간을 업데이트하는 메서드 호출
                        UpdateCurrentTime();
                    }
                    Thread.Sleep(1000); // 1초 대기
                }
            }
            catch (ThreadAbortException)
            {
                // 스레드가 중단될 때의 처리
                // 필요한 경우 UI를 초기화하거나 상태를 업데이트
                ResetUI(); // UI 초기화 메서드 호출
            }
            catch (Exception ex)
            {
                // 다른 예외가 발생하면 오류 메시지 표시
                MessageBox.Show($"시간 업데이트 중 오류 발생: {ex.Message}");
            }
        }

        // UI 초기화 메서드
        private void ResetUI()
        {
            // 예를 들어, 현재 시간을 '00:00:00'으로 초기화
            if (lblCurrentTime.InvokeRequired)
            {
                // UI 스레드에서 ResetUI 메서드를 호출
                lblCurrentTime.Invoke(new Action(ResetUI));
            }
            else
            {
                // 현재 시간을 '00:00:00'으로 설정
                lblCurrentTime.Text = "00:00:00"; // 초기화할 값
                                                  // 추가적인 UI 초기화 로직이 필요하면 여기에 추가
            }
        }

        private void UpdateCurrentTime()
        {
            lblCurrentTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // 현재 시간 표시
        }
        private void btnStopTimeUpdate_Click(object sender, EventArgs e)
        {
            _running = false; // 시간 업데이트 중지
            if (_timeThread.IsAlive)
            {
                _timeThread.Join(); // 스레드 종료 대기
            }
            MessageBox.Show("시간 업데이트가 중지되었습니다.");
        }

        private void btnStartTimeUpdate_Click(object sender, EventArgs e)
        {
            if (!_running)
            {
                _running = true; // 시간 업데이트 재개
                _timeThread = new Thread(UpdateTime); // 새로운 스레드 생성
                _timeThread.IsBackground = true;
                _timeThread.Start(); // 스레드 시작
                MessageBox.Show("시간 업데이트가 시작되었습니다.");
            }
            else
            {
                MessageBox.Show("이미 시간 업데이트가 진행 중입니다.");
            }
        }
    }
}
