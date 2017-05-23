namespace MvcKurumsalSite.Domain.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SiteContext : DbContext
    {
        public SiteContext()
            : base("name=SiteContext")
        {
        }

        public virtual DbSet<Galeri> Galeri { get; set; }
        public virtual DbSet<GaleriResim> GaleriResim { get; set; }
        public virtual DbSet<Mesaj> Mesaj { get; set; }
        public virtual DbSet<Sayfa> Sayfa { get; set; }
        public virtual DbSet<SiteAyar> SiteAyar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Galeri>()
                .HasMany(e => e.GaleriResim)
                .WithRequired(e => e.Galeri)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sayfa>()
                .Property(e => e.SayfaIcerik)
                .IsUnicode(false);
        }
    }
}
