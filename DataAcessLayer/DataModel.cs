using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;

        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.ConStr);
            cmd = con.CreateCommand();
        }

        public List<Sehir> GetSehirs()
        {
            List<Sehir> sehirler = new List<Sehir>();
            try
            {
                cmd.CommandText = "SELECT ID, Isim FROM Sehirler";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Sehir sehir = new Sehir();
                    sehir.ID = reader.GetInt32(0);
                    sehir.Isim = reader.GetString(1);
                    sehirler.Add(sehir);
                    //sehirler.Add(new Sehir() { ID = reader.GetInt32(0), Isim = reader.GetString(1) });
                }

            }
            finally
            {
                con.Close();
            }
            return sehirler;
        }
    }
}
