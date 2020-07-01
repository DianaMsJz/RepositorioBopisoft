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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
using MySql.Data.MySqlClient;

using System.Configuration;
using System.Data.SqlClient;
using BopiSoft.Datos;
using BopiSoft.Negocios;
using BopiSoft.Presentacion;
using System.Drawing.Imaging;
using System.IO;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 01c80df... 6to Commit: Login creado
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)

namespace BopiSoft
{
    public partial class MenuJefe : Form
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        public MenuJefe()
        {
            InitializeComponent();
=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
        BDConexion bd = new BDConexion();
        DatosPersonal datos = new DatosPersonal();
        PuentePersonal puente = new PuentePersonal();
>>>>>>> 031b574... Proyecto completo (Versión Final)
        string nombreJefe;
        string paternoJefe;
        string maternoJefe;
        string areaJefe;
<<<<<<< HEAD
        byte[] fotoJefe;

        public MenuJefe(string nombreJefe, string paternoJefe, string maternoJefe, string areaJefe, byte[] fotoJefe)
=======
        int IdJefe;
        byte[] fotoJefe;

        public MenuJefe(int idJefe,string nombreJefe, string paternoJefe, string maternoJefe, string areaJefe, byte[] FotoJefe)
>>>>>>> 031b574... Proyecto completo (Versión Final)
        {
            InitializeComponent();
            this.nombreJefe = nombreJefe;
            this.paternoJefe = paternoJefe;
            this.maternoJefe = maternoJefe;
            this.areaJefe = areaJefe;
<<<<<<< HEAD
            this.fotoJefe = fotoJefe;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 01c80df... 6to Commit: Login creado
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
            this.fotoJefe = FotoJefe;
            this.IdJefe = idJefe;
>>>>>>> 031b574... Proyecto completo (Versión Final)
        }

        private void MenuJefe_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

=======
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            datos.IdPersonal = IdJefe;
            puente.RegistroBuscar(datos);
            string tipo = "Docente";

            dataGridView1.DataSource = bd.SelectDataTable("select IdPersonal,Nombre,Apaterno,Amaterno,NombreDpto from lista_personal where Tipo='" + tipo + "' and NombreDpto='"+datos.NombreDpto+"'");
>>>>>>> 031b574... Proyecto completo (Versión Final)
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 01c80df... 6to Commit: Login creado
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow llenarIDGrupo = dataGridView1.Rows[e.RowIndex];
            int IdDoc = Convert.ToInt32(llenarIDGrupo.Cells["IdPersonal"].Value);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM lista_personal WHERE IdPersonal='" + IdDoc + "' ", bd.connect);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                datos.IdPersonal = IdDoc;
                puente.RegistroBuscar(datos);
                string NombreDoc = datos.Nombre;
                string MaternoDoc = datos.Amaterno;
                String PaternoDoc = datos.Apaterno;
                string Area = datos.NombreDpto;
                byte[] Foto = datos.Foto;

                this.Hide();
                MenuDocenteJefe MenuDocente = new MenuDocenteJefe(IdDoc.ToString(),IdJefe, NombreDoc, PaternoDoc, MaternoDoc, Area, Foto);
                MenuDocente.Show();
            }
>>>>>>> 031b574... Proyecto completo (Versión Final)
        }
    }
}
