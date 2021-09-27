using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebApp.Model;
using WebApp.Model.Account;


namespace WebApp.Data.ApiCallService
{
    public class ApiCallService<T> : IApiCallService<T> where T : class
    {
        IHttpClientFactory _clientFactory;

        public ILocalStorageService _localStorageService { get; }


        public ApiCallService(IHttpClientFactory clientFactory, ILocalStorageService localStorageService)
        {
            _clientFactory = clientFactory;
            _localStorageService = localStorageService;
        }

        public async Task<string> DeleteAsync(string url, object id)
        {
            var client = _clientFactory.CreateClient("webapi");

            try
            {
                var response = await client.DeleteAsync(url + id);

                var responseStatusCode = response.StatusCode.ToString();

                return responseStatusCode;

            }
            catch (Exception ex)
            {
                return "BadRequest";

            }
        }

        public async Task<List<T>> GetAllAsList(String url)
        {
            var client = _clientFactory.CreateClient("webapi");

            if (await _localStorageService.ContainKeyAsync("User"))
            {

                var userInfo = await _localStorageService.GetItemAsync<LocalUserInfo>("User");

                var token = userInfo.token;


                try
                {
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);



                    var r = await client.GetFromJsonAsync<T[]>(url);


                    return r.ToList();
                }
                catch (HttpRequestException ex)
                {
                    return new List<T>();

                }

            }

            return null;
        }

        public async Task<T> GetById(string url, object id)
        {
            var client = _clientFactory.CreateClient("webapi");

            try
            {
                var r = await client.GetFromJsonAsync<T>(url + id);
                return r;
            }
            catch (Exception ex)
            {
                return null;

            }
        }

        public async Task SaveVoidAsync(string url, T obj)
        {
            var client = _clientFactory.CreateClient("webapi");

            try
            {

                var userInfo = await _localStorageService.GetItemAsync<LocalUserInfo>("User");

                var token = userInfo.token;

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);


                await client.PostAsJsonAsync(url, obj);
            }
            catch (Exception ex)
            {


            }
        }



        public async Task<ServiceResponse> SaveAsync(string url, T obj)
        {
            var client = _clientFactory.CreateClient("webapi");

            var serviceResponse = new ServiceResponse();


            try
            {
                var r = await client.PostAsJsonAsync(url, obj);

                var result = r.Content.ReadAsStringAsync().Result;


                serviceResponse.ResponseMessage = result;

                serviceResponse.StatusCode = r.StatusCode.ToString();

                return serviceResponse;



            }
            catch (Exception ex)
            {
                return null;

            }
        }


    }
}
