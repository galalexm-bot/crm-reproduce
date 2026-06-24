using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.CRM.Web.Security;

[Component(Order = 50)]
public class ModulePermissionsPageProvider : IModulePermissionsPageProvider, IModuleSettingsPageProvider
{
	public string ModuleUid => "EleWise.ELMA.CRM.Web";

	public string Image => "#client.svg";

	public string Text => SR.T("Работа с клиентами");

	public string Description => SR.T("Раздел содержит перечень прав доступа к объектам модуля <b>CRM</b>. С помощью данного раздела настраиваются параметры видимости объектов и набор доступных операций с этими объектами. ");

	public string Url(UrlHelper urlHelper)
	{
		return urlHelper.Action("Permissions", "Security", (object)new
		{
			area = "EleWise.ELMA.CRM.Web"
		});
	}
}
