using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Menu;

namespace EleWise.ELMA.BPM.Web.Tasks.Menu;

[Component]
public class TasksMenuCoExecutorCountEvaluator : IMenuItemCountEvaluator
{
	public bool HasCountEvaluator(MenuItemNode item)
	{
		return false;
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
		long currentCoExecutorCount = TaskBaseManager.Instance.GetCurrentCoExecutorCount(AuthenticationService.GetCurrentUser<IUser>());
		return new MenuItemCount
		{
			Count = ((currentCoExecutorCount > 0) ? currentCoExecutorCount.ToString() : null),
			CssClass = "important tasks-counter"
		};
	}
}
