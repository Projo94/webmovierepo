using AutoMapper;
using Blazored.LocalStorage;
using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.Data.ApiCallService;
using WebApp.Movies.Application.Features.TVPrograms.Queries.GetTopTenTVProgram.DTOs;
using WebApp.Movies.Application.Models.Authentication;

namespace WebApp.Pages.TVProgram
{
    public class TVProgramBase : ComponentBase
    {
        [Inject]
        IApiCallService<TVProgramWithActorsVm> apiCallServiceTVProgram { get; set; }



        [Inject]
        NavigationManager navigationManager { get; set; }


        [Inject]
        public ILocalStorageService _localStorageService { get; set; }
        public string searchValue
        {
            get { return _searchValue; }
            set { _searchValue = value; Console.WriteLine(_searchValue); }
        }

        private string searchVal { get; set; } = "";

        private int lastLength = 0;


        public async Task ValueChanged(ChangeEventArgs args)
        {
            searchVal = args.Value.ToString();


            int diff = lastLength - searchVal.Length;

            lastLength = searchVal.Length;


            if (searchVal.ToString().Length >= 2 || diff > 0)
            {
                if (!Toggled)
                {
                    counterMovies = 1;

                    if (counterMovies == 1)
                        MoviesList = await apiCallServiceTVProgram.GetAllAsList("tvprogram/searchmovies?PageNumber=" + counterMovies + "&searchValue=" + searchVal);
                    else
                    {
                        MoviesList.AddRange(await apiCallServiceTVProgram.GetAllAsList("tvprogram/movies?PageNumber=" + counterMovies));
                    }

                }
                else
                {

                    counterTVShows = 1;

                    if (counterTVShows == 1)
                        TVShowsList = await apiCallServiceTVProgram.GetAllAsList("tvprogram/searchtvshows?PageNumber=" + counterTVShows + "&searchValue=" + searchVal);
                    else
                    {
                        TVShowsList.AddRange(await apiCallServiceTVProgram.GetAllAsList("tvprogram/movies?PageNumber=" + counterTVShows));
                    }

                }

            }





        }


        private string _searchValue { get; set; }

        protected List<TVProgramWithActorsVm> MoviesList { get; set; } = new List<TVProgramWithActorsVm>();

        protected List<TVProgramWithActorsVm> TVShowsList { get; set; } = new List<TVProgramWithActorsVm>();

        protected bool Toggled { get; set; }

        protected int counterMovies { get; set; }

        protected int counterTVShows { get; set; }


        protected override async Task OnInitializedAsync()
        {


            var user = await _localStorageService.GetItemAsync<AuthenticationResponse>("User");

            if (user is null)
                navigationManager.NavigateTo("/account/login");


            counterMovies = 1;

            counterTVShows = 1;


            await LoadTVPrograms();


        }

        public async Task LoadTenMore()
        {
            if (!Toggled)
                counterMovies++;
            else
                counterTVShows++;



            await LoadTVPrograms();
        }

        private async Task LoadTVPrograms()
        {
            if (!Toggled)
            {

                if (counterMovies == 1)
                {
                    if (searchVal.Length >= 2)
                        MoviesList = await apiCallServiceTVProgram.GetAllAsList("tvprogram/movies?PageNumber=" + counterMovies + "&searchValue=" + searchVal);
                    else
                        MoviesList = await apiCallServiceTVProgram.GetAllAsList("tvprogram/movies?PageNumber=" + counterMovies);
                }
                else
                {
                    if (searchVal.Length >= 2)
                        MoviesList.AddRange(await apiCallServiceTVProgram.GetAllAsList("tvprogram/movies?PageNumber=" + counterMovies + "&searchValue=" + searchVal));
                    else
                        MoviesList.AddRange(await apiCallServiceTVProgram.GetAllAsList("tvprogram/movies?PageNumber=" + counterMovies));
                }
            }
            else
            {

                if (counterTVShows == 1)
                {
                    if (searchVal.Length >= 2)
                        TVShowsList = await apiCallServiceTVProgram.GetAllAsList("tvprogram/searchtvshows?PageNumber=" + counterTVShows + "&searchValue=" + searchVal);
                    else
                        TVShowsList = await apiCallServiceTVProgram.GetAllAsList("tvprogram/tvshows?PageNumber=" + counterTVShows);
                }
                else
                {
                    if (searchVal.Length >= 2)
                        TVShowsList.AddRange(await apiCallServiceTVProgram.GetAllAsList("tvprogram/searchtvshows?PageNumber=" + counterTVShows + "&searchValue=" + searchVal));
                    else
                        TVShowsList.AddRange(await apiCallServiceTVProgram.GetAllAsList("tvprogram/tvshows?PageNumber=" + counterTVShows));
                }
            }
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





        public async Task Toggle(bool toggled)
        {

            MoviesList = new List<TVProgramWithActorsVm>();
            TVShowsList = new List<TVProgramWithActorsVm>();

            Toggled = toggled;

            await LoadTVPrograms();

        }







    }
}
