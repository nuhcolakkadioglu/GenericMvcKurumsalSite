namespace MvcKurumsalSite.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mesaj")]
    public partial class Mesaj
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Ad { get; set; }

        [StringLength(50)]
        public string Konu { get; set; }

        [Required]
        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Telefon { get; set; }

        [StringLength(150)]
        public string FirmaAdi { get; set; }

        [Required]
        [StringLength(500)]
        public string Mesaj1 { get; set; }
    }
}
