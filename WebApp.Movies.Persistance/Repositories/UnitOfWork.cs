using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Threading.Tasks;
using WebApp.Movies.Application.Contracts.Persistence;

namespace WebApp.Movies.Persistance.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool _disposed;


        private MoviesDbContext _context;

        public ITVProgramRatingRepository tvProgramRatingRepository;

        public ITVProgramRepository tvProgramRepository;


        public IActorRepository actorRepository;

        public IActorTVProgramRepository actorTVProgramRepository;

        public IRatingRepository ratingRepository;


        public UnitOfWork(MoviesDbContext context)
        {
            _context = context;
        }



        public ITVProgramRepository TVProgramRepository
        {
            get
            {
                if (this.tvProgramRepository == null)
                    this.tvProgramRepository = new TVProgramRepository(null, _context);

                return tvProgramRepository;
            }
        }


        public ITVProgramRatingRepository TVProgramRatingRepository
        {
            get
            {
                if (this.tvProgramRatingRepository == null)
                    this.tvProgramRatingRepository = new TVProgramRatingRepository(_context);

                return tvProgramRatingRepository;
            }
        }


        public IActorRepository ActorRepository
        {
            get
            {
                if (this.actorRepository == null)
                    this.actorRepository = new ActorRepository(_context);

                return actorRepository;
            }
        }

        public IActorTVProgramRepository ActorTVProgramRepository
        {
            get
            {
                if (this.actorTVProgramRepository == null)
                    this.actorTVProgramRepository = new ActorTVProgramRepository(_context);

                return actorTVProgramRepository;
            }
        }




        public IRatingRepository RatingRepository
        {
            get
            {
                if (this.ratingRepository == null)
                    this.ratingRepository = new RatingRepository(_context);

                return ratingRepository;
            }
        }


        public IDbContextTransaction BeginTransaction()
        {
            return _context.Database.BeginTransaction();
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await _context.Database.BeginTransactionAsync();
        }


        protected void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }



        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
