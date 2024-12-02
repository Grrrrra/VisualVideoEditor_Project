using System;
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
<<<<<<< HEAD

=======
        static async Task Main(string[] args)
        {
        }
>>>>>>> 611bee9f20765e6f98f3e1019cdd106599328821
    }
}
