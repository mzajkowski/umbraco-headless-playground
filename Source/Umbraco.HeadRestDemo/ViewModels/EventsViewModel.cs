using System.Collections.Generic;

namespace Umbraco.HeadRestDemo.ViewModels
{
    public class EventsViewModel : BaseViewModel
    {
        public IEnumerable<EventViewModel> Events { get; set; }
    }
}