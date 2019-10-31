using Our.Umbraco.GraphQL;
using Umbraco.Core.Composing;

namespace Umbraco.GraphQLDemo.Composing
{
    class GraphQLDemoComposer : ComponentComposer<GraphQLDemoConfigComponent>, IUserComposer
    {
        public override void Compose(Composition composition)
        {
            base.Compose(composition);

            composition.RegisterGraphQLServices();
        }
    }
}
