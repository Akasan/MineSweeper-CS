using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConfigurationForm configurationForm = new ConfigurationForm();
            Application.Run(configurationForm);
            Application.Run(new MainForm(configurationForm.Height, configurationForm.Width, configurationForm.Size, configurationForm.BombCount));
        }
    }
}
