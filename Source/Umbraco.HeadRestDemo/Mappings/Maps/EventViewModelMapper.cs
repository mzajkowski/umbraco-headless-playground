using Umbraco.Core.Mapping;
using Umbraco.HeadRestDemo.ViewModels;
using Umbraco.TestSite.Events.Models;

namespace Umbraco.HeadRestDemo.Mappings.Maps
{
    public class EventViewModelMapper : BaseMapping<EventViewModelMapper, Event, EventViewModel>
    {
        public override void Map(Event src, EventViewModel dst, MapperContext ctx)
        {
            dst.Id = src.Id;
            dst.Name = src.Name;
            dst.Url = src.Url;
            dst.Type = src.ContentType.Alias;
        }
    }
}