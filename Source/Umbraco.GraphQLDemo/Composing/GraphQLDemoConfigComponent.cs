using Our.Umbraco.GraphQL.Web;
using Umbraco.Core.Composing;
using Umbraco.Core.Configuration;
using Umbraco.Web;

namespace Umbraco.GraphQLDemo.Composing
{
    public class GraphQLDemoConfigComponent : IComponent
    {
        private readonly IGlobalSettings _globalSettings;
        private readonly IFactory _factory;

        public GraphQLDemoConfigComponent(IGlobalSettings globalSettings, IFactory factory)
        {
            _globalSettings = globalSettings ?? throw new System.ArgumentNullException(nameof(globalSettings));
            _factory = factory ?? throw new System.ArgumentNullException(nameof(factory));
        }

        public void Initialize()
        {
            UmbracoDefaultOwinStartup.MiddlewareConfigured += (s, e) =>
            {
                e.AppBuilder.UseUmbracoGraphQL(_globalSettings.GetUmbracoMvcArea(), _factory, new GraphQLServerOptions
                {
                    EnableMetrics = true,
                    Debug = true,
                });
            };
        }

        public void Terminate()
        {
        }
    }
}
