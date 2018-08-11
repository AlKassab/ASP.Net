namespace Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<announcement> announcement { get; set; }
        public virtual DbSet<application> application { get; set; }
        public virtual DbSet<article> article { get; set; }
        public virtual DbSet<collection> collection { get; set; }
        public virtual DbSet<_event> _event { get; set; }
        public virtual DbSet<follow> follow { get; set; }
        public virtual DbSet<institute> institute { get; set; }
        public virtual DbSet<journal> journal { get; set; }
        public virtual DbSet<ticketevent> ticketevent { get; set; }
        public virtual DbSet<user> user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<announcement>()
                .HasMany(e => e.application)
                .WithOptional(e => e.announcement)
                .HasForeignKey(e => e.annoucement_id_An);

            modelBuilder.Entity<application>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<article>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<collection>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<collection>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<collection>()
                .HasMany(e => e.journal)
                .WithOptional(e => e.collection)
                .HasForeignKey(e => e.collection_id_Col);

            modelBuilder.Entity<_event>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<_event>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<_event>()
                .HasMany(e => e.ticketevent)
                .WithOptional(e => e._event)
                .HasForeignKey(e => e.event_id_Ev);

            modelBuilder.Entity<institute>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<institute>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<institute>()
                .Property(e => e.latitude)
               ;
            modelBuilder.Entity<institute>()
                .Property(e => e.name);

            modelBuilder.Entity<institute>()
                .Property(e => e.type)
                ;

            modelBuilder.Entity<journal>()
                .Property(e => e.description)
                ;

            modelBuilder.Entity<journal>()
                .Property(e => e.filePath)
              ;

            modelBuilder.Entity<journal>()
                .HasMany(e => e.article)
                .WithOptional(e => e.journal)
                .HasForeignKey(e => e.journal_id_Journal);

            modelBuilder.Entity<ticketevent>()
                .Property(e => e.note)
                ;

            modelBuilder.Entity<ticketevent>()
                .Property(e => e.title)
                ;

            modelBuilder.Entity<user>()
                .Property(e => e.role)
              ;

            modelBuilder.Entity<user>()
                .Property(e => e.address)
               ;

            modelBuilder.Entity<user>()
                .Property(e => e.confirmPassword)
               ;

            modelBuilder.Entity<user>()
                .Property(e => e.country)
                ;

            modelBuilder.Entity<user>()
                .Property(e => e.email)
               ;

            modelBuilder.Entity<user>()
                .Property(e => e.firstName)
                ;

            modelBuilder.Entity<user>()
                .Property(e => e.gender)
                ;

            modelBuilder.Entity<user>()
                .Property(e => e.imagePath)
              ;

            modelBuilder.Entity<user>()
                .Property(e => e.lastName)
                ;

            modelBuilder.Entity<user>()
                .Property(e => e.password)
               ;

            modelBuilder.Entity<user>()
                .Property(e => e.username)
                ;

            modelBuilder.Entity<user>()
                .HasMany(e => e.announcement)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.application)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e._event)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.follow)
                .WithRequired(e => e.user)
                .HasForeignKey(e => e.userId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.follow1)
                .WithRequired(e => e.user1)
                .HasForeignKey(e => e.researcherId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.ticketevent)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.user_id);
        }
    }
}
