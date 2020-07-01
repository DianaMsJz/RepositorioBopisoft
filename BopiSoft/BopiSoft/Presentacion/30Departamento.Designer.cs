namespace BopiSoft
{
    partial class _30Departamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_30Departamento));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnBuscarClave = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbClave = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModi = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.GRID1 = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.registroCarreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.registroMateriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contenidoMateriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaMateriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.registroGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.registroDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
<<<<<<< HEAD
=======
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
>>>>>>> 031b574... Proyecto completo (Versión Final)
            ((System.ComponentModel.ISupportInitialize)(this.GRID1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Location = new System.Drawing.Point(345, 43);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(335, 26);
            this.txtNombre.TabIndex = 115;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Location = new System.Drawing.Point(99, 43);
            this.txtClave.Multiline = true;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(95, 26);
            this.txtClave.TabIndex = 114;
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            // 
            // btnBuscarClave
            // 
            this.btnBuscarClave.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarClave.Image")));
            this.btnBuscarClave.Location = new System.Drawing.Point(200, 38);
            this.btnBuscarClave.Name = "btnBuscarClave";
            this.btnBuscarClave.Size = new System.Drawing.Size(36, 34);
            this.btnBuscarClave.TabIndex = 113;
            this.btnBuscarClave.UseVisualStyleBackColor = true;
            this.btnBuscarClave.Click += new System.EventHandler(this.btnBuscarClave_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(216)))), ((int)(((byte)(244)))));
            this.lbNombre.Location = new System.Drawing.Point(272, 49);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(67, 20);
            this.lbNombre.TabIndex = 112;
            this.lbNombre.Text = "Nombre";
            // 
            // lbClave
            // 
            this.lbClave.AutoSize = true;
            this.lbClave.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(216)))), ((int)(((byte)(244)))));
            this.lbClave.Location = new System.Drawing.Point(32, 52);
            this.lbClave.Name = "lbClave";
            this.lbClave.Size = new System.Drawing.Size(46, 20);
            this.lbClave.TabIndex = 111;
            this.lbClave.Text = "Clave";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(181)))), ((int)(((byte)(221)))));
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(669, 398);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 40);
            this.btnEliminar.TabIndex = 158;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModi
            // 
            this.btnModi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(181)))), ((int)(((byte)(221)))));
            this.btnModi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnModi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnModi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModi.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnModi.ForeColor = System.Drawing.Color.Black;
            this.btnModi.Location = new System.Drawing.Point(546, 398);
            this.btnModi.Name = "btnModi";
            this.btnModi.Size = new System.Drawing.Size(117, 40);
            this.btnModi.TabIndex = 157;
            this.btnModi.Text = "Modificar";
            this.btnModi.UseVisualStyleBackColor = false;
            this.btnModi.Click += new System.EventHandler(this.btnModi_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(181)))), ((int)(((byte)(221)))));
            this.btnAñadir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAñadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAñadir.ForeColor = System.Drawing.Color.Black;
            this.btnAñadir.Location = new System.Drawing.Point(414, 398);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(117, 40);
            this.btnAñadir.TabIndex = 156;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // GRID1
            // 
            this.GRID1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.GRID1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.GRID1.Location = new System.Drawing.Point(200, 135);
            this.GRID1.Name = "GRID1";
            this.GRID1.Size = new System.Drawing.Size(331, 150);
=======
            this.GRID1.Location = new System.Drawing.Point(176, 135);
            this.GRID1.Name = "GRID1";
            this.GRID1.Size = new System.Drawing.Size(410, 150);
>>>>>>> 01c80df... 6to Commit: Login creado
=======
            this.GRID1.Location = new System.Drawing.Point(176, 135);
            this.GRID1.Name = "GRID1";
            this.GRID1.Size = new System.Drawing.Size(410, 150);
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
            this.GRID1.Location = new System.Drawing.Point(176, 135);
            this.GRID1.Name = "GRID1";
            this.GRID1.Size = new System.Drawing.Size(410, 150);
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
            this.GRID1.Location = new System.Drawing.Point(176, 135);
            this.GRID1.Name = "GRID1";
            this.GRID1.Size = new System.Drawing.Size(410, 150);
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
            this.GRID1.Location = new System.Drawing.Point(176, 135);
            this.GRID1.Name = "GRID1";
            this.GRID1.Size = new System.Drawing.Size(410, 150);
>>>>>>> 031b574... Proyecto completo (Versión Final)
            this.GRID1.TabIndex = 159;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
<<<<<<< HEAD
            this.toolStripMenuItem1});
=======
            this.toolStripMenuItem1,
            this.cerrarSesiónToolStripMenuItem});
>>>>>>> 031b574... Proyecto completo (Versión Final)
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 160;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripSeparator2,
            this.registroCarreraToolStripMenuItem,
            this.toolStripSeparator3,
            this.registroMateriaToolStripMenuItem,
            this.contenidoMateriaToolStripMenuItem,
            this.listaMateriaToolStripMenuItem,
            this.toolStripSeparator4,
            this.registroGrupoToolStripMenuItem,
            this.listaGrupoToolStripMenuItem,
            this.toolStripSeparator5,
            this.registroDepartamentoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItem1.Text = "Registro";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuItem2.Text = "Registro Personal";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click_2);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuItem3.Text = "Lista Docente";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuItem4.Text = "Lista Jefe";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(193, 6);
            // 
            // registroCarreraToolStripMenuItem
            // 
            this.registroCarreraToolStripMenuItem.Name = "registroCarreraToolStripMenuItem";
            this.registroCarreraToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.registroCarreraToolStripMenuItem.Text = "Registro Carrera";
            this.registroCarreraToolStripMenuItem.Click += new System.EventHandler(this.registroCarreraToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(193, 6);
            // 
            // registroMateriaToolStripMenuItem
            // 
            this.registroMateriaToolStripMenuItem.Name = "registroMateriaToolStripMenuItem";
            this.registroMateriaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.registroMateriaToolStripMenuItem.Text = "Registro Materia";
            this.registroMateriaToolStripMenuItem.Click += new System.EventHandler(this.registroMateriaToolStripMenuItem_Click_1);
            // 
            // contenidoMateriaToolStripMenuItem
            // 
            this.contenidoMateriaToolStripMenuItem.Name = "contenidoMateriaToolStripMenuItem";
            this.contenidoMateriaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.contenidoMateriaToolStripMenuItem.Text = "Contenido Materia";
            this.contenidoMateriaToolStripMenuItem.Click += new System.EventHandler(this.contenidoMateriaToolStripMenuItem_Click_1);
            // 
            // listaMateriaToolStripMenuItem
            // 
            this.listaMateriaToolStripMenuItem.Name = "listaMateriaToolStripMenuItem";
            this.listaMateriaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.listaMateriaToolStripMenuItem.Text = "Lista Materia";
            this.listaMateriaToolStripMenuItem.Click += new System.EventHandler(this.listaMateriaToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(193, 6);
            // 
            // registroGrupoToolStripMenuItem
            // 
            this.registroGrupoToolStripMenuItem.Name = "registroGrupoToolStripMenuItem";
            this.registroGrupoToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.registroGrupoToolStripMenuItem.Text = "Registro Grupo";
            this.registroGrupoToolStripMenuItem.Click += new System.EventHandler(this.registroGrupoToolStripMenuItem_Click_1);
            // 
            // listaGrupoToolStripMenuItem
            // 
            this.listaGrupoToolStripMenuItem.Name = "listaGrupoToolStripMenuItem";
            this.listaGrupoToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.listaGrupoToolStripMenuItem.Text = "Lista Grupo";
            this.listaGrupoToolStripMenuItem.Click += new System.EventHandler(this.listaGrupoToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(193, 6);
            // 
            // registroDepartamentoToolStripMenuItem
            // 
            this.registroDepartamentoToolStripMenuItem.Name = "registroDepartamentoToolStripMenuItem";
            this.registroDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.registroDepartamentoToolStripMenuItem.Text = "Registro Departamento";
            this.registroDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.registroDepartamentoToolStripMenuItem_Click_2);
            // 
<<<<<<< HEAD
=======
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
>>>>>>> 031b574... Proyecto completo (Versión Final)
            // _30Departamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.GRID1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModi);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.btnBuscarClave);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbClave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_30Departamento";
            this.Text = "Departamento";
            this.Load += new System.EventHandler(this._30Departamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRID1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnBuscarClave;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbClave;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModi;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.DataGridView GRID1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem registroCarreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem registroMateriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contenidoMateriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaMateriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem registroGrupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaGrupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem registroDepartamentoToolStripMenuItem;
<<<<<<< HEAD
=======
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
>>>>>>> 031b574... Proyecto completo (Versión Final)
    }
}