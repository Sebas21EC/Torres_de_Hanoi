using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torre_De_Hanoi
{
    internal class Torres
    {

        private Point[] puntos;
        private Pila pila;
        private string nombre;
        private Panel panel;

        public Torres(Point[] puntos, Pila pila, string nombre, Panel panel)
        {
            this.Puntos = puntos;
            this.Pila = pila;
            this.Nombre = nombre;
            this.panel = panel;
        }

        public Point[] Puntos { get => puntos; set => puntos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Panel Panel { get => panel; set => panel = value; }
        internal Pila Pila { get => pila; set => pila = value; }
    }
}
