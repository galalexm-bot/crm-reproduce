using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Content.LinkTypeProviders;

[Component]
public class ActionsLinkTypeProvider : LinkTypeProvider, ILinkTypeProvider
{
	private readonly ControllerActionRegistry controllerActionRegistry;

	public string Id => "ActionsLinkTypeProvider";

	public string Name => SR.M("Действие");

	public int? Order => 0;

	public override bool ShowInTree => false;

	public override string Category => SR.M("Н.Д.");

	public ActionsLinkTypeProvider(ControllerActionRegistry controllerActionRegistry)
	{
		this.controllerActionRegistry = controllerActionRegistry;
	}

	public IContentAction Get(string actionId)
	{
		return controllerActionRegistry.Get(actionId);
	}

	public IEnumerable<IContentItem> All()
	{
		return controllerActionRegistry.All();
	}

	public MvcHtmlString RenderSelector(HtmlHelper htmlHelper)
	{
		return PartialExtensions.Partial(htmlHelper, "ContentSelectors/ContentActionSelector", new object());
	}

	protected override string ValueElement(HtmlHelper htmlHelper)
	{
		throw new NotImplementedException();
	}

	protected override string TextElement(HtmlHelper htmlHelper)
	{
		throw new NotImplementedException();
	}

	public override MvcHtmlString GetSelectedScript(HtmlHelper htmlHelper)
	{
		return MvcHtmlString.Create("{var value = null; try { value = $.evalJSON($('#contentActionSelector').val()); } catch(e){}; if(!!value) {({value: value.id, text: $('#contentActionSelector-input').val(), type: value.type})} else undefined}");
	}
}
