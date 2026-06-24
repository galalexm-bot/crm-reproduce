using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Documents.Services;

public interface ISystemFoldersService
{
	IFolder SharedFolder { get; }

	IFilterDocumentFolder ArchiveFolder { get; }

	IFilterDocumentFolder GetArchiveFolderForCurrentUser(bool noSecurityException = false);

	IMyDocumentFolder GetMyDocumentFolder(IUser user);

	IMyDocumentFolder GetMyDocumentFolderForCurrentUser();

	IFavoritesFolder GetFavoritesFolder(IUser user);

	IFavoritesFolder GetFavoritesFolderForCurrentUser();

	void ClearAll();
}
