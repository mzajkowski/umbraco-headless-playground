using Refit;
using System;
using System.Threading.Tasks;
using Umbraco.HeadRestDemo.ViewModels;

namespace Events.Demo.Client.Interfaces
{
    /// <summary>
    /// API "definiton" for Refit RestService implementation.
    /// </summary>
    public interface IHeadRestApi
    {
        [Get("/")]
        Task<EventsViewModel> GetEventsFromRoot();


        [Get("/{uri}")]
        Task<EventViewModel> GetEventByUri(Uri uri);
    }
}
