namespace BopiSoft
{
    partial class CalificacionesSemestral
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
<<<<<<< HEAD
<<<<<<< HEAD
            this.SuspendLayout();
            // 
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalificacionesSemestral));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAlumnosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calificacionesSemestralesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planeacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.txtNombreGrupo = new System.Windows.Forms.TextBox();
            this.txtIDGrupo = new System.Windows.Forms.TextBox();
            this.GRID1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAlumnosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 24);
            this.menuStrip1.TabIndex = 156;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarAlumnosToolStripMenuItem
            // 
            this.registrarAlumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAlumnosToolStripMenuItem1,
            this.calificacionesToolStripMenuItem,
            this.calificacionesSemestralesToolStripMenuItem,
            this.evidenciasToolStripMenuItem,
            this.planeacionToolStripMenuItem});
            this.registrarAlumnosToolStripMenuItem.Name = "registrarAlumnosToolStripMenuItem";
            this.registrarAlumnosToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.registrarAlumnosToolStripMenuItem.Text = "Grupo";
            // 
            // registrarAlumnosToolStripMenuItem1
            // 
            this.registrarAlumnosToolStripMenuItem1.Name = "registrarAlumnosToolStripMenuItem1";
            this.registrarAlumnosToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.registrarAlumnosToolStripMenuItem1.Text = "Registrar Alumnos";
            this.registrarAlumnosToolStripMenuItem1.Click += new System.EventHandler(this.registrarAlumnosToolStripMenuItem1_Click);
            // 
            // calificacionesToolStripMenuItem
            // 
            this.calificacionesToolStripMenuItem.Name = "calificacionesToolStripMenuItem";
            this.calificacionesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.calificacionesToolStripMenuItem.Text = "Calificaciones parciales";
            this.calificacionesToolStripMenuItem.Click += new System.EventHandler(this.calificacionesToolStripMenuItem_Click);
            // 
            // calificacionesSemestralesToolStripMenuItem
            // 
            this.calificacionesSemestralesToolStripMenuItem.Name = "calificacionesSemestralesToolStripMenuItem";
            this.calificacionesSemestralesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.calificacionesSemestralesToolStripMenuItem.Text = "Calificaciones semestrales";
            this.calificacionesSemestralesToolStripMenuItem.Click += new System.EventHandler(this.calificacionesSemestralesToolStripMenuItem_Click);
            // 
            // evidenciasToolStripMenuItem
            // 
            this.evidenciasToolStripMenuItem.Name = "evidenciasToolStripMenuItem";
            this.evidenciasToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.evidenciasToolStripMenuItem.Text = "Evidencias";
            this.evidenciasToolStripMenuItem.Click += new System.EventHandler(this.evidenciasToolStripMenuItem_Click);
            // 
            // planeacionToolStripMenuItem
            // 
            this.planeacionToolStripMenuItem.Name = "planeacionToolStripMenuItem";
            this.planeacionToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.planeacionToolStripMenuItem.Text = "Planeacion";
            this.planeacionToolStripMenuItem.Click += new System.EventHandler(this.planeacionToolStripMenuItem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ebrima", 12F);
            this.label9.Location = new System.Drawing.Point(465, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 21);
            this.label9.TabIndex = 162;
            this.label9.Text = "Nombre Materia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 12F);
            this.label7.Location = new System.Drawing.Point(465, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 21);
            this.label7.TabIndex = 161;
            this.label7.Text = "Nombre Grupo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12F);
            this.label3.Location = new System.Drawing.Point(465, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 160;
            this.label3.Text = "ID Grupo";
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(186)))), ((int)(((byte)(223)))));
            this.txtNombreMateria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreMateria.Enabled = false;
            this.txtNombreMateria.Location = new System.Drawing.Point(596, 103);
            this.txtNombreMateria.Multiline = true;
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(105, 26);
            this.txtNombreMateria.TabIndex = 159;
            // 
            // txtNombreGrupo
            // 
            this.txtNombreGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(186)))), ((int)(((byte)(223)))));
            this.txtNombreGrupo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreGrupo.Enabled = false;
            this.txtNombreGrupo.Location = new System.Drawing.Point(596, 71);
            this.txtNombreGrupo.Multiline = true;
            this.txtNombreGrupo.Name = "txtNombreGrupo";
            this.txtNombreGrupo.Size = new System.Drawing.Size(105, 26);
            this.txtNombreGrupo.TabIndex = 158;
            // 
            // txtIDGrupo
            // 
            this.txtIDGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(186)))), ((int)(((byte)(223)))));
            this.txtIDGrupo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDGrupo.Enabled = false;
            this.txtIDGrupo.Location = new System.Drawing.Point(596, 39);
            this.txtIDGrupo.Multiline = true;
            this.txtIDGrupo.Name = "txtIDGrupo";
            this.txtIDGrupo.Size = new System.Drawing.Size(105, 26);
            this.txtIDGrupo.TabIndex = 157;
            // 
            // GRID1
            // 
            this.GRID1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.GRID1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID1.Location = new System.Drawing.Point(12, 181);
            this.GRID1.Name = "GRID1";
            this.GRID1.Size = new System.Drawing.Size(949, 215);
            this.GRID1.TabIndex = 164;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(216)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(29, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 171;
            this.label1.Text = "Promedio final";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnVolver.FlatAppearance.BorderSize = 3;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(913, 27);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(48, 49);
            this.btnVolver.TabIndex = 172;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
            this.SuspendLayout();
            // 
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
            // CalificacionesSemestral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "CalificacionesSemestral";
            this.Text = "Calificaciones semestral";
            this.ResumeLayout(false);
<<<<<<< HEAD
=======
            this.ClientSize = new System.Drawing.Size(973, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GRID1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreMateria);
            this.Controls.Add(this.txtNombreGrupo);
            this.Controls.Add(this.txtIDGrupo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CalificacionesSemestral";
            this.Text = "Calificaciones semestral";
            this.Load += new System.EventHandler(this.CalificacionesSemestral_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones

        }

        #endregion
<<<<<<< HEAD
<<<<<<< HEAD
=======

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAlumnosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem calificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calificacionesSemestralesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evidenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planeacionToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.TextBox txtNombreGrupo;
        private System.Windows.Forms.TextBox txtIDGrupo;
        private System.Windows.Forms.DataGridView GRID1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
    }
}