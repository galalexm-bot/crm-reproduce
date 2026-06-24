using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Common.Attributes;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Content.Components;

[Component]
[ActionWizardItem(Order = 20, Image32 = "#user.svg", Category = ActionWizardItemCategory.Link)]
public class UserLinkActionProvider : LinkTypeProvider, ILinkTypeProvider
{
	public const string ProviderId = "UserLinkTypeProvider";

	public ISecurityService SecurityService { get; set; }

	public string Id => "UserLinkTypeProvider";

	public string Name => SR.M("Пользователь");

	public int? Order => 15;

	public override string Image => "#user.svg";

	public override string ActionType => ContentAction.ActionTypeDialog;

	public override bool ShowInTree => false;

	public IContentAction Get(string parameters)
	{
		return new ContentAction
		{
			Id = parameters,
			NameForLocalization = SR.M("Пользователь"),
			DescriptionForLocalization = SR.M("Пользователь"),
			Image24 = "#user.svg",
			ActionType = ContentAction.ActionTypeDialog,
			LinkTemplate = (RequestContext cc) => $"showUserInfo({parameters})".PrepareJavascriptHref()
		};
	}

	public MvcHtmlString RenderSelector(HtmlHelper htmlHelper)
	{
		UserLinkActionModel userLinkActionModel = new UserLinkActionModel();
		return PartialExtensions.Partial(htmlHelper, "ContentSelectors/UserLinkActionParameters", (object)userLinkActionModel);
	}

	protected override string ValueElement(HtmlHelper htmlHelper)
	{
		return "User_Id";
	}

	protected override string TextElement(HtmlHelper htmlHelper)
	{
		return ValueElement(htmlHelper) + "-input";
	}

	public override MvcHtmlString RenderActionView(HtmlHelper htmlHelper, IContentAction contentAction)
	{
		if (!long.TryParse(contentAction.Id, out var result))
		{
			return MvcHtmlString.Empty;
		}
		EleWise.ELMA.Security.Models.IUser user = UserManager.Instance.LoadOrNull(result);
		if (user == null)
		{
			return MvcHtmlString.Empty;
		}
		return PartialExtensions.Partial(htmlHelper, "DisplayTemplates/Entities/User", (object)user);
	}
}
