using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BopiSoft.Datos
{
    class DatosAlumnosGrupos
    {
        
        public int No_Control { get; set; }
        public int IdGrupo { get; set; }
        public string Nombre { get; set; }
        public string Apaterno { get; set; }
        public string Amaterno { get; set; }

        public DatosAlumnosGrupos()
        {
        }

        public DatosAlumnosGrupos(int no_Control, int idGrupo, string nombre, string apaterno, string amaterno)
        {
            No_Control = no_Control;
            IdGrupo = idGrupo;
            Nombre = nombre;
            Apaterno = apaterno;
            Amaterno = amaterno;
        }
    }
}
