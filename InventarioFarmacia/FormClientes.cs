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
    public partial class FormClientes : Form
    {
        ClienteBL _clientes;

        public FormClientes()
        {
            InitializeComponent();

            _clientes = new ClienteBL();
            listadeClientesBindingSource.DataSource = _clientes.ObtenerCliente();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
             
        }

        private void toolStripButton1Cancelar_Click(object sender, EventArgs e)
        {
            _clientes.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _clientes.AgregarCliente();
            listadeClientesBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool v)
        {
            throw new NotImplementedException();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(idTextBox.Text);//convirte a numerico el string del texto

            var resultado = _clientes.EliminarCliente(id);

            if (resultado == true)
            {
                listadeClientesBindingSource.ResetBindings(false);

            }
            else
            {
                MessageBox.Show("Ocurrio un Errror al eliminar un cliente");
            }
        }

        private void listadeClientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listadeClientesBindingSource.EndEdit();
            var clientes = (Cliente)listadeClientesBindingSource.Current;
            var resultado = _clientes.GuardarCliente(clientes);

            if (resultado.Exitoso == true)
            {
                MessageBox.Show(resultado.Mensaje);
                listadeClientesBindingSource.ResetBindings(false);

            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }


        }
    }
    }
    

