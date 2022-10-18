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
    public partial class Form2 : Form
    {
        int a = 0;
        int b = 0;
        int c = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f1 = new Form1();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                Form1.komp += 650;
                label8.Text = Form1.komp.ToString();
            }
            if(radioButton1.Checked == false)
            {
                Form1.komp -= 650;
                label8.Text = Form1.komp.ToString();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            {
                Form1.komp += 790;
                label8.Text = Form1.komp.ToString();
            }

            if(radioButton2.Checked == false)
            {
                Form1.komp -= 790;
                label8.Text = Form1.komp.ToString();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton3.Checked == true)
            {
                Form1.komp += 950;
                label8.Text = Form1.komp.ToString();
            }

            if(radioButton3.Checked == false)
            {
                Form1.komp -= 950;
                label8.Text = Form1.komp.ToString();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton4.Checked == true)
            {
                Form1.komp += 700;
                label8.Text = Form1.komp.ToString();
            }

            if(radioButton4.Checked == false)
            {
                Form1.komp -= 700;
                label8.Text = Form1.komp.ToString();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton5.Checked == true)
            {
                Form1.komp += 910;
                label8.Text = Form1.komp.ToString();
            }

            if(radioButton5.Checked == false)
            {
                Form1.komp -= 910;
                label8.Text = Form1.komp.ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                Form1.komp += 750;
                label8.Text = Form1.komp.ToString();
            }

            if(checkBox1.Checked == false)
            {
                Form1.komp -= 750;
                label8.Text = Form1.komp.ToString();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
            {
                Form1.komp += 1250;
                label8.Text = Form1.komp.ToString();
            }

            if(checkBox2.Checked == false)
            {
                Form1.komp -= 1250;
                label8.Text = Form1.komp.ToString();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked == true)
            {
                Form1.komp += 1750;
                label8.Text = Form1.komp.ToString();
            }

            if(checkBox3.Checked == false)
            {
                Form1.komp -= 1750;
                label8.Text = Form1.komp.ToString();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox4.Checked == true)
            {
                Form1.komp += 1100;
                label8.Text = Form1.komp.ToString();
            }

            if(checkBox4.Checked == false)
            {
                Form1.komp -= 1100;
                label8.Text = Form1.komp.ToString();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox5.Checked == true)
            {
                Form1.komp += 1800;
                label8.Text = Form1.komp.ToString();
            }

            if(checkBox5.Checked == false)
            {
                Form1.komp -= 1800;
                label8.Text = Form1.komp.ToString();
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton6.Checked == true)
            {
                Form1.komp += 550;
                label8.Text = Form1.komp.ToString();
            }
            if(radioButton6.Checked == false)
            {
                Form1.komp -= 550;
                label8.Text = Form1.komp.ToString();
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton7.Checked == true)
            {
                Form1.komp += 850;
                label8.Text = Form1.komp.ToString();
            }
            if(radioButton7.Checked == false)
            {
                Form1.komp -= 850;
                label8.Text = Form1.komp.ToString();
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton8.Checked == true)
            {
                Form1.komp += 1150;
                label8.Text = Form1.komp.ToString();
            }
            if(radioButton8.Checked == false)
            {
                Form1.komp -= 1150;
                label8.Text = Form1.komp.ToString();
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton9.Checked == true)
            {
                Form1.komp += 1500;
                label8.Text = Form1.komp.ToString();
            }
            if(radioButton9.Checked == false)
            {
                Form1.komp -= 1500;
                label8.Text = Form1.komp.ToString();
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton11.Checked == true)
            {
                Form1.komp += 1200;
                label8.Text = Form1.komp.ToString();
            }
            if(radioButton11.Checked == false)
            {
                Form1.komp -= 1200;
                label8.Text = Form1.komp.ToString();
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton12.Checked == true)
            {
                Form1.komp += 1000;
                label8.Text = Form1.komp.ToString();
            }
            if(radioButton12.Checked == false)
            {
                Form1.komp -= 1000;
                label8.Text = Form1.komp.ToString();
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton13.Checked == true)
            {
                Form1.komp += 1680;
                label8.Text = Form1.komp.ToString();
            }
            if(radioButton13.Checked == false)
            {
                Form1.komp -= 1680;
                label8.Text = Form1.komp.ToString();
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton14.Checked == true)
            {
                Form1.komp += 2150;
                label8.Text = Form1.komp.ToString();
            }
            if(radioButton14.Checked == false)
            {
                Form1.komp -= 2150;
                label8.Text = Form1.komp.ToString();
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton15.Checked == true)
            {
                Form1.komp += 1700;
                label8.Text = Form1.komp.ToString();
            }
            if(radioButton15.Checked == false)
            {
                Form1.komp -= 1700;
                label8.Text = Form1.komp.ToString();
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var systemo = comboBox1.SelectedItem;

            if(systemo == "MacOS")
            {
                Form1.komp += 2100 - a;
                label8.Text = Form1.komp.ToString();
                a = 2100;
            }
            else if(systemo == "Windows")
            {
                Form1.komp += 1500 - b;
                label8.Text = Form1.komp.ToString();
                b = 1500;
            }
            else if(systemo == "Linux")
            {
                Form1.komp += 1000 - c;
                label8.Text = Form1.komp.ToString();
                c = 1000;
            }
        }
    }
}
