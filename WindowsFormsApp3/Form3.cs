using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        int a = 0;
        int b = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f1 = new Form1();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var markam = comboBox1.SelectedItem;

            if(markam.ToString() == "Apple")
            {
                Form1.mon = 0;
                a = 1;

                if(b == 1 && b != null)
                {
                    Form1.mon += 1000;
                    label5.Text = Form1.mon.ToString();
                }
                else if(b == 2 && b != null)
                {
                    Form1.mon += 1290;
                    label5.Text = Form1.mon.ToString();
                }
                else if(b == 3 && b != null)
                {
                    Form1.mon += 1500;
                    label5.Text = Form1.mon.ToString();
                }
                else if(b == 4 && b != null)
                {
                    Form1.mon += 1700;
                    label5.Text = Form1.mon.ToString();
                }
                else if (b == 5 && b != null)
                {
                    Form1.mon += 1990;
                    label5.Text = Form1.mon.ToString();
                }
            }

            if (markam.ToString() == "Samsung")
            {
                Form1.mon = 0;
                a = 2;

                if (b == 1 && b != null)
                {
                    Form1.mon += 700;
                    label5.Text = Form1.mon.ToString();
                }
                else if (b == 2 && b != null)
                {
                    Form1.mon += 890;
                    label5.Text = Form1.mon.ToString();
                }
                else if (b == 3 && b != null)
                {
                    Form1.mon += 1000;
                    label5.Text = Form1.mon.ToString();
                }
                else if (b == 4 && b != null)
                {
                    Form1.mon += 1340;
                    label5.Text = Form1.mon.ToString();
                }
                else if (b == 5 && b != null)
                {
                    Form1.mon += 1690;
                    label5.Text = Form1.mon.ToString();
                }
            }

            if (markam.ToString() == "DELL")
            {
                Form1.mon = 0;
                a = 3;

                if (b == 1 && b != null)
                {
                    Form1.mon += 560;
                    label5.Text = Form1.mon.ToString();
                }
                else if (b == 2 && b != null)
                {
                    Form1.mon += 790;
                    label5.Text = Form1.mon.ToString();
                }
                else if (b == 3 && b != null)
                {
                    Form1.mon += 910;
                    label5.Text = Form1.mon.ToString();
                }
                else if (b == 4 && b != null)
                {
                    Form1.mon += 1030;
                    label5.Text = Form1.mon.ToString();
                }
                else if (b == 5 && b != null)
                {
                    Form1.mon += 1380;
                    label5.Text = Form1.mon.ToString();
                }
            }

            if (markam.ToString() == "LG")
            {
                Form1.mon = 0;
                a = 4;

                if (b == 1 && b != null)
                {
                    Form1.mon += 450;
                    label5.Text = Form1.mon.ToString();
                }
                else if (b == 2 && b != null)
                {
                    Form1.mon += 750;
                    label5.Text = Form1.mon.ToString();
                }
                else if (b == 3 && b != null)
                {
                    Form1.mon += 860;
                    label5.Text = Form1.mon.ToString();
                }
                else if (b == 4 && b != null)
                {
                    Form1.mon += 950;
                    label5.Text = Form1.mon.ToString();
                }
                else if (b == 5 && b != null)
                {
                    Form1.mon += 1190;
                    label5.Text = Form1.mon.ToString();
                }
            }

            if (markam.ToString() == "ACER")
            {
                Form1.mon = 0;
                a = 5;

                if (b == 1 && b != null)
                {
                    Form1.mon += 680;
                    label5.Text = Form1.mon.ToString();
                }
                else if (b == 2 && b != null)
                {
                    Form1.mon += 790;
                    label5.Text = Form1.mon.ToString();
                }
                else if (b == 3 && b != null)
                {
                    Form1.mon += 900;
                    label5.Text = Form1.mon.ToString();
                }
                else if (b == 4 && b != null)
                {
                    Form1.mon += 1010;
                    label5.Text = Form1.mon.ToString();
                }
                else if (b == 5 && b != null)
                {
                    Form1.mon += 1120;
                    label5.Text = Form1.mon.ToString();
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var markam = comboBox2.SelectedItem;

            if (markam.ToString() == "1920x1200")
            {
                Form1.mon = 0;
                b = 1;

                if (a == 1 && a != null)
                {
                    Form1.mon += 1000;
                    label5.Text = Form1.mon.ToString();
                }
                else if (a == 2 && a != null)
                {
                    Form1.mon += 1290;
                    label5.Text = Form1.mon.ToString();
                }
                else if (a == 3 && a != null)
                {
                    Form1.mon += 1500;
                    label5.Text = Form1.mon.ToString();
                }
                else if (a == 4 && a != null)
                {
                    Form1.mon += 1700;
                    label5.Text = Form1.mon.ToString();
                }
                else if (a == 5 && a != null)
                {
                    Form1.mon += 1990;
                    label5.Text = Form1.mon.ToString();
                }
            }

            if (markam.ToString() == "2560x1080")
            {
                Form1.mon = 0;
                b = 2;

                if (a == 1 && a != null)
                {
                    Form1.mon += 700;
                    label5.Text = Form1.mon.ToString();
                }
                else if (a == 2 && a != null)
                {
                    Form1.mon += 890;
                    label5.Text = Form1.mon.ToString();
                }
                else if (a == 3 && a != null)
                {
                    Form1.mon += 1000;
                    label5.Text = Form1.mon.ToString();
                }
                else if (a == 4 && a != null)
                {
                    Form1.mon += 1340;
                    label5.Text = Form1.mon.ToString();
                }
                else if (a == 5 && a != null)
                {
                    Form1.mon += 1690;
                    label5.Text = Form1.mon.ToString();
                }
            }

            if (markam.ToString() == "3440x1440")
            {
                Form1.mon = 0;
                b = 3;

                if (a == 1 && a != null)
                {
                    Form1.mon += 560;
                    label5.Text = Form1.mon.ToString();
                }
                else if (a == 2 && a != null)
                {
                    Form1.mon += 790;
                    label5.Text = Form1.mon.ToString();
                }
                else if (a == 3 && a != null)
                {
                    Form1.mon += 910;
                    label5.Text = Form1.mon.ToString();
                }
                else if (a == 4 && a != null)
                {
                    Form1.mon += 1030;
                    label5.Text = Form1.mon.ToString();
                }
                else if (a == 5 && a != null)
                {
                    Form1.mon += 1380;
                    label5.Text = Form1.mon.ToString();
                }
            }

            if (markam.ToString() == "3840x1080")
            {
                Form1.mon = 0;
                b = 4;

                if (a == 1 && a != null)
                {
                    Form1.mon += 450;
                    label5.Text = Form1.mon.ToString();
                }
                else if (a == 2 && a != null)
                {
                    Form1.mon += 750;
                    label5.Text = Form1.mon.ToString();
                }
                else if (a == 3 && a != null)
                {
                    Form1.mon += 860;
                    label5.Text = Form1.mon.ToString();
                }
                else if (a == 4 && a != null)
                {
                    Form1.mon += 950;
                    label5.Text = Form1.mon.ToString();
                }
                else if (a == 5 && a != null)
                {
                    Form1.mon += 1190;
                    label5.Text = Form1.mon.ToString();
                }
            }

            if (markam.ToString() == "5120x1440")
            {
                Form1.mon = 0;
                b = 5;

                if (a == 1 && a != null)
                {
                    Form1.mon += 680;
                    label5.Text = Form1.mon.ToString();
                }
                else if (a == 2 && a != null)
                {
                    Form1.mon += 790;
                    label5.Text = Form1.mon.ToString();
                }
                else if (a == 3 && a != null)
                {
                    Form1.mon += 900;
                    label5.Text = Form1.mon.ToString();
                }
                else if (a == 4 && a != null)
                {
                    Form1.mon += 1010;
                    label5.Text = Form1.mon.ToString();
                }
                else if (a == 5 && a != null)
                {
                    Form1.mon += 1120;
                    label5.Text = Form1.mon.ToString();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
