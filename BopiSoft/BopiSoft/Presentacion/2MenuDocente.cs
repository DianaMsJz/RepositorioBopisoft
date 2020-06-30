using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
using MySql.Data.MySqlClient;

using System.Configuration;
using System.Data.SqlClient;
using BopiSoft.Datos;
using BopiSoft.Negocios;
using BopiSoft.Presentacion;




using System.IO;

<<<<<<< HEAD
>>>>>>> 01c80df... 6to Commit: Login creado

namespace BopiSoft
{
    public partial class MenuDocente : Form
    {
<<<<<<< HEAD
        public MenuDocente()
        {
            InitializeComponent();
        }

       
=======
=======

namespace BopiSoft
{
    public partial class _2MenuDocente : Form
    {
        BDConexion bd = new BDConexion();
        PuenteGrupo puente = new PuenteGrupo();
        PuenteDepartamento puenteDpto = new PuenteDepartamento();

        _27MateriaLista lista = new _27MateriaLista();



        DatosGrupos datos = new DatosGrupos();
        RegistroGruposSql registro = new RegistroGruposSql();

        string IDGrupo;
        string NombreMateria;
        string NombreGrupo;

        string IDdoc;
>>>>>>> 48fe993... Commit 7: Registrar alumnos
        string nombredoc;
        string paternodoc;
        string maternodoc;
        string areadoc;
        byte[] fotodoc;

<<<<<<< HEAD
        public MenuDocente(string nombredoc, string paternodoc, string maternodoc, string areadoc, byte[] fotodoc)
        {
            InitializeComponent();
=======
        public _2MenuDocente(string IDdoc, string nombredoc, string paternodoc, string maternodoc, string areadoc, byte[] fotodoc)
        {
            InitializeComponent();
            this.IDdoc = IDdoc;
>>>>>>> 48fe993... Commit 7: Registrar alumnos
            this.nombredoc = nombredoc;
            this.paternodoc = paternodoc;
            this.maternodoc = maternodoc;
            this.areadoc = areadoc;
            this.fotodoc = fotodoc;
        }

<<<<<<< HEAD
        BDConexion bd = new BDConexion();
        PuentePersonal PuentePersonal = new PuentePersonal();
        DatosPersonal datos = new DatosPersonal();
        RegistroPersonalSql registroPersonal = new RegistroPersonalSql();
=======
     
>>>>>>> 48fe993... Commit 7: Registrar alumnos


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

        private void MenuDocente_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            pbFotoDoc.Image = byteArrayToImage(this.fotodoc);
            lbNombre.Text = nombredoc + " " + paternodoc + " " + maternodoc;
            lbArea.Text = areadoc;
<<<<<<< HEAD
=======
            tablaGruposDOC.DataSource = bd.SelectDataTable("select * from lista_grupos where IdPersonal='" + IDdoc + "'");

>>>>>>> 48fe993... Commit 7: Registrar alumnos
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

<<<<<<< HEAD
>>>>>>> 01c80df... 6to Commit: Login creado
=======
        private void tablaGruposDOC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow llenarIDGrupo = tablaGruposDOC.Rows[e.RowIndex];
            IDGrupo = Convert.ToString(llenarIDGrupo.Cells["IdGrupo"].Value);
           

            DataGridViewRow llenarNombreGrupo = tablaGruposDOC.Rows[e.RowIndex];
            NombreGrupo = Convert.ToString(llenarNombreGrupo.Cells["Nombre"].Value);
         

            DataGridViewRow llenarNombreMateria = tablaGruposDOC.Rows[e.RowIndex];
            NombreMateria = Convert.ToString(llenarNombreMateria.Cells["NombreMateria"].Value);
            
            ListaAlumnos AlumnosLista = new ListaAlumnos(IDGrupo, NombreGrupo,NombreMateria,Convert.ToInt32(IDdoc));
            this.Hide();
            AlumnosLista.Show(); 
        }
>>>>>>> 48fe993... Commit 7: Registrar alumnos
    }
}
