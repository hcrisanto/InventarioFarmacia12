using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.InventarioFarmacia;

namespace InventarioFarmacia
{
    public partial class FormReporteProducto2 : Form
    {
        public FormReporteProducto2()
        {
            InitializeComponent();

            var _productoBL = new ProductosBL();
            var _categoriasBL = new CategoriasBL();
            var _tiposBL = new TiposBL();

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = _productoBL.ObtenerProducto();

            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = _categoriasBL.ObtenerCategorias();

            var bindingSource3 = new BindingSource();
            bindingSource3.DataSource = _tiposBL.ObtenerTipos();

            var reporte = new ReporteProductos();
            reporte.Database.Tables["Producto"].SetDataSource(bindingSource1);
            reporte.Database.Tables["Categoria"].SetDataSource(bindingSource2);
            reporte.Database.Tables["Tipo"].SetDataSource(bindingSource3);

            
            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();

            /*var _productoBL = new productosBL();//Creamos la variable productosBL
            var bindingSource = new BindingSource();//Enlasar Reportes bindingSource
            bindingSource.DataSource = _productoBL.ObtenerProducto();//

            var reporte = new ReporteProductos();//Archivo que se creo que se diseno en Crystal Report
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();//Refresh genera el Reporte
            */
        
        }
    }
}
