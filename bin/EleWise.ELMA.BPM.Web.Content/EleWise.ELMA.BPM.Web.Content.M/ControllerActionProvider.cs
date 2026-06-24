using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Content.Menu;

[Component]
public class ControllerActionProvider : ControllerActionProviderBase
{
	private readonly ContentAction home;

	public ControllerActionProvider()
	{
		home = new ContentAction
		{
			Id = "ELMA.BPM.Web.Content-Module.Page.Home",
			Image24 = "#elma.svg",
			DescriptionForLocalization = SR.M("Главная"),
			NameForLocalization = SR.M("Главная"),
			ReferenceType = "ActionPage",
			Routes = new ActionRoute("Home", "Page", new
			{
				area = "EleWise.ELMA.BPM.Web.Content"
			})
		};
	}

	protected override IEnumerable<ContentAction> GetAction()
	{
		yield return home;
	}
}
