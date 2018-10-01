using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soal3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            
            if (Convert.ToInt32(txtInput.Text) > 1000 || Convert.ToInt32(txtInput.Text) < 1)
            {
                MessageBox.Show("Input 1-1000", "Validasi");   
                return;
            }

            int Jumlah = Convert.ToInt32(txtInput.Text);
            string HasilOutput = "";

            for (int i = 1; i <= Jumlah; i++)
            {

                int Mod3 = i % 3;
                int Mod5 = i % 5;
                int Mod7 = i % 7;
                bool Check = false;

                if (Mod3 == 0)
                {
                    HasilOutput += "X";
                    Check = true;
                }
                if (Mod5 == 0)
                {
                    HasilOutput += "Y";
                    Check = true;
                }

                if (Mod7 == 0)
                {
                    HasilOutput += "Z";
                    Check = true;
                }

                if (Check == false)
                {
                    HasilOutput += i.ToString() + " ";
                }
                else
                { HasilOutput += " "; }


            }

            txtOutput.Text = HasilOutput;
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
