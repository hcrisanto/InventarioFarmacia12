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
    public partial class FormReporteProductos : Form
    {
        public FormReporteProductos()
        {
            InitializeComponent();

            var _productoBL = new productosBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _productoBL.ObtenerProducto();

            var reporte = new ReporteProducto();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport(); 
        }
    }
}
