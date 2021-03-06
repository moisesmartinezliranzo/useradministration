﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;

namespace UserAdministration
{
    class Manager
    {
        DataTable myDataTable;
        SqlCommand myCommand;
        SqlDataAdapter mySqlAdapter;
        SqlDataReader myDataReader = null;
        private int userId;

        MailMessage myMailMessage;
        SmtpClient mySmtpClient;

        public Manager()
        { 
        }

        public Manager(int id)
        {
            this.userId = id;
        }

        /*Busca los usuarios*/

        public void FindUser(DataGridView grid, string name)
        {
            myDataTable = new DataTable();
            myCommand = new SqlCommand("SP_SearchUser", MyConnection.GetConnection());
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.Add("@name",SqlDbType.VarChar).Value = name;
            mySqlAdapter = new SqlDataAdapter(myCommand);

            mySqlAdapter.Fill(myDataTable);
            if (myCommand.Connection.State == ConnectionState.Open)
            {
                myCommand.Connection.Close();
            }

            if (myDataTable.Rows.Count == 0)
            {
                MessageBox.Show("Lo sentimos el usuario no ha sido encontrado","Usuario no encontrado",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < myDataTable.Rows.Count; i++)
                {
                    myDataTable.Rows[i]["Nombre"] = UpperFirstLetter(myDataTable.Rows[i]["Nombre"].ToString());
                    myDataTable.Rows[i]["Apellido"] = UpperFirstLetter(myDataTable.Rows[i]["Apellido"].ToString());
                }

                grid.DataSource = myDataTable;
            }            
        }
        
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

                MessageBox.Show("El Usuario: " + UpperFirstLetter(name) + " " + UpperFirstLetter(last_name) + " ha sido creado satisfactoriamente", "Nuevo usuario creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /*Seleccionar usuario por id*/
        public DialogResult SelectUserById(int id)
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
                    name = UpperFirstLetter(myDataReader["Nombre"].ToString());
                    last_name = UpperFirstLetter(myDataReader["Apellido"].ToString());
                    addr = myDataReader["Dirección"].ToString();
                    email = myDataReader["Email"].ToString();
                    phone = myDataReader["Teléfono"].ToString();
                    gender = myDataReader["Género"].ToString();                  
                }

                UserClass user = new UserClass(name,last_name,addr,email,phone,gender,id);
                FormEditOrDeleteUser myFormEditOrDeleteUser = new FormEditOrDeleteUser(user);

               DialogResult result = myFormEditOrDeleteUser.ShowDialog();
               return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return DialogResult.Cancel;
            }
        }

        /*Actualizar informacion de usuario*/
        public void UpdateUser(string name, string last_name,string addr,string email,string phone,string gender,int id)
        {
            try
            {
                myCommand = new SqlCommand("SP_UpdateUser", MyConnection.GetConnection());
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add("@name",SqlDbType.VarChar).Value = name;
                myCommand.Parameters.Add("@last_name",SqlDbType.VarChar).Value = last_name;
                myCommand.Parameters.Add("@addr",SqlDbType.VarChar).Value = addr;
                myCommand.Parameters.Add("@email",SqlDbType.VarChar).Value = email;
                myCommand.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
                myCommand.Parameters.Add("@gender",SqlDbType.VarChar).Value = gender;
                myCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
                myCommand.ExecuteNonQuery(); 
           
                if(myCommand.Connection.State == ConnectionState.Open)
                {
                    myCommand.Connection.Close();
                }

                MessageBox.Show("La información del usuario ha sido actualizado satisfactoriamente","Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /*Eliminar usuario*/
        public void DeleteUser(int id)
        {
            try
            {
                myCommand = new SqlCommand("SP_DeleteUser", MyConnection.GetConnection());
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add("@id",SqlDbType.Int).Value = id;

                myCommand.ExecuteNonQuery();

                if(myCommand.Connection.State == ConnectionState.Open)
                {
                    myCommand.Connection.Close();
                }
                MessageBox.Show("El usuario ha sido eliminado satisfactoriamente","Eliminado",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        /*Evalua si el email es valido*/
        public bool IsValidEmail(string email)
        {
            Regex myRegularExpression = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

            if (myRegularExpression.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*Enviar email*/

        public void SendMailTo(string email, string subject, string msg)
        {
            string template = "<div style=\"background-color:#999; padding: 20px 0px; height:100%;\" > <div style=\"width:600px; margin:0 auto 0 auto; background-color:#fff;\"> <div style=\"padding:10px; font-size:16px;\"> {0} </div> </div> </div>";
            template = string.Format(template,msg);
            mySmtpClient = new SmtpClient("smtp.gmail.com");
            
            myMailMessage = new MailMessage();

            myMailMessage.From = new MailAddress("moisesmmltest@gmail.com","Moises");
            myMailMessage.To.Add(email);
            myMailMessage.Subject = subject;
            myMailMessage.Body = template;
            myMailMessage.IsBodyHtml = true;

            mySmtpClient.Port = 587;
            mySmtpClient.EnableSsl = true;
            mySmtpClient.Credentials = new System.Net.NetworkCredential("moisesmmltest@gmail.com","pwdprueba");

            mySmtpClient.Send(myMailMessage);
        }

        
    }
}
