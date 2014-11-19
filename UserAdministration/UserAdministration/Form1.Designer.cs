namespace UserAdministration
{
    partial class FormUsers
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
            this.btnNewUser = new System.Windows.Forms.Button();
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.btnFindUser = new System.Windows.Forms.Button();
            this.txtUserParam = new System.Windows.Forms.TextBox();
            this.gbSearchUser = new System.Windows.Forms.GroupBox();
            this.btnShowAllUsers = new System.Windows.Forms.Button();
            this.gbCreateUser = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.gbSearchUser.SuspendLayout();
            this.gbCreateUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewUser
            // 
            this.btnNewUser.Image = global::UserAdministration.Properties.Resources.user_add;
            this.btnNewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewUser.Location = new System.Drawing.Point(7, 20);
            this.btnNewUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnNewUser.Size = new System.Drawing.Size(90, 28);
            this.btnNewUser.TabIndex = 2;
            this.btnNewUser.Text = "Crear";
            this.btnNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // dgvUserList
            // 
            this.dgvUserList.AllowUserToAddRows = false;
            this.dgvUserList.AllowUserToDeleteRows = false;
            this.dgvUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.Location = new System.Drawing.Point(16, 74);
            this.dgvUserList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.ReadOnly = true;
            this.dgvUserList.Size = new System.Drawing.Size(855, 475);
            this.dgvUserList.TabIndex = 1;
            this.dgvUserList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserList_CellDoubleClick);
            // 
            // btnFindUser
            // 
            this.btnFindUser.Image = global::UserAdministration.Properties.Resources.user_search;
            this.btnFindUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindUser.Location = new System.Drawing.Point(213, 20);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnFindUser.Size = new System.Drawing.Size(100, 28);
            this.btnFindUser.TabIndex = 0;
            this.btnFindUser.Text = "Buscar";
            this.btnFindUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindUser.UseVisualStyleBackColor = true;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // txtUserParam
            // 
            this.txtUserParam.Location = new System.Drawing.Point(7, 23);
            this.txtUserParam.MaximumSize = new System.Drawing.Size(220, 25);
            this.txtUserParam.MinimumSize = new System.Drawing.Size(200, 25);
            this.txtUserParam.Name = "txtUserParam";
            this.txtUserParam.Size = new System.Drawing.Size(200, 25);
            this.txtUserParam.TabIndex = 1;
            // 
            // gbSearchUser
            // 
            this.gbSearchUser.Controls.Add(this.btnShowAllUsers);
            this.gbSearchUser.Controls.Add(this.txtUserParam);
            this.gbSearchUser.Controls.Add(this.btnFindUser);
            this.gbSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearchUser.Location = new System.Drawing.Point(16, 12);
            this.gbSearchUser.Name = "gbSearchUser";
            this.gbSearchUser.Size = new System.Drawing.Size(463, 55);
            this.gbSearchUser.TabIndex = 3;
            this.gbSearchUser.TabStop = false;
            this.gbSearchUser.Text = "Buscar usuarios";
            // 
            // btnShowAllUsers
            // 
            this.btnShowAllUsers.Image = global::UserAdministration.Properties.Resources.usergroup;
            this.btnShowAllUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowAllUsers.Location = new System.Drawing.Point(319, 20);
            this.btnShowAllUsers.Name = "btnShowAllUsers";
            this.btnShowAllUsers.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnShowAllUsers.Size = new System.Drawing.Size(135, 28);
            this.btnShowAllUsers.TabIndex = 2;
            this.btnShowAllUsers.Text = "Mostrar todos";
            this.btnShowAllUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAllUsers.UseVisualStyleBackColor = true;
            this.btnShowAllUsers.Click += new System.EventHandler(this.btnShowAllUsers_Click);
            // 
            // gbCreateUser
            // 
            this.gbCreateUser.Controls.Add(this.btnNewUser);
            this.gbCreateUser.Location = new System.Drawing.Point(485, 12);
            this.gbCreateUser.Name = "gbCreateUser";
            this.gbCreateUser.Size = new System.Drawing.Size(160, 55);
            this.gbCreateUser.TabIndex = 4;
            this.gbCreateUser.TabStop = false;
            this.gbCreateUser.Text = "Nuevo usuario";
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.gbCreateUser);
            this.Controls.Add(this.gbSearchUser);
            this.Controls.Add(this.dgvUserList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.Name = "FormUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de usuarios";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.gbSearchUser.ResumeLayout(false);
            this.gbSearchUser.PerformLayout();
            this.gbCreateUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.DataGridView dgvUserList;
        private System.Windows.Forms.Button btnFindUser;
        private System.Windows.Forms.TextBox txtUserParam;
        private System.Windows.Forms.GroupBox gbSearchUser;
        private System.Windows.Forms.GroupBox gbCreateUser;
        private System.Windows.Forms.Button btnShowAllUsers;
    }
}

