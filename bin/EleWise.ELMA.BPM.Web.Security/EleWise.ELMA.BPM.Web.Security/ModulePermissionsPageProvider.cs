using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.BPM.Web.Security.Security;

[Component(Order = 10)]
public class ModulePermissionsPageProvider : IModulePermissionsPageProvider, IModuleSettingsPageProvider
{
	public string ModuleUid => "EleWise.ELMA.BPM.Web.Security";

	public string Image => "#global_permissions.svg";

	public string Text => SR.T("Глобальные настройки доступа");

	public string Description => SR.T("Полный перечень прав доступа к функциям пользовательского интерфейса, которые реализованы в системе. В данном разделе Вы можете предоставить или убрать право доступа к функциям системы для системной группы (роли).<br><b>Примечание</b>: Кроме данных настроек есть настройки доступа к объектам модулей (бизнес-процессам, документам и т.д.) – смотрите соответствующие разделы в левом меню.");

	public string Url(UrlHelper urlHelper)
	{
		return urlHelper.Action("GlobalPermissions", "PermissionManagment");
	}
}
