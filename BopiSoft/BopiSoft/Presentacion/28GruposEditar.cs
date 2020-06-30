<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
﻿using BopiSoft.Presentacion;
=======
﻿using BopiSoft.Datos;
using BopiSoft.Negocios;
using BopiSoft.Presentacion;
>>>>>>> 6591c39... 5to Commit
=======
﻿using BopiSoft.Datos;
using BopiSoft.Negocios;
using BopiSoft.Presentacion;
>>>>>>> 01c80df... 6to Commit: Login creado
=======
﻿using BopiSoft.Datos;
using BopiSoft.Negocios;
using BopiSoft.Presentacion;
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
﻿using BopiSoft.Datos;
using BopiSoft.Negocios;
using BopiSoft.Presentacion;
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
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
    public partial class _28GruposEditra : Form
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 01c80df... 6to Commit: Login creado
        PuenteGrupo puente = new PuenteGrupo();
        _27MateriaLista lista = new _27MateriaLista();
        _22RegistroListDoc listaDoc = new _22RegistroListDoc();
        DatosGrupos datos = new DatosGrupos();

<<<<<<< HEAD
>>>>>>> 6591c39... 5to Commit
=======
>>>>>>> 01c80df... 6to Commit: Login creado
=======
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
        BDConexion bd = new BDConexion();
        PuenteGrupo puente = new PuenteGrupo();
        PuenteDepartamento puenteDpto = new PuenteDepartamento();
        _27MateriaLista lista = new _27MateriaLista();
        DatosGrupos datos = new DatosGrupos();
        RegistroGruposSql registro = new RegistroGruposSql();

<<<<<<< HEAD
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
        public _28GruposEditra()
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======

        private void _28GruposEditra_Load(object sender, EventArgs e)
        {
            
=======

        private void _28GruposEditra_Load(object sender, EventArgs e)
        {

>>>>>>> 01c80df... 6to Commit: Login creado
=======
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias

        private void _28GruposEditra_Load(object sender, EventArgs e)
        {
            puenteDpto.LlenarComboBoxDeptos(comboBox1);
<<<<<<< HEAD
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            puente.LlenarCombo(cmbCarrera);
        }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        private void btnBuscarMateria_Click(object sender, EventArgs e)
=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias

        public void actualizarNombreMateria(String nombreMateria)
        {
            txtNombreMat.Text = nombreMateria;
        }
<<<<<<< HEAD
=======
        public void actualizarIdMateria(int IdMateria)
        {
            txtIdMateria.Text = IdMateria.ToString();
        }
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias

        public void actualizarClaveDocente(int IdPersonal)
        {
            txtClaveDoc.Text = IdPersonal.ToString();
        }

        private void btnBuscarMateria_Click_1(object sender, EventArgs e)
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 01c80df... 6to Commit: Login creado
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
        {
            lista.form = 2;
            this.Hide();
            lista.Show();
            MessageBox.Show("Selecciona la materia para obtener el nombre");
        }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        private void btnBuscarDocente_Click(object sender, EventArgs e)
=======
        private void btnBuscarDocente_Click_1(object sender, EventArgs e)
>>>>>>> 01c80df... 6to Commit: Login creado
        {
            this.Hide();
            listaDoc.Show();
            MessageBox.Show("Selecciona el docente para obtener la clave");
        }

<<<<<<< HEAD
        public void actualizarNombreMateria(String nombreMateria)
        {
            txtNombreMat.Text =nombreMateria;
        }

        public void actualizarClaveDocente(int IdPersonal)
        {
            txtClaveDoc.Text =IdPersonal.ToString();
=======
        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
>>>>>>> 01c80df... 6to Commit: Login creado
=======
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
        private void btnBuscarDocente_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Selecciona el docente en la tabla para obtener la clave");
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
<<<<<<< HEAD
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
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

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
>>>>>>> 6591c39... 5to Commit
=======
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }
>>>>>>> 01c80df... 6to Commit: Login creado
=======
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String depto;
            depto = comboBox1.Text;
            GRID1.DataSource = bd.SelectDataTable("select * from lista_personal where Tipo='docente' and NombreDpto='" + depto + "'");
        }

        private void GRID1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow llenarClave = GRID1.Rows[e.RowIndex];
            int IdPersonal = Convert.ToInt32(llenarClave.Cells["IdPersonal"].Value);
            txtClaveDoc.Text = IdPersonal.ToString();
        }
        public Boolean VerificadoCorrecto()
        {
            Boolean v;
            if (txtClave.Text.Equals("") || txtNombre.Text.Equals("") || cmbCarrera.Text.Equals("") || txtNombreMat.Text.Equals("") || txtClaveDoc.Text.Equals("") ||
<<<<<<< HEAD
                cmbSemestre.Text.Equals("") || cmbTurno.Text.Equals(""))
=======
                cmbSemestre.Text.Equals("") || cmbTurno.Text.Equals("") || txtIdMateria.Text.Equals(""))
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
            {
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
            cmbCarrera.Text = "";
            txtNombreMat.Text = "";
<<<<<<< HEAD
=======
            txtIdMateria.Text = "";
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
            txtClaveDoc.Text = "";
            cmbSemestre.Text = "";
            cmbTurno.Text = "";
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (VerificadoCorrecto())
            {
                try
                {
                    datos.IdGrupo = Convert.ToInt32(txtClave.Text);
                    if (!registro.ExisteRegistro(datos.IdGrupo))
                    {
                        MessageBox.Show("Ya existe un grupo con esa clave");
                    }
                    else
                    {
                        datos.Nombre = txtNombre.Text;
                        datos.NombreCarrera = cmbCarrera.Text;
                        datos.NombreMateria = txtNombreMat.Text;
<<<<<<< HEAD
=======
                        datos.IdMateria =Convert.ToInt32(txtIdMateria.Text);
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
                        datos.IdPersonal = Convert.ToInt32(txtClaveDoc.Text);
                        datos.Semestre = Convert.ToInt32(cmbSemestre.Text);
                        datos.Turno = cmbTurno.Text;
                        puente.AñadirGrupo(datos);
                        Limpiar();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnModi_Click(object sender, EventArgs e)
        {
            if (VerificadoCorrecto())
            {
                try
                {
                    datos.IdGrupo = Convert.ToInt32(txtClave.Text);
                    if (!registro.ExisteRegistro(datos.IdGrupo))
                    {
                        datos.Nombre = txtNombre.Text;
                        datos.NombreCarrera = cmbCarrera.Text;
                        datos.NombreMateria = txtNombreMat.Text;
<<<<<<< HEAD
=======
                        datos.IdMateria = Convert.ToInt32(txtIdMateria.Text);
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
                        datos.IdPersonal = Convert.ToInt32(txtClaveDoc.Text);
                        datos.Semestre = Convert.ToInt32(cmbSemestre.Text);
                        datos.Turno = cmbTurno.Text;
                        puente.ModificarGrupo(datos);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No existe un grupo con esa clave");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnBuscarClave_Click(object sender, EventArgs e)
        {
            if (txtClave.Text != "")
            {
                try
                {
                    datos.IdGrupo = Int32.Parse(txtClave.Text);
                    if (!registro.ExisteRegistro(datos.IdGrupo))
                    {
                        puente.GrupoBuscar(datos);

                        txtNombre.Text = datos.Nombre;
                        cmbCarrera.Text = datos.NombreCarrera;
                        txtNombreMat.Text = datos.NombreMateria;
<<<<<<< HEAD
=======
                        txtIdMateria.Text = datos.IdMateria.ToString();
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
                        txtClaveDoc.Text = datos.IdPersonal.ToString();
                        cmbSemestre.Text = datos.Semestre.ToString();
                        cmbTurno.Text = datos.Turno.ToString();

                    }
                    else
                    {
                        MessageBox.Show("No existe un grupo con esa clave");
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text != "")
            {
                try
                {
                    datos.IdGrupo = Int32.Parse(txtClave.Text);
                    if (!registro.ExisteRegistro(datos.IdGrupo))
                    {
                        var n = MessageBox.Show("¿Está seguro que desea eliminar el grupo con la clave " + datos.IdGrupo + "?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                        if (n == DialogResult.Yes)
                        {
                            puente.GrupoEliminar(datos);
                            Limpiar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existe grupo con esa clave");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.ToString());
                }
            }
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            if(txtClave.Text != "")
            {
                datos.IdGrupo = Convert.ToInt32(txtClave.Text);
                if (!registro.ExisteRegistro(datos.IdGrupo))
                {
                    MessageBox.Show("Ya existe un registro con esa clave");
                }

            }
           
        }

        private void GRID1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
    }
}
