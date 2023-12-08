using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STAND
{
    public partial class KAYITOL : Form
    {
        public KAYITOL()
        {
            InitializeComponent();
        }

        private void btn_kyt_Click(object sender, EventArgs e)
        {

            if (tx_sfr.Text == "" || tx_kadi.Text == "" || tx_syd.Text == "" || txt_sfr.Text == "") 
            {
                MessageBox.Show("LÜTFEN BOŞ ALAN BIRAKMAYINIZ");
            }
            else
            {
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.kadi = tx_kadi.Text;
                Properties.Settings.Default.ad = tx_sfr.Text;
                Properties.Settings.Default.sifre = txt_sfr.Text;
                Properties.Settings.Default.soyad = tx_syd.Text;

                MessageBox.Show("BAŞARILI BİR ŞEKİLDE KAYIT OLDUNUZ \n " +  tx_sfr.Text  +   tx_syd.Text  +  "ARAMIZA HOŞGELDİN");

                Form1 girisgecis = new Form1();
                girisgecis.Show();
                this.Close();



            }


        }

        private void tx_sfr_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_sfr_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        
    }
}
