using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intentoGrafos
{
    class Conexion
    {
        //nombre de la conexion, que resume de donde viene y a donde va
        private string nombre;
        //estos dos nodos solo tienen que ser referencias a los nodos que contienen a la conexion
        //en su lista de nodos
        private Nodo nodoInicio;
        private Nodo nodoFinal;
        //Peso de la conexion, es opcional
        private double peso;

        //Constructor sin peso
        public Conexion(Nodo nodoInicio, Nodo nodoFinal) {
            this.nodoInicio = nodoInicio;
            this.nodoFinal = nodoFinal;
            this.nombre = nodoInicio.Nombre + "-" + nodoFinal.Nombre;
            this.Peso = 1;
        }

        //Constructor con peso
        public Conexion(Nodo nodoInicio, Nodo nodoFinal, double peso)
        {
            this.nombre = nodoInicio.Nombre + "-" + nodoFinal.Nombre;
            this.nodoInicio = nodoInicio;
            this.nodoFinal = nodoFinal;
            this.Peso = peso;
        }

        public string Nombre { get => nombre;}
        public double Peso { get => peso; set => peso = value; }
        public Nodo NodoInicio { get => nodoInicio;}
        public Nodo NodoFinal { get => nodoFinal;}
    }
}
