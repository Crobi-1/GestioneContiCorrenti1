using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioneContiCorrenti1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] Nome = new string[] { "Rossi Mario", "Bianchi Luigi", "Belli Giulia", "Dotti Fabio", "Merli Gianna", "Zeri Giulio", "Batti Maria" };
        String[] Conto = new string[] { "11264", "99780", "00342", "03419", "34562", "09887", "02341" };
        int[] Saldo = new int[] { 11534, -2345, 3451, 127, 45673, -13, 3452 };
        private void button1_Click(object sender, EventArgs e)
        {
            string contoCercato = txt_NumeroConto.Text;
            bool trovato = false;

            for (int i = 0; i < Conto.Length; i++)
            {
                if (Conto[i] == contoCercato)
                {
                    lbl_Risultato1.Text = ("Intestatario " + Nome[i]  + " Saldo " + Saldo[i]);
                    trovato = true;
                }
            }

            if (trovato==false)
            {
                lbl_Risultato1.Text = ("Conto non trovato");
            }



        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            
            lst_n1.Items.Clear();
            lst_n2.Items.Clear();
            lst_n3.Items.Clear();

           
            for (int i = 0; i < Nome.Length; i++)
            {
                lst_n1.Items.Add(Nome[i]);
                lst_n2.Items.Add(Conto[i]);
                lst_n3.Items.Add(Saldo[i]); 
            }
        }

        private void btn_n3_Click(object sender, EventArgs e)
        {
            string nomeCercato=txt_NomeCognome.Text;
            bool trovato = false;

            for (int i = 0; i < Nome.Length; i++)
            {
                if (Nome[i] == nomeCercato)
                {
                    lbl_Risultato2.Text = ("Conto " + Conto[i] + " Saldo " + Saldo[i] );
                    trovato = true;
                }
            }

            if (trovato == false)
            {
                lbl_Risultato2.Text = ("Nome e Cognome non trovato");
            }

        }
    }
    
}
