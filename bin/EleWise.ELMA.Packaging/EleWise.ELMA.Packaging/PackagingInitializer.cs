using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using EleWise.ELMA.Packaging.Logging;
using NuGet;

namespace EleWise.ELMA.Packaging;

public class PackagingInitializer : IDisposable
{
	private AggregateCatalog _catalog;

	private CompositionContainer _compositionContainer;

	private PackagingHelper _helper;

	public CompositionContainer CompositionContainer => _compositionContainer;

	public static PackagingInitializer Current { get; private set; }

	public PackagingInitializer(IEnumerable<Assembly> compositionAssemblies, PackagingSettings settings, ILogger logger)
		: this(compositionAssemblies, settings, logger, null)
	{
	}

	public PackagingInitializer(IEnumerable<Assembly> compositionAssemblies, PackagingSettings settings, ILogger logger, ILogger nuGetLogger)
	{
		SR.DesignMode = false;
		_catalog = new AggregateCatalog(compositionAssemblies.Select((Assembly a) => new AssemblyCatalog(a)));
		_compositionContainer = new CompositionContainer(_catalog);
		_compositionContainer.ComposeExportedValue(settings);
		_compositionContainer.ComposeExportedValue(this);
		if (logger == null)
		{
			logger = Logger.Log;
		}
		if (nuGetLogger == null)
		{
			nuGetLogger = (ILogger)(object)new NugetLoggerShim(logger);
		}
		_compositionContainer.ComposeExportedValue(logger);
		_compositionContainer.ComposeExportedValue<ILogger>(nuGetLogger);
		_helper = new PackagingHelper(settings);
		_compositionContainer.ComposeExportedValue(_helper);
		ServicePointManager.ServerCertificateValidationCallback = (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true;
		Current = this;
	}

	public T ComposeParts<T>(T obj)
	{
		CompositionContainer.ComposeParts(obj);
		return obj;
	}

	public void Dispose()
	{
		if (_compositionContainer != null)
		{
			_compositionContainer.Dispose();
			_compositionContainer = null;
		}
		if (_catalog != null)
		{
			_catalog.Dispose();
			_catalog = null;
		}
	}
}
