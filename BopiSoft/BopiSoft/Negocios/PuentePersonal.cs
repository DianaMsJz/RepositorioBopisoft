using BopiSoft.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BopiSoft.Negocios
{
    class PuentePersonal
    {
        RegistroPersonalSql registro= new RegistroPersonalSql();

        public void RegistroAñadir(DatosPersonal datos)
        {
            registro.RegistroAñadir(datos);
        }

        public void RegistroModificar(DatosPersonal datos)
        {
            registro.RegistroModificar(datos);
        }

        public void RegistroEliminar(DatosPersonal datos)
        {
            registro.RegistroEliminar(datos);
        }

        public void RegistroBuscar(DatosPersonal datos)
        {
            registro.RegistroBuscar(datos);
        }

       
        public void LlenarCombo(ComboBox combo)
        {
            registro.LlenarComboBoxDptos(combo);
        }

        public void ExisteRegistro(int ID)
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
          
=======
>>>>>>> 01c80df... 6to Commit: Login creado
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
            registro.ExisteRegistro(ID);
        }
    }
}
