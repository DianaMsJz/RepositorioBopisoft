using BopiSoft.Datos;
using BopiSoft.Negocios;
using BopiSoft.Presentacion;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace BopiSoft
{
    public partial class _21RegistroEditar : Form
    {
        BDConexion bd = new BDConexion();
        PuentePersonal PuentePersonal = new PuentePersonal();
        DatosPersonal datos = new DatosPersonal();
        RegistroPersonalSql registroPersonal = new RegistroPersonalSql();
        

        public _21RegistroEditar()
        {
            InitializeComponent();
        }

        private void _21RegistroEditar_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            
            PuentePersonal.LlenarCombo(cmbDepartamento);
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (VerificadoCorrecto())
            {
                try
                {
                    datos.IdPersonal = Int32.Parse(txtIdPersonal.Text);
                    if (!registroPersonal.ExisteRegistro(datos.IdPersonal))
                    {
                        MessageBox.Show("Ya existe un registro con esa ID");
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream();
                        pbFoto.Image.Save(ms, ImageFormat.Jpeg);
                        byte[] imagen = ms.ToArray();
                        datos.Foto = imagen;

                   
                        datos.Tipo = cmbTipo.Text;
                        datos.NombreDpto =cmbDepartamento.Text;
                        datos.Nombre = txtNombre.Text;
                        datos.Apaterno = txtApaterno.Text;
                        datos.Amaterno = txtlbAmaterno.Text;
                        datos.Sexo = cmbSexo.Text;
                        datos.Direccion = txtDireccion.Text;
                        datos.Telefono = txtTelefono.Text;
                        datos.Contraseña = txtContraseña.Text;
                        PuentePersonal.RegistroAñadir(datos);
                        Limpiar();
                    }
                    
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(""+ ex);

                }
            }
            else
            {
                MessageBox.Show("ERROR LLENE TODOS LOS CAMPOS");
            } 
            
        }

        private void btnModi_Click(object sender, EventArgs e)
        {
            if(VerificadoCorrecto())
            {
                try
                {
<<<<<<< HEAD
<<<<<<< HEAD
                    MemoryStream ms = new MemoryStream();
                    pbFoto.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] imagen = ms.ToArray();
                    datos.Foto = imagen;

                    datos.IdPersonal= Int32.Parse(txtIdPersonal.Text);
                    datos.Tipo = cmbTipo.Text;
                    datos.NombreDpto = cmbDepartamento.Text;
                    datos.Nombre = txtNombre.Text;
                    datos.Apaterno = txtApaterno.Text;
                    datos.Amaterno = txtlbAmaterno.Text;
                    datos.Sexo = cmbSexo.Text;
                    datos.Direccion = txtDireccion.Text;
                    datos.Telefono = txtTelefono.Text;
                    datos.Contraseña = txtContraseña.Text;
                    PuentePersonal.RegistroModificar(datos);
                    Limpiar();
=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
                    datos.IdPersonal = Int32.Parse(txtIdPersonal.Text);
                    if (!registroPersonal.ExisteRegistro(datos.IdPersonal))
                    {
                        MemoryStream ms = new MemoryStream();
                        pbFoto.Image.Save(ms, ImageFormat.Jpeg);
                        byte[] imagen = ms.ToArray();
                        datos.Foto = imagen;

                        datos.IdPersonal = Int32.Parse(txtIdPersonal.Text);
                        datos.Tipo = cmbTipo.Text;
                        datos.NombreDpto = cmbDepartamento.Text;
                        datos.Nombre = txtNombre.Text;
                        datos.Apaterno = txtApaterno.Text;
                        datos.Amaterno = txtlbAmaterno.Text;
                        datos.Sexo = cmbSexo.Text;
                        datos.Direccion = txtDireccion.Text;
                        datos.Telefono = txtTelefono.Text;
                        datos.Contraseña = txtContraseña.Text;
                        PuentePersonal.RegistroModificar(datos);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No existe registro con esa ID");
                        
                    }
<<<<<<< HEAD
>>>>>>> 01c80df... 6to Commit: Login creado
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (txtIdPersonal.Text != "")
            {
                try
                {
                    datos.IdPersonal = Int32.Parse(txtIdPersonal.Text);
                    if (!registroPersonal.ExisteRegistro(datos.IdPersonal))
                    {
                        var n = MessageBox.Show("¿Está seguro que desea eliminar el registro con la ID "+datos.IdPersonal+"?","Confirmar eliminación",MessageBoxButtons.YesNo);
                        if (n == DialogResult.Yes)
                        {
                             PuentePersonal.RegistroEliminar(datos);
                             Limpiar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay registros con esa ID");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
               
            }
            else
            {
                MessageBox.Show("Id personal no valido, ingrese uno valido porfavor");
            }
            
        }

        private void btnBuscarClave_Click(object sender, EventArgs e)
        {

            if (txtIdPersonal.Text != "")
            {
                try
                {
                    datos.IdPersonal = Int32.Parse(txtIdPersonal.Text);
                    PuentePersonal.RegistroBuscar(datos);

                    cmbTipo.Text = datos.Tipo;
                    txtNombre.Text = datos.Nombre;
                    txtApaterno.Text = datos.Apaterno;
                    txtlbAmaterno.Text = datos.Amaterno;
                    cmbSexo.Text = datos.Sexo;
                    txtDireccion.Text = datos.Direccion;
                    txtTelefono.Text = datos.Telefono;
                    cmbDepartamento.Text=datos.NombreDpto;
                    txtContraseña.Text = datos.Contraseña;
                    pbFoto.Image = byteArrayToImage(datos.Foto);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Algo salió mal " + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("ERROR ESCRIBA UNA ID");
            }


        }
        
 
        public Boolean VerificadoCorrecto()
        {
            Boolean v;
            if (txtIdPersonal.Text.Equals("") || cmbTipo.Text.Equals("") || cmbDepartamento.Text.Equals("") || txtNombre.Text.Equals("") || txtApaterno.Text.Equals("") ||
                txtlbAmaterno.Text.Equals("") || cmbSexo.Text.Equals("") || txtDireccion.Text.Equals("") || txtTelefono.Text.Equals("")  ||
                txtContraseña.Text.Equals("") || pbFoto.Image==null)
            {
                //MessageBox.Show("HAY CAMPOS VACIOS POR FAVOR VERIFIQUE");
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
<<<<<<< HEAD
                cmbTipo.Text = "";
=======
            cmbTipo.Text = "";
>>>>>>> 48fe993... Commit 7: Registrar alumnos
            cmbDepartamento.Text="";
            txtNombre.Text = "";
            txtApaterno.Text = "";
            txtlbAmaterno.Text = "";
<<<<<<< HEAD
                cmbSexo.Text = "";
=======
            cmbSexo.Text = "";
>>>>>>> 48fe993... Commit 7: Registrar alumnos
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtContraseña.Text = "";
            pbFoto.Image = null;
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void listaDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            _22RegistroListDoc listadoc = new _22RegistroListDoc();

           listadoc.Show();
        }

        public static void SoloNumeros(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(char.IsControl(e.KeyChar))
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
            else if(char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtApaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtlbAmaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

       

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes|*.jpg; *.png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionar.Title = "Seleccionar imagen";

            if(ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                pbFoto.Image = Image.FromFile(ofdSeleccionar.FileName);
            }
        }
        

        private void carreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _24Carrera carrera = new _24Carrera();
            carrera.Show();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            _25MateriaEditar materia= new _25MateriaEditar();
            materia.Show();
        }
        
        private void cmbTipo_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            datos.IdPersonal = Convert.ToInt32(txtIdPersonal.Text);
            if (!registroPersonal.ExisteRegistro(datos.IdPersonal))
            {
                MessageBox.Show("Ya existe un registro con esa ID");
            }
=======
            ////datos.IdPersonal = Convert.ToInt32(txtIdPersonal.Text);
            //if (!registroPersonal.ExisteRegistro(datos.IdPersonal))
            //{
            //    MessageBox.Show("Ya existe un registro con esa ID");
            //}
>>>>>>> 01c80df... 6to Commit: Login creado
=======
            if(txtIdPersonal.Text != "")
            {
                datos.IdPersonal = Convert.ToInt32(txtIdPersonal.Text);
                if (!registroPersonal.ExisteRegistro(datos.IdPersonal))
                {
                    MessageBox.Show("Ya existe un registro con esa ID");
                }
            }
           
>>>>>>> 48fe993... Commit 7: Registrar alumnos
        }

        private void toolStripListaDocente_Click(object sender, EventArgs e)
        {
             this.Hide();
            _22RegistroListDoc _22Registro = new _22RegistroListDoc();
            _22Registro.Show();
        }
        
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _21RegistroEditar _21Registro = new _21RegistroEditar();
            _21Registro.Show();
        }

        private void listaJefeToolStripMenuItem_Click(object sender, EventArgs e)
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
=======

        private void txtIdPersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

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
>>>>>>> 48fe993... Commit 7: Registrar alumnos
    }
}
