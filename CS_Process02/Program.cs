using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Process02
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            String StrArgs = "";
            for (int i = 0; i < args.Length; i++)
            {
                if (i == 0)
                {
                    StrArgs = args[i];
                }
                else
                {
                    StrArgs += "-" + args[i];
                }

            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(StrArgs));
        }
    }
}
