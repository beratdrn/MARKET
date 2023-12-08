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
    public partial class SIPARIS : Form
    {
        public SIPARIS()
        {
            InitializeComponent();
        }

        private void SIPARIS_Load(object sender, EventArgs e)
        {


        }

        private void btn_spt_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);

            }
            else
            {
                MessageBox.Show("SEÇİM YAPMADAN İLERLEYEMEZSİNİZ");

            }
        }

        private void btn_ony_Click(object sender, EventArgs e)
        {

                Form2 form2gecis = new Form2();
                form2gecis.Show();
                this.Hide();
        }
    }
}
