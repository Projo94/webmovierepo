using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.Movies.Application.Features.TVPrograms.Queries.GetTopTenTVProgram.DTOs;

namespace WebApp.Movies.Application.Contracts.Persistence.Dapper
{
    public interface ITVProgramRepositoryDapper
    {

        Task<List<TVProgramVm>> GetAllMovies();

        Task<List<TVProgramVm>> GetTVPrograms(int page, int size, string type);

        Task<List<TVProgramVm>> GetTVPrograms(int page, int size, string type, string searchValue);


    }
}
