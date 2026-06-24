using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Web.Extensions;

public static class FolderExtension
{
	public static string GetPath(this IFolder folder)
	{
		return FolderManager.Instance.GetFolderPath(folder);
	}

	public static string GetConvertPath(this IFolder folder, bool convertMyDocuments = false)
	{
		return FolderManager.Instance.GetFolderPath(folder, convertMyDocuments);
	}

	public static string GetFolderConvertedName(this IFolder folder)
	{
		long num = (long)Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser().GetId();
		if (folder.FolderType == FolderType.MyDocuments && folder.CreationAuthor.Id != num)
		{
			return SR.T("Документы ({0})", folder.CreationAuthor.FullName);
		}
		return folder.Name;
	}

	public static bool IsEditPermission(this IFolder folder)
	{
		ISecurityService service = Locator.GetService<ISecurityService>();
		if (service != null)
		{
			if (!service.HasPermission(PermissionProvider.DocumentEditPermission, folder))
			{
				return service.HasPermission(PermissionProvider.DocumentFullAccessPermission, folder);
			}
			return true;
		}
		return false;
	}
}
