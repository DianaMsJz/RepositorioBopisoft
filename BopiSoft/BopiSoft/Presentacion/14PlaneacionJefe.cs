<<<<<<< HEAD
﻿using System;
=======
﻿using BopiSoft.Datos;
using BopiSoft.Negocios;
using BopiSoft.Presentacion;
using MySql.Data.MySqlClient;
using System;
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
    public partial class PlaneacionJefe_11_ : Form
    {
<<<<<<< HEAD
        public PlaneacionJefe_11_()
        {
            InitializeComponent();
        }
    }
=======
        int s = 1;

        BDConexion bd = new BDConexion();

        PuentePlaneacion PlaneacionPuente = new PuentePlaneacion();
        PuenteMaterias MateriaPuente = new PuenteMaterias();
        PuenteGrupo GrupoPuente = new PuenteGrupo();
        PuentePersonal DocentePuente = new PuentePersonal();

        DatosRevisiones datosRevi = new DatosRevisiones();
        DatosPersonal datospersonal = new DatosPersonal();
        DatosPlaneaciones PlaneacionDatos = new DatosPlaneaciones();
        DatosMaterias MateriaDatos = new DatosMaterias();
        DatosGrupos GrupoDatos = new DatosGrupos();
        DatosPersonal DocenteDatos = new DatosPersonal();
        RegistroMateriaSql RegistroMateria = new RegistroMateriaSql();
        RegistroPlaneacion RegistrarPlaneacion = new RegistroPlaneacion();
        RegistroRevision regisRevi = new RegistroRevision();

        string IDGrupo;
        int IdDocente;
        int IdMateria;
        int IdJefe;
        public PlaneacionJefe_11_(string iDGrupo, int IdJefe,int idMateria, int idDocente)
        {
            InitializeComponent();
            this.IDGrupo = iDGrupo;
            this.IdMateria = idMateria;
            this.IdDocente = idDocente;
            txtIDGrupo.Text = IDGrupo;
            txtIdDocente.Text = "" + IdDocente;
            MateriaDatos.IdMateria = IdMateria;
            this.IdJefe = IdJefe;
        }

        private void PlaneacionJefe_11__Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            MateriaDatos.IdMateria = this.IdMateria;
            MateriaPuente.RegistroBuscar(MateriaDatos);
            if (s == 1)
            {
                for (int i = 0; i < MateriaDatos.Unidades; i++)
                {
                    cmbUnidad.Items.Insert(i, i + 1);
                }
                s++;
            }
        }

        private void cmbUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlaneacionDatos.IdGrupo = Convert.ToInt32(txtIDGrupo.Text);
            PlaneacionDatos.Unidad = Convert.ToInt32(cmbUnidad.Text);
            if (!RegistrarPlaneacion.ExisteRegistroIdGrupo(PlaneacionDatos.IdGrupo, PlaneacionDatos.Unidad))
            {
                try
                {
                    PlaneacionPuente.PlaneacionBuscarId(PlaneacionDatos);
                    //txtIDplaneacion.Text = PlaneacionDatos.IdPlaneacion.ToString();


                    txtNombreMateria.Text = PlaneacionDatos.NombreMateria;
                    txtIdDocente.Text = PlaneacionDatos.IDdocente.ToString();
                    txtNombreDocente.Text = PlaneacionDatos.NombreDocente.ToString();
                    txtIDplaneacion.Text = PlaneacionDatos.IdGrupo.ToString(); ;

                    txtCompetenciaMat.Text = PlaneacionDatos.CompetenciaMat;
                    txtCaracterizacion.Text = PlaneacionDatos.Caracterizacion;
                    txtTemario.Text = PlaneacionDatos.TemarioUnidad;
                    txtActAprendizaje.Text = PlaneacionDatos.ActAprendizaje;

                    txtHrT.Text = PlaneacionDatos.HrsTeoria.ToString();
                    txtHrP.Text = PlaneacionDatos.HrsPractica.ToString();
                    txtSesiones.Text = PlaneacionDatos.SesionesEst.ToString();
                    dateFechaExamen.Value = PlaneacionDatos.FechaExam;

                    txtVisitas.Text = PlaneacionDatos.Visitas;
                    txtPracticas.Text = PlaneacionDatos.Practicas;
                    txtactEnse.Text = PlaneacionDatos.ActEnseñanza;
                    txtRecursos.Text = PlaneacionDatos.Recursos;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Algo salió mal " + ex.ToString());
                }
            }
            else
            {
                txtPracticas.Text = "";
                txtRecursos.Text = "";
                txtHrT.Text = "";
                txtHrP.Text = "";
                txtSesiones.Text = "";
                dateFechaExamen.Value = DateTime.Today.Date; 

                txtVisitas.Text = "";
                txtPracticas.Text = "";
                txtactEnse.Text = "";
                txtRecursos.Text = "";
            }
        }

        private void btnComentar_Click(object sender, EventArgs e)
        {
            if (!cmbUnidad.Text.Equals(""))
            {


                PlaneacionDatos.IdGrupo = Convert.ToInt32(txtIDGrupo.Text);
                PlaneacionDatos.Unidad = Convert.ToInt32(cmbUnidad.Text);
                if (!RegistrarPlaneacion.ExisteRegistroIdGrupo(PlaneacionDatos.IdGrupo, PlaneacionDatos.Unidad))
                {
                    datosRevi.Fecha = DateTime.Now;
                    datosRevi.Contenido = txtComentario.Text;
                    datosRevi.IdDocente = IdDocente;
                    datosRevi.IdGrupo = Convert.ToInt32(txtIDGrupo.Text);
                    datosRevi.Unidad = Convert.ToInt32(cmbUnidad.Text);
                    datosRevi.Tipo = "Revisión de planeación";

                    regisRevi.AñadirRevision(datosRevi);
                    txtComentario.Text = "";

                }
                else
                {
                    
                    MessageBox.Show("No existe planeación, no se puede comentar");
                }
            }
        }

        private void evidenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {

          
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            bd.connecttodb();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM lista_personal WHERE IdPersonal='" + IdDocente + "' ", bd.connect);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                datospersonal.IdPersonal = IdDocente;
                DocentePuente.RegistroBuscar(datospersonal);
                string NombreDoc = datospersonal.Nombre;
                string MaternoDoc = datospersonal.Amaterno;
                String PaternoDoc = datospersonal.Apaterno;
                string Area = datospersonal.NombreDpto;
                byte[] Foto = datospersonal.Foto;

                this.Hide();
                MenuDocenteJefe MenuDocenteObj = new MenuDocenteJefe(IdDocente.ToString(),IdJefe, NombreDoc, PaternoDoc, MaternoDoc, Area, Foto);
                MenuDocenteObj.Show();
            }
        }

        private void evidenciasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            EvidenciasJefe evidencias = new EvidenciasJefe(IDGrupo,IdMateria,IdDocente,IdJefe);
            evidencias.Show();
        }
    }
        
    
>>>>>>> 031b574... Proyecto completo (Versión Final)
}
