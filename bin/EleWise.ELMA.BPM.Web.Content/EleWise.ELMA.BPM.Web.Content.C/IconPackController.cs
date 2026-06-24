using System.Collections.Generic;
using System.IO;
using System.Web.Hosting;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

public class IconPackController : BPMController
{
	private readonly IIconPackService iconPackService;

	public IconPackController(IIconPackService iconPackService)
	{
		this.iconPackService = iconPackService;
	}

	public ActionResult Collection()
	{
		List<string> list = new List<string>();
		foreach (string item in GetIconPack())
		{
			list.Add(Path.GetFileName(item));
		}
		return (ActionResult)(object)((Controller)this).View("IconPack", (object)list);
	}

	private IEnumerable<string> GetIconPack()
	{
		string path = HostingEnvironment.MapPath("~").Replace('/', '\\');
		if (Directory.Exists(Path.Combine(path, "..\\..\\..\\SDK\\EleWise.ELMA.SDK.Web")))
		{
			path = Path.GetFullPath(Path.Combine(path, "..\\..\\..\\SDK\\EleWise.ELMA.SDK.Web\\Mvc\\Templates"));
		}
		return Directory.EnumerateFiles(Path.Combine(path, "Content\\IconPack"), "*.svg");
	}
}
