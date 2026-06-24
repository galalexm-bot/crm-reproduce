using System.Linq;
using System.Web.Helpers;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Security.Menu;

[Component]
public class UserPanelPingExtension : IPingDataExtension
{
	public string ClientFunction => "elma.userPanelCountsUpdate";

	public string GetData()
	{
		return Json.Encode((object)(from p in ComponentManager.Current.GetExtensionPoints<ICurrentUserPanelAction>(useCache: true)
			where p.IsVisible() && p.NeedUpdateCount()
			select p).Select(delegate(ICurrentUserPanelAction p)
		{
			MenuItemCount count = p.GetCount();
			return new
			{
				code = p.Id,
				c = count?.Count,
				f = count?.ClientUpdateFunction,
				cssClass = count?.CssClass
			};
		}));
	}
}
