<<<<<<< HEAD
<<<<<<< HEAD
﻿using BopiSoft.Presentacion;
=======
﻿using BopiSoft.Datos;
using BopiSoft.Presentacion;
>>>>>>> 6591c39... 5to Commit
=======
﻿using BopiSoft.Datos;
using BopiSoft.Negocios;
using BopiSoft.Presentacion;
>>>>>>> 01c80df... 6to Commit: Login creado
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
<<<<<<< HEAD
<<<<<<< HEAD
=======
        DatosGrupos datos = new DatosGrupos();
>>>>>>> 6591c39... 5to Commit
=======
        DatosGrupos datos = new DatosGrupos();
        PuenteDepartamento puente = new PuenteDepartamento();
>>>>>>> 01c80df... 6to Commit: Login creado

        public _22RegistroListDoc()
        {
            InitializeComponent();
        }

        private void _22RegistroListDoc_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
<<<<<<< HEAD
            GRID1.DataSource = bd.SelectDataTable("select * from lista_personal where Tipo='docente'");
=======
            puente.LlenarComboBoxDeptos(comboBox1);
            String depto;
            depto = comboBox1.Text;
            GRID1.DataSource = bd.SelectDataTable("select * from lista_personal where Tipo='docente' and NombreDpto='"+depto+"'");
>>>>>>> 01c80df... 6to Commit: Login creado
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            _21RegistroEditar _21Registro = new _21RegistroEditar();
            _21Registro.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            _22RegistroListDoc _22Registro = new _22RegistroListDoc();
            _22Registro.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            _23RegistroListaJefe _23Registro = new _23RegistroListaJefe();
            _23Registro.Show();
        }

        private void registroCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _24Carrera carrera = new _24Carrera();
            carrera.Show();
        }

        private void registroMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _25MateriaEditar _25Materia = new _25MateriaEditar();
            _25Materia.Show();
        }

        private void contenidoMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _25MateriaContenido contenido = new _25MateriaContenido();
            contenido.Show();
        }

        private void listaMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _27MateriaLista materiaLista = new _27MateriaLista();
            materiaLista.Show();
        }

        private void registroGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _28GruposEditra grupos = new _28GruposEditra();
            grupos.Show();
        }

        private void listaGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _29GruposLista gruposLista = new _29GruposLista();
            gruposLista.Show();
        }

        private void registroDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _30Departamento departamento = new _30Departamento();
            departamento.Show();
        }
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 01c80df... 6to Commit: Login creado

        private void GRID1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GRID1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _28GruposEditra grupos = new _28GruposEditra();
            DataGridViewRow llenarClave = GRID1.Rows[e.RowIndex];
<<<<<<< HEAD
            int IdPersonal= Convert.ToInt32(llenarClave.Cells["IdPersonal"].Value);
=======
            int IdPersonal = Convert.ToInt32(llenarClave.Cells["IdPersonal"].Value);
>>>>>>> 01c80df... 6to Commit: Login creado
            datos.IdPersonal = IdPersonal;
            MessageBox.Show(datos.IdPersonal.ToString());
            grupos.actualizarClaveDocente(datos.IdPersonal);
            grupos.Show();
            this.Hide();
        }
<<<<<<< HEAD
>>>>>>> 6591c39... 5to Commit
=======

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String depto;
            depto = comboBox1.Text;
            GRID1.DataSource = bd.SelectDataTable("select * from lista_personal where Tipo='docente' and NombreDpto='" + depto + "'");
        }
>>>>>>> 01c80df... 6to Commit: Login creado
    }
}
