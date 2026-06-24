using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Models;

public static class DocumentVersionExtensions
{
	public static bool CanEdit(this IDocumentVersion documentVersion, bool ignoreBlocked = false)
	{
		if (documentVersion == null)
		{
			return false;
		}
		if (documentVersion.IsBlocked)
		{
			if (!ignoreBlocked)
			{
				return false;
			}
			EleWise.ELMA.Security.Models.IUser user = (EleWise.ELMA.Security.Models.IUser)Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
			if (documentVersion.BlockAuthor != user)
			{
				return false;
			}
		}
		if (documentVersion.Status == DocumentVersionStatus.Deleted || documentVersion.Status == DocumentVersionStatus.InArchive || documentVersion.Status == DocumentVersionStatus.Signed)
		{
			return false;
		}
		if (DocumentVersionManager.Instance.IsSigned(documentVersion))
		{
			return false;
		}
		return documentVersion.HaveEditPermission();
	}

	public static bool HaveEditPermission(this IDocumentVersion documentVersion, bool isNewVersion = false)
	{
		if (documentVersion == null)
		{
			return false;
		}
		IAuthenticationService serviceNotNull = Locator.GetServiceNotNull<IAuthenticationService>();
		ISecurityService serviceNotNull2 = Locator.GetServiceNotNull<ISecurityService>();
		EleWise.ELMA.Security.Models.IUser user = (EleWise.ELMA.Security.Models.IUser)serviceNotNull.GetCurrentUser();
		if (!serviceNotNull2.HasPermission(user, PermissionProvider.DocumentFullAccessPermission, documentVersion.Document) && (!serviceNotNull2.HasPermission(user, PermissionProvider.DocumentEditPermission, documentVersion.Document) || !((!documentVersion.IsNew() && documentVersion.CreationAuthor == user) || isNewVersion)))
		{
			return false;
		}
		return true;
	}
}
