using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo.ViewModels
{
    class vmProducto : IDisposable
    {
        catalogoEntities db;
        public BindingSource bs { get; set; }

        public void Dispose()
        {
            db.Dispose();
        }

        public vmProducto() => db = new catalogoEntities();

        public void Cargar()
        {
            db.productoes.Load();
            bs.DataSource = db.productoes.Local.ToBindingList();
        }

        public void Guardar()
        {
            try
            {

                bs.EndEdit();
                db.SaveChanges();
                Utilidades.MessageManager.InfoMessage("Datos Guardados");
            }
            catch (Exception ex)
            {
                Utilidades.MessageManager.ErrorMessage(ex.Message);
            }
        }

        public void Eliminar()
        {
            var eliminar = Utilidades.MessageManager.Question("Desea eliminar este registro?") == DialogResult.Yes
                            ? true : false;
            if (eliminar)
            {
                bs.RemoveCurrent();
            }
        }

        public void AgregarNuevo() => bs.AddNew();

        public List<categoria> CargarCategoriasProducto()
        {
            var prod = (producto)bs.Current;
            return prod.categorias.ToList();
        }

        public void AgregarCategoria(int id)
        {
            var prod = (producto)bs.Current;
            var cat = db.categorias.Where(x => x.id_categoria == id).FirstOrDefault();
            prod.categorias.Add(cat);
        }
    }
}
