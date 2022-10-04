using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torre_De_Hanoi
{
    public partial class frm_principal : Form
    {

        //Variables Globales
        Torres torre_1, torre_2, torre_3;
        int movimientos;

        private void button2_Click(object sender, EventArgs e)
        {
            this.MovimentoPlato(torre_1, torre_2, pnl_2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.MovimentoPlato(torre_1, torre_3, pnl_3);
            if (torre_3.Pila.Full())
            {
                MessageBox.Show("Excelente trabajo", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        public frm_principal()
        {
            InitializeComponent();
            movimientos = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.MovimentoPlato(torre_2, torre_1, pnl_1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.MovimentoPlato(torre_2, torre_3, pnl_3);
            if (torre_3.Pila.Full())
            {
                MessageBox.Show("Excelente trabajo", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.MovimentoPlato(torre_3, torre_1, pnl_1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.MovimentoPlato(torre_3, torre_2, pnl_2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnl_1.Controls.Clear();
            pnl_2.Controls.Clear();
            pnl_3.Controls.Clear();

            int numero_platos = Convert.ToInt32(txt_numero_platos.Text);

            // desde aqui

            Point[] puntos = new Point[numero_platos];
            int para_x = 0;
            int para_y = 235;

            for (int i = 0; i < numero_platos; i++)
            {
                puntos[i] = new Point(para_x, para_y);
                para_x += 13;
                para_y -= 20;

            }
            int tamanio_plato_y = 337;
            Plato plato;
            //Torres

            torre_1 = new Torres(puntos, new Pila(numero_platos), "Torre 1");
            torre_2 = new Torres(puntos, new Pila(numero_platos), "Torre 2");
            torre_3 = new Torres(puntos, new Pila(numero_platos), "Torre 3");

            for (int i = 0; i < numero_platos; i++)
            {
                plato = new Plato("Plato_" + (numero_platos - i), (numero_platos - i), tamanio_plato_y);
                plato.Location = puntos[i];
                plato.BackColor = Color.DarkRed;
                plato.ForeColor = Color.White;
                tamanio_plato_y -= 26;
                torre_1.Pila.Push(plato);
                pnl_1.Controls.Add(plato);
            }

        }

        private void MovimentoPlato(Torres torre_auxiliar_1, Torres torre_auxiliar_2, Panel panel) {

            if (!torre_auxiliar_1.Pila.Empty())
            {
                Plato plato_auxiliar = torre_auxiliar_1.Pila.Pop();
                if (torre_auxiliar_2.Pila.Empty())
                {
                    plato_auxiliar.Location = torre_auxiliar_2.Puntos[torre_auxiliar_2.Pila.Cima];
                    torre_auxiliar_2.Pila.Push(plato_auxiliar);
                    panel.Controls.Add(plato_auxiliar);
                }
                else
                {
                    Plato plato_auxiliar_2 = torre_auxiliar_2.Pila.Pop();
                    torre_auxiliar_2.Pila.Push(plato_auxiliar_2);
                    if (plato_auxiliar.Tamanio < plato_auxiliar_2.Tamanio)
                    {
                        plato_auxiliar.Location = torre_auxiliar_2.Puntos[torre_auxiliar_2.Pila.Cima];
                        torre_auxiliar_2.Pila.Push(plato_auxiliar);
                        panel.Controls.Add(plato_auxiliar);

                    }
                    else
                    {
                        MessageBox.Show("No puede colocar un plato que es más grande que el que ya está", "Aviso de movimiento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        torre_auxiliar_1.Pila.Push(plato_auxiliar);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay platos para mover en esta torre", "Alerta de movimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lbl_movimiento.Text = "Número de movimientos: " + (++movimientos);

        }
    }
}
