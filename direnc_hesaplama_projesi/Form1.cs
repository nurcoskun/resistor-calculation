using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace direnc_hesaplama_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox3.Enabled = false;
            textBox3.Enabled = false;

            listBox1.SelectedIndex = 1;
            listBox2.SelectedIndex = 1;
            listBox3.SelectedIndex = 1;
            listBox4.SelectedIndex = 1;
            listBox5.SelectedIndex = 1;
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox5.SelectedIndex == 0) { textBox5.BackColor = Color.Brown; }
            if (listBox5.SelectedIndex == 1) { textBox5.BackColor = Color.Red; }
            if (listBox5.SelectedIndex == 2) { textBox5.BackColor = Color.Green; }
            if (listBox5.SelectedIndex == 3) { textBox5.BackColor = Color.Blue; }
            if (listBox5.SelectedIndex == 4) { textBox5.BackColor = Color.Purple;}
            if (listBox5.SelectedIndex == 5) { textBox5.BackColor = Color.Gray;}
            if (listBox5.SelectedIndex == 6) { textBox5.BackColor = Color.Gold;}
            if (listBox5.SelectedIndex == 7) { textBox5.BackColor = Color.Silver; }
        }


        private void rb5Renk_CheckedChanged(object sender, EventArgs e)
        {
            listBox3.Enabled = true;
            textBox3.Enabled = true;
        }

        private void rb4Renk_CheckedChanged(object sender, EventArgs e)
        {
            listBox3.Enabled = false;
            textBox3.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0) textBox1.BackColor = Color.Black;
            if (listBox1.SelectedIndex == 1) textBox1.BackColor = Color.Brown;
            if (listBox1.SelectedIndex == 2) textBox1.BackColor = Color.Red;
            if (listBox1.SelectedIndex == 3) textBox1.BackColor = Color.Orange;
            if (listBox1.SelectedIndex == 4) textBox1.BackColor = Color.Yellow;
            if (listBox1.SelectedIndex == 5) textBox1.BackColor = Color.Green;
            if (listBox1.SelectedIndex == 6) textBox1.BackColor = Color.Blue;
            if (listBox1.SelectedIndex == 7) textBox1.BackColor = Color.Purple;
            if (listBox1.SelectedIndex == 8) textBox1.BackColor = Color.Gray;
            if (listBox1.SelectedIndex == 9) textBox1.BackColor = Color.White;
        }

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == 0) textBox2.BackColor = Color.Black;
            if (listBox2.SelectedIndex == 1) textBox2.BackColor = Color.Brown;
            if (listBox2.SelectedIndex == 2) textBox2.BackColor = Color.Red;
            if (listBox2.SelectedIndex == 3) textBox2.BackColor = Color.Orange;
            if (listBox2.SelectedIndex == 4) textBox2.BackColor = Color.Yellow;
            if (listBox2.SelectedIndex == 5) textBox2.BackColor = Color.Green;
            if (listBox2.SelectedIndex == 6) textBox2.BackColor = Color.Blue;
            if (listBox2.SelectedIndex == 7) textBox2.BackColor = Color.Purple;
            if (listBox2.SelectedIndex == 8) textBox2.BackColor = Color.Gray;
            if (listBox2.SelectedIndex == 9) textBox2.BackColor = Color.White;

        }

        private void listBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex == 0) { textBox3.BackColor = Color.Black; }
            if (listBox3.SelectedIndex == 1) { textBox3.BackColor = Color.Brown; }
            if (listBox3.SelectedIndex == 2) { textBox3.BackColor = Color.Red; }
            if (listBox3.SelectedIndex == 3) { textBox3.BackColor = Color.Orange; }
            if (listBox3.SelectedIndex == 4) { textBox3.BackColor = Color.Yellow; }
            if (listBox3.SelectedIndex == 5) { textBox3.BackColor = Color.Green; }
            if (listBox3.SelectedIndex == 6) { textBox3.BackColor = Color.Blue; }
            if (listBox3.SelectedIndex == 7) { textBox3.BackColor = Color.Purple; }
            if (listBox3.SelectedIndex == 8) { textBox3.BackColor = Color.Gray; }
            if (listBox3.SelectedIndex == 9) { textBox3.BackColor = Color.White; }
        }

        private void listBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox4.SelectedIndex == 0) { textBox4.BackColor = Color.Black; }
            if (listBox4.SelectedIndex == 1) { textBox4.BackColor = Color.Brown; }
            if (listBox4.SelectedIndex == 2) { textBox4.BackColor = Color.Red; }
            if (listBox4.SelectedIndex == 3) { textBox4.BackColor = Color.Orange; }
            if (listBox4.SelectedIndex == 4) { textBox4.BackColor = Color.Yellow;}
            if (listBox4.SelectedIndex == 5) { textBox4.BackColor = Color.Green;}
            if (listBox4.SelectedIndex == 6) { textBox4.BackColor = Color.Blue;  }
            if (listBox4.SelectedIndex == 7) { textBox4.BackColor = Color.Gold;  }
            if (listBox4.SelectedIndex == 8) { textBox4.BackColor = Color.Silver;  }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rb4Renk.Checked)
            {
                tbDeger.Text = listBox1.SelectedIndex.ToString("D") + listBox2.SelectedIndex.ToString("D");
            }
            else
            {
                tbDeger.Text = listBox1.SelectedIndex.ToString("D") + listBox2.SelectedIndex.ToString("D") + listBox3.SelectedIndex.ToString("D");
            }
           //double carpan = Math.Pow(10,listBox4.SelectedIndex);

            switch (listBox4.SelectedIndex)
            {
                case 0: tbDeger.Text = tbDeger.Text + " Ω "; break;
                case 1: tbDeger.Text = tbDeger.Text + "0 Ω "; break;
                case 2: tbDeger.Text = tbDeger.Text + "00 Ω "; break;
                case 3: tbDeger.Text = tbDeger.Text + " KΩ "; break;
                case 4: tbDeger.Text = tbDeger.Text + "0 KΩ "; break;
                case 5: tbDeger.Text = tbDeger.Text + "00 KΩ "; break;
                case 6: tbDeger.Text = tbDeger.Text + " MΩ "; break;
                case 7: tbDeger.Text = tbDeger.Text + "0 MΩ "; break;
                case 8: tbDeger.Text = tbDeger.Text + "00 MΩ "; break;
                case 9: tbDeger.Text = tbDeger.Text + "000 MΩ "; break;
            }
            switch (listBox5.SelectedIndex)
            {
                case 0: tbDeger.Text = tbDeger.Text + "± %1"; break;
                case 1: tbDeger.Text = tbDeger.Text + "± %2"; break;
                case 2: tbDeger.Text = tbDeger.Text + "± %0.5"; break;
                case 3: tbDeger.Text = tbDeger.Text + "± %0.25"; break;
                case 4: tbDeger.Text = tbDeger.Text + "± %0.10"; break;
                case 5: tbDeger.Text = tbDeger.Text + "± %0.05"; break;
                case 6: tbDeger.Text = tbDeger.Text + "± %5"; break;
                case 7: tbDeger.Text = tbDeger.Text + "± %10"; break;
            }
           


        }

       
    }
}
