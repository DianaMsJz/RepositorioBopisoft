﻿using BopiSoft.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BopiSoft.Negocios
{
    class PuenteMaterias
    {
        RegistroMateriaSql  registro = new RegistroMateriaSql();

        public void RegistroAñadir(DatosMaterias datos)
        {
            registro.RegistroAñadir(datos);
        }

        public void RegistroAñadirContenido(DatosMaterias datos)
        {
            registro.RegistroAñadirContenido(datos);
        }

        public void RegistroModificar(DatosMaterias datos)
        {
            registro.RegistroModificar(datos);
        }

<<<<<<< HEAD
=======
        public void RegistroModificarContenido(DatosMaterias datos)
        {
            registro.RegistroModificarContenido(datos);
        }

>>>>>>> 48fe993... Commit 7: Registrar alumnos
        public void RegistroEliminar(DatosMaterias datos)
        {
            registro.RegistroEliminar(datos);
        }

        public void RegistroEliminarContenido(DatosMaterias datos)
        {
            registro.RegistroEliminarContenido(datos);
        }

        public void RegistroBuscar(DatosMaterias datos)
        {
            registro.RegistroBuscar(datos);
        }

        public void LlenarCombo(ComboBox combo)
        {
            registro.LlenarComboBoxCarreras(combo);
        }

        public void BuscarContenido(DatosMaterias datos)
        {
            registro.RegistroBuscarContenido(datos);
        }
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
        public void ExisteMateria(int ID)
        {
            registro.ExisteMateria(ID);
        }
<<<<<<< HEAD
>>>>>>> 01c80df... 6to Commit: Login creado
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos

    }
}
