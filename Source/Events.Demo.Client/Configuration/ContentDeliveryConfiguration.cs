using Umbraco.Headless.Client.Net.Configuration;

namespace Events.Demo.Client.Configuration
{
    public class ContentDeliveryConfiguration : IHeadlessConfiguration
    {
        public ContentDeliveryConfiguration(string projectAlias)
        {
            ProjectAlias = projectAlias;
        }

        public string ProjectAlias { get; }
    }
}
