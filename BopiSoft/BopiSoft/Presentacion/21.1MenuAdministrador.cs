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
=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
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
>>>>>>> 01c80df... 6to Commit: Login creado
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones

namespace BopiSoft
{
    public partial class _21 : Form
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        public _21()
        {
            InitializeComponent();
=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones

        string nombreAdmin;
        string paternoAdmin;
        string maternoAdmin;
        string areaAdmin;
        byte[] fotoAdmin;
        public _21(string nombreAdmin, string paternoAdmin, string maternoAdmin, string areaAdmin, byte[] fotoAdmin)
        {
            InitializeComponent();
            this.nombreAdmin = nombreAdmin;
            this.paternoAdmin = paternoAdmin;
            this.maternoAdmin = maternoAdmin;
            this.areaAdmin = areaAdmin;
            this.fotoAdmin = fotoAdmin;
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
        }

        private void listaDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            _22RegistroListDoc RegistroListaDocente = new _22RegistroListDoc();

            RegistroListaDocente.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _21RegistroEditar RegistroListaPersonal = new _21RegistroEditar();

            RegistroListaPersonal.Show();
        }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    }
    }
=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones

        private void carreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _24Carrera Carrera = new _24Carrera();
            Carrera.Show();

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
            else { 
            
            
            }
                
        }

        private void _21_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            pbAdmin.Image = byteArrayToImage(this.fotoAdmin);
            lbNombreAdmin.Text = nombreAdmin + " " + paternoAdmin + " " + maternoAdmin;
            lbAreaAdmin.Text = areaAdmin;
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _25MateriaEditar MateriaEditar = new _25MateriaEditar();

            MateriaEditar.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            _21RegistroEditar _21Registro = new _21RegistroEditar();
            _21Registro.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            _22RegistroListDoc listadoc = new _22RegistroListDoc();
            listadoc.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            _23RegistroListaJefe _23Registro = new _23RegistroListaJefe();
            _23Registro.Show();
        }

        private void registroCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _24Carrera carrera = new _24Carrera();
            carrera.Show();
        }

        private void registroMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _25MateriaEditar _25Materia = new _25MateriaEditar();
            _25Materia.Show();
        }

        private void contenidoMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _25MateriaContenido contenido = new _25MateriaContenido();
            contenido.Show();
        }

        private void listaMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _27MateriaLista materiaLista = new _27MateriaLista();
            materiaLista.Show();
        }

        private void registroGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _28GruposEditra grupos = new _28GruposEditra();
            grupos.Show();
        }

        private void listaGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _29GruposLista gruposLista = new _29GruposLista();
            gruposLista.Show();
        }

        private void registroDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _30Departamento departamento = new _30Departamento();
            departamento.Show();
        }
    }

}
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

