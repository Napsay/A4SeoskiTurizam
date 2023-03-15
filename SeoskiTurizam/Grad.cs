using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SeoskiTurizam
{
    class Grad
    {
        public static DataTable UcitajSve()
        {
            SqlCommand cmd = Konekcija.GetCommand();
            cmd.CommandText = "usp_Grad";
            

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                cmd.Connection.Open();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else throw new Exception("tabela gradova je prazna");
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
    }
}
