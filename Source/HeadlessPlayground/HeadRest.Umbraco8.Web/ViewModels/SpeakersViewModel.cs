using System.Collections.Generic;

namespace Umbraco.HeadRestDemo.Web.ViewModels
{
    public class SpeakersViewModel
    {
        public IEnumerable<SpeakerViewModel> Speakers { get; set; }
    }
}