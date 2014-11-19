namespace UserAdministration
{
    partial class FormEditOrDeleteUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditOrDeleteUser));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_UpdateUser = new System.Windows.Forms.Button();
            this.bnt_DeleteUser = new System.Windows.Forms.Button();
            this.btnEnableUnable = new System.Windows.Forms.Button();
            this.btn_Email = new System.Windows.Forms.Button();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(104, 6);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(204, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Window;
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(104, 36);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(204, 22);
            this.txtLastName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(104, 131);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(257, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(104, 161);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(160, 22);
            this.txtPhone.TabIndex = 4;
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.SystemColors.Window;
            this.cmbGender.Enabled = false;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cmbGender.Location = new System.Drawing.Point(104, 191);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(160, 24);
            this.cmbGender.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(26, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(19, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(42, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(22, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(31, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Género";
            // 
            // btn_UpdateUser
            // 
            this.btn_UpdateUser.Enabled = false;
            this.btn_UpdateUser.Image = global::UserAdministration.Properties.Resources.update;
            this.btn_UpdateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_UpdateUser.Location = new System.Drawing.Point(104, 223);
            this.btn_UpdateUser.Margin = new System.Windows.Forms.Padding(4);
            this.btn_UpdateUser.Name = "btn_UpdateUser";
            this.btn_UpdateUser.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_UpdateUser.Size = new System.Drawing.Size(134, 28);
            this.btn_UpdateUser.TabIndex = 12;
            this.btn_UpdateUser.Text = "Actualizar";
            this.btn_UpdateUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UpdateUser.UseVisualStyleBackColor = true;
            this.btn_UpdateUser.Click += new System.EventHandler(this.btn_UpdateUser_Click);
            // 
            // bnt_DeleteUser
            // 
            this.bnt_DeleteUser.Enabled = false;
            this.bnt_DeleteUser.Image = global::UserAdministration.Properties.Resources.Delete;
            this.bnt_DeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnt_DeleteUser.Location = new System.Drawing.Point(104, 293);
            this.bnt_DeleteUser.Margin = new System.Windows.Forms.Padding(4);
            this.bnt_DeleteUser.Name = "bnt_DeleteUser";
            this.bnt_DeleteUser.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.bnt_DeleteUser.Size = new System.Drawing.Size(134, 28);
            this.bnt_DeleteUser.TabIndex = 13;
            this.bnt_DeleteUser.Text = "Eliminar";
            this.bnt_DeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_DeleteUser.UseVisualStyleBackColor = true;
            this.bnt_DeleteUser.Click += new System.EventHandler(this.bnt_DeleteUser_Click);
            // 
            // btnEnableUnable
            // 
            this.btnEnableUnable.Location = new System.Drawing.Point(320, 17);
            this.btnEnableUnable.Name = "btnEnableUnable";
            this.btnEnableUnable.Size = new System.Drawing.Size(41, 28);
            this.btnEnableUnable.TabIndex = 14;
            this.btnEnableUnable.UseVisualStyleBackColor = true;
            this.btnEnableUnable.Click += new System.EventHandler(this.btnEnableUnable_Click);
            // 
            // btn_Email
            // 
            this.btn_Email.Image = global::UserAdministration.Properties.Resources.user_msg;
            this.btn_Email.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Email.Location = new System.Drawing.Point(104, 258);
            this.btn_Email.Name = "btn_Email";
            this.btn_Email.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_Email.Size = new System.Drawing.Size(134, 28);
            this.btn_Email.TabIndex = 15;
            this.btn_Email.Text = "Enviar correo";
            this.btn_Email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Email.UseVisualStyleBackColor = true;
            this.btn_Email.Click += new System.EventHandler(this.btn_Email_Click);
            // 
            // txtAddr
            // 
            this.txtAddr.Enabled = false;
            this.txtAddr.Location = new System.Drawing.Point(104, 65);
            this.txtAddr.Multiline = true;
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(257, 59);
            this.txtAddr.TabIndex = 16;
            // 
            // FormEditOrDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(378, 332);
            this.Controls.Add(this.txtAddr);
            this.Controls.Add(this.btn_Email);
            this.Controls.Add(this.btnEnableUnable);
            this.Controls.Add(this.bnt_DeleteUser);
            this.Controls.Add(this.btn_UpdateUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(394, 370);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(394, 370);
            this.Name = "FormEditOrDeleteUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar o Eliminar usuario";
            this.Load += new System.EventHandler(this.FormEditOrDeleteUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_UpdateUser;
        private System.Windows.Forms.Button bnt_DeleteUser;
        private System.Windows.Forms.Button btnEnableUnable;
        private System.Windows.Forms.Button btn_Email;
        private System.Windows.Forms.TextBox txtAddr;
    }
}