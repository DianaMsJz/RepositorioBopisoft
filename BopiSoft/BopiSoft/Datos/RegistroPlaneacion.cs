using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BopiSoft.Datos
{
    class RegistroPlaneacion
    {
        BDConexion bd = new BDConexion();

        public void LlenarComboBoxUnidad(ComboBox combo)
        {
            MySqlCommand buscarporID = new MySqlCommand("select * from planeacion", bd.connect);
            bd.connecttodb();
            MySqlDataReader registro = buscarporID.ExecuteReader();
            while (registro.Read())
            {
                combo.Items.Add(registro["Unidades"]);
            }
            combo.SelectedIndex = 0;
            bd.closeconnection();
        }

      

        public bool ExisteRegistro(int ID)
        {
            bd.connecttodb();
            string existe = "Select count(*) from planeacion where IdPlaneacion=@IdPlaneacion";
            bd.command = new MySqlCommand(existe, bd.connect);
            bd.command.Parameters.AddWithValue("@IdPlaneacion", ID);

            int count = Convert.ToInt32(bd.command.ExecuteScalar());

            return count == 0;
        }

        public void AñadirPlaneacion(DatosPlaneaciones datos)
        {

            try
            {
                bd.connecttodb();
                string añadir = "insert into planeacion(IdPlaneacion, IdGrupo, NombreMateria, IDdocente, NombreDocente, Unidad, CompetenciaMat, Caracterizacion, TemarioUnidad, ActAprendizaje, HrsTeoria, HrsPractica, SesionesEst, FechaExam, Visitas, Practicas, ActEnseñanza, Recursos) values (@IdPlaneacion, @IdGrupo, @NombreMateria, @IDdocente, @NombreDocente, @Unidad, @CompetenciaMat, @Caracterizacion, @TemarioUnidad, @ActAprendizaje, @HrsTeoria, @HrsPractica, @SesionesEst, @FechaExam, @Visitas, @Practicas, @ActEnseñanza, @Recursos)";

                bd.command = new MySqlCommand(añadir, bd.connect);
                bd.command.Parameters.AddWithValue("@IdPlaneacion", datos.@IdPlaneacion);
                bd.command.Parameters.AddWithValue("@IdGrupo", datos.IdGrupo);
                bd.command.Parameters.AddWithValue("@NombreMateria", datos.NombreMateria);
                bd.command.Parameters.AddWithValue("@IDdocente", datos.IDdocente);
                bd.command.Parameters.AddWithValue("@NombreDocente", datos.NombreDocente);
                bd.command.Parameters.AddWithValue("@Unidad", datos.Unidad);
                bd.command.Parameters.AddWithValue("@CompetenciaMat", datos.CompetenciaMat);
                bd.command.Parameters.AddWithValue("@Caracterizacion", datos.Caracterizacion);
                bd.command.Parameters.AddWithValue("@TemarioUnidad", datos.TemarioUnidad);
                bd.command.Parameters.AddWithValue("@ActAprendizaje", datos.ActAprendizaje);
                bd.command.Parameters.AddWithValue("@HrsTeoria", datos.HrsTeoria);
                bd.command.Parameters.AddWithValue("@HrsPractica", datos.HrsPractica);
                bd.command.Parameters.AddWithValue("@SesionesEst", datos.SesionesEst);
                bd.command.Parameters.AddWithValue("@FechaExam", datos.FechaExam);
                bd.command.Parameters.AddWithValue("@Visitas", datos.Visitas);
                bd.command.Parameters.AddWithValue("@Practicas", datos.Practicas);
                bd.command.Parameters.AddWithValue("@ActEnseñanza", datos.ActEnseñanza);
                bd.command.Parameters.AddWithValue("@Recursos", datos.Recursos);

                int cant;
                cant = bd.command.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Evidencias añadidas con exito");
                }
                else
                {
                    MessageBox.Show("Algo salió mal");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void ModificarPlaneacion(DatosPlaneaciones datos)
        {
            try
            {
                bd.connecttodb();
                string actualizar = "update planeacion set  IdPlaneacion=@IdPlaneacion, IdGrupo=@IdGrupo, NombreMateria=@NombreMateria, IDdocente=@IDdocente, NombreDocente=@NombreDocente, Unidad=@Unidad, CompetenciaMat=@CompetenciaMat, Caracterizacion=@Caracterizacion, TemarioUnidad=@TemarioUnidad, ActAprendizaje=@ActAprendizaje, HrsTeoria=@HrsTeoria, HrsPractica=@HrsPractica, SesionesEst=@SesionesEst, FechaExam=@FechaExam, Visitas=@Visitas, Practicas=@Practicas, ActEnseñanza=@ActEnseñanza, Recursos=@Recursos  where IdPlaneacion=" + datos.IdPlaneacion;

                bd.command = new MySqlCommand(actualizar, bd.connect);
                bd.command.Parameters.AddWithValue("@IdPlaneacion", datos.IdPlaneacion);
                bd.command.Parameters.AddWithValue("@IdGrupo", datos.IdGrupo);
                bd.command.Parameters.AddWithValue("@NombreMateria", datos.NombreMateria);
                bd.command.Parameters.AddWithValue("@IDdocente", datos.IDdocente);
                bd.command.Parameters.AddWithValue("@NombreDocente", datos.NombreDocente);
                bd.command.Parameters.AddWithValue("@Unidad", datos.Unidad);
                bd.command.Parameters.AddWithValue("@CompetenciaMat", datos.CompetenciaMat);
                bd.command.Parameters.AddWithValue("@Caracterizacion", datos.Caracterizacion);
                bd.command.Parameters.AddWithValue("@TemarioUnidad", datos.TemarioUnidad);
                bd.command.Parameters.AddWithValue("@ActAprendizaje", datos.ActAprendizaje);
                bd.command.Parameters.AddWithValue("@HrsTeoria", datos.HrsTeoria);
                bd.command.Parameters.AddWithValue("@HrsPractica", datos.HrsPractica);
                bd.command.Parameters.AddWithValue("@SesionesEst", datos.SesionesEst);
                bd.command.Parameters.AddWithValue("@FechaExam", datos.FechaExam);
                bd.command.Parameters.AddWithValue("@Visitas", datos.Visitas);
                bd.command.Parameters.AddWithValue("@Practicas", datos.Practicas);
                bd.command.Parameters.AddWithValue("@ActEnseñanza", datos.ActEnseñanza);
                bd.command.Parameters.AddWithValue("@Recursos", datos.Recursos);

                int cant;
                cant = bd.command.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Planeacion modificada con exito");
                }
                else
                {
                    MessageBox.Show("Algo salió mal");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void PlaneacionBuscar(DatosPlaneaciones datos)
        {
            MySqlCommand buscarporID = new MySqlCommand("select * from planeacion where IdPlaneacion=@IdPlaneacion", bd.connect);
            buscarporID.Parameters.AddWithValue("@IdPlaneacion", datos.IdPlaneacion);
            bd.connecttodb();
            MySqlDataReader registro = buscarporID.ExecuteReader();
            if (registro.Read())
            {
                datos.IdGrupo = Convert.ToInt32(registro[1]);
                datos.NombreMateria = registro[2].ToString();
                datos.IDdocente = Convert.ToInt32(registro[3]);
                datos.NombreDocente = registro[4].ToString();
                datos.Unidad = Convert.ToInt32(registro[5]);
                datos.CompetenciaMat = registro[6].ToString();
                datos.Caracterizacion = registro[7].ToString();
                datos.TemarioUnidad = registro[8].ToString();
                datos.ActAprendizaje = registro[9].ToString();
                datos.HrsTeoria = Convert.ToInt32(registro[10]);
                datos.HrsPractica = Convert.ToInt32(registro[11]);
                datos.SesionesEst = Convert.ToInt32(registro[12]);
                datos.FechaExam = Convert.ToDateTime(registro[13]);
                datos.Visitas = registro[14].ToString();
                datos.Practicas = registro[15].ToString();
                datos.ActEnseñanza = registro[16].ToString();
                datos.Recursos = registro[17].ToString();





            }

            bd.closeconnection();
        }

        public void PlaneacionEliminar(DatosPlaneaciones datos)
        {

            string eliminar = "delete from planeacion where IdPlaneacion=" + datos.IdPlaneacion;

            if (bd.executecommand(eliminar))
            {

                MessageBox.Show("Planeacion eliminada con exito!");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar, intente de nuevo");
            }
        }
    }
}
    

