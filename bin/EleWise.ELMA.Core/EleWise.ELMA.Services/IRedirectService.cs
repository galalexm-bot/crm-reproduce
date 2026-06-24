using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Services;

[ServiceContract]
public interface IRedirectService
{
	void Redirect(string url);

	void Reload();

	void OpenInNewTab(string url);

	void OpenInNewWindow(string url);

	string GetCurrentUrl();
}
