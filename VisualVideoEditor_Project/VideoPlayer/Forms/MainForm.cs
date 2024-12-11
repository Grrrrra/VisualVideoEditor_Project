using LibVLCSharp.Shared;
using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using VisualVideoEditor_Project.VideoEditor.Forms;
using VisualVideoEditor_Project.VideoEditor.Account;

namespace VisualVideoEditor_Project
{
    public partial class MainForm : MetroForm
    {
        private readonly LoginForm loginForm; // 로그인 폼 인스턴스
        private readonly string username; // 사용자 이름 저장

        private static LibVLC _libVLC;
        private static MediaPlayer _mp;

        private TimeSpan videoDuration; // 비디오의 총 길이
        private double currentTime; // 현재 재생 시간

        private Timer timelineTimer; // 타임라인 업데이트 타이머
        private string videoPath; // 비디오 파일 경로
        private bool isVideoLoaded = false; // 비디오가 로드되었는지 확인하는 변수
        private AccountUser currentUser; // 현재 사용자 정보

        public MainForm(AccountUser user, LoginForm loginForm)
        {
            InitializeComponent();
            InitializeLibVLC(); // LibVLC 초기화
            InitializeDragAndDrop(); // 드래그 앤 드롭 초기화

            this.currentUser = user; // 사용자 정보를 설정
            this.username = user.Username; // 사용자 이름 저장
            this.loginForm = loginForm; // 로그인 폼 인스턴스 저장
            SetGreetingMessage(); // 인사 메시지 설정
            InitializeTimelineTimer(); // 타임라인 업데이트 타이머 초기화

            this.KeyDown += MainForm_KeyDown; // KeyDown 이벤트 핸들러 추가
        }

        private void InitializeTimelineTimer()
        {
            timelineTimer = new System.Windows.Forms.Timer
            {
                Interval = 1000 // 1초 간격
            };
            timelineTimer.Tick += TimelineTimer_Tick; // 타이머 Tick 이벤트 핸들러 추가
            timelineTimer.Start(); // 타이머 시작
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 타이머 중지
            if (timelineTimer != null)
            {
                timelineTimer.Stop();
            }

            // 폼이 닫힐 때 VLC 리소스를 해제
            if (_mp != null)
            {
                _mp.Dispose(); // MediaPlayer 자원 해제
            }
            if (_libVLC != null)
            {
                _libVLC.Dispose(); // LibVLC 자원 해제
            }
        }

        private void InitializeDragAndDrop()
        {
            // MainVideoView가 드래그 앤 드롭을 허용하도록 설정
            MainVideoView.AllowDrop = true;

            // 드래그 앤 드롭 이벤트 핸들러 추가
            MainVideoView.DragEnter += MainVideoView_DragEnter; // 드래그 진입 이벤트
            MainVideoView.DragDrop += MainVideoView_DragDrop;   // 드래그 드롭 이벤트
        }

        private void InitializeLibVLC()
        {
            Core.Initialize(); // LibVLC 초기화
            _libVLC = new LibVLC(); // LibVLC 인스턴스 생성
            _mp = new MediaPlayer(_libVLC); // MediaPlayer 인스턴스 생성
            MainVideoView.MediaPlayer = _mp; // MediaPlayer를 MainVideoView에 설정
        }

        private void SetGreetingMessage()
        {
            this.Text = $"안녕하세요! {username}님! QuickPlayer에 오신 것을 환영합니다!";
        }

        private void PlayVideo(string path)
        {
            videoPath = path; // 전달된 경로를 필드에 저장
            try
            {
                Media media = new Media(_libVLC, videoPath, FromType.FromPath);
                _mp.Play(media); // 비디오 재생

                _mp.Playing += (s, e) =>
                {
                    videoDuration = TimeSpan.FromMilliseconds(media.Duration); // 비디오 길이 설정
                    UpdateUIOnVideoLength(videoPath); // UI 업데이트
                    lblState.Text = "재생 중"; // 상태 레이블 업데이트
                    UpdateUrlTextBox(videoPath); // URL 텍스트 박스 업데이트
                };

                isVideoLoaded = true; // 비디오 로드 상태 업데이트
            }
            catch (Exception ex)
            {
                MessageBox.Show($"비디오 재생 중 오류 발생: {ex.Message}");
            }
        }
        private void UpdateUrlTextBox(string path)
        {
            // UI 스레드에서 호출되었는지 확인
            if (InvokeRequired)
            {
                // UI 스레드에서 메서드를 호출
                Invoke((MethodInvoker)(() => UpdateUrlTextBox(path)));
                return; // 메서드 종료
            }

            // urlTextBox에 경로명을 설정
            urlTextBox.Clear(); // 기존 텍스트 클리어
            urlTextBox.Text = path; // 새로운 경로 설정
        }

            private void UpdateUIOnVideoLength(string videoPath)
        {
            // UI 스레드에서 호출되었는지 확인
            // InvokeRequired가 true이면 UI 스레드가 아닌 스레드에서 호출되었음을 의미
            if (InvokeRequired)
            {
                // UI 스레드에서 메서드를 호출
                Invoke((MethodInvoker)(() => UpdateUIOnVideoLength(videoPath)));
                return; // 메서드 종료
            }

            // 파일 확장자를 확인하여 MP4 파일인지 검증
            if (!videoPath.EndsWith(".mp4", StringComparison.OrdinalIgnoreCase))
            {
                // 유효하지 않은 MP4 파일일 경우 오류 메시지 박스 표시
                MessageBox.Show("유효한 MP4 파일이 아닙니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // MP4가 아닐 경우 메서드 종료
            }

            // 비디오의 총 길이를 초 단위로 가져옴
            double maxDuration = videoDuration.TotalSeconds;

            // TrackBar의 최소값을 항상 0으로 설정
            mediaTrackBar.Minimum = 0; // 최소값을 항상 0으로 설정

            // 비디오 길이가 0보다 큰지 확인하여 TrackBar의 최대값 설정
            if (maxDuration > 0)
            {
                // 비디오 길이가 0보다 크면 최대값을 설정
                mediaTrackBar.Maximum = (int)maxDuration; // TrackBar 최대값 설정
            }
            else
            {
                // 비디오 길이가 0인 경우 최대값을 0으로 설정
                mediaTrackBar.Maximum = 0; // 비디오 길이가 0일 경우 최대값을 0으로 설정
            }

            // 총 비디오 시간을 포맷하여 레이블에 표시
            totalDurationLabel.Text = videoDuration.ToString(@"hh\:mm\:ss"); // 총 비디오 시간 표시
        }
        private void UpdateTimeline()
        {
            try
            {
                if (_mp.IsPlaying)
                {
                    currentTime = _mp.Time / 1000.0; // 현재 재생 시간을 double로 가져오기 (초 단위)

                    // UI 스레드에서 실행되는지 확인
                    if (InvokeRequired)
                    {
                        Invoke((MethodInvoker)UpdateTimeline);
                        return;
                    }

                    // 현재 시간의 범위를 확인하고 업데이트
                    if (currentTime >= 0 && currentTime <= mediaTrackBar.Maximum)
                    {
                        mediaTrackBar.Value = (int)currentTime; // TrackBar 현재 위치 업데이트 (int로 변환)
                        currentTimeLabel.Text = TimeSpan.FromSeconds(currentTime).ToString(@"hh\:mm\:ss"); // 현재 시간 표시
                    }
                }
            }
            catch (Exception ex)
            {
                // 예외가 발생한 경우 사용자에게 알림
                MessageBox.Show($"타임라인 업데이트 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TimelineTimer_Tick(object sender, EventArgs e)
        {
            UpdateTimeline(); // 타임라인 업데이트를 위한 메서드 호출
        }

        private void btnFavorites_Click(object sender, EventArgs e)
        {
            MyMediaList myMediaList = new MyMediaList(currentUser); // 현재 사용자 정보를 넘겨줌
            myMediaList.Show();
        }

        private void MainVideoView_DragDrop(object sender, DragEventArgs e)
        {
            // 드래그된 데이터가 파일인지 확인
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // 드래그된 파일 경로를 문자열 배열로 가져옴
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                // 파일 배열이 비어있지 않은지 확인
                if (files.Length > 0)
                {
                    // 첫 번째 파일 경로를 사용하여 비디오 재생
                    PlayVideo(files[0]); // 첫 번째 파일 경로 가져오기
                }
            }
        }

        private void MainVideoView_DragEnter(object sender, DragEventArgs e)
        {
            // 드래그된 데이터가 파일인지 확인
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // 드래그가 유효한 경우 복사 효과를 설정
                e.Effect = DragDropEffects.Copy; // 드래그 효과 설정
            }
            else
            {
                // 드래그된 데이터가 유효하지 않은 경우 드래그 효과 없음
                e.Effect = DragDropEffects.None; // 드래그 효과 없음
            }
        }


        private void btnVideoPlayStop_Click(object sender, EventArgs e)
        {
            TogglePlayPause();
        }

        private void TogglePlayPause()
        {
            if (_mp.IsPlaying)
            {
                _mp.Pause(); // 현재 재생 중이면 일시 정지
                lblState.Text = "일시 정지"; // 상태 레이블 업데이트
                btnVideoPlayStop.Text = "재생"; // 버튼 텍스트 업데이트
            }
            else
            {
                _mp.Play(); // 비디오 재생
                lblState.Text = "재생 중"; // 상태 레이블 업데이트
                btnVideoPlayStop.Text = "일시 정지"; // 버튼 텍스트 업데이트
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) // Space 키가 눌렸을 때
            {
                TogglePlayPause(); // 재생/정지 토글
                e.Handled = true; // 이벤트가 처리되었음을 표시
            }
        }

        private void urlTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string videoPath = urlTextBox.Text.Trim(); // 입력된

                // 입력된 경로 가져오기

                if (System.IO.File.Exists(videoPath) && videoPath.EndsWith(".mp4", StringComparison.OrdinalIgnoreCase))
{
    PlayVideo(videoPath); // 비디오 재생
}
else
{
    MessageBox.Show("유효한 MP4 파일 경로가 아닙니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
{
    // 비디오를 정지하고 클리어하는 과정
    if (_mp != null)
    {
        // 미디어가 재생 중이거나 일시 정지 상태일 경우 무조건 미디어를 클리어
        _mp.Stop(); // 비디오 정지
        _mp.Media = null; // MediaPlayer의 미디어를 클리어
    }

    // UI 요소 초기화
    mediaTrackBar.Value = 0; // TrackBar 초기화
    totalDurationLabel.Text = "00:00:00"; // 총 비디오 시간 초기화
    currentTimeLabel.Text = "00:00:00"; // 현재 시간 초기화
    urlTextBox.Clear(); // 비디오 경로 텍스트 박스 초기화
    lblState.Text = "정지"; // 상태 레이블 초기화
}



private void 현재시간ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
{
    현재시간ToolStripMenuItem.Text = "현재시간"; // 원래의 텍스트로 되돌리기
}

private void 현재시간ToolStripMenuItem_Click(object sender, EventArgs e)
{
    CurrentTimeForm currentTimeForm = new CurrentTimeForm();
    currentTimeForm.Show(); // 팝업 창 열기
}
        private void 가져오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "MP4 Files (*.mp4)|*.mp4|All Files (*.*)|*.*";
                openFileDialog.Title = "비디오 파일 선택";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PlayVideo(openFileDialog.FileName); // 선택한 비디오 재생
                }
            }
        }
        private void 새프로젝트ToolStripMenuItem_Click(object sender, EventArgs e)
{
    // 새로운 MainForm 인스턴스 생성
    MainForm newProjectForm = new MainForm(currentUser, loginForm);
    newProjectForm.Show(); // 팝업 형태로 새로운 폼을 열기
}

private void 오디오로_내보내기ToolStripMenuItem_Click(object sender, EventArgs e)
{
    // 비디오가 로드되지 않은 경우 경고 메시지 표시
    if (!isVideoLoaded)
    {
        MessageBox.Show("MP4 영상을 먼저 로드해야 합니다!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return; // 메서드 종료
    }

    string videoPath = urlTextBox.Text; // 현재 비디오 경로 가져오기

    // 비디오 경로가 유효한지 확인
    if (string.IsNullOrWhiteSpace(videoPath))
    {
        MessageBox.Show("오디오로 저장할 경로명이 없습니다!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return; // 메서드 종료
    }

    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
    {
        saveFileDialog.Filter = "MP3 Files (*.mp3)|*.mp3";
        saveFileDialog.Title = "오디오 파일 저장";

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            string outputPath = saveFileDialog.FileName;

            // 비디오에서 오디오 추출 및 MP3로 변환
            ExtractAudio(videoPath, outputPath);
        }
    }
}

private void ExtractAudio(string videoPath, string outputPath)
{
    // FFmpeg 명령어 구성
    string arguments = $"-i \"{videoPath}\" -q:a 0 -map a \"{outputPath}\"";

    // FFmpeg 프로세스 시작
    using (System.Diagnostics.Process process = new System.Diagnostics.Process())
    {
        process.StartInfo.FileName = "ffmpeg.exe"; // FFmpeg 실행 파일 경로
        process.StartInfo.Arguments = arguments;
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.RedirectStandardError = true;
        process.StartInfo.CreateNoWindow = true;

        process.Start();

        // 오류 출력 읽기 (선택 사항)
        string output = process.StandardOutput.ReadToEnd();
        string error = process.StandardError.ReadToEnd();

        process.WaitForExit();

        // 오류가 발생한 경우 메시지 표시
        if (process.ExitCode != 0)
        {
            MessageBox.Show($"오디오 추출 중 오류가 발생했습니다:\n{error}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            MessageBox.Show("오디오가 성공적으로 내보내졌습니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

private void urlTextBox_Click(object sender, EventArgs e)
{
    urlTextBox.SelectAll(); // 클릭 시 모든 텍스트 선택
}

private void 닫기ToolStripMenuItem_Click(object sender, EventArgs e)
{
    // 로그인 폼이 열려 있는 경우 닫기
    if (loginForm != null && !loginForm.IsDisposed)
    {
        loginForm.Close(); // LoginForm 종료
    }

    // MediaPlayer 및 LibVLC 자원 해제
    if (_mp != null)
    {
        _mp.Dispose(); // MediaPlayer 자원 해제
        _mp = null; // 참조 해제
    }

    if (_libVLC != null)
    {
        _libVLC.Dispose(); // LibVLC 자원 해제
        _libVLC = null; // 참조 해제
    }

    // 현재 폼 닫기
    this.Close(); // MainForm 종료
}

private void mediaTrackBar_Scroll(object sender, ScrollEventArgs e)
{
    // TrackBar의 값에 따라 비디오 재생 위치 조정
    if (_mp != null)
    {
        currentTime = mediaTrackBar.Value; // TrackBar 현재 값을 double로 저장
        _mp.Time = (long)(currentTime * 1000); // MediaPlayer의 재생 위치를 밀리초로 설정
    }
}
    }
}
