using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data.ApiCallService;
using WebApp.Model;
using WebApp.Model.Account;



namespace WebApp.Pages
{
    public class LoginBase : ComponentBase
    {

        public User User { get; set; } = new User();

        public string LoginMesssage { get; set; }
        [Inject]
        public IApiCallService<User> loginCallService { get; set; }

        [Inject]
        public ILocalStorageService _localStorageService { get; set; }

        [Inject]
        AppState AppState { get; set; }

        [Inject]
        NavigationManager Navigation { get; set; }


        [Inject]
        AuthenticationStateProvider authenticationStateProvider { get; set; }

        public async Task LoginUser(User user)
        {

            var result = await loginCallService.SaveAsync("Account/authenticate", user);

            if (String.Equals(result.StatusCode, "OK"))
            {
                var returnedInfoForUser = JsonConvert.DeserializeObject<LoginResponse>(result.ResponseMessage);


                await _localStorageService.SetItemAsync("User", returnedInfoForUser);


                await authenticationStateProvider.GetAuthenticationStateAsync();


                AppState.LoggedIn = true;
                Navigation.NavigateTo("index");


            }



        }



    }
}
