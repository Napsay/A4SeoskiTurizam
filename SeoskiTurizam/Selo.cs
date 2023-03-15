using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SeoskiTurizam
{
    class Selo
    {
        public int SeloID { get; set; }
        public string Naziv { get; set; }
        public int GradID { get; set; }
        public string Grad { get; set; }
     

        public Selo() { }
        public void InicijalizujPolja(DataRow dr)
        {
            
        }

        public Selo(DataRow dr)
        {
            this.SeloID = (int)dr["SeloID"];
            this.Naziv = (string)dr["Naziv"];
            this.GradID = (int)dr["GradID"];
            this.Grad = (string)dr["Grad"];

        }

        
        public static List<Selo> UcitajSve()
        {
            SqlCommand cmd = Konekcija.GetCommand();
            cmd.CommandText = "usp_Selo";
          

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            List<Selo> lista = new List<Selo>();


            try
            {
                cmd.Connection.Open();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    foreach (DataRow dr in dt.Rows) lista.Add(new Selo(dr));
                    return lista;
                }
                else throw new Exception("tabela sela je prazna");
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

        public bool Izmeni()
        {
            SqlCommand cmd = Konekcija.GetCommand();
            cmd.CommandText = "usp_SeloIzmeni";
          
            cmd.Parameters.AddWithValue("@sifra", this.SeloID);
            cmd.Parameters.AddWithValue("@naziv", this.Naziv);
            if (this.GradID > 0) cmd.Parameters.AddWithValue("@gradid", this.GradID);

            try
            {
                cmd.Connection.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                   
                    return true;
                }
                else throw new Exception("izmena nije izvrsena");
            }
            catch (Exception ex)
            {
               
                return false;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
    }
}
