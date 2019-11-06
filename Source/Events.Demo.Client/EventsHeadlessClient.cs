using Events.Demo.Client.Configuration;
using System;
using System.Threading.Tasks;
using Umbraco.Headless.Client.Net.Delivery;
using Umbraco.Headless.Client.Net.Delivery.Models;

namespace Events.Demo.Client
{
    public class EventsHeadlessClient
    {
        private ContentDeliveryService _headlessClient;

        public EventsHeadlessClient(string projectAlias)
        {
            _headlessClient = new ContentDeliveryService(new ContentDeliveryConfiguration(projectAlias));
        }
        public async Task<PagedContent> GetAllEvents()
        {
            var allEvents = await _headlessClient.Content.GetByType("event").ConfigureAwait(false);
            return allEvents;
        }

        public async Task<Content> GetEvent(Guid id)
        {
            var eventObject = await _headlessClient.Content.GetById(id).ConfigureAwait(false);
            return eventObject;
        }
    }
}
