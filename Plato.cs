using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torre_De_Hanoi
{
    internal class Plato : Button
    {

        //private string nombre;
       // private bool estado;
        private int tamanio;
        

        public Plato(string nombre, int tamanio,int tamanio_plato_y) { 
        
            this.Name = nombre;
            this.Text = nombre;
            this.Tamanio = tamanio;
            this.Size = new Size(tamanio_plato_y, 20);


            // this.estado = estado;
            // this.boton = boton;
        }

        public int Tamanio { get => tamanio; set => tamanio = value; }
    }
}
