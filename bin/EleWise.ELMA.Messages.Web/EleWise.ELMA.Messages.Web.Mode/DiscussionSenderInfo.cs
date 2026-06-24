using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Messages.Web.Models;

public class DiscussionSenderInfo
{
	public List<IEntity<long>> Objects { get; set; }

	public string PopupId { get; set; }

	public string ButtonName { get; set; }

	public string ButtonImage { get; set; }

	public bool NeedToolbarButton { get; set; }

	public string BeforeSubmitScript { get; set; }

	public DiscussionSenderInfo()
	{
		NeedToolbarButton = true;
	}

	public string GetPopupScript(HtmlHelper helper)
	{
		string text = PopupId ?? "DiscussionSenderPopup";
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary
		{
			{ "area", "EleWise.ELMA.Messages.Web" },
			{ "popupId", text },
			{ "ajaxSubmit", false }
		};
		if (BeforeSubmitScript != null)
		{
			routeValueDictionary.Add("beforeSubmitScript", BeforeSubmitScript);
		}
		if (Objects.Count == 1)
		{
			routeValueDictionary.Add("subject", Objects.First().ToString());
		}
		int num = 0;
		foreach (IEntity<long> @object in Objects)
		{
			routeValueDictionary.Add($"objectIdsForDiscussion[{num}]", @object.Id);
			routeValueDictionary.Add($"objectTypesForDiscussion[{num}]", InterfaceActivator.UID(@object.GetType()));
			num++;
		}
		string arg = helper.Url().Action("EditForm", "ChannelMessage", routeValueDictionary);
		return $"refreshPopup('{text}', '{arg}')";
	}
}
