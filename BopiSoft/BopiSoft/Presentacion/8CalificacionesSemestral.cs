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
﻿using System;
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
    public partial class CalificacionesSemestral : Form
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        public CalificacionesSemestral()
        {
            InitializeComponent();
=======
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
        DatosMaterias datosMaterias = new DatosMaterias();
        DatosCalificaciones datos = new DatosCalificaciones();
        CalificacionesSql calificacionesSql = new CalificacionesSql();
        BDConexion bd = new BDConexion();
        PuenteMaterias puenteMaterias = new PuenteMaterias();
        
        DatosPersonal datospersonal = new DatosPersonal();
        PuentePersonal puentePersonal = new PuentePersonal();

        string IDGrupo;
        string NombreGrupo;
        string NombreMateria;
        int IdMateria;
        int IdDoc;


        public CalificacionesSemestral(string IDGrupo, string NombreGrupo, string NombreMateria, int IdMateria, int IdDoc)
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

        private void button1_Click(object sender, EventArgs e)
        {
            datos.IdGrupo = Convert.ToInt32(txtIDGrupo.Text);
            GRID1.DataSource = bd.SelectDataTable("select * from calificaciones_finales");
        }

        private void CalificacionesSemestral_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            puenteMaterias.RegistroBuscar(datosMaterias);
            if (datosMaterias.Unidades==7)
            {
                GRID1.DataSource = bd.SelectDataTable("select * from calificaciones_unidad where IdGrupo='" + datos.IdGrupo + "'");
            }
            if (datosMaterias.Unidades == 6)
            {
                GRID1.DataSource = bd.SelectDataTable("select IdGrupo,NoControl,Unidad1,Unidad2,Unidad3,Unidad4,Unidad5,Unidad6,Promedio from calificaciones_unidad where IdGrupo='" + datos.IdGrupo + "'");
            }
            if (datosMaterias.Unidades == 5)
            {
                GRID1.DataSource = bd.SelectDataTable("select IdGrupo,NoControl,Unidad1,Unidad2,Unidad3,Unidad4,Unidad5,Promedio from calificaciones_unidad where IdGrupo='" + datos.IdGrupo + "'");
            }

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

        private void calificacionesSemestralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalificacionesSemestral calif = new CalificacionesSemestral(IDGrupo, NombreGrupo, NombreMateria, IdMateria, IdDoc);
            calif.Show();
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

>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
        public CalificacionesSemestral()
        {
            InitializeComponent();
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
            this.Hide();
            Planeacion plan = new Planeacion(IDGrupo, IdMateria, IdDoc);
            plan.Show();
>>>>>>> 031b574... Proyecto completo (Versión Final)
        }
    }
}
