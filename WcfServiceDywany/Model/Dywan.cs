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
    
    public partial class Dywan
    {
        public int IdDywanu { get; set; }
        public Nullable<int> Indeks { get; set; }
        public Nullable<decimal> Ilosc { get; set; }
        public string Nazwa { get; set; }
        public string Grupa { get; set; }
        public Nullable<decimal> Cena { get; set; }
        public Nullable<int> IdPolozenia { get; set; }
        public Nullable<int> IdPromocji { get; set; }
        public Nullable<bool> CzyNaPromocji { get; set; }
        public Nullable<int> IdZdjecia { get; set; }
    
        public virtual Miejsce Miejsce { get; set; }
        public virtual Promocja Promocja { get; set; }
        public virtual Zdjecie Zdjecie { get; set; }
    }
}
