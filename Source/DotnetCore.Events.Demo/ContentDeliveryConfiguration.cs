using Umbraco.Headless.Client.Net.Configuration;

namespace DotnetCore.Events.Demo
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
