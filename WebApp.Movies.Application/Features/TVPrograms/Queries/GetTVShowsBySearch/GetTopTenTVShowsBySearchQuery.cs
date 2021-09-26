using MediatR;
using System.Collections.Generic;
using WebApp.Movies.Application.Features.TVPrograms.Queries.GetTopTenTVProgram.DTOs;


namespace WebApp.Movies.Application.Features.TVPrograms.Queries.GetTVShowsBySearch
{
    public class GetTopTenTVShowsBySearchQuery : IRequest<List<TVProgramWithActorsVm>>
    {
        public string searchValue { get; set; }

        const int maxPageSize = 10;

        public int PageNumber { get; set; } = 1;

        private int _pageSize = 10;

        public int PageSize
        {
            get
            {

                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;

            }
        }


    }
}
