using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Logging;
using Orchard.Caching;
using Orchard.Environment.Extensions.Loaders;
using Orchard.Environment.Extensions.Models;
using Orchard.FileSystems.VirtualPath;
using Orchard.Logging;

namespace Orchard.Environment.Extensions;

public class ExtensionMonitoringCoordinator : IExtensionMonitoringCoordinator
{
	private readonly IVirtualPathMonitor _virtualPathMonitor;

	private readonly IAsyncTokenProvider _asyncTokenProvider;

	private readonly IExtensionManager _extensionManager;

	private readonly IEnumerable<IExtensionLoader> _loaders;

	public ILogger Logger { get; set; }

	public bool Disabled { get; set; }

	public ExtensionMonitoringCoordinator(IVirtualPathMonitor virtualPathMonitor, IAsyncTokenProvider asyncTokenProvider, IExtensionManager extensionManager, IEnumerable<IExtensionLoader> loaders)
	{
		_virtualPathMonitor = virtualPathMonitor;
		_asyncTokenProvider = asyncTokenProvider;
		_extensionManager = extensionManager;
		_loaders = loaders;
		Logger = NullLogger.Instance;
	}

	public void MonitorExtensions(Action<IVolatileToken> monitor)
	{
		if (!Disabled)
		{
			monitor(_asyncTokenProvider.GetToken(MonitorExtensionsWork));
		}
	}

	public void MonitorExtensionsWork(Action<IVolatileToken> monitor)
	{
		IEnumerable<string> enumerable = (from e in _extensionManager.AvailableExtensions()
			select e.Location).Distinct(StringComparer.InvariantCultureIgnoreCase);
		Logger.Information("Start monitoring extension files...");
		foreach (string item in enumerable)
		{
			Logger.Debug("Monitoring virtual path \"{0}\"", item);
			monitor(_virtualPathMonitor.WhenPathChanges(item));
		}
		foreach (ExtensionDescriptor item2 in (from d in _extensionManager.AvailableExtensions()
			where DefaultExtensionTypes.IsModule(d.ExtensionType) || DefaultExtensionTypes.IsTheme(d.ExtensionType)
			select d).ToList())
		{
			foreach (IExtensionLoader loader in _loaders)
			{
				loader.Monitor(item2, monitor);
			}
		}
		Logger.Information("Done monitoring extension files...");
	}
}
