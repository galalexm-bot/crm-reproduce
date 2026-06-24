using System.Configuration.Provider;

namespace EleWise.ELMA.Web.Mvc.Portlets;

public abstract class PersonalizationProvider : ProviderBase
{
	public abstract string ApplicationName { get; set; }

	public abstract void SaveState<T>(string userName, string path, T state);

	public abstract T LoadState<T>(string userName, string path);

	public abstract void ResetState<T>(string userName, string path);
}
