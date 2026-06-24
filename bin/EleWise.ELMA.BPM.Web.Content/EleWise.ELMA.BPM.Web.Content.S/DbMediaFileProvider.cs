using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models.Media;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Html.FileBrowser;

namespace EleWise.ELMA.BPM.Web.Content.Services;

[Component]
public class DbMediaFileProvider : IMediaFileProvider, IModuleContainerEvents
{
	public const string RootFolderName = "Files";

	public IEntityManager<IMediaFolder> MediaFolderManager { get; set; }

	public IEntityManager<IMediaFile> MediaFileManager { get; set; }

	public IBLOBStore BLOBStore { get; set; }

	public IHttpContextAccessor HttpContextAccessor { get; set; }

	public Guid ProviderUid => Guid.Parse("38D67D56-A6F9-4FF8-9180-888B9B34E4D2");

	public string RootPath => "~/ContentArea/Files?path=/Files";

	public void Activated()
	{
		if (MediaFolderManager.Find((IMediaFolder f) => f.Parent == null && f.Name == "Files").FirstOrDefault() == null)
		{
			IMediaFolder mediaFolder = InterfaceActivator.Create<IMediaFolder>();
			mediaFolder.Name = "Files";
			MediaFolderManager.Save(mediaFolder);
		}
	}

	public void Terminating()
	{
	}

	private string ExtractPath(string requestPath)
	{
		int num = requestPath.IndexOf("/ContentArea/Files?path=");
		if (num >= 0)
		{
			return requestPath.Substring(num + "/ContentArea/Files?path=".Length);
		}
		return requestPath;
	}

	private IMediaFolder GetFolder(string folderPath)
	{
		if (folderPath == null)
		{
			throw new ArgumentNullException("folderPath");
		}
		IEnumerable<string> enumerable = from p in folderPath.Split('/', '\\')
			where !string.IsNullOrWhiteSpace(p)
			select p;
		IMediaFolder current = null;
		foreach (string item in enumerable)
		{
			string partCopy = item;
			IMediaFolder mediaFolder = MediaFolderManager.Find((IMediaFolder f) => f.Parent == current && f.Name == partCopy).FirstOrDefault();
			if (mediaFolder == null)
			{
				throw new DirectoryNotFoundException(SR.T("Не удалось найти папку \"{0}\" в пути \"{1}\"", item, folderPath));
			}
			current = mediaFolder;
		}
		if (current == null)
		{
			throw new DirectoryNotFoundException(SR.T("Не удалось найти папку \"{1}\"", folderPath));
		}
		return current;
	}

	public IEnumerable<FileEntry> GetFiles(string path)
	{
		IMediaFolder folder = GetFolder(ExtractPath(path));
		return from f in MediaFileManager.Find((IMediaFile f) => f.Parent == folder)
			select new FileEntry
			{
				Name = f.Name,
				Size = f.Size
			};
	}

	public IEnumerable<DirectoryEntry> GetDirectories(string path)
	{
		IMediaFolder folder = GetFolder(ExtractPath(path));
		return from f in MediaFolderManager.Find((IMediaFolder f) => f.Parent == folder)
			select new DirectoryEntry
			{
				Name = f.Name
			};
	}

	public string GetFilePhysicalPath(string path)
	{
		IMediaFile mediaFile = GetMediaFile(path);
		if (mediaFile == null)
		{
			return null;
		}
		string storedFilePath = GetStoredFilePath(mediaFile);
		if (!File.Exists(storedFilePath))
		{
			byte[] array = BLOBStore.LoadOrNull(mediaFile.StoreId);
			File.WriteAllBytes(storedFilePath, array ?? Array.Empty<byte>());
		}
		return storedFilePath;
	}

	private IMediaFile GetMediaFile(string path)
	{
		string[] source = ExtractPath(path).Split('/', '\\');
		string fileName = source.Last();
		string folderPath = string.Join("/", source.Take(source.Count() - 1).ToArray());
		IMediaFolder folder = GetFolder(folderPath);
		return MediaFileManager.Find((IMediaFile f) => f.Parent == folder && f.Name == fileName).FirstOrDefault();
	}

	private string GetStoredFilePath(IMediaFile mediaFile)
	{
		string text = HttpContextAccessor.Current().Server.MapPath("~/App_Data/MediaFiles");
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		return Path.Combine(text, mediaFile.StoreId);
	}

	[Transaction]
	public virtual void Upload(string path, HttpPostedFileBase httpPostedFileBase)
	{
		string folderPath = ExtractPath(path);
		IMediaFolder folder = GetFolder(folderPath);
		string fileName = Path.GetFileName(httpPostedFileBase.FileName);
		IMediaFile mediaFile = MediaFileManager.Find((IMediaFile f) => f.Parent == folder && f.Name == fileName).FirstOrDefault();
		if (mediaFile == null)
		{
			mediaFile = InterfaceActivator.Create<IMediaFile>();
			mediaFile.Name = fileName;
			mediaFile.Size = httpPostedFileBase.ContentLength;
			mediaFile.ContentType = httpPostedFileBase.ContentType;
			mediaFile.Parent = folder;
			mediaFile.StoreId = "media_file_" + Guid.NewGuid();
		}
		MediaFileManager.Save(mediaFile);
		string tempFileName = IOExtensions.GetTempFileName();
		httpPostedFileBase.SaveAs(tempFileName);
		byte[] value = File.ReadAllBytes(tempFileName);
		File.Delete(tempFileName);
		BLOBStore.Save(mediaFile.StoreId, value);
		string storedFilePath = GetStoredFilePath(mediaFile);
		if (File.Exists(storedFilePath))
		{
			File.Delete(storedFilePath);
		}
	}

	[Transaction]
	public virtual void DeleteFile(string path)
	{
		IMediaFile mediaFile = GetMediaFile(path);
		if (mediaFile != null)
		{
			DeleteFile(mediaFile);
		}
	}

	[Transaction]
	public virtual void CreateDirectory(string path, string name)
	{
		IMediaFolder folder = GetFolder(ExtractPath(path));
		if (MediaFolderManager.Find((IMediaFolder d) => d.Parent == folder && d.Name == name).FirstOrDefault() == null)
		{
			IMediaFolder mediaFolder = InterfaceActivator.Create<IMediaFolder>();
			mediaFolder.Name = name;
			mediaFolder.Parent = folder;
			MediaFolderManager.Save(mediaFolder);
		}
	}

	[Transaction]
	public virtual void DeleteDirectory(string path)
	{
		IMediaFolder folder = GetFolder(ExtractPath(path));
		if (folder.Parent == null)
		{
			return;
		}
		folder.AsDepthFirstEnumerable((IMediaFolder p) => MediaFolderManager.Find((IMediaFolder d) => d.Parent == p)).Reverse().ForEach(delegate(IMediaFolder d)
		{
			MediaFileManager.Find((IMediaFile f) => f.Parent == d).ForEach(DeleteFile);
			MediaFolderManager.Delete(d);
		});
	}

	private void DeleteFile(IMediaFile mediaFile)
	{
		MediaFileManager.Delete(mediaFile);
		string storedFilePath = GetStoredFilePath(mediaFile);
		if (File.Exists(storedFilePath))
		{
			File.Delete(storedFilePath);
		}
	}

	public bool CanManageFiles(string path)
	{
		return true;
	}

	public bool CanManageDirectories(string path)
	{
		return true;
	}
}
