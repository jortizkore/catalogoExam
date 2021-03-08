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
    public partial class frmReporteCategoriaProducto : Form
    {
        catalogoEntities db = new catalogoEntities();
        ViewModels.vmProducto vmProd = new ViewModels.vmProducto();
        public frmReporteCategoriaProducto()
        {
            InitializeComponent();
        }

        private void frmReporteCategoriaProducto_Load(object sender, EventArgs e)
        {
            vmProd.bs = productoBindingSource;
            vmProd.Cargar();
            this.rptView.RefreshReport();
        }
    }
}
