﻿using System;
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
    public partial class VentanaMenu : Form
    {
        public VentanaMenu()
        {
            InitializeComponent();
        }

        private void CerrarVentana()
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaEscenario1 ve1 = new VentanaEscenario1();
            ve1.Visible = true;
            this.Dispose();
        }       

        private void button2_Click(object sender, EventArgs e)
        {
            VentanaEscenario2 ve2 = new VentanaEscenario2();
            ve2.Visible = true;
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CerrarVentana();
        }

        private void VentanaMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarVentana();
        }

        
    }
}
