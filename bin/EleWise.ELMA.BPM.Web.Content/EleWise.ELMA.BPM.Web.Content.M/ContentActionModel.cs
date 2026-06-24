using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public class ContentActionModel
{
	private readonly IContentAction action;

	private readonly ILinkTypeProvider linkTypeProvider;

	private readonly bool showSelectButton;

	private readonly string id;

	private readonly string name;

	private readonly string category;

	private readonly string image;

	private readonly int order;

	private readonly string actionType;

	private readonly bool hasParameters;

	public string Id => id;

	public string Name => name;

	public string Category => category;

	public bool HasParameters => hasParameters;

	public string Description => action.Description;

	public string Image => image;

	public int Order => order;

	public string ActionType => actionType;

	public bool ShowSelectButton => showSelectButton;

	public ContentActionModel(ILinkTypeProvider linkTypeProvider, bool showSelectButton)
	{
		this.linkTypeProvider = linkTypeProvider;
		this.showSelectButton = showSelectButton;
		id = this.linkTypeProvider.Id;
		name = SR.T(this.linkTypeProvider.Name);
		category = SR.T(this.linkTypeProvider.Category) ?? SR.T("Прочее");
		image = this.linkTypeProvider.Image;
		order = this.linkTypeProvider.Order ?? 1000;
		actionType = SR.T(this.linkTypeProvider.ActionType);
		hasParameters = true;
	}

	public ContentActionModel(IContentAction action)
	{
		this.action = action;
		id = this.action.Id;
		name = this.action.Name;
		category = SR.T(this.action.Category) ?? SR.M("Прочее");
		image = this.action.GetImage(ObjectIconFormat.x16);
		order = this.action.Order;
		actionType = SR.T(this.action.ActionType);
		hasParameters = Id.StartsWith("configuration_pagev2");
	}

	public string GetHref(RequestContext requestContext)
	{
		if (action != null)
		{
			return action.GetHref(requestContext);
		}
		return null;
	}

	public string Run(RequestContext requestContext)
	{
		if (action != null)
		{
			return action.GetHref(requestContext);
		}
		if (HasParameters)
		{
			return string.Concat("javascript:void(", OpenParamsWindow(null), ")");
		}
		return null;
	}

	public MvcHtmlString OpenParamsWindow(string onClose)
	{
		return MvcHtmlString.Create("openWindow('" + ParamsPopupId() + "', null,'" + onClose + "')");
	}

	public void OnRender(HtmlHelper htmlHelper)
	{
		if (action != null)
		{
			action.OnRender(htmlHelper);
		}
		else if (linkTypeProvider != null)
		{
			htmlHelper.RegisterContent(ParamsPopupId(), (dynamic d) => PartialExtensions.Partial(htmlHelper, "ContentAction/ParametrizedAction", (object)new ParametrizedActionModel(linkTypeProvider, ParamsPopupId(), showSelectButton)));
		}
	}

	public string ParamsPopupId()
	{
		return "content_action_selector_" + id;
	}

	public bool IsAvalilable(RequestContext requestContext)
	{
		if (action != null)
		{
			return action.IsAvalilable(requestContext);
		}
		if (linkTypeProvider != null)
		{
			return linkTypeProvider.IsAvalilable(requestContext);
		}
		return true;
	}

	public int MatchCurrent(RequestContext requestContext)
	{
		if (action != null)
		{
			return action.MatchCurrent(requestContext);
		}
		return 0;
	}
}
