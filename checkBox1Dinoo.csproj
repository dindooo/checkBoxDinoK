using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace checkBox1
{
    public partial class Form1 : Form
    {
        
        public Form1()
            
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void sakrijNarudzbu_CheckedChanged(object sender, EventArgs e)
        {
            if (sakrijNarudzbu.Checked)
            {
                narudzbaBox.Hide();

            }
            else
            {
                narudzbaBox.Show();
            }
        }

        private void ŠaljiDugme_Click(object sender, EventArgs e)
        {
            narudzbaBox.Clear();
            narudzbaBox.AppendText("Odabrali ste : \r\n");
            if (DorucakBox.Checked)
            {
                narudzbaBox.AppendText("Doručak \r\n");
            }

            if (RucakBox.Checked)
            {
                narudzbaBox.AppendText("Ručak \r\n" );
            }

            if (VeceraBox.Checked)
            {
                narudzbaBox.AppendText("Večera \r\n" );
            }
        }
    }
}
