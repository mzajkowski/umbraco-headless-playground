using System.Linq;
using Umbraco.Core.Mapping;
using Umbraco.HeadRestDemo.ViewModels;
using Umbraco.TestSite.Events.Models;

namespace Umbraco.HeadRestDemo.Mappings.Maps
{
    public class EventsViewModelMapper : BaseMapping<EventsViewModelMapper, Events, EventsViewModel>
    {
        public override void Map(Events src, EventsViewModel dst, MapperContext ctx)
        {
            dst.Id = src.Id;
            dst.Name = src.Name;
            dst.Url = src.Url;
            dst.Type = src.ContentType.Alias;
            dst.Events = src.Children.Select(x => EventViewModelMapper.Instance.Map((Event)x, ctx));
        }
    }
}