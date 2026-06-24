using System;
using EleWise.ELMA.Events;
using EleWise.ELMA.Logging;
using Orchard.Caching;
using Orchard.Environment.Configuration;
using Orchard.Environment.Descriptor;
using Orchard.Environment.Descriptor.Models;
using Orchard.Exceptions;
using Orchard.FileSystems.AppData;
using Orchard.Logging;

namespace Orchard.Environment;

public class DefaultHostLocalRestart : IHostLocalRestart, IShellDescriptorManagerEventHandler, IEventHandler, IShellSettingsManagerEventHandler
{
	private readonly IAppDataFolder _appDataFolder;

	private const string fileName = "hrestart.txt";

	public ILogger Logger { get; set; }

	public DefaultHostLocalRestart(IAppDataFolder appDataFolder)
	{
		_appDataFolder = appDataFolder;
		Logger = NullLogger.Instance;
	}

	public void Monitor(Action<IVolatileToken> monitor)
	{
		if (!_appDataFolder.FileExists("hrestart.txt"))
		{
			TouchFile();
		}
		Logger.Debug("Monitoring virtual path \"{0}\"", "hrestart.txt");
		monitor(_appDataFolder.WhenPathChanges("hrestart.txt"));
	}

	void IShellSettingsManagerEventHandler.Saved(ShellSettings settings)
	{
	}

	void IShellDescriptorManagerEventHandler.Changed(ShellDescriptor descriptor, string tenant)
	{
	}

	private void TouchFile()
	{
		try
		{
			_appDataFolder.CreateFile("hrestart.txt", "Host Restart");
		}
		catch (Exception ex)
		{
			if (ex.IsFatal())
			{
				throw;
			}
			Logger.Warning(ex, "Error updating file '{0}'", "hrestart.txt");
		}
	}
}
