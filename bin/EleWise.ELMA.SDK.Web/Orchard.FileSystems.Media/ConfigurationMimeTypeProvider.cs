using System.Web;

namespace Orchard.FileSystems.Media;

public class ConfigurationMimeTypeProvider : IMimeTypeProvider, IDependency
{
	public string GetMimeType(string path)
	{
		return MimeMapping.GetMimeMapping(path);
	}
}
