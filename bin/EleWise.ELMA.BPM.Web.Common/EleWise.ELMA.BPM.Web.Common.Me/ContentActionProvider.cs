using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Panels;

namespace EleWise.ELMA.BPM.Web.Common.Menu;

[Component]
public class ContentActionProvider : ControllerActionProviderBase
{
	private readonly ContentAction about;

	public ContentActionProvider()
	{
		about = new ContentAction
		{
			Id = "EleWise.ELMA.BPM.Web.Common-Module-About",
			DescriptionForLocalization = SR.M("О программе"),
			Image24 = "#info-circle.svg",
			NameForLocalization = SR.M("О программе"),
			ActionType = ContentAction.ActionTypeDialog,
			LinkTemplate = (RequestContext cc) => ((object)UIExtensions.OpenPopup("AboutWindow")).ToString().PrepareJavascriptHref(),
			OnRenderDelegate = delegate(HtmlHelper html)
			{
				html.RegisterContent("AboutWindow", (dynamic d) => html.PopupWindow(new Popup
				{
					PopupId = "AboutWindow",
					PopupHeader = SR.T("О программе"),
					ShowHeader = false,
					ActionUrl = html.Url().Action("About", "Home", (object)new
					{
						area = "EleWise.ELMA.BPM.Web.Common"
					})
				}));
			}
		};
	}

	protected override IEnumerable<ContentAction> GetAction()
	{
		yield return about;
	}
}
