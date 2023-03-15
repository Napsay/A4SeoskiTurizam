using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SeoskiTurizam
{
    class Konekcija
    {
        static string str = @"Data Source=.\SQLEXPRESS;Integrated security=true; Initial Catalog=AA4 ";

        public static SqlCommand GetCommand()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection(str);
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }
    }
}
