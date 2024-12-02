using FFmpeg.NET; // FFmpeg.NET으로 비디오 인코딩 디코딩 구현
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualVideoEditor_Project
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

        }
        static async Task Main(string[] args)
        {
        }
    }
}
