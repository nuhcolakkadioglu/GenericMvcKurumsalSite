namespace MvcKurumsalSite.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Galeri")]
    public partial class Galeri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Galeri()
        {
            GaleriResim = new HashSet<GaleriResim>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string GaleriAdi { get; set; }

        [StringLength(650)]
        public string GaleriResmi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GaleriResim> GaleriResim { get; set; }
    }
}
