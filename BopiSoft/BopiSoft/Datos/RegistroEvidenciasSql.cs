using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BopiSoft.Datos
{
    class RegistroEvidenciasSql
    {
        BDConexion bd = new BDConexion();

        public bool ExisteEvidenciasUnidad(int IdGrupo, int NoUnidad)
        {
            bd.connecttodb();
            string existe = "Select count(*) from evidencia where IdGrupo=@IdGrupo and Unidad=@Unidad";
            bd.command = new MySqlCommand(existe, bd.connect);
            bd.command.Parameters.AddWithValue("@IdGrupo", IdGrupo);
            bd.command.Parameters.AddWithValue("@Unidad", NoUnidad);
            int count = Convert.ToInt32(bd.command.ExecuteScalar());
            return count == 0;
        }

        public void AñadirEvidencia(DatosEvidencias datos)
        {
            try
            {
                bd.connecttodb();
<<<<<<< HEAD
<<<<<<< HEAD
                string añadir = "insert into evidencia(IdGrupo,Unidad,Ruta1,Archivo1,Ruta2,Archivo2,Ruta3,Archivo3,Ruta4,Archivo4,Ruta5,Archivo5,Ruta6,Archivo6,Ruta7,Archivo7,Comentario) values (@IdGrupo, @Unidad,@Ruta1, @Archivo1,@Ruta2, @Archivo2,@Ruta3, @Archivo3,@Ruta4, @Archivo4,@Ruta5, @Archivo5,@Ruta6, @Archivo6,@Ruta7, @Archivo7, @Comentario)";
=======
                string añadir = "insert into evidencia(IdGrupo,Unidad,Archivo1,Archivo2,Archivo3,Archivo4,Archivo5,Archivo6,Archivo7,Comentario) values (@IdGrupo, @Unidad, @Archivo1, @Archivo2, @Archivo3, @Archivo4, @Archivo5, @Archivo6, @Archivo7, @Comentario)";
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
                string añadir = "insert into evidencia(IdGrupo,Unidad,Ruta1,Archivo1,Ruta2,Archivo2,Ruta3,Archivo3,Ruta4,Archivo4,Ruta5,Archivo5,Ruta6,Archivo6,Ruta7,Archivo7,Comentario) values (@IdGrupo, @Unidad,@Ruta1, @Archivo1,@Ruta2, @Archivo2,@Ruta3, @Archivo3,@Ruta4, @Archivo4,@Ruta5, @Archivo5,@Ruta6, @Archivo6,@Ruta7, @Archivo7, @Comentario)";
>>>>>>> 031b574... Proyecto completo (Versión Final)

                bd.command = new MySqlCommand(añadir, bd.connect);
                bd.command.Parameters.AddWithValue("@IdGrupo", datos.IdGrupo);
                bd.command.Parameters.AddWithValue("@Unidad", datos.NoUnidad);
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
                bd.command.Parameters.AddWithValue("@Ruta1", datos.Ruta1);
                bd.command.Parameters.AddWithValue("@Ruta2", datos.Ruta2);
                bd.command.Parameters.AddWithValue("@Ruta3", datos.Ruta3);
                bd.command.Parameters.AddWithValue("@Ruta4", datos.Ruta4);
                bd.command.Parameters.AddWithValue("@Ruta5", datos.Ruta5);
                bd.command.Parameters.AddWithValue("@Ruta6", datos.Ruta6);
                bd.command.Parameters.AddWithValue("@Ruta7", datos.Ruta7);
<<<<<<< HEAD
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
                bd.command.Parameters.AddWithValue("@Archivo1", datos.File1);
                bd.command.Parameters.AddWithValue("@Archivo2", datos.File2);
                bd.command.Parameters.AddWithValue("@Archivo3", datos.File3);
                bd.command.Parameters.AddWithValue("@Archivo4", datos.File4);
                bd.command.Parameters.AddWithValue("@Archivo5", datos.File5);
                bd.command.Parameters.AddWithValue("@Archivo6", datos.File6);
                bd.command.Parameters.AddWithValue("@Archivo7", datos.File7);
                bd.command.Parameters.AddWithValue("@Comentario", datos.Comentario);


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
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)

        public void ModificarEvidencia(DatosEvidencias datos)
        {
            try
            {
                bd.connecttodb();
                string modificar = "update evidencia set Ruta1=@Ruta1,Archivo1=@Archivo1,Ruta2=@Ruta2,Archivo2=@Archivo2,Ruta3=@Ruta3,Archivo3=@Archivo3,Ruta4=@Ruta4,Archivo4=@Archivo4,Ruta5=@Ruta5,Archivo5=@Archivo5,Ruta6=@Ruta7,Archivo6=@Archivo6,Ruta7=@Ruta7,Archivo7=@Archivo7,Comentario=@Comentario where IdGrupo=@IdGrupo and Unidad=@Unidas";

                bd.command = new MySqlCommand(modificar, bd.connect);
                bd.command.Parameters.AddWithValue("@IdGrupo", datos.IdGrupo);
                bd.command.Parameters.AddWithValue("@Unidad", datos.NoUnidad);
                bd.command.Parameters.AddWithValue("@Ruta1", datos.Ruta1);
                bd.command.Parameters.AddWithValue("@Ruta2", datos.Ruta2);
                bd.command.Parameters.AddWithValue("@Ruta3", datos.Ruta3);
                bd.command.Parameters.AddWithValue("@Ruta4", datos.Ruta4);
                bd.command.Parameters.AddWithValue("@Ruta5", datos.Ruta5);
                bd.command.Parameters.AddWithValue("@Ruta6", datos.Ruta6);
                bd.command.Parameters.AddWithValue("@Ruta7", datos.Ruta7);
                bd.command.Parameters.AddWithValue("@Archivo1", datos.File1);
                bd.command.Parameters.AddWithValue("@Archivo2", datos.File2);
                bd.command.Parameters.AddWithValue("@Archivo3", datos.File3);
                bd.command.Parameters.AddWithValue("@Archivo4", datos.File4);
                bd.command.Parameters.AddWithValue("@Archivo5", datos.File5);
                bd.command.Parameters.AddWithValue("@Archivo6", datos.File6);
                bd.command.Parameters.AddWithValue("@Archivo7", datos.File7);
                bd.command.Parameters.AddWithValue("@Comentario", datos.Comentario);


                int cant;
                cant = bd.command.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Evidencias modificadas con exito");
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

        public void RegistroBuscar(DatosEvidencias datos)
        {
            try
            {
                MySqlCommand buscarporID = new MySqlCommand("select * from evidencia where IdGrupo=@IdGrupo and Unidad=@Unidad", bd.connect);
                buscarporID.Parameters.AddWithValue("@IdGrupo", datos.IdGrupo);
                buscarporID.Parameters.AddWithValue("@Unidad", datos.NoUnidad);
                bd.connecttodb();
                MySqlDataReader registro = buscarporID.ExecuteReader();
                if (registro.Read())
                {
                    datos.Ruta1 = (registro[2]).ToString();
                    datos.File1 = (byte[])(registro[3]);
                    datos.Ruta2 = (registro[4]).ToString();
                    datos.File2 = (byte[])(registro[5]);
                    datos.Ruta3 = (registro[6]).ToString();
                    datos.File3 = (byte[])(registro[7]);
                    datos.Ruta4 = (registro[8]).ToString();
                    datos.File4 = (byte[])(registro[9]);
                    datos.Ruta5 = (registro[10]).ToString();
                    datos.File5 = (byte[])(registro[11]);
                    datos.Ruta6 = (registro[12]).ToString();
                    datos.File6 = (byte[])(registro[13]);
                    datos.Ruta7 = (registro[14]).ToString();
                    datos.File7 = (byte[])(registro[15]);
                    datos.Comentario = registro[16].ToString();
                }
                bd.closeconnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo salió mal " + ex.ToString());
            }
        }
        public void EvidenciasEliminar(DatosEvidencias datos)
        {
            bd.connecttodb();
            string eliminar = "delete from evidencia where IdGrupo=@IdGrupo and Unidad=@NoUnidad ";
            bd.command = new MySqlCommand(eliminar, bd.connect);
            bd.command.Parameters.AddWithValue("@IdGrupo", datos.IdGrupo);
            bd.command.Parameters.AddWithValue("@Unidad", datos.NoUnidad);

            int cant;
            cant = bd.command.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Evidencias eliminadas con exito");
            }
            else
            {
                MessageBox.Show("Algo salió mal");
            }
        }
<<<<<<< HEAD
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
    }
}
