using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_sklep_gui
{
    public partial class Gotowka : Form
    {
        Functions Con;
        public Gotowka()
        {
            InitializeComponent();
            Con = new Functions();
            ShowMoney();
        }

        private void NumbersOnly(object sender, KeyPressEventArgs e)
        {
            char numsOnly = e.KeyChar;
            if (!Char.IsDigit(numsOnly) && numsOnly != 8)
            {
                e.Handled = true;
                
            }
        }



        private void ShowMoney()
        {
            string naleznoscValue = Con.GetStringData("select sum(quantity*cena_brutto) from koszyk");
            NaleznoscText.Text = naleznoscValue;
        }

        private void ZatwierdzBtn_Click(object sender, EventArgs e)
        {
            int naleznosc = Convert.ToInt32(NaleznoscText.Text);
            if (KwotaKientText.Text == "")
            {
                MessageBox.Show("Nie zostawiaj pustego pola");
            }
            else
            {
                int kwota = Convert.ToInt32(KwotaKientText.Text);
                if(kwota >= naleznosc)
                {
                    string Query = $"update zarobek set suma = (select sum(cena_brutto * quantity) from koszyk)+(select suma from zarobek where Rodzaj = 'Gotowka') where Rodzaj = 'Gotowka'";
                    Query = string.Format(Query);
                    Con.SetData(Query);
        
        
                    foreach (string i in Con.GetDataToList("Select nazwa_prod from koszyk"))
                    {
                        string Query1 = $"IF EXISTS (SELECT * FROM Utarg WHERE Przedmiot ='{i}') BEGIN update utarg set Ilosc = Ilosc+(select Quantity from Koszyk where Nazwa_prod = '{i}'), Suma_zarobiona = Suma_zarobiona + (select Quantity*Cena_brutto from Koszyk where Nazwa_prod='{i}') where Przedmiot = '{i}' END ELSE BEGIN insert into utarg values ('{i}',(select Quantity*Cena_brutto from Koszyk where Nazwa_prod='{i}'),(select Quantity from Koszyk where Nazwa_prod = '{i}')) END";
                        Query1 = string.Format(Query1);
                        Con.SetData(Query1);
                    }
        
                    Con.SetData("Truncate table koszyk");
                    Koszyk.Refresh();
        
                    DialogResult dr = MessageBox.Show("Tranzakcja przebiegła pomyślnie", "Tranzakcja udana");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Podaj prawidłową kwotę");
                }
            }
        
        }

        private void ResztaSum(object sender, EventArgs e)
        {
            if(KwotaKientText.Text != "")
            { 
                int naleznosc = Convert.ToInt32(NaleznoscText.Text);
                int kwota = Convert.ToInt32(KwotaKientText.Text);
                ResztaText.Text = Convert.ToString(kwota - naleznosc);
            }
        }
    }
}
