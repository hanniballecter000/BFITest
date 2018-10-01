using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soal2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            LabelTgl.Text = "Tanggal : " + DateTime.Now.ToString("dd") +", Bulan : " + DateTime.Now.ToString("MM");

            txtHasil.Text = GenerateManyRandom(Convert.ToInt32(txtJumlah.Text.ToString()));

        }
            

        public string GenerateManyRandom(int count)
        {

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                builder.Append(GenerateRandom() + Environment.NewLine);
            }  




            return builder.ToString();
        }
        // Generate a random password  
        public string GenerateRandom()
        {


            StringBuilder builder = new StringBuilder();
            // 16 karakter (A-Z,a-z,0-9)
            // karakter 1-7 bebas 
            builder.Append(CreateRandomCharacter(7));
            // karakter 8 & 9 merupakan tanggal program berjalan
            builder.Append(DateTime.Now.ToString("dd"));
            // karakter 10-14 bebas 
            builder.Append(CreateRandomCharacter(5));
            // karakter 15 & 16 merupakan Bulan program berjalan
            builder.Append(DateTime.Now.ToString("MM"));
            
            
            return builder.ToString();
        }


  
        public  string CreateRandomCharacter(int maxSize)
        {
            char[] chars = new char[62];
            chars =
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            byte[] data = new byte[1];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetNonZeroBytes(data);
                data = new byte[maxSize];
                crypto.GetNonZeroBytes(data);
            }
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }

        private void txtJumlah_KeyPress(object sender, KeyPressEventArgs e)
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
