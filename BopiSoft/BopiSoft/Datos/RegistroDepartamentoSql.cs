using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BopiSoft.Datos
{
    class RegistroDepartamentoSql
    {
        BDConexion bd = new BDConexion();

        public void RegistroAñadir(DatosDepartamentos datos)
        {
            string agregar = "insert into lista_departamentos values ('" + datos.IdDpto + "','" + datos.Nombre +  "')";
            if (bd.executecommand(agregar))
            {
                MessageBox.Show("Departamento añadido con exito!");
            }
            else
            {
                MessageBox.Show("No se pudo añadir, intente de nuevo");
            }
        }

        public void RegistroModificar(DatosDepartamentos datos)
        {
            string actualizar = "update lista_departamentos set Nombre='" + datos.Nombre + "' where IdDpto=" + datos.IdDpto;

            if (bd.executecommand(actualizar))
            {
                MessageBox.Show("Departamento modificado con exito!");
            }
            else
            {
                MessageBox.Show("No se pudo modificar, intente de nuevo");
            }
        }

        public void RegistroEliminar(DatosDepartamentos datos)
        {
            string eliminar = "delete from lista_departamentos where IdDpto=" + datos.IdDpto;

            if (bd.executecommand(eliminar))
            {

                MessageBox.Show("Departamento eliminado con exito!");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar, intente de nuevo");
            }
        }

        public void RegistroBuscar(DatosDepartamentos datos)
        {
            MySqlCommand buscarporID = new MySqlCommand("select * from lista_departamentos where IdDpto=@IdDpto", bd.connect);
            buscarporID.Parameters.AddWithValue("@IdDpto", datos.IdDpto);
            bd.connecttodb();
            MySqlDataReader registro = buscarporID.ExecuteReader();
            if (registro.Read())
            {
                datos.Nombre = registro[1].ToString();
            }
            bd.closeconnection();
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
        public void LlenarComboBoxDeptos(ComboBox combo)
        {
            MySqlCommand buscarporID = new MySqlCommand("select * from lista_departamentos", bd.connect);
            bd.connecttodb();
            MySqlDataReader registro = buscarporID.ExecuteReader();
            while (registro.Read())
            {
                combo.Items.Add(registro["Nombre"]);
            }
            combo.SelectedIndex = 0;
            bd.closeconnection();
        }
        public bool ExisteDepto(int ID)
        {
            bd.connecttodb();
            string existe = "Select count(*) from lista_departamentos where IdDpto=@IdDpto";
            bd.command = new MySqlCommand(existe, bd.connect);
            bd.command.Parameters.AddWithValue("@IdDpto", ID);

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
