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
            txtTo.Text = email;
        }

        private void btn_SendMail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSubject.Text) || string.IsNullOrEmpty(rtxtMessage.Text))
            {
                MessageBox.Show("Al parecer existen campos vacíos. \nPor favor, verifique la información", "Información incoherente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Manager myManager = new Manager();
                string body = rtxtMessage.Text.Replace("\n", "<br />");
                this.timer1.Start();
                this.Text = "Enviando mensaje...";
                btn_SendMail.Size = new System.Drawing.Size(120, 28);
                btn_SendMail.Text = "Enviando...";

                btn_SendMail.Enabled = false;
                this.timer1.Start();
                
                myManager.SendMailTo(email, txtSubject.Text, body);
                                
                btn_SendMail.Enabled = true;
                btn_SendMail.Size = new System.Drawing.Size(98, 28);
                btn_SendMail.Text = "Enviar";
                

                MessageBox.Show("Mensaje enviado.", "Enviando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                
            }
            
        }

             

    }
}
