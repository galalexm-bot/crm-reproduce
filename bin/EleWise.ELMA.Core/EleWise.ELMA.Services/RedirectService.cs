using Bridge.Html5;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Services;

[Service]
internal sealed class RedirectService : IRedirectService
{
	public void Redirect(string url)
	{
		if (url.StartsWith("http://") || url.StartsWith("https://") || url.StartsWith("//"))
		{
			Window.Location.Href = url;
		}
		else if (url.StartsWith("~/"))
		{
			Window.Location.Href = url.Substring(1, url.get_Length() - 1);
		}
		else
		{
			Window.Location.Href = "//" + url;
		}
	}

	public void Reload()
	{
		Window.Location.Reload();
	}

	public void OpenInNewTab(string url)
	{
		Window.Open(url, "_blank").Focus();
	}

	public void OpenInNewWindow(string url)
	{
		string text = $"width={Window.InnerWidth},height={Window.InnerHeight}";
		Window.Open(url, "_blank", text).Focus();
	}

	public string GetCurrentUrl()
	{
		return Window.Location.Href;
	}
}
