using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo.Views
{
    public partial class frmTipoProductos : Form
    {
        ViewModels.vmTipoProducto vm = new ViewModels.vmTipoProducto();
        public frmTipoProductos()
        {
            InitializeComponent();
            vm.bs = tipoBindingSource;
            nuevoToolStripMenuItem.Click += delegate { vm.AgregarNuevo(); };
            guardarToolStripMenuItem.Click += delegate { vm.Guardar(); };
            eliminarToolStripMenuItem.Click += delegate { vm.Eliminar(); };
        }

        private void frmTipoProductos_Load(object sender, EventArgs e)
        {
            vm.Cargar();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
