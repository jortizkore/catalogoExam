using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
    public partial class frnInicio : Form
    {
        ViewModels.vmProducto vmProducto;
        ViewModels.vmCategoriaProducto vmCategoria;
        ViewModels.vmTipoProducto vmTipo;


        public frnInicio()
        {
            InitializeComponent();
            nuevoToolStripMenuItem.Click += delegate { vmProducto.AgregarNuevo(); Limpiar(); };
            guardarToolStripMenuItem.Click += delegate { vmProducto.Guardar(); };
            eliminarToolStripMenuItem.Click += delegate { vmProducto.Eliminar(); };
        }

        private void tiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.frmTipoProductos frm = new Views.frmTipoProductos();
            frm.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.frmCategoriaProducto frm = new Views.frmCategoriaProducto();
            frm.ShowDialog();
        }

        void Limpiar()
        {
            categoriasListBox.DataSource = null;
            categoriasListBox.Items.Clear();
        }

        private void frnInicio_Load(object sender, EventArgs e)
        {
            vmCategoria = new ViewModels.vmCategoriaProducto();
            vmTipo = new ViewModels.vmTipoProducto();
            vmProducto = new ViewModels.vmProducto();

            vmCategoria.bs = categoriaBindingSource;
            vmTipo.bs = tipoBindingSource;
            vmProducto.bs = productoBindingSource;

            vmProducto.Cargar();
            vmTipo.Cargar();
            vmCategoria.Cargar();
            vmProducto.CargarCategoriasProducto();
            CargarCategoriasProducto();
        }

        void CargarCategoriasProducto()
        {
            categoriasListBox.DataSource = vmProducto.CargarCategoriasProducto();
            categoriasListBox.DisplayMember = "categoria1";
            categoriasListBox.ValueMember = "id_categoria";
        }

        private void cmdAgregarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                int idCategoria = int.Parse(categoria1ComboBox.SelectedValue.ToString());
                vmProducto.AgregarCategoria(idCategoria);
                vmProducto.CargarCategoriasProducto();
                CargarCategoriasProducto();
            }
            catch (Exception)
            {

            }
        }

        private void productoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            vmProducto.CargarCategoriasProducto();
            CargarCategoriasProducto();
        }

        private void porCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.frmReporteCategoriaProducto frm = new Reportes.frmReporteCategoriaProducto();
            frm.ShowDialog();
        }

        private void porTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.frmReporteTipoProducto frm = new Reportes.frmReporteTipoProducto();
            frm.ShowDialog();
        }
    }
}
