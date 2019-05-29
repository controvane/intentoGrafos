using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intentoGrafos
{
    class Nodo
    {
        private string nombre;
        private List<Conexion> listaConexiones;

        public Nodo(string nombre)
        {
            this.nombre = nombre;
            this.ListaConexiones = new List<Conexion>();
        }

        public string Nombre { get => nombre;}
        public List<Conexion> ListaConexiones { get => listaConexiones; set => listaConexiones = value;}

        //te dice si el nodo esta conectado a algo, a menos que sea el unico nodo del grafo esto siempre deberia ser falso
        public bool isAlone() {
            return (this.ListaConexiones.Count() <= 0) ? true : false;
        }
    }
}
