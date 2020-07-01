using BopiSoft.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BopiSoft.Negocios
{
    class PuenteEvidencias
    {
        RegistroEvidenciasSql registro = new RegistroEvidenciasSql();

        public void AñadirEvidencias(DatosEvidencias datos)
        {
            registro.AñadirEvidencia(datos);
        }
<<<<<<< HEAD

        public void BuscarEvidencias(DatosEvidencias datos)
        {
            registro.RegistroBuscar(datos);
        }
        public void ModificarEvidencias(DatosEvidencias datos)
        {
            registro.ModificarEvidencia(datos);
        }
        public void EliminarEvidencias(DatosEvidencias datos)
        {
            registro.EvidenciasEliminar(datos);
        }
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
    }
}
