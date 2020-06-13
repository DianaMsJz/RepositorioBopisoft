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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
=======
        BDConexion bd = new BDConexion();

        private void Form1_Load(object sender, EventArgs e)
        {
            
    }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            _21 menuAdmin = new _21();

            menuAdmin.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }
>>>>>>> 284f12b... Tercer commit Registro de los usuarios
