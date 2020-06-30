using BopiSoft.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BopiSoft.Negocios
{
    class PuenteAlumnos
    {
        RegistroListaAlumnosSql registro = new RegistroListaAlumnosSql();

        public void AñadirAlumno(DatosAlumnosGrupos datos)
        {
            registro.AñadirAlumno(datos);
        }
        public void BuscarAlumno(DatosAlumnosGrupos datos)
        {
            registro.AlumnoBuscar(datos);
        }
        public void ModificarAlumno(DatosAlumnosGrupos datos)
        {
            registro.ModificarAlumno(datos);
        }
        public void EliminarAlumno(DatosAlumnosGrupos datos)
        {
            registro.AlumnoEliminar(datos);
        }
    }
}
