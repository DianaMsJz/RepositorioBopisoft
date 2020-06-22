using BopiSoft.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
=======
using System.Windows.Forms;
>>>>>>> 01c80df... 6to Commit: Login creado

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
=======
        public void LlenarComboBoxDeptos(ComboBox combo)
        {
            registro.LlenarComboBoxDeptos(combo);
        }
        public void ExisteDepto(int ID)
        {
            registro.ExisteDepto(ID);
        }
>>>>>>> 01c80df... 6to Commit: Login creado
    }
}
