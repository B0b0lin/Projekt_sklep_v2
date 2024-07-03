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
    public partial class KoniecDnia : Form
    {
        Functions Con;
        public KoniecDnia()
        {
            InitializeComponent();
            Con = new Functions();
            ShowTable();
        }

        private void ShowTable()
        {
            string Query = "Select Przedmiot, Ilosc, Suma_zarobiona from Utarg";
            UtargList.DataSource = Con.GetData(Query);
        }

        private void sprzedazBtn_Click(object sender, EventArgs e)
        {
            Sprzedaz obj = new Sprzedaz();
            obj.Show();
            this.Hide();
        }

        private void MagazynBtn_Click(object sender, EventArgs e)
        {
            Magazyn obj = new Magazyn();
            obj.Show();
            this.Hide();
        }

        private void StanKasyBtn_Click(object sender, EventArgs e)
        {
            StanKasy obj = new StanKasy();
            obj.Show();
            this.Hide();
        }

        private void DrukujRaportBtn_Click(object sender, EventArgs e)
        {
            DrukujRaport obj = new DrukujRaport();
            obj.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy chcesz zakończyć działanie progrogramu?\nPamiętaj o zakończeniu dnia przed zakończeniem pracy!", "Kończenie pracy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) { Environment.Exit(1); }
        }
    }
}
