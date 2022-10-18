using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form

    {
        public static int komp = 0;
        public static int mon = 0;
        public static int zestaw = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f3 = new Form3();
            f3.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Form1.komp != 0 && Form1.mon != 0 && Form1.zestaw != 0)
            {
                label3.ForeColor = Color.Green;
            }
            else if(Form1.komp == 0 ^ Form1.mon == 0 ^ Form1.zestaw == 0)
            {
                label3.ForeColor = Color.Red;
            }

            Form1.zestaw = Form1.mon + Form1.komp;
            label3.Text = Form1.zestaw.ToString();
        }
    }
}
