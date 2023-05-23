using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AracIhaleProje.Api.Models
{
    public partial class AracİhaleDBContextContext : DbContext
    {
        public AracİhaleDBContextContext()
        {
        }

        public AracİhaleDBContextContext(DbContextOptions<AracİhaleDBContextContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminUser> AdminUsers { get; set; }
        public virtual DbSet<AlmaSurecStatu> AlmaSurecStatus { get; set; }
        public virtual DbSet<Arac> Aracs { get; set; }
        public virtual DbSet<BireyselArac> BireyselAracs { get; set; }
        public virtual DbSet<BireyselUser> BireyselUsers { get; set; }
        public virtual DbSet<DonanimBilgisi> DonanimBilgisis { get; set; }
        public virtual DbSet<GovdeTipi> GovdeTipis { get; set; }
        public virtual DbSet<Ihale> Ihales { get; set; }
        public virtual DbSet<IhaleArac> IhaleAracs { get; set; }
        public virtual DbSet<IhaleStatu> IhaleStatus { get; set; }
        public virtual DbSet<IhaledeAraclar> IhaledeAraclars { get; set; }
        public virtual DbSet<KurumsalArac> KurumsalAracs { get; set; }
        public virtual DbSet<KurumsalUser> KurumsalUsers { get; set; }
        public virtual DbSet<Marka> Markas { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<ParcaDurumu> ParcaDurumus { get; set; }
        public virtual DbSet<Renk> Renks { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<SatmaSurecStatu> SatmaSurecStatus { get; set; }
        public virtual DbSet<Teklif> Teklifs { get; set; }
        public virtual DbSet<Tramer> Tramers { get; set; }
        public virtual DbSet<Versiyon> Versiyons { get; set; }
        public virtual DbSet<VitesTipi> VitesTipis { get; set; }
        public virtual DbSet<YakitTipi> YakitTipis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=AracİhaleDBContext;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<AdminUser>(entity =>
            {
                entity.ToTable("AdminUser");

                entity.HasIndex(e => e.RolId, "IX_RolID");

                entity.Property(e => e.AdminUserId).HasColumnName("AdminUserID");

                entity.Property(e => e.RolId).HasColumnName("RolID");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.AdminUsers)
                    .HasForeignKey(d => d.RolId)
                    .HasConstraintName("FK_dbo.AdminUser_dbo.Rol_RolID");
            });

            modelBuilder.Entity<AlmaSurecStatu>(entity =>
            {
                entity.ToTable("AlmaSurecStatu");

                entity.Property(e => e.AlmaSurecStatuId).HasColumnName("AlmaSurecStatuID");
            });

            modelBuilder.Entity<Arac>(entity =>
            {
                entity.ToTable("Arac");

                entity.HasIndex(e => e.AlmaSurecStatuId, "IX_AlmaSurecStatuID");

                entity.HasIndex(e => e.DonanimId, "IX_DonanimID");

                entity.HasIndex(e => e.GovdeTipiId, "IX_GovdeTipiID");

                entity.HasIndex(e => e.MarkaId, "IX_MarkaID");

                entity.HasIndex(e => e.ModelId, "IX_ModelID");

                entity.HasIndex(e => e.RenkId, "IX_RenkID");

                entity.HasIndex(e => e.SatmaSurecStatuId, "IX_SatmaSurecStatuID");

                entity.HasIndex(e => e.TramerId, "IX_TramerID");

                entity.HasIndex(e => e.VersiyonId, "IX_VersiyonID");

                entity.HasIndex(e => e.VitesTipiId, "IX_VitesTipiID");

                entity.HasIndex(e => e.YakitTipiId, "IX_YakitTipiID");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.AlmaSurecStatuId).HasColumnName("AlmaSurecStatuID");

                entity.Property(e => e.DonanimId).HasColumnName("DonanimID");

                entity.Property(e => e.GovdeTipiId).HasColumnName("GovdeTipiID");

                entity.Property(e => e.MarkaId).HasColumnName("MarkaID");

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.RenkId).HasColumnName("RenkID");

                entity.Property(e => e.SatmaSurecStatuId).HasColumnName("SatmaSurecStatuID");

                entity.Property(e => e.TramerId).HasColumnName("TramerID");

                entity.Property(e => e.VersiyonId).HasColumnName("VersiyonID");

                entity.Property(e => e.VitesTipiId).HasColumnName("VitesTipiID");

                entity.Property(e => e.YakitTipiId).HasColumnName("YakitTipiID");

                entity.HasOne(d => d.AlmaSurecStatu)
                    .WithMany(p => p.Aracs)
                    .HasForeignKey(d => d.AlmaSurecStatuId)
                    .HasConstraintName("FK_dbo.Arac_dbo.AlmaSurecStatu_AlmaSurecStatuID");

                entity.HasOne(d => d.Donanim)
                    .WithMany(p => p.Aracs)
                    .HasForeignKey(d => d.DonanimId)
                    .HasConstraintName("FK_dbo.Arac_dbo.DonanimBilgisi_DonanimID");

                entity.HasOne(d => d.GovdeTipi)
                    .WithMany(p => p.Aracs)
                    .HasForeignKey(d => d.GovdeTipiId)
                    .HasConstraintName("FK_dbo.Arac_dbo.GovdeTipi_GovdeTipiID");

                entity.HasOne(d => d.Marka)
                    .WithMany(p => p.Aracs)
                    .HasForeignKey(d => d.MarkaId)
                    .HasConstraintName("FK_dbo.Arac_dbo.Marka_MarkaID");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.Aracs)
                    .HasForeignKey(d => d.ModelId)
                    .HasConstraintName("FK_dbo.Arac_dbo.Model_ModelID");

                entity.HasOne(d => d.Renk)
                    .WithMany(p => p.Aracs)
                    .HasForeignKey(d => d.RenkId)
                    .HasConstraintName("FK_dbo.Arac_dbo.Renk_RenkID");

                entity.HasOne(d => d.SatmaSurecStatu)
                    .WithMany(p => p.Aracs)
                    .HasForeignKey(d => d.SatmaSurecStatuId)
                    .HasConstraintName("FK_dbo.Arac_dbo.SatmaSurecStatu_SatmaSurecStatuID");

                entity.HasOne(d => d.Tramer)
                    .WithMany(p => p.Aracs)
                    .HasForeignKey(d => d.TramerId)
                    .HasConstraintName("FK_dbo.Arac_dbo.Tramer_TramerID");

                entity.HasOne(d => d.Versiyon)
                    .WithMany(p => p.Aracs)
                    .HasForeignKey(d => d.VersiyonId)
                    .HasConstraintName("FK_dbo.Arac_dbo.Versiyon_VersiyonID");

                entity.HasOne(d => d.VitesTipi)
                    .WithMany(p => p.Aracs)
                    .HasForeignKey(d => d.VitesTipiId)
                    .HasConstraintName("FK_dbo.Arac_dbo.VitesTipi_VitesTipiID");

                entity.HasOne(d => d.YakitTipi)
                    .WithMany(p => p.Aracs)
                    .HasForeignKey(d => d.YakitTipiId)
                    .HasConstraintName("FK_dbo.Arac_dbo.YakitTipi_YakitTipiID");
            });

            modelBuilder.Entity<BireyselArac>(entity =>
            {
                entity.ToTable("BireyselArac");

                entity.HasIndex(e => e.AracId, "IX_AracID");

                entity.HasIndex(e => e.BireyselUserId, "IX_BireyselUserID");

                entity.Property(e => e.BireyselAracId).HasColumnName("BireyselAracID");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.BireyselUserId).HasColumnName("BireyselUserID");

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.BireyselAracs)
                    .HasForeignKey(d => d.AracId)
                    .HasConstraintName("FK_dbo.BireyselArac_dbo.Arac_AracID");

                entity.HasOne(d => d.BireyselUser)
                    .WithMany(p => p.BireyselAracs)
                    .HasForeignKey(d => d.BireyselUserId)
                    .HasConstraintName("FK_dbo.BireyselArac_dbo.BireyselUser_BireyselUserID");
            });

            modelBuilder.Entity<BireyselUser>(entity =>
            {
                entity.ToTable("BireyselUser");

                entity.HasIndex(e => e.RolId, "IX_RolID");

                entity.Property(e => e.BireyselUserId).HasColumnName("BireyselUserID");

                entity.Property(e => e.RolId).HasColumnName("RolID");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.BireyselUsers)
                    .HasForeignKey(d => d.RolId)
                    .HasConstraintName("FK_dbo.BireyselUser_dbo.Rol_RolID");
            });

            modelBuilder.Entity<DonanimBilgisi>(entity =>
            {
                entity.ToTable("DonanimBilgisi");

                entity.Property(e => e.DonanimBilgisiId).HasColumnName("DonanimBilgisiID");
            });

            modelBuilder.Entity<GovdeTipi>(entity =>
            {
                entity.ToTable("GovdeTipi");

                entity.Property(e => e.GovdeTipiId).HasColumnName("GovdeTipiID");
            });

            modelBuilder.Entity<Ihale>(entity =>
            {
                entity.ToTable("Ihale");

                entity.Property(e => e.IhaleId).HasColumnName("IhaleID");

                entity.Property(e => e.BaslangicTarih).HasColumnType("datetime");

                entity.Property(e => e.BitisTarih).HasColumnType("datetime");

                entity.Property(e => e.IhaleAdi)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SirketId).HasColumnName("SirketID");

                entity.HasOne(d => d.Sirket)
                    .WithMany(p => p.Ihales)
                    .HasForeignKey(d => d.SirketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ihale_KurumsalUser");

                entity.HasOne(d => d.StatüNavigation)
                    .WithMany(p => p.Ihales)
                    .HasForeignKey(d => d.Statü)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ihale_IhaleStatu");
            });

            modelBuilder.Entity<IhaleArac>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IhaleArac");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.BaslangicFiyat).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IhaleAracId).HasColumnName("IhaleAracID");

                entity.Property(e => e.IhaleId).HasColumnName("IhaleID");

                entity.Property(e => e.MinAlimFiyat).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Arac)
                    .WithMany()
                    .HasForeignKey(d => d.AracId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IhaleArac_Arac");

                entity.HasOne(d => d.Ihale)
                    .WithMany()
                    .HasForeignKey(d => d.IhaleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IhaleArac_Ihale");
            });

            modelBuilder.Entity<IhaleStatu>(entity =>
            {
                entity.HasKey(e => e.StatuId);

                entity.ToTable("IhaleStatu");

                entity.Property(e => e.StatuId).HasColumnName("StatuID");

                entity.Property(e => e.StatuAdi)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<IhaledeAraclar>(entity =>
            {
                entity.HasKey(e => e.IhaleAracId);

                entity.ToTable("IhaledeAraclar");

                entity.Property(e => e.IhaleAracId).HasColumnName("IhaleAracID");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.IhaleId).HasColumnName("IhaleID");

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.IhaledeAraclars)
                    .HasForeignKey(d => d.AracId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IhaledeAraclar_Arac");

                entity.HasOne(d => d.Ihale)
                    .WithMany(p => p.IhaledeAraclars)
                    .HasForeignKey(d => d.IhaleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IhaledeAraclar_Ihale");
            });

            modelBuilder.Entity<KurumsalArac>(entity =>
            {
                entity.ToTable("KurumsalArac");

                entity.HasIndex(e => e.AracId, "IX_AracID");

                entity.HasIndex(e => e.KurumsalUserId, "IX_KurumsalUserID");

                entity.Property(e => e.KurumsalAracId).HasColumnName("KurumsalAracID");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.KurumsalUserId).HasColumnName("KurumsalUserID");

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.KurumsalAracs)
                    .HasForeignKey(d => d.AracId)
                    .HasConstraintName("FK_dbo.KurumsalArac_dbo.Arac_AracID");

                entity.HasOne(d => d.KurumsalUser)
                    .WithMany(p => p.KurumsalAracs)
                    .HasForeignKey(d => d.KurumsalUserId)
                    .HasConstraintName("FK_dbo.KurumsalArac_dbo.KurumsalUser_KurumsalAracID");
            });

            modelBuilder.Entity<KurumsalUser>(entity =>
            {
                entity.ToTable("KurumsalUser");

                entity.HasIndex(e => e.RolId, "IX_RolID");

                entity.Property(e => e.KurumsalUserId).HasColumnName("KurumsalUserID");

                entity.Property(e => e.RolId).HasColumnName("RolID");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.KurumsalUsers)
                    .HasForeignKey(d => d.RolId)
                    .HasConstraintName("FK_dbo.KurumsalUser_dbo.Rol_RolID");
            });

            modelBuilder.Entity<Marka>(entity =>
            {
                entity.ToTable("Marka");

                entity.Property(e => e.MarkaId).HasColumnName("MarkaID");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Model>(entity =>
            {
                entity.ToTable("Model");

                entity.HasIndex(e => e.MarkaId, "IX_MarkaID");

                entity.HasIndex(e => e.VersiyonId, "IX_VersiyonID");

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.MarkaId).HasColumnName("MarkaID");

                entity.Property(e => e.VersiyonId).HasColumnName("VersiyonID");

                entity.HasOne(d => d.Marka)
                    .WithMany(p => p.Models)
                    .HasForeignKey(d => d.MarkaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Model_dbo.Marka_MarkaID");

                entity.HasOne(d => d.Versiyon)
                    .WithMany(p => p.Models)
                    .HasForeignKey(d => d.VersiyonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Model_dbo.Versiyon_VersiyonID");
            });

            modelBuilder.Entity<ParcaDurumu>(entity =>
            {
                entity.ToTable("ParcaDurumu");

                entity.Property(e => e.ParcaDurumuId).HasColumnName("ParcaDurumuID");
            });

            modelBuilder.Entity<Renk>(entity =>
            {
                entity.ToTable("Renk");

                entity.Property(e => e.RenkId).HasColumnName("RenkID");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.ToTable("Rol");

                entity.Property(e => e.RolId).HasColumnName("RolID");
            });

            modelBuilder.Entity<SatmaSurecStatu>(entity =>
            {
                entity.ToTable("SatmaSurecStatu");

                entity.Property(e => e.SatmaSurecStatuId).HasColumnName("SatmaSurecStatuID");
            });

            modelBuilder.Entity<Teklif>(entity =>
            {
                entity.ToTable("Teklif");

                entity.Property(e => e.TeklifId).HasColumnName("TeklifID");

                entity.Property(e => e.EnYuksekTeklif).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IhaleId).HasColumnName("IhaleID");

                entity.Property(e => e.MinTeklif).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Ihale)
                    .WithMany(p => p.Teklifs)
                    .HasForeignKey(d => d.IhaleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Teklif_Ihale");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Teklifs)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Teklif_BireyselUser");

                entity.HasOne(d => d.UserNavigation)
                    .WithMany(p => p.Teklifs)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Teklif_KurumsalUser");
            });

            modelBuilder.Entity<Tramer>(entity =>
            {
                entity.ToTable("Tramer");

                entity.HasIndex(e => e.SolArkaKapiId, "IX_SolArkaKapiID");

                entity.Property(e => e.TramerId).HasColumnName("TramerID");

                entity.Property(e => e.ArkaTamponId).HasColumnName("ArkaTamponID");

                entity.Property(e => e.ArkakaputId).HasColumnName("ArkakaputID");

                entity.Property(e => e.MotorKaputuId).HasColumnName("MotorKaputuID");

                entity.Property(e => e.OnTamponId).HasColumnName("OnTamponID");

                entity.Property(e => e.SagArkaCamurlukId).HasColumnName("SagArkaCamurlukID");

                entity.Property(e => e.SagArkaKapiId).HasColumnName("SagArkaKapiID");

                entity.Property(e => e.SagOnCamurlukId).HasColumnName("SagOnCamurlukID");

                entity.Property(e => e.SagOnKapiId).HasColumnName("SagOnKapiID");

                entity.Property(e => e.SolArkaCamurlukId).HasColumnName("SolArkaCamurlukID");

                entity.Property(e => e.SolArkaKapiId).HasColumnName("SolArkaKapiID");

                entity.Property(e => e.SolOnCamurlukId).HasColumnName("SolOnCamurlukID");

                entity.Property(e => e.SolOnKapiId).HasColumnName("SolOnKapiID");

                entity.Property(e => e.TavanId).HasColumnName("TavanID");

                entity.Property(e => e.TramerTutar).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.ArkaTampon)
                    .WithMany(p => p.TramerArkaTampons)
                    .HasForeignKey(d => d.ArkaTamponId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tramer_ParcaDurumu24");

                entity.HasOne(d => d.Arkakaput)
                    .WithMany(p => p.TramerArkakaputs)
                    .HasForeignKey(d => d.ArkakaputId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tramer_ParcaDurumu25");

                entity.HasOne(d => d.MotorKaputu)
                    .WithMany(p => p.TramerMotorKaputus)
                    .HasForeignKey(d => d.MotorKaputuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tramer_ParcaDurumu22");

                entity.HasOne(d => d.OnTampon)
                    .WithMany(p => p.TramerOnTampons)
                    .HasForeignKey(d => d.OnTamponId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tramer_ParcaDurumu23");

                entity.HasOne(d => d.SagArkaCamurluk)
                    .WithMany(p => p.TramerSagArkaCamurluks)
                    .HasForeignKey(d => d.SagArkaCamurlukId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tramer_ParcaDurumu13");

                entity.HasOne(d => d.SagArkaKapi)
                    .WithMany(p => p.TramerSagArkaKapis)
                    .HasForeignKey(d => d.SagArkaKapiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tramer_ParcaDurumu15");

                entity.HasOne(d => d.SagOnCamurluk)
                    .WithMany(p => p.TramerSagOnCamurluks)
                    .HasForeignKey(d => d.SagOnCamurlukId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tramer_ParcaDurumu20");

                entity.HasOne(d => d.SagOnKapi)
                    .WithMany(p => p.TramerSagOnKapis)
                    .HasForeignKey(d => d.SagOnKapiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tramer_ParcaDurumu17");

                entity.HasOne(d => d.SolArkaCamurluk)
                    .WithMany(p => p.TramerSolArkaCamurluks)
                    .HasForeignKey(d => d.SolArkaCamurlukId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tramer_ParcaDurumu14");

                entity.HasOne(d => d.SolArkaKapi)
                    .WithMany(p => p.TramerSolArkaKapis)
                    .HasForeignKey(d => d.SolArkaKapiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tramer_ParcaDurumu16");

                entity.HasOne(d => d.SolOnCamurluk)
                    .WithMany(p => p.TramerSolOnCamurluks)
                    .HasForeignKey(d => d.SolOnCamurlukId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tramer_ParcaDurumu21");

                entity.HasOne(d => d.SolOnKapi)
                    .WithMany(p => p.TramerSolOnKapis)
                    .HasForeignKey(d => d.SolOnKapiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tramer_ParcaDurumu18");

                entity.HasOne(d => d.Tavan)
                    .WithMany(p => p.TramerTavans)
                    .HasForeignKey(d => d.TavanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tramer_ParcaDurumu19");
            });

            modelBuilder.Entity<Versiyon>(entity =>
            {
                entity.ToTable("Versiyon");

                entity.Property(e => e.VersiyonId).HasColumnName("VersiyonID");
            });

            modelBuilder.Entity<VitesTipi>(entity =>
            {
                entity.ToTable("VitesTipi");

                entity.Property(e => e.VitesTipiId).HasColumnName("VitesTipiID");
            });

            modelBuilder.Entity<YakitTipi>(entity =>
            {
                entity.ToTable("YakitTipi");

                entity.Property(e => e.YakitTipiId).HasColumnName("YakitTipiID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
