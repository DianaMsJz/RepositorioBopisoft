using BopiSoft.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
using System.Windows.Forms;
>>>>>>> 01c80df... 6to Commit: Login creado
=======
using System.Windows.Forms;
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
using System.Windows.Forms;
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
using System.Windows.Forms;
>>>>>>> 80c648b... Commit 9 registro de las planeaciones

namespace BopiSoft.Negocios
{
    class PuenteDepartamento
    {
        RegistroDepartamentoSql registro = new RegistroDepartamentoSql();

        public void RegistroAñadir(DatosDepartamentos datos)
        {
            registro.RegistroAñadir(datos);
        }

        public void RegistroModificar(DatosDepartamentos datos)
        {
            registro.RegistroModificar(datos);
        }

        public void RegistroEliminar(DatosDepartamentos datos)
        {
            registro.RegistroEliminar(datos);
        }

        public void RegistroBuscar(DatosDepartamentos datos)
        {
            registro.RegistroBuscar(datos);
        }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
        public void LlenarComboBoxDeptos(ComboBox combo)
        {
            registro.LlenarComboBoxDeptos(combo);
        }
        public void ExisteDepto(int ID)
        {
            registro.ExisteDepto(ID);
        }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 01c80df... 6to Commit: Login creado
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
=======
>>>>>>> 80c648b... Commit 9 registro de las planeaciones
    }
}
