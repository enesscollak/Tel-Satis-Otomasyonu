//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tel_satis_otomasyonu_v1
{
    using System;
    using System.Collections.Generic;
    
    public partial class satislar_musteri_fatura
    {
        public int musteriID { get; set; }
        public string musteriAd { get; set; }
        public string musteriSoyad { get; set; }
        public string musteriTel { get; set; }
        public int faturaID { get; set; }
        public Nullable<System.DateTime> faturaTarih { get; set; }
        public Nullable<int> faturaTutari { get; set; }
    }
}