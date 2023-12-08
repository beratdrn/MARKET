using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STAND
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_nck_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_grs_Click(object sender, EventArgs e)
        {
            string ad = txt_nck.Text;
            string sifre = txt_psw.Text;

            if (ad == "beratdrn") 
            {
                if (sifre == "beratdrn123")
                {
                    MessageBox.Show("GİRİŞ BAŞARILI TEBRİKLER");

                    SIPARIS siparısgeçiş = new SIPARIS();
                    siparısgeçiş.Show();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("ŞİFRENİZ YANLIŞTIR YENİDEN BAKINIZ");
                }


            } 

            else
            {
                MessageBox.Show("KULLANICI ADINIZ YANLIŞ");
            }
        }

        private void lbl_kayıt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KAYITOL kayıtolgecis = new KAYITOL();
            kayıtolgecis.Show();
            this.Hide();

        }

        private void txt_nıck(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_psww(object sender, KeyPressEventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
