using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserAdministration
{
    public partial class FormNewUser : Form
    {
        public FormNewUser()
        {
            InitializeComponent();
        }

        private void btn_create_user_Click(object sender, EventArgs e)
        {
            Manager myManager = new Manager();
            try
            {
                myManager.CreateUser(txtName.Text, txtLastName.Text, txtAddr.Text, txtEmail.Text, txtPhone.Text, cmbGender.SelectedItem.ToString());
                this.DialogResult = DialogResult.OK;
            }
            catch(Exception)
            {
                MessageBox.Show("Al parecer existen campos vacíos. \nPor favor, verifique la información", "Houston tenemos un problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
