using AutoMapper;
using WebApp.Movies.Application.Features.MovieRatings.Commands;
using WebApp.Movies.Application.Features.TVProgramRatings.Commands;
using WebApp.Movies.Application.Features.TVPrograms.Queries.DTOs;
using WebApp.Movies.Application.Features.TVPrograms.Queries.GetTopTenTVProgram.DTOs;
using WebApp.Movies.Domain.Entities;

namespace WebApp.Movies.Application.Profiles
{
    class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TVProgram, TVProgramVm>().ReverseMap();

            CreateMap<TVProgramRating, CreateMovieRatingCommand>().ReverseMap();

            CreateMap<Actor, ActorVm>().ReverseMap();


        }

    }
}
