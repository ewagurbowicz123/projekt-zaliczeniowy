using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        decimal sumaZarobkow = 0;
        decimal sumaWydatkow = 0;
        Dictionary<string, decimal> wydatki_pb = new Dictionary<string, decimal>
        {
            { "Czynsz",0 },
            { "Media",0 },
            { "Ubezpieczenie", 0 },
            { "Zakupy", 0 },
            { "Jedzenie", 0 },
            { "Transport", 0 },
            { "Zdrowie",0 },
            { "Inne", 0 },
            
        };
        public Form1()
        {
            InitializeComponent();
            cbzarobki.Items.AddRange(new string[] { "Wynagrodzenie", "Premia", "Inwestycja", "Sprzedaz online", "Inne" });
            cbwydatki.Items.AddRange(new string[] { "Czynsz", "Media", "Ubezpieczenie", "Zakupy", "Jedzenie", "Transport", "Zdrowie", "Inne" });

            cbzarobki.SelectedIndex = 0;
            cbwydatki.SelectedIndex = 0;

            pb.Minimum = 0;
            pb.Maximum = 100;

        }
        
        
        private string ostatniaKategoriaWydatek = "";
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal kwota) && kwota > 0)
            {
                string kategoria = cbzarobki.SelectedItem.ToString();
                sumaZarobkow += kwota;

                tvzarobki.Nodes.Add($"{kategoria}: +{kwota} zł");

                textBox1.Clear();
                Update();
            }
            else
            {
                MessageBox.Show("Wprowadź poprawną kwotę zarobków!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox2.Text, out decimal kwota) && kwota > 0)
            {
                string kategoria = cbwydatki.SelectedItem.ToString();
                sumaWydatkow += kwota;
                ostatniaKategoriaWydatek = kategoria;
                tvwydatki.Nodes.Add($"{kategoria}: -{kwota} zł");


                if (wydatki_pb.ContainsKey(kategoria))
                {
                    wydatki_pb[kategoria] += kwota;
                }

                textBox2.Clear();
                AktualizujProgressBar();
            }
            else
            {
                MessageBox.Show("Wprowadź poprawną kwotę wydatków!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pb_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            decimal pozostalo = sumaZarobkow - sumaWydatkow;
            string raport = $"Zarobki: {sumaZarobkow} zł\n" +
                            $"Wydatki: {sumaWydatkow} zł\n" +
                            $"Pozostało: {pozostalo} zł";
            MessageBox.Show(raport, "Raport budżetu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AktualizujProgressBar()
        {
            decimal sumaSpecjalnych = wydatki_pb.Values.Sum();
            if (sumaZarobkow > 0)
            {
                int procent = (int)((sumaSpecjalnych / sumaZarobkow) * 100);
                pb.Value = Math.Min(procent, 100);
            }
            else
            {
                pb.Value = 0;
            }
        }
    }
}
