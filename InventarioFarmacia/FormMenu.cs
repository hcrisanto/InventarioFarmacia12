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
            Proveedores.ShowDialog();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Clientes = new FormClientes();
            Clientes.ShowDialog();
        }
    }
}
