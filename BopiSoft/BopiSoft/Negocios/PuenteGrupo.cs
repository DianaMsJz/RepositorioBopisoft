using BopiSoft.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BopiSoft.Negocios
{
<<<<<<< HEAD
    
=======

>>>>>>> 01c80df... 6to Commit: Login creado
    class PuenteGrupo
    {
        RegistroGruposSql registro = new RegistroGruposSql();

        public void LlenarCombo(ComboBox combo)
        {
            registro.LlenarComboBoxCarreras(combo);
        }
    }
}
