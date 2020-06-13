using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace BopiSoft
{
    public class BDConexion
    {
        private string connection = string.Empty;
        private MySqlConnection connect;
        private MySqlCommand command;
        private MySqlDataAdapter da;
        private DataTable dt;
        private DataSet ds;

        public BDConexion()
        {
            connect = new MySqlConnection();
            try
            {
                connection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            }
            catch
            {
                connection = ConfigurationManager.AppSettings.Get("connection");
            }
        }

        private MySqlConnection connecttodb()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.ConnectionString = connection;
                    connect.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return connect;

        }

        private void closeconnection()
        {
            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
            }
        }

        public string selectstring(string query)
        {
            string cadena = string.Empty;
            try
            {
                connecttodb();
                command = new MySqlCommand(query, connect);
                cadena = command.ExecuteScalar().ToString();

            }
            catch
            {
                cadena = string.Empty;
            }
            finally
            {
                closeconnection();
            }

            return cadena;
        }

        public bool executecommand(string query)
        {
            bool exito;
            try
            {
                connecttodb();
                command = new MySqlCommand(query, connect);
                command.ExecuteNonQuery();
                exito = true;
            }
            catch
            {
                exito = false;
            }
            finally
            {
                closeconnection();
            }

            return exito;
        }

        public bool ExecuteStoreProcedure(string namestoreprocedure)
        {
            try
            {
                connecttodb();
                command = new MySqlCommand(namestoreprocedure, connect);
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                closeconnection();
            }
        }

        public DataTable SelectDataTableFromStoreProcedure(string namestoreprocedure)
        {
            dt = new DataTable();
            try
            {
                connecttodb();
                command = new MySqlCommand(namestoreprocedure, connect);
                command.CommandType = CommandType.StoredProcedure;
                dt = new DataTable();
                da = new MySqlDataAdapter();
                da.SelectCommand = command;
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeconnection();
            }

            return dt;
        }

        public DataTable SelectDataTable(string query)
        {
            dt = new DataTable();
            try
            {
                connecttodb();
                da = new MySqlDataAdapter(query, connect);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connecttodb();
            }

            return dt;
        }





        public DataSet SelectDataSet(string query, string table)
        {
            ds = new DataSet();
            try
            {
                connecttodb();
                da = new MySqlDataAdapter(query, connect);
                da.Fill(ds, table);
            }
            catch
            {

            }
            finally
            {
                closeconnection();
            }

            return ds;
        }
    }
}
