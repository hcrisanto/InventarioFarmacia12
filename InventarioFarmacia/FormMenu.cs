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
            this.Close();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reporte1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteProductos = new FormReporteProductos();
            formReporteProductos.Show();
        }

        private void reporte3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formProducto = new FormProducto();
            formProducto.ShowDialog();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formproveedores = new FormProveedores();
            formproveedores.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formClientes = new FormClientes();
            formClientes.ShowDialog();
        }

        private void generarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new FormFactura();
            formFactura.Show();
        }

        private void reporteDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteFacturas = new FormReporteFactura();
            formReporteFacturas.Show();
        }
    }
}
