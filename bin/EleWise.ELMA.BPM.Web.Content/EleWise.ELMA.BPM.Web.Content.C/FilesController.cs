using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Content.Services;
using EleWise.ELMA.Web.Mvc.Attributes;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

public class FilesController : BPMController
{
	public DbMediaFileProvider DbMediaFileProvider { get; set; }

	[WithoutSpa]
	[OutputCache(Duration = 300, VaryByParam = "path")]
	public ActionResult Index(string path)
	{
		string filePhysicalPath = DbMediaFileProvider.GetFilePhysicalPath(path);
		if (filePhysicalPath == null)
		{
			throw new HttpException(404, $"File Not Found. Path: {path}");
		}
		((Controller)this).get_Response().AddFileDependency(filePhysicalPath);
		return (ActionResult)(object)File(filePhysicalPath, "image/png");
	}
}
