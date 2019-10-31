using Our.Umbraco.HeadRest;
using Our.Umbraco.HeadRest.Web.Mapping;
using Umbraco.Core.Composing;
using Umbraco.HeadRestDemo.ViewModels;
using Umbraco.TestSite.Events.Models;

namespace Umbraco.HeadRestDemo.Composing
{
    public class HeadRestDemoConfigComponent : IComponent
    {
        private readonly HeadRest _headRest;

        public HeadRestDemoConfigComponent(HeadRest headRest) => _headRest = headRest;

        public void Initialize()
        {
            _headRest.ConfigureEndpoint(new HeadRestOptions
            //_headRest.ConfigureEndpoint("/api/", "/root//events[1]", new HeadRestOptions
            {
                //CustomRouteMappings = new HeadRestRouteMap()
                //    .For("^/(?<altRoute>init|sitemap)/?$").MapTo("/"),

                ViewModelMappings = new HeadRestViewModelMap()
                    .For(Events.ModelTypeAlias).MapTo<EventsViewModel>()
                    .For(Event.ModelTypeAlias).MapTo<EventViewModel>()
                    .For(EventTypes.ModelTypeAlias).MapTo<EventTypesViewModel>()
                    .For(EventType.ModelTypeAlias).MapTo<EventTypeViewModel>()
                    .For(Venues.ModelTypeAlias).MapTo<VenuesViewModel>()
                    .For(Venue.ModelTypeAlias).MapTo<VenueViewModel>()
                    .For(Speakers.ModelTypeAlias).MapTo<SpeakersViewModel>()
                    .For(Speaker.ModelTypeAlias).MapTo<SpeakerViewModel>()
                    .For(Organisers.ModelTypeAlias).MapTo<OrganisersViewModel>()
                    .For(Organiser.ModelTypeAlias).MapTo<OrganiserViewModel>()

                //.ForEverythingElse().MapTo<BasePageViewModel>()
            });
        }

        public void Terminate()
        {
        }
    }
}