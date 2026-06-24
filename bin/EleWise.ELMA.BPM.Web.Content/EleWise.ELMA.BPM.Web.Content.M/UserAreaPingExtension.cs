using System.Linq;
using System.Web.Helpers;
using EleWise.ELMA.BPM.Web.Content.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Content.Menu;

[Component]
public class UserAreaPingExtension : IPingDataExtension
{
	public string ClientFunction => "messagesCountUpdatedInFeed";

	public string GetData()
	{
		return Json.Encode((object)(from p in ComponentManager.Current.GetExtensionPoints<IUserAreaAction>(useCache: true)
			where p.NeedUpdateCount()
			select p).Select(delegate(IUserAreaAction p)
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
