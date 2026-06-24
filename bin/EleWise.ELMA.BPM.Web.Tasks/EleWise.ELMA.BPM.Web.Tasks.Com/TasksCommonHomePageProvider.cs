using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = 20)]
public class TasksCommonHomePageProvider : ICommonHomePageProvider, IModuleSettingsPageProvider
{
	public string ModuleUid => "EleWise.ELMA.Tasks";

	public string Image => "#task.svg";

	public string Text => SR.T("Задачи");

	public string Description => SR.T("Раздел позволяет настроить категории задач и учет трудозатрат по задачам в организации");

	public string Url(UrlHelper urlHelper)
	{
		return urlHelper.Action("Index", "Settings", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		});
	}
}
