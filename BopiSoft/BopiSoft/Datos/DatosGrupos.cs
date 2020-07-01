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
<<<<<<< HEAD
<<<<<<< HEAD
=======
        public int IdMateria { get; set; }
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
        public int IdMateria { get; set; }
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
        public int IdPersonal { get; set; }
        public int Semestre { get; set; }
        public String Turno { get; set; }

        public DatosGrupos()
        {
        }

<<<<<<< HEAD
<<<<<<< HEAD
        public DatosGrupos(int idGrupo, String nombre, String nombreCarrera, String nombreMateria, int idPersonal, int semestre, String turno)
=======
        public DatosGrupos(int idGrupo, String nombre, String nombreCarrera, String nombreMateria,int idMateria, int idPersonal, int semestre, String turno)
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
        public DatosGrupos(int idGrupo, String nombre, String nombreCarrera, String nombreMateria,int idMateria, int idPersonal, int semestre, String turno)
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
        {
            IdGrupo = idGrupo;
            Nombre = nombre;
            NombreCarrera = nombreCarrera;
            NombreMateria = nombreMateria;
<<<<<<< HEAD
<<<<<<< HEAD
=======
            IdMateria = idMateria;
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
            IdMateria = idMateria;
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
            IdPersonal = idPersonal;
            Semestre = semestre;
            Turno = turno;
        }
    }
}
