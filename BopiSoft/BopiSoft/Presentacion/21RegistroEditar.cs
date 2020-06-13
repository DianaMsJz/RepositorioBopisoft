using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
>>>>>>> 284f12b... Tercer commit Registro de los usuarios
using System.Windows.Forms;

namespace BopiSoft
{
    public partial class _21RegistroEditar : Form
    {
        BDConexion bd = new BDConexion();

        public _21RegistroEditar()
        {
            InitializeComponent();
        }

        private void _21RegistroEditar_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            dataGridRegistros.DataSource = bd.SelectDataTable("select * from lista_personal");
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (VerificadoCorrecto())
            {
                String IdPersonal = txtIdPersonal.Text;
                String Tipo = cmbTipo.Text;
                String IdDepartamento = txtClaveDep.Text;
                String Nombre = txtNombre.Text;
                String Apaterno = txtApaterno.Text;
                String Amaterno = txtlbAmaterno.Text;
                String Sexo = cmbSexo.Text;
                String Direccion = txtDireccion.Text;
                String Telefono = txtTelefono.Text;
                String Email = txtEmail.Text;
                String Contraseña = txtContraseña.Text;
                String Foto = txtFoto.Text;

                string agregar = "insert into lista_personal values ('" + IdPersonal + "','" + Tipo + "','" + IdDepartamento + "','" + Nombre + "','" + Apaterno
                    + "','" + Amaterno + "','" + Sexo + "','" + Direccion + "','" + Telefono + "','" + Email + "','" + Contraseña + "','" + Foto + "')";

                if (bd.executecommand(agregar))
                {
                    dataGridRegistros.DataSource = bd.SelectDataTable("select * from lista_personal");
                    Limpiar();
                    MessageBox.Show("Agregado con exito!");
                }
                else
                {
                    MessageBox.Show("Algo salió mal, intente de nuevo");
                }




            }
            else
            {
                MessageBox.Show("ERROR LLENE TODOS LOS CAMPOS");
            } 

           


        }

        private void btnModi_Click(object sender, EventArgs e)
        {
            if (txtIdPersonal.Text =="")
            {
                MessageBox.Show("Id personal VACIO, PORFAVOR INGRESE UNO VALIDO");
            }
            else
            {

                string actualizar = "update lista_personal set Tipo='" + cmbTipo.Text + "', Nombre='" + txtNombre.Text + "', Apaterno='" + txtApaterno.Text +
               "', Amaterno='" + txtlbAmaterno.Text + "', Sexo='" + cmbSexo.Text + "', Direccion='" + txtDireccion.Text + "', Telefono='" + txtTelefono.Text +
               "', Email='" + txtEmail.Text + "', Contraseña='" + txtContraseña.Text + "', Foto='" + txtFoto.Text + "' where IdPersonal=" + txtIdPersonal.Text;

                if (bd.executecommand(actualizar))
                {
                    dataGridRegistros.DataSource = bd.SelectDataTable("select * from lista_personal");
                    MessageBox.Show("Datos actualizados con exito!");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar, intente de nuevo");
                }



            }

           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdPersonal.Text == "")
            {

                MessageBox.Show("Id personal no valido, ingrese uno valido porfavor");


            }
            else
            {
                string eliminar = "delete from lista_personal where IdPersonal=" + txtIdPersonal.Text;
                if (bd.executecommand(eliminar))
                {
                    dataGridRegistros.DataSource = bd.SelectDataTable("select * from lista_personal");
                    MessageBox.Show("Personal eliminado con exito!");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar, intente de nuevo");
                }

            }

            

        }

        private void btnBuscarClave_Click(object sender, EventArgs e)
        {
            string buscarporID = "select * from lista_personal where IdPersonal=" + txtIdPersonal.Text;
          
             



           

            if (bd.executecommand(buscarporID))
            {
                dataGridRegistros.DataSource = bd.SelectDataTable(buscarporID);

                if (dataGridRegistros.Rows!=null)
                {
                    //Pasamos el usuario o personal encontrado a los txtbox
                    txtIdPersonal.Text = dataGridRegistros.CurrentRow.Cells[0].Value.ToString();
                    cmbTipo.Text = dataGridRegistros.CurrentRow.Cells[1].Value.ToString();
                    txtClaveDep.Text = dataGridRegistros.CurrentRow.Cells[2].Value.ToString();
                    txtNombre.Text = dataGridRegistros.CurrentRow.Cells[3].Value.ToString();
                    txtApaterno.Text = dataGridRegistros.CurrentRow.Cells[4].Value.ToString();
                    txtlbAmaterno.Text = dataGridRegistros.CurrentRow.Cells[5].Value.ToString();
                    cmbSexo.Text = dataGridRegistros.CurrentRow.Cells[6].Value.ToString();
                    txtDireccion.Text = dataGridRegistros.CurrentRow.Cells[7].Value.ToString();
                    txtTelefono.Text = dataGridRegistros.CurrentRow.Cells[8].Value.ToString();
                    txtEmail.Text = dataGridRegistros.CurrentRow.Cells[9].Value.ToString();
                    txtContraseña.Text = dataGridRegistros.CurrentRow.Cells[10].Value.ToString();
                    txtFoto.Text = dataGridRegistros.CurrentRow.Cells[11].Value.ToString();

                    MessageBox.Show("Encontrado!");
                }

               
            }
            else
            {
                MessageBox.Show("No se encontro nada, intente de nuevo");
            }

        }

        private void dataGridRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                
            }
            catch
            {
                MessageBox.Show("Ha habido un error!");
            }
        }

        private void dataGridRegistros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridRegistros.DataSource = bd.SelectDataTable("select * from lista_personal");
        }


        public Boolean VerificadoCorrecto()
        {
            Boolean v;
            if (txtIdPersonal.Text.Equals("") || cmbTipo.Text.Equals("") || txtClaveDep.Text.Equals("") || txtNombre.Text.Equals("") || txtApaterno.Text.Equals("") ||
                txtlbAmaterno.Text.Equals("") || cmbSexo.Text.Equals("") || txtDireccion.Text.Equals("") || txtTelefono.Text.Equals("") || txtEmail.Text.Equals("") ||
                txtContraseña.Text.Equals("") || txtFoto.Text.Equals(""))
            {
                MessageBox.Show("HAY CAMPOS VACIOS PORFAVOR VERIFIQUE");
                v = false;
            }
            else
            {
                v = true;
            }
            return v;
        }

        public  void Limpiar()
        {
            txtIdPersonal.Text = "";
                cmbTipo.Text = "";
            txtClaveDep.Text = "";
            txtNombre.Text = "";
            txtApaterno.Text = "";
            txtlbAmaterno.Text = "";
                cmbSexo.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtContraseña.Text = "";
            txtFoto.Text = "";


        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            Limpiar();
>>>>>>> 284f12b... Tercer commit Registro de los usuarios
        }
    }
}
