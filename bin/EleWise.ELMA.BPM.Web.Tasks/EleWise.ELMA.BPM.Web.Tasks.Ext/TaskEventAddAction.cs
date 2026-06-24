using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[Component]
public class TaskEventAddAction : IEventAddAction
{
	public string Uid => "add-calendar-task";

	public string Name => SR.T("Задачу");

	public dynamic WindowSettings => null;

	public string Icon => "#add_task.svg";

	public int Order => 20;

	public bool AllowInShared => false;

	public string Url(RequestContext context)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return new UrlHelper(context).Action("Create", "Task", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks",
			start = "{0}",
			end = "{1}"
		});
	}
}
