namespace WpfEFKutyak
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KutyaModel : DbContext
    {
        public KutyaModel()
            : base("name=KutyaModel")
        {
        }

        public virtual DbSet<KutyaFajtak> KutyaFajtak { get; set; }
        public virtual DbSet<Kutyak> Kutyak { get; set; }
        public virtual DbSet<KutyaNevek> KutyaNevek { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KutyaFajtak>()
                .HasMany(e => e.Kutyak)
                .WithRequired(e => e.KutyaFajtak)
                .HasForeignKey(e => e.fajtaid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KutyaNevek>()
                .HasMany(e => e.Kutyak)
                .WithRequired(e => e.KutyaNevek)
                .HasForeignKey(e => e.nevid)
                .WillCascadeOnDelete(false);
        }
    }
}
