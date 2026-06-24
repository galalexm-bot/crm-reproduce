using System;
using System.Linq.Expressions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FileProvider.Distributed.Models;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode.Impl.CustomizersImpl;

namespace EleWise.ELMA.FileProvider.Distributed.Managers;

public class ContentOriginMap : ClassMapping<ContentOrigin>
{
	public ContentOriginMap()
	{
		((ClassCustomizer<ContentOrigin>)(object)this).Table("FS_ORIGINS");
		((ClassCustomizer<ContentOrigin>)(object)this).Id<long>((Expression<Func<ContentOrigin, long>>)((ContentOrigin p) => p.Id), (Action<IIdMapper>)delegate(IIdMapper p)
		{
			p.SetGenerator("FS_ORIGINS", "Id");
		});
		((PropertyContainerCustomizer<ContentOrigin>)(object)this).Property<long>((Expression<Func<ContentOrigin, long>>)((ContentOrigin p) => p.FileId));
		((PropertyContainerCustomizer<ContentOrigin>)(object)this).Property<string>((Expression<Func<ContentOrigin, string>>)((ContentOrigin p) => p.SourceGateway));
		((ClassCustomizer<ContentOrigin>)(object)this).Cache((Action<ICacheMapper>)delegate(ICacheMapper c)
		{
			c.Usage(CacheUsage.NonstrictReadWrite);
			c.Include(CacheInclude.NonLazy);
		});
	}
}
