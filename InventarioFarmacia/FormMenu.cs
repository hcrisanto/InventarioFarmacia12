using BL.InventarioFarmacia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioFarmacia
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            var formlogin = new FormLogin();
            formlogin.ShowDialog();
            Login();
        }

        private void Login()
        {
        if (Program.UsuarioLogueado != null)
            {
                toolStripStatusLabel1.Text = " Usuario: "
                    + Program.UsuarioLogueado.Nombre;

                

                if (Program.UsuarioLogueado.TipoUsuario == "Caja")
                {
                   
                    facturaToolStripMenuItem.Visible = true;
                    
                    reporteDeFacturasToolStripMenuItem.Visible = true;
                    generarFacturaToolStripMenuItem.Visible = true;
                    perfilesToolStripMenuItem.Visible = true;
                }

                /*  if (Program.UsuarioLogueado.TipoUsuario == "Ventas")
                  {
                      productoToolStripMenuItem1.Visible = false;
                      clientesToolStripMenuItem1.Visible = true;
                      facturaToolStripMenuItem.Visible = true;
                      usuariosToolStripMenuItem.Visible = false;
                      reporteDeProductosToolStripMenuItem1.Visible = false;
                      reporteDeFacturasToolStripMenuItem.Visible = false;
                      generarFacturaToolStripMenuItem.Visible = true;
                      perfilesToolStripMenuItem.Visible = true;
                  }
                  */
                if (Program.UsuarioLogueado.TipoUsuario == "Administradores")
                {
                    productoToolStripMenuItem1.Visible = true;
                    clientesToolStripMenuItem1.Visible = true;
                    facturaToolStripMenuItem.Visible = true;
                    usuariosToolStripMenuItem.Visible = true;
                    reporteDeProductosToolStripMenuItem1.Visible = true;
                    reporteDeFacturasToolStripMenuItem.Visible = true;
                    generarFacturaToolStripMenuItem.Visible = true;
                    perfilesToolStripMenuItem.Visible = true;
                }

            }
            else
            {
                Application.Exit();
            }
        }

        private void ingresoSalidaDeMedicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forminventario = new FormmantInventario();
            forminventario.ShowDialog();
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormLogin = new FormLogin();
            FormLogin.ShowDialog();
            Login();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void reporte1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reporte3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Producto = new FormProducto();
            Producto.ShowDialog();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Proveedores = new FormProveedores();
            Proveedores.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Clientes = new FormClientes();
            Clientes.ShowDialog();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new FormFactura();
            formFactura.MdiParent = this;// Propiedad para desplegar Pantalla dentro de un menu. se modifico la prop. IsMdiContainer = true
            formFactura.Show();
        }

        private void reporte2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reporteDeProductosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formReporteProductos = new FormReporteProducto2();
            formReporteProductos.MdiParent = this;
            formReporteProductos.Show();
        }

        private void reporteDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormReporteFacturas = new FormReporteFacturas();
            FormReporteFacturas.MdiParent = this;
            FormReporteFacturas.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormUsuario = new FormUsuario();
            FormUsuario.ShowDialog();
        }
    }
}
