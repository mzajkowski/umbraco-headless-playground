using Events.Demo.Client.Interfaces;
using Refit;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Umbraco.HeadRestDemo.ViewModels;

namespace Events.Demo.Client
{
    public class EventsHeadRestClient : IHeadRestApi
    {
        private readonly HttpClient _httpClient;
        private readonly IHeadRestApi _headRestApi;

        public EventsHeadRestClient(Uri baseEndpointUrl)
        {
            _httpClient = new HttpClient(new HttpClientHandler()) { BaseAddress = baseEndpointUrl };
            _headRestApi = RestService.For<IHeadRestApi>(_httpClient);
        }

        public async Task<EventsViewModel> GetEventsFromRoot()
        {
            return await _headRestApi.GetEventsFromRoot().ConfigureAwait(false);
        }

        public async Task<EventViewModel> GetEventByUri(Uri uri)
        {
            return await _headRestApi.GetEventByUri(uri).ConfigureAwait(false);
        }
    }
}
