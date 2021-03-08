using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo.ViewModels
{
    class vmCategoriaProducto : IDisposable
    {
        catalogoEntities db;
        public BindingSource bs { get; set; }

        public void Dispose()
        {
            db.Dispose();
        }

        public vmCategoriaProducto() => db = new catalogoEntities();

        public void Cargar()
        {
            db.categorias.Load();
            bs.DataSource = db.categorias.Local.ToBindingList();
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
                throw;
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

        public void AgregarCategoriaPadre(int id)
        {
            try
            {
                var actual = (categoria)bs.Current;
                var padre = db.categorias.Where(x => x.id_categoria == id).FirstOrDefault();
                actual.categoria_padre = padre.id_categoria;
            }
            catch (Exception)
            {
                Utilidades.MessageManager.ErrorMessage("No pudo asignarse el padre");
            }
        }

        public List<categoria> CargarCategorias()
        {
            return db.categorias.ToList();
        }

        public string CargarPadre()
        {
            try
            {
                var actual = (categoria)bs.Current;
                var padre = db.categorias.Where(x => x.id_categoria == actual.categoria_padre).FirstOrDefault();
                return padre.categoria1;
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
