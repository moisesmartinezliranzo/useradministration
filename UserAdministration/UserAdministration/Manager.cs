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
        SqlDataReader myDataReader = null;
        
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

        /*Crear un nuevo usuario*/
        public void CreateUser(string name, string last_name, string addr, string email, string phone, string gender)
        {
            try
            {
                myCommand = new SqlCommand("SP_CreateUser", MyConnection.GetConnection());
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                myCommand.Parameters.Add("@last_name", SqlDbType.VarChar).Value = last_name;
                myCommand.Parameters.Add("@addr", SqlDbType.VarChar).Value = addr;
                myCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                myCommand.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
                myCommand.Parameters.Add("@gender", SqlDbType.Char).Value = gender;       

                myCommand.ExecuteNonQuery();

                if (myCommand.Connection.State == ConnectionState.Open)
                {
                    myCommand.Connection.Close();
                }

                MessageBox.Show("El Usuario: " + name +" "+ last_name + " ha sido creado satisfactoriamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /*Seleccionar usuario por id*/
        public void SelectUserById(int id)
        {
            string name=null,  last_name =null,   addr = null,  email = null,  phone = null,  gender=null;
            try
            {
                myCommand = new SqlCommand("SP_ListUsersById", MyConnection.GetConnection());
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add("@id",SqlDbType.Int).Value = id;
                
                myDataReader = myCommand.ExecuteReader();

                while (myDataReader.Read())
                {
                    name = myDataReader["Nombre"].ToString();
                    last_name = myDataReader["Apellido"].ToString();
                    addr = myDataReader["Dirección"].ToString();
                    email = myDataReader["Email"].ToString();
                    phone = myDataReader["Teléfono"].ToString();
                    gender = myDataReader["Género"].ToString();
                }

                UserClass user = new UserClass(name,last_name,addr,email,phone,gender);
                FormEditOrDeleteUser myFormEditOrDeleteUser = new FormEditOrDeleteUser(user);
                myFormEditOrDeleteUser.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /*Actualizar informacion de usuario*/
        public void UpdateUser()
        {
 
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
