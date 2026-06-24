using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = 80)]
internal class TaskControlMenuProviderExtension : IFilterMenuProviderExtension
{
	public bool SupportedFilter(IFilterFolder filterFolder)
	{
		if (filterFolder.ObjectsType.TypeUid == TaskControlUniqueFilterExtension.Guid)
		{
			return filterFolder.Id == 0;
		}
		return false;
	}

	public void GetTreeNodeParameters(IFilterFolder filterFolder, UrlHelper urlHelper, bool isDefault, bool isSystemDefault, out string type, out string icon, out string href, out bool canMakeDefault, ActionRoute routes, string filterIdParameter = null, string urlAction = null)
	{
		filterFolder.Name = SR.T("Поиск задач");
		href = null;
		if (urlHelper != null)
		{
			if (filterFolder.Code == TaskConstants.ExecutionControlThreadCodeUid)
			{
				href = urlHelper.Action("ExecutionControl", "AllTasks", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Tasks",
					FilterId = 0
				});
			}
			else if (filterFolder.Code == TaskConstants.CurrentControlThreadCodeUid)
			{
				href = urlHelper.Action("CurrentControl", "AllTasks", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Tasks",
					FilterId = 0
				});
			}
			else
			{
				href = urlHelper.Action("Index", "AllTasks", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Tasks",
					FilterId = 0
				});
			}
		}
		canMakeDefault = true;
		type = "action";
		icon = "#search.svg";
	}
}
