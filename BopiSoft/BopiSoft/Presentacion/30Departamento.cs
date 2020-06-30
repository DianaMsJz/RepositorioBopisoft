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
    public partial class _30Departamento : Form
    {
        BDConexion bd = new BDConexion();
        PuenteDepartamento puente = new PuenteDepartamento();
        DatosDepartamentos datos = new DatosDepartamentos();
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
        RegistroDepartamentoSql registro = new RegistroDepartamentoSql();

        string ID;
        string Nombre;
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 01c80df... 6to Commit: Login creado
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias

        public _30Departamento()
        {
            InitializeComponent();
        }

        private void _30Departamento_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            GRID1.DataSource = bd.SelectDataTable("select * from lista_departamentos");
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            if (txtClave.Text!="" && txtNombre.Text!="")
=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias

            ID = txtClave.Text;
            Nombre = txtNombre.Text;


            if (validarDepaVacio(ID,Nombre))
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 01c80df... 6to Commit: Login creado
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
            {
                try
                {
                    datos.IdDpto = Int32.Parse(txtClave.Text);
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

        private void btnModi_Click(object sender, EventArgs e)
        {
            if (txtClave.Text != "" && txtNombre.Text != "")
            {
                try
                {
                    datos.IdDpto = Int32.Parse(txtClave.Text);
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
                    if (!registro.ExisteDepto(datos.IdDpto))
                    {
                        datos.Nombre = txtNombre.Text;
                        puente.RegistroModificar(datos);
                        Limpiar();
                        actualizarGrid();
                    }
                    else
                    {
                        MessageBox.Show("No existe departamento con esa ID" );
                    }
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 01c80df... 6to Commit: Login creado
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
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
                    datos.IdDpto = Int32.Parse(txtClave.Text);
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
                    if (!registro.ExisteDepto(datos.IdDpto))
                    {
                        var n = MessageBox.Show("¿Está seguro que desea eliminar el departamento con la ID " + datos.IdDpto + "?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                        if (n == DialogResult.Yes)
                        {
                            puente.RegistroEliminar(datos);
                            Limpiar();
                            actualizarGrid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existe departamento con esa ID");
                    }
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 01c80df... 6to Commit: Login creado
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

            }
            else
            {
                MessageBox.Show("Id departamento no valido, ingrese uno valido por favor");
            }
        }

        public void actualizarGrid()
        {
            GRID1.DataSource = bd.SelectDataTable("select * from lista_departamentos");
        }

      

        private void btnBuscarClave_Click(object sender, EventArgs e)
        {

            if (txtClave.Text != "")
            {
                try
                {
                    datos.IdDpto= Int32.Parse(txtClave.Text);
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

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();

            _25MateriaEditar materia = new _25MateriaEditar();

            materia.Show();
        }

        private void carreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            _24Carrera carrera = new _24Carrera();

            carrera.Show();
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

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            _23RegistroListaJefe _23Registro = new _23RegistroListaJefe();
            _23Registro.Show();
        }

        private void registroCarreraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            _24Carrera carrera = new _24Carrera();
            carrera.Show();
        }

        private void registroMateriaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            _25MateriaEditar _25Materia = new _25MateriaEditar();
            _25Materia.Show();
        }

        private void contenidoMateriaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            _25MateriaContenido contenido = new _25MateriaContenido();
            contenido.Show();
        }

        private void listaMateriaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            _27MateriaLista materiaLista = new _27MateriaLista();
            materiaLista.Show();
        }

        private void registroGrupoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            _28GruposEditra grupos = new _28GruposEditra();
            grupos.Show();
        }

        private void listaGrupoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            _29GruposLista gruposLista = new _29GruposLista();
            gruposLista.Show();
        }

        private void registroDepartamentoToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            _30Departamento departamento = new _30Departamento();
            departamento.Show();
        }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias


        public bool validarDepaVacio(string id, string nombre)
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

<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 01c80df... 6to Commit: Login creado
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
    }
}
