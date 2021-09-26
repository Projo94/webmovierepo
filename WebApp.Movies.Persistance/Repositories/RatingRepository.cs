using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApp.Movies.Application.Contracts.Persistence;
using WebApp.Movies.Domain.Entities;

namespace WebApp.Movies.Persistance.Repositories
{
    public class ActorRepository : BaseRepository<Actor>, IActorRepository
    {
        public ActorRepository(MoviesDbContext dbContext) : base(dbContext)
        {

        }

        public List<Actor> GetTVProgramActors(Guid IDTVProgram)
        {
            return _dbContext.Actors.FromSqlRaw("Select a.IDActor, a.Name From Actors a  join ActorTVPrograms atv on a.IDActor = atv.IDActor Where atv.IDTVProgram = {0}", IDTVProgram).ToList();
        }
    }
}
