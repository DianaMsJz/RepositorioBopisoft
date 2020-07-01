using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BopiSoft.Datos
{
    class DatosPlaneaciones
    {

        public int IdPlaneacion { get; set; }
        public int IdGrupo { get; set; }
        public string NombreMateria { get; set; }
        public int IDdocente   { get; set; }
        public string NombreDocente { get; set; }
        public int Unidad { get; set; }
        public string CompetenciaMat { get; set; }
        public string Caracterizacion { get; set; }
        public string TemarioUnidad { get; set; }
        public string CompetenciaUnidad { get; set; }
        public string ActAprendizaje { get; set; }
        public int HrsTeoria   { get; set; }
        public int HrsPractica { get; set; }
        public int SesionesEst { get; set; }
           public DateTime FechaExam { get; set; }
        public string Visitas { get; set; }
        public string Practicas { get; set; }
        public string ActEnseñanza   { get; set; }
        public string Recursos { get; set; }

        public DatosPlaneaciones()
        {

        }


        public DatosPlaneaciones(int idPlaneacion, int idGrupo, string nombreMateria, int iDdocente, string nombreDocente, int unidad, string competenciaMat, string caracterizacion, string temarioUnidad, string competenciaUnidad, string actAprendizaje, int hrsTeoria, int hrsPractica, int sesionesEst, DateTime fechaExam, string visitas, string practicas, string actEnseñanza, string recursos)
        {
            this.IdPlaneacion = idPlaneacion;
            this.IdGrupo = idGrupo;
            this.NombreMateria = nombreMateria;
            this.IDdocente = iDdocente;
            this.NombreDocente = nombreDocente;
            this.Unidad = unidad;
            this.CompetenciaMat = competenciaMat;
            this.Caracterizacion = caracterizacion;
            this.TemarioUnidad = temarioUnidad;
            this.CompetenciaUnidad = competenciaUnidad;
            this.ActAprendizaje = actAprendizaje;
            this.HrsTeoria = hrsTeoria;
            this.HrsPractica = hrsPractica;
            this.SesionesEst = sesionesEst;
            this.FechaExam = fechaExam;
            this.Visitas = visitas;
            this.Practicas = practicas;
            this.ActEnseñanza = actEnseñanza;
            this.Recursos = recursos;
        }

        


        

    }
}
