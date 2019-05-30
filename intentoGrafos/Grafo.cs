using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intentoGrafos
{
    class Grafo
    {
        private List<Nodo> nodos;

        public Grafo() {
            this.Nodos = new List<Nodo>();
        }

        public List<Nodo> Nodos { get => nodos; set => nodos = value; }

        //pues ... solo te dice si el grafo esta vacio nada mas
        public bool isEmpty() {
            return (this.Nodos.Count() <= 0) ? true : false;
        }

        //permite agregar el primer Nodo a partir de solo su nombre
        //solo funciona si no hay ningun nodo en el grafo
        public bool addNodo(string nom) {
            if (this.Nodos.Count <= 0)
            {
                Console.WriteLine("creando el primer nodo");
                this.Nodos.Add(new Nodo(nom));
                return true;
            }
            else {
                return false;
            }
        }

        //agrega un nuevo nodo a partir de un nodo inicial,
        //no maneja pesos de las conexiones, pero eso no es grave de manejar,
        //solo habria que aumentar un argumento mas del peso.
        //en caso de que no exista el nodo inicial, no agrega nada.
        //en caso de que existan el nodo inicial y el final, agrega una nueva conexion
        //Despues de verificar que esa conexion no exista
        public bool addNodo(Nodo nodoInicio, string nom) {     
            if (this.Nodos.Exists(x => x.Nombre.CompareTo(nodoInicio.Nombre) == 0)) {
                Console.WriteLine("El nodo inicial existe: "+nodoInicio.Nombre);
                Console.WriteLine("El nodo nuevo " + nom + " existe?: " + this.Nodos.Exists(x => x.Nombre.CompareTo(nom) == 0));
                if (this.Nodos.Exists(x => x.Nombre.CompareTo(nom) == 0))
                {
                    Console.WriteLine("El nodo final existe: "+nom);
                    //linea larga y fea, pero solo revisa si la conexion ya existe y devuelve una operacion fallida en ese caso.
                    if (this.nodos.Find(x => x.Nombre.CompareTo(nodoInicio.Nombre) == 0).ListaConexiones.Exists(x => (x.NodoInicio.Nombre.CompareTo(nodoInicio.Nombre) == 0) && (x.NodoFinal.Nombre.CompareTo(nom) == 0))) {
                        Console.WriteLine("La conexion ya existe");
                        return false;
                    }
                    //Aqui crea una nueva conexion, como las conexiones son diereccionadas una conexion inversa
                    //se considera una conexion nueva
                    Console.WriteLine("Creando nueva conexion entre " + nodoInicio.Nombre + " y " + nom + ".");
                    Conexion nuevaConexion = new Conexion(this.Nodos.Find(x => x.Nombre.CompareTo(nodoInicio.Nombre) == 0), this.Nodos.Find(x => x.Nombre.CompareTo(nom) == 0));
                    this.Nodos.Find(x => x.Nombre.CompareTo(nom) == 0).ListaConexiones.Add(nuevaConexion);
                    this.Nodos.Find(x => x.Nombre.CompareTo(nodoInicio.Nombre) == 0).ListaConexiones.Add(nuevaConexion);
                }
                else
                {
                    //en caso de que el nodoFinal no exista, crea un nuevo nodo y crea y asigna la nueva conexion
                    Console.WriteLine("Creando nuevo nodo " + nom + " y conectando a " + nodoInicio.Nombre);
                    Nodo nodoNuevo = new Nodo(nom);
                    Conexion nuevaConexion = new Conexion(this.Nodos.Find(x => x.Nombre.CompareTo(nodoInicio.Nombre) == 0), nodoNuevo);
                    nodoNuevo.ListaConexiones.Add(nuevaConexion);
                    this.Nodos.Find(x => x.Nombre.CompareTo(nodoInicio.Nombre) == 0).ListaConexiones.Add(nuevaConexion);
                    this.Nodos.Add(nodoNuevo);
                }
                return true;
            }
            return addNodo(nom);
        }

        //Lo mismo que la anterior, pero ahora las conexiones tienen peso
        public bool addNodo(Nodo nodoInicio, string nom, double peso)
        {
            if (this.Nodos.Exists(x => x.Nombre.CompareTo(nodoInicio.Nombre) == 0))
            {
                Console.WriteLine("El nodo inicial existe: " + nodoInicio.Nombre);
                Console.WriteLine("El nodo nuevo " + nom + " existe?: " + this.Nodos.Exists(x => x.Nombre.CompareTo(nom) == 0));
                if (this.Nodos.Exists(x => x.Nombre.CompareTo(nom) == 0))
                {
                    Console.WriteLine("El nodo final existe: " + nom);
                    //linea larga y fea, pero solo revisa si la conexion ya existe y devuelve una operacion fallida en ese caso.
                    if (this.nodos.Find(x => x.Nombre.CompareTo(nodoInicio.Nombre) == 0).ListaConexiones.Exists(x => (x.NodoInicio.Nombre.CompareTo(nodoInicio.Nombre) == 0) && (x.NodoFinal.Nombre.CompareTo(nom) == 0)))
                    {
                        Console.WriteLine("La conexion ya existe");
                        return false;
                    }
                    //Aqui crea una nueva conexion, como las conexiones son diereccionadas una conexion inversa
                    //se considera una conexion nueva
                    Console.WriteLine("Creando nueva conexion entre " + nodoInicio.Nombre + " y " + nom + ".");
                    Conexion nuevaConexion = new Conexion(this.Nodos.Find(x => x.Nombre.CompareTo(nodoInicio.Nombre) == 0), this.Nodos.Find(x => x.Nombre.CompareTo(nom) == 0), peso);
                    this.Nodos.Find(x => x.Nombre.CompareTo(nom) == 0).ListaConexiones.Add(nuevaConexion);
                    this.Nodos.Find(x => x.Nombre.CompareTo(nodoInicio.Nombre) == 0).ListaConexiones.Add(nuevaConexion);
                }
                else
                {
                    //en caso de que el nodoFinal no exista, crea un nuevo nodo y crea y asigna la nueva conexion
                    Console.WriteLine("Creando nuevo nodo " + nom + " y conectando a " + nodoInicio.Nombre);
                    Nodo nodoNuevo = new Nodo(nom);
                    Conexion nuevaConexion = new Conexion(this.Nodos.Find(x => x.Nombre.CompareTo(nodoInicio.Nombre) == 0), nodoNuevo, peso);
                    nodoNuevo.ListaConexiones.Add(nuevaConexion);
                    this.Nodos.Find(x => x.Nombre.CompareTo(nodoInicio.Nombre) == 0).ListaConexiones.Add(nuevaConexion);
                    this.Nodos.Add(nodoNuevo);
                }
                return true;
            }
            return addNodo(nom);
        }

        public string printRawGraph() {
            string printer = "Nodos: \r\n";
            foreach (Nodo var in this.nodos) {
                printer += var.Nombre+"\r\nConectado a:\r\n";
                foreach (Conexion con in var.ListaConexiones) {
                    printer += con.Nombre + " : "+con.Peso+"\r\n";
                }
                printer += "--------------------------------------\r\n";
            }
            return printer;
        }

        public string printConnMatrix() {
            string printer = "Vertices: ";
            int tam = this.Nodos.Count;
            for (int i = 0; i < tam; i++) {
                printer += i + " - " + this.Nodos[i].Nombre + "; ";
            }
            printer += "\r\n--------------------------\r\n";
            for (int i = 0; i <= tam; i++) {
                if (i != 0) {
                    printer += this.Nodos[i - 1].Nombre + " | ";
                }
                for (int j = 0; j < tam; j++) {
                    if (i == 0) {
                        if (j == 0) {
                            printer += "     ";
                        }
                        printer += this.Nodos[j].Nombre + " ";
                    }
                    else if (this.Nodos.Exists(x => (x.Nombre.CompareTo(this.Nodos[i-1].Nombre) == 0) && (x.ListaConexiones.Exists(y => (y.NodoInicio.Nombre.CompareTo(x.Nombre) == 0) && (y.NodoFinal.Nombre.CompareTo(this.Nodos[j].Nombre) == 0)))))
                    {
                        printer += this.Nodos[i-1].ListaConexiones.Find(x => (x.NodoInicio.Nombre.CompareTo(this.Nodos[i-1].Nombre) == 0) && (x.NodoFinal.Nombre.CompareTo(this.Nodos[j].Nombre) == 0)).Peso + " ";
                    }
                    /*else if (this.Nodos.Exists(x => (x.Nombre.CompareTo(this.Nodos[i-1].Nombre) == 0) && (x.ListaConexiones.Exists(y => (y.NodoInicio.Nombre.CompareTo(this.Nodos[j].Nombre) == 0) && (y.NodoFinal.Nombre.CompareTo(x.Nombre) == 0)))))
                    {
                        printer += this.Nodos[i-1].ListaConexiones.Find(x => (x.NodoInicio.Nombre.CompareTo(this.Nodos[j].Nombre) == 0) && (x.NodoFinal.Nombre.CompareTo(this.Nodos[i-1].Nombre) == 0)).Peso + " ";
                    }*/
                    else {
                        printer += "0 ";
                    }
                }
                printer += "\r\n";
            }
            return printer;
        }

        public bool deleteConection(String nombreConexion) {
            int eliminados = 0;
            //Busca en todos los nodos si tienen la conexion a borrar y la borra
            //Luego si era la unica conexion del nodo, borra el nodo
            for(int i = 0; i <this.Nodos.Count ; i++) {
                if (Nodos[i].ListaConexiones.Exists(x => x.Nombre.CompareTo(nombreConexion) == 0)) {
                    Nodos[i].ListaConexiones.Remove(Nodos[i].ListaConexiones.Find(x => x.Nombre.CompareTo(nombreConexion) == 0));
                    eliminados++;
                    if (Nodos[i].isAlone()) {
                        this.Nodos.Remove(Nodos.Find(x => x.Nombre.CompareTo(Nodos[i].Nombre) == 0));
                    }
                }
            }
            return (eliminados == 0)? false : true;
        }
    }
}
