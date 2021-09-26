using System;
using System.Collections.Generic;
using WebApp.Movies.Application.Contracts.Persistence.Dapper;
using WebApp.Movies.Domain.Entities;

namespace WebApp.Movies.Application.Contracts.Persistence
{
    public interface ITVProgramRepository : IAsyncRepository<TVProgram>, ITVProgramRepositoryDapper
    {

    }
}
