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
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            FormNewUser FNewUser = new FormNewUser();          

            DialogResult result = FNewUser.ShowDialog();
            if (result == DialogResult.OK)
            {
                ShowData();
            }
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        public void ShowData()
        {
            Manager myManager = new Manager();
            myManager.DisplayUserList(dgvUserList);
            dgvUserList.Columns[0].Visible = false; 
        }
        
        private void dgvUserList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var userId = dgvUserList.Rows[e.RowIndex].Cells[0].Value;
                Manager myManager = new Manager((int)userId);

                if (myManager.SelectUserById((int)userId) == DialogResult.OK)
                {
                    ShowData();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("No existen usuarios en los registros", "No existen usuarios",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            gbSearchUser.Text = "Buscando...";
            gbSearchUser.Enabled = false;
            btnFindUser.Text = "Buscando";
            btnFindUser.Size = new System.Drawing.Size(110, 28);            
           
            ShowUserResult(txtUserParam.Text);

            gbSearchUser.Enabled = true;
            btnFindUser.Text = "Buscar";
            btnFindUser.Size = new System.Drawing.Size(100, 28);
            this.gbSearchUser.Text = "Buscar usuarios";
        }

        public void ShowUserResult(string name)
        {
            Manager myManager = new Manager();
            myManager.FindUser(dgvUserList,name);
        }

        private void btnShowAllUsers_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        
        
    }
}
