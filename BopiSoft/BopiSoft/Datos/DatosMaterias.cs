using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BopiSoft.Datos
{
    class DatosMaterias
    {
        public int IdMateria {get; set; }
        public string Nombre { get; set; }
        public int Creditos {get; set; }
        public string Carrera {get; set; }
        public int Unidades {get; set; }
        public int Unidad { get; set; }
        public string Caracterizacion {get; set; }
        public string Competencia {get; set; }
        public string TemaUnidad {get; set; }
        public string SubtemaUnidad {get; set; }

        public DatosMaterias()
        {
        }

        public DatosMaterias(int idMateria, string nombre, int creditos, string carrera, int unidades,int unidad, string caracterizacion, string competencia, string temaUnidad, string subtemaUnidad)
        {
            IdMateria = idMateria;
            Nombre = nombre;
            Creditos = creditos;
            Carrera = carrera;
            Unidades = unidades;
            Unidad = unidad;
            Caracterizacion = caracterizacion;
            Competencia = competencia;
            TemaUnidad = temaUnidad;
            SubtemaUnidad = subtemaUnidad;
        }
    }
}
