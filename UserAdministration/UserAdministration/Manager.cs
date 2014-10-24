using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UserAdministration
{
    class Manager
    {
        DataTable myDataTable;
        SqlCommand myCommand;
        SqlDataAdapter mySqlAdapter;
        
        public void DisplayUserList(DataGridView grid)
        {
            myDataTable = new DataTable();
            myCommand = new SqlCommand("SP_ListUsers",MyConnection.GetConnection());
            mySqlAdapter = new SqlDataAdapter(myCommand);

            mySqlAdapter.Fill(myDataTable);
            if(myCommand.Connection.State == ConnectionState.Open)
            {
                myCommand.Connection.Close();
            }
            grid.DataSource = myDataTable;
        }
    }
}
