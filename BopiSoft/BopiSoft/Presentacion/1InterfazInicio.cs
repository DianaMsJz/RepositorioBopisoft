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

        BDConexion bd = new BDConexion();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            _21RegistroEditar menuAdmin = new _21RegistroEditar();

            menuAdmin.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }
