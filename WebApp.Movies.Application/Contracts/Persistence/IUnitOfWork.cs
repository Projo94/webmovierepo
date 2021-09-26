using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Threading.Tasks;

namespace WebApp.Movies.Application.Contracts.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        ITVProgramRatingRepository TVProgramRatingRepository { get; }

        ITVProgramRepository TVProgramRepository { get; }

        IRatingRepository RatingRepository { get; }

        int SaveChanges();
        Task<int> SaveChangesAsync();
        IDbContextTransaction BeginTransaction();
        Task<IDbContextTransaction> BeginTransactionAsync();
    }
}
