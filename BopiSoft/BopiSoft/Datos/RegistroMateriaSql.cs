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
            string agregar = "insert into lista_materias values ('" + datos.IdMateria + "','" + datos.Nombre + "','" + datos.Creditos + "','" + datos.Carrera + "','"+ datos.Unidades + "','" +datos.Caracterizacion + "','" + datos.Competencia + "')";
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
            string agregar = "insert into materia_contenido values ('" + datos.IdMateria + "','" + datos.Unidad + "','" + datos.TemaUnidad + "','" + datos.SubtemaUnidad  + "')";
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
        }

        public void RegistroEliminar(DatosMaterias datos)
        {
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
            string eliminar = "delete from materia_contenido where IdMateria=" + datos.IdMateria+ "and Unidad=" +datos.Unidad;

            if (bd.executecommand(eliminar))
            {

                MessageBox.Show("Contenido de la unidad eliminado con exito!");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar, intente de nuevo");
            }
        }

        public void RegistroBuscar(DatosMaterias datos)
        {
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
            
            
>>>>>>> 01c80df... 6to Commit: Login creado
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
            public void LlenarComboBoxCarreras(ComboBox combo)
=======
        public void LlenarComboBoxCarreras(ComboBox combo)
>>>>>>> 01c80df... 6to Commit: Login creado
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
=======
        public bool ExisteMateria(int ID)
        {
            bd.connecttodb();
            string existe = "Select count(*) from lista_materias where IdMateria=@IdMateria";
            bd.command = new MySqlCommand(existe, bd.connect);
            bd.command.Parameters.AddWithValue("@IdMateria", ID);

            int count = Convert.ToInt32(bd.command.ExecuteScalar());

            return count == 0;
        }

>>>>>>> 01c80df... 6to Commit: Login creado

    }
}
