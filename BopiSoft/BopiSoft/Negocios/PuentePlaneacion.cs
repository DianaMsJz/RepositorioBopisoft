<<<<<<< HEAD
﻿using System;
=======
﻿using BopiSoft.Datos;
using System;
>>>>>>> 031b574... Proyecto completo (Versión Final)
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using BopiSoft.Datos;
=======
>>>>>>> 031b574... Proyecto completo (Versión Final)

namespace BopiSoft.Negocios
{
    class PuentePlaneacion
    {
        RegistroPlaneacion registro = new RegistroPlaneacion();

        public void AñadirPlaneacion(DatosPlaneaciones datos)
        {
            registro.AñadirPlaneacion(datos);
        }

        public void ModificarPlaneacion(DatosPlaneaciones datos)
        {
            registro.ModificarPlaneacion(datos);
        }

        public void PlaneacionEliminar(DatosPlaneaciones datos)
        {
            registro.PlaneacionEliminar(datos);
        }

        public void PlaneacionBuscar(DatosPlaneaciones datos)
        {
            registro.PlaneacionBuscar(datos);
        }

<<<<<<< HEAD
=======
        public void PlaneacionBuscarId(DatosPlaneaciones datos)
        {
            registro.PlaneacionBuscarPorIdGrupo(datos);
        }
>>>>>>> 031b574... Proyecto completo (Versión Final)

        public void LlenarComboBoxUnidad(ComboBox combo)
        {
            registro.LlenarComboBoxUnidad(combo);
        }

        public void ExisteRegistro(int ID)
        {
            registro.ExisteRegistro(ID);
        }
<<<<<<< HEAD


=======
>>>>>>> 031b574... Proyecto completo (Versión Final)
    }
}
