using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Mapping;
using Umbraco.HeadRestDemo.Web.Mappings;

namespace Umbraco.HeadRestDemo.Web.Composing
{
    public class HeadRestDemoComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Components().Append<HeadRestDemoConfigComponent>();
            composition.WithCollectionBuilder<MapDefinitionCollectionBuilder>().Add<HeadRestDemoMapDefinition>();
        }
    }
}