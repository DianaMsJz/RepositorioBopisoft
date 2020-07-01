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

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
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
=======
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
        public void Añadir(DatosAlumnosGrupos datos)
        {
            registro.Añadir(datos);
        }
        public void RegistroModificar(DatosAlumnosGrupos datos)
        {
            registro.Modificar(datos);
        }

        public void RegistroEliminar(DatosAlumnosGrupos datos)
        {
            registro.Eliminar(datos);
        }

        public void Buscar(DatosAlumnosGrupos datos)
        {
            registro.AlumnoBuscar(datos);
        }

<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
    }
}
