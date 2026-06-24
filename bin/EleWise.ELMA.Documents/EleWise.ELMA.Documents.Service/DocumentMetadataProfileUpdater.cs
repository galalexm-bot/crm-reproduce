using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Documents.Services;

[Service]
internal class DocumentMetadataProfileUpdaterService : IDocumentMetadataProfileUpdaterService
{
	private IMetadataRuntimeService metadataRuntimeService;

	private IEnumerable<IDocumentMetadataProfileInitProvider> documentMetadataProfileInitProviders;

	private DocumentMetadataProfileManager documentMetadataProfileManager;

	private UserManager userManager;

	private UserGroupManager userGroupManager;

	public DocumentMetadataProfileUpdaterService(IMetadataRuntimeService metadataRuntimeService, IEnumerable<IDocumentMetadataProfileInitProvider> documentMetadataProfileInitProviders, DocumentMetadataProfileManager documentMetadataProfileManager, UserGroupManager userGroupManager, UserManager userManager)
	{
		this.metadataRuntimeService = metadataRuntimeService;
		this.documentMetadataProfileInitProviders = documentMetadataProfileInitProviders;
		this.documentMetadataProfileManager = documentMetadataProfileManager;
		this.userGroupManager = userGroupManager;
		this.userManager = userManager;
	}

	public void CreateProfiles(IEnumerable<DocumentMetadata> newMetadataList)
	{
		foreach (DocumentMetadata newMetadata in newMetadataList)
		{
			CreateDocumentMetadataProfile(newMetadata);
		}
	}

	public void UpdateProfiles()
	{
		if (metadataRuntimeService == null)
		{
			return;
		}
		IEnumerable<AssemblyModelsMetadata> previousAssemblyModelsMetadataList = metadataRuntimeService.GetPreviousAssemblyModelsMetadataList();
		IEnumerable<AssemblyModelsMetadata> assemblyModelsMetadataList = metadataRuntimeService.GetAssemblyModelsMetadataList();
		List<DocumentMetadata> previousDocuments = new List<DocumentMetadata>();
		foreach (AssemblyModelsMetadata item in previousAssemblyModelsMetadataList)
		{
			AbstractMetadata[] source = item.RestoreMetadata();
			previousDocuments.AddRange(from m in source.OfType<DocumentMetadata>()
				where m.Type == EntityMetadataType.Interface
				select m);
		}
		List<DocumentMetadata> list = new List<DocumentMetadata>();
		foreach (AssemblyModelsMetadata item2 in assemblyModelsMetadataList)
		{
			AbstractMetadata[] source2 = item2.RestoreMetadata();
			list.AddRange(from m in source2.OfType<DocumentMetadata>()
				where m.Type == EntityMetadataType.Interface
				select m);
		}
		list.Where((DocumentMetadata d) => !previousDocuments.Any((DocumentMetadata m) => m.Uid == d.Uid)).ToList().ForEach(delegate(DocumentMetadata documentMetadata)
		{
			CreateDocumentMetadataProfile(documentMetadata);
		});
	}

	private void CreateDocumentMetadataProfile(DocumentMetadata documentMetadata)
	{
		IDocumentMetadataProfile profile = documentMetadataProfileManager.LoadByDocumentType(documentMetadata.Uid);
		if (profile == null)
		{
			profile = InterfaceActivator.Create<IDocumentMetadataProfile>();
			profile.DocumentType = new ReferenceOnEntityType
			{
				TypeUid = documentMetadata.Uid
			};
			profile.CreationAuthor = userManager.Load(SecurityConstants.SystemUserUid);
			IUserGroup userGroup = userGroupManager.Load(SecurityConstants.AllUsersGroupUid);
			ISet<IDmsObjectDefaultPermissions> permissions = profile.Permissions;
			InstanceOf<IDmsObjectDefaultPermissions> instanceOf = new InstanceOf<IDmsObjectDefaultPermissions>();
			instanceOf.New.DocumentMetadataProfile = profile;
			instanceOf.New.PermissionId = PermissionProvider.DocumentMetadataCreateInstance.Id;
			instanceOf.New.TypeRoleId = CommonRoleTypes.Group.Id;
			instanceOf.New.Group = userGroup;
			instanceOf.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetGroupMask(userGroup.Id);
			permissions.Add(instanceOf.New);
			documentMetadataProfileInitProviders.Where((IDocumentMetadataProfileInitProvider p) => p.CheckType(documentMetadata.Uid)).ToList().ForEach(delegate(IDocumentMetadataProfileInitProvider p)
			{
				p.Init(profile);
			});
			profile.Save();
		}
	}
}
