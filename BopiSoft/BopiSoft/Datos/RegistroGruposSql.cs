using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BopiSoft.Datos
{
    class RegistroGruposSql
    {

        BDConexion bd = new BDConexion();

        public void LlenarComboBoxCarreras(ComboBox combo)
        {
            MySqlCommand buscarporID = new MySqlCommand("select * from lista_carreras", bd.connect);
            bd.connecttodb();
            MySqlDataReader registro = buscarporID.ExecuteReader();
            while (registro.Read())
            {
                combo.Items.Add(registro["Nombre"]);
            }
            combo.SelectedIndex = 0;
            bd.closeconnection();
        }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones

        public bool ExisteRegistro(int ID)
        {
            bd.connecttodb();
            string existe = "Select count(*) from lista_grupos where IdGrupo=@IdGrupo";
            bd.command = new MySqlCommand(existe, bd.connect);
            bd.command.Parameters.AddWithValue("@IdGrupo", ID);

            int count = Convert.ToInt32(bd.command.ExecuteScalar());

            return count == 0;
        }

        public void AñadirGrupo(DatosGrupos datos)
        {
            try
            {
<<<<<<< HEAD
<<<<<<< HEAD
                string agregar = "insert into lista_grupos values ('" + datos.IdGrupo + "','" + datos.Nombre + "','" + datos.NombreCarrera + "','" + datos.NombreMateria + "','" + datos.IdPersonal + "','" + datos.Semestre + "','" + datos.Turno + "')";
=======
                string agregar = "insert into lista_grupos values ('" + datos.IdGrupo + "','" + datos.Nombre + "','" + datos.NombreCarrera + "','" + datos.NombreMateria + "','" + datos.IdMateria + "','" + datos.IdPersonal+ "','" + datos.Semestre + "','" + datos.Turno + "')";
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
                string agregar = "insert into lista_grupos values ('" + datos.IdGrupo + "','" + datos.Nombre + "','" + datos.NombreCarrera + "','" + datos.NombreMateria + "','" + datos.IdMateria + "','" + datos.IdPersonal+ "','" + datos.Semestre + "','" + datos.Turno + "')";
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
                if (bd.executecommand(agregar))
                {
                    MessageBox.Show("Grupo añadido con exito!");
                }
                else
                {
                    MessageBox.Show("No se pudo añadir, intente de nuevo");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ModificarGrupo(DatosGrupos datos)
        {
            try
            {
                bd.connecttodb();
<<<<<<< HEAD
<<<<<<< HEAD
                string actualizar = "update lista_grupos set  Nombre=@Nombre, NombreCarrera=@NombreCarrera, NombreMateria=@NombreMateria , IdPersonal=@IdPersonal, Semestre=@Semestre, Turno=@Turno where IdGrupo=" + datos.IdGrupo;
=======
                string actualizar = "update lista_grupos set  Nombre=@Nombre, NombreCarrera=@NombreCarrera, NombreMateria=@NombreMateria , IdMateria=@IdMateria, IdPersonal=@IdPersonal, Semestre=@Semestre, Turno=@Turno where IdGrupo=" + datos.IdGrupo;
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
                string actualizar = "update lista_grupos set  Nombre=@Nombre, NombreCarrera=@NombreCarrera, NombreMateria=@NombreMateria , IdMateria=@IdMateria, IdPersonal=@IdPersonal, Semestre=@Semestre, Turno=@Turno where IdGrupo=" + datos.IdGrupo;
>>>>>>> 80c648b... Commit 9 registro de las planeaciones

                bd.command = new MySqlCommand(actualizar, bd.connect);
                bd.command.Parameters.AddWithValue("@Nombre", datos.Nombre);
                bd.command.Parameters.AddWithValue("@NombreCarrera", datos.NombreCarrera);
                bd.command.Parameters.AddWithValue("@NombreMateria", datos.NombreMateria);
<<<<<<< HEAD
<<<<<<< HEAD
=======
                bd.command.Parameters.AddWithValue("@IdMateria", datos.IdMateria);
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
                bd.command.Parameters.AddWithValue("@IdMateria", datos.IdMateria);
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
                bd.command.Parameters.AddWithValue("@IdPersonal", datos.IdPersonal);
                bd.command.Parameters.AddWithValue("@Semestre", datos.Semestre);
                bd.command.Parameters.AddWithValue("@Turno", datos.Turno);
                
                int cant;
                cant = bd.command.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Grupo modificado con exito");
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

        public void GrupoBuscar(DatosGrupos datos)
        {
            MySqlCommand buscarporID = new MySqlCommand("select * from lista_grupos where IdGrupo=@IdGrupo", bd.connect);
            buscarporID.Parameters.AddWithValue("@IdGrupo", datos.IdGrupo);
            bd.connecttodb();
            MySqlDataReader registro = buscarporID.ExecuteReader();
            if (registro.Read())
            {
                datos.Nombre = registro[1].ToString();
                datos.NombreCarrera = registro[2].ToString();
                datos.NombreMateria = registro[3].ToString();
                datos.IdPersonal = Convert.ToInt32(registro[4]);
                datos.Semestre = Convert.ToInt32(registro[5]);
                datos.Turno = registro[6].ToString();
            }
            
            bd.closeconnection();
        }

        public void GrupoEliminar(DatosGrupos datos)
        {

            string eliminar = "delete from lista_grupos where IdGrupo=" + datos.IdGrupo;

            if (bd.executecommand(eliminar))
            {

                MessageBox.Show("Grupo eliminado con exito!");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar, intente de nuevo");
            }
        }
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
    }
}
