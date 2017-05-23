namespace MvcKurumsalSite.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GaleriResim")]
    public partial class GaleriResim
    {
        public int Id { get; set; }

        public int GaleriId { get; set; }

        [Required]
        [StringLength(550)]
        public string ResimUrl { get; set; }

        public virtual Galeri Galeri { get; set; }
    }
}
