using BopiSoft.Datos;
using BopiSoft.Negocios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BopiSoft.Presentacion
{
    public partial class MenuDocenteJefe : Form
    {
        BDConexion bd = new BDConexion();
        PuenteGrupo puente = new PuenteGrupo();
        PuentePersonal puentep = new PuentePersonal();
        PuenteDepartamento puenteDpto = new PuenteDepartamento();

        _27MateriaLista lista = new _27MateriaLista();
        DatosGrupos datos = new DatosGrupos();
        DatosPersonal datosp = new DatosPersonal();
        RegistroGruposSql registro = new RegistroGruposSql();

        string IDGrupo;
        string NombreMateria;
        string NombreGrupo;
        int IdMateria;

        string IDdoc;
        int IdJefe;
        string nombredoc;
        string paternodoc;
        string maternodoc;
        string areadoc;
        byte[] fotodoc;

        public MenuDocenteJefe(string IDdoc, int idJefe,string nombredoc, string paternodoc, string maternodoc, string areadoc, byte[] fotodoc)
        {
            InitializeComponent();
            this.IDdoc = IDdoc;
            this.nombredoc = nombredoc;
            this.paternodoc = paternodoc;
            this.maternodoc = maternodoc;
            this.areadoc = areadoc;
            this.fotodoc = fotodoc;
            this.IdJefe = idJefe;
        }




        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out?", "Warning",
           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Form1 Login = new Form1();
                Login.Show();
            }
            else
            {


            }
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

       

        private void tablaGruposDOC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _2MenuDocente_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            pbFotoDoc.Image = byteArrayToImage(this.fotodoc);
            lbNombre.Text = nombredoc + " " + paternodoc + " " + maternodoc;
            lbArea.Text = areadoc;
            tablaGruposDOC.DataSource = bd.SelectDataTable("select * from lista_grupos where IdPersonal='" + IDdoc + "'");
        }

        private void tablaGruposDOC_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tablaGruposDOC_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow llenarIDGrupo = tablaGruposDOC.Rows[e.RowIndex];
            IDGrupo = Convert.ToString(llenarIDGrupo.Cells["IdGrupo"].Value);


            DataGridViewRow llenarNombreGrupo = tablaGruposDOC.Rows[e.RowIndex];
            NombreGrupo = Convert.ToString(llenarNombreGrupo.Cells["Nombre"].Value);


            DataGridViewRow llenarNombreMateria = tablaGruposDOC.Rows[e.RowIndex];
            NombreMateria = Convert.ToString(llenarNombreMateria.Cells["NombreMateria"].Value);

            DataGridViewRow llenarIdMateria = tablaGruposDOC.Rows[e.RowIndex];
            IdMateria = Convert.ToInt32(llenarIdMateria.Cells["IdMateria"].Value);

            PlaneacionJefe_11_ plan = new PlaneacionJefe_11_(IDGrupo,IdJefe, IdMateria, Convert.ToInt32(IDdoc));
            this.Hide();
            plan.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out?", "Warning",
         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Form1 Login = new Form1();
                Login.Show();
            }
            else
            {


            }

        }
    }
}
