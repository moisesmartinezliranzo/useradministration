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
    public partial class FormEditOrDeleteUser : Form
    {
        public UserClass user;       

        public FormEditOrDeleteUser(UserClass user) {
            InitializeComponent();
            this.user = user; 
        }
     
        private void FormEditOrDeleteUser_Load(object sender, EventArgs e)
        { 
            
            txtName.Text = user.Name;
            txtLastName.Text = user.LastName;
            txtAddr.Text = user.Addr;
            txtEmail.Text = user.Email;
            txtPhone.Text = user.Phone;
            cmbGender.Text = user.Gender;
            string a = "a";

            btnEnableUnable.Image = global::UserAdministration.Properties.Resources.lock1;
        }

        private void btn_UpdateUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtAddr.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(cmbGender.Text))
            {
                MessageBox.Show("Al parecer existen campos vacíos. \nPor favor, verifique la información", "Información incoherente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Manager myManager = new Manager();
                myManager.UpdateUser(txtName.Text, txtLastName.Text, txtAddr.Text, txtEmail.Text, txtPhone.Text, cmbGender.Text, user.Id);
                this.DialogResult = DialogResult.OK;               
            }
        }

        private void bnt_DeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de eliminar este usuario?\nUna ves eliminado no podrá recuperarlo", "¿Desea eliminar el usuario?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                Manager mymanager = new Manager();
                mymanager.DeleteUser(user.Id);
                this.DialogResult = DialogResult.OK;
            }            
        }

        private void btnEnableUnable_Click(object sender, EventArgs e)
        {
            txtName.Enabled = (!txtName.Enabled == true);
            txtLastName.Enabled = (!txtLastName.Enabled == true);
            txtAddr.Enabled = (!txtAddr.Enabled == true);
            txtEmail.Enabled = (!txtEmail.Enabled == true);
            txtPhone.Enabled = (!txtPhone.Enabled == true);
            cmbGender.Enabled = (!cmbGender.Enabled == true);
            btn_UpdateUser.Enabled = (!btn_UpdateUser.Enabled == true);
            bnt_DeleteUser.Enabled = (!bnt_DeleteUser.Enabled == true);            

            btnEnableUnable.Image = txtName.Enabled == true ? global::UserAdministration.Properties.Resources._lock : global::UserAdministration.Properties.Resources.lock1;           
        }

        private void btn_Email_Click(object sender, EventArgs e)
        {
            FSendEmail FsendMail = new FSendEmail(txtEmail.Text);
            DialogResult myDialog = FsendMail.ShowDialog();    
        }            
    }
}
