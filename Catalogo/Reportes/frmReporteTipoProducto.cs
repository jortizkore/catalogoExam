using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo.Reportes
{
    public partial class frmReporteTipoProducto : Form
    {
        ViewModels.vmProducto vm;
        public frmReporteTipoProducto()
        {
            InitializeComponent();
            vm = new ViewModels.vmProducto();
        }

        private void frmReporteTipoProducto_Load(object sender, EventArgs e)
        {
            vm.bs = productoBindingSource;
            vm.Cargar();
            this.reportViewer1.RefreshReport();
        }
    }
}
