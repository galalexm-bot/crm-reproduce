using System;
using System.Web.Mvc;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public class ParametrizedActionModel
{
	public string PopupId { get; set; }

	public string Name { get; private set; }

	public Func<HtmlHelper, MvcHtmlString> Selector { get; private set; }

	public bool ShowSelectButton { get; private set; }

	public Func<HtmlHelper, MvcHtmlString> RunScript { get; private set; }

	public Func<HtmlHelper, MvcHtmlString> SelectScript { get; private set; }

	public ParametrizedActionModel(ILinkTypeProvider provider, string popupId, bool showSelectButton)
	{
		ShowSelectButton = showSelectButton;
		RunScript = provider.GetRunScript;
		SelectScript = provider.GetSelectedScript;
		Selector = provider.RenderSelector;
		Name = provider.Name;
		PopupId = popupId;
	}
}
