using System;
using System.Collections.Generic;
using WebApp.Movies.Domain.Entities;

namespace WebApp.Movies.Application.Contracts.Persistence
{
    public interface IActorRepository : IAsyncRepository<Actor>
    {

        List<Actor> GetTVProgramActors(Guid IDTVProgram);
    }
}
