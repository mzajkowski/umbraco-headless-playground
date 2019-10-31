using System.Collections.Generic;

namespace Umbraco.HeadRestDemo.ViewModels
{
    public class SpeakersViewModel
    {
        public IEnumerable<SpeakerViewModel> Speakers { get; set; }
    }
}