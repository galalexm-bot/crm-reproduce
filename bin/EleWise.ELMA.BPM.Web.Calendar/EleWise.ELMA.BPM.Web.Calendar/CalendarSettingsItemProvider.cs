using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Models.Buttons;

namespace EleWise.ELMA.BPM.Web.Calendar.Components;

[Component]
internal sealed class CalendarSettingsItemProvider : IModuleSettingsItemProvider
{
	private SecurityService securityService;

	public CalendarSettingsItemProvider(SecurityService securityService)
	{
		this.securityService = securityService;
	}

	public bool Check(string id)
	{
		return id == "admin-calendar";
	}

	public IEnumerable<LinkButton> GetItems(UrlHelper urlHelper)
	{
		List<LinkButton> list = new List<LinkButton>();
		list.Add(new LinkButton
		{
			Href = urlHelper.Action("GlobalProductionSchedule", "ProductionSchedule", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Calendar"
			}),
			Image = "#calendar_external.svg",
			Text = SR.T("Глобальный календарь")
		});
		list.Add(new LinkButton
		{
			Href = urlHelper.Action("CommonGrid", "ProductionSchedule", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Calendar"
			}),
			Image = "#calendar.svg",
			Text = SR.T("Производственные календари")
		});
		list.Add(new LinkButton
		{
			Href = urlHelper.Action("Index", "Admin", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Calendar"
			}),
			Image = "#calendar.svg",
			Text = SR.T("Общие календари"),
			Description = MvcHtmlString.Create(SR.T("Раздел позволяет настроить общие календари системы для совместного использования при планировании"))
		});
		list.Add(new LinkButton
		{
			Href = urlHelper.Action("Index", "Settings", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Common",
				module = "EleWise.ELMA.Calendar",
				title = SR.T("Настройки модуля «Календарь»")
			}),
			Image = "#setting_outline.svg",
			Text = SR.T("Настройки модуля «Календарь»")
		});
		if (securityService.HasPermission(PermissionProvider.AccessManagmentPermission))
		{
			list.Add(new LinkButton
			{
				Href = urlHelper.Action("GlobalPermissions", "PermissionManagment", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Security",
					module = "EleWise.ELMA.BPM.Web.Calendar",
					currentMenu = "admin-calendar",
					title = SR.T("Права доступа к модулю «Календарь»")
				}),
				Image = "#access.svg",
				Text = SR.T("Права доступа к модулю «Календарь»")
			});
		}
		return list;
	}
}
