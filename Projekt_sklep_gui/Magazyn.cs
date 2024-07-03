using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Projekt_sklep_gui
{
    public partial class Magazyn : Form
    {
        Functions Con;
        public Magazyn()
        {
            InitializeComponent();
            Con = new Functions();
            ShowMagazyn();
            ComboGetValues();
        }

        //DONE wychodzenie z aplikacji
        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy chcesz zakończyć działanie progrogramu?\nPamiętaj o zakończeniu dnia przed zakończeniem pracy!", "Kończenie pracy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) { Environment.Exit(1); }
        }

        //DONE validatora dla textboxa zeby były tylko numery
        private void NumbersOnly(object sender, KeyPressEventArgs e)
        {
            char numsOnly = e.KeyChar;
            if (!Char.IsDigit(numsOnly) && numsOnly != 8)
            {
                e.Handled = true;
            }
        }
        //DONE to samo co wyżej tylko dla cen bo "."
        private void NumbersOnlyForPrice(object sender, KeyPressEventArgs e) 
        {
            char numsOnly = e.KeyChar;
            if (!Char.IsDigit(numsOnly) && numsOnly != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void ComboGetValues()
        {
            UsunNazwa.Items.Clear();
            nazwaEdytowanie.Items.Clear();
            nazwaDodawanieStanu.Items.Clear();
            string Sql = "select Name from Magazyn";
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ignac\\Documents\\Magazyn.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                UsunNazwa.Items.Add(DR[0]);
                nazwaDodawanieStanu.Items.Add(DR[0]);
                nazwaEdytowanie.Items.Add(DR[0]);
            }
        }

        private void ShowMagazyn()
        {
            string Query = "Select Name Nazwa, Quantity Ilosc, Value_netto Cena_Netto, Category Kategoria from Magazyn";
            MagazynList.DataSource = Con.GetData(Query);
        }

        //DONE dodawanie produktów do magazynu
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(newProductNameTextBox.Text == "" || newPriceNettoTextBox.Text == "" || newQuantityTextBox.Text == "" || categoryCombo.Text == "")
                {
                    MessageBox.Show("Wypełnij wszystkie pola poprawnie!");
                }
                else
                {
                    string MagName = newProductNameTextBox.Text;
                    string MagCategory = categoryCombo.Text;
                    int MagQuantity = Convert.ToInt32(newQuantityTextBox.Text);
                    //dodać walidacje decimala 
                    string MagMoney = newPriceNettoTextBox.Text;

                    try
                    {
                        string Query = $"insert into Magazyn values('{MagName}','{MagQuantity}','{MagMoney}','{MagCategory}')";
                        Query = string.Format(Query, newProductNameTextBox.Text);
                        Con.SetData(Query);
                        ShowMagazyn();
                        ComboGetValues();
                        MessageBox.Show("Produkt dodany!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                    newProductNameTextBox.Text = "";
                    categoryCombo.Text = "";
                    newPriceNettoTextBox.Text = "";
                    newQuantityTextBox.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //DONE dodawanie stanuów na magazyn  
        private void DodajStanBtn_Click(object sender, EventArgs e)
        {
            if (nazwaDodawanieStanu.Text == "")
            {
                MessageBox.Show("Wybierz produkt do dodania stanu!");
            }
            else
            {
                string MagNazwaDodawanie = nazwaDodawanieStanu.Text;
                string MagIloscDodawanie = IloscDodawanieStanu.Text;
                try
                {
                    string Query = $"update magazyn set quantity = " +
                        $"(select quantity from magazyn where Name = '{MagNazwaDodawanie}')+{MagIloscDodawanie} where name = '{MagNazwaDodawanie}'";
                    Query = string.Format(Query, newProductNameTextBox.Text);
                    Con.SetData(Query);
                    ShowMagazyn();
                    ComboGetValues();
                    MessageBox.Show("Stany dodane pomyslnie!");
                    IloscDodawanieStanu.Text = "";
                    nazwaDodawanieStanu.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Magazyn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'magazynDataSet.Magazyn' table. You can move, or remove it, as needed.
            this.magazynTableAdapter.Fill(this.magazynDataSet.Magazyn);

        }

        //DONE usuwanie produktu
        private void usunBtn_Click(object sender, EventArgs e)
        {
            if(UsunNazwa.Text == "")
            {
                MessageBox.Show("Wybierz produkt do usunięcia");
            }
            else
            {
                    string MagusunNazwa = UsunNazwa.Text;
                try
                {
                    string Query = $"delete from Magazyn where name='{MagusunNazwa}'";
                    Query = string.Format(Query, UsunNazwa.Text);
                    Con.SetData(Query);
                    ShowMagazyn();
                    ComboGetValues();
                    MessageBox.Show("Produkt usunięty!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                UsunNazwa.Text = "";

            }
        }

        //DONE Edystowanie rekordów w bazie danych
        private void EdytowanieBtn_Click(object sender, EventArgs e)
        {
            if (nazwaEdytowanie.Text == "")
            {
                MessageBox.Show("Wybierz produkt do edycji!");
            }
            else
            { 

                string MagEdycjaNazwa = nazwaEdytowanie.Text;
                string MagKategoria = kategoriaEdycja.Text;
                string MagIlosc = iloscEdycja.Text;
                string MagCena = CenaEdycja.Text;
                try
                {
                    string Query = $"update magazyn set quantity = '{MagIlosc}', value_netto = '{MagCena}'" +
                                   $",category = '{MagKategoria}' where name = '{MagEdycjaNazwa}'";
                    Query = string.Format(Query, nazwaEdytowanie.Text);
                    Con.SetData(Query);
                    ShowMagazyn();
                    ComboGetValues();
                    MessageBox.Show("Produkt zaktualizowany pomyślnie!");

                    nazwaEdytowanie.Text = "";
                    kategoriaEdycja.Text = "";
                    iloscEdycja.Text = "";
                    CenaEdycja.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //DONE  wyświetlanie wartosci podczas edytowania
        private void nazwaEdytowanie_TextChanged(object sender, EventArgs e)
        {
            string Sql = $"select * from Magazyn where name = '{nazwaEdytowanie.Text}'";
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ignac\\Documents\\Magazyn.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                kategoriaEdycja.Text = DR[4].ToString();
                iloscEdycja.Text = DR[2].ToString();
                CenaEdycja.Text = DR[3].ToString().Replace(",", ".");
            }
        }

        //DONE
        private void sprzedazBtn_Click(object sender, EventArgs e)
        {
            Sprzedaz Obj = new Sprzedaz();
            Obj.Show();
            this.Hide();
        }

        private void categoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryCombo.Text == "Usluga")
            {
                newQuantityTextBox.Text = "0";
                newQuantityTextBox.ReadOnly = true;
            }
            else
            {
                newQuantityTextBox.Text = "";
                newQuantityTextBox.ReadOnly = false;
            }
        }

        //DONE
        private void StanKasyBtn_Click(object sender, EventArgs e)
        {
            StanKasy Obj = new StanKasy();
            Obj.Show();
            this.Hide();
        }

        //DONE: Dodac strone i przypisac do przycisku
        private void KoniecDniaBtn_Click(object sender, EventArgs e)
        {
            KoniecDnia obj = new KoniecDnia();
            obj.Show();
            this.Hide();

        }
    }
}
