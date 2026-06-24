using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

public static class UrlExtensions
{
	public static string EventHistory([NotNull] this UrlHelper url, [NotNull] IEntity<long> entity, bool inTab = false, string divPanelId = null, List<string> disableButtons = null, bool asyncLoading = true)
	{
		Guid guid = InterfaceActivator.UID(entity.CastAsRealType().GetType());
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary
		{
			{ "area", "EleWise.ELMA.BPM.Web.Common" },
			{ "id", entity.Id },
			{ "actionObject", guid },
			{ "divPanelId", divPanelId },
			{ "asyncLoading", asyncLoading }
		};
		if (disableButtons != null)
		{
			int num = 0;
			foreach (string disableButton in disableButtons)
			{
				routeValueDictionary.Add($"disableButtons[{num}]", disableButton);
				num++;
			}
		}
		return url.Action("EventHistory", "EntityHistory", routeValueDictionary);
	}
}
