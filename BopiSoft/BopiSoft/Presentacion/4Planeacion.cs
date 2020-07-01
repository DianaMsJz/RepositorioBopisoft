using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
=======
using BopiSoft.Datos;
using BopiSoft.Negocios;
using BopiSoft.Presentacion;

>>>>>>> 80c648b... Commit 9 registro de las planeaciones

namespace BopiSoft
{
    public partial class Planeacion : Form
    {
<<<<<<< HEAD
        public Planeacion()
        {
            InitializeComponent();
=======
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

            NombreMateria =MateriaDatos.Nombre;
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

            txtNombreMateria.Text =NombreMateria;
            txtNombreDocente.Text = NombreDocente;
            txtCompetenciaMat.Text = CompetenciaMateria;
            txtCaracterizacion.Text = Caracterizacion;
            txtIDGrupo.Text = IDGrupo;
            txtIdDocente.Text = ""+IdDocente;

            cmbUnidad.SelectedIndex = 0;
            Unidad = Convert.ToInt32(cmbUnidad.SelectedItem.ToString());
            MateriaContenidoDatos.IdMateria = IdMateria;
            MateriaContenidoDatos.Unidad = Unidad;
            MateriaContenidoPuente.RegistroBuscarContenido(MateriaContenidoDatos);

            TemarioUnidad = MateriaContenidoDatos.SubtemaUnidad;
            txtTemario.Text = TemarioUnidad;

           


>>>>>>> 80c648b... Commit 9 registro de las planeaciones
        }

        private void Planeacion_Load(object sender, EventArgs e)
        {

        }
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

        public Boolean VerificadoCorrecto()
        {
            Boolean v;
            if (txtNombreDocente.Text.Equals("") || cmbUnidad.Text.Equals("") || txtCompetenciaMat.Text.Equals("") || txtCaracterizacion.Text.Equals("") || 
                txtVisitas.Text.Equals("") ||  txtHrP.Text.Equals("") || txtHrT.Text.Equals("") ||
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
            
        }

        private void cmbUnidad_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
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

                     txtCompetenciaMat.Text = PlaneacionDatos.CompetenciaMat;
                    txtCaracterizacion.Text = PlaneacionDatos.Caracterizacion;
                    txtTemario.Text = PlaneacionDatos.TemarioUnidad;
                    txtActAprendizaje.Text = PlaneacionDatos.ActAprendizaje;

                    txtHrT.Text = PlaneacionDatos.HrsTeoria.ToString();
                    txtHrP.Text = PlaneacionDatos.HrsPractica.ToString();
                    txtSesiones.Text = PlaneacionDatos.SesionesEst.ToString();
                    dateFechaExamen.Value = PlaneacionDatos.FechaExam;

                     txtVisitas.Text = PlaneacionDatos.Visitas;
                    txtPracticas.Text = PlaneacionDatos.Practicas ;
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
                MessageBox.Show("ERROR ESCRIBA UNA ID");
            }

        }

        private void txtModificar_Click(object sender, EventArgs e)
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

        }

        private void txtEliminar_Click(object sender, EventArgs e)
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
    }
}
