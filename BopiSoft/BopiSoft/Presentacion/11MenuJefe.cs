using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
using MySql.Data.MySqlClient;

using System.Configuration;
using System.Data.SqlClient;
using BopiSoft.Datos;
using BopiSoft.Negocios;
using BopiSoft.Presentacion;
using System.Drawing.Imaging;
using System.IO;
<<<<<<< HEAD
>>>>>>> 01c80df... 6to Commit: Login creado
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos

namespace BopiSoft
{
    public partial class MenuJefe : Form
    {
<<<<<<< HEAD
<<<<<<< HEAD
        public MenuJefe()
        {
            InitializeComponent();
=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
        string nombreJefe;
        string paternoJefe;
        string maternoJefe;
        string areaJefe;
        byte[] fotoJefe;

        public MenuJefe(string nombreJefe, string paternoJefe, string maternoJefe, string areaJefe, byte[] fotoJefe)
        {
            InitializeComponent();
            this.nombreJefe = nombreJefe;
            this.paternoJefe = paternoJefe;
            this.maternoJefe = maternoJefe;
            this.areaJefe = areaJefe;
            this.fotoJefe = fotoJefe;
<<<<<<< HEAD
>>>>>>> 01c80df... 6to Commit: Login creado
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
        }

        private void MenuJefe_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD

=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            pbJefe.Image = byteArrayToImage(this.fotoJefe);
            lbNombreJefe.Text = nombreJefe + " " + paternoJefe + " " + maternoJefe;
            lbAreaJefe.Text = areaJefe;
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out?", "Warning",
          MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Form1 Login = new Form1();
                Login.Show();
            }
            else
            {


            }
<<<<<<< HEAD
>>>>>>> 01c80df... 6to Commit: Login creado
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
        }
    }
}
