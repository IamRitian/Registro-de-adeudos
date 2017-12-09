namespace main
{
    partial class main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroAdeudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeNominaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioCodigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiosArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adeudosPendientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiosEnUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.adeudosPendientesToolStripMenuItem,
            this.administracionDeUsuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroAdeudoToolStripMenuItem,
            this.listaDeNominaToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // registroAdeudoToolStripMenuItem
            // 
            this.registroAdeudoToolStripMenuItem.Name = "registroAdeudoToolStripMenuItem";
            this.registroAdeudoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.registroAdeudoToolStripMenuItem.Text = "Registro Adeudo";
            this.registroAdeudoToolStripMenuItem.Click += new System.EventHandler(this.registroAdeudoToolStripMenuItem_Click);
            // 
            // listaDeNominaToolStripMenuItem
            // 
            this.listaDeNominaToolStripMenuItem.Name = "listaDeNominaToolStripMenuItem";
            this.listaDeNominaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.listaDeNominaToolStripMenuItem.Text = "Lista de Nomina";
            this.listaDeNominaToolStripMenuItem.Click += new System.EventHandler(this.listaDeNominaToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantEmpleadoToolStripMenuItem,
            this.cambioCodigoToolStripMenuItem,
            this.mantArtículoToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // mantEmpleadoToolStripMenuItem
            // 
            this.mantEmpleadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEmpleadoToolStripMenuItem,
            this.eliminarEmpleadoToolStripMenuItem,
            this.cambioDeDatosToolStripMenuItem});
            this.mantEmpleadoToolStripMenuItem.Name = "mantEmpleadoToolStripMenuItem";
            this.mantEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.mantEmpleadoToolStripMenuItem.Text = "Mant. Empleado";
            // 
            // agregarEmpleadoToolStripMenuItem
            // 
            this.agregarEmpleadoToolStripMenuItem.Name = "agregarEmpleadoToolStripMenuItem";
            this.agregarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.agregarEmpleadoToolStripMenuItem.Text = "Agregar empleado";
            this.agregarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.agregarEmpleadoToolStripMenuItem_Click);
            // 
            // eliminarEmpleadoToolStripMenuItem
            // 
            this.eliminarEmpleadoToolStripMenuItem.Name = "eliminarEmpleadoToolStripMenuItem";
            this.eliminarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.eliminarEmpleadoToolStripMenuItem.Text = "Eliminar empleado";
            this.eliminarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.eliminarEmpleadoToolStripMenuItem_Click);
            // 
            // cambioDeDatosToolStripMenuItem
            // 
            this.cambioDeDatosToolStripMenuItem.Name = "cambioDeDatosToolStripMenuItem";
            this.cambioDeDatosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.cambioDeDatosToolStripMenuItem.Text = "Cambio de datos";
            this.cambioDeDatosToolStripMenuItem.Click += new System.EventHandler(this.cambioDeDatosToolStripMenuItem_Click);
            // 
            // cambioCodigoToolStripMenuItem
            // 
            this.cambioCodigoToolStripMenuItem.Name = "cambioCodigoToolStripMenuItem";
            this.cambioCodigoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cambioCodigoToolStripMenuItem.Text = "Cambio codigo";
            this.cambioCodigoToolStripMenuItem.Click += new System.EventHandler(this.cambioCodigoToolStripMenuItem_Click);
            // 
            // mantArtículoToolStripMenuItem
            // 
            this.mantArtículoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarArticuloToolStripMenuItem,
            this.eliminarArticuloToolStripMenuItem,
            this.cambiosArticuloToolStripMenuItem});
            this.mantArtículoToolStripMenuItem.Name = "mantArtículoToolStripMenuItem";
            this.mantArtículoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.mantArtículoToolStripMenuItem.Text = "Mant. Artículo";
            // 
            // agregarArticuloToolStripMenuItem
            // 
            this.agregarArticuloToolStripMenuItem.Name = "agregarArticuloToolStripMenuItem";
            this.agregarArticuloToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.agregarArticuloToolStripMenuItem.Text = "Agregar articulo";
            this.agregarArticuloToolStripMenuItem.Click += new System.EventHandler(this.agregarArticuloToolStripMenuItem_Click_1);
            // 
            // eliminarArticuloToolStripMenuItem
            // 
            this.eliminarArticuloToolStripMenuItem.Name = "eliminarArticuloToolStripMenuItem";
            this.eliminarArticuloToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.eliminarArticuloToolStripMenuItem.Text = "Eliminar articulo";
            this.eliminarArticuloToolStripMenuItem.Click += new System.EventHandler(this.eliminarArticuloToolStripMenuItem_Click);
            // 
            // cambiosArticuloToolStripMenuItem
            // 
            this.cambiosArticuloToolStripMenuItem.Name = "cambiosArticuloToolStripMenuItem";
            this.cambiosArticuloToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cambiosArticuloToolStripMenuItem.Text = "Cambios articulo";
            this.cambiosArticuloToolStripMenuItem.Click += new System.EventHandler(this.cambiosArticuloToolStripMenuItem_Click);
            // 
            // adeudosPendientesToolStripMenuItem
            // 
            this.adeudosPendientesToolStripMenuItem.Name = "adeudosPendientesToolStripMenuItem";
            this.adeudosPendientesToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.adeudosPendientesToolStripMenuItem.Text = "Adeudos pendientes";
            this.adeudosPendientesToolStripMenuItem.Click += new System.EventHandler(this.adeudosPendientesToolStripMenuItem_Click);
            // 
            // administracionDeUsuariosToolStripMenuItem
            // 
            this.administracionDeUsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem,
            this.cambiosEnUsuarioToolStripMenuItem});
            this.administracionDeUsuariosToolStripMenuItem.Name = "administracionDeUsuariosToolStripMenuItem";
            this.administracionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.administracionDeUsuariosToolStripMenuItem.Text = "Administracion de usuarios";
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            this.agregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.agregarUsuarioToolStripMenuItem.Text = "Agregar usuario";
            this.agregarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.agregarUsuarioToolStripMenuItem_Click);
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar usuario";
            // 
            // cambiosEnUsuarioToolStripMenuItem
            // 
            this.cambiosEnUsuarioToolStripMenuItem.Name = "cambiosEnUsuarioToolStripMenuItem";
            this.cambiosEnUsuarioToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.cambiosEnUsuarioToolStripMenuItem.Text = "Cambios en usuario";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 582);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "Ventana principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroAdeudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeNominaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioCodigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantArtículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiosArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiosEnUsuarioToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem administracionDeUsuariosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem adeudosPendientesToolStripMenuItem;
    }
}

