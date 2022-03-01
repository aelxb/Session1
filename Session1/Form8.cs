using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }
        DateTime eventTime = new DateTime(2017, 11, 24, 6, 0, 0);
        Timer timer1 = new Timer();
        void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan TimeRemaining = eventTime - DateTime.Now;
            label5.Text = "До начала события осталось: " + TimeRemaining.Days + " : " + TimeRemaining.Hours + " : " + TimeRemaining.Minutes + " : " + TimeRemaining.Seconds;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form11 form = new Form11();
            form.Show();
            Close();
        }
    }
}
