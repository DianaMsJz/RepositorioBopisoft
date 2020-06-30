using BopiSoft.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BopiSoft
{
    public partial class _23RegistroListaJefe : Form
    {
        BDConexion bd = new BDConexion();

        public _23RegistroListaJefe()
        {
            InitializeComponent();
        }

        private void _23RegistroListaJefe_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            GRID1.DataSource = bd.SelectDataTable("select * from lista_personal where Tipo='jefe'");
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
            _22RegistroListDoc _22Registro = new _22RegistroListDoc();
            _22Registro.Show();
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
<<<<<<< HEAD
=======

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
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
>>>>>>> 48fe993... Commit 7: Registrar alumnos
    }
}
