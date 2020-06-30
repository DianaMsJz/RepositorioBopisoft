using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BopiSoft.Datos
{
    class RegistroListaAlumnosSql
    {
        BDConexion bd = new BDConexion();
<<<<<<< HEAD
        DatosAlumnosGrupos datos = new DatosAlumnosGrupos();

        public bool ExisteAlumno(int ID,int IdGrupo)
        {
            bd.connecttodb();
            string existe = "Select count(*) from lista_alumnos where No_Control=@No_Control and IdGrupo=@IdGrupo";
            bd.command = new MySqlCommand(existe, bd.connect);
            bd.command.Parameters.AddWithValue("@No_Control", ID);
            bd.command.Parameters.AddWithValue("@IdGrupo", IdGrupo);
=======

        public void AlumnoBuscar(DatosAlumnosGrupos datos)
        {
            MySqlCommand buscarporID = new MySqlCommand("select * from lista_alumnos where No_Control=@No_Control and IdGrupo=@IdGrupo", bd.connect);
            buscarporID.Parameters.AddWithValue("@IdGrupo", datos.IdGrupo);
            buscarporID.Parameters.AddWithValue("@No_Control", datos.NoControl);
            bd.connecttodb();
            MySqlDataReader registro = buscarporID.ExecuteReader();
            if (registro.Read())
            {
                datos.Nombre = registro[2].ToString();
                datos.Apaterno = registro[3].ToString();
                datos.Amaterno = registro[4].ToString();

            }

            bd.closeconnection();
        }

        public bool ExisteAlumno(int ID,  int NoControl)
        {
            bd.connecttodb();
            string existe = "Select count(*) from lista_alumnos where IdGrupo=@IdGrupo and No_Control=@NoControl ";
            bd.command = new MySqlCommand(existe, bd.connect);
            bd.command.Parameters.AddWithValue("@IdGrupo", ID);
            bd.command.Parameters.AddWithValue("@NoControl", NoControl);
            int count = Convert.ToInt32(bd.command.ExecuteScalar());

            return count == 0;
        }
        public bool HayAlumnosGrupo(int ID)
        {
            bd.connecttodb();
            string existe = "Select count(*) from lista_alumnos where IdGrupo=@IdGrupo";
            bd.command = new MySqlCommand(existe, bd.connect);
            bd.command.Parameters.AddWithValue("@IdGrupo", ID);
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
            int count = Convert.ToInt32(bd.command.ExecuteScalar());

            return count == 0;
        }

<<<<<<< HEAD
        public void AñadirAlumno(DatosAlumnosGrupos datos)
        {
            try
            {
                string agregar = "insert into lista_alumnos values ('" + datos.No_Control + "','" + datos.IdGrupo + "','" + datos.Nombre + "','" + datos.Apaterno + "','" + datos.Amaterno + "')";
                if (bd.executecommand(agregar))
                {
                    MessageBox.Show("Alumno añadido con exito!");
                }
                else
                {
                    MessageBox.Show("No se pudo añadir, intente de nuevo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void ModificarAlumno(DatosAlumnosGrupos datos)
=======
        public void Añadir(DatosAlumnosGrupos datos)
        {
            string agregar = "insert into lista_alumnos values ('" + datos.NoControl+ "','" + datos.IdGrupo + "','" + datos.Nombre + "','" + datos.Apaterno+"','" + datos.Amaterno + "')";
            if (bd.executecommand(agregar))
            {
                MessageBox.Show("Alumno añadido con exito!");
            }
            else
            {
                MessageBox.Show("No se pudo añadir, intente de nuevo");
            }
        }

        public void Modificar(DatosAlumnosGrupos datos)
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
        {
            try
            {
                bd.connecttodb();
<<<<<<< HEAD
                string actualizar = "update lista_alumnos set  Nombre=@Nombre, Apaterno=@Apaterno, Amaterno=@Amaterno  where No_Control='" + datos.No_Control +"' and IdGrupo='"+datos.IdGrupo+"'";
=======
                string actualizar = "update lista_alumnos set Nombre=@Nombre, Apaterno=@Apaterno, Amaterno=@Amaterno where No_Control=@NoControl and IdGrupo=@IdGrupo";
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias

                bd.command = new MySqlCommand(actualizar, bd.connect);
                bd.command.Parameters.AddWithValue("@Nombre", datos.Nombre);
                bd.command.Parameters.AddWithValue("@Apaterno", datos.Apaterno);
                bd.command.Parameters.AddWithValue("@Amaterno", datos.Amaterno);
<<<<<<< HEAD
=======
                bd.command.Parameters.AddWithValue("@NoControl", datos.NoControl);
                bd.command.Parameters.AddWithValue("@IdGrupo", datos.IdGrupo);

>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias

                int cant;
                cant = bd.command.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Alumno modificado con exito");
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

        }
        public void AlumnoEliminar(DatosAlumnosGrupos datos)
        {

            string eliminar = "delete from lista_alumnos where No_Control='" + datos.No_Control+"'and IdGrupo='"+datos.IdGrupo+"'" ;

            if (bd.executecommand(eliminar))
            {

                MessageBox.Show("Alumno eliminado con exito!");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar, intente de nuevo");
            }
        }
        public void AlumnoBuscar(DatosAlumnosGrupos datos)
        {
            MySqlCommand buscarporID = new MySqlCommand("select * from lista_alumnos where No_Control=@No_Control and IdGrupo=@IdGrupo", bd.connect);
            buscarporID.Parameters.AddWithValue("@No_Control", datos.No_Control);
            buscarporID.Parameters.AddWithValue("@IdGrupo", datos.IdGrupo);
            bd.connecttodb();
            MySqlDataReader registro = buscarporID.ExecuteReader();
            if (registro.Read())
            {
                datos.IdGrupo = Convert.ToInt32(registro[1]);
                datos.Nombre = registro[2].ToString();
                datos.Apaterno = registro[3].ToString();
                datos.Amaterno = registro[4].ToString();
            }

            bd.closeconnection();
        }

=======
        }
        public void Eliminar(DatosAlumnosGrupos datos)
        {
            bd.connecttodb();
            string eliminar = "delete from lista_alumnos where IdGrupo=@IdGrupo and No_Control=@NoControl";
            bd.command = new MySqlCommand(eliminar, bd.connect);
            bd.command.Parameters.AddWithValue("@IdGrupo", datos.IdGrupo);
            bd.command.Parameters.AddWithValue("@NoControl", datos.NoControl);

            int cant;
            cant = bd.command.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Alumno eliminado con exito");
            }
            else
            {
                MessageBox.Show("Algo salió mal");
            }
        }
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
    }
}
