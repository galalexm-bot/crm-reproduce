using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[Component]
public class TaskProfileActions : IProfileActionProviderPoint
{
	public IEnumerable<IProfileAction> GetProfileActions(HtmlHelper html, EleWise.ELMA.Security.Models.IUser user)
	{
		List<IProfileAction> list = new List<IProfileAction>();
		if (user.Status != UserStatus.Blocked && Locator.GetServiceNotNull<ISecurityService>().HasPermission(EleWise.ELMA.Tasks.PermissionProvider.TasksAccessPermission))
		{
			list.Add(new SimpleProfileAction
			{
				ImageUrl = "#add_task.svg",
				ActionUrl = html.Url().Action("Create", "Task", new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.BPM.Web.Tasks" },
					{ "idUsers[0]", user.Id }
				}),
				Caption = SR.T("Задача"),
				Tooltip = SR.T("Создать задачу данному пользователю"),
				Order = 10
			});
		}
		return list;
	}
}
