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
    public partial class FormReporteFactura : Form
    {
        public FormReporteFactura()
        {
            InitializeComponent();

            var _facturaBL = new FacturasBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _facturaBL.ObtenerFacturas();

            var reporte = new ReporteFacturas();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
