using System;
using System.Collections.Generic;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems.Menu;

[Serializable]
public class ActionMenuShowParams
{
	public string MenuGuid { get; set; }

	public object Sender { get; set; }

	public string Scope { get; set; }

	public string Align { get; set; }

	public IEnumerable<string> NotVisibleItems { get; set; }

	public string NotVisibleItemsUrl { get; set; }

	public ActionMenuShowParams()
	{
		NotVisibleItems = new SerializableList<string>();
		MenuGuid = "";
	}

	public void CopyFrom(ActionMenuShowParams param)
	{
		if (param != null)
		{
			Align = param.Align;
			MenuGuid = param.MenuGuid;
			NotVisibleItems = ClassSerializationHelper.CloneObject(param.NotVisibleItems);
			NotVisibleItemsUrl = param.NotVisibleItemsUrl;
			Scope = param.Scope;
			Sender = param.Sender;
		}
	}
}
