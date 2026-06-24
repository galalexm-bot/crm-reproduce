using System.Web.Mvc;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class TasksModuleSettingsItemCatalog<T> : TasksModuleSettingsItem
{
	private readonly string catalogsCategory = SR.T("Справочники");

	public TasksModuleSettingsItemCatalog(UrlHelper urlHelper)
	{
		base.Category = catalogsCategory;
		base.Image = "#dictionary.svg";
		base.Url = urlHelper.Action("View", "Catalogs", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common",
			uid = InterfaceActivator.UID<T>()
		});
	}
}
