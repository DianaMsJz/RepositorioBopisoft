using BopiSoft.Datos;
using BopiSoft.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BopiSoft.Presentacion
{
    public partial class _25MateriaContenido : Form
    {
        PuenteMaterias puente = new PuenteMaterias();
        DatosMaterias datos = new DatosMaterias();
        _27MateriaLista lista = new _27MateriaLista();
        RegistroMateriaSql Registro = new RegistroMateriaSql();
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
        int s = 1;

        public _25MateriaContenido()
        {
            InitializeComponent();
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

        private void _25MateriaContenido_Load(object sender, EventArgs e)
        {
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
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            
=======

>>>>>>> 031b574... Proyecto completo (Versión Final)
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
            lista.form = 1;

>>>>>>> 6591c39... 5to Commit
=======
            lista.form = 1;

>>>>>>> 01c80df... 6to Commit: Login creado
=======
            lista.form = 1;

>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
            lista.form = 1;

>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
            lista.form = 1;

>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
            lista.form = 1;

>>>>>>> 031b574... Proyecto completo (Versión Final)
            this.Hide();
            lista.Show();
            MessageBox.Show("Selecciona la materia para obtener la clave");
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
<<<<<<< HEAD
                    datos.IdMateria = Int32.Parse(txtClave.Text);
                    datos.Unidad =Convert.ToInt32(cmbUnidad.SelectedItem);
                    datos.TemaUnidad = txtTema.ToString();
                    datos.SubtemaUnidad = txtSubtema.ToString();
=======
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
                    datos.IdMateria = Convert.ToInt32(txtClave.Text);
                    datos.Unidad =Convert.ToInt32(cmbUnidad.Text);
                    datos.TemaUnidad = txtTema.Text;
                    datos.SubtemaUnidad = txtSubtema.Text;
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
                    puente.RegistroAñadirContenido(datos);
                    Limpiar();
=======
                    datos.IdMateria = Convert.ToInt32(txtClave.Text);
                    datos.Unidad = Convert.ToInt32(cmbUnidad.Text);
                    if (!Registro.ExisteContenidoDeEsaUnidad(datos.IdMateria, datos.Unidad))
                    {
                        MessageBox.Show("Ya existe contenido de esa materia");
                    }
                    else
                    {
                        datos.TemaUnidad = txtTema.Text;
                        datos.SubtemaUnidad = txtSubtema.Text;
                        puente.RegistroAñadirContenido(datos);
                        Limpiar();

                    }
                    
                   
>>>>>>> 031b574... Proyecto completo (Versión Final)

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

        public Boolean VerificadoCorrecto()
        {
            Boolean v;
<<<<<<< HEAD
            if (txtClave.Text.Equals("") || cmbUnidad.Text.Equals("") || txtTema.Text.Equals("") || txtSubtema.Text.Equals("") )
=======
            if (txtClave.Text.Equals("") || cmbUnidad.Text.Equals("") || txtTema.Text.Equals("") || txtSubtema.Text.Equals(""))
>>>>>>> 031b574... Proyecto completo (Versión Final)
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
            txtTema.Text = "";
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            cmbUnidad.SelectedIndex = 0;
=======
            cmbUnidad.Text="";
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
            cmbUnidad.Text="";
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
            cmbUnidad.Text="";
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
            cmbUnidad.Text = "";
>>>>>>> 031b574... Proyecto completo (Versión Final)
            txtSubtema.Text = "";
        }

        private void cmbUnidad_Click(object sender, EventArgs e)
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        {
            datos.IdMateria = Int32.Parse(txtClave.Text);
            puente.RegistroBuscar(datos);
            if (s == 1)
            {
               for (int i = 0; i < datos.Unidades; i++)
                {
                    cmbUnidad.Items.Insert(i, i + 1);
                    
                }
                s++;
            }
            
=======
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
        {//para que el comboBox jale el número de unidades que tiene dicha materia
            if (!txtClave.Text.Equals(""))
            {
                datos.IdMateria = Int32.Parse(txtClave.Text);
                puente.RegistroBuscar(datos);
                if (s == 1)
                {
<<<<<<< HEAD
                     for (int i = 0; i < datos.Unidades; i++)
                     {
                         cmbUnidad.Items.Insert(i, i + 1);
                    
                     }
                     s++;
                }
            }
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
                    for (int i = 0; i < datos.Unidades; i++)
                    {
                        cmbUnidad.Items.Insert(i, i + 1);

                    }
                    s++;
                }
            }
>>>>>>> 031b574... Proyecto completo (Versión Final)
        }

        private void cmbUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            datos.IdMateria= Int32.Parse(txtClave.Text);
=======
            datos.IdMateria= Convert.ToInt32(txtClave.Text);
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
            datos.IdMateria= Convert.ToInt32(txtClave.Text);
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
            datos.IdMateria= Convert.ToInt32(txtClave.Text);
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
            datos.Unidad = Convert.ToInt32(cmbUnidad.Text);

            if (!Registro.ExisteContenidoDeEsaUnidad(datos.IdMateria,datos.Unidad))
=======
            if (!txtClave.Text.Equals(""))
            {
                datos.IdMateria = Convert.ToInt32(txtClave.Text);
                datos.Unidad = Convert.ToInt32(cmbUnidad.Text);

            if (!Registro.ExisteContenidoDeEsaUnidad(datos.IdMateria, datos.Unidad))
>>>>>>> 031b574... Proyecto completo (Versión Final)
            {
                puente.BuscarContenido(datos);
                txtTema.Text = datos.TemaUnidad;
                txtSubtema.Text = datos.SubtemaUnidad;
            }
<<<<<<< HEAD
=======
            else
            {
                txtTema.Text = "";
                txtSubtema.Text = "";
            }

            }
           
>>>>>>> 031b574... Proyecto completo (Versión Final)

        }

        private void btnModi_Click(object sender, EventArgs e)
        {
            if (VerificadoCorrecto())
            {
                if (!Registro.ExisteContenidoDeEsaUnidad(datos.IdMateria, datos.Unidad))
                {
                    try
                    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                        datos.IdMateria = Int32.Parse(txtClave.Text);
                        datos.Unidad = Convert.ToInt32(cmbUnidad.SelectedItem);
                        datos.TemaUnidad = txtTema.ToString();
                        datos.SubtemaUnidad = txtSubtema.ToString();
                        puente.RegistroModificar(datos);
=======
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
                        datos.IdMateria = Convert.ToInt32(txtClave.Text);
                        datos.Unidad = Convert.ToInt32(cmbUnidad.Text);
                        datos.TemaUnidad = txtTema.Text;
                        datos.SubtemaUnidad = txtSubtema.Text;
                        puente.RegistroModificarContenido(datos);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
                        Limpiar();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);

                    }
                }
                else
                {
                    MessageBox.Show("No hay registros");
                }
            }
            else
            {
                //MessageBox.Show("ERROR LLENE TODOS LOS CAMPOS");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (txtClave.Text != "" && cmbUnidad.Text !="")
            {
                try
                {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                    datos.IdMateria = Int32.Parse(txtClave.Text);
=======
                    datos.IdMateria = Convert.ToInt32(txtClave.Text);
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
                    datos.IdMateria = Convert.ToInt32(txtClave.Text);
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
                    datos.IdMateria = Convert.ToInt32(txtClave.Text);
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
                    datos.Unidad = Convert.ToInt32(cmbUnidad.Text);
                    if (!Registro.ExisteContenidoDeEsaUnidad(datos.IdMateria, datos.Unidad))
                    {
                        var n = MessageBox.Show("¿Está seguro que desea eliminar el contenido de la unidad " + datos.Unidad + " con la Id de la materia "+datos.IdMateria+ "?", "Confirmar eliminación", MessageBoxButtons.YesNo);
=======
            if (txtClave.Text != "" && cmbUnidad.Text != "")
            {
                try
                {
                    datos.IdMateria = Convert.ToInt32(txtClave.Text);
                    datos.Unidad = Convert.ToInt32(cmbUnidad.Text);
                    if (!Registro.ExisteContenidoDeEsaUnidad(datos.IdMateria, datos.Unidad))
                    {
                        var n = MessageBox.Show("¿Está seguro que desea eliminar el contenido de la unidad " + datos.Unidad + " con la Id de la materia " + datos.IdMateria + "?", "Confirmar eliminación", MessageBoxButtons.YesNo);
>>>>>>> 031b574... Proyecto completo (Versión Final)
                        if (n == DialogResult.Yes)
                        {
                            puente.RegistroEliminarContenido(datos);
                            Limpiar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay registros ");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }
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

<<<<<<< HEAD
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

=======

    }
>>>>>>> 031b574... Proyecto completo (Versión Final)
}
