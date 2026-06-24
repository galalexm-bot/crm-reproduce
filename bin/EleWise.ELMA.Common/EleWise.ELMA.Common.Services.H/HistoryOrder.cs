using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Common.Services.HistoryOrder;

[Service(Scope = ServiceScope.Shell)]
internal sealed class HistoryOrder : IHistoryOrder
{
	private readonly IEnumerable<IHistoryIdentifierExtensionPoint> extPoints;

	public HistoryOrder(IEnumerable<IHistoryIdentifierExtensionPoint> extPoints)
	{
		this.extPoints = extPoints;
	}

	public ListSortDirection GetOrderType(IHistoryIdParams parameters)
	{
		Contract.ArgumentNotNull(parameters, "parameters");
		string key = GetKey(parameters);
		return ContextVars.GetOrAdd(key, () => SessionVars.GetOrAdd(key, () => PersonalizationAdministration.LoadState<ListSortDirection?>(GetCurrentUserName(), key) ?? ListSortDirection.Ascending));
	}

	public void SetOrderType(ListSortDirection direction, IHistoryIdParams parameters)
	{
		Contract.ArgumentNotNull(parameters, "parameters");
		string key = GetKey(parameters);
		PersonalizationAdministration.SaveState(GetCurrentUserName(), key, direction);
		SessionVars.Set(key, direction);
		ContextVars.Set(key, direction);
	}

	private string GetKey(IHistoryIdParams parameters)
	{
		return extPoints.First((IHistoryIdentifierExtensionPoint x) => x.Check(parameters)).GetKey(parameters);
	}

	private static string GetCurrentUserName()
	{
		return "u_" + AuthenticationService.CurrentUserName;
	}
}
