using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace EleWise.ELMA.Web.Mvc.Models.Panels;

public class FramePanelBuilder
{
	private FramePanel framePanel;

	private readonly HtmlHelper html;

	public FramePanelBuilder(FramePanel framePanel, HtmlHelper html)
	{
		this.framePanel = framePanel;
		this.html = html;
	}

	public FramePanelBuilder Id(string id)
	{
		framePanel.Id = id;
		return this;
	}

	public FramePanelBuilder Src(string url)
	{
		framePanel.Src = url;
		return this;
	}

	public FramePanelBuilder Class(string @class)
	{
		framePanel.Class = @class;
		return this;
	}

	public FramePanelBuilder Style(Action<HtmlStyle> styleAction)
	{
		styleAction(framePanel.Style);
		return this;
	}

	public FramePanelBuilder OnLoad(string onload)
	{
		framePanel.OnLoad = onload;
		return this;
	}

	public override string ToString()
	{
		return string.Format(SR.T("Используйте метод Render!"));
	}

	public MvcHtmlString Render()
	{
		return PartialExtensions.Partial(html, "UI/Panels/FramePanel", (object)framePanel);
	}
}
