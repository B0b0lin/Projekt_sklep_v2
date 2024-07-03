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
    public partial class StanKasy : Form
    {
        Functions Con;
        public StanKasy()
        {
            InitializeComponent();
            Con = new Functions();
            ShowTable();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy chcesz zakończyć działanie progrogramu?\nPamiętaj o zakończeniu dnia przed zakończeniem pracy!", "Kończenie pracy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) { Environment.Exit(1); }
        }

        private void ShowTable()
        {
            string Query2 = "update zarobek set suma = ((Select suma from zarobek where Rodzaj = 'Karta')+(Select suma from zarobek where Rodzaj = 'Gotowka')) where rodzaj = 'Suma ogolna'";
            Query2 = string.Format(Query2);
            Con.SetData(Query2);
            
            string Query = "Select Przedmiot, Ilosc, Suma_zarobiona from Utarg";
            UtargList.DataSource = Con.GetData(Query);
            
            string Query1 = "Select Rodzaj, Suma from Zarobek";
            AllUtargList.DataSource = Con.GetData(Query1);

        }
        
        //Done: dodac strone i funkcje
        private void KoniecDniaBtn_Click(object sender, EventArgs e)
        {
            KoniecDnia obj = new KoniecDnia();
            obj.Show();
            this.Hide();
        }

        //DONE
        private void MagazynBtn_Click(object sender, EventArgs e)
        {
            Magazyn Obj = new Magazyn();
            Obj.Show();
            this.Hide();
        }

        //DONE
        private void sprzedazBtn_Click(object sender, EventArgs e)
        {
            Sprzedaz Obj = new Sprzedaz();
            Obj.Show();
            this.Hide();
        }

        private void UtargList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void magazynBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AllUtargList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
