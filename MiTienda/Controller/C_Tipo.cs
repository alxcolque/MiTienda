using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referencias
using MiTienda.Model;

namespace MiTienda.Controller
{
    public class C_Tipo
    {
        private int _Idtipo;
        private string _Nombre;
        
        //Instanciar
        Tipo obj = new Tipo();

        public int Idtipo
        {
            get
            {
                return _Idtipo;
            }

            set
            {
                _Idtipo = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }

        //Metodos de CRUD
        public List<C_Tipo> Listado(string buscar)
        {
            return obj.ListarTipo(buscar);
        }
        public void Insertar(C_Tipo Tipo)
        {
            obj.Insertar(Tipo);
        }
        public void Editar(C_Tipo Tipo)
        {
            obj.Editar(Tipo);
        }
        public void Eliminar(C_Tipo Tipo)
        {
            obj.Eliminar(Tipo);
        }

    }
}
