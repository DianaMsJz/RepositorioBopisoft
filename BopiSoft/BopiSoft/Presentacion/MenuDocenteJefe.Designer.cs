namespace BopiSoft.Presentacion
{
    partial class MenuDocenteJefe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuDocenteJefe));
            this.tablaGruposDOC = new System.Windows.Forms.DataGridView();
            this.pbFotoDoc = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbArea = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaGruposDOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaGruposDOC
            // 
            this.tablaGruposDOC.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablaGruposDOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaGruposDOC.Location = new System.Drawing.Point(13, 212);
            this.tablaGruposDOC.Name = "tablaGruposDOC";
            this.tablaGruposDOC.Size = new System.Drawing.Size(784, 231);
            this.tablaGruposDOC.TabIndex = 37;
            this.tablaGruposDOC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaGruposDOC_CellClick_1);
            this.tablaGruposDOC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaGruposDOC_CellContentClick_1);
            // 
            // pbFotoDoc
            // 
            this.pbFotoDoc.Location = new System.Drawing.Point(3, 7);
            this.pbFotoDoc.Name = "pbFotoDoc";
            this.pbFotoDoc.Size = new System.Drawing.Size(140, 131);
            this.pbFotoDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoDoc.TabIndex = 36;
            this.pbFotoDoc.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(271, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 32);
            this.label3.TabIndex = 35;
            this.label3.Text = "GRUPOS ASIGNADOS";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 10);
            this.label1.TabIndex = 34;
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
            this.btnVolver.Location = new System.Drawing.Point(691, 22);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(71, 69);
            this.btnVolver.TabIndex = 33;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Ebrima", 18F);
            this.lbNombre.ForeColor = System.Drawing.Color.White;
            this.lbNombre.Location = new System.Drawing.Point(149, 22);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(99, 32);
            this.lbNombre.TabIndex = 38;
            this.lbNombre.Text = "nombre";
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Font = new System.Drawing.Font("Ebrima", 14F);
            this.lbArea.ForeColor = System.Drawing.Color.White;
            this.lbArea.Location = new System.Drawing.Point(150, 66);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(212, 25);
            this.lbArea.TabIndex = 39;
            this.lbArea.Text = "Área a la que pertenece";
            // 
            // MenuDocenteJefe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(109)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(821, 476);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.tablaGruposDOC);
            this.Controls.Add(this.pbFotoDoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Name = "MenuDocenteJefe";
            this.Text = "Docentes";
            this.Load += new System.EventHandler(this._2MenuDocente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaGruposDOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaGruposDOC;
        private System.Windows.Forms.PictureBox pbFotoDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbArea;
    }
}