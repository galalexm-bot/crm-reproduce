using System.Web;

namespace EleWise.ELMA.Web.Mvc.Models.Panels;

public class ClientInfoPanel
{
	public string Text { get; set; }

	public string PanelId { get; set; }

	public string HtmlClasses { get; set; }

	public long? Expires { get; set; }

	public bool Closable { get; set; }

	public bool RootPath { get; set; }

	public string CookieKey => $"Is{PanelId}Show";

	public ClientInfoPanel()
	{
		Closable = true;
	}

	public bool IsVisible(HttpRequestBase request)
	{
		return request.Cookies[CookieKey] == null;
	}
}
