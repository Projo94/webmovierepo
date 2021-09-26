using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.Movies.Application.Features.MovieRatings.Commands;
using WebApp.Movies.Application.Features.TVPrograms.Queries.GetTopTenTVProgram.DTOs;
using WebApp.Movies.Application.Features.TVPrograms.Queries.GetTopTenTVPrograms;
using WebApp.Movies.Application.Features.TVPrograms.Queries.GetTVShows;
using WebApp.Movies.Application.Features.TVPrograms.Queries.GetTVShowsBySearch;
using WebApp.Movies.Domain.Entities;


namespace WebApp.Movies.Api.Controllers
{
    [EnableCors("Open")]
    [Authorize]
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class TVProgramController : BaseApiController
    {

        private readonly IMediator _mediator;
        public TVProgramController(IMediator mediator)
        {
            _mediator = mediator;
        }




        [ActionName("movies")]
        [HttpGet(Name = "GetMovies")]
        public async Task<ActionResult<List<TVProgramVm>>> GetMovies([FromQuery] GetTopTenMoviesQuery request)
        {
            var dtos = await _mediator.Send(request);

            return Ok(dtos);
        }





        [ActionName("getallmovies")]
        [HttpGet(Name = "GetAllMovies")]
        public async Task<ActionResult<List<TVProgramVm>>> GetAllMovies([FromQuery] GetAllMoviesQuery request)
        {
            var dtos = await _mediator.Send(request);

            return Ok(dtos);
        }


        [ActionName("tvshows")]
        [HttpGet(Name = "GetTVShows")]
        public async Task<ActionResult<List<TVProgramVm>>> GetTVShows([FromQuery] GetTopTenTVShowsQuery request)
        {
            var dtos = await _mediator.Send(request);

            return Ok(dtos);
        }


        [ActionName("rate")]
        [HttpPost]
        public async Task<ActionResult<TVProgramRating>> AddMovieRating([FromBody] CreateMovieRatingCommand createTVProgramRatingCommand)
        {
            var response = await _mediator.Send(createTVProgramRatingCommand);

            return Ok(response);


        }





        [ActionName("searchmovies")]
        [HttpGet(Name = "SearchForMovies")]

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<TVProgramRating>> SearchForMovies([FromQuery] GetTopTenMoviesBySearchQuery request)
        {
            var response = await _mediator.Send(request);

            return Ok(response);


        }



        [ActionName("searchtvshows")]
        [HttpGet(Name = "SearchForTVShows")]
        public async Task<ActionResult<TVProgramRating>> SearchForTVShows([FromQuery] GetTopTenTVShowsBySearchQuery request)
        {
            var response = await _mediator.Send(request);

            return Ok(response);
        }


    }
}
