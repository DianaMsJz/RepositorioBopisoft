﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BopiSoft.Datos
{
    class RegistroCarrerasSql
    {
        BDConexion bd = new BDConexion();

        public void RegistroAñadir(DatosCarreras datos)
        {
            string agregar = "insert into lista_carreras values ('" + datos.IdCarrera+ "','" + datos.Nombre + "')";
            if (bd.executecommand(agregar))
            {
                MessageBox.Show("Carrera añadida con exito!");
            }
            else
            {
                MessageBox.Show("No se pudo añadir, intente de nuevo");
            }
        }

        public void RegistroModificar(DatosCarreras datos)
        {
            string actualizar = "update lista_carreras set Nombre='" + datos.Nombre + "' where Clave=" + datos.IdCarrera;

            if (bd.executecommand(actualizar))
            {
                MessageBox.Show("Carrera modificada con exito!");
            }
            else
            {
                MessageBox.Show("No se pudo modificar, intente de nuevo");
            }
        }

        public void RegistroEliminar(DatosCarreras datos)
        {
            string eliminar = "delete from lista_carreras where Clave=" + datos.IdCarrera;

            if (bd.executecommand(eliminar))
            {

                MessageBox.Show("Carrera eliminada con exito!");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar, intente de nuevo");
            }
        }

        public void RegistroBuscar(DatosCarreras datos)
        {
            MySqlCommand buscarporID = new MySqlCommand("select * from lista_carreras where Clave=@Clave", bd.connect);
            buscarporID.Parameters.AddWithValue("@Clave", datos.IdCarrera);
            bd.connecttodb();
            MySqlDataReader registro = buscarporID.ExecuteReader();
            if (registro.Read())
            {
                datos.Nombre = registro[1].ToString();
            }
            bd.closeconnection();
        }
    }
}
