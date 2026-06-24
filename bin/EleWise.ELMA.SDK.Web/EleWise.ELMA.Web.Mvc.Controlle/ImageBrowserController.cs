using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Web.Mvc.Html.FileBrowser;
using Telerik.Web.Mvc.Infrastructure;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.Web.Mvc.Controllers;

public class ImageBrowserController : EditorFileBrowserController
{
	private const int ThumbnailHeight = 80;

	private const int ThumbnailWidth = 80;

	private readonly IVirtualPathProvider virtualPathProvider;

	private readonly IThumbnailCreator thumbnailCreator;

	private readonly IEnumerable<IMediaFileProvider> mediaFileProviders;

	public ILogger Logger { get; set; }

	public override string[] ContentPaths => mediaFileProviders.Select((IMediaFileProvider p) => p.RootPath).ToArray();

	public ImageBrowserController(IEnumerable<IMediaFileProvider> mediaFileProviders)
	{
		this.mediaFileProviders = mediaFileProviders;
		virtualPathProvider = DI.get_Current().Resolve<IVirtualPathProvider>();
		thumbnailCreator = DI.get_Current().Resolve<IThumbnailCreator>();
	}

	public override bool AuthorizeBrowse(string path)
	{
		return true;
	}

	public override bool AuthorizeUpload(string path, HttpPostedFileBase file)
	{
		return GetByPath(path).CanManageFiles(path);
	}

	public override bool AuthorizeDeleteFile(string path)
	{
		return GetByPath(path).CanManageFiles(path);
	}

	public override bool AuthorizeDeleteDirectory(string path)
	{
		return GetByPath(path).CanManageDirectories(path);
	}

	public override bool AuthorizeCreateDirectory(string path, string name)
	{
		return GetByPath(path).CanManageDirectories(path);
	}

	public override JsonResult Browse(string path)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		path = NormalizePath(path);
		IMediaFileProvider byPath = GetByPath(path);
		if (((EditorFileBrowserController)this).AuthorizeBrowse(path))
		{
			try
			{
				BrowseResult val = new BrowseResult();
				val.set_Files(byPath.GetFiles(path).Select((Func<FileEntry, FileEntry>)delegate(FileEntry f)
				{
					//IL_0000: Unknown result type (might be due to invalid IL or missing references)
					//IL_0005: Unknown result type (might be due to invalid IL or missing references)
					//IL_0011: Unknown result type (might be due to invalid IL or missing references)
					//IL_001e: Expected O, but got Unknown
					FileEntry val6 = new FileEntry();
					val6.set_Name(f.Name);
					val6.set_Size(f.Size);
					return val6;
				}));
				val.set_Directories(byPath.GetDirectories(path).Select((Func<DirectoryEntry, DirectoryEntry>)delegate(DirectoryEntry d)
				{
					//IL_0000: Unknown result type (might be due to invalid IL or missing references)
					//IL_0005: Unknown result type (might be due to invalid IL or missing references)
					//IL_0012: Expected O, but got Unknown
					DirectoryEntry val5 = new DirectoryEntry();
					val5.set_Name(d.Name);
					return val5;
				}));
				val.set_Path(virtualPathProvider.AppendTrailingSlash(path));
				val.set_ContentPaths((from root in ((EditorFileBrowserController)this).get_ContentPaths()
					select virtualPathProvider.ToAbsolute(root)).ToArray());
				BrowseResult val2 = val;
				return ((Controller)this).Json((object)val2);
			}
			catch (DirectoryNotFoundException exception)
			{
				Logger.Error("File Not Found " + byPath, exception);
				BrowseResult val3 = new BrowseResult();
				val3.set_Files(Enumerable.Empty<FileEntry>());
				val3.set_Directories(Enumerable.Empty<DirectoryEntry>());
				val3.set_Path(virtualPathProvider.AppendTrailingSlash(path));
				val3.set_ContentPaths((from root in ((EditorFileBrowserController)this).get_ContentPaths()
					select virtualPathProvider.ToAbsolute(root)).ToArray());
				BrowseResult val4 = val3;
				return ((Controller)this).Json((object)val4);
			}
		}
		throw new HttpException(403, "Forbidden");
	}

	public override ActionResult Upload(string path, HttpPostedFileBase file)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		Guard.IsNotNull((object)file, "file");
		path = NormalizePath(path);
		string fileName = Path.GetFileName(file.FileName);
		IMediaFileProvider byPath = GetByPath(path);
		if (((EditorFileBrowserController)this).AuthorizeUpload(path, file))
		{
			byPath.Upload(path, file);
			return (ActionResult)(object)((Controller)this).Json((object)new FileEntry
			{
				Size = file.ContentLength,
				Name = fileName
			}, "text/plain");
		}
		return (ActionResult)new HttpStatusCodeResult(HttpStatusCode.Forbidden);
	}

	public override ActionResult DeleteFile(string path)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		path = NormalizePath(path);
		if (((EditorFileBrowserController)this).AuthorizeDeleteFile(path))
		{
			GetByPath(path).DeleteFile(path);
			return (ActionResult)(object)((Controller)this).Content("");
		}
		return (ActionResult)new HttpStatusCodeResult(HttpStatusCode.Forbidden);
	}

	[AcceptVerbs(/*Could not decode attribute arguments.*/)]
	public override ActionResult CreateDirectory(string path, string name)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		path = NormalizePath(path);
		if (((EditorFileBrowserController)this).AuthorizeCreateDirectory(path, name))
		{
			GetByPath(path).CreateDirectory(path, name);
			return (ActionResult)(object)((Controller)this).Content("");
		}
		return (ActionResult)new HttpStatusCodeResult(HttpStatusCode.Forbidden);
	}

	[AcceptVerbs(/*Could not decode attribute arguments.*/)]
	public override ActionResult DeleteDirectory(string path)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		path = NormalizePath(path);
		if (((EditorFileBrowserController)this).AuthorizeDeleteDirectory(path))
		{
			GetByPath(path).DeleteDirectory(path);
			return (ActionResult)(object)((Controller)this).Content("");
		}
		return (ActionResult)new HttpStatusCodeResult(HttpStatusCode.Forbidden);
	}

	[OutputCache(Duration = 3600, VaryByParam = "path")]
	public override ActionResult Thumbnail(string path)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		path = NormalizePath(path);
		IMediaFileProvider byPath = GetByPath(path);
		if (((EditorFileBrowserController)this).AuthorizeThumbnail(path))
		{
			string filePhysicalPath = byPath.GetFilePhysicalPath(path);
			if (filePhysicalPath != null && File.Exists(filePhysicalPath))
			{
				((Controller)this).get_Response().AddFileDependency(filePhysicalPath);
				return (ActionResult)(object)CreateThumbnail(filePhysicalPath);
			}
			Logger.Warn(SR.T("Не удалось найти путь \"{0}\"", path));
			return (ActionResult)new HttpStatusCodeResult(HttpStatusCode.NotFound);
		}
		return (ActionResult)new HttpStatusCodeResult(HttpStatusCode.Forbidden);
	}

	private FileContentResult CreateThumbnail(string physicalPath)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		using FileStream fileStream = File.OpenRead(physicalPath);
		ImageSize val = new ImageSize();
		val.set_Width(80);
		val.set_Height(80);
		ImageSize val2 = val;
		return ((Controller)this).File(thumbnailCreator.Create((Stream)fileStream, val2, "image/png"), "image/png");
	}

	public virtual IMediaFileProvider GetByPath(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (mediaFileProviders.Count() == 0)
		{
			throw new InvalidOperationException(SR.T("Не зарегистрировано ни одного файл провайдера"));
		}
		IMediaFileProvider mediaFileProvider = mediaFileProviders.FirstOrDefault((IMediaFileProvider p) => path.StartsWith(virtualPathProvider.ToAbsolute(p.RootPath)));
		if (mediaFileProvider == null)
		{
			throw new InvalidOperationException(SR.T("Не удалось соспоставить IMediaFileProvider по пути {0}", path));
		}
		return mediaFileProvider;
	}

	private string NormalizePath(string path)
	{
		if (string.IsNullOrEmpty(path))
		{
			return virtualPathProvider.ToAbsolute(((EditorFileBrowserController)this).get_ContentPaths().First());
		}
		return path;
	}
}
