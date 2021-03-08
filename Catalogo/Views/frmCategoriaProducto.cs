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
    public partial class frmCategoriaProducto : Form
    {

        ViewModels.vmCategoriaProducto vm;
        public frmCategoriaProducto()
        {
            InitializeComponent();
            vm = new ViewModels.vmCategoriaProducto();
            vm.bs = categoriaBindingSource;

            nuevoToolStripMenuItem.Click += delegate { vm.AgregarNuevo(); };
            guardarToolStripMenuItem.Click += delegate { vm.Guardar(); };
            eliminarToolStripMenuItem.Click += delegate { vm.Eliminar(); };
            salirToolStripMenuItem.Click += delegate { this.Close(); };
        }

        private void frmCategoriaProducto_Load(object sender, EventArgs e)
        {
            vm.Cargar();
        }

    }
}
