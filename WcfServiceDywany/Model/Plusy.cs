//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceDywany.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Plusy
    {
        public int IdPlusu { get; set; }
        public Nullable<int> Indeks { get; set; }
        public Nullable<decimal> Ilosc { get; set; }
        public string Nazwa { get; set; }
        public Nullable<int> IdMiejsca { get; set; }
        public Nullable<decimal> Cena { get; set; }
    
        public virtual Miejsce Miejsce { get; set; }
    }
}
