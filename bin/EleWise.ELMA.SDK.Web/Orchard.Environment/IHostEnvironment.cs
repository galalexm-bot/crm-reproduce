namespace Orchard.Environment;

public interface IHostEnvironment
{
	string MapPath(string virtualPath);

	bool IsAssemblyLoaded(string name);

	void RestartAppDomain();
}
