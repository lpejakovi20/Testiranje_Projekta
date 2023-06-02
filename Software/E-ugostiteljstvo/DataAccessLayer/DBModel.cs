using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using EntitiesLayer.Entities;

namespace DataAccessLayer
{
    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=DBModel")
        {
        }

        public virtual DbSet<iskoristenost_namirnice> iskoristenost_namirnice { get; set; }
        public virtual DbSet<namirnica> namirnica { get; set; }
        public virtual DbSet<namirnica_narudzbenica> namirnica_narudzbenica { get; set; }
        public virtual DbSet<namirnica_u_katalogu> namirnica_u_katalogu { get; set; }
        public virtual DbSet<narudzbenica> narudzbenica { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<uloga> uloga { get; set; }
        public virtual DbSet<zaposlenik> zaposlenik { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<namirnica>()
                .Property(e => e.rok);
                

            modelBuilder.Entity<namirnica_u_katalogu>()
                .Property(e => e.cijena)
                .HasPrecision(19, 2);

            modelBuilder.Entity<namirnica_u_katalogu>()
                .HasMany(e => e.iskoristenost_namirnice)
                .WithRequired(e => e.namirnica_u_katalogu)
                .HasForeignKey(e => e.namirnica_u_katalogu_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<namirnica_u_katalogu>()
                .HasMany(e => e.namirnica)
                .WithRequired(e => e.namirnica_u_katalogu)
                .HasForeignKey(e => e.namirnica_u_katalogu_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<namirnica_u_katalogu>()
                .HasMany(e => e.namirnica_narudzbenica)
                .WithRequired(e => e.namirnica_u_katalogu)
                .HasForeignKey(e => e.namirnica_u_katalogu_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<narudzbenica>()
            .Property(e => e.datum_kreiranja);


            modelBuilder.Entity<narudzbenica>()
                .Property(e => e.sveukupan_iznos)
                .HasPrecision(19, 2);

            modelBuilder.Entity<narudzbenica>()
                .HasMany(e => e.namirnica_narudzbenica)
                .WithRequired(e => e.narudzbenica)
                .HasForeignKey(e => e.narudzbenica_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<uloga>()
                .HasMany(e => e.zaposlenik)
                .WithRequired(e => e.uloga)
                .HasForeignKey(e => e.uloga_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<zaposlenik>()
                .HasMany(e => e.namirnica_u_katalogu)
                .WithOptional(e => e.zaposlenik)
                .HasForeignKey(e => e.zaposlenik_id);

            modelBuilder.Entity<zaposlenik>()
                .HasMany(e => e.narudzbenica)
                .WithOptional(e => e.zaposlenik)
                .HasForeignKey(e => e.zaposlenik_id);
        }
    }
}