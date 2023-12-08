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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             if (checkBox1.Checked == false)
             {
                    MessageBox.Show("LÜTFEN SÖZLEŞMEYİ KABUL EDİNİZ");
                    
               
             }
            else if (txt_cvv == null)
            {
                MessageBox.Show("LÜTFEN HEPSİNİ DOLDURUN");


            }
            else if (txt_add == null)
            {
                MessageBox.Show("LÜTFEN HEPSİNİ DOLDURUN");
            }
            else if (txt_no == null)
            {
                MessageBox.Show("LÜTFEN HEPSİNİ DOLDURUN");
            }

            else

            {
                
                SON_BÖLÜM sonbolumgecıs = new SON_BÖLÜM();
                sonbolumgecıs.Show();
                this.Hide();
            }







        }

        private void txt_snt_TextChanged(object sender, EventArgs e)
        {

        }

        public void txt_add_TextChanged(object sender, EventArgs e)
        {
        }

        public void txt_syd_TextChanged(object sender, EventArgs e)
        {
           
        }

        

        

        private void txt_noKeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar==8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_cvvKeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar==8 )
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_ad(object sender, KeyPressEventArgs e)
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

        private void txt_sydky(object sender, KeyPressEventArgs e)
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
    }
}
