using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Service.v1.AdministrationService.Models;

namespace EleWise.ELMA.Web.Service.v1.AdministrationService;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceKnownType("GetGlobalKnownTypes", typeof(ServiceKnownTypeHelper))]
[Component]
[Uid("{F610F50C-B7D3-44D6-9D84-6E9430B1D3A5}")]
internal sealed class AdministrationService : IAdministrationService, IInternalAPIWebService
{
	private const string GuidS = "{F610F50C-B7D3-44D6-9D84-6E9430B1D3A5}";

	private static ISecurityService securityService;

	private static IEnumerable<IGlobalSettingsModuleController> globalSettingsModules;

	private static ISecurityService SecurityService => securityService ?? (securityService = Locator.GetServiceNotNull<ISecurityService>());

	private static IEnumerable<IGlobalSettingsModuleController> GlobalSettingsModules => globalSettingsModules ?? (globalSettingsModules = Locator.GetServiceNotNull<IEnumerable<IGlobalSettingsModuleController>>());

	public IGlobalSettingsModuleInfo[] GetGlobalSettingsModuleInfo()
	{
		CheckPermissions(CommonPermissions.AdminPermission);
		IGlobalSettingsModule[] array = (from g in GlobalSettingsModules
			where g.Visible
			select g.Module).ToArray();
		int num = array.Length;
		IGlobalSettingsModuleInfo[] array2 = new IGlobalSettingsModuleInfo[num];
		for (int i = 0; i < num; i++)
		{
			IGlobalSettingsModule globalSettingsModule = array[i];
			GlobalSettingsModuleInfo globalSettingsModuleInfo = (GlobalSettingsModuleInfo)(array2[i] = new GlobalSettingsModuleInfo
			{
				Uid = globalSettingsModule.ModuleGuid,
				DisplayName = globalSettingsModule.ModuleName
			});
		}
		return array2;
	}

	public IModuleGlobalSettings GetModuleGlobalSettings(ModuleSettingsParameters moduleSettingsParameters)
	{
		CheckPermissions(CommonPermissions.AdminPermission);
		if (moduleSettingsParameters == null)
		{
			return null;
		}
		Guid moduleUid = moduleSettingsParameters.Module;
		IGlobalSettingsModuleController globalSettingsModuleController = GlobalSettingsModules.FirstOrDefault((IGlobalSettingsModuleController a) => a.Module.ModuleGuid == moduleUid);
		if (globalSettingsModuleController == null)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не найден модуль настроек с указанным идентификатором {0}", moduleUid), 400);
		}
		IGlobalSettingsModule module = globalSettingsModuleController.Module;
		if (module is IGlobalSettingsModulePermission globalSettingsModulePermission)
		{
			CheckPermissions(globalSettingsModulePermission.AdminPermission);
		}
		if (!(module.Settings is GlobalSettingsBase globalSettingsBase))
		{
			return null;
		}
		IDictionary<string, string> values = globalSettingsBase.GetStorageValues();
		string[] array = moduleSettingsParameters.Settings;
		if (array == null || array.Length == 0)
		{
			array = values.Keys.ToArray();
		}
		string value;
		Settings[] array2 = (from p in array
			select values.TryGetValue(p, out value) ? new Settings(p, value) : null into a
			where a != null
			select a).ToArray();
		ModuleGlobalSettings moduleGlobalSettings = new ModuleGlobalSettings();
		ISettings[] array4 = (moduleGlobalSettings.Settings = array2);
		return moduleGlobalSettings;
	}

	private void CheckPermissions(Permission permission)
	{
		if (!SecurityService.HasPermission(permission))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Отсутствуют права доступа \"{0}\"", permission.Name), 401);
		}
	}
}
