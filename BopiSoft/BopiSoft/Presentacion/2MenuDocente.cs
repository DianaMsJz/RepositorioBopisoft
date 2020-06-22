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
=======
using MySql.Data.MySqlClient;

using System.Configuration;
using System.Data.SqlClient;
using BopiSoft.Datos;
using BopiSoft.Negocios;
using BopiSoft.Presentacion;




using System.IO;

>>>>>>> 01c80df... 6to Commit: Login creado

namespace BopiSoft
{
    public partial class MenuDocente : Form
    {
<<<<<<< HEAD
        public MenuDocente()
        {
            InitializeComponent();
        }

       
=======
        string nombredoc;
        string paternodoc;
        string maternodoc;
        string areadoc;
        byte[] fotodoc;

        public MenuDocente(string nombredoc, string paternodoc, string maternodoc, string areadoc, byte[] fotodoc)
        {
            InitializeComponent();
            this.nombredoc = nombredoc;
            this.paternodoc = paternodoc;
            this.maternodoc = maternodoc;
            this.areadoc = areadoc;
            this.fotodoc = fotodoc;
        }

        BDConexion bd = new BDConexion();
        PuentePersonal PuentePersonal = new PuentePersonal();
        DatosPersonal datos = new DatosPersonal();
        RegistroPersonalSql registroPersonal = new RegistroPersonalSql();


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
        }

        private void MenuDocente_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            pbFotoDoc.Image = byteArrayToImage(this.fotodoc);
            lbNombre.Text = nombredoc + " " + paternodoc + " " + maternodoc;
            lbArea.Text = areadoc;
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

>>>>>>> 01c80df... 6to Commit: Login creado
    }
}
