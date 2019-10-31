using System;
using Umbraco.Core.Mapping;

namespace Umbraco.HeadRestDemo.Extensions
{
    public static class UmbracoMapperExtensions
    {
        public static void Define<TFrom, TTo>(this UmbracoMapper mapper, Action<TFrom, TTo, MapperContext> map)
            where TTo : new()
        {
            mapper.Define(
               (src, ctx) => new TTo(),
               map
            );
        }
    }
}
