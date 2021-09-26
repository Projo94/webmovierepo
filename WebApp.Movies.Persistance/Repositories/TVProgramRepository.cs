using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Movies.Application.Contracts.Persistence;
using WebApp.Movies.Application.Features.TVPrograms.Queries.GetTopTenTVProgram.DTOs;
using WebApp.Movies.Domain.Entities;

namespace WebApp.Movies.Persistance.Repositories
{
    public class TVProgramRepository : BaseRepository<TVProgram>, ITVProgramRepository
    {

        private IDbConnection db;

        public TVProgramRepository(IConfiguration configuration, MoviesDbContext dbContext) : base(dbContext)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("MoviesConnectionString"));
        }

        public async Task<List<TVProgramVm>> GetAllMovies()
        {
            var sql = @"exec GetAllMoviesSP";

            var result = await db.QueryAsync<TVProgramVm>(sql);

            return result.ToList();
        }

        public async Task<List<TVProgramVm>> GetTVPrograms(int page, int size, string type)
        {
            var sql = @"exec GetTVProgramsSP @Type='" + type + "' , @PageNumber = " + page + " , @RowsOfPage=" + size;

            var result = await db.QueryAsync<TVProgramVm>(sql);

            return result.ToList();
        }

        public async Task<List<TVProgramVm>> GetTVPrograms(int page, int size, string type, string searchValue)
        {
            var sql = @"exec GetTVProgramsSP @Type='" + type + "' , @PageNumber = " + page + ", @RowsOfPage=" + size + " , @SearchValue= '" + searchValue + "'";

            var result = await db.QueryAsync<TVProgramVm>(sql);



            return result.ToList();
        }
    }
}
