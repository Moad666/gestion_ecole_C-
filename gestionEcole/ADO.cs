using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace gestionEcole
{
    internal class ADO
    {
        public SqlConnection cnx = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public SqlDataAdapter da;
        public DataTable dt = new DataTable();
        public DataSet ds = new DataSet();

        public void getConnection()
        {
            if(cnx.State == ConnectionState.Broken || cnx.State == ConnectionState.Closed)
            {
                cnx.ConnectionString = @"Data Source=DESKTOP-GD3I8L8\SQLEXPRESS;Initial Catalog=gestionEcole;Integrated Security=True";
                cnx.Open();
            }
        }

        public void Deconnecter()
        {
            if(cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }

    }
}
