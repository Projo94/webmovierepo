using MediatR;
using System.Collections.Generic;
using WebApp.Movies.Application.Features.TVPrograms.Queries.GetTopTenTVProgram.DTOs;


namespace WebApp.Movies.Application.Features.TVPrograms.Queries.GetTopTenTVPrograms
{
    public class GetAllMoviesQuery : IRequest<List<TVProgramWithActorsVm>>
    {




    }
}
