﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BopiSoft.Datos
{
    class CalificacionesSql
    {
        BDConexion bd = new BDConexion();

<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
        public bool ExisteCalifAlumno(int ID, int NoControl)
        {
            bd.connecttodb();
            string existe = "Select count(*) from calificaciones_unidad where IdGrupo=@IdGrupo and NoControl=@NoControl";
            bd.command = new MySqlCommand(existe, bd.connect);
            bd.command.Parameters.AddWithValue("@IdGrupo", ID);
<<<<<<< HEAD
=======
        public bool ExisteCalificacionUnidad(int ID, int NoUnidad, int NoControl)
        {
            bd.connecttodb();
            string existe = "Select count(*) from calificaciones_unidad where IdGrupo=@IdGrupo and NoControl=@NoControl and NoUnidad=@NoUnidad";
            bd.command = new MySqlCommand(existe, bd.connect);
            bd.command.Parameters.AddWithValue("@IdGrupo", ID);
            bd.command.Parameters.AddWithValue("@NoUnidad", NoUnidad);
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
            bd.command.Parameters.AddWithValue("@NoControl", NoControl);
            int count = Convert.ToInt32(bd.command.ExecuteScalar());

            return count == 0;
        }

        public void Añadir(DatosCalificaciones datos)
        {
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
            string agregar = "insert into calificaciones_unidad values ('" + datos.IdGrupo + "','" + datos.NoControl +  "','" + datos.Calif1 + "','" + datos.Calif2+"','" +datos.Calif3+"','"+datos.Calif4+"','"+datos.Calif5+"','"+datos.Calif6+"','"+datos.Calif7+"','"+datos.Promedio+"')";
            if (bd.executecommand(agregar))
            {
                MessageBox.Show("Calificaciones añadidas con exito!");
<<<<<<< HEAD
=======
            string agregar = "insert into calificaciones_unidad values ('" + datos.IdGrupo + "','" + datos.NoControl + "','" + datos.NoUnidad + "','" + datos.CalificacionUni + "')";
            if (bd.executecommand(agregar))
            {
                MessageBox.Show("Calificación añadida con exito!");
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
            }
            else
            {
                MessageBox.Show("No se pudo añadir, intente de nuevo");
            }
        }

        public void Modificar(DatosCalificaciones datos)
        {
            try
            {
                bd.connecttodb();
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
                string actualizar = "update calificaciones_unidad set Unidad1=@Unidad1,Unidad2=@Unidad2,Unidad3=@Unidad3,Unidad4=@Unidad4,Unidad5=@Unidad5,Unidad6=@Unidad6,Unidad7=@Unidad7,Promedio=@Promedio  where IdGrupo=@IdGrupo and NoControl=@NoControl ";

                bd.command = new MySqlCommand(actualizar, bd.connect);
                bd.command.Parameters.AddWithValue("@Unidad1", datos.Calif1);
                bd.command.Parameters.AddWithValue("@Unidad2", datos.Calif2);
                bd.command.Parameters.AddWithValue("@Unidad3", datos.Calif3);
                bd.command.Parameters.AddWithValue("@Unidad4", datos.Calif4);
                bd.command.Parameters.AddWithValue("@Unidad5", datos.Calif5);
                bd.command.Parameters.AddWithValue("@Unidad6", datos.Calif6);
                bd.command.Parameters.AddWithValue("@Unidad7", datos.Calif7);
                bd.command.Parameters.AddWithValue("@Promedio", datos.Promedio);
                bd.command.Parameters.AddWithValue("@IdGrupo", datos.IdGrupo);
                bd.command.Parameters.AddWithValue("@NoControl", datos.NoControl);
<<<<<<< HEAD
=======
                string actualizar = "update calificaciones_unidad set CalificacionUni=@CalificacionUni  where IdGrupo=@IdGrupo and NoControl=@NoControl and NoUnidad=@NoUnidad";

                bd.command = new MySqlCommand(actualizar, bd.connect);
                bd.command.Parameters.AddWithValue("@CalificacionUni", datos.CalificacionUni);
                bd.command.Parameters.AddWithValue("@IdGrupo", datos.IdGrupo);
                bd.command.Parameters.AddWithValue("@NoControl", datos.NoControl);
                bd.command.Parameters.AddWithValue("@NoUnidad", datos.NoUnidad);
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)


                int cant;
                cant = bd.command.ExecuteNonQuery();
                if (cant == 1)
                {
<<<<<<< HEAD
<<<<<<< HEAD
                    MessageBox.Show("Calificaciones modificadas con exito");
=======
                    MessageBox.Show("Calificación modificada con exito");
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
                    MessageBox.Show("Calificaciones modificadas con exito");
>>>>>>> 031b574... Proyecto completo (Versión Final)
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
        public void Eliminar(DatosCalificaciones datos)
        {
            bd.connecttodb();
<<<<<<< HEAD
<<<<<<< HEAD
            string eliminar = "delete from calificaciones_unidad where IdGrupo=@IdGrupo and  NoControl=@NoControl";
            bd.command = new MySqlCommand(eliminar, bd.connect);
            bd.command.Parameters.AddWithValue("@IdGrupo", datos.IdGrupo);
=======
            string eliminar = "delete from calificaciones_unidad where IdGrupo=@IdGrupo and NoUnidad=@NoUnidad and NoControl=@NoControl";
            bd.command = new MySqlCommand(eliminar, bd.connect);
            bd.command.Parameters.AddWithValue("@IdGrupo", datos.IdGrupo);
            bd.command.Parameters.AddWithValue("@NoUnidad", datos.NoUnidad);
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
            string eliminar = "delete from calificaciones_unidad where IdGrupo=@IdGrupo and  NoControl=@NoControl";
            bd.command = new MySqlCommand(eliminar, bd.connect);
            bd.command.Parameters.AddWithValue("@IdGrupo", datos.IdGrupo);
>>>>>>> 031b574... Proyecto completo (Versión Final)
            bd.command.Parameters.AddWithValue("@NoControl", datos.NoControl);

            int cant;
            cant = bd.command.ExecuteNonQuery();
            if (cant == 1)
            {
<<<<<<< HEAD
<<<<<<< HEAD
                MessageBox.Show("Calificaciones eliminadas con exito");
=======
                MessageBox.Show("Calificación eliminada con exito");
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
                MessageBox.Show("Calificaciones eliminadas con exito");
>>>>>>> 031b574... Proyecto completo (Versión Final)
            }
            else
            {
                MessageBox.Show("Algo salió mal");
            }
        }
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)

        public void RegistroBuscar(DatosCalificaciones datos)
        {
            try
            {
                MySqlCommand buscarCalif = new MySqlCommand("select * from calificaciones_unidad where IdGrupo=@IdGrupo and NoControl=@NoControl", bd.connect);
                buscarCalif.Parameters.AddWithValue("@IdGrupo", datos.IdGrupo);
                buscarCalif.Parameters.AddWithValue("@NoControl", datos.NoControl);
                bd.connecttodb();
                MySqlDataReader registro = buscarCalif.ExecuteReader();
                if (registro.Read())
                {
                    datos.Calif1 = Convert.ToInt32((registro[2]));
                    datos.Calif2 = Convert.ToInt32((registro[3]));
                    datos.Calif3 = Convert.ToInt32((registro[4]));
                    datos.Calif4 = Convert.ToInt32((registro[5]));
                    datos.Calif5 = Convert.ToInt32((registro[6]));
                    datos.Calif6 = Convert.ToInt32((registro[7]));
                    datos.Calif7 = Convert.ToInt32((registro[8]));
                    datos.Promedio = Convert.ToInt32((registro[9]));
                }
                bd.closeconnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo salió mal " + ex.ToString());
            }
        }


<<<<<<< HEAD
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
    }
}
