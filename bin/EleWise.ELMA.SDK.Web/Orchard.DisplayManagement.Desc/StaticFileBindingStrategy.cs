using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Orchard.DisplayManagement.Implementation;
using Orchard.Environment.Descriptor.Models;
using Orchard.Environment.Extensions;
using Orchard.Environment.Extensions.Models;
using Orchard.FileSystems.VirtualPath;
using Orchard.UI.Resources;
using Orchard.Utility.Extensions;

namespace Orchard.DisplayManagement.Descriptors.ResourceBindingStrategy;

public abstract class StaticFileBindingStrategy
{
	private readonly IExtensionManager _extensionManager;

	private readonly ShellDescriptor _shellDescriptor;

	private readonly IVirtualPathProvider _virtualPathProvider;

	private static readonly char[] UnsafeCharList = "/:?#[]@!&'()*+,;=\r\n\t\f\" <>.-_".ToCharArray();

	protected StaticFileBindingStrategy(IExtensionManager extensionManager, ShellDescriptor shellDescriptor, IVirtualPathProvider virtualPathProvider)
	{
		_extensionManager = extensionManager;
		_shellDescriptor = shellDescriptor;
		_virtualPathProvider = virtualPathProvider;
	}

	public abstract string GetFileExtension();

	public abstract string GetFolder();

	public abstract string GetShapePrefix();

	private static string SafeName(string name)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			return string.Empty;
		}
		return name.Strip(UnsafeCharList).ToLowerInvariant();
	}

	public static string GetAlternateShapeNameFromFileName(string fileName)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		string name;
		if (Uri.IsWellFormedUriString(fileName, UriKind.Absolute) || (fileName.StartsWith("//", StringComparison.InvariantCulture) && Uri.IsWellFormedUriString("http:" + fileName, UriKind.Absolute)))
		{
			if (fileName.StartsWith("//", StringComparison.InvariantCulture))
			{
				fileName = "http:" + fileName;
			}
			Uri uri = new Uri(fileName);
			name = uri.Authority + "$" + uri.AbsolutePath + "$" + uri.Query;
		}
		else
		{
			name = Path.GetFileNameWithoutExtension(fileName);
		}
		return SafeName(name);
	}

	private static IEnumerable<ExtensionDescriptor> Once(IEnumerable<FeatureDescriptor> featureDescriptors)
	{
		ConcurrentDictionary<string, object> once = new ConcurrentDictionary<string, object>();
		return (from fd in featureDescriptors
			select fd.Extension into ed
			where once.TryAdd(ed.Id, null)
			select ed).ToList();
	}

	public void Discover(ShapeTableBuilder builder)
	{
		foreach (var item in Once(_extensionManager.AvailableFeatures().Where(FeatureIsEnabled)).SelectMany(delegate(ExtensionDescriptor extensionDescriptor)
		{
			string path = Path.Combine(extensionDescriptor.Location, extensionDescriptor.Id).Replace(Path.DirectorySeparatorChar, '/');
			string virtualPath = Path.Combine(path, GetFolder()).Replace(Path.DirectorySeparatorChar, '/');
			return from fileName in _virtualPathProvider.ListFiles(virtualPath).Select(Path.GetFileName)
				where string.Equals(Path.GetExtension(fileName), GetFileExtension(), StringComparison.OrdinalIgnoreCase)
				select fileName into cssFileName
				select new
				{
					fileName = Path.GetFileNameWithoutExtension(cssFileName),
					fileVirtualPath = Path.Combine(virtualPath, cssFileName).Replace(Path.DirectorySeparatorChar, '/'),
					shapeType = GetShapePrefix() + GetAlternateShapeNameFromFileName(cssFileName),
					extensionDescriptor = extensionDescriptor
				};
		}))
		{
			var hit = item;
			foreach (FeatureDescriptor item2 in hit.extensionDescriptor.Features.Where((FeatureDescriptor fd) => fd.Id == hit.extensionDescriptor.Id))
			{
				builder.Describe(item.shapeType).From(new Feature
				{
					Descriptor = item2
				}).BoundAs(hit.fileVirtualPath, (ShapeDescriptor shapeDescriptor) => delegate(DisplayContext displayContext)
				{
					object value = displayContext.Value;
					TextWriter writer = displayContext.ViewContext.get_Writer();
					ResourceDefinition resource = ((dynamic)value).Resource;
					string condition = ((dynamic)value).Condition;
					Dictionary<string, string> attributes = ((dynamic)value).TagAttributes;
					ResourceManager.WriteResource(writer, resource, hit.fileVirtualPath, condition, attributes);
					return null;
				});
			}
		}
	}

	private bool FeatureIsEnabled(FeatureDescriptor fd)
	{
		if (!DefaultExtensionTypes.IsTheme(fd.Extension.ExtensionType) || (!(fd.Id == "TheAdmin") && !(fd.Id == "SafeMode")))
		{
			return _shellDescriptor.Features.Any((ShellFeature sf) => sf.Name == fd.Id);
		}
		return true;
	}
}
