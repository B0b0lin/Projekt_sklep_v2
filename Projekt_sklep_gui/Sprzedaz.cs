using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_sklep_gui
{
    public partial class Sprzedaz : Form
    {
        Functions Con;
        Validator Validator;
        public Sprzedaz()
        {
            InitializeComponent();
            Con = new Functions();
            Validator = new Validator();
            ShowKoszyk();
            ComboGetValuesKoszyk();
        }

        private void ShowKoszyk()
        {
            string Query = "Select Nazwa_prod Produkt, Cena_brutto Cena, Quantity Ilosc from Koszyk";
            KoszykGridView.DataSource = Con.GetData(Query);

            string QueryGet = $"select sum(cena_brutto*quantity) from koszyk";
            sumaKoszyk.Text = Con.GetStringData(QueryGet);
        }

        private void ShowItems(string type)
        {
            if(type == "Usluga")
            {
                string Query = $"Select name Usluga, value_netto Cena from Magazyn where Category = '{type}'";
                itemsGridView.DataSource = Con.GetData(Query);
            }
            else
            {
                string Query = $"Select name Usluga,quantity Stan_magazynu, CAST(value_netto*1.60 as int) Cena from Magazyn where Category = '{type}'";
                itemsGridView.DataSource = Con.GetData(Query);
            }
            
        }

        private void ComboGetValuesItems(string type)
        {
            sprzedajComboBox.Items.Clear();
            string Sql = $"select Name from Magazyn where category = '{type}' ";
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ignac\\Documents\\Magazyn.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                sprzedajComboBox.Items.Add(DR[0]);
            }
        }

        private void ComboGetValuesKoszyk()
        {
            UsunKoszykKombo.Items.Clear();
            ZmienKoszukCombo.Items.Clear(); 
            string Query = "Select nazwa_prod from koszyk";
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ignac\\Documents\\Magazyn.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                UsunKoszykKombo.Items.Add(DR[0]);
                ZmienKoszukCombo.Items.Add(DR[0]);
            }
        }

        private void NumbersOnly(object sender, KeyPressEventArgs e)
        {
            char numsOnly = e.KeyChar;
            if (!Char.IsDigit(numsOnly) && numsOnly != 8)
            {
                e.Handled = true;
            }
        }

        //Done: Przejscid do magazynu
        private void button2_Click(object sender, EventArgs e)
        {
            Magazyn Obj = new Magazyn();
            Obj.Show();
            this.Hide();
        }

        //DONE: Exit app
        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy chcesz zakończyć działanie progrogramu?\nPamiętaj o zakończeniu dnia przed zakończeniem pracy!", "Kończenie pracy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) { Environment.Exit(1); }
        }


        //KOSZYK
        //DONE: Zmien BTN
        private void zmienBtn_Click(object sender, EventArgs e)
        {
            if (ZmienKoszukCombo.Text == "")
            {
                MessageBox.Show("Wybierz produkt do edycji!");
            }
            else
            {

                string MagEdycjaNazwa = ZmienKoszukCombo.Text;
                string MagIlosc = iloscZmien.Text;
                bool decyzja;

                if (Convert.ToInt16(MagIlosc) > Convert.ToInt32(Con.GetStringData($"select quantity from koszyk where nazwa_prod = '{MagEdycjaNazwa}'")))
                {
                    string tempnum = Con.GetStringData($"select quantity from koszyk where nazwa_prod = '{MagEdycjaNazwa}'");
                    string Query1 = $"update magazyn set quantity = {tempnum} + (select quantity from magazyn where name = '{MagEdycjaNazwa}')  where name = '{MagEdycjaNazwa}'";
                    Query1 = string.Format(Query1);
                    Con.SetData(Query1);
                    decyzja = Validator.MagazynCheckSub(MagEdycjaNazwa, Convert.ToInt32(MagIlosc));
                }
                else
                {

                    decyzja = Validator.MagazynCheckAdd(MagEdycjaNazwa, Convert.ToInt32(MagIlosc));
                }

                if (decyzja)
                {
                    try
                    {
                        string category = Con.GetStringData($"select category from magazyn where name = '{MagEdycjaNazwa}'");
                        string Query = $"update koszyk set quantity = '{MagIlosc}' where nazwa_prod = '{MagEdycjaNazwa}'";
                        Query = string.Format(Query, ZmienKoszukCombo.Text);
                        Con.SetData(Query);
                        ShowItems(category);
                        ShowKoszyk();
                        ComboGetValuesKoszyk();
                        MessageBox.Show("Produkt zaktualizowany pomyślnie!");

                        ZmienKoszukCombo.Text = "";
                        iloscZmien.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Brak wybranej ilości asortymentu");
                }
            }
        }
        private void ZmienKoszukCombo_TextChanged(object sender, EventArgs e)
        {
            string Sql = $"select nazwa_prod,quantity from koszyk where nazwa_prod = '{ZmienKoszukCombo.Text}'";
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ignac\\Documents\\Magazyn.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                ZmienKoszukCombo.Text = DR[0].ToString();
                iloscZmien.Text = DR[1].ToString();
            }
        }

        //DONE: usun BTN
        private void UsunBtn_Click(object sender, EventArgs e)
        {
            if (UsunKoszykKombo.Text == "")
            {
                MessageBox.Show("Wybierz produkt do usunięcia");
            }
            else
            {
                string koszykUsunNazwa = UsunKoszykKombo.Text;
                string iloscUsun = Con.GetStringData($"Select quantity from koszyk where nazwa_prod = '{koszykUsunNazwa}'");
                
                string category = Con.GetStringData($"select category from magazyn where name = '{koszykUsunNazwa}'");
                Validator.MagazynCheckAdd(koszykUsunNazwa);
                string Query = $"delete from Koszyk where nazwa_Prod = '{koszykUsunNazwa}'";
                Query = string.Format(Query, UsunKoszykKombo.Text);
                Con.SetData(Query);
                ShowItems(category);
                ShowKoszyk();
                ComboGetValuesKoszyk();


                MessageBox.Show("Produkt usunięty!");
                
                
                UsunKoszykKombo.Text = "";
            }
        }

        //DONE: Zaplac BTN wyskakujące nowe okno z wyborem płatnosci i pozniej wyskakujace z info z karty lub kalkulator reszty
        private void Zaplata_btn_Click(object sender, EventArgs e)
        {
            Platnosc obj = new Platnosc();
            obj.Show();
        }

        //DONE: Anulu BTN
        private void anulacja_btn_Click(object sender, EventArgs e)
        {
            List<string> names = new List<string>();
            foreach(string i in Con.GetDataToList("select nazwa_prod from koszyk"))
            {
                names.Add(i);
            }

            int j = 0;
            foreach(string i in Con.GetDataToList("select quantity from koszyk"))
            {
                Validator.MagazynCheckAdd(names[j],Convert.ToInt32(i));
                j++;
            }

            string category = Con.GetStringData($"select category from magazyn where name = 'Napoje'");
            ShowItems(category);
            names.Clear();
            Con.SetData("Truncate table koszyk");
            ShowKoszyk();
        }

        //DONE: Dodawanie do koszyka
        private void DodajDoKoszykaBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if(sprzedajComboBox.Text == "" || iloscSprzedaj.Text == "")
                {
                    MessageBox.Show("Wypełnij wszystkie pola, aby dodać produkt do koszyka");
                }
                else
                {
                    string koszSprzedaj = sprzedajComboBox.Text;
                    string koszIlosc = iloscSprzedaj.Text;

                    string QueryCheck = $"select nazwa_prod from koszyk where nazwa_prod = '{koszSprzedaj}'";

                    bool decyzja = Validator.MagazynCheckSub(koszSprzedaj, Convert.ToInt32(koszIlosc));
                    if (decyzja)
                    {
                        if (Con.GetStringData(QueryCheck) != koszSprzedaj)
                        {
                            string category = Con.GetStringData($"select category from magazyn where name = '{koszSprzedaj}'");
                            string Query = $"insert into Koszyk (Nazwa_prod,Cena_brutto,Quantity) values('{koszSprzedaj}',(select cast(value_netto*1.60 as int) from magazyn where Name = '{koszSprzedaj}'),'{koszIlosc}')";
                            Query = string.Format(Query, sprzedajComboBox.Text);
                            Con.SetData(Query);
                            ShowItems(category);
                            ShowKoszyk();
                            ComboGetValuesKoszyk();

                            string QueryGet = $"select Sum(cena_brutto*Quantity) from koszyk";
                            sumaKoszyk.Text = Con.GetStringData(QueryGet);
                        }
                        else
                        {
                            string QueryExist = $"update koszyk set quantity = quantity + {koszIlosc} where nazwa_prod = '{koszSprzedaj}'";
                            QueryExist = string.Format(QueryExist, sprzedajComboBox.Text);
                            Con.SetData(QueryExist);
                            ShowKoszyk();
                            ComboGetValuesKoszyk();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Brak wybranej ilości asortymentu");
                    }
                }

                    sprzedajComboBox.Text = "";
                    iloscSprzedaj.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //DONE: BTN - wejscia gry
        private void wejsciaGryBtn_Click(object sender, EventArgs e)
        {
            sprzedajComboBox.Text = "";
            iloscSprzedaj.Text = "";
            ShowItems("Usluga");
            ComboGetValuesItems("Usluga");
        }

        //DONE: BTN - Napoje
        private void NapojeBTN_Click(object sender, EventArgs e)
        {
            sprzedajComboBox.Text = "";
            iloscSprzedaj.Text = "";
            ShowItems("Napoje");
            ComboGetValuesItems("Napoje");
        }

        //DONE: BTN - Akcesoria
        private void AkcesoriaBTN_Click(object sender, EventArgs e)
        {
            sprzedajComboBox.Text = "";
            iloscSprzedaj.Text = "";
            ShowItems("Akcesoria");
            ComboGetValuesItems("Akcesoria");
        }

        //DONE
        private void StanKasyBtn_Click(object sender, EventArgs e)
        {
            StanKasy obj = new StanKasy();
            obj.Show();
            this.Hide();
        }

        //DONE: Dodać strone i podlinowac pod przycisk
        private void KoniecDniaBtn_Click(object sender, EventArgs e)
        {
            KoniecDnia obj = new KoniecDnia();
            obj.Show();
            this.Hide();
        }


    }
}
