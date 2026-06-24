using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class WorkLogItemFormParams
{
	public string EditScript { get; set; }

	public string DeleteScript { get; set; }

	public string FilterFormId { get; set; }

	public string PopupId { get; set; }

	public bool OpenOnPopup { get; set; }

	public bool CanChange { get; set; }

	public bool ShowDisplayName { get; set; }

	public bool ShowSummaryTable { get; set; }

	public RouteValueDictionary ToRouteValueDictionary()
	{
		RouteValueDictionary routeDic = new RouteValueDictionary();
		Action<string, object> action = delegate(string key, object value)
		{
			routeDic.Add($"FormParameters.{key}", value);
		};
		foreach (KeyValuePair<string, object> item in ToViewDataDictionary())
		{
			action(item.Key, item.Value);
		}
		return routeDic;
	}

	public ViewDataDictionary ToViewDataDictionary()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary();
		if (!string.IsNullOrEmpty(EditScript))
		{
			val.Add("EditScript", (object)EditScript);
		}
		if (!string.IsNullOrEmpty(DeleteScript))
		{
			val.Add("DeleteScript", (object)DeleteScript);
		}
		if (!string.IsNullOrEmpty(FilterFormId))
		{
			val.Add("FilterFormId", (object)FilterFormId);
		}
		if (!string.IsNullOrEmpty(PopupId))
		{
			val.Add("PopupId", (object)PopupId);
		}
		if (OpenOnPopup)
		{
			val.Add("OpenOnPopup", (object)OpenOnPopup);
		}
		if (CanChange)
		{
			val.Add("CanChange", (object)CanChange);
		}
		if (ShowDisplayName)
		{
			val.Add("ShowDisplayName", (object)ShowDisplayName);
		}
		if (ShowSummaryTable)
		{
			val.Add("ShowSummaryTable", (object)ShowSummaryTable);
		}
		return val;
	}
}
