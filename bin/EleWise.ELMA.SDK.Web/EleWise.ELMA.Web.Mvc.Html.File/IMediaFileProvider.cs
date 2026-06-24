using System;
using System.Collections.Generic;
using System.Web;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.Html.FileBrowser;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IMediaFileProvider
{
	Guid ProviderUid { get; }

	string RootPath { get; }

	IEnumerable<FileEntry> GetFiles(string path);

	IEnumerable<DirectoryEntry> GetDirectories(string path);

	string GetFilePhysicalPath(string path);

	bool CanManageFiles(string path);

	bool CanManageDirectories(string path);

	void Upload(string path, HttpPostedFileBase httpPostedFileBase);

	void DeleteFile(string path);

	void CreateDirectory(string path, string name);

	void DeleteDirectory(string path);
}
