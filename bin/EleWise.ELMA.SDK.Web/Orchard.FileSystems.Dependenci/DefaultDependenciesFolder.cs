using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Orchard.Caching;
using Orchard.FileSystems.AppData;
using Orchard.Localization;
using Orchard.Utility.Extensions;

namespace Orchard.FileSystems.Dependencies;

public class DefaultDependenciesFolder : IDependenciesFolder, IVolatileProvider, ISingletonDependency, IDependency
{
	private class InvalidationToken : IVolatileToken
	{
		public bool IsCurrent { get; set; }
	}

	private class DependencyDescriptorComparer : EqualityComparer<DependencyDescriptor>
	{
		private readonly ReferenceDescriptorComparer _referenceDescriptorComparer = new ReferenceDescriptorComparer();

		public override bool Equals(DependencyDescriptor x, DependencyDescriptor y)
		{
			if (StringComparer.OrdinalIgnoreCase.Equals(x.Name, y.Name) && StringComparer.OrdinalIgnoreCase.Equals(x.LoaderName, y.LoaderName) && StringComparer.OrdinalIgnoreCase.Equals(x.VirtualPath, y.VirtualPath))
			{
				return x.References.SequenceEqual(y.References, _referenceDescriptorComparer);
			}
			return false;
		}

		public override int GetHashCode(DependencyDescriptor obj)
		{
			return StringComparer.OrdinalIgnoreCase.GetHashCode(obj.Name) ^ StringComparer.OrdinalIgnoreCase.GetHashCode(obj.LoaderName) ^ StringComparer.OrdinalIgnoreCase.GetHashCode(obj.VirtualPath) ^ obj.References.Aggregate(0, (int a, DependencyReferenceDescriptor entry) => a + _referenceDescriptorComparer.GetHashCode(entry));
		}
	}

	private class ReferenceDescriptorComparer : EqualityComparer<DependencyReferenceDescriptor>
	{
		public override bool Equals(DependencyReferenceDescriptor x, DependencyReferenceDescriptor y)
		{
			if (StringComparer.OrdinalIgnoreCase.Equals(x.Name, y.Name) && StringComparer.OrdinalIgnoreCase.Equals(x.LoaderName, y.LoaderName))
			{
				return StringComparer.OrdinalIgnoreCase.Equals(x.VirtualPath, y.VirtualPath);
			}
			return false;
		}

		public override int GetHashCode(DependencyReferenceDescriptor obj)
		{
			return StringComparer.OrdinalIgnoreCase.GetHashCode(obj.Name) ^ StringComparer.OrdinalIgnoreCase.GetHashCode(obj.LoaderName) ^ StringComparer.OrdinalIgnoreCase.GetHashCode(obj.VirtualPath);
		}
	}

	private const string BasePath = "Dependencies";

	private const string FileName = "dependencies.xml";

	private readonly ICacheManager _cacheManager;

	private readonly IAppDataFolder _appDataFolder;

	private readonly InvalidationToken _writeThroughToken;

	public Localizer T { get; set; }

	public bool DisableMonitoring { get; set; }

	private string PersistencePath => _appDataFolder.Combine("Dependencies", "dependencies.xml");

	public DefaultDependenciesFolder(ICacheManager cacheManager, IAppDataFolder appDataFolder)
	{
		_cacheManager = cacheManager;
		_appDataFolder = appDataFolder;
		_writeThroughToken = new InvalidationToken();
		T = NullLocalizer.Instance;
	}

	public DependencyDescriptor GetDescriptor(string moduleName)
	{
		return LoadDescriptors().SingleOrDefault((DependencyDescriptor d) => StringComparer.OrdinalIgnoreCase.Equals(d.Name, moduleName));
	}

	public IEnumerable<DependencyDescriptor> LoadDescriptors()
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
			return ReadDependencies(ctx.Key).ToReadOnlyCollection();
		});
	}

	public void StoreDescriptors(IEnumerable<DependencyDescriptor> dependencyDescriptors)
	{
		IOrderedEnumerable<DependencyDescriptor> second = from d in LoadDescriptors()
			orderby d.Name
			select d;
		if (!dependencyDescriptors.OrderBy((DependencyDescriptor d) => d.Name).SequenceEqual(second, new DependencyDescriptorComparer()))
		{
			WriteDependencies(PersistencePath, dependencyDescriptors);
		}
	}

	private IEnumerable<DependencyDescriptor> ReadDependencies(string persistancePath)
	{
		Func<string, XName> ns = (string name) => XName.Get(name);
		Func<XElement, string, string> elem = (XElement e, string name) => e.Element(ns(name)).Value;
		if (!_appDataFolder.FileExists(persistancePath))
		{
			return Enumerable.Empty<DependencyDescriptor>();
		}
		using Stream stream = _appDataFolder.OpenFile(persistancePath);
		return (from e in XDocument.Load(stream).Elements(ns("Dependencies")).Elements(ns("Dependency"))
			select new DependencyDescriptor
			{
				Name = elem(e, "ModuleName"),
				VirtualPath = elem(e, "VirtualPath"),
				LoaderName = elem(e, "LoaderName"),
				References = from r in e.Elements(ns("References")).Elements(ns("Reference"))
					select new DependencyReferenceDescriptor
					{
						Name = elem(r, "Name"),
						LoaderName = elem(r, "LoaderName"),
						VirtualPath = elem(r, "VirtualPath")
					}
			}).ToList();
	}

	private void WriteDependencies(string persistancePath, IEnumerable<DependencyDescriptor> dependencies)
	{
		Func<string, XName> ns = (string name) => XName.Get(name);
		XDocument xDocument = new XDocument();
		xDocument.Add(new XElement(ns("Dependencies")));
		IEnumerable<XElement> content = dependencies.Select(delegate(DependencyDescriptor d)
		{
			XName name2 = "Dependency";
			object[] obj = new object[4]
			{
				new XElement(ns("ModuleName"), d.Name),
				new XElement(ns("VirtualPath"), d.VirtualPath),
				new XElement(ns("LoaderName"), d.LoaderName),
				null
			};
			XName name3 = ns("References");
			object[] content2 = d.References.Select((DependencyReferenceDescriptor r) => new XElement(ns("Reference"), new XElement(ns("Name"), r.Name), new XElement(ns("LoaderName"), r.LoaderName), new XElement(ns("VirtualPath"), r.VirtualPath))).ToArray();
			obj[3] = new XElement(name3, content2);
			return new XElement(name2, obj);
		});
		xDocument.Root.Add(content);
		using (Stream stream = _appDataFolder.CreateFile(persistancePath))
		{
			xDocument.Save(stream, SaveOptions.None);
		}
		_writeThroughToken.IsCurrent = false;
	}
}
