using Umbraco.Core.Mapping;
using Umbraco.HeadRestDemo.Web.Models;
using Umbraco.HeadRestDemo.Web.ViewModels;

namespace Umbraco.HeadRestDemo.Web.Mappings.Maps
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