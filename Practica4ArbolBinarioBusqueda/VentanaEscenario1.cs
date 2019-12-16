using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica4ArbolBinarioBusqueda
{
    public partial class VentanaEscenario1 : Form
    {
        public VentanaEscenario1()
        {
            InitializeComponent();
        }

        private void CerrarVentana()
        {
            VentanaMenu vm = new VentanaMenu();
            vm.Visible = true;
            this.Dispose();
        }

        private void VentanaEscenario1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarVentana();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarVentana();
        }

        private void graficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics grafico = CreateGraphics();
            Pen linea = new Pen(Brushes.Tomato, 2);
            //Primer nivel.
            //Primer nodo (nodo raiz)
            grafico.FillEllipse(Brushes.Brown,280,40,40,40);
            grafico.DrawString("50", new Font("Arial", 10), Brushes.White, 292, 52);

            //Nodo izquierdo hijo
            grafico.FillEllipse(Brushes.Brown, 180, 80, 40, 40);
            grafico.DrawString("40", new Font("Arial", 10), Brushes.White, 192, 92);

            grafico.DrawLine(linea, 220, 100, 280, 60);

            //Nodo derecho hijo
            grafico.FillEllipse(Brushes.Brown, 380, 80, 40, 40);
            grafico.DrawString("60", new Font("Arial", 10), Brushes.White, 392, 92);

            grafico.DrawLine(linea, 320, 60, 380, 100);

            //Segundo nivel
            //Nodo raiz 40
            //Nodo izquierdo hijo
            grafico.FillEllipse(Brushes.Brown, 105, 120, 40, 40);
            grafico.DrawString("30", new Font("Arial", 10), Brushes.White, 117, 132);

            grafico.DrawLine(linea, 145, 140, 180, 100);

            //Nodo derecho hijo
            grafico.FillEllipse(Brushes.Brown, 255, 120, 40, 40);
            grafico.DrawString("45", new Font("Arial", 10), Brushes.White, 267, 132);

            grafico.DrawLine(linea, 220, 100, 255, 140);

            //Nodo raiz 60
            //Nodo izquierdo hijo
            grafico.FillEllipse(Brushes.Brown, 305, 120, 40, 40);
            grafico.DrawString("55", new Font("Arial", 10), Brushes.White, 317, 132);

            grafico.DrawLine(linea, 345, 140, 380, 100);

            //Nodo derecho hijo
            grafico.FillEllipse(Brushes.Brown, 455, 120, 40, 40);
            grafico.DrawString("70", new Font("Arial", 10), Brushes.White, 467, 132);

            grafico.DrawLine(linea, 420, 100, 455, 140);

            //Tercer nivel
            //Nodo raiz 30
            //Nodo izquierdo hijo
            grafico.FillEllipse(Brushes.Brown, 55, 160, 40, 40);
            grafico.DrawString("25", new Font("Arial", 10), Brushes.White, 67, 172);

            grafico.DrawLine(linea, 95, 180, 105, 140);

            //Nodo derecho hijo
            grafico.FillEllipse(Brushes.Brown, 155, 160, 40, 40);
            grafico.DrawString("35", new Font("Arial", 10), Brushes.White, 167, 172);

            grafico.DrawLine(linea, 145, 140, 155, 180);

            //Nodo raiz 45
            //Nodo izquierdo hijo
            grafico.FillEllipse(Brushes.Brown, 205, 160, 40, 40);
            grafico.DrawString("42", new Font("Arial", 10), Brushes.White, 217, 172);

            grafico.DrawLine(linea, 245, 180, 255, 140);

            //Nodo raiz 70
            //Nodo izquierdo hijo
            grafico.FillEllipse(Brushes.Brown, 405, 160, 40, 40);
            grafico.DrawString("65", new Font("Arial", 10), Brushes.White, 417, 172);

            grafico.DrawLine(linea, 445, 180, 455, 140);

            //Nodo derecho hijo
            grafico.FillEllipse(Brushes.Brown, 505, 160, 40, 40);
            grafico.DrawString("75", new Font("Arial", 10), Brushes.White, 517, 172);

            grafico.DrawLine(linea, 495, 140, 505, 180);

            //duibujar despues de 300            

        }

        private void preordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics grafico = CreateGraphics();
            grafico.DrawString("Preorden:", new Font("Arial", 10), Brushes.Black, 55, 300);

            //Nodo 1
            grafico.FillEllipse(Brushes.Brown, 120, 292, 30, 30);
            grafico.DrawString("50", new Font("Arial", 10), Brushes.White, 126, 299);

            //Nodo 2
            grafico.FillEllipse(Brushes.Brown, 155, 292, 30, 30);
            grafico.DrawString("40", new Font("Arial", 10), Brushes.White, 161, 299);

            //Nodo 3
            grafico.FillEllipse(Brushes.Brown, 190, 292, 30, 30);
            grafico.DrawString("30", new Font("Arial", 10), Brushes.White, 196, 299);

            //Nodo 4
            grafico.FillEllipse(Brushes.Brown, 225, 292, 30, 30);
            grafico.DrawString("25", new Font("Arial", 10), Brushes.White, 231, 299);

            //Nodo 5
            grafico.FillEllipse(Brushes.Brown, 260, 292, 30, 30);
            grafico.DrawString("35", new Font("Arial", 10), Brushes.White, 266, 299);

            //Nodo 6
            grafico.FillEllipse(Brushes.Brown, 295, 292, 30, 30);
            grafico.DrawString("45", new Font("Arial", 10), Brushes.White, 301, 299);

            //Nodo 7
            grafico.FillEllipse(Brushes.Brown, 330, 292, 30, 30);
            grafico.DrawString("42", new Font("Arial", 10), Brushes.White, 336, 299);

            //Nodo 8
            grafico.FillEllipse(Brushes.Brown, 365, 292, 30, 30);
            grafico.DrawString("60", new Font("Arial", 10), Brushes.White, 371, 299);

            //Nodo 9
            grafico.FillEllipse(Brushes.Brown, 400, 292, 30, 30);
            grafico.DrawString("55", new Font("Arial", 10), Brushes.White, 406, 299);

            //Nodo 10
            grafico.FillEllipse(Brushes.Brown, 435, 292, 30, 30);
            grafico.DrawString("70", new Font("Arial", 10), Brushes.White, 441, 299);

            //Nodo 11
            grafico.FillEllipse(Brushes.Brown, 470, 292, 30, 30);
            grafico.DrawString("65", new Font("Arial", 10), Brushes.White, 476, 299);

            //Nodo 12
            grafico.FillEllipse(Brushes.Brown, 505, 292, 30, 30);
            grafico.DrawString("75", new Font("Arial", 10), Brushes.White, 511, 299);           

        }

        private void inordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics grafico = CreateGraphics();
            grafico.DrawString("Inorden:", new Font("Arial", 10), Brushes.Black, 55, 350);

            //Nodo 1
            grafico.FillEllipse(Brushes.Brown, 120, 342, 30, 30);
            grafico.DrawString("25", new Font("Arial", 10), Brushes.White, 126, 349);

            //Nodo 2
            grafico.FillEllipse(Brushes.Brown, 155, 342, 30, 30);
            grafico.DrawString("30", new Font("Arial", 10), Brushes.White, 161, 349);

            //Nodo 3
            grafico.FillEllipse(Brushes.Brown, 190, 342, 30, 30);
            grafico.DrawString("35", new Font("Arial", 10), Brushes.White, 196, 349);

            //Nodo 4
            grafico.FillEllipse(Brushes.Brown, 225, 342, 30, 30);
            grafico.DrawString("40", new Font("Arial", 10), Brushes.White, 231, 349);

            //Nodo 5
            grafico.FillEllipse(Brushes.Brown, 260, 342, 30, 30);
            grafico.DrawString("42", new Font("Arial", 10), Brushes.White, 266, 349);

            //Nodo 6
            grafico.FillEllipse(Brushes.Brown, 295, 342, 30, 30);
            grafico.DrawString("45", new Font("Arial", 10), Brushes.White, 301, 349);

            //Nodo 7
            grafico.FillEllipse(Brushes.Brown, 330, 342, 30, 30);
            grafico.DrawString("50", new Font("Arial", 10), Brushes.White, 336, 349);

            //Nodo 8
            grafico.FillEllipse(Brushes.Brown, 365, 342, 30, 30);
            grafico.DrawString("55", new Font("Arial", 10), Brushes.White, 371, 349);

            //Nodo 9
            grafico.FillEllipse(Brushes.Brown, 400, 342, 30, 30);
            grafico.DrawString("60", new Font("Arial", 10), Brushes.White, 406, 349);

            //Nodo 10
            grafico.FillEllipse(Brushes.Brown, 435, 342, 30, 30);
            grafico.DrawString("65", new Font("Arial", 10), Brushes.White, 441, 349);

            //Nodo 11
            grafico.FillEllipse(Brushes.Brown, 470, 342, 30, 30);
            grafico.DrawString("70", new Font("Arial", 10), Brushes.White, 476, 349);

            //Nodo 12
            grafico.FillEllipse(Brushes.Brown, 505, 342, 30, 30);
            grafico.DrawString("75", new Font("Arial", 10), Brushes.White, 511, 349);

        }

        private void postordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics grafico = CreateGraphics();
            grafico.DrawString("Postorden:", new Font("Arial", 10), Brushes.Black, 50, 400);

            //Nodo 1
            grafico.FillEllipse(Brushes.Brown, 120, 392, 30, 30);
            grafico.DrawString("25", new Font("Arial", 10), Brushes.White, 126, 399);

            //Nodo 2
            grafico.FillEllipse(Brushes.Brown, 155, 392, 30, 30);
            grafico.DrawString("35", new Font("Arial", 10), Brushes.White, 161, 399);

            //Nodo 3
            grafico.FillEllipse(Brushes.Brown, 190, 392, 30, 30);
            grafico.DrawString("30", new Font("Arial", 10), Brushes.White, 196, 399);

            //Nodo 4
            grafico.FillEllipse(Brushes.Brown, 225, 392, 30, 30);
            grafico.DrawString("42", new Font("Arial", 10), Brushes.White, 231, 399);

            //Nodo 5
            grafico.FillEllipse(Brushes.Brown, 260, 392, 30, 30);
            grafico.DrawString("45", new Font("Arial", 10), Brushes.White, 266, 399);

            //Nodo 6
            grafico.FillEllipse(Brushes.Brown, 295, 392, 30, 30);
            grafico.DrawString("40", new Font("Arial", 10), Brushes.White, 301, 399);

            //Nodo 7
            grafico.FillEllipse(Brushes.Brown, 330, 392, 30, 30);
            grafico.DrawString("55", new Font("Arial", 10), Brushes.White, 336, 399);

            //Nodo 8
            grafico.FillEllipse(Brushes.Brown, 365, 392, 30, 30);
            grafico.DrawString("65", new Font("Arial", 10), Brushes.White, 371, 399);

            //Nodo 9
            grafico.FillEllipse(Brushes.Brown, 400, 392, 30, 30);
            grafico.DrawString("75", new Font("Arial", 10), Brushes.White, 406, 399);

            //Nodo 10
            grafico.FillEllipse(Brushes.Brown, 435, 392, 30, 30);
            grafico.DrawString("70", new Font("Arial", 10), Brushes.White, 441, 399);

            //Nodo 11
            grafico.FillEllipse(Brushes.Brown, 470, 392, 30, 30);
            grafico.DrawString("60", new Font("Arial", 10), Brushes.White, 476, 399);

            //Nodo 12
            grafico.FillEllipse(Brushes.Brown, 505, 392, 30, 30);
            grafico.DrawString("50", new Font("Arial", 10), Brushes.White, 511, 399);

        }
    }
}
