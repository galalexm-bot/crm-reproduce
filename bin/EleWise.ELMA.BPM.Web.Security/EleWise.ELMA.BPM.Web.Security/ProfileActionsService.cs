using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints;

public static class ProfileActionsService
{
	public static IEnumerable<IProfileAction> GetProfileActions(this HtmlHelper html, IUser user)
	{
		return from p in ComponentManager.Current.GetExtensionPoints<IProfileActionProviderPoint>().SelectMany((IProfileActionProviderPoint p) => p.GetProfileActions(html, user))
			orderby p.Order
			select p;
	}
}
