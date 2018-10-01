using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Soal1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public class Item
        {
            public string country;
            public string name;
            public decimal lat;
            public Decimal lng;
            
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
           
            using (StreamReader r = new StreamReader("cities.json"))
            {
                string json = r.ReadToEnd();
                List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);

                items = items.Where(x => x.country.Equals("ID")).ToList();

                string input = txtInput.Text;
                int hasil;
                string hasiloutput = "";

                for (var i = 0; i < items.Count; i++)
                {
                                                          
                    hasil = StringDistance.LevenshteinDistance(input.ToLower(), items[i].name.ToLower());

                    decimal persenPerubahan = 0;

                 

                    persenPerubahan = ((decimal)hasil / (decimal)input.Length) * 100;

                    if (persenPerubahan <= 30)
                    {
                        hasiloutput += items[i].name + " (" + persenPerubahan + ")" + " ,";
                        }

                   
                    

                  }


                txtOutput.Text = hasiloutput;

            }

            MessageBox.Show("Done!");
          
        }

        public static class StringDistance
        {


            public static int GetHammingDistance(string s, string t)
            {
                if (s.Length != t.Length)
                {
                    throw new Exception("Strings must be equal length");
                }

                int distance =
                    s.ToCharArray()
                    .Zip(t.ToCharArray(), (c1, c2) => new { c1, c2 })
                    .Count(m => m.c1 != m.c2);

                return distance;
            }

            public static int GetDamerauLevenshteinDistance(string s, string t)
            {
                var bounds = new { Height = s.Length + 1, Width = t.Length + 1 };

                int[,] matrix = new int[bounds.Height, bounds.Width];

                for (int height = 0; height < bounds.Height; height++) { matrix[height, 0] = height; };
                for (int width = 0; width < bounds.Width; width++) { matrix[0, width] = width; };

                for (int height = 1; height < bounds.Height; height++)
                {
                    for (int width = 1; width < bounds.Width; width++)
                    {
                        int cost = (s[height - 1] == t[width - 1]) ? 0 : 1;
                        int insertion = matrix[height, width - 1] + 1;
                        int deletion = matrix[height - 1, width] + 1;
                        int substitution = matrix[height - 1, width - 1] + cost;

                        int distance = Math.Min(insertion, Math.Min(deletion, substitution));

                        if (height > 1 && width > 1 && s[height - 1] == t[width - 2] && s[height - 2] == t[width - 1])
                        {
                            distance = Math.Min(distance, matrix[height - 2, width - 2] + cost);
                        }

                        matrix[height, width] = distance;
                    }
                }

                return matrix[bounds.Height - 1, bounds.Width - 1];
            }

            public static int LevenshteinDistance(string s, string t)
            {
                int n = s.Length;
                int m = t.Length;
                int[,] d = new int[n + 1, m + 1];

                // Step 1
                if (n == 0)
                {
                    return m;
                }

                if (m == 0)
                {
                    return n;
                }

                // Step 2
                for (int i = 0; i <= n; d[i, 0] = i++)
                {
                }

                for (int j = 0; j <= m; d[0, j] = j++)
                {
                }

                // Step 3
                for (int i = 1; i <= n; i++)
                {
                    //Step 4
                    for (int j = 1; j <= m; j++)
                    {
                        // Step 5
                        int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

                        // Step 6
                        d[i, j] = Math.Min(
                            Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                            d[i - 1, j - 1] + cost);
                    }
                }
                // Step 7
                return d[n, m];
            }

        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtOutput.Text = "";
            
        }
    }
}
