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
    public partial class FormProveedores : Form
    {
        ProveedorBL _proveedor;

        public FormProveedores()
        {
            InitializeComponent();

            _proveedor = new ProveedorBL();
            //listaProveedoresBindingSource.DataSource = _proveedor.ObtenerProveedor();
 

        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

      /*  private void listaProveedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaProveedoresBindingSource.EndEdit();
            var proveedor = (Proveedor)listaProveedoresBindingSource.Current;
            var resultado = _proveedor.GuardarProveedor(proveedor);


            if (resultado.Exitoso == true)
            {
                listaProveedoresBindingSource.ResetBindings(false);

            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }*/

      /*  private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(idTextBox.Text);//convirte a numerico el string del texto

            var resultado = _proveedor.EliminarProveedor(id);

            if (resultado == true)
            {
                listaProveedorBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un Errror al eliminar un producto");
            }
        }*/

     /*   private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _proveedor.AgregarProveedor();
            listaProveedoresBindingSource.MoveLast();
        }*/
    }
}
