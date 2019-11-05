using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Umbraco.HeadRestDemo.ViewModels;

namespace Events.Demo.Client
{
    public interface IHeadRestApi
    {
        [Get("/")]
        Task<EventsViewModel> GetEvents();
    }

    public class EventsHeadRestClient : IHeadRestApi
    {
        private readonly HttpClient _httpClient;
        private readonly IHeadRestApi _headRestApi;

        public EventsHeadRestClient(Uri baseEndpointUrl)
        {
            _httpClient = new HttpClient(new HttpClientHandler()) { BaseAddress = baseEndpointUrl };
            _headRestApi = RestService.For<IHeadRestApi>(_httpClient);
        }

        public async Task<EventsViewModel> GetEvents()
        {
            return await _headRestApi.GetEvents().ConfigureAwait(false);
        }
    }
}
