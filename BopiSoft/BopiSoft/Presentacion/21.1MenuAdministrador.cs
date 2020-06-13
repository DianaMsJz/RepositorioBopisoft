using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BopiSoft
{
    public partial class _21 : Form
    {
        public _21()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
    }
}
=======

        private void listaDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            _22RegistroListDoc RegistroListaDocente = new _22RegistroListDoc();

            RegistroListaDocente.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _21RegistroEditar RegistroListaPersonal = new _21RegistroEditar();

            RegistroListaPersonal.Show();
        }
    }
    }

>>>>>>> 284f12b... Tercer commit Registro de los usuarios
