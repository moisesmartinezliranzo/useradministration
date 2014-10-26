using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UserAdministration
{
    class MyConnection
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = null;

            try
            { 
                connection = new SqlConnection(UserAdministration.Properties.Resources.RConnectionString);
                connection.Open();
                return connection;
            }
            catch(Exception ex)
            {
                return null;
                MessageBox.Show(ex.ToString(), "Exception");                
            }
            
        }
    }
}
