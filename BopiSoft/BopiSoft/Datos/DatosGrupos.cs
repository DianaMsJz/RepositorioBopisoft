using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BopiSoft.Datos
{
    class DatosGrupos
    {
        public int IdGrupo { get; set; }
        public String Nombre { get; set; }
        public String NombreCarrera { get; set; }
        public String NombreMateria { get; set; }
        public int IdPersonal { get; set; }
        public int Semestre { get; set; }
        public String Turno { get; set; }

        public DatosGrupos()
        {
        }

        public DatosGrupos(int idGrupo, String nombre, String nombreCarrera, String nombreMateria, int idPersonal, int semestre, String turno)
        {
            IdGrupo = idGrupo;
            Nombre = nombre;
            NombreCarrera = nombreCarrera;
            NombreMateria = nombreMateria;
            IdPersonal = idPersonal;
            Semestre = semestre;
            Turno = turno;
        }
    }
}
