namespace intentoGrafos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelNodo1 = new System.Windows.Forms.Label();
            this.labelNodo2 = new System.Windows.Forms.Label();
            this.textoNodo1 = new System.Windows.Forms.TextBox();
            this.textoNodo2 = new System.Windows.Forms.TextBox();
            this.botonAgregarNodo = new System.Windows.Forms.Button();
            this.labelExpAgreagar = new System.Windows.Forms.Label();
            this.labelMensajes = new System.Windows.Forms.Label();
            this.botonPrintRaw = new System.Windows.Forms.Button();
            this.botonAdyacencia = new System.Windows.Forms.Button();
            this.textoPeso = new System.Windows.Forms.TextBox();
            this.labelPeso = new System.Windows.Forms.Label();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.labelEliminarInstrucciones = new System.Windows.Forms.Label();
            this.botonDijkstra = new System.Windows.Forms.Button();
            this.labelDijkstra = new System.Windows.Forms.Label();
            this.buttonAgregarSinDireccion = new System.Windows.Forms.Button();
            this.labelAgregarSinDireccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNodo1
            // 
            this.labelNodo1.AutoSize = true;
            this.labelNodo1.Location = new System.Drawing.Point(48, 13);
            this.labelNodo1.Name = "labelNodo1";
            this.labelNodo1.Size = new System.Drawing.Size(62, 17);
            this.labelNodo1.TabIndex = 0;
            this.labelNodo1.Text = "Nodo 1: ";
            // 
            // labelNodo2
            // 
            this.labelNodo2.AutoSize = true;
            this.labelNodo2.Location = new System.Drawing.Point(48, 57);
            this.labelNodo2.Name = "labelNodo2";
            this.labelNodo2.Size = new System.Drawing.Size(62, 17);
            this.labelNodo2.TabIndex = 1;
            this.labelNodo2.Text = "Nodo 2: ";
            // 
            // textoNodo1
            // 
            this.textoNodo1.Location = new System.Drawing.Point(117, 7);
            this.textoNodo1.Name = "textoNodo1";
            this.textoNodo1.Size = new System.Drawing.Size(100, 22);
            this.textoNodo1.TabIndex = 2;
            // 
            // textoNodo2
            // 
            this.textoNodo2.Location = new System.Drawing.Point(116, 54);
            this.textoNodo2.Name = "textoNodo2";
            this.textoNodo2.Size = new System.Drawing.Size(100, 22);
            this.textoNodo2.TabIndex = 3;
            // 
            // botonAgregarNodo
            // 
            this.botonAgregarNodo.Location = new System.Drawing.Point(480, 6);
            this.botonAgregarNodo.Name = "botonAgregarNodo";
            this.botonAgregarNodo.Size = new System.Drawing.Size(200, 23);
            this.botonAgregarNodo.TabIndex = 4;
            this.botonAgregarNodo.Text = "Agregar Nodo/Conexion ";
            this.botonAgregarNodo.UseVisualStyleBackColor = true;
            this.botonAgregarNodo.Click += new System.EventHandler(this.botonAgregarNodo_Click);
            // 
            // labelExpAgreagar
            // 
            this.labelExpAgreagar.AutoSize = true;
            this.labelExpAgreagar.Location = new System.Drawing.Point(357, 32);
            this.labelExpAgreagar.Name = "labelExpAgreagar";
            this.labelExpAgreagar.Size = new System.Drawing.Size(440, 102);
            this.labelExpAgreagar.TabIndex = 5;
            this.labelExpAgreagar.Text = resources.GetString("labelExpAgreagar.Text");
            // 
            // labelMensajes
            // 
            this.labelMensajes.AutoSize = true;
            this.labelMensajes.Location = new System.Drawing.Point(12, 121);
            this.labelMensajes.Name = "labelMensajes";
            this.labelMensajes.Size = new System.Drawing.Size(122, 17);
            this.labelMensajes.TabIndex = 6;
            this.labelMensajes.Text = "label de Mensajes";
            // 
            // botonPrintRaw
            // 
            this.botonPrintRaw.Location = new System.Drawing.Point(480, 209);
            this.botonPrintRaw.Name = "botonPrintRaw";
            this.botonPrintRaw.Size = new System.Drawing.Size(200, 23);
            this.botonPrintRaw.TabIndex = 7;
            this.botonPrintRaw.Text = "Imprimir Grafo en bruto";
            this.botonPrintRaw.UseVisualStyleBackColor = true;
            this.botonPrintRaw.Click += new System.EventHandler(this.botonPrintRaw_Click);
            // 
            // botonAdyacencia
            // 
            this.botonAdyacencia.Location = new System.Drawing.Point(480, 247);
            this.botonAdyacencia.Name = "botonAdyacencia";
            this.botonAdyacencia.Size = new System.Drawing.Size(200, 23);
            this.botonAdyacencia.TabIndex = 8;
            this.botonAdyacencia.Text = "Matriz de Adyacencia";
            this.botonAdyacencia.UseVisualStyleBackColor = true;
            this.botonAdyacencia.Click += new System.EventHandler(this.botonAdyacencia_Click);
            // 
            // textoPeso
            // 
            this.textoPeso.Location = new System.Drawing.Point(116, 96);
            this.textoPeso.Name = "textoPeso";
            this.textoPeso.Size = new System.Drawing.Size(100, 22);
            this.textoPeso.TabIndex = 10;
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Location = new System.Drawing.Point(48, 96);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(48, 17);
            this.labelPeso.TabIndex = 9;
            this.labelPeso.Text = "Peso: ";
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(480, 286);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(200, 23);
            this.botonEliminar.TabIndex = 11;
            this.botonEliminar.Text = "Eliminar Conexion";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // labelEliminarInstrucciones
            // 
            this.labelEliminarInstrucciones.AutoSize = true;
            this.labelEliminarInstrucciones.Location = new System.Drawing.Point(391, 312);
            this.labelEliminarInstrucciones.Name = "labelEliminarInstrucciones";
            this.labelEliminarInstrucciones.Size = new System.Drawing.Size(367, 34);
            this.labelEliminarInstrucciones.TabIndex = 12;
            this.labelEliminarInstrucciones.Text = "Declare la conexion escribiendo el nodo inicial en nodo 1\r\ny el nodo final en nod" +
    "o 2";
            // 
            // botonDijkstra
            // 
            this.botonDijkstra.Location = new System.Drawing.Point(480, 364);
            this.botonDijkstra.Name = "botonDijkstra";
            this.botonDijkstra.Size = new System.Drawing.Size(200, 23);
            this.botonDijkstra.TabIndex = 13;
            this.botonDijkstra.Text = "Buscar ruta mas corta";
            this.botonDijkstra.UseVisualStyleBackColor = true;
            this.botonDijkstra.Click += new System.EventHandler(this.botonDijkstra_Click);
            // 
            // labelDijkstra
            // 
            this.labelDijkstra.AutoSize = true;
            this.labelDijkstra.Location = new System.Drawing.Point(391, 390);
            this.labelDijkstra.Name = "labelDijkstra";
            this.labelDijkstra.Size = new System.Drawing.Size(348, 51);
            this.labelDijkstra.TabIndex = 14;
            this.labelDijkstra.Text = "Buscara la ruta mas corta entre el Nodo 1 y el Nodo 2\r\nignora la direccion de las" +
    " conexiones\r\n(simula que el grafo sea no dirigido)";
            // 
            // buttonAgregarSinDireccion
            // 
            this.buttonAgregarSinDireccion.Location = new System.Drawing.Point(455, 137);
            this.buttonAgregarSinDireccion.Name = "buttonAgregarSinDireccion";
            this.buttonAgregarSinDireccion.Size = new System.Drawing.Size(264, 23);
            this.buttonAgregarSinDireccion.TabIndex = 15;
            this.buttonAgregarSinDireccion.Text = "Agregar Nodo/Conexion (Sin Direccion)";
            this.buttonAgregarSinDireccion.UseVisualStyleBackColor = true;
            this.buttonAgregarSinDireccion.Click += new System.EventHandler(this.buttonAgregarSinDireccion_Click);
            // 
            // labelAgregarSinDireccion
            // 
            this.labelAgregarSinDireccion.AutoSize = true;
            this.labelAgregarSinDireccion.Location = new System.Drawing.Point(407, 163);
            this.labelAgregarSinDireccion.Name = "labelAgregarSinDireccion";
            this.labelAgregarSinDireccion.Size = new System.Drawing.Size(362, 34);
            this.labelAgregarSinDireccion.TabIndex = 16;
            this.labelAgregarSinDireccion.Text = "Funciona igual que el anterior, pero las conexiones que \r\ncrea son sin direccion";
            this.labelAgregarSinDireccion.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAgregarSinDireccion);
            this.Controls.Add(this.buttonAgregarSinDireccion);
            this.Controls.Add(this.labelDijkstra);
            this.Controls.Add(this.botonDijkstra);
            this.Controls.Add(this.labelEliminarInstrucciones);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.textoPeso);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.botonAdyacencia);
            this.Controls.Add(this.botonPrintRaw);
            this.Controls.Add(this.labelMensajes);
            this.Controls.Add(this.labelExpAgreagar);
            this.Controls.Add(this.botonAgregarNodo);
            this.Controls.Add(this.textoNodo2);
            this.Controls.Add(this.textoNodo1);
            this.Controls.Add(this.labelNodo2);
            this.Controls.Add(this.labelNodo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNodo1;
        private System.Windows.Forms.Label labelNodo2;
        private System.Windows.Forms.TextBox textoNodo1;
        private System.Windows.Forms.TextBox textoNodo2;
        private System.Windows.Forms.Button botonAgregarNodo;
        private System.Windows.Forms.Label labelExpAgreagar;
        private System.Windows.Forms.Label labelMensajes;
        private System.Windows.Forms.Button botonPrintRaw;
        private System.Windows.Forms.Button botonAdyacencia;
        private System.Windows.Forms.TextBox textoPeso;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Label labelEliminarInstrucciones;
        private System.Windows.Forms.Button botonDijkstra;
        private System.Windows.Forms.Label labelDijkstra;
        private System.Windows.Forms.Button buttonAgregarSinDireccion;
        private System.Windows.Forms.Label labelAgregarSinDireccion;
    }
}

