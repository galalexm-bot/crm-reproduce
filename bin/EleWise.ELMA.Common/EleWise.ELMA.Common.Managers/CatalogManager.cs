using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Common.Managers;

public class CatalogManager : EntityManager<ICatalogProfile, long>
{
	[Component]
	private class CleanCatalogProfileCache : IMetadataPublishFinishedEventHandler, IEventHandler
	{
		private readonly IMemoryCacheService memoryCacheService;

		public CleanCatalogProfileCache(IMemoryCacheService memoryCacheService)
		{
			this.memoryCacheService = memoryCacheService;
		}

		public void PublishExecuted(MetadataPublishedEventArgs e)
		{
			e.DeltaPublishedMetadata.Concat(e.SoftPublishedMetadata).ForEach(delegate(IRootMetadata rootMd)
			{
				string key = "CatalogProfile_" + rootMd.Uid;
				memoryCacheService.Remove(key);
			});
		}
	}

	private const string CacheKeyPrefix = "CatalogProfile_";

	public new static CatalogManager Instance => Locator.GetServiceNotNull<CatalogManager>();

	[ContextCache]
	public virtual ICatalogProfile LoadByCatalog(Guid uid)
	{
		Contract.ServiceNotNull(base.MemoryCacheService, "IMemoryCacheService");
		string key = "CatalogProfile_" + uid;
		if (!base.MemoryCacheService.TryGetValue<ICatalogProfile>(key, out var result))
		{
			result = CreateCriteria(new Filter
			{
				DisableSecurity = true
			}).Add((ICriterion)(object)Restrictions.Eq("CatalogType", (object)new ReferenceOnEntityType
			{
				TypeUid = GetInterfaceUid(uid)
			})).List<ICatalogProfile>().FirstOrDefault();
			if (result != null)
			{
				base.MemoryCacheService.Insert(key, result);
			}
		}
		return result;
	}

	public override void Save(ICatalogProfile profile)
	{
		Guid interfaceUid = GetInterfaceUid(profile.CatalogType.TypeUid);
		if (interfaceUid != profile.CatalogType.TypeUid)
		{
			profile.CatalogType = new ReferenceOnEntityType
			{
				TypeUid = interfaceUid
			};
		}
		base.Save(profile);
	}

	public void LoadCache()
	{
		Contract.ServiceNotNull(base.MemoryCacheService, "IMemoryCacheService");
		Action action = delegate
		{
			(from p in FindAll()
				where p.CatalogType != null
				select p).ForEach(delegate(ICatalogProfile p)
			{
				base.MemoryCacheService.Insert("CatalogProfile_" + p.CatalogType.TypeUid, p);
			});
		};
		ISecurityService service = Locator.GetService<ISecurityService>();
		if (service != null)
		{
			service.RunWithElevatedPrivilegies(action);
		}
		else
		{
			action();
		}
	}

	public virtual Dictionary<Guid, ICatalogProfile> LoadByCatalogs(List<Guid> uids)
	{
		ICriteria obj = CreateCriteria(new Filter
		{
			DisableSecurity = true
		});
		object[] array = uids.Select((Guid u) => new ReferenceOnEntityType
		{
			TypeUid = u
		}).ToArray();
		return obj.Add((ICriterion)(object)Restrictions.In("CatalogType", array)).List<ICatalogProfile>().ToDictionary((ICatalogProfile k) => k.CatalogType.TypeUid);
	}

	public virtual Dictionary<Guid, string> LoadNamesByCatalogs(List<Guid> uids)
	{
		ICriteria obj = CreateCriteria(new Filter
		{
			DisableSecurity = true
		});
		object[] array = uids.Select((Guid u) => new ReferenceOnEntityType
		{
			TypeUid = u
		}).ToArray();
		return obj.Add((ICriterion)(object)Restrictions.In("CatalogType", array)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property("CatalogType")).Add((IProjection)(object)Projections.Property("Name")) }).List<object[]>()
			.ToDictionary((object[] k) => ((ReferenceOnEntityType)k[0]).TypeUid, (object[] v) => (string)v[1]);
	}

	private Guid GetInterfaceUid(Guid uid)
	{
		if (MetadataLoader.LoadMetadata(uid, inherit: false, loadImplementation: false) is EntityMetadata entityMetadata)
		{
			switch (entityMetadata.Type)
			{
			case EntityMetadataType.InterfaceExtension:
				return entityMetadata.BaseClassUid;
			case EntityMetadataType.InterfaceImplementation:
				return entityMetadata.ImplementationUid;
			}
		}
		return uid;
	}
}
