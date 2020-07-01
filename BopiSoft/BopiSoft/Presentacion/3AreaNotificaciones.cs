<<<<<<< HEAD
﻿using System;
=======
﻿using BopiSoft.Datos;
using BopiSoft.Negocios;
using MySql.Data.MySqlClient;
using System;
>>>>>>> 031b574... Proyecto completo (Versión Final)
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
    public partial class AreaNotificaciones : Form
    {
<<<<<<< HEAD
        public AreaNotificaciones()
        {
            InitializeComponent();
        }

        
=======
        BDConexion bd = new BDConexion();
        DatosPersonal datos = new DatosPersonal();
        PuentePersonal puente = new PuentePersonal();
        int IdDoc;
        public AreaNotificaciones(int IdDocente)
        {
            InitializeComponent();
            this.IdDoc = IdDocente;
        }

        private void AreaNotificaciones_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            dataGridView1.DataSource = bd.SelectDataTable("select * from revision_docente where IdDocente='"+IdDoc+"'");
        }

        private void lbRegresar_Click(object sender, EventArgs e)
        {
            bd.connecttodb();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM lista_personal WHERE IdPersonal='" + IdDoc + "' ", bd.connect);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                datos.IdPersonal = IdDoc;
                puente.RegistroBuscar(datos);
                string NombreDoc = datos.Nombre;
                string MaternoDoc = datos.Amaterno;
                String PaternoDoc = datos.Apaterno;
                string Area = datos.NombreDpto;
                byte[] Foto = datos.Foto;

                this.Hide();
                _2MenuDocente MenuDocenteObj = new _2MenuDocente(IdDoc.ToString(), NombreDoc, PaternoDoc, MaternoDoc, Area, Foto);
                MenuDocenteObj.Show();
            }
        }
>>>>>>> 031b574... Proyecto completo (Versión Final)
    }
}
