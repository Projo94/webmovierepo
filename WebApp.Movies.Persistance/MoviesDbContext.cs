using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;
using WebApp.Movies.Domain.Common;
using WebApp.Movies.Domain.Entities;

namespace WebApp.Movies.Persistance
{
    public class MoviesDbContext : DbContext
    {

        public DbSet<TVProgram> TVPrograms { get; set; }

        public DbSet<TypeOfProgram> TypeOfPrograms { get; set; }

        public DbSet<Rating> Ratings { get; set; }

        public DbSet<TVProgramRating> TVProgramRatings { get; set; }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<ActorTVProgram> ActorTVPrograms { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MoviesDbContext).Assembly); // it will search all configurations in an assembly and apply them


            modelBuilder.Entity<TVProgramRating>()
               .HasKey(c => new { c.ID });



            modelBuilder.Entity<TVProgramRating>()
            .HasOne(c => c.TVProgram)
            .WithMany(p => p.TVProgramRating)
            .HasForeignKey(c => c.IDTVProgram);


            modelBuilder.Entity<TVProgramRating>()
            .HasOne(c => c.Rating)
            .WithMany(p => p.TVProgramRating)
            .HasForeignKey(c => c.IDRating);



            modelBuilder.Entity<TVProgram>()
            .Property(p => p.IDTVProgram)
            .HasDefaultValueSql("NEWID()");



            modelBuilder.Entity<ActorTVProgram>()
                .HasKey(c => new { c.IDTVProgram, c.IDActor });



            modelBuilder.Entity<ActorTVProgram>()
            .HasOne(c => c.TVProgram)
            .WithMany(p => p.ActorTVProgram)
            .HasForeignKey(c => c.IDTVProgram);


            modelBuilder.Entity<ActorTVProgram>()
            .HasOne(c => c.Actor)
            .WithMany(p => p.ActorTVProgram)
            .HasForeignKey(c => c.IDActor);



            modelBuilder.Entity<TypeOfProgram>()
          .HasData(
         new TypeOfProgram()
         {
             IDTypeOfProgram = 1,
             Caption = "TV Show"
         },
         new TypeOfProgram()
         {
             IDTypeOfProgram = 2,
             Caption = "Movie"
         }
         );







            modelBuilder.Entity<Rating>()
            .HasData(
            new Rating()
            {
                IDRating = 1,
                NumberOfStars = 1
            },
             new Rating()
             {
                 IDRating = 2,
                 NumberOfStars = 2
             },
             new Rating()
             {
                 IDRating = 3,
                 NumberOfStars = 3
             },
               new Rating()
               {
                   IDRating = 4,
                   NumberOfStars = 4
               },
            new Rating()
            {
                IDRating = 5,
                NumberOfStars = 5
            }

            );








        }





        public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options)
        {


            //Database.EnsureCreated();

        }



        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        break;
                }

            }
            return base.SaveChangesAsync(cancellationToken);


        }




    }
}
