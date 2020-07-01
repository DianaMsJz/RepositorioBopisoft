<<<<<<< HEAD
﻿using System;
=======
﻿using BopiSoft.Datos;
using BopiSoft.Negocios;
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
<<<<<<< HEAD
<<<<<<< HEAD
=======
using BopiSoft.Datos;
using BopiSoft.Negocios;
using BopiSoft.Presentacion;

>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)

namespace BopiSoft
{
    public partial class Planeacion : Form
    {
<<<<<<< HEAD
<<<<<<< HEAD
        public Planeacion()
        {
            InitializeComponent();
=======
=======
        BDConexion bd = new BDConexion();

>>>>>>> 031b574... Proyecto completo (Versión Final)
        PuentePlaneacion PlaneacionPuente = new PuentePlaneacion();
        PuenteMaterias MateriaPuente = new PuenteMaterias();
        PuenteMaterias MateriaContenidoPuente = new PuenteMaterias();
        PuenteGrupo GrupoPuente = new PuenteGrupo();
        PuentePersonal DocentePuente = new PuentePersonal();


        DatosPlaneaciones PlaneacionDatos = new DatosPlaneaciones();
        DatosMaterias MateriaDatos = new DatosMaterias();
        DatosGrupos GrupoDatos = new DatosGrupos();
        DatosPersonal DocenteDatos = new DatosPersonal();
        DatosMaterias MateriaContenidoDatos = new DatosMaterias();
<<<<<<< HEAD

=======
        RegistroMateriaSql RegistroMateria = new RegistroMateriaSql();
>>>>>>> 031b574... Proyecto completo (Versión Final)
        RegistroPlaneacion RegistrarPlaneacion = new RegistroPlaneacion();

        int s = 1;


        string IDGrupo;
        int IdMateria;
        string NombreMateria;
        int IdDocente;
        string NombreDocente;
        int Unidad;
        string CompetenciaMateria;
        string Caracterizacion;
        string TemarioUnidad;
        string CompetenciaUnidad;
        string ActividadAprendizaje;

        public Planeacion(string iDGrupo, int idMateria, int idDocente)
        {
            InitializeComponent();
            this.IDGrupo = iDGrupo;
            this.IdMateria = idMateria;
            this.IdDocente = idDocente;

            dateFechaExamen.MinDate = DateTime.Today;

            //Buscamos los campos que nos faltan con cada uno de los ID campos clave (IdGrupo, IdMateria,IdDocente)
            MateriaDatos.IdMateria = Int32.Parse(this.IDGrupo);
            MateriaPuente.RegistroBuscar(MateriaDatos);

<<<<<<< HEAD
            NombreMateria =MateriaDatos.Nombre;
=======
            NombreMateria = MateriaDatos.Nombre;
>>>>>>> 031b574... Proyecto completo (Versión Final)
            CompetenciaMateria = MateriaDatos.Competencia;
            Caracterizacion = MateriaDatos.Caracterizacion;

            DocenteDatos.IdPersonal = IdDocente;
            DocentePuente.RegistroBuscar(DocenteDatos);
            NombreDocente = "" + DocenteDatos.Nombre + " " + DocenteDatos.Apaterno + " " + DocenteDatos.Amaterno;

            //UNIDADES RELLENAR
            MateriaPuente.RegistroBuscar(MateriaDatos);
            if (s == 1)
            {
                for (int i = 0; i < MateriaDatos.Unidades; i++)
                {
                    cmbUnidad.Items.Insert(i, i + 1);
                }
                s++;
            }

<<<<<<< HEAD
            txtNombreMateria.Text =NombreMateria;
=======
            txtNombreMateria.Text = NombreMateria;
>>>>>>> 031b574... Proyecto completo (Versión Final)
            txtNombreDocente.Text = NombreDocente;
            txtCompetenciaMat.Text = CompetenciaMateria;
            txtCaracterizacion.Text = Caracterizacion;
            txtIDGrupo.Text = IDGrupo;
<<<<<<< HEAD
            txtIdDocente.Text = ""+IdDocente;
=======
            txtIdDocente.Text = "" + IdDocente;
>>>>>>> 031b574... Proyecto completo (Versión Final)

            cmbUnidad.SelectedIndex = 0;
            Unidad = Convert.ToInt32(cmbUnidad.SelectedItem.ToString());
            MateriaContenidoDatos.IdMateria = IdMateria;
            MateriaContenidoDatos.Unidad = Unidad;
<<<<<<< HEAD
            MateriaContenidoPuente.RegistroBuscarContenido(MateriaContenidoDatos);
=======
            MateriaContenidoPuente.BuscarContenido(MateriaContenidoDatos);
>>>>>>> 031b574... Proyecto completo (Versión Final)

            TemarioUnidad = MateriaContenidoDatos.SubtemaUnidad;
            txtTemario.Text = TemarioUnidad;

<<<<<<< HEAD
           


>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======



>>>>>>> 031b574... Proyecto completo (Versión Final)
        }

        private void Planeacion_Load(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD
<<<<<<< HEAD
=======

        private void cmbUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTemario.Text = "";
            Unidad = Convert.ToInt32(cmbUnidad.SelectedItem.ToString());
           
            MateriaContenidoDatos.IdMateria = IdMateria;
            MateriaContenidoDatos.Unidad = Unidad;
            MateriaContenidoPuente.RegistroBuscarContenido(MateriaContenidoDatos);

            TemarioUnidad = MateriaContenidoDatos.SubtemaUnidad;
            txtTemario.Text = TemarioUnidad;
           

        }
=======

        
>>>>>>> 031b574... Proyecto completo (Versión Final)

        public Boolean VerificadoCorrecto()
        {
            Boolean v;
<<<<<<< HEAD
            if (txtNombreDocente.Text.Equals("") || cmbUnidad.Text.Equals("") || txtCompetenciaMat.Text.Equals("") || txtCaracterizacion.Text.Equals("") || 
                txtVisitas.Text.Equals("") ||  txtHrP.Text.Equals("") || txtHrT.Text.Equals("") ||
=======
            if (txtNombreDocente.Text.Equals("") || cmbUnidad.Text.Equals("") || txtCompetenciaMat.Text.Equals("") || txtCaracterizacion.Text.Equals("") ||
                txtVisitas.Text.Equals("") || txtHrP.Text.Equals("") || txtHrT.Text.Equals("") ||
>>>>>>> 031b574... Proyecto completo (Versión Final)
                txtPracticas.Text.Equals("") || txtSesiones.Text.Equals("") || txtActAprendizaje.Text.Equals("") || txtactEnse.Text.Equals("") || txtTemario.Text.Equals("") || txtRecursos.Text.Equals("") || txtIDplaneacion.Text.Equals(""))
            {
                //MessageBox.Show("HAY CAMPOS VACIOS POR FAVOR VERIFIQUE");
                v = false;
            }
            else
            {
                v = true;
            }
            return v;
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtTemario_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            
=======

>>>>>>> 031b574... Proyecto completo (Versión Final)
        }

        private void cmbUnidad_SelectedValueChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
           
=======

>>>>>>> 031b574... Proyecto completo (Versión Final)
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (VerificadoCorrecto())
            {
                try
                {
                    PlaneacionDatos.IdPlaneacion = Int32.Parse(txtIDplaneacion.Text);
                    if (!RegistrarPlaneacion.ExisteRegistro(PlaneacionDatos.IdPlaneacion))
                    {
                        MessageBox.Show("Ya existe un registro con esa ID");
                    }
                    else
                    {
                        


                        PlaneacionDatos.IdPlaneacion = Convert.ToInt32(txtIDplaneacion.Text);
                        PlaneacionDatos.IdGrupo = Convert.ToInt32(txtIDGrupo.Text);
                        PlaneacionDatos.NombreMateria = txtNombreMateria.Text;
                        PlaneacionDatos.IDdocente = Convert.ToInt32(txtIdDocente.Text);
                        PlaneacionDatos.NombreDocente = txtNombreDocente.Text;
                        PlaneacionDatos.Unidad = Convert.ToInt32(cmbUnidad.Text);
                        PlaneacionDatos.CompetenciaMat = txtCompetenciaMat.Text;
                        PlaneacionDatos.Caracterizacion = txtCaracterizacion.Text;
                        PlaneacionDatos.TemarioUnidad = txtTemario.Text;
                        PlaneacionDatos.ActAprendizaje = txtActAprendizaje.Text;
                        PlaneacionDatos.HrsTeoria = Convert.ToInt32(txtHrT.Text);
                        PlaneacionDatos.HrsPractica = Convert.ToInt32(txtHrP.Text);
                        PlaneacionDatos.SesionesEst = Convert.ToInt32(txtSesiones.Text);
                        PlaneacionDatos.FechaExam = dateFechaExamen.Value.Date;
                        PlaneacionDatos.Visitas = txtVisitas.Text;
                        PlaneacionDatos.Practicas = txtPracticas.Text;
                        PlaneacionDatos.ActEnseñanza = txtactEnse.Text;
                        PlaneacionDatos.Recursos = txtRecursos.Text;
                        PlaneacionPuente.AñadirPlaneacion(PlaneacionDatos);
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

        private void btnBuscarClave_Click(object sender, EventArgs e)
=======

        }



        private void txtModificar_Click(object sender, EventArgs e)
        {

        }

        private void txtEliminar_Click(object sender, EventArgs e)
        {

        }

        public void Limpiar()
        {
            txtIDplaneacion.Text = "";
            dateFechaExamen.Value = DateTime.Today.Date;
            txtVisitas.Text = "";
            txtPracticas.Text = "";
            txtHrP.Text = "";
            txtHrT.Text = "";
            txtSesiones.Text = "";
            txtActAprendizaje.Text = "";
            txtactEnse.Text = "";
            txtTemario.Text = "";
            txtRecursos.Text = "";

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            bd.connecttodb();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM lista_personal WHERE IdPersonal='" + IdDocente + "' ", bd.connect);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                DocenteDatos.IdPersonal = IdDocente;
                DocentePuente.RegistroBuscar(DocenteDatos);
                string NombreDoc = DocenteDatos.Nombre;
                string MaternoDoc = DocenteDatos.Amaterno;
                String PaternoDoc = DocenteDatos.Apaterno;
                string Area = DocenteDatos.NombreDpto;
                byte[] Foto = DocenteDatos.Foto;

                this.Hide();
                _2MenuDocente MenuDocenteObj = new _2MenuDocente(IdDocente.ToString(), NombreDoc, PaternoDoc, MaternoDoc, Area, Foto);
                MenuDocenteObj.Show();
            }
        }

        private void btnBuscarClave_Click_1(object sender, EventArgs e)
>>>>>>> 031b574... Proyecto completo (Versión Final)
        {
            if (txtIDplaneacion.Text != "")
            {
                try
                {
                    PlaneacionDatos.IdPlaneacion = Convert.ToInt32(txtIDplaneacion.Text);
                    PlaneacionPuente.PlaneacionBuscar(PlaneacionDatos);


                    //txtIDplaneacion.Text = PlaneacionDatos.IdPlaneacion.ToString();
                    txtIDGrupo.Text = PlaneacionDatos.IdGrupo.ToString();

                    txtNombreMateria.Text = PlaneacionDatos.NombreMateria;

                    txtIdDocente.Text = PlaneacionDatos.IDdocente.ToString();
                    txtNombreDocente.Text = PlaneacionDatos.NombreDocente.ToString();

                    cmbUnidad.Text = PlaneacionDatos.Unidad.ToString();

<<<<<<< HEAD
                     txtCompetenciaMat.Text = PlaneacionDatos.CompetenciaMat;
=======
                    txtCompetenciaMat.Text = PlaneacionDatos.CompetenciaMat;
>>>>>>> 031b574... Proyecto completo (Versión Final)
                    txtCaracterizacion.Text = PlaneacionDatos.Caracterizacion;
                    txtTemario.Text = PlaneacionDatos.TemarioUnidad;
                    txtActAprendizaje.Text = PlaneacionDatos.ActAprendizaje;

                    txtHrT.Text = PlaneacionDatos.HrsTeoria.ToString();
                    txtHrP.Text = PlaneacionDatos.HrsPractica.ToString();
                    txtSesiones.Text = PlaneacionDatos.SesionesEst.ToString();
                    dateFechaExamen.Value = PlaneacionDatos.FechaExam;

<<<<<<< HEAD
                     txtVisitas.Text = PlaneacionDatos.Visitas;
                    txtPracticas.Text = PlaneacionDatos.Practicas ;
                     txtactEnse.Text = PlaneacionDatos.ActEnseñanza;
                     txtRecursos.Text = PlaneacionDatos.Recursos;
=======
                    txtVisitas.Text = PlaneacionDatos.Visitas;
                    txtPracticas.Text = PlaneacionDatos.Practicas;
                    txtactEnse.Text = PlaneacionDatos.ActEnseñanza;
                    txtRecursos.Text = PlaneacionDatos.Recursos;
>>>>>>> 031b574... Proyecto completo (Versión Final)





                }
                catch (Exception ex)
                {
                    MessageBox.Show("Algo salió mal " + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("ERROR ESCRIBA UNA ID");
            }
<<<<<<< HEAD

        }

        private void txtModificar_Click(object sender, EventArgs e)
=======
        }

        private void txtEliminar_Click_1(object sender, EventArgs e)
        {

            if (txtIDplaneacion.Text != "")
            {
                try
                {
                    PlaneacionDatos.IdPlaneacion = Int32.Parse(txtIDplaneacion.Text);
                    if (!RegistrarPlaneacion.ExisteRegistro(PlaneacionDatos.IdPlaneacion))
                    {
                        var n = MessageBox.Show("¿Está seguro que desea eliminar el registro con la ID " + PlaneacionDatos.IdPlaneacion + "?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                        if (n == DialogResult.Yes)
                        {
                            PlaneacionPuente.PlaneacionEliminar(PlaneacionDatos);
                            Limpiar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay registros con esa ID");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

            }
            else
            {
                MessageBox.Show("Id planeacion no valido, ingrese uno valido porfavor");
            }
        }

        private void txtModificar_Click_1(object sender, EventArgs e)
>>>>>>> 031b574... Proyecto completo (Versión Final)
        {
            if (VerificadoCorrecto())
            {
                try
                {
                    PlaneacionDatos.IdPlaneacion = Int32.Parse(txtIDplaneacion.Text);
                    if (!RegistrarPlaneacion.ExisteRegistro(PlaneacionDatos.IdPlaneacion))
                    {




                        PlaneacionDatos.IdPlaneacion = Convert.ToInt32(txtIDplaneacion.Text);
                        PlaneacionDatos.IdGrupo = Convert.ToInt32(txtIDGrupo.Text);
                        PlaneacionDatos.NombreMateria = txtNombreMateria.Text;
                        PlaneacionDatos.IDdocente = Convert.ToInt32(txtIdDocente.Text);
                        PlaneacionDatos.NombreDocente = txtNombreDocente.Text;
                        PlaneacionDatos.Unidad = Convert.ToInt32(cmbUnidad.Text);
                        PlaneacionDatos.CompetenciaMat = txtCompetenciaMat.Text;
                        PlaneacionDatos.Caracterizacion = txtCaracterizacion.Text;
                        PlaneacionDatos.TemarioUnidad = txtTemario.Text;
                        PlaneacionDatos.ActAprendizaje = txtActAprendizaje.Text;
                        PlaneacionDatos.HrsTeoria = Convert.ToInt32(txtHrT.Text);
                        PlaneacionDatos.HrsPractica = Convert.ToInt32(txtHrP.Text);
                        PlaneacionDatos.SesionesEst = Convert.ToInt32(txtSesiones.Text);
                        PlaneacionDatos.FechaExam = dateFechaExamen.Value.Date;
                        PlaneacionDatos.Visitas = txtVisitas.Text;
                        PlaneacionDatos.Practicas = txtPracticas.Text;
                        PlaneacionDatos.ActEnseñanza = txtactEnse.Text;
                        PlaneacionDatos.Recursos = txtRecursos.Text;

                        PlaneacionPuente.ModificarPlaneacion(PlaneacionDatos);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No existe registro con esa ID");

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
<<<<<<< HEAD

        }

        private void txtEliminar_Click(object sender, EventArgs e)
        {


            if (txtIDplaneacion.Text != "")
=======
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerificadoCorrecto())
>>>>>>> 031b574... Proyecto completo (Versión Final)
            {
                try
                {
                    PlaneacionDatos.IdPlaneacion = Int32.Parse(txtIDplaneacion.Text);
                    if (!RegistrarPlaneacion.ExisteRegistro(PlaneacionDatos.IdPlaneacion))
                    {
<<<<<<< HEAD
                        var n = MessageBox.Show("¿Está seguro que desea eliminar el registro con la ID " + PlaneacionDatos.IdPlaneacion + "?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                        if (n == DialogResult.Yes)
                        {
                            PlaneacionPuente.PlaneacionEliminar(PlaneacionDatos);
                            Limpiar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay registros con esa ID");
                    }

=======
                        MessageBox.Show("Ya existe un registro con esa ID");
                    }
                    else
                    {
                        PlaneacionDatos.IdPlaneacion = Convert.ToInt32(txtIDplaneacion.Text);
                        PlaneacionDatos.IdGrupo = Convert.ToInt32(txtIDGrupo.Text);
                        PlaneacionDatos.NombreMateria = txtNombreMateria.Text;
                        PlaneacionDatos.IDdocente = Convert.ToInt32(txtIdDocente.Text);
                        PlaneacionDatos.NombreDocente = txtNombreDocente.Text;
                        PlaneacionDatos.Unidad = Convert.ToInt32(cmbUnidad.Text);
                        PlaneacionDatos.CompetenciaMat = txtCompetenciaMat.Text;
                        PlaneacionDatos.Caracterizacion = txtCaracterizacion.Text;
                        PlaneacionDatos.TemarioUnidad = txtTemario.Text;
                        PlaneacionDatos.ActAprendizaje = txtActAprendizaje.Text;
                        PlaneacionDatos.HrsTeoria = Convert.ToInt32(txtHrT.Text);
                        PlaneacionDatos.HrsPractica = Convert.ToInt32(txtHrP.Text);
                        PlaneacionDatos.SesionesEst = Convert.ToInt32(txtSesiones.Text);
                        PlaneacionDatos.FechaExam = dateFechaExamen.Value.Date;
                        PlaneacionDatos.Visitas = txtVisitas.Text;
                        PlaneacionDatos.Practicas = txtPracticas.Text;
                        PlaneacionDatos.ActEnseñanza = txtactEnse.Text;
                        PlaneacionDatos.Recursos = txtRecursos.Text;
                        PlaneacionPuente.AñadirPlaneacion(PlaneacionDatos);
                        Limpiar();

                    }


>>>>>>> 031b574... Proyecto completo (Versión Final)
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
<<<<<<< HEAD
                }

            }
            else
            {
                MessageBox.Show("Id personal no valido, ingrese uno valido porfavor");
            }
        }

        public void Limpiar()
        {
            txtIDplaneacion.Text = "";
            dateFechaExamen.Value = DateTime.Today.Date;
            txtVisitas.Text = "";
            txtPracticas.Text = "";
            txtHrP.Text = "";
            txtHrT.Text = "";
            txtSesiones.Text = "";
            txtActAprendizaje.Text = "";
            txtactEnse.Text = "";
            txtTemario.Text = "";
            txtRecursos.Text = "";

        }


>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======

                }
            }
            else
            {
                MessageBox.Show("ERROR LLENE TODOS LOS CAMPOS");
            }
        }

        private void cmbUnidad_SelectedIndexChanged_1(object sender, EventArgs e)
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
>>>>>>> 031b574... Proyecto completo (Versión Final)
    }
}
