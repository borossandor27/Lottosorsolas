using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottosorsolas
{
    public partial class Form_Lottosorsolas : Form
    {
        Color normal_szin = Color.AliceBlue;
        Color valasztott_szin = Color.Red;

        static readonly int sorsolhato_Szamok_Szama = 5;
        List<int> jatszott_Szamok = new List<int>();
        int[] sorsolt_Szamok = new int[sorsolhato_Szamok_Szama];

        public Form_Lottosorsolas()
        {
            InitializeComponent();
        }

        private void Form_Lottosorsolas_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            Szamokat_Felrak();
        }

        private void Szamokat_Felrak()
        {
            int a = (panel_lottoszamok.Width - 40) / 15;
            int top = 10;
            int left = 20;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Label uj = new Label();
                    int szam = (i * 15 + j + 1);
                    uj.Text = (szam).ToString();
                    uj.Top = top + i * a + 1;
                    uj.Left = left + j * a + 1;
                    uj.Width = a;
                    uj.Height = a;
                    uj.TextAlign = ContentAlignment.MiddleCenter;
                    uj.Font = new Font(Font.FontFamily, FontHeight, FontStyle.Bold);
                    uj.BackColor = normal_szin;
                    uj.Click += (sender, e) =>
                    {
                        Label cimke = (Label)sender;
                        if (jatszott_Szamok.Count < sorsolhato_Szamok_Szama || jatszott_Szamok.IndexOf(int.Parse(cimke.Text)) != -1)
                        {
                            if (cimke.BackColor == normal_szin)
                            {
                                cimke.BackColor = valasztott_szin;
                                jatszott_Szamok.Add(int.Parse(cimke.Text));
                            }
                            else
                            {
                                cimke.BackColor = normal_szin;
                                jatszott_Szamok.Remove(int.Parse(cimke.Text));
                            }
                        }
                        else
                        {
                            MessageBox.Show("Már kiválasztotta a(z) " + sorsolhato_Szamok_Szama + " számot!");
                        }
                        jatszott_Szamok.Sort();
                        label_Megjatszott.Text = "Megjátszott ->" + string.Join(", ", jatszott_Szamok);
                    };

                    panel_lottoszamok.Controls.Add(uj);
                }
            }
        }

        private void button_Sorsolas_Click(object sender, EventArgs e)
        {
            //-- Kezdődik a sorsolás ----------------------------------------------------------------------------
            Random r = new Random();
            int db = 0;
            int szam;
            while (db < sorsolhato_Szamok_Szama)
            {
                do
                {
                    szam = r.Next(1, 91);
                } while (sorsolt_Szamok.Contains(szam));
                sorsolt_Szamok[db++] = szam;
            }
            Array.Sort(sorsolt_Szamok);
            label_Nyeroszamok.Text = "Nyerőszámok -> " + string.Join(", ", sorsolt_Szamok);

            //-- Találatok keresése -------------------------------------------------------------------------------
            int talalat = 0;
            foreach (int tipp in jatszott_Szamok)
            {
                if (sorsolt_Szamok.Contains(tipp))
                {
                    talalat++;
                }
            }

            //-- Eredmény kiiratása --------------------------------------------------------------------------------
            if (talalat == 0)
            {
                label_Talalat.Text = "Találat -> Önnek most nincs találata!";
            }
            else
            {
                label_Talalat.Text = "Találat -> Önnek " + talalat.ToString() + " találata van!";
            }
        }
    }
}
