using LibVLCSharp.Shared;

using System;
using System.IO;
using System.Drawing; // Graphics 사용을 위한 네임스페이스
using System.Drawing.Text;
using MetroFramework.Controls;
using MetroFramework.Components;

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

            try
            {
                media = new Media(_libVLC, videoPath, FromType.FromPath);
                _mp.Play(media); // 비디오 재생

                // 비디오의 길이를 가져옵니다.
                videoDuration = TimeSpan.FromMilliseconds(media.Duration); // long을 TimeSpan으로 변환

                // 타임라인을 초기화
                currentTime = TimeSpan.Zero; // 비디오 재생 시작 시 초기화
                UpdateTimeline(); // 타임라인 업데이트

                // 타이머 시작 (타이머가 정의된 경우)
                timelineTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"비디오 재생 중 오류 발생: {ex.Message}");
            }
        }
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
      
        private void SetGreetingMessage()
        {
            // MetroForm의 제목을 사용자 이름을 포함한 인사 메시지로 설정
            this.Text = $"안녕하세요! {username}님! Quickcut에 오신 것을 환영합니다!";
        }

        private void 도움말ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 도움말 메뉴 클릭 시 동작
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 초기화 작업 (필요 시 추가)
        }

        private void ModeSelect_Enter(object sender, EventArgs e)
        {
            // 모드 선택 시 동작
        }
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
        }
    }
}
