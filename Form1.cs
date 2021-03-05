using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgi_yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlıs = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonrakı.Enabled = true;


            label8.Text = btnB.Text;
            if (label8.Text == label7.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlıs++;
                lblYanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonrakı.Enabled = true;

            label8.Text = btnB.Text;
            if (label8.Text == label7.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlıs++;
                lblYanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonrakı.Enabled = true;


            label8.Text = btnD.Text;
            if (label8.Text == label7.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlıs++;
                lblYanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonrakı.Enabled = true;



            label8.Text = btnA.Text;
            if (label8.Text==label7.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlıs++;
                lblYanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnSonrakı_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonrakı.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            lblSoruno.Text = soruno.ToString();
            if (soruno==1)
            {
                richTextBox1.Text = "Seven filminde Brad Pitt hangi karaktere can vermiştir?";
                btnA.Text = "David Mills";
                btnB.Text = "John Doe";
                btnC.Text = "Billy Hopkins";
                btnD.Text = "David Somerset";
                label7.Text = "David Mills";
            }
            if (soruno==2)
            {
                richTextBox1.Text = "Matrix serisinin ikinci filminin adı nedir?";
                btnA.Text = "Matrıx Revolutions";
                btnB.Text = "Matrıx Reloaded ";
                btnC.Text = "Matrıx Overload";
                btnD.Text = "Matrıx HoverCraft ";
                label7.Text = "Matrıx Reloaded";
            }
            if (soruno==3)
            {
                richTextBox1.Text = "Türkiye'de bulanan Kaçkar Dağı hangi il sınırlarındadır? ";
                btnA.Text = "Adana";
                btnB.Text = "Ağrı";
                btnC.Text = "Rize";
                btnD.Text = "Artvin";
                label7.Text = "Rize";
            }
            if (soruno==4)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi Fyodor Dostoyevski'ye ait eserdir?";
                btnA.Text = "Dava";
                btnB.Text = "Karamazov Kardeşler";
                btnC.Text = "Babalar ve Oğullar";
                btnD.Text = "Satranç";
                label7.Text = "Karamazov Kardeşler";
                btnSonrakı.Text = "Sonuçlar";
            }
            if (soruno==5)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonrakı.Enabled = false;
                MessageBox.Show("Doğru:" + dogru + "\n " + "Yanlış:" + yanlıs);
            }
        }
    }
}
