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
        RegistroCarrerasSql registro = new RegistroCarrerasSql();

        string ID;
        string Nombre;

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

        public _24Carrera()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            if (txtClave.Text != "" && txtNombre.Text != "")
=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones

            ID = txtClave.Text;
            Nombre = txtNombre.Text;
            if (validarCarreraVacia(ID, Nombre))
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

            }
            else
=======
            }
          else
>>>>>>> 01c80df... 6to Commit: Login creado
=======
            }
          else
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
            }
          else
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
            }
          else
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                    datos.Nombre = txtNombre.Text;


                    puente.RegistroModificar(datos);
                    Limpiar();
                    actualizarGrid();
=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
                    if (!registro.ExisteCarrera(datos.IdCarrera))
                    {
                        datos.Nombre = txtNombre.Text;
                        puente.RegistroModificar(datos);
                        Limpiar();
                        actualizarGrid();
                    }
                    else
                    {
                        MessageBox.Show("No existe carrera con esa ID");
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

                    puente.RegistroEliminar(datos);
                    Limpiar();
                    actualizarGrid();
=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
                    if (!registro.ExisteCarrera(datos.IdCarrera))
                    {
                        var n = MessageBox.Show("¿Está seguro que desea eliminar la carrera con la ID " + datos.IdCarrera + "?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                        if (n == DialogResult.Yes)
                        {
                            puente.RegistroEliminar(datos);
                            Limpiar();
                            actualizarGrid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existe carrera con esa ID" );
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


        public bool validarCarreraVacia(string id, string nombre)
        {
            Boolean v = false;
            if (id.Length <= 0 || nombre.Length <= 0)
            {
                MessageBox.Show("HAY CAMPOS VACIOS POR FAVOR VERIFIQUE");
                v = false;
            }
            else
            {
                v = true;
            }
            return v;
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 01c80df... 6to Commit: Login creado
=======
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones

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
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
    }
}

