using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataModel
{
    public partial class PartnersContext : DbContext
    {
        public PartnersContext()
        {
        }

        public PartnersContext(DbContextOptions<PartnersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<ContactsPartners> ContactsPartners { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<EngagementOfOwn> EngagementOfOwn { get; set; }
        public virtual DbSet<EngagementOfPartner> EngagementOfPartner { get; set; }
        public virtual DbSet<FavoriteResource> FavoriteResource { get; set; }
        public virtual DbSet<NonSolicitationType> NonSolicitationType { get; set; }
        public virtual DbSet<Partner> Partner { get; set; }
        public virtual DbSet<PartnerDocument> PartnerDocument { get; set; }
        public virtual DbSet<PartnerRating> PartnerRating { get; set; }
        public virtual DbSet<PartnersContacts> PartnersContacts { get; set; }
        public virtual DbSet<PaymentWay> PaymentWay { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<RequestResource> RequestResource { get; set; }
        public virtual DbSet<Resource> Resource { get; set; }
        public virtual DbSet<ResourceAvailability> ResourceAvailability { get; set; }
        public virtual DbSet<ResourceDocument> ResourceDocument { get; set; }
        public virtual DbSet<ResourceFeedback> ResourceFeedback { get; set; }
        public virtual DbSet<ResourceLevel> ResourceLevel { get; set; }
        public virtual DbSet<ResourceRates> ResourceRates { get; set; }
        public virtual DbSet<ResourceWithRate> ResourceWithRate { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserAccess> UserAccess { get; set; }
        public virtual DbSet<UserSession> UserSession { get; set; }
        public virtual DbSet<WayOfCommunication> WayOfCommunication { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS01;Database=Partners;Trusted_Connection=True;MultipleActiveResultsets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("M, F, U");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Position).HasMaxLength(50);

                entity.Property(e => e.Skype).HasMaxLength(50);

                entity.Property(e => e.Telegram).HasMaxLength(50);

                /*entity.HasOne(d => d.Partner)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.PartnerId)
                    .HasConstraintName("FK_Contacts_Partners");*/

                entity.HasOne(d => d.PreferredWayOfCommunicationNavigation)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.PreferredWayOfCommunication)
                    .HasConstraintName("FK_Contacts_WaysOfCommunication");
            });

            modelBuilder.Entity<ContactsPartners>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ContactsPartners");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Position).HasMaxLength(50);

                entity.Property(e => e.Skype).HasMaxLength(50);
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ContentData).IsRequired();

                entity.Property(e => e.ContentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileDate).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EngagementOfOwn>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_EngagementsOfOwn");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateFinish).HasColumnType("date");

                entity.Property(e => e.DateStart).HasColumnType("date");

                entity.Property(e => e.ProjectCode).HasMaxLength(50);

                entity.Property(e => e.ProjectJira).HasMaxLength(50);

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.EngagementOfOwn)
                    .HasForeignKey(d => d.PartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EngagementsOfOwn_Partners");

                /*entity.HasOne(d => d.PartnerManager)
                    .WithMany(p => p.EngagementOfOwn)
                    .HasForeignKey(d => d.PartnerManagerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EngagementsOfOwn_Contacts");*/

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.EngagementOfOwn)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_EngagementsOfOwn_PaymentWays");

                entity.HasOne(d => d.ResourceWithRate)
                    .WithMany(p => p.EngagementOfOwn)
                    .HasForeignKey(d => d.ResourceWithRateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EngagementsOfOwn_ResourceWithRates");
            });

            modelBuilder.Entity<EngagementOfPartner>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AccountManagerId).HasMaxLength(50);

                entity.Property(e => e.DateFinish).HasColumnType("date");

                entity.Property(e => e.DateStart).HasColumnType("date");

                entity.Property(e => e.ProjectCode).HasMaxLength(50);

                entity.Property(e => e.ProjectJira)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectManagerId).HasMaxLength(50);

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.EngagementOfPartner)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_EngagementsOfPartners_PaymentWays");

                entity.HasOne(d => d.ResourceWithRate)
                    .WithMany(p => p.EngagementOfPartner)
                    .HasForeignKey(d => d.ResourceWithRateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EngagementsOfPartners_ResourceWithRates");
            });

            modelBuilder.Entity<FavoriteResource>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.ResourceId)
                    .HasName("IX_FavoriteResources");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.Resource)
                    .WithMany()
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FavoriteResources_Resources");
            });

            modelBuilder.Entity<NonSolicitationType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Partner>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_Partners");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NdaDate).HasColumnType("date");

                entity.HasOne(d => d.NonSolicitationNavigation)
                    .WithMany(p => p.Partner)
                    .HasForeignKey(d => d.NonSolicitation)
                    .HasConstraintName("FK_Partners_NonSolicitationTypes");

                entity.HasOne(d => d.RatingNavigation)
                    .WithMany(p => p.Partner)
                    .HasForeignKey(d => d.Rating)
                    .HasConstraintName("FK_Partners_Rating");
            });

            modelBuilder.Entity<PartnerDocument>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.PartnerDocument)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartnerDocuments_Documents");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.PartnerDocument)
                    .HasForeignKey(d => d.PartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartnerDocuments_Partners");
            });

            modelBuilder.Entity<PartnerRating>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PartnersContacts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PartnersContacts");

                entity.Property(e => e.Expr2).HasMaxLength(50);

                entity.Property(e => e.Expr3).HasMaxLength(50);

                entity.Property(e => e.Expr5).HasMaxLength(50);

                entity.Property(e => e.Expr6).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ndadate)
                    .HasColumnName("NDADate")
                    .HasColumnType("date");

                entity.Property(e => e.NdanonSolicitation).HasColumnName("NDANonSolicitation");

                entity.Property(e => e.NdanonSolicitationExtended).HasColumnName("NDANonSolicitationExtended");

                entity.Property(e => e.Ndayears).HasColumnName("NDAYears");

                entity.Property(e => e.Position).HasMaxLength(50);
            });

            modelBuilder.Entity<PaymentWay>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ApproximateDuration).HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.IssuedDate).HasColumnType("date");

                entity.Property(e => e.IssuerAccountId).HasMaxLength(50);

                entity.Property(e => e.LinkCollab).IsUnicode(false);

                entity.Property(e => e.LinkJira).IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.IssuerPartner)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.IssuerPartnerId)
                    .HasConstraintName("FK_Requests_Partners");

                entity.HasOne(d => d.ResourceLevelNavigation)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.ResourceLevel)
                    .HasConstraintName("FK_Requests_ResourceLevels");
            });

            modelBuilder.Entity<RequestResource>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.RequestResource)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestResources_Requests");

                entity.HasOne(d => d.ResourceWithRate)
                    .WithMany(p => p.RequestResource)
                    .HasForeignKey(d => d.ResourceWithRateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestResources_Resources");

                entity.HasOne(d => d.ResourceWithRateNavigation)
                    .WithMany(p => p.RequestResource)
                    .HasForeignKey(d => d.ResourceWithRateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestResources_ResourceWithRates");
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.CvtoolLinkMaster).HasColumnName("CVToolLinkMaster");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.LevelDeclaredNavigation)
                    .WithMany(p => p.Resource)
                    .HasForeignKey(d => d.LevelDeclared)
                    .HasConstraintName("FK_Resources_LevelDeclared");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.Resource)
                    .HasForeignKey(d => d.PartnerId)
                    .HasConstraintName("FK_Resources_Partners");
            });

            modelBuilder.Entity<ResourceAvailability>(entity =>
            {
                entity.HasIndex(e => e.AvailableFrom)
                    .HasName("IX_ResourceAvailability");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AvailableFrom).HasColumnType("date");

                entity.Property(e => e.AvailableTill).HasColumnType("date");

                entity.Property(e => e.Notes)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.VacationFrom).HasColumnType("date");

                entity.Property(e => e.VacationTill).HasColumnType("date");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.ResourceAvailability)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceAvailability_Resources");
            });

            modelBuilder.Entity<ResourceDocument>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.ResourceDocument)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceDocuments_Documents");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.ResourceDocument)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceDocuments_Resources");
            });

            modelBuilder.Entity<ResourceFeedback>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ScnSoftAccountId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.LevelIdentifiedNavigation)
                    .WithMany(p => p.ResourceFeedback)
                    .HasForeignKey(d => d.LevelIdentified)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceFeedbacks_ResourceLevels");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.ResourceFeedback)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceFeedbacks_Resources");
            });

            modelBuilder.Entity<ResourceLevel>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ResourceRates>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ResourceRates");

                entity.Property(e => e.Currency)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DateStart).HasColumnType("date");

                entity.Property(e => e.DateTill).HasColumnType("date");

                entity.Property(e => e.RateIn).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RateOut).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<ResourceWithRate>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Currency)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CvtoolLinkSnapshot).HasColumnName("CVToolLinkSnapshot");

                entity.Property(e => e.DateStart).HasColumnType("date");

                entity.Property(e => e.DateTill).HasColumnType("date");

                entity.Property(e => e.RateIn).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RateOut).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ScnSoftResourceAccountId).HasMaxLength(50);

                entity.HasOne(d => d.PartnerResource)
                    .WithMany(p => p.ResourceWithRate)
                    .HasForeignKey(d => d.PartnerResourceId)
                    .HasConstraintName("FK_ResourceWithRates_Resources");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.PersonalAppeal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserAccess>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.UserOrGroupId)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserSession>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Date)
                    .HasName("IX_UserSession_1");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserSession");

                entity.Property(e => e.Url).IsRequired();

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WayOfCommunication>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
