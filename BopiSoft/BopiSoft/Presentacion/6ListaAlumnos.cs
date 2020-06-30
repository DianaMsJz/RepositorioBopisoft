<<<<<<< HEAD
﻿using System;
=======
﻿using BopiSoft.Datos;
using BopiSoft.Negocios;
using MySql.Data.MySqlClient;
using System;
>>>>>>> 48fe993... Commit 7: Registrar alumnos
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
        public ListaAlumnos()
        {
            InitializeComponent();
        }

        
=======
        DatosAlumnosGrupos datos = new DatosAlumnosGrupos();
        DatosPersonal datospersonal = new DatosPersonal();
        PuentePersonal PuentePersonal = new PuentePersonal();
        RegistroListaAlumnosSql registro = new RegistroListaAlumnosSql();
        PuenteAlumnos puente = new PuenteAlumnos();
        BDConexion bd = new BDConexion();

        string IDGrupo;
        string NombreGrupo;
        string NombreMateria;
        int IdDoc;

        public ListaAlumnos(string IDGrupo, string NombreGrupo, string NombreMateria, int IdDoc)
        {
            InitializeComponent();
            this.IDGrupo = IDGrupo;
            this.NombreGrupo = NombreGrupo;
            this.NombreMateria = NombreMateria;
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
                    datos.No_Control = Convert.ToInt32(txtNC.Text);
                    datos.IdGrupo = Convert.ToInt32(txtIDGrupo.Text);
                    if (!registro.ExisteAlumno(datos.No_Control,datos.IdGrupo))
                    {
                        MessageBox.Show("Ya existe un alumno con esa clave");
                    }
                    else
                    {
                        datos.Nombre = txtNom.Text;
                        datos.Apaterno = txtApellidoPaterno.Text;
                        datos.Amaterno = txtApellidoMaterno.Text;
                        
                        puente.AñadirAlumno(datos);
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
                    datos.No_Control = Convert.ToInt32(txtNC.Text);
                    if (!registro.ExisteAlumno(datos.No_Control,datos.IdGrupo))
                    {
                        puente.BuscarAlumno(datos);

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
                    datos.No_Control = Convert.ToInt32(txtNC.Text);
                    datos.IdGrupo = Convert.ToInt32(txtIDGrupo.Text);

                    if (!registro.ExisteAlumno(datos.No_Control,datos.IdGrupo))
                    {
                        datos.Nombre = txtNom.Text;
                        datos.Apaterno= txtApellidoPaterno.Text;
                        datos.Amaterno = txtApellidoMaterno.Text;
                        puente.ModificarAlumno(datos);
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
                    datos.No_Control=Int32.Parse(txtNC.Text);

                    if (!registro.ExisteAlumno(datos.No_Control,datos.IdGrupo))
                    {
                        var n = MessageBox.Show("¿Está seguro que desea eliminar el alumno con NC " + datos.No_Control + "?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                        if (n == DialogResult.Yes)
                        {
                            puente.EliminarAlumno(datos);
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
            ListaAlumnos listaAlumno = new ListaAlumnos(IDGrupo, NombreGrupo, NombreMateria, IdDoc);
            listaAlumno.Show();
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
>>>>>>> 48fe993... Commit 7: Registrar alumnos
    }
}
