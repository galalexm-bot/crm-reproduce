namespace EleWise.ELMA.Web.Mvc.Models.Panels;

public class FramePanel
{
	public string Id { get; set; }

	public string Src { get; set; }

	public bool AutoRefresh { get; set; }

	public HtmlStyle Style { get; set; }

	public string Class { get; set; }

	public string OnLoad { get; set; }

	public FramePanel()
	{
		Style = new HtmlStyle();
	}
}
