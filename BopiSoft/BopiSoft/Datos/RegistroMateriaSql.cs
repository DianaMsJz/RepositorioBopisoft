using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BopiSoft.Datos
{
    class RegistroMateriaSql
    {
        BDConexion bd = new BDConexion();

        public void RegistroAñadir(DatosMaterias datos)
        {
<<<<<<< HEAD
            string agregar = "insert into lista_materias values ('" + datos.IdMateria + "','" + datos.Nombre + "','" + datos.Creditos + "','" + datos.Carrera + "','"+ datos.Unidades + "','" +datos.Caracterizacion + "','" + datos.Competencia + "')";
=======
            string agregar = "insert into lista_materias values ('" + datos.IdMateria + "','" + datos.Nombre + "','" + datos.Creditos + "','" + datos.Carrera + "','" + datos.Unidades + "','" + datos.Caracterizacion + "','" + datos.Competencia + "')";
>>>>>>> 031b574... Proyecto completo (Versión Final)
            if (bd.executecommand(agregar))
            {
                MessageBox.Show("Materia añadida con exito!");
            }
            else
            {
                MessageBox.Show("No se pudo añadir, intente de nuevo");
            }
        }
        public void RegistroAñadirContenido(DatosMaterias datos)
        {
<<<<<<< HEAD
            string agregar = "insert into materia_contenido values ('" + datos.IdMateria + "','" + datos.Unidad + "','" + datos.TemaUnidad + "','" + datos.SubtemaUnidad  + "')";
=======
            string agregar = "insert into materia_contenido values ('" + datos.IdMateria + "','" + datos.Unidad + "','" + datos.TemaUnidad + "','" + datos.SubtemaUnidad + "')";
>>>>>>> 031b574... Proyecto completo (Versión Final)
            if (bd.executecommand(agregar))
            {
                MessageBox.Show("Contenido de la unidad añadido con exito!");
            }
            else
            {
                MessageBox.Show("No se pudo añadir, intente de nuevo");
            }
        }

        public void RegistroModificar(DatosMaterias datos)
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            string actualizar = "update lista_materias set Nombre='" + datos.Nombre + "','" + datos.Creditos  +"','" + datos.Carrera + "','" + datos.Unidades + "','" + datos.Caracterizacion + "','" + datos.Competencia + "' where Clave=" + datos.IdMateria;
=======
            string actualizar = "update lista_materias set Nombre='" + datos.Nombre + "','" + datos.Creditos  +"','" + datos.Carrera + "','" + datos.Unidades + "','" + datos.Caracterizacion + "','" + datos.Competencia + "' where IdMateria=" + datos.IdMateria;
>>>>>>> 01c80df... 6to Commit: Login creado

            if (bd.executecommand(actualizar))
            {
                MessageBox.Show("Materia modificada con exito!");
            }
            else
            {
                MessageBox.Show("No se pudo modificar, intente de nuevo");
            }
        }
        public void RegistroModificarContenido(DatosMaterias datos)
        {
<<<<<<< HEAD
            string actualizar = "update materia_contenido set Tema='" + datos.TemaUnidad + "','" + datos.SubtemaUnidad + "' where Clave=" + datos.IdMateria + "' and Unidad=" +datos.Unidad ;
=======
            string actualizar = "update materia_contenido set Tema='" + datos.TemaUnidad + "','" + datos.SubtemaUnidad + "' where IdMateria=" + datos.IdMateria + "' and Unidad=" +datos.Unidad ;
>>>>>>> 01c80df... 6to Commit: Login creado

            if (bd.executecommand(actualizar))
            {
                MessageBox.Show("Contenido de la unidad modificado con exito!");
            }
            else
            {
                MessageBox.Show("No se pudo modificar, intente de nuevo");
            }
=======
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
            try
            {
                bd.connecttodb();
                string actualizar = "update lista_materias set Nombre=@Nombre , Creditos=@Creditos , Carrera=@Carrera, Unidades=@Unidades , Caracterización=@Caracterizacion, Competencia=@Competencia where IdMateria=" + datos.IdMateria;

                bd.command = new MySqlCommand(actualizar, bd.connect);
                bd.command.Parameters.AddWithValue("@Nombre", datos.Nombre);
                bd.command.Parameters.AddWithValue("@Creditos", datos.Creditos);
                bd.command.Parameters.AddWithValue("@Carrera", datos.Carrera);
                bd.command.Parameters.AddWithValue("@Unidades", datos.Unidades);
                bd.command.Parameters.AddWithValue("@Caracterizacion", datos.Caracterizacion);
                bd.command.Parameters.AddWithValue("@Competencia", datos.Competencia);


                int cant;
                cant = bd.command.ExecuteNonQuery();
                if (cant == 1)
                {
<<<<<<< HEAD
                     MessageBox.Show("Materia modificada con exito");
=======
                    MessageBox.Show("Materia modificada con exito");
>>>>>>> 031b574... Proyecto completo (Versión Final)
                }
                else
                {
                    MessageBox.Show("Algo salió mal");
                }
<<<<<<< HEAD
            }catch(Exception ex)
=======
            }
            catch (Exception ex)
>>>>>>> 031b574... Proyecto completo (Versión Final)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void RegistroModificarContenido(DatosMaterias datos)
        {
            try
            {
                bd.connecttodb();
                string actualizar = "update materia_contenido set Tema=@Tema , Subtema=@Subtema  where IdMateria=" + datos.IdMateria + " and Unidad=" + datos.Unidad;

                bd.command = new MySqlCommand(actualizar, bd.connect);
                bd.command.Parameters.AddWithValue("@Tema", datos.TemaUnidad);
                bd.command.Parameters.AddWithValue("@Subtema", datos.SubtemaUnidad);
<<<<<<< HEAD
                
=======

>>>>>>> 031b574... Proyecto completo (Versión Final)
                int cant;
                cant = bd.command.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Contenido de materia modificado con exito");
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
<<<<<<< HEAD
           

           
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======



>>>>>>> 031b574... Proyecto completo (Versión Final)
        }

        public void RegistroEliminar(DatosMaterias datos)
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======

>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======

>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======

>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======

>>>>>>> 031b574... Proyecto completo (Versión Final)
            string eliminar = "delete from lista_materias where IdMateria=" + datos.IdMateria;

            if (bd.executecommand(eliminar))
            {

                MessageBox.Show("Materia eliminada con exito!");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar, intente de nuevo");
            }
        }

        public void RegistroEliminarContenido(DatosMaterias datos)
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            string eliminar = "delete from materia_contenido where IdMateria=" + datos.IdMateria+ "and Unidad=" +datos.Unidad;

            if (bd.executecommand(eliminar))
            {

                MessageBox.Show("Contenido de la unidad eliminado con exito!");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar, intente de nuevo");
            }
=======
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
            try
            {
                bd.connecttodb();
                string eliminar = "delete from materia_contenido where IdMateria=@IdMateria and Unidad=@Unidad";

                bd.command = new MySqlCommand(eliminar, bd.connect);
                bd.command.Parameters.AddWithValue("@IdMateria", datos.IdMateria);
                bd.command.Parameters.AddWithValue("@Unidad", datos.Unidad);

                int cant;
                cant = bd.command.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Contenido de materia eliminado con exito");
                }
                else
                {
                    MessageBox.Show("Algo salió mal");
                }
            }
<<<<<<< HEAD
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
          

           
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
        }

        public void RegistroBuscar(DatosMaterias datos)
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            MySqlCommand buscarporID = new MySqlCommand("select * from lista_materias where IdMateria=@IdMateria", bd.connect);
            buscarporID.Parameters.AddWithValue("@IdMateria", datos.IdMateria);
            bd.connecttodb();
            MySqlDataReader registro = buscarporID.ExecuteReader();
            if (registro.Read())
            {
                datos.Nombre = registro[1].ToString();
                datos.Creditos = Convert.ToInt32(registro[2]);
                datos.Carrera = registro[3].ToString();
                datos.Unidades = Convert.ToInt32(registro[4]);
                datos.Caracterizacion = registro[5].ToString();
                datos.Competencia = registro[6].ToString();
            }
=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
           
                MySqlCommand buscarporID = new MySqlCommand("select * from lista_materias where IdMateria=@IdMateria", bd.connect);
                buscarporID.Parameters.AddWithValue("@IdMateria", datos.IdMateria);
                bd.connecttodb();
                MySqlDataReader registro = buscarporID.ExecuteReader();
                if (registro.Read())
                {
                    datos.Nombre = registro[1].ToString();
                    datos.Creditos = Convert.ToInt32(registro[2]);
                    datos.Carrera = registro[3].ToString();
                    datos.Unidades = Convert.ToInt32(registro[4]);
                    datos.Caracterizacion = registro[5].ToString();
                    datos.Competencia = registro[6].ToString();
                }
            
            
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 01c80df... 6to Commit: Login creado
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
            bd.closeconnection();
        }

        public void RegistroBuscarPorNombre(DatosMaterias datos)
=======
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }




        }

        public void RegistroBuscar(DatosMaterias datos)
>>>>>>> 031b574... Proyecto completo (Versión Final)
        {

            MySqlCommand buscarporID = new MySqlCommand("select * from lista_materias where IdMateria=@IdMateria", bd.connect);
            buscarporID.Parameters.AddWithValue("@IdMateria", datos.IdMateria);
            bd.connecttodb();
            MySqlDataReader registro = buscarporID.ExecuteReader();
            if (registro.Read())
            {
                datos.Nombre = registro[1].ToString();
                datos.Creditos = Convert.ToInt32(registro[2]);
                datos.Carrera = registro[3].ToString();
                datos.Unidades = Convert.ToInt32(registro[4]);
                datos.Caracterizacion = registro[5].ToString();
                datos.Competencia = registro[6].ToString();
            }


<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
            bd.closeconnection();
        }
        public void RegistroBuscarContenido(DatosMaterias datos)
        {
            try
            {
                MySqlCommand buscarporID = new MySqlCommand("select * from materia_contenido where IdMateria=@IdMateria and Unidad=@Unidad", bd.connect);
                buscarporID.Parameters.AddWithValue("@IdMateria", datos.IdMateria);
                buscarporID.Parameters.AddWithValue("@Unidad", datos.Unidad);
                bd.connecttodb();
                MySqlDataReader registro = buscarporID.ExecuteReader();
                if (registro.Read())
                {
                    datos.TemaUnidad = registro[2].ToString();
                    datos.SubtemaUnidad = registro[3].ToString();
                }
                bd.closeconnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo salió mal " + ex.ToString());
            }
        }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            public void LlenarComboBoxCarreras(ComboBox combo)
=======
        public void LlenarComboBoxCarreras(ComboBox combo)
>>>>>>> 01c80df... 6to Commit: Login creado
=======
        public void LlenarComboBoxCarreras(ComboBox combo)
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
        public void LlenarComboBoxCarreras(ComboBox combo)
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
        public void LlenarComboBoxCarreras(ComboBox combo)
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
        public void LlenarComboBoxCarreras(ComboBox combo)
>>>>>>> 031b574... Proyecto completo (Versión Final)
        {
            MySqlCommand buscarporID = new MySqlCommand("select * from lista_carreras", bd.connect);
            bd.connecttodb();
            MySqlDataReader registro = buscarporID.ExecuteReader();
            while (registro.Read())
            {
<<<<<<< HEAD
               combo.Items.Add(registro["Nombre"]);
=======
                combo.Items.Add(registro["Nombre"]);
>>>>>>> 031b574... Proyecto completo (Versión Final)
            }
            combo.SelectedIndex = 0;
            bd.closeconnection();
        }

        public bool ExisteContenidoDeEsaUnidad(int ID, int unidad)
        {
            bd.connecttodb();
            string existe = "Select count(*) from materia_contenido where IdMateria=@IdMateria and Unidad=@Unidad";
            bd.command = new MySqlCommand(existe, bd.connect);
            bd.command.Parameters.AddWithValue("@IdMateria", ID);
            bd.command.Parameters.AddWithValue("@Unidad", unidad);

            int count = Convert.ToInt32(bd.command.ExecuteScalar());

            return count == 0;
        }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
        public bool ExisteMateria(int ID)
        {
            bd.connecttodb();
            string existe = "Select count(*) from lista_materias where IdMateria=@IdMateria";
            bd.command = new MySqlCommand(existe, bd.connect);
            bd.command.Parameters.AddWithValue("@IdMateria", ID);

            int count = Convert.ToInt32(bd.command.ExecuteScalar());

            return count == 0;
        }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 01c80df... 6to Commit: Login creado
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)

    }
}
