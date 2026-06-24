using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = 80)]
public class FilterWorkLogReportMenuProviderExtension : IFilterMenuProviderExtension
{
	public IContentActionRegistry ContentActionRegistry { get; set; }

	public IComponentManager ComponentManager { get; set; }

	public bool SupportedFilter(IFilterFolder filterFolder)
	{
		if (filterFolder.ObjectsType.TypeUid == new Guid("{BB33273E-8224-4D28-82E6-E1C37F659828}"))
		{
			return filterFolder.Id == 0;
		}
		return false;
	}

	public void GetTreeNodeParameters(IFilterFolder filterFolder, UrlHelper urlHelper, bool isDefault, bool isSystemDefault, out string type, out string icon, out string href, out bool canMakeDefault, ActionRoute routes, string filterIdParameter = null, string urlAction = null)
	{
		filterFolder.Name = SR.T("Поиск трудозатрат");
		href = null;
		if (urlHelper != null)
		{
			href = urlHelper.Action("Index", "WorkLogReport", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Tasks",
				FilterId = 0
			});
		}
		canMakeDefault = true;
		type = "action";
		icon = "#search.svg";
	}
}
