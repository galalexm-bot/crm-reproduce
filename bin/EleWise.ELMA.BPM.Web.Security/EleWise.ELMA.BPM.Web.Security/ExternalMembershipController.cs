using System;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Security.Settings;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Security.Controllers;

[RouteArea("EleWise.ELMA.BPM.Web.Security")]
[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
public class ExternalMembershipController : BPMController
{
	public IExternalMembershipManager ExternalMembershipManager { get; set; }

	public ActionResult AddModule()
	{
		return (ActionResult)(object)((Controller)this).PartialView("AddModule");
	}

	[HttpGet]
	public ActionResult CreatePopup(Guid? moduleUid)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		if (!moduleUid.HasValue)
		{
			return (ActionResult)new EmptyResult();
		}
		IExternalMembershipModule module = ExternalMembershipManager.GetModule(moduleUid.Value);
		if (module == null)
		{
			return (ActionResult)new EmptyResult();
		}
		IExternalMembershipModuleSettings externalMembershipModuleSettings = module.CreateDefaultSettings();
		if (externalMembershipModuleSettings == null)
		{
			return (ActionResult)new EmptyResult();
		}
		return (ActionResult)(object)((Controller)this).PartialView("EditPopup", (object)externalMembershipModuleSettings);
	}

	[HttpGet]
	public ActionResult EditPopup(Guid? instanceUid)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		if (!instanceUid.HasValue)
		{
			return (ActionResult)new EmptyResult();
		}
		IExternalMembershipModuleSettings externalMembershipModuleSettings = ExternalMembershipManager.LoadSettings(instanceUid.Value);
		if (externalMembershipModuleSettings == null)
		{
			return (ActionResult)new EmptyResult();
		}
		return (ActionResult)(object)((Controller)this).PartialView("EditPopup", (object)externalMembershipModuleSettings);
	}

	[HttpPost]
	public JsonResult SaveProviderSettings(IExternalMembershipModuleSettings model)
	{
		try
		{
			IExternalMembershipModuleSettings externalMembershipModuleSettings = ExternalMembershipManager.LoadSettings(model.InstanceUid);
			if (externalMembershipModuleSettings != null)
			{
				((Controller)this).TryUpdateModel<IExternalMembershipModuleSettings>(externalMembershipModuleSettings);
				ExternalMembershipManager.SaveSettings(externalMembershipModuleSettings);
			}
			else
			{
				ExternalMembershipManager.SaveSettings(model);
			}
		}
		catch (Exception ex)
		{
			return ((Controller)this).Json((object)new
			{
				success = false,
				reason = ex.Message
			});
		}
		return ((Controller)this).Json((object)new
		{
			success = true,
			reason = SR.T("Настройки успешно сохранены")
		});
	}

	public ActionResult ViewForm(Guid? instanceUid)
	{
		if (!instanceUid.HasValue)
		{
			return (ActionResult)(object)((Controller)this).PartialView((string)null);
		}
		IExternalMembershipModuleSettings externalMembershipModuleSettings = ExternalMembershipManager.LoadSettings(instanceUid.Value);
		return (ActionResult)(object)((Controller)this).PartialView((object)externalMembershipModuleSettings);
	}

	[HttpGet]
	public ActionResult ListView()
	{
		return (ActionResult)(object)((Controller)this).PartialView();
	}

	[HttpGet]
	public ActionResult ListEdit()
	{
		return (ActionResult)(object)((Controller)this).PartialView();
	}

	[CustomGridAction]
	public ActionResult List(GridCommand command, bool? canEdit)
	{
		GridData<IExternalMembershipModuleSettings> gridData = (from s in ExternalMembershipManager.GetAllSettings()
			where s.Module() != null
			orderby s.Module().Name, s.Name
			select s).CreateGridData();
		((ControllerBase)this).get_ViewData().set_Item("CanEdit", (object)(canEdit ?? false));
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	public JsonResult GetUserCount(Guid? instanceUid)
	{
		if (!instanceUid.HasValue)
		{
			return ((Controller)this).Json((object)new
			{
				success = false
			});
		}
		IUserFilter userFilter = InterfaceActivator.Create<IUserFilter>();
		userFilter.AuthProviderGuid = instanceUid.Value;
		long count = UserManager.Instance.Count(userFilter);
		var anon = new
		{
			success = true,
			count = count
		};
		return ((Controller)this).Json((object)anon, (JsonRequestBehavior)0);
	}

	public ActionResult UsersInInstance(Guid? instanceUid)
	{
		if (instanceUid.HasValue)
		{
			return (ActionResult)(object)((Controller)this).View((object)ExternalMembershipManager.LoadSettings(instanceUid.Value));
		}
		return (ActionResult)(object)((Controller)this).View();
	}

	[CustomGridAction]
	public ActionResult UsersInInstanceGrid(GridCommand command, Guid? instanceUid)
	{
		if (!instanceUid.HasValue)
		{
			return (ActionResult)(object)((Controller)this).PartialView((string)null);
		}
		IUserFilter userFilter = InterfaceActivator.Create<IUserFilter>();
		userFilter.AuthProviderGuid = instanceUid.Value;
		GridData<IUser, IUserFilter> gridData = UserManager.Instance.CreateGridData(command, userFilter);
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	[HttpPost]
	public JsonResult DeleteProviderSettings(Guid? moduleUid, Guid? instanceUid)
	{
		if (!instanceUid.HasValue || !moduleUid.HasValue)
		{
			return ((Controller)this).Json((object)new
			{
				success = false
			});
		}
		ExternalMembershipManager.DeleteSettings(moduleUid.Value, instanceUid.Value);
		var anon = new
		{
			success = true
		};
		return ((Controller)this).Json((object)anon, (JsonRequestBehavior)0);
	}
}
