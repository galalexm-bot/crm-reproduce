using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.Settings;

namespace EleWise.ELMA.Web.Mvc.Controllers;

public class GlobalSettingsController : BaseController
{
	public IEnumerable<IGlobalSettingsModuleController> GlobalSettingsModules { get; set; }

	[HttpPost]
	public JsonResult Save(Guid? moduleUid)
	{
		if (!moduleUid.HasValue)
		{
			return ((Controller)this).Json((object)new
			{
				success = false,
				reason = SR.T("Неправильно задан идентификатор модуля")
			});
		}
		if (GlobalSettingsModules == null)
		{
			return ((Controller)this).Json((object)new
			{
				success = false,
				reason = SR.T("Невозможно получить список доступных модулей для сохранения настроек")
			});
		}
		IGlobalSettingsModuleController globalSettingsModuleController = GlobalSettingsModules.FirstOrDefault(delegate(IGlobalSettingsModuleController c)
		{
			Guid moduleGuid = c.Module.ModuleGuid;
			Guid? guid = moduleUid;
			return moduleGuid == guid;
		});
		if (globalSettingsModuleController == null)
		{
			return ((Controller)this).Json((object)new
			{
				success = false,
				reason = SR.T("Невозможно найти модуль с идентификатором {0}", moduleUid)
			});
		}
		Permission permission = ((globalSettingsModuleController.Module is IGlobalSettingsModulePermission) ? ((IGlobalSettingsModulePermission)globalSettingsModuleController.Module).AdminPermission : CommonPermissions.AdminPermission);
		CheckPermission(permission);
		try
		{
			if (!((Controller)this).TryUpdateModel<object>(globalSettingsModuleController.Module.Settings))
			{
				IEnumerable<ModelError> source = ((Controller)this).get_ModelState().get_Values().SelectMany((ModelState e) => (IEnumerable<ModelError>)e.get_Errors());
				return ((Controller)this).Json((object)new
				{
					success = false,
					reason = string.Join("\n", source.Select((ModelError e) => (e.get_Exception() != null) ? e.get_Exception().Message : e.get_ErrorMessage()))
				});
			}
			GlobalSettingsSaveResult globalSettingsSaveResult = globalSettingsModuleController.SaveSettings(((ControllerBase)this).get_ControllerContext());
			if (globalSettingsSaveResult != null && !globalSettingsSaveResult.Success)
			{
				return ((Controller)this).Json((object)new
				{
					success = false,
					reason = globalSettingsSaveResult.ErrorMessage
				});
			}
			return ((Controller)this).Json((object)new
			{
				success = true,
				reason = SR.T("Настройки успешно сохранены")
			});
		}
		catch (Exception ex)
		{
			base.Logger.Error(SR.T("Ошибка при сохранении настроек системы"), ex);
			return ((Controller)this).Json((object)new
			{
				success = false,
				reason = SR.T("Ошибка при сохранении настроек системы: {0}", ex.Message)
			});
		}
	}

	public ActionResult Edit(Guid? moduleUid)
	{
		if (!moduleUid.HasValue)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				reason = SR.T("Неправильно задан идентификатор модуля")
			});
		}
		if (GlobalSettingsModules == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				reason = SR.T("Невозможно получить список доступных модулей для сохранения настроек")
			});
		}
		IGlobalSettingsModuleController globalSettingsModuleController = GlobalSettingsModules.FirstOrDefault(delegate(IGlobalSettingsModuleController c)
		{
			Guid moduleGuid = c.Module.ModuleGuid;
			Guid? guid = moduleUid;
			return moduleGuid == guid;
		});
		if (globalSettingsModuleController == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				reason = SR.T("Невозможно найти модуль с идентификатором {0}", moduleUid)
			});
		}
		Permission permission = ((globalSettingsModuleController.Module is IGlobalSettingsModulePermission) ? ((IGlobalSettingsModulePermission)globalSettingsModuleController.Module).AdminPermission : CommonPermissions.AdminPermission);
		CheckPermission(permission);
		return (ActionResult)(object)((Controller)this).PartialView("Templates/GlobalSettingsRenderEdit", (object)globalSettingsModuleController);
	}
}
