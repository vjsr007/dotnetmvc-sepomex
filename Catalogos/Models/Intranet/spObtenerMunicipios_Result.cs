//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Catalogos.Models.Intranet
{
    using System;
    
    public partial class spObtenerMunicipios_Result
    {
        public int MunicipioID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> EstadoID { get; set; }
        public Nullable<System.DateTime> FechaUltimaModificacion { get; set; }
        public Nullable<int> UsuarioID { get; set; }
        public Nullable<bool> Activo { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public int PaisID { get; set; }
    }
}
