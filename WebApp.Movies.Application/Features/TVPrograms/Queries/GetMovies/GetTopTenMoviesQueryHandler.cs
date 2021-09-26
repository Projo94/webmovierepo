using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebApp.Movies.Application.Contracts.Persistence;
using WebApp.Movies.Application.Features.TVPrograms.Queries.DTOs;
using WebApp.Movies.Application.Features.TVPrograms.Queries.GetTopTenTVProgram.DTOs;
using WebApp.Movies.Domain.Entities;

namespace WebApp.Movies.Application.Features.TVPrograms.Queries.GetTopTenTVPrograms
{
    public class GetTopTenMoviesQueryHandler : IRequestHandler<GetTopTenMoviesQuery, List<TVProgramWithActorsVm>>
    {
        private readonly IMapper _mapper;
        private readonly ITVProgramRepository _TVProgramRepository;

        private readonly IActorRepository _actorRepository;



        public GetTopTenMoviesQueryHandler(IMapper mapper, ITVProgramRepository tVProgramRepository, IActorRepository actorRepository)
        {
            _mapper = mapper;
            _TVProgramRepository = tVProgramRepository;
            _actorRepository = actorRepository;
        }

        public async Task<List<TVProgramWithActorsVm>> Handle(GetTopTenMoviesQuery request, CancellationToken cancellationToken)
        {
            var moviesEntities = await _TVProgramRepository.GetTVPrograms(request.PageNumber, request.PageSize, "Movie");
            if (moviesEntities is null)
                return new List<TVProgramWithActorsVm>();

            var result = new List<TVProgramWithActorsVm>();

            foreach (var m in moviesEntities)
            {
                var obj = new TVProgramWithActorsVm();

                obj.IDTVProgram = m.IDTVProgram;
                obj.AverageRating = m.AverageRating;
                obj.Title = m.Title;
                obj.Description = m.Description;
                obj.PictureDisplay = m.PictureDisplay;
                obj.ReleaseDate = m.ReleaseDate.Split(" ")[0];
                obj.actors = _mapper.Map<List<ActorVm>>((_actorRepository.GetTVProgramActors(obj.IDTVProgram)));


                result.Add(obj);

            }




            return result;
        }
    }
}
