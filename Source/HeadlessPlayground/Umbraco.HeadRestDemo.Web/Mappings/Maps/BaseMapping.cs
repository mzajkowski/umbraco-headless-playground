using System;
using Umbraco.Core.Mapping;

namespace Umbraco.HeadRestDemo.Web.Mappings.Maps
{
    public abstract class BaseMapping<TSelf, TFrom, TTo>
        where TSelf : BaseMapping<TSelf, TFrom, TTo>, new()
        where TTo : new()
    {
        private static readonly Lazy<TSelf> lazy = new Lazy<TSelf>(() => new TSelf());

        public static TSelf Instance { get { return lazy.Value; } }

        protected BaseMapping()
        { }

        public TTo Map(TFrom src, MapperContext ctx)
        {
            var dst = new TTo();
            Map(src, dst, ctx);
            return dst;
        }

        public abstract void Map(TFrom src, TTo dst, MapperContext ctx);
    }
}