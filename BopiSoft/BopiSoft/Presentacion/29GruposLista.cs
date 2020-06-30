<<<<<<< HEAD
<<<<<<< HEAD
﻿using BopiSoft.Presentacion;
=======
﻿using BopiSoft.Negocios;
using BopiSoft.Presentacion;
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
﻿using BopiSoft.Negocios;
using BopiSoft.Presentacion;
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
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
    public partial class _29GruposLista : Form
    {
<<<<<<< HEAD
<<<<<<< HEAD
=======
        BDConexion bd = new BDConexion();
        PuenteMaterias puenteMat = new PuenteMaterias();

>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
        BDConexion bd = new BDConexion();
        PuenteMaterias puenteMat = new PuenteMaterias();

>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
        public _29GruposLista()
        {
            InitializeComponent();
        }

        

        private void toolStripMenuItem2_Click_2(object sender, EventArgs e)
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

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            _23RegistroListaJefe _23Registro = new _23RegistroListaJefe();
            _23Registro.Show();
        }

        private void registroCarreraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            _24Carrera carrera = new _24Carrera();
            carrera.Show();
        }

        private void registroMateriaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            _25MateriaEditar _25Materia = new _25MateriaEditar();
            _25Materia.Show();
        }

        private void contenidoMateriaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            _25MateriaContenido contenido = new _25MateriaContenido();
            contenido.Show();
        }

        private void listaMateriaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            _27MateriaLista materiaLista = new _27MateriaLista();
            materiaLista.Show();
        }

        private void registroGrupoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            _28GruposEditra grupos = new _28GruposEditra();
            grupos.Show();
        }

        private void listaGrupoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            _29GruposLista gruposLista = new _29GruposLista();
            gruposLista.Show();
        }

        private void registroDepartamentoToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            _30Departamento departamento = new _30Departamento();
            departamento.Show();
        }
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cmbCarrera.Text != ""  && cmbSemestre.Text != "" && cmbTurno.Text != "")
            {
                String carrera = cmbCarrera.Text;
                String semestre = cmbSemestre.Text;
                String turno = cmbTurno.Text;
                GRID1.DataSource = bd.SelectDataTable("select * from lista_grupos where NombreCarrera='"+carrera+"' and Semestre='" + semestre + "' and Turno='"+ turno + "'");
            }
            else
            {
                MessageBox.Show("Seleccione la carrera, semestre y turno");
            }
        }

        private void _29GruposLista_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            puenteMat.LlenarCombo(cmbCarrera);
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
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
<<<<<<< HEAD
>>>>>>> 48fe993... Commit 7: Registrar alumnos
=======
>>>>>>> 90e77cf... Commit #8: Registro de calificaciones y evidencias
    }


}
