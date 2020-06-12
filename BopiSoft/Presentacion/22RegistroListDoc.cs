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
    public partial class _22RegistroListDoc : Form
    {
        BDConexion bd = new BDConexion();

        public _22RegistroListDoc()
        {
            InitializeComponent();
        }

        private void _22RegistroListDoc_Load(object sender, EventArgs e)
        {
            GRID1.DataSource = bd.SelectDataTable("select * from lista_personal where Tipo=Docente");
        }
    }
}
