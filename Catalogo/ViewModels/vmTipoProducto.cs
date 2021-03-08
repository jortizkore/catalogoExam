using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo.ViewModels
{
    class vmTipoProducto : IDisposable
    {
        catalogoEntities db;
        public BindingSource bs { get; set; }


        public vmTipoProducto() => db = new catalogoEntities();

        public void Dispose()
        {
            db.Dispose();
        }

        public void Cargar()
        {
            db.tipoes.Load();
            bs.DataSource = db.tipoes.Local.ToBindingList();
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

        public void Eliminar() {
            var eliminar = Utilidades.MessageManager.Question("Desea eliminar este registro?") == DialogResult.Yes 
                            ? true : false;
            if(eliminar)
            {
                bs.RemoveCurrent();
            }
        }   

        public void AgregarNuevo() => bs.AddNew();
    }
}
