using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BopiSoft.Datos;

namespace BopiSoft.Negocios
{
    class PuentePlaneacion
    {
        RegistroPlaneacion registro = new RegistroPlaneacion();

        public void AñadirPlaneacion(DatosPlaneaciones datos)
        {
            registro.AñadirPlaneacion(datos);
        }

        public void ModificarPlaneacion(DatosPlaneaciones datos)
        {
            registro.ModificarPlaneacion(datos);
        }

        public void PlaneacionEliminar(DatosPlaneaciones datos)
        {
            registro.PlaneacionEliminar(datos);
        }

        public void PlaneacionBuscar(DatosPlaneaciones datos)
        {
            registro.PlaneacionBuscar(datos);
        }


        public void LlenarComboBoxUnidad(ComboBox combo)
        {
            registro.LlenarComboBoxUnidad(combo);
        }

        public void ExisteRegistro(int ID)
        {
            registro.ExisteRegistro(ID);
        }


    }
}
