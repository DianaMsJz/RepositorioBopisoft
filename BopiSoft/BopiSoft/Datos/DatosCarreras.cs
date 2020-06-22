using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BopiSoft.Datos
{
    class DatosCarreras
    {
        public int IdCarrera { get; set; }
        public String Nombre { get; set; }

        public DatosCarreras()
        {
        }

        public DatosCarreras(int idCarrera, string nombre)
        {
            IdCarrera = idCarrera;
            Nombre = nombre;
        }
    }
}
