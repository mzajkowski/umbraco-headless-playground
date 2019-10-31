using Umbraco.Core.Mapping;
using Umbraco.HeadRestDemo.Web.Mappings.Maps;
using Umbraco.HeadRestDemo.Web.Models;
using Umbraco.HeadRestDemo.Web.ViewModels;

namespace Umbraco.HeadRestDemo.Web.Mappings
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