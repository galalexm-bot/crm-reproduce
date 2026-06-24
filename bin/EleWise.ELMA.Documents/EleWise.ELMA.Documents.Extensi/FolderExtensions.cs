using System.Collections.Generic;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Extensions;

internal static class FolderExtensions
{
	internal static ValidateFolderResult ValidateFolder(this IFolder folder)
	{
		List<string> list = new List<string>();
		ISecurityService service = Locator.GetService<ISecurityService>();
		ISystemFoldersService serviceNotNull = Locator.GetServiceNotNull<ISystemFoldersService>();
		if (!service.HasPermission(PermissionProvider.DocumentCreatePermission, folder) && !service.HasPermission(PermissionProvider.DocumentFullAccessPermission, folder))
		{
			folder = serviceNotNull.GetMyDocumentFolderForCurrentUser();
			list.Add(SR.T("Нет права на создание документов в папке \"{0}\" (идентификатор: {1}). Папка сброшена на папку документов текущего пользователя.", folder, folder.Id));
		}
		if (folder.Uid == DocumentConstants.ArchiveFolderUid)
		{
			folder = serviceNotNull.GetMyDocumentFolderForCurrentUser();
			list.Add(SR.T("Папка является архивом. Папка сброшена на папку документов текущего пользователя.", folder, folder.Id));
		}
		return new ValidateFolderResult
		{
			Folder = folder,
			Messages = list.ToArray()
		};
	}
}
