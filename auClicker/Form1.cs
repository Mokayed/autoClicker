using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auClicker
{
    public partial class Form1 : Form
    {
        autoit click = new autoit();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                this.KeyPreview = true;
                timer.Tick += new EventHandler(button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {        
            click.clicking("LEFT");
            timer.Start();
            label1.Text = "Clicking started";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer.Interval = (int)numericUpDown1.Value * 1000;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            label1.Text = "Stoped";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                timer.Stop();
                label1.Text = "Stoped";
            }
        }
    }
}
