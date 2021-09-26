using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApp.Movies.Application.Contracts.Persistence;
using WebApp.Movies.Domain.Entities;

namespace WebApp.Movies.Persistance.Repositories
{
    public class ActorTVProgramRepository : BaseRepository<ActorTVProgram>, IActorTVProgramRepository
    {
        public ActorTVProgramRepository(MoviesDbContext dbContext) : base(dbContext)
        {

        }

        //public List<ProductSizeType> GetProductSizeTypes(Guid productId)
        //{
        //    return _dbContext.ProductsSizeTypes.FromSqlRaw("Select * From ProductsSizeTypes Where ProductID = {0}", productId).ToList();
        //}
    }
}
