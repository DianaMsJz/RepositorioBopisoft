using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BopiSoft.Datos
{
    class RegistroPersonalSql
    {
        BDConexion bd = new BDConexion();
        
        public void RegistroAñadir(DatosPersonal datos)
        {
            try
            {
                bd.connecttodb();
                bd.command = new MySqlCommand("insert into lista_personal(IdPersonal,Tipo,Nombre,Apaterno,Amaterno,Sexo,NombreDpto,Direccion,Telefono,Contraseña,Foto) values ('" + datos.IdPersonal + "','" + datos.Tipo + "','" + datos.Nombre + "','" + datos.Apaterno
                        + "','" + datos.Amaterno + "','" + datos.Sexo + "','" + datos.NombreDpto + "','" + datos.Direccion + "','" + datos.Telefono + "','" + datos.Contraseña + "', @Foto)",bd.connect);
                
               
               bd.command.Parameters.AddWithValue("@Foto", datos.Foto);

               int cant;
               cant = bd.command.ExecuteNonQuery();

               if (cant == 1)
               {
                    MessageBox.Show("Registro añadido con exito");
               }
               else
               {
                    MessageBox.Show("Algo salió mal");
               }
            }
            catch(Exception ex)
            {
                MessageBox.Show( ex.ToString());
            }
           

        }

        public void RegistroModificar(DatosPersonal datos)
        {
            try
            {
                bd.connecttodb();
                string actualizar = "update lista_personal set Tipo= @Tipo , Nombre= @Nombre , Apaterno= @Apaterno, Amaterno= @Amaterno , Sexo= @Sexo, NombreDpto= @NombreDpto, Direccion= @Direccion, Telefono= @Telefono, Contraseña= @Contraseña, Foto= @Foto where IdPersonal=" + datos.IdPersonal;

                bd.command = new MySqlCommand(actualizar, bd.connect);
                bd.command.Parameters.AddWithValue("@Tipo", datos.Tipo);
                bd.command.Parameters.AddWithValue("@Nombre", datos.Nombre);
                bd.command.Parameters.AddWithValue("@Apaterno", datos.Apaterno);
                bd.command.Parameters.AddWithValue("@Amaterno", datos.Amaterno);
                bd.command.Parameters.AddWithValue("@Sexo", datos.Sexo);
                bd.command.Parameters.AddWithValue("@NombreDpto", datos.NombreDpto);
                bd.command.Parameters.AddWithValue("@Direccion", datos.Direccion);
                bd.command.Parameters.AddWithValue("@Telefono", datos.Telefono);
                bd.command.Parameters.AddWithValue("@Contraseña", datos.Contraseña);
                bd.command.Parameters.AddWithValue("@Foto", datos.Foto);


                int cant;
                cant = bd.command.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Registro modificado con exito");
                }
                else
                {
                    MessageBox.Show("Algo salió mal");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void RegistroEliminar(DatosPersonal datos)
        {
            string eliminar = "delete from lista_personal where IdPersonal=" + datos.IdPersonal;

            if (bd.executecommand(eliminar))
            {

                MessageBox.Show("Personal eliminado con exito!");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar, intente de nuevo");
            }
        }

        public void RegistroBuscar(DatosPersonal datos)
        {
            try
            {
                MySqlCommand buscarporID = new MySqlCommand("select * from lista_personal where IdPersonal=@IdPersonal", bd.connect);
                buscarporID.Parameters.AddWithValue("@IdPersonal", datos.IdPersonal);
                bd.connecttodb();
                MySqlDataReader registro = buscarporID.ExecuteReader();
                if (registro.Read())
                {
                    datos.Tipo = registro[1].ToString();
                    datos.Nombre = registro[2].ToString();
                    datos.Apaterno = registro[3].ToString();
                    datos.Amaterno = registro[4].ToString();
                    datos.Sexo = registro[5].ToString();
                    datos.NombreDpto = registro[6].ToString();
                    datos.Direccion = registro[7].ToString();
                    datos.Telefono = registro[8].ToString();
                    datos.Contraseña = registro[9].ToString();
                    datos.Foto =(byte[])(registro[10]);
                }
                bd.closeconnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Algo salió mal " + ex.ToString());
            }
        }

        public void MostrarImagen(PictureBox pb,int ID)
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select Foto from lista_personal where IdPersonal='" + ID + "'", bd.connect);
                DataSet ds = new DataSet();
                DataRow dr;
                da.Fill(ds, "lista_personal");
                byte[] datos = new byte[0];
                dr = ds.Tables["lista_personal"].Rows[10];
                datos = (byte[])dr["Foto"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pb.Image = System.Drawing.Bitmap.FromStream(ms);
            }catch(Exception ex)
            {
                MessageBox.Show("Algo salió mal "+ ex.ToString());
            }
        }

        public void LlenarComboBoxDptos(ComboBox combo)
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

        public bool ExisteRegistro(int ID)
        {
            bd.connecttodb();
            string existe = "Select count(*) from lista_personal where IdPersonal=@IdPersonal";
            bd.command = new MySqlCommand(existe, bd.connect);
            bd.command.Parameters.AddWithValue("@IdPersonal", ID);

            int count = Convert.ToInt32(bd.command.ExecuteScalar());

            return count == 0;
        }


    }
}
