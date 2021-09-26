using AutoMapper;
using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data.ApiCallService;
using WebApp.Model.TVProgram;
using WebApp.Movies.Application.Features.TVPrograms.Queries.GetTopTenTVProgram.DTOs;

namespace WebApp.Pages.MoviesRating
{
    public class RateMovieBase : ComponentBase
    {
        [Inject]
        IApiCallService<TVProgramWithActorsVm> apiCallServiceTVProgram { get; set; }

        [Inject]
        IApiCallService<Rating> apiCallServiceRating { get; set; }


        [Inject]
        IMapper _mapper { get; set; }


        [Inject]
        IToastService toastService { get; set; }

        [Inject]
        IJSRuntime JsRuntime { get; set; }
        [Inject]
        NavigationManager Navigation { get; set; }





        public async Task OnChange(int value, Guid movieId)
        {
            var rating = new Rating(movieId, value);

            await apiCallServiceRating.SaveAsync("tvprogram/rate", rating);


        }

        private string _searchValue { get; set; }

        protected List<TVProgramWithActorsVm> MoviesList { get; set; } = new List<TVProgramWithActorsVm>();



        protected override async Task OnInitializedAsync()
        {

            await LoadTVPrograms();

        }



        private async Task LoadTVPrograms()
        {

            MoviesList = await apiCallServiceTVProgram.GetAllAsList("tvprogram/getallmovies");



        }



        protected string convertImageToDisplay(string image)
        {

            if (image != null)
            {
                var fs = string.Format("data:image/jpg;base64,{0}", image);
                return fs;
            }
            return "";
        }











    }
}
