using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referencias 
using Oracle.DataAccess.Client;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using MiTienda.Controller;

namespace MiTienda.Model
{
    public class Usuario
    {
        internal static OracleConnection conn = null;
        public void abrirConexion()
        {
            string conexionstring = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            conn = new OracleConnection(conexionstring);
            try
            {
                conn.Open();
                //MessageBox.Show("Conexion establecida ");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error de la conexion con la base de datos" + ex);
            }
        }
        private bool validar_login(string user, string pass)
        {
            try
            {
                abrirConexion();
                OracleCommand cmd = new OracleCommand("select * from tienda.usuarios where nombre_usuario = '"+user+"' and clave ='"+pass+"'",conn);
                cmd.Connection = conn;
                OracleDataReader login = cmd.ExecuteReader();
                if (login.Read())
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al validar credenciales" + ex);
                throw new Exception("Err");
            }
        }
        public void login()
        {
            try
            {
                string user = C_Sesion.Usuario;
                string pass = C_Sesion.Clave;
                string id_rol = C_Sesion.Rol;
                if(user == "" || pass == "")
                {
                    MessageBox.Show("Llene los campos vacios por favor !");
                    return;
                }
                bool r = validar_login(user, pass);
                if (r)
                {
                    abrirConexion();
                    OracleCommand cmd = new OracleCommand("SELECT COUNT(rol) FROM usuarios WHERE nombre_usuario ='" + C_Sesion.Usuario + "' AND rol = 1", conn);
                    id_rol = (cmd.ExecuteScalar()).ToString();
                    if ((Convert.ToUInt32(id_rol)) > 0)
                    {
                        Principal m = new Principal();
                        m.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuario de diferente rol ");
                    }
                }
                else {
                    MessageBox.Show("Datos incorrectos...!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en login" + ex);
            }
        }
    }
}
