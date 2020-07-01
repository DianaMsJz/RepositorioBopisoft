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
<<<<<<< HEAD
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)

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
<<<<<<< HEAD
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
    }
}
