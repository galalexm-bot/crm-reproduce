using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Menu;

namespace EleWise.ELMA.BPM.Web.Tasks.Menu;

[Component]
public class TasksMenuItemCountEvaluator : IMenuItemCountEvaluator
{
	public bool HasCountEvaluator(MenuItemNode item)
	{
		return item.Code == "left_tasks_menu";
	}

	public bool NeedUpdate(MenuItemNode item)
	{
		return false;
	}

	public MenuItemCount Evaluate(MenuItemNode item)
	{
		return Evaluate(useClientUpdateFunction: true);
	}

	public static MenuItemCount Evaluate(bool useClientUpdateFunction)
	{
		long currentCount = TaskBaseManager.Instance.GetCurrentCount(AuthenticationService.GetCurrentUser<IUser>());
		return new MenuItemCount
		{
			Count = ((currentCount > 0) ? currentCount.ToString() : null),
			CssClass = "important tasks-counter"
		};
	}
}
