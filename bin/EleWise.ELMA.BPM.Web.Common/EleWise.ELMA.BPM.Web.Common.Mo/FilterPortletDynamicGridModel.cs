using System;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class FilterPortletDynamicGridModel : DynamicGrid, IFilterPortletModel
{
	public FilterPortletDynamicGridModel(string uniqueName, string dynamicContentId, IGridData gridData, Type type, string callbackFunction = null)
		: base(uniqueName, dynamicContentId, gridData, type, callbackFunction)
	{
	}

	public FilterPortletDynamicGridModel(string uniqueName, string dynamicContentId, IGridData gridData, Type type, string callbackFunction, string stateId)
		: base(uniqueName, dynamicContentId, gridData, type, callbackFunction, stateId)
	{
	}

	public IGridData GetGridData()
	{
		return base.GridData;
	}
}
