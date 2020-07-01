using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BopiSoft.Datos
{
    class DatosCalificaciones
    {
        public int IdGrupo{ get; set; }
        public int NoControl { get; set; }
        public int NoUnidad { get; set; }
<<<<<<< HEAD
        public int Calif1 { get; set; }
        public int Calif2 { get; set; }
        public int Calif3 { get; set; }
        public int Calif4 { get; set; }
        public int Calif5 { get; set; }
        public int Calif6 { get; set; }
        public int Calif7 { get; set; }
        public int Promedio { get; set; }
=======
        public int CalificacionUni { get; set; }
>>>>>>> 80c648b... Commit 9 registro de las planeaciones

        public DatosCalificaciones()
        {
        }

<<<<<<< HEAD
        public DatosCalificaciones(int idGrupo, int noControl, int noUnidad, int calif1, int calif2, int calif3, int calif4, int calif5, int calif6, int calif7, int promedio)
=======
        public DatosCalificaciones(int idGrupo, int noControl, int noUnidad, int calificacionUni)
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
        {
            IdGrupo = idGrupo;
            NoControl = noControl;
            NoUnidad = noUnidad;
<<<<<<< HEAD
            Calif1 = calif1;
            Calif2 = calif2;
            Calif3 = calif3;
            Calif4 = calif4;
            Calif5 = calif5;
            Calif6 = calif6;
            Calif7 = calif7;
            Promedio = promedio;
=======
            CalificacionUni = calificacionUni;
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
        }
    }
}
