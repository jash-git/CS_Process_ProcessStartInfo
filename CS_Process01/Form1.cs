using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Process01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "CS_Process02";  // Specify exe name.
            start.Arguments = "F00000000000000E";
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;

            Process p = Process.Start(start);
            if (p != null)
            {
                p.WaitForExit();
                StreamReader reader = p.StandardOutput;
                string result=p.StandardOutput.ReadToEnd();
                MessageBox.Show(String.Format("外部程式 {0} 已經退出！\n 回傳值={1}", start.FileName, result), this.Text,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
