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
            listadeProvedoresBindingSource.DataSource = _proveedor.ObtenerProveedor();
 

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

        private void listadeProvedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
