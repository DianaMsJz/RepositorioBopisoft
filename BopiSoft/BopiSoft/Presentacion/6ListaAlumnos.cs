<<<<<<< HEAD
<<<<<<< HEAD
﻿using System;
=======
﻿using BopiSoft.Datos;
using BopiSoft.Negocios;
using MySql.Data.MySqlClient;
using System;
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
﻿using BopiSoft.Datos;
using BopiSoft.Negocios;
using BopiSoft.Presentacion;
using MySql.Data.MySqlClient;
using System;
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
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
    public partial class ListaAlumnos : Form
    {
<<<<<<< HEAD
<<<<<<< HEAD
        public ListaAlumnos()
        {
            InitializeComponent();
        }

        
=======
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
        DatosAlumnosGrupos datos = new DatosAlumnosGrupos();
        DatosPersonal datospersonal = new DatosPersonal();
        PuentePersonal PuentePersonal = new PuentePersonal();
        RegistroListaAlumnosSql registro = new RegistroListaAlumnosSql();
        PuenteAlumnos puente = new PuenteAlumnos();
        BDConexion bd = new BDConexion();
<<<<<<< HEAD

        string IDGrupo;
        string NombreGrupo;
        string NombreMateria;
        int IdDoc;

        public ListaAlumnos(string IDGrupo, string NombreGrupo, string NombreMateria, int IdDoc)
=======
        
        string IDGrupo;
        string NombreGrupo;
        string NombreMateria;
        int IdMateria;
        int IdDoc;

        public ListaAlumnos(string IDGrupo, string NombreGrupo, string NombreMateria,int IdMateria, int IdDoc)
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
        {
            InitializeComponent();
            this.IDGrupo = IDGrupo;
            this.NombreGrupo = NombreGrupo;
            this.NombreMateria = NombreMateria;
<<<<<<< HEAD
=======
            this.IdMateria = IdMateria;
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
            this.IdDoc = IdDoc;

            txtIDGrupo.Text = IDGrupo;
            txtNombreGrupo.Text = NombreGrupo;
            txtNombreMateria.Text = NombreMateria;
            datos.IdGrupo = Convert.ToInt32(IDGrupo);
           
        }

        private void ListaAlumnos_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            actualizarGrid();
        }

        public void Limpiar()
        {
            txtNC.Text = "";
            txtNom.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
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


        private void txtNC_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }
        public Boolean VerificadoCorrecto()
        {
            Boolean v;
            if (txtNC.Text.Equals("") || txtNom.Text.Equals("") || txtApellidoMaterno.Text.Equals("") || txtApellidoPaterno.Text.Equals("") )
            {
                v = false;
            }
            else
            {
                v = true;
            }
            return v;
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (VerificadoCorrecto())
            {
                try
                {
<<<<<<< HEAD
                    datos.No_Control = Convert.ToInt32(txtNC.Text);
                    datos.IdGrupo = Convert.ToInt32(txtIDGrupo.Text);
                    if (!registro.ExisteAlumno(datos.No_Control,datos.IdGrupo))
=======
                    datos.NoControl = Convert.ToInt32(txtNC.Text);
                    datos.IdGrupo = Convert.ToInt32(txtIDGrupo.Text);
                    if (!registro.ExisteAlumno(datos.IdGrupo,datos.NoControl))
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
                    {
                        MessageBox.Show("Ya existe un alumno con esa clave");
                    }
                    else
                    {
                        datos.Nombre = txtNom.Text;
                        datos.Apaterno = txtApellidoPaterno.Text;
                        datos.Amaterno = txtApellidoMaterno.Text;
                        
<<<<<<< HEAD
                        puente.AñadirAlumno(datos);
=======
                        puente.Añadir(datos);
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
                        actualizarGrid();
                        Limpiar();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnBuscarClave_Click(object sender, EventArgs e)
        {
            if (!txtNC.Equals(""))
            {
                try
                {
                    datos.IdGrupo = Convert.ToInt32(txtIDGrupo.Text);
<<<<<<< HEAD
                    datos.No_Control = Convert.ToInt32(txtNC.Text);
                    if (!registro.ExisteAlumno(datos.No_Control,datos.IdGrupo))
                    {
                        puente.BuscarAlumno(datos);
=======
                    datos.NoControl = Convert.ToInt32(txtNC.Text);
                    if (!registro.ExisteAlumno(datos.IdGrupo,datos.NoControl))
                    {
                        puente.Buscar(datos);
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias

                        txtNom.Text = datos.Nombre;
                        txtApellidoPaterno.Text = datos.Apaterno;
                        txtApellidoMaterno.Text = datos.Amaterno;

                    }
                    else
                    {
                        MessageBox.Show("No existe registro con ese Número de Control");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Escriba un Número de Control");
            }
        }
        public void actualizarGrid()
        {
            dataGridView1.DataSource = bd.SelectDataTable("select * from lista_alumnos where IdGrupo='" + datos.IdGrupo + "'");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
           
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM lista_personal WHERE IdPersonal='" + IdDoc + "' ", bd.connect); 
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                datospersonal.IdPersonal = IdDoc;
                PuentePersonal.RegistroBuscar(datospersonal);
                string NombreDoc = datospersonal.Nombre;
                string MaternoDoc = datospersonal.Amaterno;
                String PaternoDoc = datospersonal.Apaterno;
                string Area = datospersonal.NombreDpto;
                byte[] Foto = datospersonal.Foto;

                this.Hide();
                _2MenuDocente MenuDocenteObj = new _2MenuDocente(IdDoc.ToString(), NombreDoc, PaternoDoc, MaternoDoc, Area, Foto);
                MenuDocenteObj.Show();
            }
           
        }

        private void btnModi_Click(object sender, EventArgs e)
        {
            if (VerificadoCorrecto())
            {
                try
                {
<<<<<<< HEAD
                    datos.No_Control = Convert.ToInt32(txtNC.Text);
                    datos.IdGrupo = Convert.ToInt32(txtIDGrupo.Text);

                    if (!registro.ExisteAlumno(datos.No_Control,datos.IdGrupo))
=======
                    datos.NoControl = Convert.ToInt32(txtNC.Text);
                    datos.IdGrupo = Convert.ToInt32(txtIDGrupo.Text);

                    if (!registro.ExisteAlumno(datos.IdGrupo, datos.NoControl))
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
                    {
                        datos.Nombre = txtNom.Text;
                        datos.Apaterno= txtApellidoPaterno.Text;
                        datos.Amaterno = txtApellidoMaterno.Text;
<<<<<<< HEAD
                        puente.ModificarAlumno(datos);
=======
                        puente.RegistroModificar(datos);
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
                        actualizarGrid();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No existe un alumno con esa clave");
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
            if (txtNC.Text != "")
            {
                try
                {
                    datos.IdGrupo = Int32.Parse(txtIDGrupo.Text);
<<<<<<< HEAD
                    datos.No_Control=Int32.Parse(txtNC.Text);

                    if (!registro.ExisteAlumno(datos.No_Control,datos.IdGrupo))
                    {
                        var n = MessageBox.Show("¿Está seguro que desea eliminar el alumno con NC " + datos.No_Control + "?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                        if (n == DialogResult.Yes)
                        {
                            puente.EliminarAlumno(datos);
=======
                    datos.NoControl=Int32.Parse(txtNC.Text);

                    if (!registro.ExisteAlumno(datos.IdGrupo, datos.NoControl))
                    {
                        var n = MessageBox.Show("¿Está seguro que desea eliminar el alumno con NC " + datos.NoControl + "?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                        if (n == DialogResult.Yes)
                        {
                            puente.RegistroEliminar(datos);
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
                            actualizarGrid();
                            Limpiar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existe alumno con ese Número de Control");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.ToString());
                }
            }
        }

        private void registrarAlumnosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
<<<<<<< HEAD
            ListaAlumnos listaAlumno = new ListaAlumnos(IDGrupo, NombreGrupo, NombreMateria, IdDoc);
=======
            ListaAlumnos listaAlumno = new ListaAlumnos(IDGrupo, NombreGrupo, NombreMateria,IdMateria, IdDoc);
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
            listaAlumno.Show();
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

        }
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
            this.Hide();
            CalificacionesPorUnidad calif = new CalificacionesPorUnidad(IDGrupo, NombreGrupo, NombreMateria, IdMateria, IdDoc);
            calif.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow llenarNC = dataGridView1.Rows[e.RowIndex];
            String NoControl = llenarNC.Cells["No_Control"].Value.ToString();
            datos.NoControl =Convert.ToInt32(NoControl);
            MessageBox.Show(datos.NoControl.ToString());
            CalificacionesPorUnidad calif = new CalificacionesPorUnidad(IDGrupo, NombreGrupo,NombreMateria,IdMateria, IdDoc);
            calif.txtNC.Text = datos.NoControl.ToString();
            
            this.Hide();
            calif.Show();
                
        }

        private void evidenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Evidencias evidencias = new Evidencias(IDGrupo, NombreGrupo, NombreMateria, IdMateria, IdDoc);
            evidencias.Show();
        }

        private void calificacionesSemestralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalificacionesSemestral semestral = new CalificacionesSemestral(IDGrupo, NombreGrupo, NombreMateria, IdMateria, IdDoc);
            semestral.Show();
        }

        private void planeacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
    }
}
