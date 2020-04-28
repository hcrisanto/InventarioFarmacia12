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
    public partial class FormUsuario : Form
    {
        SeguridadBL _seguridadBL;
        public FormUsuario()
        {
            InitializeComponent();

            _seguridadBL = new SeguridadBL();

            seguridadBL_UsurarioBindingSource.DataSource = _seguridadBL.ObtenerUsuarios();
        }

        private void seguridadBL_UsurarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            seguridadBL_UsurarioBindingSource.EndEdit();
            var usuario = (Usuario)seguridadBL_UsurarioBindingSource.Current;

            var resultado = _seguridadBL.GuardarUsuario(usuario);

            if (resultado.Exitoso == true)
            {
                seguridadBL_UsurarioBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show(" Usuario Guardado ");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }

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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _seguridadBL.AgregarUsuario();
            seguridadBL_UsurarioBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text  != " " )
            {
                var resultado = MessageBox.Show(" Desea eliminar este registro? ", " Eliminar ", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    eliminar(id);
                }
            }
        }

        private void  eliminar(int id)
        {
            var resultado = _seguridadBL.EliminarUsuario(id);

            if (resultado == true)
            {
                seguridadBL_UsurarioBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show(" Ocurrio un error al eliminar el usuario ");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _seguridadBL.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }
    }
    
}
