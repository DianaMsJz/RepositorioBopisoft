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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        BDConexion bd = new BDConexion();
=======
        DatosGrupos datos = new DatosGrupos();
        BDConexion bd = new BDConexion();
        public int form;
>>>>>>> 6591c39... 5to Commit
=======
        DatosGrupos datos = new DatosGrupos();
        BDConexion bd = new BDConexion();
        public int form;
>>>>>>> 01c80df... 6to Commit: Login creado
=======
        DatosGrupos datos = new DatosGrupos();
        BDConexion bd = new BDConexion();
        public int form;
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
        DatosGrupos datos = new DatosGrupos();
        BDConexion bd = new BDConexion();
        public int form;
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
        DatosGrupos datos = new DatosGrupos();
        BDConexion bd = new BDConexion();
        public int form;
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
        DatosGrupos datos = new DatosGrupos();
        BDConexion bd = new BDConexion();
        public int form;
>>>>>>> 031b574... Proyecto completo (Versión Final)

        public _27MateriaLista()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        
=======
>>>>>>> 6591c39... 5to Commit
=======
>>>>>>> 01c80df... 6to Commit: Login creado
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)

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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
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
=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
            GRID1.DataSource = bd.SelectDataTable("select * from lista_materias where Carrera=" + carrera);
        }

        private void GRID1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cambia lo que hace el evento dependiendo del formulario que lo llama
            _25MateriaContenido materiaContenido = new _25MateriaContenido();
            _28GruposEditra gruposEditra = new _28GruposEditra();

            if (form == 1)
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
            {
                DataGridViewRow llenarClave = GRID1.Rows[e.RowIndex];
                materiaContenido.txtClave.Text = llenarClave.Cells["IdMateria"].Value.ToString();
                materiaContenido.Show();
                this.Hide();
            }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            
            else if (form==2)
=======

            else if (form == 2)
>>>>>>> 01c80df... 6to Commit: Login creado
=======

            else if (form == 2)
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======

            else if (form == 2)
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======

            else if (form == 2)
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======

            else if (form == 2)
>>>>>>> 031b574... Proyecto completo (Versión Final)
            {
                DataGridViewRow llenarNombreMateria = GRID1.Rows[e.RowIndex];
                String nombreMateria = llenarNombreMateria.Cells["Nombre"].Value.ToString();
                datos.NombreMateria = nombreMateria;
                MessageBox.Show(datos.NombreMateria);
                gruposEditra.actualizarNombreMateria(datos.NombreMateria);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)

                DataGridViewRow llenarIdMateria = GRID1.Rows[e.RowIndex];
                String IdMateria = llenarIdMateria.Cells["IdMateria"].Value.ToString();
                datos.IdMateria= Convert.ToInt32(IdMateria);
                gruposEditra.actualizarIdMateria(datos.IdMateria);
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
                gruposEditra.Show();
                this.Hide();
            }


<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 6591c39... 5to Commit
        }
=======
        }

       
       
>>>>>>> 01c80df... 6to Commit: Login creado
=======
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
        }

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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD


            }
        }
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
            }
        }
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
            }
        }

        private void GRID1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
            }
        }
>>>>>>> 031b574... Proyecto completo (Versión Final)
    }
}
