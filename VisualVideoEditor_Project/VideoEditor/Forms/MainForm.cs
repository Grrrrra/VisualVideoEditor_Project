using LibVLCSharp.Shared;

using System;
<<<<<<< HEAD
using MetroFramework.Components;

using System.Windows.Forms;
using MetroFramework.Forms;

using VisualVideoEditor_Project.VideoEditor.Forms;
using VisualVideoEditor_Project.VideoEditor.Account;

=======
using System.IO;
using System.Drawing; // Graphics 사용을 위한 네임스페이스
using System.Drawing.Text;
using MetroFramework.Controls;
using MetroFramework.Components;
>>>>>>> 611bee9f20765e6f98f3e1019cdd106599328821

using System.Threading;
using System.Windows.Forms;
using MetroFramework.Forms;

using VisualVideoEditor_Project.Properties;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;
using LibVLCSharp.Forms.Shared;
using VisualVideoEditor_Project.VideoEditor.Forms;

namespace VisualVideoEditor_Project
{

    public partial class MainForm : MetroForm
    {
<<<<<<< HEAD

        private readonly LoginForm loginForm; // 로그인 폼 인스턴스
        private MetroStyleManager styleManager; // 스타일 매니저
        private readonly string username; // 사용자 이름 저장

        private static LibVLC _libVLC;
        private static MediaPlayer _mp;

        private TimeSpan videoDuration; // 비디오의 총 길이
        private TimeSpan currentTime; // 현재 재생 시간
        private System.Windows.Forms.Timer durationCheckTimer; // 비디오 길이를 확인할 타이머 추가
        private Media media; // 현재 재생 중인 미디어
        private string videoPath; // 비디오 파일 경로
        private bool isVideoLoaded = false; // 비디오가 로드되었는지 확인하는 변수

        public MainForm(string username, LoginForm loginForm)
        {
            InitializeComponent();
            InitializeStyleManager();
            InitializeLibVLC(); // LibVLC 초기화
            InitializeDragAndDrop(); // 드래그 앤 드롭 초기화

            LoadSettings(); // 설정 로드
            this.username = username; // 사용자 이름 저장
            SetGreetingMessage(); // 인사 메시지 설정
            this.loginForm = loginForm; // 로그인 폼 인스턴스 저장

            InitializePlayer(); // 플레이어 초기화
            InitializeDurationCheckTimer(); // 길이 확인을 위한 타이머 초기화

            this.KeyDown += MainForm_KeyDown; // KeyDown 이벤트 핸들러 추가
        }
        private void InitializeDurationCheckTimer()
        {
            durationCheckTimer = new System.Windows.Forms.Timer
            {
                Interval = 1000 // 1초 간격
            };
            durationCheckTimer.Tick += durationCheckTimer_Tick;
        }

        private void InitializePlayer()
        {
            _libVLC = new LibVLC();
            _mp = new MediaPlayer(_libVLC);

            // 타임라인 초기화
            timelineTimer = new System.Windows.Forms.Timer
            {
                Interval = 1000 // 1초 간격
            };
            timelineTimer.Tick += TimelineTimer_Tick;
=======

        private LoginForm loginForm; // 로그인 폼 인스턴스
        private MetroStyleManager styleManager; // 스타일 매니저
        private string username; // 사용자 이름 저장

        public static LibVLC _libVLC;
        public static MediaPlayer _mp;

        private TimeSpan videoDuration; // 비디오의 총 길이
        private TimeSpan currentTime; // 현재 재생 시간
        public Media media; // 현재 재생 중인 미디어

        private string videoPath; // 비디오 파일 경로

        public MainForm(string username, LoginForm form)
        {
            InitializeComponent();

            InitializeStyleManager();

            InitializeLibVLC(); // LibVLC 초기화
            InitializeDragAndDrop(); // 드래그 앤 드롭 초기화

            InitializeTimer(); // 타이머 초기화

            LoadSettings(); // 설정 로드
            this.username = username; // 사용자 이름 저장
            SetGreetingMessage(); // 인사 메시지 설정
            this.loginForm = form; // 로그인 폼 인스턴스 저장
>>>>>>> 611bee9f20765e6f98f3e1019cdd106599328821
        }

        private void LoadSettings()
        {
            // 설정에서 값 로드 (예: LastAccessDate)
            if (Properties.Settings.Default.LastAccessDate != DateTime.MinValue)
            {
                DateTime lastAccessDate = Properties.Settings.Default.LastAccessDate;
                // 추가 로직이 필요할 수 있습니다.
            }
        }

<<<<<<< HEAD
        private void UpdateTimeline()
        {
            if (_mp.IsPlaying)
            {
                currentTime = TimeSpan.FromMilliseconds(_mp.Time); // 현재 재생 시간을 가져옵니다.
                if (currentTime.TotalSeconds >= 0 && currentTime.TotalSeconds <= mediaTrackBar.Maximum)
                {
                    mediaTrackBar.Value = (int)currentTime.TotalSeconds; // TrackBar 현재 위치 업데이트
                    currentTimeLabel.Text = currentTime.ToString(@"hh\:mm\:ss"); // 현재 시간 표시
                }
            }
        }

        private void PlayVideo(string path)
        {
            videoPath = path; // 전달된 경로를 필드에 저장
=======

        private void UpdateTimeline()
        {   // 타임라인을 업데이트하는 메서드
            if (_mp != null && videoDuration.TotalMilliseconds > 0)
            {
                currentTime = TimeSpan.FromMilliseconds(_mp.Time); // 현재 재생 시간 (TimeSpan으로 변환)

                // 타임라인 그리기를 요청
                panelTimeline.Invalidate();
            }
        }

        private void PlayVideo(string videoPath)
        {
>>>>>>> 611bee9f20765e6f98f3e1019cdd106599328821

            try
            {
                media = new Media(_libVLC, videoPath, FromType.FromPath);
                _mp.Play(media); // 비디오 재생

<<<<<<< HEAD
                // 비디오가 재생되기 시작할 때 길이 가져오기
                _mp.Playing += (s, e) =>
                {
                    long durationMillis = media.Duration; // 비디오 길이 가져오기
                    if (durationMillis > 0)
                    {
                        videoDuration = TimeSpan.FromMilliseconds(durationMillis); // 길이 설정
                        UpdateUIOnVideoLength(); // UI 업데이트
                        lblState.Text = "재생 중"; // 상태 레이블 업데이트
                    }
                    else
                    {
                        MessageBox.Show("비디오 길이를 가져오는 데 실패했습니다.");
                    }
                };

                currentTime = TimeSpan.Zero; // 비디오 재생 시작 시 초기화
                UpdateTimeline(); // 타임라인 업데이트
                timelineTimer.Start(); // 타이머 시작
                isVideoLoaded = true; // 비디오 로드 상태 업데이트
=======
                // 비디오의 길이를 가져옵니다.
                videoDuration = TimeSpan.FromMilliseconds(media.Duration); // long을 TimeSpan으로 변환

                // 타임라인을 초기화
                currentTime = TimeSpan.Zero; // 비디오 재생 시작 시 초기화
                UpdateTimeline(); // 타임라인 업데이트

                // 타이머 시작 (타이머가 정의된 경우)
                timelineTimer.Start();
>>>>>>> 611bee9f20765e6f98f3e1019cdd106599328821
            }
            catch (Exception ex)
            {
                MessageBox.Show($"비디오 재생 중 오류 발생: {ex.Message}");
            }
        }
<<<<<<< HEAD

        // UI 업데이트를 위한 메서드
        private void UpdateUIOnVideoLength()
        {
            if (totalDurationLabel.InvokeRequired)
            {
                totalDurationLabel.Invoke((MethodInvoker)delegate
                {
                    mediaTrackBar.Maximum = (int)videoDuration.TotalSeconds; // TrackBar 최대값 설정
                    totalDurationLabel.Text = videoDuration.ToString(@"hh\:mm\:ss"); // 총 비디오 시간 표시
                });
            }
            else
            {
                mediaTrackBar.Maximum = (int)videoDuration.TotalSeconds; // TrackBar 최대값 설정
                totalDurationLabel.Text = videoDuration.ToString(@"hh\:mm\:ss"); // 총 비디오 시간 표시
            }
        }

        private void TimelineTimer_Tick(object sender, EventArgs e)
        {
            UpdateTimeline(); // 타임라인 업데이트를 위한 메서드 호출
        }
=======
        private void panelTimeline_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = panelTimeline.ClientRectangle;

            // 타임라인 배경 그리기
            g.FillRectangle(Brushes.Black, rect);

            // 비디오 길이에 비례하여 타임라인 길이 계산
            double timelineWidth = (double)rect.Width * ((double)currentTime.TotalMilliseconds / videoDuration.TotalMilliseconds);

            // 현재 재생 시간에 따른 타임라인 표시
            g.FillRectangle(Brushes.Green, 0, 0, (float)timelineWidth, rect.Height); // 현재 재생 시간 표시

            // 시작 및 끝 시간 표시
            g.DrawString("0:00", this.Font, Brushes.White, new PointF(0, 0)); // 시작 시간
            g.DrawString(videoDuration.ToString(@"m\:ss"), this.Font, Brushes.White, new PointF(rect.Width - 50, 0)); // 끝 시간

            // 중심선 그리기
            g.DrawLine(Pens.White, 0, rect.Height / 2, rect.Width, rect.Height / 2);
        }
        // 컷 편집 기능을 위한 메서드
        private void CutVideoAtCurrentTime()
        {
            if (_mp != null && videoDuration.TotalMilliseconds > 0)
            {
                long cutTime = _mp.Time; // 현재 재생 중인 시간
                string outputPath = Path.Combine(Path.GetDirectoryName(videoPath),
                    $"cut_{Path.GetFileNameWithoutExtension(videoPath)}_{cutTime / 1000}.mp4");

                // FFmpeg 실행
                ExecuteFFmpeg(videoPath, cutTime, outputPath);
                MessageBox.Show($"비디오가 {cutTime / 1000}초에서 컷되었습니다. 저장 위치: {outputPath}");
            }
        }
        private void ExecuteFFmpeg(string inputPath, long cutTime, string outputPath)
        {
            string ffmpegPath = @"C:\path\to\ffmpeg.exe"; // FFmpeg 실행 파일 경로 설정

            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = ffmpegPath,
                Arguments = $"-i \"{inputPath}\" -ss {cutTime / 1000} -c copy \"{outputPath}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            using (Process process = Process.Start(processStartInfo))
            {
                process.WaitForExit(); // FFmpeg 프로세스가 끝날 때까지 대기
            }
        }
      
>>>>>>> 611bee9f20765e6f98f3e1019cdd106599328821
        private void SetGreetingMessage()
        {
            // MetroForm의 제목을 사용자 이름을 포함한 인사 메시지로 설정
            this.Text = $"안녕하세요! {username}님! QuickPlayer에 오신 것을 환영합니다!";

            // 비디오 경로가 저장되어 있다면 비디오를 재생
            if (!string.IsNullOrEmpty(videoPath))
            {
                PlayVideo(videoPath); // PlayVideo 메서드 호출
            }
        }

        private void btnFavorites_Click(object sender, EventArgs e)
        {
            AccountUser currentUser = GetCurrentUser(); // 현재 사용자 정보를 가져오는 메서드
            MyMediaList myMediaList = new MyMediaList(currentUser);
            myMediaList.Show();
        }

        private AccountUser GetCurrentUser()
        {
<<<<<<< HEAD
            // 현재 로그인된 사용자 정보를 반환하는 로직
            AccountUser currentUser = new AccountUser
            {
                Username = username,
                UserId = "userId_example", // 실제로는 로그인 시 저장된 UserId를 사용해야 함
                Password = "password_example", // 실제로는 로그인 시 저장된 Password를 사용해야 함
            };

            // 사용자 즐겨찾기 로드
            currentUser.LoadFavorites(); // 사용자의 즐겨찾기를 로드하는 메서드 호출

            return currentUser; // 현재 사용자 정보를 가진 AccountUser 객체 반환
=======
            // 초기화 작업 (필요 시 추가)
>>>>>>> 611bee9f20765e6f98f3e1019cdd106599328821
        }

        private void MainVideoView_DragDrop(object sender, DragEventArgs e)
        {
            // 드래그 앤 드롭 된 파일 처리
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0)
                {
                    string videoPath = files[0]; // 첫 번째 파일 경로 가져오기
                    PlayVideo(videoPath); // 비디오 재생 함수 호출
                }
            }
        }
        private void MainVideoView_DragEnter(object sender, DragEventArgs e)
        {
            // 드래그한 데이터가 파일인지 확인
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy; // 드래그 효과 설정
            }
            else
            {
                e.Effect = DragDropEffects.None; // 드래그 효과 없음
            }
        }
        private void 닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginForm != null && !loginForm.IsDisposed)
            {
                loginForm.Close(); // LoginForm 종료
            }
        }
<<<<<<< HEAD

        private void btnVideoPlayStop_Click(object sender, EventArgs e)
        {
            TogglePlayPause();
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
            // 엔터 키를 눌렀을 때
            if (e.KeyCode == Keys.Enter)
            {
                string videoPath = urlTextBox.Text.Trim(); // 입력된 경로 가져오기

                // MP4 파일인지 확인
                if (System.IO.File.Exists(videoPath) && videoPath.EndsWith(".mp4", StringComparison.OrdinalIgnoreCase))
                {
                    // 비디오 재생
                    _mp.Play(new Media(_libVLC, videoPath, FromType.FromPath)); // VLC를 사용하여 비디오 재생
                }
                else
                {
                    MessageBox.Show("유효한 MP4 파일 경로가 아닙니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void InitializeStyleManager()
        {
            styleManager = new MetroStyleManager();
            styleManager.Owner = this; // 스타일 매니저의 소유자를 현재 폼으로 설정
            this.StyleManager = styleManager; // 폼의 스타일 매니저 설정
            this.StyleManager.Style = MetroFramework.MetroColorStyle.Magenta; // 레드 테마
            this.StyleManager.Theme = MetroFramework.MetroThemeStyle.Light; // 다크 테마
=======
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void MainVideoView_DragDrop(object sender, DragEventArgs e)
        {
            // 드래그 앤 드롭 된 파일 처리
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0)
                {
                    string videoPath = files[0]; // 첫 번째 파일 경로 가져오기
                    PlayVideo(videoPath); // 비디오 재생 함수 호출
                }
            }
        }
        private void MainVideoView_DragEnter(object sender, DragEventArgs e)
        {
            // 드래그한 데이터가 파일인지 확인
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy; // 드래그 효과 설정
            }
            else
            {
                e.Effect = DragDropEffects.None; // 드래그 효과 없음
            }
        }

        private void MainVideoView_Stopped(object sender, EventArgs e)
        {
            // 비디오가 종료될 때 타이머 중지
            timelineTimer.Stop();
            // 타임라인 초기화
            currentTime = TimeSpan.Zero;
            panelTimeline.Invalidate();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // 현재 시간을 가져와서 "yyyy-MM-dd HH:mm:ss" 형식으로 포맷
            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            label1.Text = currentTime; // 현재 시간 표시
        }

        private void MainVideoView_Click(object sender, EventArgs e)
        {

        }
        private void 닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginForm != null && !loginForm.IsDisposed)
            {
                loginForm.Close(); // LoginForm 종료
            }
        }

        private void 보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnVideoPlayStop_Click(object sender, EventArgs e)
        {
            if (_mp.IsPlaying)
            {
                _mp.Pause(); // 비디오를 멈춤
                btnVideoPlayStop.Text = "재생"; // 버튼 텍스트 변경
            }
            else
            {
                _mp.Play(); // 비디오를 재생
                btnVideoPlayStop.Text = "멈춤"; // 버튼 텍스트 변경
            }
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
                    // 선택된 비디오 파일 경로
                    string selectedFilePath = openFileDialog.FileName;

                    // 비디오를 MainVideoView에 로드하고 재생
                    var media = new Media(_libVLC, selectedFilePath, FromType.FromPath);
                    _mp.Media = media;
                    _mp.Play();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        { // 현재 재생 중인 비디오가 있다면 멈춤
            if (_mp.IsPlaying)
            {
                _mp.Stop(); // 비디오 정지
            }
        // MediaPlayer의 미디어를 클리어
         _mp.Media = null; // 미디어를 null로 설정하여 클리어

            // MainVideoView를 클리어 (비디오 뷰를 초기 상태로 되돌림)
            MainVideoView.MediaPlayer = null; // MediaPlayer를 null로 설정 (필요한 경우)
            
            // 버튼 텍스트 초기화 (필요에 따라)
            btnVideoPlayStop.Text = "재생"; // 재생 버튼 텍스트 초기화
        }

        private void btnCutVideo_Click_1(object sender, EventArgs e)
        {
            CutVideoAtCurrentTime(); // 컷 편집 메서드 호출
>>>>>>> 611bee9f20765e6f98f3e1019cdd106599328821
        }
        private void InitializeLibVLC()
        {
            Core.Initialize(); // LibVLC 초기화
            _libVLC = new LibVLC(); // LibVLC 인스턴스 생성
            _mp = new MediaPlayer(_libVLC); // MediaPlayer 인스턴스 생성
                                            // MediaPlayer를 MainVideoView에 설정
            try
            {
                MainVideoView.MediaPlayer = _mp; // 비디오 뷰에 MediaPlayer 설정
            }
            catch (Exception ex)
            {
                MessageBox.Show($"MediaPlayer 설정 중 오류 발생: {ex.Message}");
            }
        }

        private void InitializeDragAndDrop()
        {
            MainVideoView.AllowDrop = true; // 드래그 앤 드롭 허용
            MainVideoView.DragEnter += MainVideoView_DragEnter; // 드래그 진입 이벤트
            MainVideoView.DragDrop += MainVideoView_DragDrop; // 드래그 드롭 이벤트
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
                    string selectedFilePath = openFileDialog.FileName;
                    urlTextBox.Text = selectedFilePath; // 선택한 비디오 경로를 TextBox에 표시
                    PlayVideo(selectedFilePath); // 비디오 재생 함수 호출
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {    
             // 현재 재생 중인 비디오가 있다면 정지
            if (_mp.IsPlaying)
            {
                _mp.Stop(); // 비디오 정지
                lblState.Text = "정지"; // 상태 레이블 업데이트
            }

            // MediaPlayer의 미디어를 클리어
            _mp.Media = null; // 미디어를 null로 설정하여 클리어

            // MainVideoView를 클리어 (비디오 뷰를 초기 상태로 되돌림)
            MainVideoView.MediaPlayer = null; // MediaPlayer를 null로 설정

            // UI 요소 초기화
            mediaTrackBar.Value = 0; // TrackBar 초기화
            totalDurationLabel.Text = "00:00:00"; // 총 비디오 시간 초기화
            currentTimeLabel.Text = "00:00:00"; // 현재 시간 초기화
            urlTextBox.Clear(); // 비디오 경로 텍스트 박스 초기화

            // 버튼 텍스트 초기화
            btnVideoPlayStop.Text = "재생"; // 재생 버튼 텍스트 초기화
            lblState.Text = "정지"; // 상태 레이블 초기화
        }



        private void 현재시간ToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {

            // "현재시간" 텍스트를 현재 시간으로 변경
            현재시간ToolStripMenuItem.Text = "현재시간: " + currentTime;
        }

        private void 현재시간ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            // 원래의 텍스트로 되돌리기
            현재시간ToolStripMenuItem.Text = "현재시간";
        }

        private void mediaTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            // TrackBar 값을 기반으로 비디오 위치 이동
            int seconds = mediaTrackBar.Value;

            // 비디오 길이가 유효한 경우에만 시간 설정
            if (videoDuration.TotalSeconds > 0)
            {
                _mp.Time = seconds * 1000; // 비디오 시간 설정 (초 단위)
            }
        }

        private void durationCheckTimer_Tick(object sender, EventArgs e)
        {

        }

        private void 현재시간ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentTimeForm currentTimeForm = new CurrentTimeForm();
            currentTimeForm.Show(); // 팝업 창 열기
        }

        private void 새프로젝트ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 새로운 MainForm 인스턴스 생성
            MainForm newProjectForm = new MainForm(username, loginForm);
            // 새로운 폼을 보여줌
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
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 폼이 닫힐 때 VLC 리소스를 해제
            if (_mp != null)
            {
                _mp.Dispose();
            }
            if (_libVLC != null)
            {
                _libVLC.Dispose();
            }
        }

    }
}
