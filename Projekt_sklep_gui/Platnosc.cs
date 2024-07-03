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
    public partial class Platnosc : Form
    {
        public Platnosc()
        {
            InitializeComponent();
        }

        private void Karta_Click(object sender, EventArgs e)
        {
            Karta obj = new Karta();
            obj.Show();
            this.Hide();
        }

        private void Gotowka_Click(object sender, EventArgs e)
        {
            Gotowka obj = new Gotowka();
            obj.Show();
            this.Hide();
        }

        private void Anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
