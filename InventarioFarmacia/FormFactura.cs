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
    public partial class FormFactura : Form
    {
        FacturaBL _facturasBL;
        ClienteBL _clientesBL;
        productosBL _productosBL;
        

        public FormFactura()
        {
            InitializeComponent();
            _facturasBL = new FacturaBL();
            listadeFacturasBindingSource.DataSource = _facturasBL.ObtenerFacturas();

            _clientesBL = new ClienteBL();
            listadeClientesBindingSource.DataSource = _clientesBL.ObtenerClientes();

            _productosBL = new productosBL();
            listaProductosBindingSource.DataSource = _productosBL.ObtenerProducto();

        }

        private void subtotalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void subtotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _facturasBL.AgregarFattura();
            listadeFacturasBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones (bool valor)
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

        private void listadeFacturasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listadeFacturasBindingSource.EndEdit();

            var factura = (Factura)listadeFacturasBindingSource.Current;
            var resultado = _facturasBL.GuardarFactura(factura);

            if (resultado.Exitoso == true)
            {
                listadeFacturasBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Factura Guardada Exitosamente");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            _facturasBL.CancelarCambios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var factura = (Factura)listadeFacturasBindingSource.Current;

            _facturasBL.AgregarFacturaDetalle(factura);

            DeshabilitarHabilitarBotones(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var factura = (Factura)listadeFacturasBindingSource.Current;
            var facturaDetalle = (FacturaDetalle)facturaDetalleBindingSource.Current;

            _facturasBL.RemoverFacturaDetalle(factura, facturaDetalle);

            DeshabilitarHabilitarBotones(false);
        }

        private void facturaDetalleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void facturaDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var factura = (Factura)listadeFacturasBindingSource.Current;
            var detalle = (FacturaDetalle)facturaDetalleBindingSource.Current;
            var mensaje = _facturasBL.VerificarExistencia(detalle);

            if (mensaje == "")
            {
                _facturasBL.CalcularFactura(factura);
            }
            else
            {
                MessageBox.Show(mensaje);
            }

            listadeFacturasBindingSource.ResetBindings(false);
        }

        private void activoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea Anular Esta Factura?", "Anular", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Anular(id);
                }
            }
        }

        private void Anular(int id)
        {
            var resultado = _facturasBL.AnularFactura(id);

            if (resultado == true)
            {
                listadeFacturasBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al anular la factura");
            }
        }

        private void listadeFacturasBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var factura = (Factura)listadeFacturasBindingSource.Current;

            if (factura != null && factura.Id != 0 && factura.Activo == false)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
        }

        private void FormFactura_Load(object sender, EventArgs e)
        {

        }

        private void listaProductosBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var producto = (Producto)listaProductosBindingSource.Current;
                     
        }

        private void facturaDetalleBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void facturaDetalleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listadeClientesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }

}
