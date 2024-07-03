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
    public partial class DrukujRaport : Form
    {
        Functions Con;
        public DrukujRaport()
        {
            InitializeComponent();
            Con = new Functions();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 3;
            if (progressBar1.Value >= 99)
            {
                Con.SetData("Truncate table utarg");

                timer1.Enabled = false;
                DialogResult dr = MessageBox.Show("Dokument wydrukowany", "Drukowanie pomyślne");
                Koszyk.RefreshKoniecDnia();
                this.Close();
            }
        }
    }
}
