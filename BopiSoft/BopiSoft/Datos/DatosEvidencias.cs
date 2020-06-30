using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BopiSoft.Datos
{
    class DatosEvidencias
    {
        public int IdGrupo { get; set; }
        public int NoUnidad { get; set; }
        public string Ruta1 { get; set; }
        public string Ruta2 { get; set; }
        public string Ruta3 { get; set; }
        public string Ruta4 { get; set; }
        public string Ruta5 { get; set; }
        public string Ruta6 { get; set; }
        public string Ruta7 { get; set; }
        public byte[] File1 { get; set; }
        public byte[] File2 { get; set; }
        public byte[] File3 { get; set; }
        public byte[] File4 { get; set; }
        public byte[] File5 { get; set; }
        public byte[] File6 { get; set; }
        public byte[] File7 { get; set; }
        public string Comentario { get; set; }

        public DatosEvidencias()
        {
        }

        public DatosEvidencias(int idGrupo, int noUnidad, string ruta1, string ruta2, string ruta3, string ruta4, string ruta5, string ruta6, string ruta7, byte[] file1, byte[] file2, byte[] file3, byte[] file4, byte[] file5, byte[] file6, byte[] file7, string comentario)
        {
            IdGrupo = idGrupo;
            NoUnidad = noUnidad;
            Ruta1 = ruta1;
            Ruta2 = ruta2;
            Ruta3 = ruta3;
            Ruta4 = ruta4;
            Ruta5 = ruta5;
            Ruta6 = ruta6;
            Ruta7 = ruta7;
            File1 = file1;
            File2 = file2;
            File3 = file3;
            File4 = file4;
            File5 = file5;
            File6 = file6;
            File7 = file7;
            Comentario = comentario;
        }
    }
}
