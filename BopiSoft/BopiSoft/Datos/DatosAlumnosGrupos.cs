using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BopiSoft.Datos
{
    class DatosAlumnosGrupos
    {
<<<<<<< HEAD
        
        public int No_Control { get; set; }
=======
        public int NoControl { get; set; }
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
        public int IdGrupo { get; set; }
        public string Nombre { get; set; }
        public string Apaterno { get; set; }
        public string Amaterno { get; set; }

        public DatosAlumnosGrupos()
        {
        }

<<<<<<< HEAD
        public DatosAlumnosGrupos(int no_Control, int idGrupo, string nombre, string apaterno, string amaterno)
        {
            No_Control = no_Control;
=======
        public DatosAlumnosGrupos(int noControl, int idGrupo, string nombre, string apaterno, string amaterno)
        {
            NoControl = noControl;
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
            IdGrupo = idGrupo;
            Nombre = nombre;
            Apaterno = apaterno;
            Amaterno = amaterno;
        }
    }
}
