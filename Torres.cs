using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torre_De_Hanoi
{
    internal class Torres
    {

        private Point[] puntos;
        private Pila pila;
        private string nombre;

        public Torres(Point[]puntos, Pila pila, string nombre) { 
            this.Puntos = puntos;
            this.Pila = pila;
            this.Nombre = nombre;
        
        }

        public Point[] Puntos { get => puntos; set => puntos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        internal Pila Pila { get => pila; set => pila = value; }
    }
}
