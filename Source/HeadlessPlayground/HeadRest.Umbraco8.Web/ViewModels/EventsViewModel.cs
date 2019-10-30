using System.Collections.Generic;

namespace Umbraco.HeadRestDemo.Web.ViewModels
{
    public class EventsViewModel : BaseViewModel
    {
        public IEnumerable<EventViewModel> Events { get; set; }
    }
}