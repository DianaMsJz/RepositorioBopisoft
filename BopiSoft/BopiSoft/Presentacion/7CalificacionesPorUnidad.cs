<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
﻿using System;
=======
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
﻿using BopiSoft.Datos;
using BopiSoft.Negocios;
using MySql.Data.MySqlClient;
using System;
<<<<<<< HEAD
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
﻿using BopiSoft.Datos;
using BopiSoft.Negocios;
using System;
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
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
    public partial class CalificacionesPorUnidad : Form
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        public CalificacionesPorUnidad()
        {
            InitializeComponent();
        }

      
=======
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
        DatosMaterias datosMaterias = new DatosMaterias();
        PuenteMaterias puenteMaterias = new PuenteMaterias();
        DatosCalificaciones datos = new DatosCalificaciones();
        CalificacionesSql registro = new CalificacionesSql();
        PuenteCalificaciones puente = new PuenteCalificaciones();
        RegistroListaAlumnosSql regisAlumno = new RegistroListaAlumnosSql();
        BDConexion bd = new BDConexion();
<<<<<<< HEAD
<<<<<<< HEAD
        DatosPersonal datospersonal = new DatosPersonal();
        PuentePersonal puentePersonal = new PuentePersonal();
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
        DatosPersonal datospersonal = new DatosPersonal();
        PuentePersonal puentePersonal = new PuentePersonal();
>>>>>>> 031b574... Proyecto completo (Versión Final)

        string IDGrupo;
        string NombreGrupo;
        string NombreMateria;
        int IdMateria;
        int IdDoc;
        int s = 1;

        public CalificacionesPorUnidad(string IDGrupo, string NombreGrupo, string NombreMateria,int IdMateria, int IdDoc)
        {
            InitializeComponent();
            this.IDGrupo = IDGrupo;
            this.NombreGrupo = NombreGrupo;
            this.NombreMateria = NombreMateria;
            this.IdMateria = IdMateria;
            this.IdDoc = IdDoc;

            txtIDGrupo.Text = IDGrupo;
            txtNombreGrupo.Text = NombreGrupo;
            txtNombreMateria.Text = NombreMateria;
            datos.IdGrupo = Convert.ToInt32(IDGrupo);
            datosMaterias.IdMateria = IdMateria;
        }

<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
        
        public Boolean VerificadoCorrecto()
        {
            int x=0;
            Boolean v;
            puenteMaterias.RegistroBuscar(datosMaterias);
            TextBox[] aTextbox = { calif1, calif2, calif3, calif4, calif5, calif6, calif7 };
            for (int i = 0; i < datosMaterias.Unidades; i++)
            {
                if (aTextbox[i].Text.Equals("")|| txtNC.Text.Equals(""))
                {
                    x++;
                }

            }
            if ( x>0)
            {
<<<<<<< HEAD
=======
        private void cmbUnidad_Click(object sender, EventArgs e)
        {
            if (!txtNombreMateria.Text.Equals(""))
            {
                puenteMaterias.RegistroBuscar(datosMaterias);
                if (s == 1)
                {
                    for (int i = 0; i < datosMaterias.Unidades; i++)
                    {
                        cmbUnidad.Items.Insert(i, i + 1);
                    }
                    s++;
                }
            }
        }
        public Boolean VerificadoCorrecto()
        {
            Boolean v;
            if (cmbUnidad.Text.Equals("") || txtNC.Text.Equals("") || txtCalifUni.Text.Equals("") )
            {
                MessageBox.Show("HAY CAMPOS VACIOS POR FAVOR VERIFIQUE");
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
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
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
            txtNC.Text = "";
            calif1.Text = "";
            calif2.Text = "";
            calif3.Text = "";
            calif4.Text = "";
            calif5.Text = "";
            calif6.Text = "";
            calif7.Text = "";
<<<<<<< HEAD
=======
            cmbUnidad.Text = "";
            txtNC.Text = "";
            txtCalifUni.Text = "";
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (VerificadoCorrecto())
            {
                try
                {

                    datos.IdGrupo = Int32.Parse(txtIDGrupo.Text);
                    datos.NoControl= Int32.Parse(txtNC.Text);
<<<<<<< HEAD
<<<<<<< HEAD
                    if (!registro.ExisteCalifAlumno(datos.IdGrupo,datos.NoControl))
=======
                    datos.NoUnidad = Int32.Parse(cmbUnidad.Text);
                    if (!registro.ExisteCalificacionUnidad(datos.IdGrupo,datos.NoUnidad,datos.NoControl))
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
                    if (!registro.ExisteCalifAlumno(datos.IdGrupo,datos.NoControl))
>>>>>>> 031b574... Proyecto completo (Versión Final)
                    {
                        MessageBox.Show("Ya existe registro de esa calificación");
                    }
                    else
                    {
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
                        int suma = 0 ;
                        int promedio;
                        if (datosMaterias.Unidades == 6)
                        {
                            datos.Calif1 = Convert.ToInt32(calif1.Text);
                            datos.Calif2 = Convert.ToInt32(calif2.Text);
                            datos.Calif3 = Convert.ToInt32(calif3.Text);
                            datos.Calif4 = Convert.ToInt32(calif4.Text);
                            datos.Calif5 = Convert.ToInt32(calif5.Text);
                            datos.Calif6 = Convert.ToInt32(calif6.Text);
                        }

                        if (datosMaterias.Unidades == 7)
                        {
                            datos.Calif1 = Convert.ToInt32(calif1.Text);
                            datos.Calif2 = Convert.ToInt32(calif2.Text);
                            datos.Calif3 = Convert.ToInt32(calif3.Text);
                            datos.Calif4 = Convert.ToInt32(calif4.Text);
                            datos.Calif5 = Convert.ToInt32(calif5.Text);
                            datos.Calif6 = Convert.ToInt32(calif6.Text);
                            datos.Calif7 = Convert.ToInt32(calif7.Text);
                        }

                        if (datosMaterias.Unidades == 5)
                        {
                            datos.Calif1 = Convert.ToInt32(calif1.Text);
                            datos.Calif2 = Convert.ToInt32(calif2.Text);
                            datos.Calif3 = Convert.ToInt32(calif3.Text);
                            datos.Calif4 = Convert.ToInt32(calif4.Text);
                            datos.Calif5 = Convert.ToInt32(calif5.Text);
                        }

                        

                        TextBox[] aTextbox = { calif1, calif2, calif3, calif4, calif5, calif6, calif7 };
                        for (int i = 0; i < datosMaterias.Unidades; i++)
                        {

                            suma = suma+Convert.ToInt32(aTextbox[i].Text);
                        }
                        promedio = suma / datosMaterias.Unidades;
                        datos.Promedio = promedio;
                        puente.Añadir(datos);
<<<<<<< HEAD
=======
                        datos.CalificacionUni = Convert.ToInt32(txtCalifUni.Text);
                        
                        puente.Añadir(datos);
                        actualizarGrid();
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
                        Limpiar();
                    }

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

                    datos.IdGrupo = Int32.Parse(txtIDGrupo.Text);
                    datos.NoControl = Int32.Parse(txtNC.Text);
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
                    if (!registro.ExisteCalifAlumno(datos.IdGrupo, datos.NoControl))
                    {
                        
                        int suma = 0;
                        int promedio;
                        if (datosMaterias.Unidades == 6)
                        {
                            datos.Calif1 = Convert.ToInt32(calif1.Text);
                            datos.Calif2 = Convert.ToInt32(calif2.Text);
                            datos.Calif3 = Convert.ToInt32(calif3.Text);
                            datos.Calif4 = Convert.ToInt32(calif4.Text);
                            datos.Calif5 = Convert.ToInt32(calif5.Text);
                            datos.Calif6 = Convert.ToInt32(calif6.Text);
                        }

                        if (datosMaterias.Unidades == 7)
                        {
                            datos.Calif1 = Convert.ToInt32(calif1.Text);
                            datos.Calif2 = Convert.ToInt32(calif2.Text);
                            datos.Calif3 = Convert.ToInt32(calif3.Text);
                            datos.Calif4 = Convert.ToInt32(calif4.Text);
                            datos.Calif5 = Convert.ToInt32(calif5.Text);
                            datos.Calif6 = Convert.ToInt32(calif6.Text);
                            datos.Calif7 = Convert.ToInt32(calif7.Text);
                        }

                        if (datosMaterias.Unidades == 5)
                        {
                            datos.Calif1 = Convert.ToInt32(calif1.Text);
                            datos.Calif2 = Convert.ToInt32(calif2.Text);
                            datos.Calif3 = Convert.ToInt32(calif3.Text);
                            datos.Calif4 = Convert.ToInt32(calif4.Text);
                            datos.Calif5 = Convert.ToInt32(calif5.Text);
                        }



                        TextBox[] aTextbox = { calif1, calif2, calif3, calif4, calif5, calif6, calif7 };
                        for (int i = 0; i < datosMaterias.Unidades; i++)
                        {

                            suma = suma + Convert.ToInt32(aTextbox[i].Text);
                        }
                        promedio = suma / datosMaterias.Unidades;
                        datos.Promedio = promedio;
                        puente.RegistroModificar(datos);
<<<<<<< HEAD
=======
                    datos.NoUnidad = Int32.Parse(cmbUnidad.Text);
                    if (!registro.ExisteCalificacionUnidad(datos.IdGrupo, datos.NoUnidad, datos.NoControl))
                    {
                        datos.CalificacionUni = Convert.ToInt32(txtCalifUni.Text);

                        puente.RegistroModificar(datos);
                        actualizarGrid();
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
                        Limpiar();
                    }
                    else
                    {
<<<<<<< HEAD
<<<<<<< HEAD
                        MessageBox.Show("No existe registro de esas calificaciones, no se puede modificar");
=======
                        MessageBox.Show("No existe registro de esa calificación, no se puede modificar");
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
                        MessageBox.Show("No existe registro de esas calificaciones, no se puede modificar");
>>>>>>> 031b574... Proyecto completo (Versión Final)

                    }

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
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
            if (!txtNC.Text.Equals(""))
            {
                try
                {
                    datos.IdGrupo = Int32.Parse(txtIDGrupo.Text);
                    datos.NoControl = Int32.Parse(txtNC.Text);
                    if (!registro.ExisteCalifAlumno(datos.IdGrupo, datos.NoControl))
                    {
                        var n = MessageBox.Show("¿Está seguro que desea eliminar las calificaciones del alumno " + datos.NoControl, "Confirmar eliminación", MessageBoxButtons.YesNo);
                        if (n == DialogResult.Yes)
                        {
                            puente.RegistroEliminar(datos);
<<<<<<< HEAD
=======
            if (!cmbUnidad.Text.Equals("") || !txtNC.Text.Equals(""))
            {
                try
                {

                    datos.IdGrupo = Int32.Parse(txtIDGrupo.Text);
                    datos.NoControl = Int32.Parse(txtNC.Text);
                    datos.NoUnidad = Int32.Parse(cmbUnidad.Text);
                    if (!registro.ExisteCalificacionUnidad(datos.IdGrupo, datos.NoUnidad, datos.NoControl))
                    {
                        var n = MessageBox.Show("¿Está seguro que desea eliminar la calificación del alumno " + datos.NoControl+ " de la unidad "+datos.NoUnidad+"", "Confirmar eliminación", MessageBoxButtons.YesNo);
                        if (n == DialogResult.Yes)
                        {
                            puente.RegistroEliminar(datos);
                            actualizarGrid();
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
                            Limpiar();
                        }
                        
                    }
                    else
                    {
<<<<<<< HEAD
<<<<<<< HEAD
                        MessageBox.Show("No existe registro de esas calificaciones, no se puede eliminar");
=======
                        MessageBox.Show("No existe registro de esa calificación, no se puede eliminar");
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
                        MessageBox.Show("No existe registro de esas calificaciones, no se puede eliminar");
>>>>>>> 031b574... Proyecto completo (Versión Final)

                    }

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

        private void btnBuscarNC_Click(object sender, EventArgs e)
        {
            if (!regisAlumno.HayAlumnosGrupo(datos.IdGrupo))
            {
                 this.Hide();
                 ListaAlumnos lista= new ListaAlumnos(IdMateria.ToString(), NombreGrupo, NombreMateria, IdMateria, IdDoc);
                 lista.Show();
                 MessageBox.Show("Haga clic en el alumno para obtener su número de control");
            }
            else
            {
                MessageBox.Show("No hay alumnos registrados en este grupo, debe ir a la pestaña registrar alumnos");
            }
           
        }

        private void registrarAlumnosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaAlumnos listaAlumno = new ListaAlumnos(IDGrupo, NombreGrupo, NombreMateria, IdMateria, IdDoc);
            listaAlumno.Show();
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalificacionesPorUnidad calif = new CalificacionesPorUnidad(IDGrupo, NombreGrupo, NombreMateria, IdMateria, IdDoc);
            calif.Show();
        }

        private void CalificacionesPorUnidad_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
           
            puenteMaterias.RegistroBuscar(datosMaterias);
            TextBox[] aTextbox = { calif1, calif2, calif3, calif4, calif5, calif6, calif7 };
            Label[] aLabel = { lab1, lab2, lab3, lab4, lab5, lab6, lab7};
            for (int i = 0; i < datosMaterias.Unidades; i++)
            {
                aTextbox[i].Visible = true;
                aLabel[i].Visible = true;
                
            }

        }


<<<<<<< HEAD
=======
            actualizarGrid();
        }

        public void actualizarGrid()
        {
            if (!cmbUnidad.Text.Equals(""))
            {
                datos.NoUnidad = Convert.ToInt32(cmbUnidad.Text);
                dataGridView1.DataSource = bd.SelectDataTable("select * from calificaciones_unidad where IdGrupo='" + datos.IdGrupo + "' and NoUnidad='"+datos.NoUnidad+"'");

            }
            
        }
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

        

        private void txtCalifUni_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
       
        private void btnBuscarClave_Click(object sender, EventArgs e)
        {
            if (!txtNC.Text.Equals(""))
            {
                datos.IdGrupo = Int32.Parse(txtIDGrupo.Text);
                datos.NoControl = Int32.Parse(txtNC.Text);
                if (!registro.ExisteCalifAlumno(datos.IdGrupo, datos.NoControl))
                {
                    datos.NoControl = Convert.ToInt32(txtNC.Text);
                    datos.IdGrupo = Convert.ToInt32(txtIDGrupo.Text);
                    puente.BuscarCalif(datos);

                    if (datosMaterias.Unidades == 6)
                    {
                        calif1.Text = datos.Calif1.ToString();
                        calif2.Text = datos.Calif2.ToString();
                        calif3.Text = datos.Calif3.ToString();
                        calif4.Text = datos.Calif4.ToString();
                        calif5.Text = datos.Calif5.ToString();
                        calif6.Text = datos.Calif6.ToString();
                    }

                    if (datosMaterias.Unidades == 7)
                    {
                        calif1.Text = datos.Calif1.ToString();
                        calif2.Text = datos.Calif2.ToString();
                        calif3.Text = datos.Calif3.ToString();
                        calif4.Text = datos.Calif4.ToString();
                        calif5.Text = datos.Calif5.ToString();
                        calif6.Text = datos.Calif6.ToString();
                        calif7.Text = datos.Calif7.ToString();
                    }
                    if (datosMaterias.Unidades == 5)
                    {
                        calif1.Text = datos.Calif1.ToString();
                        calif2.Text = datos.Calif2.ToString();
                        calif3.Text = datos.Calif3.ToString();
                        calif4.Text = datos.Calif4.ToString();
                        calif5.Text = datos.Calif5.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No hay calificaciones registradas de ese alumno");
                }

            }
            else
            {
                MessageBox.Show("Haga clic en el botón para ingresar un No. de Control");
            }
        }

        private void calif3_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void calif5_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void calif7_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void calif2_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void calif4_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void calif6_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            bd.connecttodb();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM lista_personal WHERE IdPersonal='" + IdDoc + "' ", bd.connect);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                datospersonal.IdPersonal = IdDoc;
                puentePersonal.RegistroBuscar(datospersonal);
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

        private void calificacionesSemestralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalificacionesSemestral semestral = new CalificacionesSemestral(IDGrupo, NombreGrupo, NombreMateria, IdMateria, IdDoc);
            semestral.Show();
        }

        private void evidenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Evidencias evi = new Evidencias(IDGrupo, NombreGrupo, NombreMateria, IdMateria, IdDoc);
            evi.Show();
        }

        private void planeacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

        }
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
        private void cmbUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nounidad = Convert.ToInt32(cmbUnidad.Text);
            dataGridView1.DataSource = bd.SelectDataTable("select * from calificaciones_unidad where IdGrupo='" + datos.IdGrupo + "' and NoUnidad='" + nounidad + "'");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow llenarNC = dataGridView1.Rows[e.RowIndex];
            txtNC.Text = llenarNC.Cells["NoControl"].Value.ToString();

            DataGridViewRow llenarCalif = dataGridView1.Rows[e.RowIndex];
            txtCalifUni.Text = llenarCalif.Cells["CalificacionUni"].Value.ToString();

            DataGridViewRow llenarUnidad = dataGridView1.Rows[e.RowIndex];
            cmbUnidad.Text = llenarUnidad.Cells["NoUnidad"].Value.ToString();
        }
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
            this.Hide();
            Planeacion plan = new Planeacion(IDGrupo, IdMateria, IdDoc);
            plan.Show();
        }
>>>>>>> 031b574... Proyecto completo (Versión Final)
    }
}
