using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BopiSoft.Datos
{
    class DatosDepartamentos
    {
        public int IdDpto { get; set; }
        public String Nombre { get; set; }

        public DatosDepartamentos()
        {

        }

        public DatosDepartamentos(int idDpto, string nombre)
        {
            this.IdDpto = idDpto;
            this.Nombre = nombre;
        }
    }
}
