using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Process02
{
    public partial class Form1 : Form
    {
        public String m_StrCmdInput = "";
        public Form1(String StrCmdInput = "")
        {
            InitializeComponent();
            m_StrCmdInput = StrCmdInput;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(m_StrCmdInput.Length>0)
            {
                this.Text += " ~" + m_StrCmdInput;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.Write(m_StrCmdInput+","+m_StrCmdInput);
        }
    }
}
