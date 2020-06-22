using BopiSoft.Datos;
using BopiSoft.Negocios;
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
    public partial class _27MateriaLista : Form
    {
        PuenteMaterias puente = new PuenteMaterias();
<<<<<<< HEAD
        BDConexion bd = new BDConexion();
=======
        DatosGrupos datos = new DatosGrupos();
        BDConexion bd = new BDConexion();
        public int form;
>>>>>>> 6591c39... 5to Commit

        public _27MateriaLista()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        
=======
>>>>>>> 6591c39... 5to Commit

        private void toolStripMenuItem2_Click_2(object sender, EventArgs e)
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

        private void _27MateriaLista_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            puente.LlenarCombo(cmbCarrera);
        }

        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            String carrera;
            carrera = cmbCarrera.SelectedIndex.ToString();
            GRID1.DataSource = bd.SelectDataTable("select * from lista_materias where Carrera="+carrera);
        }
<<<<<<< HEAD

        

        private void GRID1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _25MateriaContenido materiaContenido = new _25MateriaContenido();
            DataGridViewRow llenarClave = GRID1.Rows[e.RowIndex];
            materiaContenido.txtClave.Text = llenarClave.Cells["IdMateria"].Value.ToString();
            materiaContenido.Show();
            this.Hide();
=======
        
        private void GRID1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cambia lo que hace el evento dependiendo del formulario que lo llama
            _25MateriaContenido materiaContenido = new _25MateriaContenido();
            _28GruposEditra gruposEditra = new _28GruposEditra();
            
            if (form==1)
            {
                DataGridViewRow llenarClave = GRID1.Rows[e.RowIndex];
                materiaContenido.txtClave.Text = llenarClave.Cells["IdMateria"].Value.ToString();
                materiaContenido.Show();
                this.Hide();
            }
            
            else if (form==2)
            {
                DataGridViewRow llenarNombreMateria = GRID1.Rows[e.RowIndex];
                String nombreMateria = llenarNombreMateria.Cells["Nombre"].Value.ToString();
                datos.NombreMateria = nombreMateria;
                MessageBox.Show(datos.NombreMateria);
                gruposEditra.actualizarNombreMateria(datos.NombreMateria);
                gruposEditra.Show();
                this.Hide();
            }


>>>>>>> 6591c39... 5to Commit
        }
    }
}
