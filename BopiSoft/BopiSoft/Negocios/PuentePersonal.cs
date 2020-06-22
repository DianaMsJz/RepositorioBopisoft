using BopiSoft.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BopiSoft.Negocios
{
    class PuentePersonal
    {
        RegistroPersonalSql registro= new RegistroPersonalSql();

        public void RegistroAñadir(DatosPersonal datos)
        {
            registro.RegistroAñadir(datos);
        }

        public void RegistroModificar(DatosPersonal datos)
        {
            registro.RegistroModificar(datos);
        }

        public void RegistroEliminar(DatosPersonal datos)
        {
            registro.RegistroEliminar(datos);
        }

        public void RegistroBuscar(DatosPersonal datos)
        {
            registro.RegistroBuscar(datos);
        }

       
        public void LlenarCombo(ComboBox combo)
        {
            registro.LlenarComboBoxDptos(combo);
        }

        public void ExisteRegistro(int ID)
        {
          
            registro.ExisteRegistro(ID);
        }
    }
}
