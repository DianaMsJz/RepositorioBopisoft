<<<<<<< HEAD
<<<<<<< HEAD
﻿using BopiSoft.Presentacion;
=======
﻿using BopiSoft.Datos;
using BopiSoft.Negocios;
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
    public partial class _28GruposEditra : Form
    {
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 01c80df... 6to Commit: Login creado
        PuenteGrupo puente = new PuenteGrupo();
        _27MateriaLista lista = new _27MateriaLista();
        _22RegistroListDoc listaDoc = new _22RegistroListDoc();
        DatosGrupos datos = new DatosGrupos();

<<<<<<< HEAD
>>>>>>> 6591c39... 5to Commit
=======
>>>>>>> 01c80df... 6to Commit: Login creado
        public _28GruposEditra()
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

        private void _28GruposEditra_Load(object sender, EventArgs e)
        {
            
=======

        private void _28GruposEditra_Load(object sender, EventArgs e)
        {

>>>>>>> 01c80df... 6to Commit: Login creado
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            puente.LlenarCombo(cmbCarrera);
        }

<<<<<<< HEAD
        private void btnBuscarMateria_Click(object sender, EventArgs e)
=======

        public void actualizarNombreMateria(String nombreMateria)
        {
            txtNombreMat.Text = nombreMateria;
        }

        public void actualizarClaveDocente(int IdPersonal)
        {
            txtClaveDoc.Text = IdPersonal.ToString();
        }

        private void btnBuscarMateria_Click_1(object sender, EventArgs e)
>>>>>>> 01c80df... 6to Commit: Login creado
        {
            lista.form = 2;
            this.Hide();
            lista.Show();
            MessageBox.Show("Selecciona la materia para obtener el nombre");
        }

<<<<<<< HEAD
        private void btnBuscarDocente_Click(object sender, EventArgs e)
=======
        private void btnBuscarDocente_Click_1(object sender, EventArgs e)
>>>>>>> 01c80df... 6to Commit: Login creado
        {
            this.Hide();
            listaDoc.Show();
            MessageBox.Show("Selecciona el docente para obtener la clave");
        }

<<<<<<< HEAD
        public void actualizarNombreMateria(String nombreMateria)
        {
            txtNombreMat.Text =nombreMateria;
        }

        public void actualizarClaveDocente(int IdPersonal)
        {
            txtClaveDoc.Text =IdPersonal.ToString();
=======
        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
>>>>>>> 01c80df... 6to Commit: Login creado
        }

        public static void SoloNumeros(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void SoloLetras(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

<<<<<<< HEAD
        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
>>>>>>> 6591c39... 5to Commit
=======
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }
>>>>>>> 01c80df... 6to Commit: Login creado
    }
}
