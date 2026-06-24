using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Modules.Impl;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using NHibernate;

namespace EleWise.ELMA.UIBuilder.Services;

[Service]
internal sealed class ModuleMetadataLoader : IModuleMetadataLoader
{
	private const string VersionKeyPrefix = "ModuleVersion";

	private const string DefaultsKeyPrefix = "DefaultModuleVersion";

	private const string HeadersKeyPrefix = "ModuleVersionHeader";

	private readonly ModuleMetadataItemHeaderManager headerManager;

	private readonly ModuleMetadataItemManager itemManager;

	private readonly ISessionProvider sessionProvider;

	private readonly IMemoryCacheService cacheService;

	private readonly IContextBoundVariableService contextBoundVariableService;

	private IModuleManager ModuleManager => ComponentManager.Current.ModuleManager;

	private ISession Session => sessionProvider.GetSession(string.Empty);

	private IMetadataService MetadataService => MetadataServiceContext.Service;

	public ModuleMetadataLoader(ModuleMetadataItemHeaderManager headerManager, ModuleMetadataItemManager itemManager, ISessionProvider sessionProvider, IMemoryCacheService cacheService, IContextBoundVariableService contextBoundVariableService)
	{
		this.headerManager = headerManager;
		this.itemManager = itemManager;
		this.sessionProvider = sessionProvider;
		this.cacheService = cacheService;
		this.contextBoundVariableService = contextBoundVariableService;
	}

	public ModuleVersion GetDefaultModuleVersion(Guid moduleUid, bool published)
	{
		return GetDefaultModuleVersionInternal(moduleUid, published);
	}

	public ModuleVersion GetSpecificModuleVersion(Guid moduleUid, Guid versionUid)
	{
		if (TryGetCached(moduleUid, versionUid, out var version))
		{
			return version;
		}
		ModuleMetadataItem moduleMetadataItem = itemManager.LoadOrNull(versionUid);
		if (moduleMetadataItem == null)
		{
			version = GetDefaultModuleVersion(moduleUid, published: true);
			if (version.Header.VersionUid == versionUid)
			{
				return version;
			}
			throw new ModuleNotFoundException(moduleUid, SR.T("Не найдена версия {0} модуля {1}", versionUid, moduleUid));
		}
		ModuleInfoMetadata moduleInfoMetadata = (ModuleInfoMetadata)moduleMetadataItem.Metadata;
		if (moduleInfoMetadata == null || moduleInfoMetadata.Uid != moduleUid)
		{
			throw new ModuleNotFoundException(moduleUid, SR.T("Не найдена версия {0} модуля {1}", versionUid, moduleUid));
		}
		version = ModuleVersion.FromItem(moduleMetadataItem);
		ToCache(version);
		return version;
	}

	public IReadOnlyCollection<ModuleVersionHeader> GetModuleVersionHeaders(Guid moduleUid, bool published)
	{
		IReadOnlyCollection<ModuleVersionHeader> orAddHeaders = GetOrAddHeaders(moduleUid, () => LoadHeadersFromDB(moduleUid));
		ModuleVersion moduleVersion = LoadFromModuleManager(moduleUid, published);
		return (from h in orAddHeaders.Concat(new ModuleVersionHeader[1] { moduleVersion?.Header })
			where h != null
			orderby h.Version descending
			select h).ToList();
	}

	[Obsolete("TODO: ELMA4-6475 Убрать после оптимизации загрузки модулей для поиска точек расширения и реализаций", false)]
	public IReadOnlyCollection<ModuleVersion> GetAllDefaultVersions(IEnumerable<Guid> excluded, bool published)
	{
		List<ModuleVersion> list = itemManager.GetLastPublished(excluded ?? Enumerable.Empty<Guid>()).Select(ModuleVersion.FromItem).ToList();
		list.ForEach(ToCache);
		return list;
	}

	public IEnumerable<ModuleMetadataItemWrapper> GetLastPublishedHeaders(IEnumerable<Guid> notLoaded)
	{
		return itemManager.GetLastPublishedHeaders(notLoaded ?? Enumerable.Empty<Guid>()).ToList();
	}

	public bool IsSystemModule(Guid moduleUid)
	{
		return ModuleManager.FindUnitByUid(moduleUid) is IModule;
	}

	private ModuleVersion GetDefaultModuleVersionInternal(Guid moduleUid, bool enabled)
	{
		if (moduleUid == Guid.Empty)
		{
			throw new ModuleNotFoundException(moduleUid, SR.T("Данный идентификатор модуля соответствует текущей конфигурации"));
		}
		return (enabled ? GetOrAddDefaults(moduleUid, () => LoadFromDB(moduleUid, enabled) ?? LoadFromModuleManager(moduleUid, enabled)) : (LoadFromDB(moduleUid, enabled) ?? LoadFromModuleManager(moduleUid, enabled))) ?? throw new ModuleNotFoundException(moduleUid);
	}

	private ModuleVersion LoadFromDB(Guid moduleUid, bool published)
	{
		ModuleMetadataItemHeader moduleMetadataItemHeader = headerManager.LoadOrNull(moduleUid);
		if (moduleMetadataItemHeader == null)
		{
			return null;
		}
		ModuleMetadataItem moduleMetadataItem = (published ? moduleMetadataItemHeader.Published : moduleMetadataItemHeader.Draft);
		if (moduleMetadataItem == null)
		{
			return null;
		}
		ModuleInfoMetadata metadata = (ModuleInfoMetadata)moduleMetadataItem.Metadata;
		if (!published)
		{
			LoadItemsToModule(metadata, moduleUid);
		}
		return ModuleVersion.FromItem(moduleMetadataItem);
	}

	private ModuleVersion LoadFromModuleManager(Guid moduleUid, bool enabled)
	{
		if (!(ModuleManager.FindUnitByUid(moduleUid) is Module module) || (module.Status != ModuleStatus.Enabled && enabled))
		{
			return null;
		}
		IModuleAssembly mainAssembly = module.MainAssembly;
		if (mainAssembly == null)
		{
			return null;
		}
		ModuleInfoMetadata moduleInfoMetadata = new ModuleInfoMetadata();
		moduleInfoMetadata.LoadFromAssembly(mainAssembly.Assembly);
		moduleInfoMetadata.Dependency = new ModuleDependency();
		return new ModuleVersion(moduleInfoMetadata, new ModuleVersionHeader(moduleInfoMetadata.GetSignature(), moduleInfoMetadata.Uid, module.Status, module.DisabledReason));
	}

	private void LoadItemsToModule(ModuleInfoMetadata metadata, Guid headerUid)
	{
		if (metadata.Components.Count + metadata.DataClasses.Count + metadata.Functions.Count <= 0)
		{
			List<ComponentMetadata> components = (from a in (from h in Session.Query<ComponentMetadataItemHeader>()
					where h.ModuleUid == headerUid
					select h.Draft).ToList()
				select (ComponentMetadata)a.Metadata).ToList();
			List<DataClassMetadata> dataClasses = (from d in (from h in Session.Query<DataClassMetadataItemHeader>()
					where h.ModuleUid == headerUid
					select h.Draft).ToList()
				select (DataClassMetadata)d.Metadata).ToList();
			List<FunctionMetadata> functions = (from f in (from h in Session.Query<FunctionMetadataItemHeader>()
					where h.ModuleUid == headerUid
					select h.Draft).ToList()
				select (FunctionMetadata)f.Metadata).ToList();
			metadata.Components = components;
			metadata.DataClasses = dataClasses;
			metadata.Functions = functions;
		}
	}

	private IReadOnlyCollection<ModuleVersionHeader> LoadHeadersFromDB(Guid moduleUid)
	{
		ModuleMetadataItemHeader moduleMetadataItemHeader = headerManager.LoadOrNull(moduleUid);
		if (moduleMetadataItemHeader == null)
		{
			return (IReadOnlyCollection<ModuleVersionHeader>)(object)Array.Empty<ModuleVersionHeader>();
		}
		var source = (from props in ((IQueryOver<ModuleMetadataItem>)(object)Session.QueryOver<ModuleMetadataItem>().Where((Expression<Func<ModuleMetadataItem, bool>>)((ModuleMetadataItem i) => i.Signature != null)).And((Expression<Func<ModuleMetadataItem, bool>>)((ModuleMetadataItem i) => i.AssemblyRaw != null))
				.JoinQueryOver<ModuleMetadataItemHeader>((Expression<Func<ModuleMetadataItem, ModuleMetadataItemHeader>>)((ModuleMetadataItem i) => i.Header))
				.Where((Expression<Func<ModuleMetadataItemHeader, bool>>)((ModuleMetadataItemHeader h) => h.Uid == moduleUid))
				.Select(new Expression<Func<ModuleMetadataItem, object>>[3]
				{
					(ModuleMetadataItem i) => i.Signature,
					(ModuleMetadataItem i) => i.Uid,
					(ModuleMetadataItem i) => i.Version
				})).List<object[]>()
			select new
			{
				Signature = (ModuleSignature)props[0],
				VersionUid = (Guid)props[1],
				VersionString = (string)props[2]
			}).ToList();
		Guid? draftUid = moduleMetadataItemHeader.Draft?.Uid;
		List<ModuleVersionHeader> list = new List<ModuleVersionHeader>();
		foreach (var item in source.Where(mi =>
		{
			Guid versionUid = mi.VersionUid;
			Guid? guid = draftUid;
			return versionUid != guid;
		}))
		{
			if (!Version.TryParse(item.VersionString, out var result))
			{
				result = ModuleVersionHeader.DefaultVersion;
			}
			list.Add(new ModuleVersionHeader(item.Signature, item.VersionUid, moduleUid, result, ModuleStatus.Enabled));
		}
		return list;
	}

	private void ToCache(ModuleVersion version)
	{
		cacheService.Insert(CacheKey(version.Header.HeaderUid, version.Header.VersionUid, "ModuleVersion"), version);
	}

	private bool TryGetCached(Guid headerUid, Guid versionUid, out ModuleVersion version)
	{
		return cacheService.TryGetValue<ModuleVersion>(CacheKey(headerUid, versionUid, "ModuleVersion"), out version);
	}

	private IReadOnlyCollection<ModuleVersionHeader> GetOrAddHeaders(Guid headerUid, Func<IReadOnlyCollection<ModuleVersionHeader>> versionFabric)
	{
		string name = CacheKey(headerUid, "ModuleVersionHeader");
		if (contextBoundVariableService.TryGetValue<IReadOnlyCollection<ModuleVersionHeader>>(name, out var value))
		{
			return value;
		}
		value = versionFabric();
		contextBoundVariableService.Set(name, value);
		return value;
	}

	private ModuleVersion GetOrAddDefaults(Guid headerUid, Func<ModuleVersion> versionFabric)
	{
		string name = CacheKey(headerUid, "DefaultModuleVersion");
		if (contextBoundVariableService.TryGetValue<ModuleVersion>(name, out var value))
		{
			return value;
		}
		value = versionFabric();
		if (value != null)
		{
			contextBoundVariableService.Set(name, value);
		}
		return value;
	}

	private static string CacheKey(Guid headerUid, Guid versionUid, string prefix)
	{
		return $"{prefix}{headerUid}{versionUid}";
	}

	private static string CacheKey(Guid uid, string prefix)
	{
		return $"{prefix}{uid}";
	}
}
