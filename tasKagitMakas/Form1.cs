using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tasKagitMakas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          timer1.Start();
        }
        int skor1 = 0;
        int skor2 = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            btn_pctas.BackColor=Color.White;
            btn_pckagit.BackColor = Color.White;
            btn_pcmakas.BackColor = Color.White;
            Random random = new Random();
            int deger = random.Next(1, 4);
            if (deger == 1) 
            {
                lbl_sonuc.Text = "Berabere";
                btn_pctas.BackColor = Color.Gray;
            }
            else if(deger==2)
            {
                lbl_sonuc.Text = "Kaybettiniz";
                btn_pckagit.BackColor = Color.Red;
                skor2++;
                lbl_skorpc.Text=skor2.ToString();

            }
            else if( deger==3)
            {
                lbl_sonuc.Text = "Kazandınız";
                btn_pcmakas.BackColor = Color.Green;
                skor1++;
                lbl_skoroyuncu.Text = skor1.ToString();
            }
        }

        private void btn_oyuncukagit_Click(object sender, EventArgs e)
        {
            btn_pctas.BackColor = Color.White;
            btn_pckagit.BackColor = Color.White;
            btn_pcmakas.BackColor = Color.White;
            Random random = new Random();
            int deger = random.Next(1, 4);
            if (deger == 1)
            {
                lbl_sonuc.Text = "Kazandınız";
                btn_pctas.BackColor = Color.Green;
                skor1++;
                lbl_skoroyuncu.Text = skor1.ToString();
            }
            else if (deger == 2)
            {
                lbl_sonuc.Text = "Berabere";
                btn_pckagit.BackColor = Color.Gray;
            }
            else if (deger == 3)
            {
                lbl_sonuc.Text = "Kaybettiniz";
                btn_pcmakas.BackColor = Color.Red;
                skor2++;
                lbl_skorpc.Text = skor2.ToString();
            }

        }

        private void btn_oyuncumakas_Click(object sender, EventArgs e)
        {
            btn_pctas.BackColor = Color.White;
            btn_pckagit.BackColor = Color.White;
            btn_pcmakas.BackColor = Color.White;
            Random random = new Random();
            int deger = random.Next(1, 4);
            if (deger == 1)
            {
                lbl_sonuc.Text = "Kaybettiniz";
                btn_pctas.BackColor = Color.Red;
                skor2++;
                lbl_skorpc.Text = skor2.ToString();
            }
            else if (deger == 2)
            {
                lbl_sonuc.Text = "Kazandınız";
                btn_pckagit.BackColor = Color.Green;
                skor1++;
                lbl_skoroyuncu.Text = skor1.ToString();
            }
            else if (deger == 3)
            {
                lbl_sonuc.Text = "Berabere";
                btn_pcmakas.BackColor = Color.Gray;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (skor1 == 3)
            {
                lbl_sonuc.Text = "KAZANDINIZ";
                btn_oyuncukagit.Enabled = false;
                btn_oyuncumakas.Enabled = false;
                btn_oyuncutas.Enabled = false;
                btn_pckagit.Enabled = false;
                btn_pcmakas.Enabled = false;
                btn_pctas.Enabled = false;
            }
            else if (skor2 == 3)
            {
                lbl_sonuc.Text = "KAYBETTİNİZ";
                btn_oyuncukagit.Enabled = false;
                btn_oyuncumakas.Enabled = false;
                btn_oyuncutas.Enabled = false;
                btn_pckagit.Enabled = false;
                btn_pcmakas.Enabled = false;
                btn_pctas.Enabled = false;
            }
        }
    }
}
