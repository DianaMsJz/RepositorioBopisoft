using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BopiSoft.Datos
{
    class DatosPersonal
    {
        public int IdPersonal { get; set; }
        public String Tipo { get; set; }
        public String Nombre { get; set; }
        public String Apaterno { get; set; }
        public String Amaterno { get; set; }
        public String Sexo { get; set; }
        public String NombreDpto { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String Contraseña { get; set; }
        public byte[] Foto { get; set; }

        public DatosPersonal()
        {

        }

        public DatosPersonal(int idPersonal, string tipo, string nombre, string apaterno, string amaterno, string sexo, string nombreDpto, string direccion, string telefono, string contraseña, byte[] foto)
        {
            this.IdPersonal = idPersonal;
            this.Tipo = tipo;
            this.Nombre = nombre;
            this.Apaterno = apaterno;
            this.Amaterno = amaterno;
            this.Sexo = sexo;
            this.NombreDpto = nombreDpto;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Contraseña = contraseña;
            this.Foto = foto;
        }
        
       

    }
}
