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
    public partial class VentanaInicial : Form
    {
        public VentanaInicial()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "123")
            {
                VentanaMenu vm = new VentanaMenu();
                vm.Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show(this, "Digite la contraseña correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
