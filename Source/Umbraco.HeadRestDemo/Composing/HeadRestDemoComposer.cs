using Our.Umbraco.HeadRest.Composing;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Mapping;
using Umbraco.HeadRestDemo.Mappings;

namespace Umbraco.HeadRestDemo.Composing
{
    [ComposeAfter(typeof(HeadRestComposer))]
    public class HeadRestDemoComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Components().Append<HeadRestDemoConfigComponent>();
            composition.WithCollectionBuilder<MapDefinitionCollectionBuilder>().Add<HeadRestDemoMapDefinition>();
        }
    }
}