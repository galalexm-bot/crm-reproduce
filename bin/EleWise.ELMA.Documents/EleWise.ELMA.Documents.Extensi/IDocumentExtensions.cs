using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Components;
using EleWise.ELMA.Documents.ExtensionPoint;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Extensions;

internal static class IDocumentExtensions
{
	private static IEnumerable<IDocumentCreateCheckerExtension> documentCreateCheckerExtensions;

	private static IEnumerable<IDocumentCreateCheckerExtension> DocumentCreatableCheckers => ComponentManager.Current.GetExtensionPoints<IDocumentCreateCheckerExtension>();

	private static ISecurityService SecurityService => Locator.GetServiceNotNull<ISecurityService>();

	internal static InitDocumentResult InitDocument(this IDocument document, ViewType viewType, long? folderId, bool disableProfileFolder, bool disableCreateAccess, bool documentWasNull, bool disableDefaultFolder)
	{
		Contract.ArgumentNotNull(document, "document");
		DocumentMetadata documentMetadata = (DocumentMetadata)MetadataLoader.LoadMetadata(document.CastAsRealType().GetType());
		InitDocumentResult initDocumentResult = new InitDocumentResult
		{
			Metadata = documentMetadata
		};
		CheckDocumentPermissions(document, viewType, documentMetadata, disableCreateAccess);
		if (documentWasNull)
		{
			if (string.IsNullOrEmpty(document.Name))
			{
				document.Name = SR.T(documentMetadata.TemplateName);
			}
			IDocumentMetadataProfile documentMetadataProfile = DocumentMetadataProfileManager.Instance.LoadByDocumentType(documentMetadata.ImplementationUid);
			if (documentMetadataProfile != null)
			{
				initDocumentResult.Profile = documentMetadataProfile;
				if (!disableProfileFolder && documentMetadataProfile.Folder != null)
				{
					ValidateFolderResult validateFolderResult = documentMetadataProfile.Folder.ValidateFolder();
					document.Folder = validateFolderResult.Folder;
					initDocumentResult.Messages = validateFolderResult.Messages;
				}
			}
			if (document.Folder == null)
			{
				if (!folderId.HasValue && !disableDefaultFolder)
				{
					CreateDocumentSettingsBlock serviceNotNull = Locator.GetServiceNotNull<CreateDocumentSettingsBlock>();
					if (serviceNotNull.Settings != null)
					{
						long folderId2 = serviceNotNull.Settings.FolderId;
						folderId = ((folderId2 != 0L) ? new int?((int)folderId2) : null);
					}
				}
				IFolder folder = null;
				if (folderId.HasValue)
				{
					Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
					{
						folder = FolderManager.Instance.Load(folderId.Value);
					});
					ValidateFolderResult validateFolderResult2 = folder.ValidateFolder();
					folder = validateFolderResult2.Folder;
					initDocumentResult.Messages = validateFolderResult2.Messages;
				}
				else
				{
					folder = Locator.GetServiceNotNull<ISystemFoldersService>().GetMyDocumentFolderForCurrentUser();
				}
				document.Folder = folder;
			}
		}
		IDocumentVersion documentVersion = ((IEnumerable<IDocumentVersion>)document.Versions).FirstOrDefault();
		if (((ICollection<IDocumentVersion>)document.Versions).Count == 0)
		{
			documentVersion = InterfaceActivator.Create<IDocumentVersion>();
			documentVersion.Document = document;
		}
		initDocumentResult.Version = documentVersion;
		return initDocumentResult;
	}

	private static void CheckDocumentPermissions(IDocument document, ViewType viewType, DocumentMetadata metadata, bool disableCreateAccess)
	{
		Contract.ArgumentNotNull(document, "document");
		if (!document.IsNew())
		{
			switch (viewType)
			{
			case ViewType.Create:
				break;
			case ViewType.Display:
				if (!SecurityService.HasPermission(PermissionProvider.DocumentViewPermission, document))
				{
					throw new SecurityException(SR.T("Недостаточно прав для просмотра объекта с идентификатором {0}", document.Id));
				}
				return;
			default:
				if (!SecurityService.HasPermission(PermissionProvider.DocumentEditPermission, document))
				{
					throw new SecurityException(SR.T("Недостаточно прав для редактирования объекта с идентификатором {0}", document.Id));
				}
				return;
			}
		}
		if (DocumentMetadataProfileManager.Instance.CreateableDocumentTypes("", null, disableCreateAccess).All((DocumentMetadata ct) => ct.Uid != metadata.Uid))
		{
			throw new SecurityException(SR.T("Недостаточно прав для создания документа типа \"{0}\", либо тип документа был удален", metadata.DisplayName));
		}
		Type type = document.GetType();
		foreach (IDocumentCreateCheckerExtension documentCreatableChecker in DocumentCreatableCheckers)
		{
			documentCreatableChecker.Check(type);
		}
	}
}
