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

        private void dgvUserList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var userId =  dgvUserList.Rows[e.RowIndex].Cells[0].Value;          
            Manager myManager = new Manager();
            myManager.SelectUserById((int)userId);                     
        }        
    }
}
