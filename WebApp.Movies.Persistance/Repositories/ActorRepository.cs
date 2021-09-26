using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApp.Movies.Application.Contracts.Persistence;
using WebApp.Movies.Domain.Entities;

namespace WebApp.Movies.Persistance.Repositories
{
    public class RatingRepository : BaseRepository<Rating>, IRatingRepository
    {
        public RatingRepository(MoviesDbContext dbContext) : base(dbContext)
        {

        }


    }
}
