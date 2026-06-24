using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace EleWise.ELMA.Web.Mvc.Models.Panels;

public class CollapsiblePanelBuilder
{
	private CollapsiblePanel collapsiblePanel;

	private readonly HtmlHelper html;

	public CollapsiblePanel CollapsiblePanel
	{
		get
		{
			return collapsiblePanel;
		}
		set
		{
			collapsiblePanel = value;
		}
	}

	public CollapsiblePanelBuilder(CollapsiblePanel collapsiblePanel, HtmlHelper html)
	{
		this.collapsiblePanel = collapsiblePanel;
		this.html = html;
	}

	public CollapsiblePanelBuilder Id(string id)
	{
		collapsiblePanel.Id = id;
		return this;
	}

	public CollapsiblePanelBuilder Header(string arg)
	{
		collapsiblePanel.Header = arg;
		return this;
	}

	public CollapsiblePanelBuilder HeaderClose(string arg)
	{
		collapsiblePanel.HeaderClose = arg;
		return this;
	}

	public CollapsiblePanelBuilder ImageUrl(string arg)
	{
		collapsiblePanel.ImageUrl = arg;
		return this;
	}

	public CollapsiblePanelBuilder Url(string arg)
	{
		collapsiblePanel.Url = arg;
		return this;
	}

	public CollapsiblePanelBuilder LoadMode(DynamicLoadMode arg)
	{
		collapsiblePanel.LoadMode = arg;
		return this;
	}

	public CollapsiblePanelBuilder Style(HtmlStyle arg)
	{
		collapsiblePanel.Style = arg;
		return this;
	}

	public CollapsiblePanelBuilder Class(string arg)
	{
		collapsiblePanel.Class = arg;
		return this;
	}

	public CollapsiblePanelBuilder PlusMinus(bool arg)
	{
		collapsiblePanel.PlusMinus = arg;
		return this;
	}

	public CollapsiblePanelBuilder Expanded(bool arg)
	{
		collapsiblePanel.Expanded = arg;
		return this;
	}

	public CollapsiblePanelBuilder OnExpand(string arg)
	{
		collapsiblePanel.OnExpand = arg;
		return this;
	}

	public CollapsiblePanelBuilder SaveState(bool arg)
	{
		collapsiblePanel.SaveState = arg;
		return this;
	}

	public CollapsiblePanelBuilder Content(Func<dynamic, object> content)
	{
		collapsiblePanel.Content = content;
		return this;
	}

	public CollapsiblePanelBuilder HeaderExt(MvcHtmlString arg)
	{
		collapsiblePanel.HeaderExt = arg;
		return this;
	}

	public override string ToString()
	{
		return string.Format(SR.T("Используйте метод Render!"));
	}

	public MvcHtmlString Render()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		if (collapsiblePanel.SaveState)
		{
			PanelState panelState = PanelPersonalizationAdministration.LoadState(collapsiblePanel.Id);
			if (panelState != null)
			{
				collapsiblePanel.Expanded = panelState.Expanded;
			}
		}
		return new MvcHtmlString(string.Concat(((object)PartialExtensions.Partial(html, "UI/Panels/CollapsiblePanelBegin", (object)collapsiblePanel)).ToString(), (collapsiblePanel.Content != null) ? collapsiblePanel.Content(this) : MvcHtmlString.Empty, PartialExtensions.Partial(html, "UI/Panels/CollapsiblePanelEnd", (object)collapsiblePanel)));
	}
}
