using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Html.FileBrowser;

namespace EleWise.ELMA.BPM.Web.Content.Services;

[Component]
public class StaticMediaFileProvider : IMediaFileProvider
{
	private readonly string rootPhisicalDirectory;

	public IHttpContextAccessor HttpContextAccessor { get; set; }

	public Guid ProviderUid => Guid.Parse("BC599BDD-E27A-4AF1-89D5-1B4A0034E702");

	public string RootPath => "/Content/Images";

	public StaticMediaFileProvider()
	{
		rootPhisicalDirectory = HostingEnvironment.MapPath("~").Replace('/', '\\');
		if (Directory.Exists(Path.Combine(rootPhisicalDirectory, "..\\..\\..\\SDK\\EleWise.ELMA.SDK.Web")))
		{
			rootPhisicalDirectory = Path.GetFullPath(Path.Combine(rootPhisicalDirectory, "..\\..\\..\\SDK\\EleWise.ELMA.SDK.Web\\Mvc\\Templates"));
		}
	}

	public IEnumerable<FileEntry> GetFiles(string path)
	{
		return from f in new DirectoryInfo(GetPhisicalPath(path)).GetFiles("*")
			select new FileEntry
			{
				Name = f.Name,
				Size = f.Length
			};
	}

	public IEnumerable<DirectoryEntry> GetDirectories(string path)
	{
		return from subDirectory in new DirectoryInfo(GetPhisicalPath(path)).GetDirectories()
			select new DirectoryEntry
			{
				Name = subDirectory.Name
			};
	}

	public bool CanManageFiles(string path)
	{
		return false;
	}

	public bool CanManageDirectories(string path)
	{
		return false;
	}

	public void Upload(string path, HttpPostedFileBase httpPostedFileBase)
	{
		throw new NotImplementedException();
	}

	public void DeleteFile(string path)
	{
		throw new NotImplementedException();
	}

	public void CreateDirectory(string path, string name)
	{
		throw new NotImplementedException();
	}

	public void DeleteDirectory(string path)
	{
		throw new NotImplementedException();
	}

	public string GetFilePhysicalPath(string path)
	{
		return GetPhisicalPath(path);
	}

	private string GetPhisicalPath(string path)
	{
		path = path.Replace("..", "").Replace('/', '\\');
		if (path.StartsWith("~"))
		{
			path = path.Substring(1);
		}
		if (path.StartsWith("\\"))
		{
			path = path.Substring(1);
		}
		return Path.Combine(rootPhisicalDirectory, path);
	}
}
