namespace MvcKurumsalSite.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sayfa")]
    public partial class Sayfa
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string SayfaAdi { get; set; }

        [Column(TypeName = "text")]
        public string SayfaIcerik { get; set; }

        public bool Aktif { get; set; }

    }
}
