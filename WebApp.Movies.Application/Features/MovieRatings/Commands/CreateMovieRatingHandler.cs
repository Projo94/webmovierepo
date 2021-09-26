using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebApp.Movies.Application.Contracts.Persistence;
using WebApp.Movies.Application.Exceptions;
using WebApp.Movies.Application.Features.MovieRatings.Commands;
using WebApp.Movies.Domain.Entities;

namespace WebApp.Movies.Application.Features.TVProgramRatings.Commands
{
    public class CreateMovieRatingHandler : IRequestHandler<CreateMovieRatingCommand, TVProgramRating>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public CreateMovieRatingHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<TVProgramRating> Handle(CreateMovieRatingCommand request, CancellationToken cancellationToken)
        {

            var rating = await _unitOfWork.RatingRepository.GetByIdAsync(request.IDRating);

            var movie = await _unitOfWork.TVProgramRepository.GetByIdAsync(request.IDTVProgram);

            if (rating is null)
                throw new NotFoundException("Rating", request.IDRating);

            if (movie is null)
                throw new NotFoundException("Movie", request.IDTVProgram);


            var @tvProgramRating = _mapper.Map<TVProgramRating>(request);

            @tvProgramRating = await _unitOfWork.TVProgramRatingRepository.AddAsync(@tvProgramRating);

            return @tvProgramRating;

        }
    }

}
