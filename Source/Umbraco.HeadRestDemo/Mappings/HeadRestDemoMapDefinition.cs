using Umbraco.Core.Mapping;
using Umbraco.HeadRestDemo.Mappings.Maps;
using Umbraco.HeadRestDemo.ViewModels;
using Umbraco.TestSite.Events.Models;

namespace Umbraco.HeadRestDemo.Mappings
{
    public class HeadRestDemoMapDefinition : IMapDefinition
    {
        public void DefineMaps(UmbracoMapper mapper)
        {
            mapper.Define<Events, EventsViewModel>(EventsViewModelMapper.Instance.Map);
            mapper.Define<Event, EventViewModel>(EventViewModelMapper.Instance.Map);
        }
    }
}