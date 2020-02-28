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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transaccionesToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(555, 24);
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
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.transaccionesToolStripMenuItem.Text = "Inicio";
            this.transaccionesToolStripMenuItem.Click += new System.EventHandler(this.transaccionesToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem1
            // 
            this.productoToolStripMenuItem1.Name = "productoToolStripMenuItem1";
            this.productoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.productoToolStripMenuItem1.Text = "Producto";
            this.productoToolStripMenuItem1.Click += new System.EventHandler(this.productoToolStripMenuItem1_Click);
            // 
            // proveedoresToolStripMenuItem1
            // 
            this.proveedoresToolStripMenuItem1.Name = "proveedoresToolStripMenuItem1";
            this.proveedoresToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.proveedoresToolStripMenuItem1.Text = "Proveedores";
            this.proveedoresToolStripMenuItem1.Click += new System.EventHandler(this.proveedoresToolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporte1ToolStripMenuItem,
            this.reporte2ToolStripMenuItem,
            this.reporte3ToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporte1ToolStripMenuItem
            // 
            this.reporte1ToolStripMenuItem.Name = "reporte1ToolStripMenuItem";
            this.reporte1ToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.reporte1ToolStripMenuItem.Text = "Reporte de Gastos";
            this.reporte1ToolStripMenuItem.Click += new System.EventHandler(this.reporte1ToolStripMenuItem_Click);
            // 
            // reporte2ToolStripMenuItem
            // 
            this.reporte2ToolStripMenuItem.Name = "reporte2ToolStripMenuItem";
            this.reporte2ToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.reporte2ToolStripMenuItem.Text = "Reportes de Ingresos";
            // 
            // reporte3ToolStripMenuItem
            // 
            this.reporte3ToolStripMenuItem.Name = "reporte3ToolStripMenuItem";
            this.reporte3ToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.reporte3ToolStripMenuItem.Text = "Reporte de Inventario";
            this.reporte3ToolStripMenuItem.Click += new System.EventHandler(this.reporte3ToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarFacturaToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.clientesToolStripMenuItem.Text = "Facturacion";
            // 
            // generarFacturaToolStripMenuItem
            // 
            this.generarFacturaToolStripMenuItem.Name = "generarFacturaToolStripMenuItem";
            this.generarFacturaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.generarFacturaToolStripMenuItem.Text = "Generar Factura";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilesToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // perfilesToolStripMenuItem
            // 
            this.perfilesToolStripMenuItem.Name = "perfilesToolStripMenuItem";
            this.perfilesToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.perfilesToolStripMenuItem.Text = "Log out";
            this.perfilesToolStripMenuItem.Click += new System.EventHandler(this.perfilesToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 488);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.Text = "Menu Principal";
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
    }
}