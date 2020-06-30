using BopiSoft.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BopiSoft.Negocios
{
    class PuenteCalificaciones
    {
        CalificacionesSql registro = new CalificacionesSql();

        public void Añadir(DatosCalificaciones datos)
        {
            registro.Añadir(datos);
        }
        public void RegistroModificar(DatosCalificaciones datos)
        {
            registro.Modificar(datos);
        }

        public void RegistroEliminar(DatosCalificaciones datos)
        {
            registro.Eliminar(datos);
        }

        public void BuscarCalif(DatosCalificaciones datos)
        {
            registro.RegistroBuscar(datos);
        }
    }
}
