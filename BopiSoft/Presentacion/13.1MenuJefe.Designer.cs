namespace BopiSoft
{
    partial class _13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_13));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.planeaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planeaciónToolStripMenuItem,
            this.evidenciasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // planeaciónToolStripMenuItem
            // 
            this.planeaciónToolStripMenuItem.Name = "planeaciónToolStripMenuItem";
            this.planeaciónToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.planeaciónToolStripMenuItem.Text = "Planeación";
            // 
            // evidenciasToolStripMenuItem
            // 
            this.evidenciasToolStripMenuItem.Name = "evidenciasToolStripMenuItem";
            this.evidenciasToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.evidenciasToolStripMenuItem.Text = "Evidencias";
            // 
            // _13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(109)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "_13";
            this.Text = "Menú Jefe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem planeaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evidenciasToolStripMenuItem;
    }
}