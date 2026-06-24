using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc;

[Service]
public class ApplicationDirectoryFileWatcher : DirectoryFileWatcher
{
	public void Init(string configurationDirectory)
	{
		InitWatcher(configurationDirectory);
	}
}
