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


<<<<<<< HEAD
>>>>>>> 01c80df... 6to Commit: Login creado
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos

namespace BopiSoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BDConexion bd = new BDConexion();
<<<<<<< HEAD
<<<<<<< HEAD

=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
        PuentePersonal PuentePersonal = new PuentePersonal();
        DatosPersonal datos = new DatosPersonal();
        RegistroPersonalSql registroPersonal = new RegistroPersonalSql();

<<<<<<< HEAD
        string ID; 
        string Password;
       
>>>>>>> 01c80df... 6to Commit: Login creado
=======
        string IDtest;
        string ID; 
        string Password;
       
>>>>>>> 48fe993... Commit 7: Registrar alumnos
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

<<<<<<< HEAD
<<<<<<< HEAD
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            _21RegistroEditar menuAdmin = new _21RegistroEditar();

            menuAdmin.Show();
        }

        private void label1_Click(object sender, EventArgs e)
=======
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
        public void btnLogin_Click(object sender, EventArgs e)
        {
            ID = txtID.Text;
            Password = txtPassword.Text;
            if (validarSesion(ID,Password))
            {
                TestLogin();
            }
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {

        }

        public void limpiarLogin()
        {
            txtID.Text = "";
            txtPassword.Text = "";
        }

        public bool LoginVerificado(string txtboxID, string txtboxPassword)
        {
            Boolean v;
            if (txtboxID.Length<=0 || txtboxPassword.Length<=0)
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

<<<<<<< HEAD
        public bool ProcesarLogin()
        {

            Boolean v = true;
            ID = txtID.Text;
            Password = txtPassword.Text;

            if (LoginVerificado(ID, Password))
            {
                MessageBox.Show("Llene todos los campos porfavor");
                v = false;
                return v;
            }
            else
            {
                string tipoUsu;

                bd.connecttodb(); //Abrimos la conexion creada.
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM lista_personal WHERE IdPersonal='" + txtID.Text + "'AND Contraseña='" + txtPassword.Text + "' ", bd.connect); //Realizamos una selecion de la tabla usuarios.
                MySqlDataReader leer = cmd.ExecuteReader();
                if (leer.Read()) //Si el usuario es correcto nos abrira la otra ventana.
                {
                    datos.IdPersonal = Int32.Parse(txtID.Text);
                    PuentePersonal.RegistroBuscar(datos);
                    tipoUsu = datos.Tipo;

                    //Docente
                    //Jefe
                    //Admin

                    if (tipoUsu.Equals("Admin"))
                    {
                        this.Hide();
                        string Nombre = datos.Nombre;
                        string Materno = datos.Amaterno;
                        String Paterno = datos.Apaterno;
                        string Area = datos.NombreDpto;
                        byte[] Foto = datos.Foto;

                        _21 MenuAdministrador = new _21(Nombre, Paterno, Materno, Area, Foto);
                        MenuAdministrador.Show();
                        v = true;
                        return v;
                    }
                    if (tipoUsu.Equals("Jefe"))
                    {
                        this.Hide();
                        string Nombre = datos.Nombre;
                        string Materno = datos.Amaterno;
                        String Paterno = datos.Apaterno;
                        string Area = datos.NombreDpto;
                        byte[] Foto = datos.Foto;

                        MenuJefe menujefe = new MenuJefe(Nombre, Paterno, Materno, Area, Foto);
                        menujefe.Show();
                        v = true;
                        return v;
                    }
                    if (tipoUsu.Equals("Docente"))
                    {
                        this.Hide();
                        string Nombre = datos.Nombre;
                        string Materno = datos.Amaterno;
                        String Paterno = datos.Apaterno;
                        string Area = datos.NombreDpto;
                        byte[] Foto = datos.Foto;

                        MenuDocente MenuDocenteObj = new MenuDocente(Nombre, Paterno, Materno, Area, Foto);
                        MenuDocenteObj.Show();
                        v = true;
                        return v;
                    }


                }
                else
                { //Si no lo es mostrara este mensaje.
                    MessageBox.Show("Error, datos incorrectos o el usuario no existe.");
                    bd.closeconnection(); //Cerramos la conexion.
                    v = false;
                    return v;

                }


            }

            MessageBox.Show("");
            return v;


        }
=======
        //public bool ProcesarLogin()
        //{

        //    Boolean v = true;
        //    ID = txtID.Text;
        //    Password = txtPassword.Text;

        //    if (LoginVerificado(ID, Password))
        //    {
        //        MessageBox.Show("Llene todos los campos porfavor");
        //        v = false;
        //        return v;
        //    }
        //    else
        //    {
        //        string tipoUsu;

        //        bd.connecttodb(); //Abrimos la conexion creada.
        //        MySqlCommand cmd = new MySqlCommand("SELECT * FROM lista_personal WHERE IdPersonal='" + txtID.Text + "'AND Contraseña='" + txtPassword.Text + "' ", bd.connect); //Realizamos una selecion de la tabla usuarios.
        //        MySqlDataReader leer = cmd.ExecuteReader();
        //        if (leer.Read()) //Si el usuario es correcto nos abrira la otra ventana.
        //        {
        //            datos.IdPersonal = Int32.Parse(txtID.Text);
        //            PuentePersonal.RegistroBuscar(datos);
        //            tipoUsu = datos.Tipo;

        //            //Docente
        //            //Jefe
        //            //Admin

        //            if (tipoUsu.Equals("Admin"))
        //            {
        //                this.Hide();
        //                string Nombre = datos.Nombre;
        //                string Materno = datos.Amaterno;
        //                String Paterno = datos.Apaterno;
        //                string Area = datos.NombreDpto;
        //                byte[] Foto = datos.Foto;

        //                _21 MenuAdministrador = new _21(Nombre, Paterno, Materno, Area, Foto);
        //                MenuAdministrador.Show();
        //                v = true;
        //                return v;
        //            }
        //            if (tipoUsu.Equals("Jefe"))
        //            {
        //                this.Hide();
        //                string Nombre = datos.Nombre;
        //                string Materno = datos.Amaterno;
        //                String Paterno = datos.Apaterno;
        //                string Area = datos.NombreDpto;
        //                byte[] Foto = datos.Foto;

        //                MenuJefe menujefe = new MenuJefe(Nombre, Paterno, Materno, Area, Foto);
        //                menujefe.Show();
        //                v = true;
        //                return v;
        //            }
        //            if (tipoUsu.Equals("Docente"))
        //            {
        //                this.Hide();
        //                string Nombre = datos.Nombre;
        //                string Materno = datos.Amaterno;
        //                String Paterno = datos.Apaterno;
        //                string Area = datos.NombreDpto;
        //                byte[] Foto = datos.Foto;

        //                MenuDocente MenuDocenteObj = new MenuDocente(Nombre, Paterno, Materno, Area, Foto);
        //                MenuDocenteObj.Show();
        //                v = true;
        //                return v;
        //            }


        //        }
        //        else
        //        { //Si no lo es mostrara este mensaje.
        //            MessageBox.Show("Error, datos incorrectos o el usuario no existe.");
        //            bd.closeconnection(); //Cerramos la conexion.
        //            v = false;
        //            return v;

        //        }


        //    }

        //    MessageBox.Show("");
        //    return v;


        //}
>>>>>>> 48fe993... Commit 7: Registrar alumnos


        public void TestLogin()
        {
<<<<<<< HEAD
            
      



           
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos

                string tipoUsu;

                bd.connecttodb(); //Abrimos la conexion creada.
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM lista_personal WHERE IdPersonal='" + txtID.Text + "'AND Contraseña='" + txtPassword.Text + "' ", bd.connect); //Realizamos una selecion de la tabla usuarios.
                MySqlDataReader leer = cmd.ExecuteReader();
                if (leer.Read()) //Si el usuario es correcto nos abrira la otra ventana.
                {
                    datos.IdPersonal = Int32.Parse(txtID.Text);
                    PuentePersonal.RegistroBuscar(datos);
                    tipoUsu = datos.Tipo;

                    //Docente
                    //Jefe
                    //Admin

                    if (tipoUsu.Equals("Admin"))
                    {
                        this.Hide();
                        string Nombre = datos.Nombre;
                        string Materno = datos.Amaterno;
                        String Paterno = datos.Apaterno;
                        string Area = datos.NombreDpto;
                        byte[] Foto = datos.Foto;

                        _21 MenuAdministrador = new _21(Nombre, Paterno, Materno, Area, Foto);
                        MenuAdministrador.Show();
                       
                        
                    }
                    if (tipoUsu.Equals("Jefe"))
                    {
                        this.Hide();
                        string Nombre = datos.Nombre;
                        string Materno = datos.Amaterno;
                        String Paterno = datos.Apaterno;
                        string Area = datos.NombreDpto;
                        byte[] Foto = datos.Foto;

                        MenuJefe menujefe = new MenuJefe(Nombre, Paterno, Materno, Area, Foto);
                        menujefe.Show();
                        
                        
                    }
                    if (tipoUsu.Equals("Docente"))
                    {
                        this.Hide();
<<<<<<< HEAD
=======
                    string IDTest = txtID.Text;
>>>>>>> 48fe993... Commit 7: Registrar alumnos
                        string Nombre = datos.Nombre;
                        string Materno = datos.Amaterno;
                        String Paterno = datos.Apaterno;
                        string Area = datos.NombreDpto;
                        byte[] Foto = datos.Foto;

<<<<<<< HEAD
                        MenuDocente MenuDocenteObj = new MenuDocente(Nombre, Paterno, Materno, Area, Foto);
=======
                        _2MenuDocente MenuDocenteObj = new _2MenuDocente(IDTest, Nombre, Paterno, Materno, Area, Foto);
>>>>>>> 48fe993... Commit 7: Registrar alumnos
                        MenuDocenteObj.Show();
                      
                      
                    }
<<<<<<< HEAD


=======
                    
>>>>>>> 48fe993... Commit 7: Registrar alumnos
                }
                else
                { //Si no lo es mostrara este mensaje.
                    MessageBox.Show("Error, datos incorrectos o el usuario no existe.");
                    bd.closeconnection(); //Cerramos la conexion.
                  
<<<<<<< HEAD
                    

                }


                


            

=======
                }
                
>>>>>>> 48fe993... Commit 7: Registrar alumnos
        }

        public bool validarSesion(string id, string password)
        {
            
            Boolean v = false;
            if (id.Length <= 0 || password.Length <= 0)
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

        public void logout()
<<<<<<< HEAD
>>>>>>> 01c80df... 6to Commit: Login creado
=======
>>>>>>> 48fe993... Commit 7: Registrar alumnos
        {

        }
    }
    }
