using Orchard.Environment.Descriptor.Models;
using Orchard.Environment.Extensions;
using Orchard.FileSystems.VirtualPath;

namespace Orchard.DisplayManagement.Descriptors.ResourceBindingStrategy;

public class StylesheetBindingStrategy : StaticFileBindingStrategy, IShapeTableProvider, IDependency
{
	public StylesheetBindingStrategy(IExtensionManager extensionManager, ShellDescriptor shellDescriptor, IVirtualPathProvider virtualPathProvider)
		: base(extensionManager, shellDescriptor, virtualPathProvider)
	{
	}

	public override string GetFileExtension()
	{
		return ".css";
	}

	public override string GetFolder()
	{
		return "Styles";
	}

	public override string GetShapePrefix()
	{
		return "Style__";
	}
}
