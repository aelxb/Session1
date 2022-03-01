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
    public partial class Form3 : Form
    {
        public Form3()
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length>0 && textBox2.Text.Length> 0 && textBox4.Text.Length > 0 && textBox5.Text.Length > 0 && textBox6.Text.Length > 0 && textBox7.Text.Length > 0 && textBox8.Text.Length > 0)
            {
                if (textBox5.Text.Length == 16 && textBox7.Text.Length == 3 && DateTime.Parse(textBox6.Text+"."+textBox8.Text) >= DateTime.Now)
                {
                    Form4 form = new Form4();
                    form.Show();
                    Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = (int.Parse(textBox1.Text)-10).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = (int.Parse(textBox1.Text) + 10).ToString();
        }
    }
}
