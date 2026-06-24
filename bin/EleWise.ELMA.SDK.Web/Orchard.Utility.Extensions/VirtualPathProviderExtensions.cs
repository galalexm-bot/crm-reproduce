using Orchard.FileSystems.VirtualPath;

namespace Orchard.Utility.Extensions;

public static class VirtualPathProviderExtensions
{
	public static string GetProjectReferenceVirtualPath(this IVirtualPathProvider virtualPathProvider, string projectPath, string referenceName, string hintPath)
	{
		string directoryName = virtualPathProvider.GetDirectoryName(projectPath);
		string referenceVirtualPath = virtualPathProvider.GetReferenceVirtualPath(directoryName, referenceName, hintPath);
		if (!string.IsNullOrEmpty(referenceVirtualPath))
		{
			return virtualPathProvider.Combine(directoryName, referenceVirtualPath);
		}
		return null;
	}

	public static string GetReferenceVirtualPath(this IVirtualPathProvider virtualPathProvider, string basePath, string referenceName, string hintPath)
	{
		if (!string.IsNullOrEmpty(hintPath) && virtualPathProvider.TryFileExists(virtualPathProvider.Combine(basePath, hintPath)))
		{
			return hintPath;
		}
		string text = virtualPathProvider.Combine("bin", referenceName + ".dll");
		if (virtualPathProvider.TryFileExists(virtualPathProvider.Combine(basePath, text)))
		{
			return text;
		}
		return null;
	}
}
