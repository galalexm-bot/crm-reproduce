using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Extensions;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Common.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class FilterFolderManager : EntityManager<IFilterFolder, long>
{
	private const string ContextCacheRegion = "CR EleWise.ELMA.Common.Managers.FilterFolderManager";

	public IContextBoundVariableService CacheService { get; set; }

	public new static FilterFolderManager Instance => Locator.GetServiceNotNull<FilterFolderManager>();

	[Cache]
	public virtual ICollection Types(ReferenceOnEntityType type)
	{
		List<ReferenceOnEntityType> list = new List<ReferenceOnEntityType>();
		list.Add(type);
		IEnumerable<ClassMetadata> source = (from m in Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList()
			where m is ClassMetadata && ((ClassMetadata)m).BaseClassUid == type.TypeUid
			select m).Cast<ClassMetadata>();
		list.AddRange(source.Select((ClassMetadata md) => new ReferenceOnEntityType
		{
			TypeUid = md.Uid
		}));
		return list;
	}

	public virtual ICollection<IFilterFolder> LoadSharedFilterFolders(ReferenceOnEntityType type)
	{
		return LoadSharedFilterFolders(type, null);
	}

	[ContextCache(Region = "CR EleWise.ELMA.Common.Managers.FilterFolderManager")]
	public virtual ICollection<IFilterFolder> LoadSharedFilterFolders(ReferenceOnEntityType type, Guid? code)
	{
		ICriteria val = CreateCriteria(null, base.ImplementationType);
		SetupSharedFilterFoldersFilter(val, type, code);
		return val.List<IFilterFolder>();
	}

	[ContextCache(Region = "CR EleWise.ELMA.Common.Managers.FilterFolderManager")]
	public virtual IFilterFolder LoadSharedFilterFolder(ReferenceOnEntityType type, Guid? code)
	{
		ICriteria val = CreateCriteria(null, base.ImplementationType);
		SetupSharedFilterFolderFilter(val, type, code);
		return val.List<IFilterFolder>().FirstOrDefault();
	}

	[Auditable]
	public virtual ICollection<IFilterFolder> LoadSystemFilterFolders(ReferenceOnEntityType type)
	{
		return LoadSystemFilterFolders(type, null);
	}

	[Auditable]
	[ContextCache(Region = "CR EleWise.ELMA.Common.Managers.FilterFolderManager")]
	public virtual ICollection<IFilterFolder> LoadSystemFilterFolders(ReferenceOnEntityType type, Guid? code)
	{
		ICriteria val = CreateCriteria(null, base.ImplementationType);
		SetupSystemFilterFoldersFilter(val, type, code);
		return val.List<IFilterFolder>();
	}

	[Auditable]
	protected virtual void SetupSharedFilterFoldersFilter(ICriteria criteria, ReferenceOnEntityType type)
	{
		SetupSharedFilterFoldersFilter(criteria, type, null);
	}

	[Auditable]
	protected virtual void SetupSharedFilterFoldersFilter(ICriteria criteria, ReferenceOnEntityType type, Guid? code)
	{
		criteria.Add((ICriterion)(object)Restrictions.In("ObjectsType", Types(type)));
		criteria.Add((ICriterion)(object)Restrictions.Eq("FilterType", (object)FilterType.SharedFilter));
		if (code.HasValue)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("Code", (object)code.Value));
		}
		SetPermissionByFilter(criteria);
	}

	[Auditable]
	protected virtual void SetupSharedFilterFolderFilter(ICriteria criteria, ReferenceOnEntityType type, Guid? code)
	{
		criteria.Add((ICriterion)(object)Restrictions.IsNull("ParentFolder"));
		criteria.Add((ICriterion)(object)Restrictions.In("ObjectsType", Types(type)));
		criteria.Add((ICriterion)(object)Restrictions.Eq("FilterType", (object)FilterType.SharedFilter));
		if (code.HasValue)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("Code", (object)code.Value));
		}
	}

	[Auditable]
	protected virtual void SetupSystemFilterFoldersFilter(ICriteria criteria, ReferenceOnEntityType type)
	{
		SetupSystemFilterFoldersFilter(criteria, type, null);
	}

	[Auditable]
	protected virtual void SetupSystemFilterFoldersFilter(ICriteria criteria, ReferenceOnEntityType type, Guid? code)
	{
		criteria.Add((ICriterion)(object)Restrictions.In("ObjectsType", Types(type)));
		criteria.Add((ICriterion)(object)Restrictions.Eq("FilterType", (object)FilterType.SystemFilter));
		if (code.HasValue)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("Code", (object)code.Value));
		}
		SetPermissionByFilter(criteria);
	}

	public virtual ICollection<IFilterFolder> LoadOrCreateSharedFilterFolders(ReferenceOnEntityType type)
	{
		return LoadOrCreateSharedFilterFolders(type, null);
	}

	[ContextCache(Region = "CR EleWise.ELMA.Common.Managers.FilterFolderManager")]
	public virtual IFilterFolder LoadOrCreateSharedFilterFolder(ReferenceOnEntityType type, Guid? code = null)
	{
		lock (this)
		{
			IFilterFolder filterFolder = LoadSharedFilterFolder(type, code);
			if (filterFolder == null)
			{
				InstanceOf<IFilterFolder> instanceOf = new InstanceOf<IFilterFolder>();
				instanceOf.New.Name = SR.T("Общие фильтры");
				instanceOf.New.ObjectsType = type;
				instanceOf.New.FilterType = FilterType.SharedFilter;
				instanceOf.New.Code = code;
				filterFolder = instanceOf.New;
				filterFolder.Save();
			}
			return filterFolder;
		}
	}

	[ContextCache(Region = "CR EleWise.ELMA.Common.Managers.FilterFolderManager")]
	public virtual ICollection<IFilterFolder> LoadOrCreateSharedFilterFolders(ReferenceOnEntityType type, Guid? code)
	{
		lock (this)
		{
			ICollection<IFilterFolder> collection = LoadSharedFilterFolders(type, code);
			if (!collection.Any())
			{
				InstanceOf<IFilterFolder> instanceOf = new InstanceOf<IFilterFolder>();
				instanceOf.New.Name = SR.T("Общие фильтры");
				instanceOf.New.ObjectsType = type;
				instanceOf.New.FilterType = FilterType.SharedFilter;
				instanceOf.New.Code = code;
				IFilterFolder @new = instanceOf.New;
				@new.Save();
				collection.Add(@new);
			}
			return collection;
		}
	}

	[Auditable]
	public virtual ICollection<IFilterFolder> LoadFilterFolders(ReferenceOnEntityType type)
	{
		return LoadFilterFolders(type, null);
	}

	[Auditable]
	public virtual ICollection<IFilterFolder> LoadFilterFolders(ReferenceOnEntityType type, Guid? code, bool includeFavorites = false)
	{
		IEnumerable<IFilterFolder> enumerable = LoadSystemFilterFolders(type, code).Union(LoadSharedFilterFolders(type, code)).Union(LoadMyFilterFolders(type, code));
		if (includeFavorites)
		{
			enumerable = enumerable.Union(LoadFavoriteFilters(type, code));
		}
		return enumerable.ToArray();
	}

	public virtual ICollection<IFilterFolder> LoadAvailableFilters(bool shared)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		ICriteria val = CreateCriteria(null, base.ImplementationType);
		val.Add((ICriterion)(object)Restrictions.Eq(base.EntityTypeUidPropertyName, (object)InterfaceActivator.UID<IFilter>()));
		foreach (IFilterPortletExcludedTypes extensionPoint in ComponentManager.Current.GetExtensionPoints<IFilterPortletExcludedTypes>())
		{
			val.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq("ObjectsType", (object)new ReferenceOnEntityType
			{
				TypeUid = extensionPoint.GetExcludedTypeUid()
			})));
		}
		if (shared)
		{
			val.Add((ICriterion)(object)((Junction)new Disjunction()).Add((ICriterion)(object)Restrictions.Eq("FilterType", (object)FilterType.SystemFilter)).Add((ICriterion)(object)Restrictions.Eq("FilterType", (object)FilterType.SharedFilter)));
		}
		else
		{
			val.Add((ICriterion)(object)((Junction)new Disjunction()).Add((ICriterion)(object)((Junction)new Conjunction()).Add((ICriterion)(object)Restrictions.Eq("FilterType", (object)FilterType.MyFilter)).Add((ICriterion)(object)Restrictions.Eq("CreationAuthor", (object)base.AuthenticationService.GetCurrentUser()))).Add((ICriterion)(object)Restrictions.Eq("FilterType", (object)FilterType.SystemFilter)).Add((ICriterion)(object)Restrictions.Eq("FilterType", (object)FilterType.SharedFilter)));
		}
		SetPermissionByFilter(val);
		return val.List<IFilterFolder>();
	}

	[Auditable]
	public virtual ICollection<IFilterFolder> LoadOrCreateFilterFolders(ReferenceOnEntityType type)
	{
		return LoadOrCreateFilterFolders(type, null);
	}

	[Auditable]
	public virtual ICollection<IFilterFolder> LoadOrCreateFilterFolders(ReferenceOnEntityType type, Guid? code, bool includeFavorites = false)
	{
		IEnumerable<IFilterFolder> enumerable = LoadSystemFilterFolders(type, code).Union(LoadOrCreateSharedFilterFolders(type, code)).Union(LoadOrCreateMyFilterFolders(type, code));
		if (includeFavorites)
		{
			enumerable = enumerable.Union(LoadOrCreateFavoriteFilterFolders(type, code));
		}
		return enumerable.ToArray();
	}

	[ContextCache(Region = "CR EleWise.ELMA.Common.Managers.FilterFolderManager")]
	public virtual bool HasSharedFilterPermission(IFilterFolder filter)
	{
		if (filter == null)
		{
			return false;
		}
		return ComponentManager.Current.GetExtensionPoints<IFilterPermissionResolver>().FirstOrDefault((IFilterPermissionResolver c) => c.FilterType == FilterType.SharedFilter && c.SupportedType(filter))?.HasPermission(filter) ?? false;
	}

	[Auditable]
	public virtual IFilterFolder GetDefaultFilterFolder(ReferenceOnEntityType type)
	{
		return GetDefaultFilterFolder(type, null);
	}

	[Auditable]
	public virtual IFilterFolder GetDefaultFilterFolder(ReferenceOnEntityType type, Guid? code)
	{
		return LoadOrCreateMyFilterFolders(type, code).First((IFilterFolder folder) => folder.ParentFolder == null);
	}

	public void SetPermissionByFilter(ICriteria criteria)
	{
		EleWise.ELMA.Security.Models.IUser currentUser = Locator.GetService<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		if (currentUser != null)
		{
			SqlSubQuery sqlSubQuery = base.Session.CreateSQLSubQuery("select p.FilterObj from FilterPermission p\r\n                                    inner join UserSecuritySetCache c on p.UserSecuritySetCacheId = c.SetId\r\n                                    where c.UserId = :userId and p.PermissionId = :permissionId").SetParameter("userId", currentUser.Id).SetParameter("permissionId", PermissionProvider.FilterViewPermission.Id);
			ITransformationProvider service = Locator.GetService<ITransformationProvider>();
			criteria.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Eq(base.EntityTypeUidPropertyName, (object)InterfaceActivator.UID<IFilterFolder>()), (ICriterion)(object)Expression.Sql(string.Format("{{alias}}.{0} in ({1})", (service != null) ? service.Dialect.QuoteIfNeeded("Id") : "Id", sqlSubQuery.Sql), sqlSubQuery.ParametersValues, sqlSubQuery.ParametersTypes)));
		}
	}

	[ContextCache(Region = "CR EleWise.ELMA.Common.Managers.FilterFolderManager")]
	public virtual ICollection<IFilterFolder> LoadAllUsersFilterFolders(ReferenceOnEntityType type, Guid? code)
	{
		ICriteria val = CreateCriteria(null, InterfaceActivator.TypeOf<IFilterFolder>());
		val.Add((ICriterion)(object)Restrictions.In("ObjectsType", Types(type)));
		val.Add((ICriterion)(object)Restrictions.Eq("FilterType", (object)FilterType.MyFilter));
		if (code.HasValue)
		{
			val.Add((ICriterion)(object)Restrictions.Eq("Code", (object)code.Value));
		}
		return val.List<IFilterFolder>();
	}

	public virtual ICollection<IFilterFolder> LoadMyFilterFolders(ReferenceOnEntityType type)
	{
		return LoadMyFilterFolders(type, null);
	}

	[ContextCache(Region = "CR EleWise.ELMA.Common.Managers.FilterFolderManager")]
	public virtual ICollection<IFilterFolder> LoadMyFilterFolders(ReferenceOnEntityType type, Guid? code)
	{
		ICriteria val = CreateCriteria(null, InterfaceActivator.TypeOf<IFilterFolder>());
		val.Add((ICriterion)(object)Restrictions.In("ObjectsType", Types(type)));
		val.Add((ICriterion)(object)Restrictions.Eq("FilterType", (object)FilterType.MyFilter));
		val.Add((ICriterion)(object)Restrictions.Eq("CreationAuthor", (object)EleWise.ELMA.Security.Services.AuthenticationService.GetCurrentUser()));
		if (code.HasValue)
		{
			val.Add((ICriterion)(object)Restrictions.Eq("Code", (object)code.Value));
		}
		SetPermissionByFilter(val);
		return val.List<IFilterFolder>();
	}

	[ContextCache(Region = "CR EleWise.ELMA.Common.Managers.FilterFolderManager")]
	public virtual IFilterFolder LoadMyFilterFolder(ReferenceOnEntityType type, Guid? code)
	{
		ICriteria val = CreateCriteria(null, InterfaceActivator.TypeOf<IFilterFolder>());
		val.Add((ICriterion)(object)Restrictions.IsNull("ParentFolder"));
		val.Add((ICriterion)(object)Restrictions.In("ObjectsType", Types(type)));
		val.Add((ICriterion)(object)Restrictions.Eq("FilterType", (object)FilterType.MyFilter));
		val.Add((ICriterion)(object)Restrictions.Eq("CreationAuthor", (object)EleWise.ELMA.Security.Services.AuthenticationService.GetCurrentUser()));
		if (code.HasValue)
		{
			val.Add((ICriterion)(object)Restrictions.Eq("Code", (object)code.Value));
		}
		SetPermissionByFilter(val);
		return val.List<IFilterFolder>().FirstOrDefault();
	}

	public virtual ICollection<IFilterFolder> LoadOrCreateMyFilterFolders(ReferenceOnEntityType type)
	{
		return LoadOrCreateMyFilterFolders(type, null);
	}

	[ContextCache(Region = "CR EleWise.ELMA.Common.Managers.FilterFolderManager")]
	public virtual ICollection<IFilterFolder> LoadOrCreateMyFilterFolders(ReferenceOnEntityType type, Guid? code)
	{
		lock (this)
		{
			ICollection<IFilterFolder> collection = LoadMyFilterFolders(type, code);
			if (!collection.Any())
			{
				InstanceOf<IFilterFolder> instanceOf = new InstanceOf<IFilterFolder>();
				instanceOf.New.Name = SR.T("Мои фильтры");
				instanceOf.New.ObjectsType = type;
				instanceOf.New.FilterType = FilterType.MyFilter;
				instanceOf.New.Code = code;
				IFilterFolder @new = instanceOf.New;
				@new.Save();
				collection.Add(@new);
			}
			return collection;
		}
	}

	public virtual IFilterFolder LoadOrCreateMyFilterFolder(ReferenceOnEntityType type, Guid? code = null)
	{
		return LoadOrCreateMyFilterFolder(type, SR.T("Мои фильтры"), code);
	}

	[ContextCache(Region = "CR EleWise.ELMA.Common.Managers.FilterFolderManager")]
	public virtual IFilterFolder LoadOrCreateMyFilterFolder(ReferenceOnEntityType type, string createName, Guid? code = null)
	{
		lock (this)
		{
			IFilterFolder filterFolder = LoadMyFilterFolder(type, code);
			if (filterFolder == null)
			{
				InstanceOf<IFilterFolder> instanceOf = new InstanceOf<IFilterFolder>();
				instanceOf.New.Name = createName;
				instanceOf.New.ObjectsType = type;
				instanceOf.New.FilterType = FilterType.MyFilter;
				instanceOf.New.Code = code;
				filterFolder = instanceOf.New;
				filterFolder.Save();
			}
			return filterFolder;
		}
	}

	[Transaction]
	public virtual void ChangeFolderType(IFilterFolder folder, FilterType type)
	{
		folder.FilterType = type;
		folder.CreationAuthor = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		foreach (IFilterFolder item in (IEnumerable<IFilterFolder>)folder.SubFolders)
		{
			ChangeFolderType(item, type);
		}
		folder.Save();
		CacheService.ClearRegion("CR EleWise.ELMA.Common.Managers.FilterFolderManager");
	}

	public void CheckMoveAvaliable(IFilterFolder folder, IFilterFolder destinationFolder, Dictionary<IFilterFolder, string> res)
	{
		ISecurityService service = Locator.GetService<ISecurityService>();
		if (folder.CastAsRealType() is IFilter && !service.HasPermission(PermissionProvider.FilterFullAccessPermission, folder) && folder.FilterType == FilterType.SharedFilter && folder.FilterType != destinationFolder.FilterType)
		{
			res.Add(folder, SR.T("Для осуществления операции перемещения фильтров из \"Общие фильтры\" в \"Мои фильтры\" нужны полные права на \"{0}\"", folder.Name));
		}
		else
		{
			if (res.Count != 0)
			{
				return;
			}
			foreach (IFilterFolder item in (IEnumerable<IFilterFolder>)folder.SubFolders)
			{
				CheckMoveAvaliable(item, destinationFolder, res);
			}
		}
	}

	[ContextCache(Region = "CR EleWise.ELMA.Common.Managers.FilterFolderManager")]
	public virtual bool HasEditPermission(long filterId)
	{
		IFilterFolder filterFolder = Instance.Load(filterId).CastAsRealType();
		if (filterFolder is IFilter)
		{
			if (!base.SecurityService.HasPermission(PermissionProvider.FilterEditPermission, filterFolder))
			{
				return base.SecurityService.HasPermission(PermissionProvider.FilterFullAccessPermission, filterFolder);
			}
			return true;
		}
		return true;
	}

	[PublicApiMember]
	public override void Delete(IFilterFolder obj)
	{
		base.Delete(obj);
		CacheService.ClearRegion("CR EleWise.ELMA.Common.Managers.FilterFolderManager");
	}

	[Cache]
	public virtual Pair<Guid, Guid?> GetFilterTypeCode(long? Id)
	{
		IFilter filter = CreateCriteria(new Filter
		{
			DisableSecurity = true
		}).Add((ICriterion)(object)Restrictions.Eq("Id", (object)Id)).UniqueResult<IFilter>();
		return new Pair<Guid, Guid?>(filter.ObjectsType.TypeUid, filter.Code);
	}

	[Auditable]
	public virtual ICollection<IFilterFolder> LoadFavoriteFilters(ReferenceOnEntityType type)
	{
		return LoadFavoriteFilters(type, null);
	}

	[Auditable]
	[ContextCache(Region = "CR EleWise.ELMA.Common.Managers.FilterFolderManager")]
	public virtual ICollection<IFilterFolder> LoadFavoriteFilters(ReferenceOnEntityType type, Guid? code)
	{
		ICriteria val = CreateCriteria(null, InterfaceActivator.TypeOf<IFilterFolder>());
		val.Add((ICriterion)(object)Restrictions.In("ObjectsType", Types(type)));
		val.Add((ICriterion)(object)Restrictions.Eq("FilterType", (object)FilterType.FavoriteFilter));
		val.Add((ICriterion)(object)Restrictions.Eq("CreationAuthor", (object)EleWise.ELMA.Security.Services.AuthenticationService.GetCurrentUser()));
		if (code.HasValue)
		{
			val.Add((ICriterion)(object)Restrictions.Eq("Code", (object)code.Value));
		}
		SetPermissionByFilter(val);
		return val.List<IFilterFolder>();
	}

	[ContextCache(Region = "CR EleWise.ELMA.Common.Managers.FilterFolderManager")]
	public virtual IFilterFolder LoadFavoriteFilterFolder(ReferenceOnEntityType type, Guid? code)
	{
		ICriteria val = CreateCriteria(null, InterfaceActivator.TypeOf<IFilterFolder>());
		val.Add((ICriterion)(object)Restrictions.IsNull("ParentFolder"));
		val.Add((ICriterion)(object)Restrictions.In("ObjectsType", Types(type)));
		val.Add((ICriterion)(object)Restrictions.Eq("FilterType", (object)FilterType.FavoriteFilter));
		val.Add((ICriterion)(object)Restrictions.Eq("CreationAuthor", (object)EleWise.ELMA.Security.Services.AuthenticationService.GetCurrentUser()));
		if (code.HasValue)
		{
			val.Add((ICriterion)(object)Restrictions.Eq("Code", (object)code.Value));
		}
		SetPermissionByFilter(val);
		return val.List<IFilterFolder>().FirstOrDefault();
	}

	public virtual ICollection<IFilterFolder> LoadOrCreateFavoriteFilterFolders(ReferenceOnEntityType type)
	{
		return LoadOrCreateFavoriteFilterFolders(type, null);
	}

	[ContextCache(Region = "CR EleWise.ELMA.Common.Managers.FilterFolderManager")]
	public virtual ICollection<IFilterFolder> LoadOrCreateFavoriteFilterFolders(ReferenceOnEntityType type, Guid? code)
	{
		lock (this)
		{
			ICollection<IFilterFolder> collection = LoadFavoriteFilters(type, code);
			if (!collection.Any())
			{
				InstanceOf<IFilterFolder> instanceOf = new InstanceOf<IFilterFolder>();
				instanceOf.New.Name = SR.T("Избранные фильтры");
				instanceOf.New.ObjectsType = type;
				instanceOf.New.FilterType = FilterType.FavoriteFilter;
				instanceOf.New.Code = code;
				IFilterFolder @new = instanceOf.New;
				@new.Save();
				collection.Add(@new);
			}
			return collection;
		}
	}

	public virtual IFilterFolder LoadOrCreateFavoriteFilterFolder(ReferenceOnEntityType type, Guid? code = null)
	{
		return LoadOrCreateFavoriteFilterFolder(type, SR.T("Избранные фильтры"), code);
	}

	[ContextCache(Region = "CR EleWise.ELMA.Common.Managers.FilterFolderManager")]
	public virtual IFilterFolder LoadOrCreateFavoriteFilterFolder(ReferenceOnEntityType type, string createName, Guid? code = null)
	{
		lock (this)
		{
			IFilterFolder filterFolder = LoadFavoriteFilterFolder(type, code);
			if (filterFolder == null)
			{
				InstanceOf<IFilterFolder> instanceOf = new InstanceOf<IFilterFolder>();
				instanceOf.New.Name = createName;
				instanceOf.New.ObjectsType = type;
				instanceOf.New.FilterType = FilterType.FavoriteFilter;
				instanceOf.New.Code = code;
				filterFolder = instanceOf.New;
				filterFolder.Save();
			}
			return filterFolder;
		}
	}
}
