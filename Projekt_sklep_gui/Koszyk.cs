using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_sklep_gui
{
    public class Koszyk
    {
        public static void Refresh() 
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name == "Sprzedaz")
                    Application.OpenForms[i].Close();
            }

            Sprzedaz obj = new Sprzedaz();
            obj.Show();
        }

        public static void RefreshKoniecDnia()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name == "KoniecDnia")
                    Application.OpenForms[i].Close();
            }

            KoniecDnia obj = new KoniecDnia();
            obj.Show();
        }
    }
}
