using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WebApp.Movies.Application.Contracts.Persistence;
using WebApp.Movies.Application.Features.TVPrograms.Queries.DTOs;
using WebApp.Movies.Application.Features.TVPrograms.Queries.GetTopTenTVProgram.DTOs;

namespace WebApp.Movies.Application.Features.TVPrograms.Queries.GetTopTenTVPrograms
{
    public class GetAllMoviesQueryHandler : IRequestHandler<GetAllMoviesQuery, List<TVProgramWithActorsVm>>
    {
        private readonly IMapper _mapper;
        private readonly ITVProgramRepository _TVProgramRepository;

        private readonly IActorRepository _actorRepository;



        public GetAllMoviesQueryHandler(IMapper mapper, ITVProgramRepository tVProgramRepository, IActorRepository actorRepository)
        {
            _mapper = mapper;
            _TVProgramRepository = tVProgramRepository;
            _actorRepository = actorRepository;
        }

        public async Task<List<TVProgramWithActorsVm>> Handle(GetAllMoviesQuery request, CancellationToken cancellationToken)
        {
            var moviesEntities = await _TVProgramRepository.GetAllMovies();

            if (moviesEntities is null)
                return null;


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
