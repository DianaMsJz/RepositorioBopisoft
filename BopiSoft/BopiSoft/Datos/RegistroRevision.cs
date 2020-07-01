using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BopiSoft.Datos
{
    class RegistroRevision
    {
        BDConexion bd = new BDConexion();

        public void AñadirRevision(DatosRevisiones datos)
        {

            try
            {
                bd.connecttodb();
                string añadir = "insert into revision_docente(IdGrupo,IDdocente,Fecha, Unidad, Tipo, Contenido ) values (@IdGrupo,@IDdocente, @Fecha, @Unidad, @Tipo, @Contenido)";

                bd.command = new MySqlCommand(añadir, bd.connect);
                bd.command.Parameters.AddWithValue("@IdGrupo", datos.IdGrupo);
                bd.command.Parameters.AddWithValue("@IDdocente", datos.IdDocente);
                bd.command.Parameters.AddWithValue("@Fecha", datos.Fecha);
                bd.command.Parameters.AddWithValue("@Unidad", datos.Unidad);
                bd.command.Parameters.AddWithValue("@Tipo", datos.Tipo);
                bd.command.Parameters.AddWithValue("@Contenido", datos.Contenido);

                int cant;
                cant = bd.command.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Comentario guardado");
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
    }
}
