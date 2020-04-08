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
    public class Tipo
    {
        internal static OracleConnection conn = null;

        private void abrirConexion()
        {
            string conexionstring = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            conn = new OracleConnection(conexionstring);
            try
            {
                conn.Open();
                //MessageBox.Show("Conexion establecida");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion" + ex);
                Application.Exit();
                throw new Exception("Error !!!");
            }
        }
        public List<C_Tipo> ListarTipo(String lista)
        {
            List<C_Tipo> Listar = new List<C_Tipo>();
            using (OracleCommand command = new OracleCommand())
            {
                StringBuilder Query = new StringBuilder();
                abrirConexion();
                Query.Append("SELECT tipo_id, tipo_nombre FROM tipos WHERE tipo_nombre LIKE '" + lista + "%'");
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = Query.ToString();
                OracleDataReader reader = null;
                command.Connection = conn;
                reader = command.ExecuteReader();
                //List<C_Tipo> Listar = new List<C_Tipo>();
                while (reader.Read())
                {
                    Listar.Add(new C_Tipo
                    {
                        Idtipo = reader.GetInt32(0),
                        Nombre = reader.GetString(1)
                    });
                }
                conn.Close();
                reader.Close();
            }
            return Listar;
        }
        public void Insertar(C_Tipo Tipo)
        {
            try
            {
                abrirConexion();
                OracleCommand cmd1 = new OracleCommand("SELECT COUNT(*) FROM tipos", conn);
                string id = (cmd1.ExecuteScalar()).ToString();
                if (Convert.ToInt32(id) > 0)
                {
                    OracleCommand idmax = new OracleCommand("SELECT MAX(tipo_id) FROM tipos", conn);
                    string _id = (idmax.ExecuteScalar()).ToString();
                    OracleCommand cmd = new OracleCommand("INSERT INTO tipos VALUES ('" + (Convert.ToInt32(_id) + 1) + "', '" + Tipo.Nombre + "')", conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    OracleCommand cmd3 = new OracleCommand("INSERT INTO tipos VALUES ('" + 1 + "', '" + Tipo.Nombre + "')", conn);
                    cmd3.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar Tipo " + ex);
                throw new Exception("Error !!!");
            }
        }
        public void Editar(C_Tipo Tipo)
        {
            try
            {
                abrirConexion();
                OracleCommand cmd = new OracleCommand("UPDATE tipos SET tipo_nombre = '" + Tipo.Nombre + "'WHERE tipo_id = '" + Tipo.Idtipo + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar Tipo" + ex);
                throw new Exception("Error !!!");
            }
        }
        public void Eliminar(C_Tipo Tipo)
        {
            try
            {
                abrirConexion();
                OracleCommand cmd = new OracleCommand("DELETE FROM tipos WHERE tipo_id = '" + Tipo.Idtipo + "'", conn);
                if (MessageBox.Show("¿Está seguro que que desea eliminar '" + Tipo.Nombre + "'?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar tipos" + ex);
                throw new Exception("Error !!!");
            }
        }
    }
}
