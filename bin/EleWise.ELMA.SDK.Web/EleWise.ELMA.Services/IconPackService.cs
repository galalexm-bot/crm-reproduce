using System.IO;
using System.Linq;
using System.Web.Hosting;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Managers;

namespace EleWise.ELMA.Services;

public class IconPackService : DTOManager, IIconPackService, IConfigurationService
{
	private string iconPackFolder;

	private string IconPackFolder
	{
		get
		{
			if (string.IsNullOrEmpty(iconPackFolder))
			{
				InitializePath();
			}
			return iconPackFolder;
		}
	}

	public virtual IconModel GetIcon(string name)
	{
		string text = Directory.EnumerateFiles(IconPackFolder).FirstOrDefault((string f) => Path.GetFileNameWithoutExtension(f).Equals(name));
		if (text != null)
		{
			return new IconModel
			{
				Name = name,
				Data = File.ReadAllText(text)
			};
		}
		return null;
	}

	private void InitializePath()
	{
		string path = HostingEnvironment.MapPath("~").Replace('/', '\\');
		if (Directory.Exists(Path.Combine(path, "..\\..\\..\\SDK\\EleWise.ELMA.SDK.Web")))
		{
			path = Path.GetFullPath(Path.Combine(path, "..\\..\\..\\SDK\\EleWise.ELMA.SDK.Web\\Mvc\\Templates"));
		}
		iconPackFolder = Path.Combine(path, "Content\\IconPack");
	}
}
