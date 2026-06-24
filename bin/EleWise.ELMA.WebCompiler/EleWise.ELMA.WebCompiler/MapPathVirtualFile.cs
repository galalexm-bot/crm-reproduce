using System.IO;
using System.Web.Hosting;

namespace EleWise.ELMA.WebCompiler;

public class MapPathVirtualFile : VirtualFile
{
	private readonly string physicalPath;

	public string PhysicalPath => physicalPath;

	public override string Name => physicalPath;

	public MapPathVirtualFile(string virtualPath, string physicalPath)
		: base(virtualPath)
	{
		this.physicalPath = physicalPath;
	}

	public override Stream Open()
	{
		return File.OpenRead(physicalPath);
	}
}
