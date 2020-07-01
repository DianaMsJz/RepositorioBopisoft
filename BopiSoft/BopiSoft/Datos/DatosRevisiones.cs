using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BopiSoft.Datos
{
    class DatosRevisiones
    {
        
        public int IdGrupo { get; set; }
        public int IdDocente { get; set; }
        public DateTime Fecha { get; set; }
        public int Unidad { get; set; }
        public string Tipo { get; set; }
        public string Contenido { get; set; }

        public DatosRevisiones(int idGrupo,int idDocente, DateTime fecha, int unidad, string tipo, string contenido)
        {
            IdGrupo = idGrupo;
            IdDocente= idDocente;
            Fecha = fecha;
            Unidad = unidad;
            Tipo = tipo;
            Contenido = contenido;
        }

        public DatosRevisiones()
        {
        }
    }
}
