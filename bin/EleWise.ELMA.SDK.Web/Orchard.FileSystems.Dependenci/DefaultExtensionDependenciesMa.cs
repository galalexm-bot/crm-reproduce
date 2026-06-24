using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using EleWise.ELMA.Logging;
using Orchard.Caching;
using Orchard.Exceptions;
using Orchard.FileSystems.AppData;
using Orchard.Logging;

namespace Orchard.FileSystems.Dependencies;

public class DefaultExtensionDependenciesManager : IExtensionDependenciesManager, IVolatileProvider, ISingletonDependency, IDependency
{
	private class InvalidationToken : IVolatileToken
	{
		public bool IsCurrent { get; set; }
	}

	private const string BasePath = "Dependencies";

	private const string FileName = "dependencies.compiled.xml";

	private readonly ICacheManager _cacheManager;

	private readonly IAppDataFolder _appDataFolder;

	private readonly InvalidationToken _writeThroughToken;

	public ILogger Logger { get; set; }

	public bool DisableMonitoring { get; set; }

	private string PersistencePath => _appDataFolder.Combine("Dependencies", "dependencies.compiled.xml");

	public DefaultExtensionDependenciesManager(ICacheManager cacheManager, IAppDataFolder appDataFolder)
	{
		_cacheManager = cacheManager;
		_appDataFolder = appDataFolder;
		_writeThroughToken = new InvalidationToken();
		Logger = NullLogger.Instance;
	}

	public void StoreDependencies(IEnumerable<DependencyDescriptor> dependencyDescriptors, Func<DependencyDescriptor, string> fileHashProvider)
	{
		Logger.Information("Storing module dependency file.");
		XDocument xDocument = CreateDocument(dependencyDescriptors, fileHashProvider);
		XDocument xDocument2 = ReadDocument(PersistencePath);
		if (XNode.DeepEquals(xDocument.Root, xDocument2.Root))
		{
			Logger.Debug("Existing document is identical to new one. Skipping save.");
		}
		else
		{
			WriteDocument(PersistencePath, xDocument);
		}
		Logger.Information("Done storing module dependency file.");
	}

	public IEnumerable<string> GetVirtualPathDependencies(string extensionId)
	{
		ActivatedExtensionDescriptor descriptor = GetDescriptor(extensionId);
		if (descriptor != null && IsSupportedLoader(descriptor.LoaderName))
		{
			yield return _appDataFolder.GetVirtualPath(PersistencePath);
		}
	}

	public ActivatedExtensionDescriptor GetDescriptor(string extensionId)
	{
		return LoadDescriptors().FirstOrDefault((ActivatedExtensionDescriptor d) => d.ExtensionId.Equals(extensionId, StringComparison.OrdinalIgnoreCase));
	}

	public IEnumerable<ActivatedExtensionDescriptor> LoadDescriptors()
	{
		return _cacheManager.Get(PersistencePath, preventConcurrentCalls: true, delegate(AcquireContext<string> ctx)
		{
			_appDataFolder.CreateDirectory("Dependencies");
			if (!DisableMonitoring)
			{
				ctx.Monitor(_appDataFolder.WhenPathChanges(ctx.Key));
			}
			_writeThroughToken.IsCurrent = true;
			ctx.Monitor(_writeThroughToken);
			return ReadDescriptors(ctx.Key).ToList();
		});
	}

	private XDocument CreateDocument(IEnumerable<DependencyDescriptor> dependencies, Func<DependencyDescriptor, string> fileHashProvider)
	{
		Func<string, XName> ns = (string name) => XName.Get(name);
		IEnumerable<XElement> source = from descriptor in dependencies.Where((DependencyDescriptor dep) => IsSupportedLoader(dep.LoaderName)).OrderBy((DependencyDescriptor dep) => dep.Name, StringComparer.OrdinalIgnoreCase)
			select new XElement(ns("Dependency"), new XElement(ns("ExtensionId"), descriptor.Name), new XElement(ns("LoaderName"), descriptor.LoaderName), new XElement(ns("VirtualPath"), descriptor.VirtualPath), new XElement(ns("Hash"), fileHashProvider(descriptor)));
		object[] array = new object[1];
		XName name2 = ns("Dependencies");
		object[] content = source.ToArray();
		array[0] = new XElement(name2, content);
		return new XDocument(array);
	}

	private IEnumerable<ActivatedExtensionDescriptor> ReadDescriptors(string persistancePath)
	{
		Func<string, XName> ns = (string name) => XName.Get(name);
		Func<XElement, string, string> elem = (XElement e, string name) => e.Element(ns(name)).Value;
		return (from e in ReadDocument(persistancePath).Elements(ns("Dependencies")).Elements(ns("Dependency"))
			select new ActivatedExtensionDescriptor
			{
				ExtensionId = elem(e, "ExtensionId"),
				VirtualPath = elem(e, "VirtualPath"),
				LoaderName = elem(e, "LoaderName"),
				Hash = elem(e, "Hash")
			}).ToList();
	}

	private bool IsSupportedLoader(string loaderName)
	{
		if (!(loaderName == "DynamicExtensionLoader"))
		{
			return loaderName == "PrecompiledExtensionLoader";
		}
		return true;
	}

	private void WriteDocument(string persistancePath, XDocument document)
	{
		_writeThroughToken.IsCurrent = false;
		using Stream stream = _appDataFolder.CreateFile(persistancePath);
		document.Save(stream, SaveOptions.None);
		stream.Close();
	}

	private XDocument ReadDocument(string persistancePath)
	{
		if (!_appDataFolder.FileExists(persistancePath))
		{
			return new XDocument();
		}
		try
		{
			using Stream stream = _appDataFolder.OpenFile(persistancePath);
			return XDocument.Load(stream);
		}
		catch (Exception ex)
		{
			if (ex.IsFatal())
			{
				throw;
			}
			Logger.Information(ex, "Error reading file '{0}'. Assuming empty.", persistancePath);
			return new XDocument();
		}
	}
}
