using System.Collections.Generic;

namespace EleWise.ELMA.Web.Mvc.Html.FileBrowser;

public interface IStaticMediaFileService
{
	IEnumerable<FileEntry> GetFiles(string webPath);

	IEnumerable<DirectoryEntry> GetDirectories(string webPath);

	string GetWebPath(string path);

	string GetPhysicalPath(string webPath);
}
