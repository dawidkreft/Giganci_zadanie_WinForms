using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fizyka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPredkosc_Click(object sender, EventArgs e)
        {
            double droga = 0;            // Tworzymy zmienne
            double czas = 0;
            double predkosc = 0; 

            try               // rozpoczynamy wyjatek 
            {
                droga = double.Parse(txtDroga.Text);            // pobieramy dane z textboxow
                czas = double.Parse(txtCzas.Text);              // oraz parsujemy na żądany typ 
                predkosc = droga / czas;                       // obliczamy nasz wynik
            }
            catch
            {
                MessageBox.Show("Zle wartosci ",                     // w zlych danych informujemy uzytkownika 
                                       "Błąd ",
                                            MessageBoxButtons.OK,
                                                 MessageBoxIcon.Warning 
                                );
            }

            txtPredkosc.Text = predkosc.ToString();          // wyswietlanie nasz wynik 
                                                             // Pamietaj ze textbox wyswietla Stringa !! 
        }

        private void btnGestosc_Click(object sender, EventArgs e)
        {
            double masa = 0;            // Tworzymy zmienne
            double objetosc= 0;
            double gestosc = 0;

            try               // rozpoczynamy wyjatek 
            {
                masa= double.Parse(txtMasa.Text);            // pobieramy dane z textboxow
                objetosc= double.Parse(txtObjetosc.Text);
                gestosc = masa / objetosc;                       // obliczamy nasz wynik
            }
            catch
            {
                MessageBox.Show("Zle wartosci ",                     // w zlych danych informujemy uzytkownika 
                                       "Błąd ",
                                            MessageBoxButtons.OK,
                                                 MessageBoxIcon.Warning
                                );
            }

            txtGestosc.Text = gestosc.ToString();          // wyswietlanie nasz wynik 
                                                           // Pamietaj ze textbox wyswietla Stringa !! 
        }
    }
    
}
