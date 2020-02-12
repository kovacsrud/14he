namespace WpfKutyak2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Kutyacontext : DbContext
    {
        public Kutyacontext()
            : base("name=Kutyacontext")
        {
        }

        public virtual DbSet<Kutyafajtak> Kutyafajtak { get; set; }
        public virtual DbSet<Kutyak> Kutyak { get; set; }
        public virtual DbSet<Kutyanevek> Kutyanevek { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kutyafajtak>()
                .HasMany(e => e.Kutyak)
                .WithRequired(e => e.Kutyafajtak)
                .HasForeignKey(e => e.fajtaid)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Kutyak>()
            //    .HasOptional(e => e.Kutyak1)
            //    .WithRequired(e => e.Kutyak2);

            modelBuilder.Entity<Kutyanevek>()
                .HasMany(e => e.Kutyak)
                .WithRequired(e => e.Kutyanevek)
                .HasForeignKey(e => e.nevid)
                .WillCascadeOnDelete(false);
        }
    }
}
