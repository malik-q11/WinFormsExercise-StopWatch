using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_EXP
{
    public partial class Form1 : Form
    {
        private DateTime startTime;
        private Timer timer;
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += timer1_Tick;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            startTime = DateTime.MinValue;
            UpdateTimerLabels();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateTimerLabels();
        }
        private void UpdateTimerLabels()
        {
            TimeSpan span = DateTime.Now - startTime;
            L1.Text = span.Hours.ToString("D2");
            L2.Text = span.Minutes.ToString("D2");
            L3.Text = span.Seconds.ToString("D2");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
            }
            else
            {
                if (startTime == DateTime.MinValue)
                    startTime = DateTime.Now;
                    timer.Start();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            L1.Text = "00";
            L2.Text = "00";
            L3.Text = "00";
        }
    }
}
