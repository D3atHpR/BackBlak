using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackBlak
{
    public partial class Form1 : Form
    {
        int PanelWidth;
        bool Hidden;
        public Form1()
        {
            InitializeComponent();
            PanelWidth = flowLayoutPanel1.Width;
            Hidden = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                flowLayoutPanel1.Width = flowLayoutPanel1.Width + 20;
                if (flowLayoutPanel1.Width>=PanelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                flowLayoutPanel1.Width = flowLayoutPanel1.Width - 20;
                if (flowLayoutPanel1.Width<=10)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
