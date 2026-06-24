using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc;

[Service]
[Obsolete("EleWise.ELMA.Web.Mvc.ConfigurationDirectoryFileWatcher не используется. Используйте EleWise.ELMA.Services.ConfigurationDirectoryFileWatcher!", true)]
public class ConfigurationDirectoryFileWatcher : EleWise.ELMA.Services.ConfigurationDirectoryFileWatcher
{
	public new void Init(string configurationDirectory)
	{
		InitWatcher(configurationDirectory);
	}
}
