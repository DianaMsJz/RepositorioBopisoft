using BopiSoft.Datos;
using BopiSoft.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BopiSoft.Presentacion
{
    public partial class _25MateriaContenido : Form
    {
        PuenteMaterias puente = new PuenteMaterias();
        DatosMaterias datos = new DatosMaterias();
        _27MateriaLista lista = new _27MateriaLista();
        RegistroMateriaSql Registro = new RegistroMateriaSql();

        int s = 1;

        public _25MateriaContenido()
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

        private void _25MateriaContenido_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            lista.Show();
            MessageBox.Show("Selecciona la materia para obtener la clave");
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (VerificadoCorrecto())
            {
                try
                {
                    datos.IdMateria = Int32.Parse(txtClave.Text);
                    datos.Unidad =Convert.ToInt32(cmbUnidad.SelectedItem);
                    datos.TemaUnidad = txtTema.ToString();
                    datos.SubtemaUnidad = txtSubtema.ToString();
                    puente.RegistroAñadirContenido(datos);
                    Limpiar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            }
            else
            {
                MessageBox.Show("ERROR LLENE TODOS LOS CAMPOS");
            }
        }

        public Boolean VerificadoCorrecto()
        {
            Boolean v;
            if (txtClave.Text.Equals("") || cmbUnidad.Text.Equals("") || txtTema.Text.Equals("") || txtSubtema.Text.Equals("") )
            {
                MessageBox.Show("HAY CAMPOS VACIOS POR FAVOR VERIFIQUE");
                v = false;
            }
            else
            {
                v = true;
            }
            return v;
        }
        public void Limpiar()
        {
            txtClave.Text = "";
            txtTema.Text = "";
            cmbUnidad.SelectedIndex = 0;
            txtSubtema.Text = "";
        }

        private void cmbUnidad_Click(object sender, EventArgs e)
        {
            datos.IdMateria = Int32.Parse(txtClave.Text);
            puente.RegistroBuscar(datos);
            if (s == 1)
            {
               for (int i = 0; i < datos.Unidades; i++)
                {
                    cmbUnidad.Items.Insert(i, i + 1);
                    
                }
                s++;
            }
            
        }

        private void cmbUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            datos.IdMateria= Int32.Parse(txtClave.Text);
            datos.Unidad = Convert.ToInt32(cmbUnidad.Text);

            if (!Registro.ExisteContenidoDeEsaUnidad(datos.IdMateria,datos.Unidad))
            {
                puente.BuscarContenido(datos);
                txtTema.Text = datos.TemaUnidad;
                txtSubtema.Text = datos.SubtemaUnidad;
            }

        }

        private void btnModi_Click(object sender, EventArgs e)
        {
            if (VerificadoCorrecto())
            {
                if (!Registro.ExisteContenidoDeEsaUnidad(datos.IdMateria, datos.Unidad))
                {
                    try
                    {
                        datos.IdMateria = Int32.Parse(txtClave.Text);
                        datos.Unidad = Convert.ToInt32(cmbUnidad.SelectedItem);
                        datos.TemaUnidad = txtTema.ToString();
                        datos.SubtemaUnidad = txtSubtema.ToString();
                        puente.RegistroModificar(datos);
                        Limpiar();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);

                    }
                }
                else
                {
                    MessageBox.Show("No hay registros");
                }
            }
            else
            {
                //MessageBox.Show("ERROR LLENE TODOS LOS CAMPOS");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text != "" && cmbUnidad.Text !="")
            {
                try
                {
                    datos.IdMateria = Int32.Parse(txtClave.Text);
                    datos.Unidad = Convert.ToInt32(cmbUnidad.Text);
                    if (!Registro.ExisteContenidoDeEsaUnidad(datos.IdMateria, datos.Unidad))
                    {
                        var n = MessageBox.Show("¿Está seguro que desea eliminar el contenido de la unidad " + datos.Unidad + " con la Id de la materia "+datos.IdMateria+ "?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                        if (n == DialogResult.Yes)
                        {
                            puente.RegistroEliminarContenido(datos);
                            Limpiar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay registros ");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }
    }

}
