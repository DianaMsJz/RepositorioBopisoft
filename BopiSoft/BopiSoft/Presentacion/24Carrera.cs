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
    public partial class _24Carrera : Form
    {
        DatosCarreras datos = new DatosCarreras();
        PuenteCarrera puente = new PuenteCarrera();
        BDConexion bd = new BDConexion();

        public _24Carrera()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtClave.Text != "" && txtNombre.Text != "")
            {
                try
                {
                    datos.IdCarrera = Int32.Parse(txtClave.Text);
                    datos.Nombre = txtNombre.Text;

                    puente.RegistroAñadir(datos);
                    Limpiar();
                    actualizarGrid();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

            }
            else
            {
                MessageBox.Show("ERROR LLENE TODOS LOS CAMPOS");
            }
        }

        public void Limpiar()
        {
            txtClave.Text = "";
            txtNombre.Text = "";
        }

        public void actualizarGrid()
        {
            GRID1.DataSource = bd.SelectDataTable("select * from lista_carreras");
        }

        private void btnModi_Click(object sender, EventArgs e)
        {

            if (txtClave.Text != "" && txtNombre.Text != "")
            {
                try
                {
                    datos.IdCarrera = Int32.Parse(txtClave.Text);
                    datos.Nombre = txtNombre.Text;


                    puente.RegistroModificar(datos);
                    Limpiar();
                    actualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

            }
            else
            {
                MessageBox.Show("ERROR LLENE TODOS LOS CAMPOS");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (txtClave.Text != "")
            {
                try
                {
                    datos.IdCarrera = Int32.Parse(txtClave.Text);

                    puente.RegistroEliminar(datos);
                    Limpiar();
                    actualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

            }
            else
            {
                MessageBox.Show("Id no valido, ingrese uno valido por favor");
            }
        }

        private void btnBuscarClave_Click(object sender, EventArgs e)
        {

            if (txtClave.Text != "")
            {
                try
                {
                    datos.IdCarrera = Int32.Parse(txtClave.Text);
                    puente.RegistroBuscar(datos);

                   
                    txtNombre.Text = datos.Nombre;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
            else
            {
                MessageBox.Show("ERROR ESCRIBA UNA ID");
            }
        }

        private void _24Carrera_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            actualizarGrid();
        }


        public static void SoloNumeros(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void SoloLetras(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

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
    }
}

