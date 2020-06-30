namespace BopiSoft
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Inicio = new System.Windows.Forms.Label();
            this.ImgenUser = new System.Windows.Forms.Label();
            this.NomBopi = new System.Windows.Forms.Label();
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
=======
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
>>>>>>> 01c80df... 6to Commit: Login creado
=======
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Inicio
            // 
            this.Inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.Inicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Inicio.Location = new System.Drawing.Point(187, 31);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(372, 429);
            this.Inicio.TabIndex = 0;
            // 
            // ImgenUser
            // 
            this.ImgenUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.ImgenUser.Image = ((System.Drawing.Image)(resources.GetObject("ImgenUser.Image")));
            this.ImgenUser.Location = new System.Drawing.Point(301, 62);
            this.ImgenUser.Name = "ImgenUser";
            this.ImgenUser.Size = new System.Drawing.Size(146, 136);
            this.ImgenUser.TabIndex = 1;
            // 
            // NomBopi
            // 
            this.NomBopi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.NomBopi.Font = new System.Drawing.Font("bizagi-font", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomBopi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.NomBopi.Location = new System.Drawing.Point(272, 198);
            this.NomBopi.Name = "NomBopi";
            this.NomBopi.Size = new System.Drawing.Size(213, 45);
            this.NomBopi.TabIndex = 2;
            this.NomBopi.Text = "BOPISOFT";
            // 
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(281, 279);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(281, 330);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(191, 20);
            this.txtContra.TabIndex = 4;
=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(281, 279);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(191, 20);
            this.txtID.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(281, 330);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(191, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtContra_TextChanged);
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 01c80df... 6to Commit: Login creado
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("bizagi-font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(320, 382);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(110, 42);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "L O G I N";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 279);
            this.label1.Name = "label1";
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "EMAIL";
=======
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
>>>>>>> 01c80df... 6to Commit: Login creado
=======
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "PASSWORD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(109)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtEmail);
=======
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtID);
>>>>>>> 01c80df... 6to Commit: Login creado
=======
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtID);
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtID);
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
            this.Controls.Add(this.NomBopi);
            this.Controls.Add(this.ImgenUser);
            this.Controls.Add(this.Inicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Inicio;
        private System.Windows.Forms.Label ImgenUser;
        private System.Windows.Forms.Label NomBopi;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContra;
=======
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPassword;
>>>>>>> 01c80df... 6to Commit: Login creado
=======
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPassword;
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPassword;
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

