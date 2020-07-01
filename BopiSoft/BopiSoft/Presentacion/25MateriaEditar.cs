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
    public partial class _25MateriaEditar : Form
    {
        PuenteMaterias puente = new PuenteMaterias();
        DatosMaterias datos = new DatosMaterias();
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
        RegistroMateriaSql registro = new RegistroMateriaSql();
>>>>>>> 01c80df... 6to Commit: Login creado
=======
        RegistroMateriaSql registro = new RegistroMateriaSql();
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
        RegistroMateriaSql registro = new RegistroMateriaSql();
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
        RegistroMateriaSql registro = new RegistroMateriaSql();
>>>>>>> 80c648b... Commit 9 registro de las planeaciones

        public _25MateriaEditar()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (VerificadoCorrecto())
            {
                try
                {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                    datos.IdMateria = Int32.Parse(txtClave.Text);
                    datos.Nombre = txtNombre.Text;
                    datos.Creditos = Convert.ToInt32(txtCreditos.Text);
                    datos.Carrera = cmbCarrera.SelectedItem.ToString();
                    datos.Unidades = Convert.ToInt32(txtUnidades.Text);
                    datos.Caracterizacion = txtCaracterizacion.Text;
                    datos.Competencia = txtCompetencia.Text;
                    puente.RegistroAñadir(datos);
                    Limpiar();
=======
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones

                    datos.IdMateria = Int32.Parse(txtClave.Text);
                    if (!registro.ExisteMateria(datos.IdMateria))
                    {
                        MessageBox.Show("Ya existe una materia con esa ID");
                    }
                    else
                    {
                        datos.Nombre = txtNombre.Text;
                        datos.Creditos = Convert.ToInt32(txtCreditos.Text);
                        datos.Carrera = cmbCarrera.SelectedItem.ToString();
                        datos.Unidades = Convert.ToInt32(txtUnidades.Text);
                        datos.Caracterizacion = txtCaracterizacion.Text;
                        datos.Competencia = txtCompetencia.Text;
                        puente.RegistroAñadir(datos);
                        Limpiar();
                    }
<<<<<<< HEAD
<<<<<<< HEAD
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

        private void btnModi_Click(object sender, EventArgs e)
        {
            if (VerificadoCorrecto())
            {
                try
                {
                    datos.IdMateria = Int32.Parse(txtClave.Text);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                    datos.Nombre = txtNombre.Text;
                    datos.Creditos = Convert.ToInt32(txtCreditos.Text);
                    datos.Carrera = cmbCarrera.SelectedItem.ToString();
                    datos.Unidades = Convert.ToInt32(txtUnidades.Text);
                    datos.Caracterizacion = txtCaracterizacion.Text;
                    datos.Competencia = txtCompetencia.Text;
                    puente.RegistroModificar(datos);
                    Limpiar();
=======
                    if (!registro.ExisteMateria(datos.IdMateria))
                    {
                        datos.Nombre = txtNombre.Text;
                        datos.Creditos = Convert.ToInt32(txtCreditos.Text);
                        datos.Carrera = cmbCarrera.SelectedItem.ToString();
=======
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
                    if (!registro.ExisteMateria(datos.IdMateria))
                    {
                        
                        datos.Nombre = txtNombre.Text;
                        datos.Creditos = Convert.ToInt32(txtCreditos.Text);
                        datos.Carrera = cmbCarrera.Text;
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
                        datos.Unidades = Convert.ToInt32(txtUnidades.Text);
                        datos.Caracterizacion = txtCaracterizacion.Text;
                        datos.Competencia = txtCompetencia.Text;
                        puente.RegistroModificar(datos);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No existe materia con esa ID" );
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
                    datos.IdMateria = Int32.Parse(txtClave.Text);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                    puente.RegistroEliminar(datos);
                    Limpiar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones

                    if (!registro.ExisteMateria(datos.IdMateria))
                    {
                        var n = MessageBox.Show("¿Está seguro que desea eliminar la materia con la ID " + datos.IdMateria + "?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                        if (n == DialogResult.Yes)
                        {
                            puente.RegistroEliminar(datos);
                            Limpiar();
                        }
                    }
                    else
                    {
                       MessageBox.Show("No existe materia con esa ID" );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.ToString());
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

            }
            else
            {
                MessageBox.Show("Id de la materia no valido, ingrese uno valido porfavor");
            }
        }

        private void btnBuscarClave_Click(object sender, EventArgs e)
        {
            if (txtClave.Text != "")
            {
                try
                {
                    datos.IdMateria = Int32.Parse(txtClave.Text);
                    puente.RegistroBuscar(datos);

                    
                    txtNombre.Text = datos.Nombre;
                    txtUnidades.Text = datos.Unidades.ToString();
                    cmbCarrera.SelectedItem = datos.Carrera;
                    txtCreditos.Text = datos.Creditos.ToString();
                    txtCaracterizacion.Text = datos.Caracterizacion.ToString();
                    txtCompetencia.Text = datos.Competencia.ToString();

                }
                catch (Exception ex)
                {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                    MessageBox.Show("" + ex);
=======
                    MessageBox.Show("No existe materia con esa ID" );
>>>>>>> 01c80df... 6to Commit: Login creado
=======
                    MessageBox.Show("No existe materia con esa ID" );
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
                    MessageBox.Show("No existe materia con esa ID" );
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
                    MessageBox.Show("No existe materia con esa ID" );
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
                }
            }
            else
            {
                MessageBox.Show("ERROR ESCRIBA UNA ID");
            }

        }

        public Boolean VerificadoCorrecto()
        {
            Boolean v;
            if (txtClave.Text.Equals("") || txtNombre.Text.Equals("") || txtCreditos.Text.Equals("") || txtUnidades.Text.Equals("") || txtCaracterizacion.Text.Equals("") ||
                txtCompetencia.Text.Equals("") || cmbCarrera.Text.Equals("") )
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

        public void Limpiar()
        {
            txtClave.Text = "";
            txtNombre.Text = "";
            txtUnidades.Text = "";
            cmbCarrera.SelectedIndex = 0;
            txtCreditos.Text = "";
            txtCaracterizacion.Text = "";
            txtCompetencia.Text = "";
        }

        private void _25MateriaEditar_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            puente.LlenarCombo(cmbCarrera);
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

        private void txtCreditos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCreditos_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        

        private void txtUnidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtCaracterizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtCompetencia_KeyPress(object sender, KeyPressEventArgs e)
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
=======
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones

        private void txtNombre_Click(object sender, EventArgs e)
        {
            if (txtClave.Text != "")
            {
                datos.IdMateria = Convert.ToInt32(txtClave.Text);
                if (!registro.ExisteMateria(datos.IdMateria))
                {
                    MessageBox.Show("Ya existe una materia con esa ID");
                }
            }
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
