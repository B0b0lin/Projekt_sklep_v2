using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_sklep_gui
{
    public partial class Karta : Form
    {
        Functions Con;
        public Karta()
        {
            InitializeComponent();
            Con = new Functions();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 3;
            if(progressBar1.Value >= 99) 
            {
                string Query = $"update zarobek set suma = (select sum(cena_brutto * quantity) from koszyk)+(select suma from zarobek where Rodzaj = 'Karta') where Rodzaj = 'Karta'\r\n";
                Query = string.Format(Query);
                Con.SetData(Query);


                foreach(string i in Con.GetDataToList("Select nazwa_prod from koszyk"))
                {
                    string Query1 = $"IF EXISTS (SELECT * FROM Utarg WHERE Przedmiot ='{i}') BEGIN update utarg set Ilosc = Ilosc+(select Quantity from Koszyk where Nazwa_prod = '{i}'), Suma_zarobiona = Suma_zarobiona + (select Quantity*Cena_brutto from Koszyk where Nazwa_prod='{i}') where Przedmiot = '{i}' END ELSE BEGIN insert into utarg values ('{i}',(select Quantity*Cena_brutto from Koszyk where Nazwa_prod='{i}'),(select Quantity from Koszyk where Nazwa_prod = '{i}')) END";
                    Query1 = string.Format(Query1);
                    Con.SetData(Query1);
                }

                Con.SetData("Truncate table koszyk");
                Koszyk.Refresh();


                timer1.Enabled = false;
                DialogResult dr = MessageBox.Show("Tranzakcja przebiegła pomyślnie", "Tranzakcja udana");
                this.Close();   
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
