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

        private void botonAgregarNodo_Click(object sender, EventArgs e)
        {
            Nodo nodoInicial = new Nodo(this.textoNodo1.Text);
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

        private void botonPrintRaw_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.grafo.printRawGraph());
        }

        private void botonAdyacencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.grafo.printConnMatrix());
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            String nombre = textoNodo1.Text + "-" + textoNodo2.Text;
            bool eliminar = this.grafo.deleteConection(nombre);
            MessageBox.Show((eliminar) ? "Se elimino la conexion exitosamente" : "No se elimino la conexion");
        }

        private void botonDijkstra_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.grafo.printableDijkstraNoDirigido(this.textoNodo1.Text, this.textoNodo2.Text));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregarSinDireccion_Click(object sender, EventArgs e)
        {
            Nodo nodoInicial = new Nodo(this.textoNodo1.Text);
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
