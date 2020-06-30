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

=======
        
>>>>>>> 6591c39... 5to Commit
=======

>>>>>>> 01c80df... 6to Commit: Login creado
=======

>>>>>>> 48fe993... Commit 7: Registrar alumnos
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
=======
            
>>>>>>> 6591c39... 5to Commit
=======
>>>>>>> 01c80df... 6to Commit: Login creado
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
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
                    datos.IdMateria = Int32.Parse(txtClave.Text);
                    datos.Unidad =Convert.ToInt32(cmbUnidad.SelectedItem);
                    datos.TemaUnidad = txtTema.ToString();
                    datos.SubtemaUnidad = txtSubtema.ToString();
=======
                    datos.IdMateria = Convert.ToInt32(txtClave.Text);
                    datos.Unidad =Convert.ToInt32(cmbUnidad.Text);
                    datos.TemaUnidad = txtTema.Text;
                    datos.SubtemaUnidad = txtSubtema.Text;
>>>>>>> 48fe993... Commit 7: Registrar alumnos
                    puente.RegistroAñadirContenido(datos);
                    Limpiar();

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
            if (txtClave.Text.Equals("") || cmbUnidad.Text.Equals("") || txtTema.Text.Equals("") || txtSubtema.Text.Equals("") )
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
            cmbUnidad.SelectedIndex = 0;
=======
            cmbUnidad.Text="";
>>>>>>> 48fe993... Commit 7: Registrar alumnos
            txtSubtema.Text = "";
        }

        private void cmbUnidad_Click(object sender, EventArgs e)
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
        {//para que el comboBox jale el número de unidades que tiene dicha materia
            if (!txtClave.Text.Equals(""))
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
            }
>>>>>>> 48fe993... Commit 7: Registrar alumnos
        }

        private void cmbUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            datos.IdMateria= Int32.Parse(txtClave.Text);
=======
            datos.IdMateria= Convert.ToInt32(txtClave.Text);
>>>>>>> 48fe993... Commit 7: Registrar alumnos
            datos.Unidad = Convert.ToInt32(cmbUnidad.Text);

            if (!Registro.ExisteContenidoDeEsaUnidad(datos.IdMateria,datos.Unidad))
            {
                puente.BuscarContenido(datos);
                txtTema.Text = datos.TemaUnidad;
                txtSubtema.Text = datos.SubtemaUnidad;
            }

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
                        datos.IdMateria = Int32.Parse(txtClave.Text);
                        datos.Unidad = Convert.ToInt32(cmbUnidad.SelectedItem);
                        datos.TemaUnidad = txtTema.ToString();
                        datos.SubtemaUnidad = txtSubtema.ToString();
                        puente.RegistroModificar(datos);
=======
                        datos.IdMateria = Convert.ToInt32(txtClave.Text);
                        datos.Unidad = Convert.ToInt32(cmbUnidad.Text);
                        datos.TemaUnidad = txtTema.Text;
                        datos.SubtemaUnidad = txtSubtema.Text;
                        puente.RegistroModificarContenido(datos);
>>>>>>> 48fe993... Commit 7: Registrar alumnos
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
            if (txtClave.Text != "" && cmbUnidad.Text !="")
            {
                try
                {
<<<<<<< HEAD
                    datos.IdMateria = Int32.Parse(txtClave.Text);
=======
                    datos.IdMateria = Convert.ToInt32(txtClave.Text);
>>>>>>> 48fe993... Commit 7: Registrar alumnos
                    datos.Unidad = Convert.ToInt32(cmbUnidad.Text);
                    if (!Registro.ExisteContenidoDeEsaUnidad(datos.IdMateria, datos.Unidad))
                    {
                        var n = MessageBox.Show("¿Está seguro que desea eliminar el contenido de la unidad " + datos.Unidad + " con la Id de la materia "+datos.IdMateria+ "?", "Confirmar eliminación", MessageBoxButtons.YesNo);
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
=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
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
       
>>>>>>> 01c80df... 6to Commit: Login creado
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
