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
            FNewUser.ShowDialog();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            Manager myManager = new Manager();

            myManager.DisplayUserList(dgvUserList);

            dgvUserList.Columns[0].Visible = false;          
        }
    }
}
