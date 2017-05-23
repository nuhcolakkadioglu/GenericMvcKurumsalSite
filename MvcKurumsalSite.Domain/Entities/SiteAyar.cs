namespace MvcKurumsalSite.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SiteAyar")]
    public partial class SiteAyar
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string SiteAdi { get; set; }

        [StringLength(250)]
        public string Adres { get; set; }

        [StringLength(50)]
        public string Telefon { get; set; }

        [StringLength(350)]
        public string SiteLogo { get; set; }
    }
}
