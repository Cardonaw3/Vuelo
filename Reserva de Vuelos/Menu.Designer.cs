namespace Reserva_de_Vuelos
{
    partial class Menu
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
            this.vueloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionDeVueloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vueloToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(412, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vueloToolStripMenuItem
            // 
            this.vueloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccionDeVueloToolStripMenuItem});
            this.vueloToolStripMenuItem.Name = "vueloToolStripMenuItem";
            this.vueloToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.vueloToolStripMenuItem.Text = "Vuelo";
            // 
            // seleccionDeVueloToolStripMenuItem
            // 
            this.seleccionDeVueloToolStripMenuItem.Name = "seleccionDeVueloToolStripMenuItem";
            this.seleccionDeVueloToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.seleccionDeVueloToolStripMenuItem.Text = "Seleccion de Vuelo";
            this.seleccionDeVueloToolStripMenuItem.Click += new System.EventHandler(this.seleccionDeVueloToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservasToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelarToolStripMenuItem});
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reservasToolStripMenuItem.Text = "Reservas";
            this.reservasToolStripMenuItem.Click += new System.EventHandler(this.reservasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.salirToolStripMenuItem.Text = "Salir ";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // cancelarToolStripMenuItem
            // 
            this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cancelarToolStripMenuItem.Text = "Cancelar";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 324);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vueloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionDeVueloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
    }
}