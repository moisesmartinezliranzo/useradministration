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
    public partial class FSendEmail : Form
    {
        public string email;
        public FSendEmail()
        {
            InitializeComponent();
        }
        public FSendEmail(String email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void FSendEmail_Load(object sender, EventArgs e)
        {
            txtFrom.Text = email;
        }

        private void btn_SendMail_Click(object sender, EventArgs e)
        {
            Manager myManager = new Manager();
            myManager.SendMailTo(email);
        }
    }
}
