using System;
using System.Windows.Forms;

namespace QLBanHang
{
    internal static class Program
    {
        /// <summary>
        /// Điểm bắt đầu của ứng dụng.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
