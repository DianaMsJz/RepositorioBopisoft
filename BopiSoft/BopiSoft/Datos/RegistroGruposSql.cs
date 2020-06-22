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
    }
}
