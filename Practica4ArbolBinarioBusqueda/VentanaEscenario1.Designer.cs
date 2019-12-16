namespace Practica4ArbolBinarioBusqueda
{
    partial class VentanaEscenario1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.graficaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorridosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preordenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inordenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postordenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficaToolStripMenuItem,
            this.recorridosToolStripMenuItem,
            this.regresarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // graficaToolStripMenuItem
            // 
            this.graficaToolStripMenuItem.Name = "graficaToolStripMenuItem";
            this.graficaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.graficaToolStripMenuItem.Text = "Grafica";
            this.graficaToolStripMenuItem.ToolTipText = "Muestra la interfaz gráfica del árbol.";
            this.graficaToolStripMenuItem.Click += new System.EventHandler(this.graficaToolStripMenuItem_Click);
            // 
            // recorridosToolStripMenuItem
            // 
            this.recorridosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preordenToolStripMenuItem,
            this.inordenToolStripMenuItem,
            this.postordenToolStripMenuItem});
            this.recorridosToolStripMenuItem.Name = "recorridosToolStripMenuItem";
            this.recorridosToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.recorridosToolStripMenuItem.Text = "Recorridos";
            // 
            // preordenToolStripMenuItem
            // 
            this.preordenToolStripMenuItem.Name = "preordenToolStripMenuItem";
            this.preordenToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.preordenToolStripMenuItem.Text = "Preorden";
            this.preordenToolStripMenuItem.ToolTipText = "Muestra los datos del recorrido en preorden.";
            this.preordenToolStripMenuItem.Click += new System.EventHandler(this.preordenToolStripMenuItem_Click);
            // 
            // inordenToolStripMenuItem
            // 
            this.inordenToolStripMenuItem.Name = "inordenToolStripMenuItem";
            this.inordenToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.inordenToolStripMenuItem.Text = "Inorden";
            this.inordenToolStripMenuItem.ToolTipText = "Muestra los datos del recorrido en Inorden.";
            this.inordenToolStripMenuItem.Click += new System.EventHandler(this.inordenToolStripMenuItem_Click);
            // 
            // postordenToolStripMenuItem
            // 
            this.postordenToolStripMenuItem.Name = "postordenToolStripMenuItem";
            this.postordenToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.postordenToolStripMenuItem.Text = "Postorden";
            this.postordenToolStripMenuItem.ToolTipText = "Muestra los datos del recorrido en Postorden.";
            this.postordenToolStripMenuItem.Click += new System.EventHandler(this.postordenToolStripMenuItem_Click);
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.regresarToolStripMenuItem.Text = "Regresar";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // VentanaEscenario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "VentanaEscenario1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escenario 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentanaEscenario1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem graficaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorridosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preordenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inordenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postordenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
    }
}