using BL.InventarioFarmacia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioFarmacia
{
    public partial class FormProveedores : Form
    {
        ProveedorBL _proveedor;
        public FormProveedores()
        {
            InitializeComponent();

            _proveedor = new ProveedorBL();
            listaProveedoresBindingSource.DataSource = _proveedor.ObtenerProveedor();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {

        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _proveedor.AgregarProveedor();
             listaProveedoresBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(idTextBox.Text);//convirte a numerico el string del texto

            var resultado = _proveedor.EliminarProveedor(id);

            if (resultado == true)
            {
                listaProveedoresBindingSource.ResetBindings(false);

            }
            else
            {
                MessageBox.Show("Ocurrio un Errror al eliminar un proveedor");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listaProveedoresBindingSource.DataSource = _proveedor.BuscarProveedor(textBox1.Text);

            listaProveedoresBindingSource.ResetBindings(false);
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            _proveedor.CancelarCambios();
        }
    }
}
