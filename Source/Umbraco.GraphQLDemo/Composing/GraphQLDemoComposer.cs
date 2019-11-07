using Umbraco.Core;
using Umbraco.Core.Composing;

namespace Umbraco.GraphQLDemo.Composing
{
    [RuntimeLevel(MinLevel = RuntimeLevel.Run)]
    class GraphQLDemoComposer : ComponentComposer<GraphQLDemoConfigComponent>, IUserComposer
    {
    }
}
