using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torre_De_Hanoi
{
    internal class Pila
    {

        private int numero_elementos;
        private int cima;
        private Plato[] pila_platos;
      
        public int Numero_elementos { get => numero_elementos; set => numero_elementos = value; }
        public int Cima { get => cima; set => cima = value; }
        internal Plato[] Pila_platos { get => pila_platos; set => pila_platos = value; }

        // COnstructor
        public Pila(int numero_elementos) { 
        
            this.Numero_elementos = numero_elementos;
            pila_platos = new Plato[numero_elementos];
            this.Cima = 0;
          

        }

        /// <summary>
        /// Apilar un boton el la pila
        /// </summary>
        /// <param name="boton"></param> Recibo una referencia de objeto tipo botón.
        public void Push(Plato boton) {
            pila_platos[Cima]=boton;
            Cima++;
        }


        /// <summary>
        /// Desapilar un boton de la pila.
        /// </summary>
        /// <returns></returns>
        public Plato Pop() {
            Cima--;
            return pila_platos[Cima];  
        }

        /// <summary>
        /// Método para verificar si la pila esta vacia
        /// </summary>
        /// <returns></returns>
        public Boolean Empty() {
            return Cima <=0;
        }

        /// <summary>
        /// Método para verificaxr si la pila esta llena.
        /// </summary>
        /// <returns></returns>
        public Boolean Full() {
            return Cima == Numero_elementos;
        }

        

    }
}
