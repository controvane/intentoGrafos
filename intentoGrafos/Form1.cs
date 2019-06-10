using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intentoGrafos
{
    public partial class Form1 : Form
    {
        //Todo este form es solo para probar la clase de grafos, a parte de eso no tiene nada de interesante
        Grafo grafo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.grafo = new Grafo();
            this.labelMensajes.Text = "";
        }

        //Todos los botones hacen algo llamando a alguna funcion del grafo
        // Este agrega nodos y / o conexiones con direccion

        private void botonAgregarNodo_Click(object sender, EventArgs e)
        {
            String nodoInicial = this.textoNodo1.Text;
            String nodoFinal = this.textoNodo2.Text;
            try
            {
                double peso = double.Parse(this.textoPeso.Text);
                if (peso <= 0)
                {
                    throw new Exception();
                }
                bool exito = this.grafo.addNodo(nodoInicial, nodoFinal, peso);
                if (exito)
                {
                    MessageBox.Show("Nodo o Conexion agregada exitosamente");
                    /*this.labelMensajes.Text = "Nodo o Conexion agregada exitosamente";
                    System.Threading.Thread.Sleep(5000);
                    this.labelMensajes.Text = "";*/
                }
                else
                {
                    MessageBox.Show("Hubo un error y no se pudo agregar el nuevo nodo o conexion");
                }
            }
            catch (Exception ex)
            {
                bool exito = this.grafo.addNodo(nodoInicial, nodoFinal);
                if (exito)
                {
                    MessageBox.Show("Nodo o Conexion agregada exitosamente");
                    /*this.labelMensajes.Text = "Nodo o Conexion agregada exitosamente";
                    System.Threading.Thread.Sleep(5000);
                    this.labelMensajes.Text = "";*/
                }
                else
                {
                    MessageBox.Show("Hubo un error y no se pudo agregar el nuevo nodo o conexion");
                }
            }
        }

        //esta te imprime una descripcion del grafo
        private void botonPrintRaw_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.grafo.printRawGraph());
        }

        //esta te imprime la matriz de adyacencia
        private void botonAdyacencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.grafo.printConnMatrix());
        }

        //esta elimina conexiones
        private void botonEliminar_Click(object sender, EventArgs e)
        {
            String nombre = textoNodo1.Text + "-" + textoNodo2.Text;
            bool eliminar = this.grafo.deleteConection(nombre);
            MessageBox.Show((eliminar) ? "Se elimino la conexion exitosamente" : "No se elimino la conexion");
        }

        //esta hace Dijkstra entre dos nodos
        private void botonDijkstra_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.grafo.printableDijkstraNoDirigido(this.textoNodo1.Text, this.textoNodo2.Text));
        }

        //esto es un missclick al diseñar el form y no se como quitarlo sin jorobar al form
        //tengo que ver como resolverlo, pero tampoco hace nada a parte de estar ahi, asi que
        //no es muy grave
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Este boton agrega Nodos y/o conexiones sin direccion
        private void buttonAgregarSinDireccion_Click(object sender, EventArgs e)
        {
            String nodoInicial = this.textoNodo1.Text;
            String nodoFinal = this.textoNodo2.Text;
            try
            {
                double peso = double.Parse(this.textoPeso.Text);
                if (peso <= 0)
                {
                    throw new Exception();
                }
                bool exito = this.grafo.addNodoNoDirigido(nodoInicial, nodoFinal, peso);
                if (exito)
                {
                    MessageBox.Show("Nodo o Conexion agregada exitosamente");
                    /*this.labelMensajes.Text = "Nodo o Conexion agregada exitosamente";
                    System.Threading.Thread.Sleep(5000);
                    this.labelMensajes.Text = "";*/
                }
                else
                {
                    MessageBox.Show("Hubo un error y no se pudo agregar el nuevo nodo o conexion");
                }
            }
            catch (Exception ex)
            {
                bool exito = this.grafo.addNodoNoDirigido(nodoInicial, nodoFinal);
                if (exito)
                {
                    MessageBox.Show("Nodo o Conexion agregada exitosamente");
                    /*this.labelMensajes.Text = "Nodo o Conexion agregada exitosamente";
                    System.Threading.Thread.Sleep(5000);
                    this.labelMensajes.Text = "";*/
                }
                else
                {
                    MessageBox.Show("Hubo un error y no se pudo agregar el nuevo nodo o conexion");
                }
            }
        }
    }
}
