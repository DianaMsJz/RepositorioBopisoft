<<<<<<< HEAD
<<<<<<< HEAD
﻿using System;
=======
﻿using BopiSoft.Datos;
using BopiSoft.Negocios;
using MySql.Data.MySqlClient;
using System;
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
﻿using BopiSoft.Datos;
using BopiSoft.Negocios;
using System;
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
<<<<<<< HEAD
<<<<<<< HEAD
=======
using System.IO;
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
using System.IO;
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BopiSoft
{
    public partial class Evidencias : Form
    {
<<<<<<< HEAD
<<<<<<< HEAD
        public Evidencias()
        {
            InitializeComponent();
        }

       
=======
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
        DatosMaterias datosMaterias = new DatosMaterias();
        DatosEvidencias datos = new DatosEvidencias();
        RegistroEvidenciasSql registro = new RegistroEvidenciasSql();
        PuenteEvidencias puente = new PuenteEvidencias();
        PuenteMaterias puenteMaterias = new PuenteMaterias();
<<<<<<< HEAD
        BDConexion bd = new BDConexion();
        DatosPersonal datospersonal = new DatosPersonal();
        PuentePersonal puentePersonal = new PuentePersonal();
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
        int s = 1;
        string IDGrupo;
        string NombreGrupo;
        string NombreMateria;
        int IdMateria;
        int IdDoc;

        public Evidencias(string IDGrupo, string NombreGrupo, string NombreMateria, int IdMateria, int IdDoc)
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

        private void Evidencias_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
=======

>>>>>>> 80c648b... Commit 9 registro de las planeaciones
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "Documentos (*.docx)|*.docx|Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                E1.Text = openFileDialog1.FileName;
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

        public void Limpiar()
        {
            cmbUnidad.Text = "";
            E1.Text = "";
            E2.Text = "";
            E3.Text = "";
            E4.Text = "";
            E5.Text = "";
            E6.Text = "";
            E7.Text = "";
<<<<<<< HEAD
            txtComent.Text = "";
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog2.Filter = "Documentos (*.docx)|*.docx|Todos los archivos (*.*)|*.*";
            openFileDialog2.FilterIndex = 1;
            openFileDialog2.RestoreDirectory = true;

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {

                E2.Text = openFileDialog2.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog3.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog3.Filter = "Documentos (*.docx)|*.docx|Todos los archivos (*.*)|*.*";
            openFileDialog3.FilterIndex = 1;
            openFileDialog3.RestoreDirectory = true;

            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {

                E3.Text = openFileDialog3.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog4.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog4.Filter = "Documentos (*.docx)|*.docx|Todos los archivos (*.*)|*.*";
            openFileDialog4.FilterIndex = 1;
            openFileDialog4.RestoreDirectory = true;

            if (openFileDialog4.ShowDialog() == DialogResult.OK)
            {

                E4.Text = openFileDialog4.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog5.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog5.Filter = "Documentos (*.docx)|*.docx|Todos los archivos (*.*)|*.*";
            openFileDialog5.FilterIndex = 1;
            openFileDialog5.RestoreDirectory = true;

            if (openFileDialog5.ShowDialog() == DialogResult.OK)
            {

                E5.Text = openFileDialog5.FileName;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            openFileDialog7.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog7.Filter = "Documentos (*.docx)|*.docx|Todos los archivos (*.*)|*.*";
            openFileDialog7.FilterIndex = 1;
            openFileDialog7.RestoreDirectory = true;

            if (openFileDialog7.ShowDialog() == DialogResult.OK)
            {

                E7.Text = openFileDialog7.FileName;
=======
            openFileDialog6.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog6.Filter = "Documentos (*.docx)|*.docx|Todos los archivos (*.*)|*.*";
            openFileDialog6.FilterIndex = 1;
            openFileDialog6.RestoreDirectory = true;

            if (openFileDialog6.ShowDialog() == DialogResult.OK)
            {

                E6.Text = openFileDialog6.FileName;
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            openFileDialog6.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog6.Filter = "Documentos (*.docx)|*.docx|Todos los archivos (*.*)|*.*";
            openFileDialog6.FilterIndex = 1;
            openFileDialog6.RestoreDirectory = true;

            if (openFileDialog6.ShowDialog() == DialogResult.OK)
            {

                E6.Text = openFileDialog6.FileName;
            }
           
=======
            openFileDialog7.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog7.Filter = "Documentos (*.docx)|*.docx|Todos los archivos (*.*)|*.*";
            openFileDialog7.FilterIndex = 1;
            openFileDialog7.RestoreDirectory = true;

            if (openFileDialog7.ShowDialog() == DialogResult.OK)
            {

                E7.Text = openFileDialog7.FileName;
            }
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (VerificadoCorrecto())
            {
                try {
                datos.IdGrupo = Convert.ToInt32(txtIDGrupo.Text);
                datos.NoUnidad = Convert.ToInt32(cmbUnidad.Text);
                    if (!registro.ExisteEvidenciasUnidad(datos.IdGrupo, datos.NoUnidad))
                    {
                        MessageBox.Show("Ya existen evidencias de esta unidad");
                    }
                    else
                    {
                        byte[] file1 = null;
                        byte[] file2 = null;
                        byte[] file3 = null;
                        byte[] file4 = null;
                        byte[] file5 = null;
                        byte[] file6 = null;
                        byte[] file7 = null;
                        Stream myStream1 = openFileDialog1.OpenFile();
                        Stream myStream2 = openFileDialog2.OpenFile();
                        Stream myStream3 = openFileDialog3.OpenFile();
                        Stream myStream4 = openFileDialog4.OpenFile();
                        Stream myStream5 = openFileDialog5.OpenFile();
                        Stream myStream6 = openFileDialog6.OpenFile();
                        Stream myStream7 = openFileDialog7.OpenFile();
<<<<<<< HEAD
                        datos.Ruta1 = openFileDialog1.FileName;
                        datos.Ruta2 = openFileDialog2.FileName;
                        datos.Ruta3 = openFileDialog3.FileName;
                        datos.Ruta4 = openFileDialog4.FileName;
                        datos.Ruta5 = openFileDialog5.FileName;
                        datos.Ruta6 = openFileDialog6.FileName;
                        datos.Ruta7 = openFileDialog7.FileName;

=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
                        using (MemoryStream ms = new MemoryStream())
                        {
                            myStream1.CopyTo(ms);
                            file1 = ms.ToArray();
                            datos.File1 = file1;
                        }
                        using (MemoryStream ms2 = new MemoryStream())
                        {
                            myStream2.CopyTo(ms2);
                            file2 = ms2.ToArray();
                            datos.File2 = file2;
                        }
                        using (MemoryStream ms3 = new MemoryStream())
                        {
                            myStream3.CopyTo(ms3);
                            file3 = ms3.ToArray();
                            datos.File3 = file3;
                        }
                        using (MemoryStream ms4 = new MemoryStream())
                        {
                            myStream4.CopyTo(ms4);
                            file4 = ms4.ToArray();
                            datos.File4 = file4;
                        }
                        using (MemoryStream ms5 = new MemoryStream())
                        {
                            myStream5.CopyTo(ms5);
                            file5 = ms5.ToArray();
                            datos.File5 = file5;
                        }
                        using (MemoryStream ms6 = new MemoryStream())
                        {
                            myStream6.CopyTo(ms6);
                            file6 = ms6.ToArray();
                            datos.File6 = file6;
                        }
                        using (MemoryStream ms7 = new MemoryStream())
                        {
                            myStream7.CopyTo(ms7);
                            file7 = ms7.ToArray();
                            datos.File7 = file7;
                        }
                        if (txtComent.Text.Equals(""))
                        {
                            datos.Comentario = "S/C";
                        }
                        else
                        {
                            datos.Comentario = txtComent.Text;
                        }
                        puente.AñadirEvidencias(datos);
<<<<<<< HEAD
                        Limpiar();
=======

>>>>>>> 80c648b... Commit 9 registro de las planeaciones
                    }

                }
                catch(Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

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
<<<<<<< HEAD

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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVer1_Click(object sender, EventArgs e)
        {//Los archivos se guardan en la carpeta bin\debug
            FileInfo fi = new FileInfo(datos.Ruta1);
            var nombre = fi.Name;
            File.WriteAllBytes(nombre, datos.File1);
           
        }

        private void btnVer2_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(datos.Ruta2);
            var nombre = fi.Name;
            File.WriteAllBytes(nombre, datos.File2);
        }

        private void btnVer3_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(datos.Ruta3);
            var nombre = fi.Name;
            File.WriteAllBytes(nombre, datos.File3);
        }

        private void btnVer4_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(datos.Ruta4);
            var nombre = fi.Name;
            File.WriteAllBytes(nombre, datos.File4);
        }

        private void btnVer5_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(datos.Ruta5);
            var nombre = fi.Name;
            File.WriteAllBytes(nombre, datos.File5);
        }

        private void btnVer6_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(datos.Ruta6);
            var nombre = fi.Name;
            File.WriteAllBytes(nombre, datos.File6);
        }

        private void btnVer7_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(datos.Ruta7);
            var nombre = fi.Name;
            File.WriteAllBytes(nombre, datos.File7);
        }

        private void btnModi_Click(object sender, EventArgs e)
        {
            if (VerificadoCorrecto())
            {
                try
                {
                    datos.IdGrupo = Convert.ToInt32(txtIDGrupo.Text);
                    datos.NoUnidad = Convert.ToInt32(cmbUnidad.Text);
                    if (registro.ExisteEvidenciasUnidad(datos.IdGrupo, datos.NoUnidad))
                    {
                        MessageBox.Show("No existen evidencias de esta unidad");
                    }
                    else
                    {
                        byte[] file1 = null;
                        byte[] file2 = null;
                        byte[] file3 = null;
                        byte[] file4 = null;
                        byte[] file5 = null;
                        byte[] file6 = null;
                        byte[] file7 = null;
                        Stream myStream1 = openFileDialog1.OpenFile();
                        Stream myStream2 = openFileDialog2.OpenFile();
                        Stream myStream3 = openFileDialog3.OpenFile();
                        Stream myStream4 = openFileDialog4.OpenFile();
                        Stream myStream5 = openFileDialog5.OpenFile();
                        Stream myStream6 = openFileDialog6.OpenFile();
                        Stream myStream7 = openFileDialog7.OpenFile();
                        datos.Ruta1 = openFileDialog1.FileName;
                        datos.Ruta2 = openFileDialog2.FileName;
                        datos.Ruta3 = openFileDialog3.FileName;
                        datos.Ruta4 = openFileDialog4.FileName;
                        datos.Ruta5 = openFileDialog5.FileName;
                        datos.Ruta6 = openFileDialog6.FileName;
                        datos.Ruta7 = openFileDialog7.FileName;

                        using (MemoryStream ms = new MemoryStream())
                        {
                            myStream1.CopyTo(ms);
                            file1 = ms.ToArray();
                            datos.File1 = file1;
                        }
                        using (MemoryStream ms2 = new MemoryStream())
                        {
                            myStream2.CopyTo(ms2);
                            file2 = ms2.ToArray();
                            datos.File2 = file2;
                        }
                        using (MemoryStream ms3 = new MemoryStream())
                        {
                            myStream3.CopyTo(ms3);
                            file3 = ms3.ToArray();
                            datos.File3 = file3;
                        }
                        using (MemoryStream ms4 = new MemoryStream())
                        {
                            myStream4.CopyTo(ms4);
                            file4 = ms4.ToArray();
                            datos.File4 = file4;
                        }
                        using (MemoryStream ms5 = new MemoryStream())
                        {
                            myStream5.CopyTo(ms5);
                            file5 = ms5.ToArray();
                            datos.File5 = file5;
                        }
                        using (MemoryStream ms6 = new MemoryStream())
                        {
                            myStream6.CopyTo(ms6);
                            file6 = ms6.ToArray();
                            datos.File6 = file6;
                        }
                        using (MemoryStream ms7 = new MemoryStream())
                        {
                            myStream7.CopyTo(ms7);
                            file7 = ms7.ToArray();
                            datos.File7 = file7;
                        }
                        if (txtComent.Text.Equals(""))
                        {
                            datos.Comentario = "S/C";
                        }
                        else
                        {
                            datos.Comentario = txtComent.Text;
                        }
                        puente.ModificarEvidencias(datos);
                        Limpiar();
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
            if (cmbUnidad.Text != "")
            {
                try
                {
                    datos.NoUnidad = Int32.Parse(cmbUnidad.Text);
                    datos.IdGrupo = Convert.ToInt32(txtIDGrupo.Text);
                    if (!registro.ExisteEvidenciasUnidad(datos.IdGrupo,datos.NoUnidad))
                    {
                        var n = MessageBox.Show("¿Está seguro que desea eliminar las evidencias de la unidad " + datos.NoUnidad + "?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                        if (n == DialogResult.Yes)
                        {
                            puente.EliminarEvidencias(datos);
                            Limpiar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay evidencias de esta unidad");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

            }
            else
            {
                MessageBox.Show("Seleccione la unidad");
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

        }
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
    }
}
