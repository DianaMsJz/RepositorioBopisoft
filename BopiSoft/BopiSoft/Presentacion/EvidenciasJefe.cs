using BopiSoft.Datos;
using BopiSoft.Negocios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BopiSoft.Presentacion
{
    public partial class EvidenciasJefe : Form
    {
        DatosMaterias datosMaterias = new DatosMaterias();
        DatosEvidencias datos = new DatosEvidencias();
        RegistroEvidenciasSql registro = new RegistroEvidenciasSql();
        PuenteEvidencias puente = new PuenteEvidencias();
        PuenteMaterias puenteMaterias = new PuenteMaterias();
        BDConexion bd = new BDConexion();
        DatosPersonal datospersonal = new DatosPersonal();
        PuentePersonal puentePersonal = new PuentePersonal();
        DatosRevisiones datosRevi = new DatosRevisiones();
        RegistroRevision registroRevi = new RegistroRevision();


        int s = 1;
        string IDGrupo;
        string NombreGrupo;
        string NombreMateria;
        int IdMateria;
        int IdDoc;
        int IdJefe;

        public EvidenciasJefe(string IDGrupo,int IdMateria, int IdDoc, int IdJefe)
        {

            InitializeComponent();
            this.IDGrupo = IDGrupo;
            this.IdMateria = IdMateria;
            this.IdDoc = IdDoc;
            this.IdJefe = IdJefe;

           
            datos.IdGrupo = Convert.ToInt32(IDGrupo);
            datosMaterias.IdMateria = IdMateria;
        }

        private void cmbUnidad_Click(object sender, EventArgs e)
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
        public Boolean VerificadoCorrecto()
        {
            Boolean v;
            if (cmbUnidad.Text.Equals("") || E1.Text.Equals("") || E2.Text.Equals("") || E3.Text.Equals("") || E4.Text.Equals("") || E5.Text.Equals("") || E6.Text.Equals("") || E7.Text.Equals(""))
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

        private void cmbUnidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                datos.NoUnidad = Convert.ToInt32(cmbUnidad.Text);

                if (!registro.ExisteEvidenciasUnidad(datos.IdGrupo, datos.NoUnidad))
                {
                    puente.BuscarEvidencias(datos);

                    E1.Text = datos.Ruta1;
                    E2.Text = datos.Ruta2;
                    E3.Text = datos.Ruta3;
                    E4.Text = datos.Ruta4;
                    E5.Text = datos.Ruta5;
                    E6.Text = datos.Ruta6;
                    E7.Text = datos.Ruta7;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVer1_Click(object sender, EventArgs e)
        {
            if (VerificadoCorrecto())
            {
                FileInfo fi = new FileInfo(datos.Ruta1);
                var nombre = fi.Name;
                File.WriteAllBytes(nombre, datos.File1);

            }
           
        }

        private void btnVer2_Click(object sender, EventArgs e)
        {
            if (VerificadoCorrecto())
            {
                FileInfo fi = new FileInfo(datos.Ruta2);
                var nombre = fi.Name;
                File.WriteAllBytes(nombre, datos.File2);

            }
        }

        private void btnVer3_Click(object sender, EventArgs e)
        {
            if (VerificadoCorrecto())
            {
                FileInfo fi = new FileInfo(datos.Ruta3);
                var nombre = fi.Name;
                File.WriteAllBytes(nombre, datos.File3);

            }
        }

        private void btnVer4_Click(object sender, EventArgs e)
        {
            if (VerificadoCorrecto())
            {
                FileInfo fi = new FileInfo(datos.Ruta4);
                var nombre = fi.Name;
                File.WriteAllBytes(nombre, datos.File4);

            }
        }

        private void btnVer5_Click(object sender, EventArgs e)
        {

            if (VerificadoCorrecto())
            {
                FileInfo fi = new FileInfo(datos.Ruta5);
                var nombre = fi.Name;
                File.WriteAllBytes(nombre, datos.File5);

            }
        }

        private void btnVer6_Click(object sender, EventArgs e)
        {
            if (VerificadoCorrecto())
            {
                FileInfo fi = new FileInfo(datos.Ruta6);
                var nombre = fi.Name;
                File.WriteAllBytes(nombre, datos.File6);

            }
        }

        private void btnVer7_Click(object sender, EventArgs e)
        {
            if (VerificadoCorrecto())
            {
                FileInfo fi = new FileInfo(datos.Ruta7);
                var nombre = fi.Name;
                File.WriteAllBytes(nombre, datos.File7);

            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (!cmbUnidad.Text.Equals(""))
            {

                datos.IdGrupo = Convert.ToInt32(IDGrupo);
                datos.NoUnidad = Convert.ToInt32(cmbUnidad.Text );
                if (!registro.ExisteEvidenciasUnidad(datos.IdGrupo, datos.NoUnidad))
                {
                    datosRevi.Fecha = DateTime.Now;
                    datosRevi.Contenido = txtComent.Text;
                    datosRevi.IdDocente = IdDoc;
                    datosRevi.IdGrupo = Convert.ToInt32(IDGrupo);
                    datosRevi.Unidad = Convert.ToInt32(cmbUnidad.Text);
                    datosRevi.Tipo = "Revisión de evidencias";

                    registroRevi.AñadirRevision(datosRevi);
                    txtComent.Text = "";

                }
                else
                {

                    MessageBox.Show("No existe planeación, no se puede comentar");
                }
            }
        }

        private void planeacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlaneacionJefe_11_ evidencias = new PlaneacionJefe_11_(IDGrupo, IdMateria, IdDoc, IdJefe);
            evidencias.Show();
        }

        private void EvidenciasJefe_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
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
                MenuDocenteJefe MenuDocenteObj = new MenuDocenteJefe(IdDoc.ToString(),IdJefe, NombreDoc, PaternoDoc, MaternoDoc, Area, Foto);
                MenuDocenteObj.Show();
            }
        }
    }
}
