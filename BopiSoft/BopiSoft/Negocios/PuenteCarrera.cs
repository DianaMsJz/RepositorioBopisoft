﻿using BopiSoft.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BopiSoft.Negocios
{
    class PuenteCarrera
    {
        RegistroCarrerasSql registro = new RegistroCarrerasSql();

        public void RegistroAñadir(DatosCarreras datos)
        {
            registro.RegistroAñadir(datos);
        }

        public void RegistroModificar(DatosCarreras datos)
        {
            registro.RegistroModificar(datos);
        }

        public void RegistroEliminar(DatosCarreras datos)
        {
            registro.RegistroEliminar(datos);
        }

        public void RegistroBuscar(DatosCarreras datos)
        {
            registro.RegistroBuscar(datos);
        }
<<<<<<< HEAD
=======

        public void ExisteCarreta(int ID)
        {
            registro.ExisteCarrera(ID);
        }
>>>>>>> 01c80df... 6to Commit: Login creado
    }
}
