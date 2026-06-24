using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.vCard.Web.Components;

[Component(Order = 50)]
public class AddPopupProfileBtn : IProfileActionProviderPoint
{
	public IEnumerable<IProfileAction> GetProfileActions(HtmlHelper html, IUser user)
	{
		return new List<IProfileAction>
		{
			new SimpleProfileAction
			{
				ImageUrl = "#vCard.svg",
				ActionUrl = html.Url().Action("GetForUser", "Vcard", new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.vCard.Web" },
					{ "id", user.Uid }
				}),
				Caption = SR.T("Экспорт vCard"),
				Tooltip = SR.T("Экспорт vCard"),
				Order = 40
			}
		};
	}
}
