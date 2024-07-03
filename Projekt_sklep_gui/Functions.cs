using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_sklep_gui
{
    internal class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string ConStr;
        public Functions() 
        {
            //properties na baze danych >> "connection string" wkleic tutaj na innym użądzeniu ze ściażką
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ignac\Documents\Magazyn.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }

        public DataTable GetData(string Query) 
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query,ConStr);
            sda.Fill(dt);
            return dt;
        }

        public int SetData(string Query)
        {
            int cnt = 0;
            if(Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Cmd.CommandText = Query;
            cnt = Cmd.ExecuteNonQuery();
            Con.Close();
            return cnt;
        }

        public string GetStringData(string Query)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            SqlCommand cmdd = new SqlCommand(Query, Con);
            SqlDataReader DR = cmdd.ExecuteReader();
            while (DR.Read())
            {
                string temp = Convert.ToString(DR[0]);
                Con.Close();
                return temp;
            }
            Con.Close();
            return "";
        }

        public List<string> GetDataToList(string Query)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            SqlCommand cmdd = new SqlCommand(Query, Con);
            SqlDataReader DR = cmdd.ExecuteReader();    

            List<string> list = new List<string>();
            do
            {
                int count = DR.FieldCount;
                while (DR.Read())
                {
                    for (int i = 0; i < count; i++)
                    {
                        list.Add(Convert.ToString(DR.GetValue(i)));
                    }
                }
            } while (DR.NextResult());
            Con.Close();
            return list;

        }
    }
}
