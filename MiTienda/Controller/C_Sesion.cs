using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using MiTienda.Model;

namespace MiTienda.Controller
{
    public class C_Sesion
    {
        public static string Usuario;
        public static string Clave;
        public static string Rol = "1";
        public void login()
        {
            Usuario t = new Usuario();
            t.login();
        }
        public void pruebaConexion()
        {
            Usuario t = new Usuario();
            t.abrirConexion();
        }
    }
}
