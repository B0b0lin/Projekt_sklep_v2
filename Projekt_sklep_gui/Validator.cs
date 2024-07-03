using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_sklep_gui
{
    internal class Validator
    {
        Functions Con;
        public Validator() 
        {
            Con = new Functions();
        }
        //TODO: Validacja sprzedarzy, kiedy klikamy zapłata musi nastąpic walidacja 
        //czy pożądana ilość produktu jest w magazynie jak nie to komunikat i rollback

        public bool MagazynCheckSub(string item, int quantity)
        {
            string Querymagazyn = $"select quantity from magazyn where name = '{item}'";
            string QueryCategory = $"select category from magazyn where name = '{item}'";

            var quantityMagazyn = Convert.ToInt16(Con.GetStringData(Querymagazyn));

            if(Con.GetStringData(QueryCategory) != "Usluga") 
            {
                if (quantity <= quantityMagazyn)
                {
                    string Query = $"update magazyn set quantity = quantity - {quantity} where name = '{item}'";
                    Query = string.Format(Query);
                    Con.SetData(Query);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public bool MagazynCheckAdd(string item, int quantity)
        {
            string QueryCategory = $"select category from magazyn where name = '{item}'";
            string QueryQuantity = $"Select quantity from koszyk where nazwa_prod = '{item}'";
            string number = Con.GetStringData(QueryQuantity);
            

            if (Con.GetStringData(QueryCategory) != "Usluga")
            {
                string Query = $"update magazyn set quantity = quantity + {number} where name = '{item}'";
                Query = string.Format(Query);
                Con.SetData(Query);

                string Query1 = $"update magazyn set quantity = quantity - {quantity} where name = '{item}'";
                Query1 = string.Format(Query1);
                Con.SetData(Query1);

                return true;
                
            }
            else
            {
                return true;
            }
        }

        public bool MagazynCheckAdd(string item)
        {
            string QueryCategory = $"select category from magazyn where name = '{item}'";
            string QueryQuantity = $"Select quantity from koszyk where nazwa_prod = '{item}'";
            string number = Con.GetStringData(QueryQuantity);


            if (Con.GetStringData(QueryCategory) != "Usluga")
            {
                string Query = $"update magazyn set quantity = quantity + {number} where name = '{item}'";
                Query = string.Format(Query);
                Con.SetData(Query);

                return true;

            }
            else
            {
                return true;
            }
        }

        //TODO: Validacja logowania
    }
}
