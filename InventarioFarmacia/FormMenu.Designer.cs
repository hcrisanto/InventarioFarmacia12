namespace InventarioFarmacia
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporte1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporte2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporte3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SkyBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transaccionesToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(555, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem1,
            this.proveedoresToolStripMenuItem1,
            this.clientesToolStripMenuItem1});
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(74, 31);
            this.transaccionesToolStripMenuItem.Text = "Inicio";
            this.transaccionesToolStripMenuItem.Click += new System.EventHandler(this.transaccionesToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem1
            // 
            this.productoToolStripMenuItem1.Name = "productoToolStripMenuItem1";
            this.productoToolStripMenuItem1.Size = new System.Drawing.Size(191, 32);
            this.productoToolStripMenuItem1.Text = "Producto";
            this.productoToolStripMenuItem1.Click += new System.EventHandler(this.productoToolStripMenuItem1_Click);
            // 
            // proveedoresToolStripMenuItem1
            // 
            this.proveedoresToolStripMenuItem1.Name = "proveedoresToolStripMenuItem1";
            this.proveedoresToolStripMenuItem1.Size = new System.Drawing.Size(191, 32);
            this.proveedoresToolStripMenuItem1.Text = "Proveedores";
            this.proveedoresToolStripMenuItem1.Click += new System.EventHandler(this.proveedoresToolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(191, 32);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporte1ToolStripMenuItem,
            this.reporte2ToolStripMenuItem,
            this.reporte3ToolStripMenuItem,
            this.reporteDeFacturasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(103, 31);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporte1ToolStripMenuItem
            // 
            this.reporte1ToolStripMenuItem.Name = "reporte1ToolStripMenuItem";
            this.reporte1ToolStripMenuItem.Size = new System.Drawing.Size(279, 32);
            this.reporte1ToolStripMenuItem.Text = "Reporte de Prductos";
            this.reporte1ToolStripMenuItem.Click += new System.EventHandler(this.reporte1ToolStripMenuItem_Click);
            // 
            // reporte2ToolStripMenuItem
            // 
            this.reporte2ToolStripMenuItem.Name = "reporte2ToolStripMenuItem";
            this.reporte2ToolStripMenuItem.Size = new System.Drawing.Size(279, 32);
            this.reporte2ToolStripMenuItem.Text = "Reportes de Ingresos";
            // 
            // reporte3ToolStripMenuItem
            // 
            this.reporte3ToolStripMenuItem.Name = "reporte3ToolStripMenuItem";
            this.reporte3ToolStripMenuItem.Size = new System.Drawing.Size(279, 32);
            this.reporte3ToolStripMenuItem.Text = "Reporte de Inventario";
            this.reporte3ToolStripMenuItem.Click += new System.EventHandler(this.reporte3ToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarFacturaToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(129, 31);
            this.clientesToolStripMenuItem.Text = "Facturación";
            // 
            // generarFacturaToolStripMenuItem
            // 
            this.generarFacturaToolStripMenuItem.Name = "generarFacturaToolStripMenuItem";
            this.generarFacturaToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
            this.generarFacturaToolStripMenuItem.Text = "Generar Factura";
            this.generarFacturaToolStripMenuItem.Click += new System.EventHandler(this.generarFacturaToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilesToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(113, 31);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // perfilesToolStripMenuItem
            // 
            this.perfilesToolStripMenuItem.Name = "perfilesToolStripMenuItem";
            this.perfilesToolStripMenuItem.Size = new System.Drawing.Size(149, 32);
            this.perfilesToolStripMenuItem.Text = "Log out";
            this.perfilesToolStripMenuItem.Click += new System.EventHandler(this.perfilesToolStripMenuItem_Click);
            // 
            // reporteDeFacturasToolStripMenuItem
            // 
            this.reporteDeFacturasToolStripMenuItem.Name = "reporteDeFacturasToolStripMenuItem";
            this.reporteDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(279, 32);
            this.reporteDeFacturasToolStripMenuItem.Text = "Reporte de Facturas";
            this.reporteDeFacturasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeFacturasToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 488);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporte1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporte2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporte3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reporteDeFacturasToolStripMenuItem;
    }
}