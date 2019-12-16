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
    public partial class VentanaEscenario2 : Form
    {
        public VentanaEscenario2()
        {
            InitializeComponent();
        }

        private void CerrarVentana()
        {
            VentanaMenu vm = new VentanaMenu();
            vm.Visible = true;
            this.Dispose();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarVentana();
        }

        private void VentanaEscenario2_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarVentana();
        }

        private void PintarInorden()
        {
            Graphics grafico = CreateGraphics();
            grafico.DrawString("Inorden:", new Font("Arial", 10), Brushes.Black, 55, 68);

            //Nodo 1
            grafico.FillEllipse(Brushes.Brown, 120, 60, 30, 30);
            grafico.DrawString("27", new Font("Arial", 10), Brushes.White, 126, 67);

            //Nodo 2
            grafico.FillEllipse(Brushes.Brown, 155, 60, 30, 30);
            grafico.DrawString("30", new Font("Arial", 10), Brushes.White, 161, 67);

            //Nodo 3
            grafico.FillEllipse(Brushes.Brown, 190, 60, 30, 30);
            grafico.DrawString("34", new Font("Arial", 10), Brushes.White, 196, 67);

            //Nodo 4
            grafico.FillEllipse(Brushes.Brown, 225, 60, 30, 30);
            grafico.DrawString("35", new Font("Arial", 10), Brushes.White, 231, 67);

            //Nodo 5
            grafico.FillEllipse(Brushes.Brown, 260, 60, 30, 30);
            grafico.DrawString("36", new Font("Arial", 10), Brushes.White, 266, 67);

            //Nodo 6
            grafico.FillEllipse(Brushes.Brown, 295, 60, 30, 30);
            grafico.DrawString("38", new Font("Arial", 10), Brushes.White, 301, 67);

            //Nodo 7
            grafico.FillEllipse(Brushes.Brown, 330, 60, 30, 30);
            grafico.DrawString("41", new Font("Arial", 10), Brushes.White, 336, 67);

            //Nodo 8
            grafico.FillEllipse(Brushes.Brown, 365, 60, 30, 30);
            grafico.DrawString("47", new Font("Arial", 10), Brushes.White, 371, 67);

            //Nodo 9
            grafico.FillEllipse(Brushes.Brown, 400, 60, 30, 30);
            grafico.DrawString("85", new Font("Arial", 10), Brushes.White, 406, 67);

            //Nodo 10
            grafico.FillEllipse(Brushes.Brown, 435, 60, 30, 30);
            grafico.DrawString("93", new Font("Arial", 10), Brushes.White, 441, 67);
        }

        private void PintarPreorden()
        {
            Graphics grafico = CreateGraphics();
            grafico.DrawString("Preorden:", new Font("Arial", 10), Brushes.Black, 55, 120);

            //Nodo 1
            grafico.FillEllipse(Brushes.Brown, 120, 112, 30, 30);
            grafico.DrawString("36", new Font("Arial", 10), Brushes.White, 126, 119);

            //Nodo 2
            grafico.FillEllipse(Brushes.Brown, 155, 112, 30, 30);
            grafico.DrawString("30", new Font("Arial", 10), Brushes.White, 161, 119);

            //Nodo 3
            grafico.FillEllipse(Brushes.Brown, 190, 112, 30, 30);
            grafico.DrawString("27", new Font("Arial", 10), Brushes.White, 196, 119);

            //Nodo 4
            grafico.FillEllipse(Brushes.Brown, 225, 112, 30, 30);
            grafico.DrawString("35", new Font("Arial", 10), Brushes.White, 231, 119);

            //Nodo 5
            grafico.FillEllipse(Brushes.Brown, 260, 112, 30, 30);
            grafico.DrawString("34", new Font("Arial", 10), Brushes.White, 266, 119);

            //Nodo 6
            grafico.FillEllipse(Brushes.Brown, 295, 112, 30, 30);
            grafico.DrawString("41", new Font("Arial", 10), Brushes.White, 301, 119);

            //Nodo 7
            grafico.FillEllipse(Brushes.Brown, 330, 112, 30, 30);
            grafico.DrawString("38", new Font("Arial", 10), Brushes.White, 336, 119);

            //Nodo 8
            grafico.FillEllipse(Brushes.Brown, 365, 112, 30, 30);
            grafico.DrawString("85", new Font("Arial", 10), Brushes.White, 371, 119);

            //Nodo 9
            grafico.FillEllipse(Brushes.Brown, 400, 112, 30, 30);
            grafico.DrawString("47", new Font("Arial", 10), Brushes.White, 406, 119);

            //Nodo 10
            grafico.FillEllipse(Brushes.Brown, 435, 112, 30, 30);
            grafico.DrawString("93", new Font("Arial", 10), Brushes.White, 441, 119);
        }

        private void PintarPostorden()
        {
            Graphics grafico = CreateGraphics();
            grafico.DrawString("Postorden:", new Font("Arial", 10), Brushes.Black, 50, 170);

            //Nodo 1
            grafico.FillEllipse(Brushes.Brown, 120, 162, 30, 30);
            grafico.DrawString("27", new Font("Arial", 10), Brushes.White, 126, 169);

            //Nodo 2
            grafico.FillEllipse(Brushes.Brown, 155, 162, 30, 30);
            grafico.DrawString("34", new Font("Arial", 10), Brushes.White, 161, 169);

            //Nodo 3
            grafico.FillEllipse(Brushes.Brown, 190, 162, 30, 30);
            grafico.DrawString("35", new Font("Arial", 10), Brushes.White, 196, 169);

            //Nodo 4
            grafico.FillEllipse(Brushes.Brown, 225, 162, 30, 30);
            grafico.DrawString("30", new Font("Arial", 10), Brushes.White, 231, 169);

            //Nodo 5
            grafico.FillEllipse(Brushes.Brown, 260, 162, 30, 30);
            grafico.DrawString("38", new Font("Arial", 10), Brushes.White, 266, 169);

            //Nodo 6
            grafico.FillEllipse(Brushes.Brown, 295, 162, 30, 30);
            grafico.DrawString("47", new Font("Arial", 10), Brushes.White, 301, 169);

            //Nodo 7
            grafico.FillEllipse(Brushes.Brown, 330, 162, 30, 30);
            grafico.DrawString("93", new Font("Arial", 10), Brushes.White, 336, 169);

            //Nodo 8
            grafico.FillEllipse(Brushes.Brown, 365, 162, 30, 30);
            grafico.DrawString("85", new Font("Arial", 10), Brushes.White, 371, 169);

            //Nodo 9
            grafico.FillEllipse(Brushes.Brown, 400, 162, 30, 30);
            grafico.DrawString("41", new Font("Arial", 10), Brushes.White, 406, 169);

            //Nodo 10
            grafico.FillEllipse(Brushes.Brown, 435, 162, 30, 30);
            grafico.DrawString("36", new Font("Arial", 10), Brushes.White, 441, 169);

        }

        private void graficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics grafico = CreateGraphics();
            Pen linea = new Pen(Brushes.Tomato, 2);
            //Primer nivel.
            //Primer nodo (nodo raiz)
            grafico.FillEllipse(Brushes.Brown, 280, 300, 40, 40);
            grafico.DrawString("36", new Font("Arial", 10), Brushes.White, 292, 312);

            //Nodo izquierdo hijo
            grafico.FillEllipse(Brushes.Brown, 180, 340, 40, 40);
            grafico.DrawString("30", new Font("Arial", 10), Brushes.White, 192, 352);

            grafico.DrawLine(linea, 220, 360, 280, 320);

            //Nodo derecho hijo
            grafico.FillEllipse(Brushes.Brown, 380, 340, 40, 40);
            grafico.DrawString("41", new Font("Arial", 10), Brushes.White, 392, 352);

            grafico.DrawLine(linea, 320, 320, 380, 360);
            
            //Segundo nivel
            //Nodo raiz 30
            //Nodo izquierdo hijo
            grafico.FillEllipse(Brushes.Brown, 105, 380, 40, 40);
            grafico.DrawString("27", new Font("Arial", 10), Brushes.White, 117, 392);

            grafico.DrawLine(linea, 145, 400, 180, 360);

            //Nodo derecho hijo
            grafico.FillEllipse(Brushes.Brown, 255, 380, 40, 40);
            grafico.DrawString("35", new Font("Arial", 10), Brushes.White, 267, 392);

            grafico.DrawLine(linea, 220, 360, 255, 400);

            //Nodo raiz 41
            //Nodo izquierdo hijo
            grafico.FillEllipse(Brushes.Brown, 305, 380, 40, 40);
            grafico.DrawString("38", new Font("Arial", 10), Brushes.White, 317, 392);

            grafico.DrawLine(linea, 345, 400, 380, 360);

            //Nodo derecho hijo
            grafico.FillEllipse(Brushes.Brown, 455, 380, 40, 40);
            grafico.DrawString("85", new Font("Arial", 10), Brushes.White, 467, 392);

            grafico.DrawLine(linea, 420, 360, 455, 400);

            //Nodo raiz 35
            //Nodo izquierdo hijo
            grafico.FillEllipse(Brushes.Brown, 205, 420, 40, 40);
            grafico.DrawString("34", new Font("Arial", 10), Brushes.White, 217, 432);

            grafico.DrawLine(linea, 245, 440, 255, 400);

            //Nodo raiz 85
            //Nodo izquierdo hijo
            grafico.FillEllipse(Brushes.Brown, 405, 420, 40, 40);
            grafico.DrawString("47", new Font("Arial", 10), Brushes.White, 417, 432);

            grafico.DrawLine(linea, 445, 440, 455, 400);

            //Nodo derecho hijo
            grafico.FillEllipse(Brushes.Brown, 505, 420, 40, 40);
            grafico.DrawString("93", new Font("Arial", 10), Brushes.White, 517, 432);

            grafico.DrawLine(linea, 495, 400, 505,440);

        }

        private void recorridosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PintarInorden();
            PintarPreorden();
            PintarPostorden();
        }
    }
}
