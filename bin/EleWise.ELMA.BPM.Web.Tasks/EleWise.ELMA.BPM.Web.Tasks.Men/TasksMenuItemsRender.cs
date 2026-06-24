using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Menu;
using EleWise.ELMA.Web.Mvc.Models.Trees;

namespace EleWise.ELMA.BPM.Web.Tasks.Menu;

[Obsolete("Больше не используется")]
public class TasksMenuItemsRender : IMenuItemRenderer
{
	public bool HasCustomRender(MenuItemNode item)
	{
		return item.Code == "mydepartment-tree";
	}

	public MvcHtmlString Render(HtmlHelper htmlHelper, MenuItemNode item)
	{
		if (item.Code != "mydepartment-tree")
		{
			throw new InvalidOperationException();
		}
		List<TreeMenuNode> list = new List<TreeMenuNode>();
		if (item.Code == "mydepartment-tree" && UserManager.Instance.HaveSubordinatesForUser(AuthenticationService.GetCurrentUser<IUser>()))
		{
			list.Add(new TreeMenuNode
			{
				id = "my_department_tasks_for",
				text = SR.T("Задачи отдела"),
				href = htmlHelper.Url().Action("MyDepartmentCurrent", "AllTasks", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Tasks"
				}),
				children = new List<TreeMenuNode>
				{
					new TreeMenuNode
					{
						id = "myDepartmentCurrent",
						text = SR.T("Текущие"),
						href = htmlHelper.Url().Action("MyDepartmentCurrent", "AllTasks", (object)new
						{
							area = "EleWise.ELMA.BPM.Web.Tasks"
						})
					},
					new TreeMenuNode
					{
						id = "myDepartmentExpired",
						text = SR.T("Просроченные"),
						href = htmlHelper.Url().Action("MyDepartmentExpired", "AllTasks", (object)new
						{
							area = "EleWise.ELMA.BPM.Web.Tasks"
						})
					}
				}
			});
			list.Add(new TreeMenuNode
			{
				id = "my_department_tasks_from",
				text = SR.T("Задачи от отдела"),
				href = htmlHelper.Url().Action("FromDepartmentCurrent", "AllTasks", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Tasks"
				}),
				children = new List<TreeMenuNode>
				{
					new TreeMenuNode
					{
						id = "fromDepartmentCurrent",
						text = SR.T("Текущие"),
						href = htmlHelper.Url().Action("FromDepartmentCurrent", "AllTasks", (object)new
						{
							area = "EleWise.ELMA.BPM.Web.Tasks"
						})
					},
					new TreeMenuNode
					{
						id = "fromDepartmentExpired",
						text = SR.T("Просроченные"),
						href = htmlHelper.Url().Action("FromDepartmentExpired", "AllTasks", (object)new
						{
							area = "EleWise.ELMA.BPM.Web.Tasks"
						})
					},
					new TreeMenuNode
					{
						id = "fromDepartmentCompleted",
						text = SR.T("Выполненные"),
						href = htmlHelper.Url().Action("FromDepartmentCompleted", "AllTasks", (object)new
						{
							area = "EleWise.ELMA.BPM.Web.Tasks"
						})
					}
				}
			});
			list.Add(new TreeMenuNode
			{
				id = "closed_tasks_department",
				text = SR.T("Архив"),
				href = htmlHelper.Url().Action("ForDepartmentClosed", "AllTasks", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Tasks"
				}),
				children = new List<TreeMenuNode>
				{
					new TreeMenuNode
					{
						id = "forDepartmentClosed",
						text = SR.T("Задачи отдела"),
						href = htmlHelper.Url().Action("ForDepartmentClosed", "AllTasks", (object)new
						{
							area = "EleWise.ELMA.BPM.Web.Tasks"
						})
					},
					new TreeMenuNode
					{
						id = "fromDepartmentClosed",
						text = SR.T("Задачи от отдела"),
						href = htmlHelper.Url().Action("FromDepartmentClosed", "AllTasks", (object)new
						{
							area = "EleWise.ELMA.BPM.Web.Tasks"
						})
					}
				}
			});
		}
		return htmlHelper.Tree(list, "main_menu_tree_channels");
	}
}
