using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Tasks.Components;

public static class WorkLogExtensionHelper
{
	private sealed class WorkLogObjectLoader
	{
		public IEntity LoadObjectCache(long objectId, Guid objectUid)
		{
			return ContextVars.GetOrAdd("EleWise.ELMA.Tasks.Components.WorkLogExtensionHelper" + objectId + objectUid, delegate
			{
				if (FindExtensionByObjectUid(objectUid) == null)
				{
					throw new Exception(SR.T("Нет точек расширения трудозатрат для объектов с Uid типа {0}.", objectUid));
				}
				IEntity entity = null;
				if (objectUid != Guid.Empty)
				{
					Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
					{
						IEntityManager entityManager = ModelHelper.GetEntityManager(ModelHelper.GetEntityType(objectUid));
						try
						{
							entity = (IEntity)entityManager.Load(objectId);
						}
						catch (ObjectIsDeletedException message)
						{
							Logger.Log.Error(message);
						}
					});
				}
				return entity;
			});
		}
	}

	private const string CacheKey = "EleWise.ELMA.Tasks.Components.WorkLogExtensionHelper";

	private const string WorkLogTypeSettingUid = "{9D63E5B8-A7FD-4D9F-9763-6BA8CD1A77FD}";

	private const string WorkLogExtensionRegion = "WorkLogExtensionRegion";

	private static IBLOBDataManager BLOBManager => DataAccessManager.BLOBManager;

	private static ICacheService CacheService => Locator.GetServiceNotNull<ICacheService>();

	public static IWorkLogExtension FindExtensionByObjectUid(Guid uid, bool enabled = false)
	{
		string key = $"WorkLogExtensionHelper.FindExtensionByObjectUid_{uid}_{enabled}";
		if (CacheService.TryGetValue<Guid>(key, "WorkLogExtensionRegion", out var value))
		{
			return FindExtensionByUid(value);
		}
		List<IWorkLogExtension> list = (from ext in ExtensionList()
			where ext.IsObjectUidContains(uid)
			select ext).ToList();
		if (enabled)
		{
			list = list.Where((IWorkLogExtension ext) => ext.IsObjectTypeEnabled(uid)).ToList();
		}
		IWorkLogExtension workLogExtension = ((list != null && list.Any()) ? list.First() : null);
		if (workLogExtension != null)
		{
			CacheService.Insert(key, workLogExtension.Uid, "WorkLogExtensionRegion");
		}
		return workLogExtension;
	}

	public static IWorkLogExtension FindExtensionByUid(Guid uid)
	{
		if (uid == Guid.Empty)
		{
			return null;
		}
		List<IWorkLogExtension> list = (from ext in ExtensionList()
			where ext.Uid == uid
			select ext).ToList();
		if (list == null || !list.Any())
		{
			return null;
		}
		return list.First();
	}

	public static List<IWorkLogExtension> ExtensionList()
	{
		return ComponentManager.Current.GetExtensionPoints<IWorkLogExtension>().ToList();
	}

	public static List<Guid> EnabledObjectTypes(this IWorkLogExtension extension)
	{
		string key = $"WorkLogExtensionHelper.EnabledObjectTypes_{extension.Uid}";
		if (CacheService.TryGetValue<List<Guid>>(key, "WorkLogExtensionRegion", out var value))
		{
			return value;
		}
		if (extension.ObjectUidList == null)
		{
			return new List<Guid>();
		}
		WorkLogExtensionSettings workLogExtensionSettings = extension.LoadSettings();
		if (workLogExtensionSettings.EnabledObjectsUids == null)
		{
			return new List<Guid>();
		}
		List<Guid> objectUidList = extension.ObjectUidList.ToList();
		value = workLogExtensionSettings.EnabledObjectsUids.Where((Guid u) => objectUidList.Any((Guid u2) => u2 == u)).ToList();
		if (value.Any())
		{
			CacheService.Insert(key, value, "WorkLogExtensionRegion");
		}
		return value;
	}

	public static bool IsObjectTypeEnabled(this IWorkLogExtension extension, Guid uid)
	{
		if (uid != Guid.Empty)
		{
			return extension.EnabledObjectTypes().Contains(uid);
		}
		return false;
	}

	public static WorkLogExtensionSettings LoadSettings(this IWorkLogExtension extension)
	{
		if (extension == null)
		{
			throw new ArgumentNullException();
		}
		try
		{
			return BLOBManager.GetBLOB<WorkLogExtensionSettings>(new Guid("{9D63E5B8-A7FD-4D9F-9763-6BA8CD1A77FD}"), extension.Uid.ToString()) ?? new WorkLogExtensionSettings
			{
				EnabledObjectsUids = extension.DefaultObjectsUidsList
			};
		}
		catch (Exception)
		{
			return new WorkLogExtensionSettings
			{
				EnabledObjectsUids = extension.DefaultObjectsUidsList
			};
		}
	}

	public static void SaveSettings(this IWorkLogExtension extension, WorkLogExtensionSettings settings)
	{
		CacheService.ClearRegion("WorkLogExtensionRegion");
		BLOBManager.SetBLOB(new Guid("{9D63E5B8-A7FD-4D9F-9763-6BA8CD1A77FD}"), extension.Uid.ToString(), settings);
	}

	public static bool IsObjectUidContains(this IWorkLogExtension extension, Guid objectUid)
	{
		return extension.ObjectUidList.Contains(objectUid);
	}

	public static IEntity LoadObject(IWorkLogItem workLogItem)
	{
		if (workLogItem == null || workLogItem.ObjectId == 0L)
		{
			return null;
		}
		return LoadObject(workLogItem.ObjectId, workLogItem.ObjectUID);
	}

	public static IEntity LoadObject(long objectId, Guid objectUid)
	{
		return new WorkLogObjectLoader().LoadObjectCache(objectId, objectUid);
	}

	public static string GetObjectDisplayName(IWorkLogItem workLogItem)
	{
		if (workLogItem != null)
		{
			return GetObjectDisplayName(workLogItem.ObjectId, workLogItem.ObjectUID);
		}
		return "";
	}

	public static string GetObjectDisplayName(long objectId, Guid objectUid)
	{
		IEntity entity = LoadObject(objectId, objectUid);
		if (entity == null)
		{
			return "";
		}
		return entity.ToString();
	}

	public static List<Guid> ObjectsUidEnabledList()
	{
		List<Guid> list = new List<Guid>();
		foreach (List<Guid> item in from ext in ExtensionList()
			select ext.EnabledObjectTypes())
		{
			list.AddRange(item);
		}
		return list;
	}

	public static EleWise.ELMA.Security.Models.IUser DefaultHarmonizator()
	{
		EleWise.ELMA.Security.Models.IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		TaskControlSettingsModel taskControlSettingsModel = ((currentUser != null) ? PersonalizationAdministration.LoadState<TaskControlSettingsModel>(currentUser.UserName, "UserTaskControlSettings") : null);
		if (taskControlSettingsModel != null && taskControlSettingsModel.WorkLogHarmonizator != null)
		{
			return taskControlSettingsModel.WorkLogHarmonizator;
		}
		return null;
	}

	public static EleWise.ELMA.Security.Models.IUser DefaultHarmonizator(Guid objectUid, long objectId)
	{
		IWorkLogExtension workLogExtension = FindExtensionByObjectUid(objectUid, enabled: true);
		if (workLogExtension != null)
		{
			IEntity entity = LoadObject(objectId, objectUid);
			if (entity != null)
			{
				return workLogExtension.DefaultHarmonizator(entity);
			}
		}
		return DefaultHarmonizator();
	}

	public static string GetObjectDisplayTypeName(Guid objectUid)
	{
		string result = "";
		if (objectUid != Guid.Empty)
		{
			Type entityType = ModelHelper.GetEntityType(objectUid);
			if (entityType != null && InterfaceActivator.LoadMetadata(entityType) is ClassMetadata classMetadata)
			{
				result = classMetadata.DisplayName;
			}
		}
		return result;
	}
}
