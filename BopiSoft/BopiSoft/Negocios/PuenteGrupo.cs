﻿using BopiSoft.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BopiSoft.Negocios
{
<<<<<<< HEAD
<<<<<<< HEAD
    
=======

>>>>>>> 01c80df... 6to Commit: Login creado
=======

>>>>>>> 48fe993... Commit 7: Registrar alumnos
    class PuenteGrupo
    {
        RegistroGruposSql registro = new RegistroGruposSql();

        public void LlenarCombo(ComboBox combo)
        {
            registro.LlenarComboBoxCarreras(combo);
        }
<<<<<<< HEAD
=======

        public void AñadirGrupo(DatosGrupos datos)
        {
            registro.AñadirGrupo(datos);
        }

        public void ModificarGrupo(DatosGrupos datos)
        {
            registro.ModificarGrupo(datos);
        }

        public void GrupoBuscar(DatosGrupos datos)
        {
            registro.GrupoBuscar(datos);
        }

        public void GrupoEliminar(DatosGrupos datos)
        {
            registro.GrupoEliminar(datos);
        }

>>>>>>> 48fe993... Commit 7: Registrar alumnos
    }
}
