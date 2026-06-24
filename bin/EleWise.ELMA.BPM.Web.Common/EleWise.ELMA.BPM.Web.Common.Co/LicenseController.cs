using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Security;
using NuGet;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
public class LicenseController : BPMController
{
	public ICacheService CacheService { get; set; }

	public PackageService Service { get; set; }

	public static bool CanAddActivationKey => ContextVars.GetOrAdd("CanAddActivationKey", () => ComponentManager.Current.LicenseManager != null && ComponentManager.Current.LicenseManager.CanAddActivationKey());

	[ContentItem(Name = "SR.M('Компоненты')", Image24 = "#regicon.svg")]
	public ActionResult Index()
	{
		return (ActionResult)(object)((Controller)this).View((object)new ComponentsViewModel(Service.GetStoreComponentsInfo(forRuntime: true), null));
	}

	[HttpPost]
	public ActionResult Search([Bind(Prefix = "Filter")] ComponentsViewModel.ComponentsFilter filter)
	{
		return (ActionResult)(object)((Controller)this).PartialView("Index", (object)new ComponentsViewModel(Service.GetStoreComponentsInfo(forRuntime: true), filter));
	}

	public ActionResult ModulePopup(string componentId)
	{
		((ControllerBase)this).get_ViewData().Add("IsPopup", (object)true);
		return (ActionResult)(object)((Controller)this).PartialView("Item", (object)Service.GetStoreComponentsInfo(forRuntime: true).FirstOrDefault((IStoreComponentInfo c) => c.Id == componentId));
	}

	public ActionResult BPMLicenseInfo()
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)BPMLicenseViewModel.Current);
	}

	[HttpPost]
	public ActionResult AddActivationKey(string ActivationKey)
	{
		if (!string.IsNullOrEmpty(ActivationKey))
		{
			ComponentManager.Current.LicenseManager.AddActivationKey(ActivationKey);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	public ActionResult ActivateModule(Guid moduleUid)
	{
		ComponentManager.Current.ModuleManager.SaveModuleStatus(moduleUid, ModuleStatus.Enabled);
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	public ActionResult UpdateComponentsPopup(string componentId = null)
	{
		UpdateComponentsViewModel updateComponentsViewModel = new UpdateComponentsViewModel("UpdateComponents", Service.GetStoreComponentsInfo(forRuntime: true).Where(ToUpdateWithRestart));
		if (componentId != null)
		{
			updateComponentsViewModel.SelectedComponentIds = new string[1] { componentId };
		}
		return (ActionResult)(object)((Controller)this).PartialView("UpdateComponentsPopup", (object)updateComponentsViewModel);
	}

	public ActionResult UpdateComponents(Guid updatingUid, string[] componentIds)
	{
		return InstallComponents(updatingUid, componentIds);
	}

	public ActionResult InstallComponentsPopup(string componentId = null)
	{
		UpdateComponentsViewModel updateComponentsViewModel = new UpdateComponentsViewModel("InstallComponents", Service.GetStoreComponentsInfo(forRuntime: true).Where(ToInstallWithRestart));
		if (componentId != null)
		{
			updateComponentsViewModel.SelectedComponentIds = new string[1] { componentId };
		}
		return (ActionResult)(object)((Controller)this).PartialView("UpdateComponentsPopup", (object)updateComponentsViewModel);
	}

	public ActionResult InstallComponents(Guid updatingUid, string[] componentIds)
	{
		if (componentIds != null)
		{
			IEnumerable<IStoreComponentInfo> componentsInfo = from c in Service.GetStoreComponentsInfo(forRuntime: true)
				join s in componentIds on c.Id equals s
				select c;
			Service.InstallStoreComponents(componentsInfo, updatingUid, saveStatusToDb: true);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	[Obsolete("Метод утратил актуальность - не используйте его", true)]
	public ActionResult SoftInstallComponents(Guid updatingUid, string[] componentIds)
	{
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	[Obsolete("Метод утратил актуальность - не используйте его", true)]
	public ActionResult GetSoftUpdateStatus(Guid updatingUid)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return (ActionResult)new EmptyResult();
	}

	[Obsolete("Метод утратил актуальность - не используйте его", true)]
	public ActionResult GetLog(Guid updatingUid)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return (ActionResult)new EmptyResult();
	}

	public ActionResult ImportComponent(string componentId, string version)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		IElmaComponent component = Service.GetComponent();
		SemanticVersion componentVersion = new SemanticVersion(version);
		Stream stream = component.GetConfigurationStoreComponentsRepository().GetComponents().FirstOrDefault((ElmaStoreComponentFile c) => c.Id == componentId && c.Version == componentVersion)?.GetStream();
		if (stream == null)
		{
			((Controller)this).RedirectToAction("Index", "License");
		}
		Guid guid = base.CacheFilesService.CreateCacheFile(componentId + "." + version + ".elma4");
		using (stream)
		{
			base.CacheFilesService.IncrementCacheFile(guid, stream, 0L);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("ImportFile", "DeployImport", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common",
			fileUid = guid
		});
	}

	public ActionResult Restart()
	{
		if (CanAddActivationKey)
		{
			Locator.GetServiceNotNull<IWebHostEnvironmentService>().RestartHost();
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	public static bool IsInstalled(IStoreComponentInfo component)
	{
		if (component.IsInstalled)
		{
			if (component.Status != ModuleStatus.Enabled)
			{
				return component.Status == ModuleStatus.RestartRequired;
			}
			return true;
		}
		return false;
	}

	public static bool ToUpdate(IStoreComponentInfo component)
	{
		if (IsInstalled(component))
		{
			return !component.IsLatestVersionInstalled;
		}
		return false;
	}

	public static bool ToUpdateWithRestart(IStoreComponentInfo component)
	{
		if (ToUpdate(component))
		{
			return component.DoesInstallOrUpdateRequireRestart;
		}
		return false;
	}

	public static bool ToImport(IStoreComponentInfo component)
	{
		if (ToUpdate(component) || ToInstall(component))
		{
			return !component.DoesInstallOrUpdateRequireRestart;
		}
		return false;
	}

	public static bool ToInstall(IStoreComponentInfo component)
	{
		if (component.IsInstalled && component.DisabledReason != ModuleDisabledReason.DisabledManually)
		{
			return component.DisabledReason == ModuleDisabledReason.NotUsedInDb;
		}
		return true;
	}

	public static bool ToInstallWithRestart(IStoreComponentInfo component)
	{
		if (ToInstall(component))
		{
			return component.DoesInstallOrUpdateRequireRestart;
		}
		return false;
	}
}
