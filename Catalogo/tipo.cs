//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Catalogo
{
    using System;
    using System.Collections.Generic;
    
    public partial class tipo
    {
        public tipo()
        {
            this.productoes = new HashSet<producto>();
        }
    
        public int id_tipo { get; set; }
        public string nombre { get; set; }
    
        public virtual ICollection<producto> productoes { get; set; }
    }
}