using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EleWise.ELMA.BPM.Web.Content.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Content.Models.Toolbar;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Constants;
using EleWise.ELMA.Content.ExtensionPoints;
using EleWise.ELMA.Content.Helpers;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Content.Extensions;

public static class WorkPlaceExtensions
{
	[Serializable]
	private class CustomizerSessionDataClass
	{
		public bool Enabled { get; set; }

		public long? CustomizatorId { get; set; }

		public long? WorkPlaceId { get; set; }
	}

	[Serializable]
	private class CustomizerItemsDataClass
	{
		public Guid? WorkPlaceTypeUid { get; set; }
	}

	private const string CustomizerSessionKey = "E02CB7AA-D3D6-4A2C-BCA9-A8EA6202CAB7";

	private const string CustomizerItemsKey = "1A98D1DC-7F51-4AFB-89B2-06F3F3E2B365";

	private const string MobileInterfaceQueryValue = "mobile";

	private static readonly ConcurrentDictionary<long, Pair<DateTime, ConcurrentDictionary<string, ToolbarTreeItemTransformation>>> ToolbarTransformations = new ConcurrentDictionary<long, Pair<DateTime, ConcurrentDictionary<string, ToolbarTreeItemTransformation>>>();

	private const string ToolbarTransformationsCacheKeyFormat = "ToolbarTransformations;{0}";

	private static CustomizerSessionDataClass CustomizerData
	{
		get
		{
			if (!SessionVars.Contains("E02CB7AA-D3D6-4A2C-BCA9-A8EA6202CAB7"))
			{
				return null;
			}
			return SessionVars.Get<CustomizerSessionDataClass>("E02CB7AA-D3D6-4A2C-BCA9-A8EA6202CAB7");
		}
		set
		{
			SessionVars.Set("E02CB7AA-D3D6-4A2C-BCA9-A8EA6202CAB7", value);
		}
	}

	private static CustomizerItemsDataClass ItemsCustomizerData
	{
		get
		{
			HttpContext current = HttpContext.Current;
			if (current == null)
			{
				return null;
			}
			IDictionary items = current.Items;
			if (!items.Contains("1A98D1DC-7F51-4AFB-89B2-06F3F3E2B365"))
			{
				items["1A98D1DC-7F51-4AFB-89B2-06F3F3E2B365"] = new CustomizerItemsDataClass();
			}
			return items["1A98D1DC-7F51-4AFB-89B2-06F3F3E2B365"] as CustomizerItemsDataClass;
		}
	}

	public static bool CustomizerEnabled
	{
		get
		{
			if (CustomizerData != null)
			{
				return CustomizerData.Enabled;
			}
			return false;
		}
		private set
		{
			if (CustomizerData == null)
			{
				CustomizerData = new CustomizerSessionDataClass
				{
					CustomizatorId = AuthenticationService.GetCurrentUser<IUser>().Id
				};
			}
			CustomizerData.Enabled = value;
		}
	}

	internal static long? CustomizatorId
	{
		get
		{
			if (CustomizerData == null)
			{
				return null;
			}
			return CustomizerData.CustomizatorId;
		}
	}

	internal static long? WorkPlaceId
	{
		get
		{
			if (CustomizerData == null)
			{
				return null;
			}
			return CustomizerData.WorkPlaceId;
		}
		private set
		{
			CustomizerData.WorkPlaceId = value;
		}
	}

	internal static Guid? WorkPlaceTypeUid
	{
		get
		{
			if (ItemsCustomizerData == null)
			{
				return null;
			}
			return ItemsCustomizerData.WorkPlaceTypeUid;
		}
		private set
		{
			if (ItemsCustomizerData != null)
			{
				ItemsCustomizerData.WorkPlaceTypeUid = value;
			}
		}
	}

	internal static object Data => CustomizerData;

	private static ICacheService CacheService => Locator.GetServiceNotNull<ICacheService>();

	public static IWorkPlace GetCurrentWorkPlace(bool loadDefaultWorkPlace = false)
	{
		if (WorkPlaceId.HasValue)
		{
			IWorkPlace workPlace = WorkPlaceManager.Instance.Load(WorkPlaceId.Value);
			if (!loadDefaultWorkPlace && !(workPlace.Uid != WorkPlaceManager.DefaultWorkPlaceUid))
			{
				return null;
			}
			return workPlace;
		}
		HttpContext current = HttpContext.Current;
		if (current != null)
		{
			string value = current.Request.QueryString["interface"];
			if ("lite".Equals(value, StringComparison.OrdinalIgnoreCase))
			{
				return WorkPlaceManager.Instance.LoadOrNull(WorkPlaceManager.LiteWorkPlaceUid);
			}
			if ("Mobile".Equals(value, StringComparison.OrdinalIgnoreCase))
			{
				IWorkPlace workPlace2 = WorkPlaceManager.Instance.LoadOrNull(WorkPlaceManager.MobileWorkPlaceUid);
				if (workPlace2 != null)
				{
					return workPlace2;
				}
				ICollection<IWorkPlace> source = WorkPlaceManager.Instance.Find((IWorkPlace x) => x.Type == MobileWorkPlaceTypeConst.Uid);
				if (source.Any())
				{
					return source.First();
				}
			}
		}
		IUser currentUser = AuthenticationService.GetCurrentUser<IUser>();
		if (currentUser != null)
		{
			return WorkPlaceManager.Instance.GetWorkPlaceByUser(currentUser.Id, loadDefaultWorkPlace);
		}
		return null;
	}

	public static IWorkPlaceType GetCurrentWorkPlaceType()
	{
		if (WorkPlaceTypeUid.HasValue)
		{
			return WorkPlaceManager.Instance.GetWorkPlaceType(WorkPlaceTypeUid.Value);
		}
		HttpContext current = HttpContext.Current;
		if (current != null)
		{
			string pageInterface = current.Request.QueryString["interface"];
			if (pageInterface != null)
			{
				IWorkPlaceType workPlaceType = ComponentManager.Current.GetExtensionPoints<IWorkPlaceType>().FirstOrDefault((IWorkPlaceType wpt) => pageInterface.Equals(wpt.Folder, StringComparison.OrdinalIgnoreCase));
				if (workPlaceType != null)
				{
					return workPlaceType;
				}
			}
		}
		return GetCurrentWorkPlace(loadDefaultWorkPlace: true).GetWorkPlaceType();
	}

	public static IMenu GetCurrentLeftMenu()
	{
		return GetCurrentMenu((IWorkPlace workPlace) => workPlace.LeftMenu, MenuManager.Instance.GetLeftMenuByUser, MenuManager.Instance.Load);
	}

	internal static IMenu GetCurrentLeftMenuReadOnly()
	{
		return GetCurrentMenu((IWorkPlace workPlace) => workPlace.LeftMenu, MenuManager.Instance.GetLeftMenuByUserReadOnly, MenuManager.Instance.LoadOrNullReadOnly);
	}

	public static IMenu GetCurrentStartMenu()
	{
		return GetCurrentMenu((IWorkPlace workPlace) => workPlace.StartMenu, MenuManager.Instance.GetStartMenuByUser, MenuManager.Instance.Load);
	}

	internal static IMenu GetCurrentStartMenuReadOnly()
	{
		return GetCurrentMenu((IWorkPlace workPlace) => workPlace.StartMenu, MenuManager.Instance.GetStartMenuByUserReadOnly, MenuManager.Instance.LoadOrNullReadOnly);
	}

	private static IMenu GetCurrentMenu(Func<IWorkPlace, IMenu> getMenu, Func<long, IMenu> getMenuByUser, Func<Guid, IMenu> load)
	{
		if (WorkPlaceId.HasValue)
		{
			return getMenu(WorkPlaceManager.Instance.Load(WorkPlaceId.Value));
		}
		IUser currentUser = AuthenticationService.GetCurrentUser<IUser>();
		return ((currentUser == null) ? null : getMenuByUser(currentUser.Id)) ?? load(MenuManager.LeftMenuUid);
	}

	public static IWebToolbar GetCurrentToolbar()
	{
		if (WorkPlaceId.HasValue)
		{
			return WorkPlaceManager.Instance.Load(WorkPlaceId.Value).Toolbar;
		}
		IUser currentUser = AuthenticationService.GetCurrentUser<IUser>();
		if (currentUser != null)
		{
			return WebToolbarManager.Instance.GetToolbarByUser(currentUser.Id);
		}
		return null;
	}

	public static IWorkplacePages GetCurrentWorkplacePages()
	{
		if (WorkPlaceId.HasValue)
		{
			return WorkPlaceManager.Instance.Load(WorkPlaceId.Value).WorkplacePages;
		}
		IUser currentUser = AuthenticationService.GetCurrentUser<IUser>();
		if (currentUser != null)
		{
			return WorkplacePagesManager.Instance.GetWorkplacePagesByUser(currentUser.Id);
		}
		return null;
	}

	public static bool CustomizableProfile()
	{
		if (CacheService.TryGetValue<bool>("AnyCustomizableUserPanelActions", out var value))
		{
			return value;
		}
		bool flag = ComponentManager.Current.GetExtensionPoints<ICurrentUserPanelAction>(useCache: true).OfType<ICurrentUserPanelActionDisable>().Any();
		CacheService.Insert("AnyCustomizableUserPanelActions", flag);
		return flag;
	}

	public static void SetWorkPlaceType(Guid uid)
	{
		WorkPlaceTypeUid = uid;
	}

	internal static void EnableCustomizer(object customizerData = null)
	{
		CustomizerData = customizerData as CustomizerSessionDataClass;
		CustomizerEnabled = true;
	}

	internal static void DisableCustomizer()
	{
		CustomizerEnabled = false;
		WorkPlaceId = null;
	}

	internal static void ChangeCustomizerWorkPlace(long workPlaceId)
	{
		WorkPlaceId = workPlaceId;
	}

	private static Pair<DateTime, ConcurrentDictionary<string, ToolbarTreeItemTransformation>> GetToolbarTransformations(IWebToolbar toolbar)
	{
		IEnumerable<ToolbarTreeItemTransformation> enumerable = ((toolbar != null) ? (toolbar.Transformations as IEnumerable<ToolbarTreeItemTransformation>) : null);
		ConcurrentDictionary<string, ToolbarTreeItemTransformation> second = ((enumerable != null) ? enumerable.ToConcurrentDictionary((ToolbarTreeItemTransformation i) => $"{i.VirtualPath};{i.Uid}") : new ConcurrentDictionary<string, ToolbarTreeItemTransformation>());
		return new Pair<DateTime, ConcurrentDictionary<string, ToolbarTreeItemTransformation>>(DateTime.Now, second);
	}

	internal static ToolbarTreeItemTransformation GetToolbarTransformation(string virtualPath, string toolbarUid, bool localize = false)
	{
		IWebToolbar toolbar = GetCurrentToolbar();
		if (toolbar == null)
		{
			return null;
		}
		ConcurrentDictionary<string, ToolbarTreeItemTransformation> second = ToolbarTransformations.AddOrUpdate(toolbar.Id, (long l) => GetToolbarTransformations(toolbar), delegate(long l, Pair<DateTime, ConcurrentDictionary<string, ToolbarTreeItemTransformation>> pair)
		{
			string key3 = $"ToolbarTransformations;{toolbar.Id}";
			DateTime value2;
			return (!(pair.First < (CacheService.TryGetValue<DateTime>(key3, out value2) ? value2 : DateTime.MinValue))) ? pair : GetToolbarTransformations(toolbar);
		}).Second;
		ToolbarTreeItemTransformation value = null;
		if (second != null)
		{
			string key = virtualPath + ";" + toolbarUid + ";" + SR.GetCurrentCulture();
			if (localize && second.TryGetValue(key, out value))
			{
				return value;
			}
			string key2 = virtualPath + ";" + toolbarUid;
			if (second.TryGetValue(key2, out value) && localize)
			{
				value = value.Clone();
				second.TryAdd(key, value);
			}
		}
		return value;
	}

	internal static void SetToolbarTransformation(IWebToolbar toolbar, string virtualPath, string toolbarUid, ToolbarTreeItemTransformation transformation)
	{
		Func<Pair<DateTime, ConcurrentDictionary<string, ToolbarTreeItemTransformation>>> addOrUpdate = delegate
		{
			List<ToolbarTreeItemTransformation> list = toolbar.Transformations as List<ToolbarTreeItemTransformation>;
			list?.RemoveAll((ToolbarTreeItemTransformation t) => t.VirtualPath == virtualPath && t.Uid == toolbarUid);
			if (transformation != null)
			{
				if (list == null)
				{
					list = new List<ToolbarTreeItemTransformation>();
				}
				transformation.VirtualPath = virtualPath;
				transformation.Uid = toolbarUid;
				list.Add(transformation);
			}
			toolbar.Transformations = list?.ToList();
			toolbar.Save();
			CacheService.Insert($"ToolbarTransformations;{toolbar.Id}", DateTime.Now);
			return GetToolbarTransformations(toolbar);
		};
		ToolbarTransformations.AddOrUpdate(toolbar.Id, (long l) => addOrUpdate(), (long l, Pair<DateTime, ConcurrentDictionary<string, ToolbarTreeItemTransformation>> pair) => addOrUpdate());
	}
}
