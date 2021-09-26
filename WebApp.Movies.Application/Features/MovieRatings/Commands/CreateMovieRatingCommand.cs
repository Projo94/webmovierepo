using MediatR;
using System;
using WebApp.Movies.Domain.Entities;

namespace WebApp.Movies.Application.Features.MovieRatings.Commands
{
    public class CreateMovieRatingCommand : IRequest<TVProgramRating>
    {
        public Guid IDTVProgram { get; set; }
        public int IDRating { get; set; }


    }
}
