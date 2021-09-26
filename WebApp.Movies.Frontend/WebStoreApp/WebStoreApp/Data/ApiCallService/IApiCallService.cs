using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Model;


namespace WebApp.Data.ApiCallService
{
    public interface IApiCallService<T> where T : class
    {
        Task<List<T>> GetAllAsList(String url);

        Task<ServiceResponse> SaveAsync(String url, T obj);

        Task SaveVoidAsync(String url, T obj);



    }
}
