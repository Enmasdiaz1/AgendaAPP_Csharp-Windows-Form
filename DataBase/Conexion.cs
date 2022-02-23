using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows;

namespace Database
{
    public class Conexion
    {
        SqlConnection cnx;

        public void conn()
        {
            
            try
            {
                cnx = new SqlConnection("Data Source=.;Initial Catalog=Agenda;Integrated Security=True");
                cnx.Open();          


            }
            catch (Exception)
            {
               
            }
        }

    }
}
