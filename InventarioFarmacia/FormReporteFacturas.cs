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
    public partial class FormReporteFacturas : Form
    {
        public FormReporteFacturas()
        {
            InitializeComponent();

            var _facturasBL = new FacturaBL();//CREAR VARIABLES
            var bindingSource = new BindingSource();//Para enlasar el reporte
            bindingSource.DataSource = _facturasBL.ObtenerFacturas();

            var reporte = new ReporteFacturas();//creamos nuestro reporte que es nuestro archivo de cristal report
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();//Genera el Reporte

        }
    }
}
