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
        

        /*Muestra los registros de la tabla en un gridview*/
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
            
            for (int i = 0; i < myDataTable.Rows.Count; i++ )
            {

                myDataTable.Rows[i]["Nombre"] = UpperFirstLetter(myDataTable.Rows[i]["Nombre"].ToString());
                myDataTable.Rows[i]["Apellido"] = UpperFirstLetter(myDataTable.Rows[i]["Apellido"].ToString());
            }

            grid.DataSource = myDataTable;
        }

        /*Convierte la primera letra de un string en mayuscula*/
        private string UpperFirstLetter(string firtLetterUpper)
        {
            if (string.IsNullOrEmpty(firtLetterUpper))
            {
                return string.Empty;
            }
            return char.ToUpper(firtLetterUpper[0]) + firtLetterUpper.Substring(1);
        }
    }
}
