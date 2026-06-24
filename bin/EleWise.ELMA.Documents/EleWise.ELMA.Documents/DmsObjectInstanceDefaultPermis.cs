using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Documents;

[Component]
public class DmsObjectInstanceDefaultPermission : IEntityInstanceDefaultPermission
{
	public DmsObjectManager DmsObjectManager { get; set; }

	public RunWithSoftDeletableService RunWithSoftDeletableService { get; set; }

	public Type EntityType => InterfaceActivator.TypeOf<IDmsObject>();

	public void CreatePermissions(IEntity entity)
	{
		bool turned = RunWithSoftDeletableService.Turned;
		RunWithSoftDeletableService.Turned = true;
		try
		{
			IDmsObject dmsObject = (IDmsObject)entity;
			if (((ICollection<IDmsObjectPermission>)dmsObject.Permissions).Count != 0)
			{
				return;
			}
			IDocumentMetadataProfile documentMetadataProfile = null;
			if (dmsObject.InheritPermissions && dmsObject.Folder == null)
			{
				dmsObject.InheritPermissions = false;
			}
			bool num = dmsObject is IDocument;
			List<IDmsObjectPermission> additionalPermissions = new List<IDmsObjectPermission>();
			if (num)
			{
				EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(dmsObject.GetType());
				documentMetadataProfile = DocumentMetadataProfileManager.Instance.LoadByDocumentType(entityMetadata.ImplementationUid);
				if (documentMetadataProfile != null)
				{
					dmsObject.InheritPermissions = documentMetadataProfile.DefaultPermissionType == DocumentDefaultPermissionType.FromFolder || documentMetadataProfile.DefaultPermissionType == DocumentDefaultPermissionType.FromFolderPlusCustom;
					if (documentMetadataProfile.DefaultPermissionType == DocumentDefaultPermissionType.FromFolderPlusCustom || documentMetadataProfile.DefaultPermissionType == DocumentDefaultPermissionType.Custom)
					{
						((IEnumerable<IDmsObjectDefaultPermissions>)documentMetadataProfile.Permissions).Where((IDmsObjectDefaultPermissions p) => p.PermissionId != PermissionProvider.DocumentMetadataCreateInstance.Id).ToList().ForEach(delegate(IDmsObjectDefaultPermissions p)
						{
							InstanceOf<IDmsObjectPermission> instanceOf13 = new InstanceOf<IDmsObjectPermission>();
							instanceOf13.New.DmsObject = dmsObject;
							instanceOf13.New.PermissionId = p.PermissionId;
							instanceOf13.New.TypeRoleId = p.TypeRoleId;
							instanceOf13.New.Assigned = p.Assigned;
							instanceOf13.New.PermissionRole = p.PermissionRole;
							instanceOf13.New.UserSecuritySetCacheId = p.UserSecuritySetCacheId;
							IDmsObjectPermission @new = instanceOf13.New;
							if (@new.TypeRoleId == CommonRoleTypes.Author.Id)
							{
								@new.User = dmsObject.CreationAuthor;
							}
							additionalPermissions.Add(@new);
						});
					}
				}
			}
			if (dmsObject.InheritPermissions)
			{
				DmsObjectManager.AddPermissionsFromParent(dmsObject);
				dmsObject.Permissions.AddAll((ICollection<IDmsObjectPermission>)additionalPermissions);
			}
			else
			{
				dmsObject.Permissions.AddAll((ICollection<IDmsObjectPermission>)additionalPermissions);
			}
			if (((IEnumerable<IDmsObjectPermission>)dmsObject.Permissions).Any((IDmsObjectPermission p) => p.TypeRoleId == CommonRoleTypes.Author.Id))
			{
				return;
			}
			if (documentMetadataProfile != null && documentMetadataProfile.AuthorDefaultPermissionId.HasValue)
			{
				if (documentMetadataProfile.AuthorDefaultPermissionId == PermissionProvider.DocumentViewPermission.Id || documentMetadataProfile.AuthorDefaultPermissionId == PermissionProvider.DocumentLoadPermission.Id || documentMetadataProfile.AuthorDefaultPermissionId == PermissionProvider.DocumentEditPermission.Id || documentMetadataProfile.AuthorDefaultPermissionId == PermissionProvider.DocumentFullAccessPermission.Id)
				{
					ISet<IDmsObjectPermission> permissions = dmsObject.Permissions;
					InstanceOf<IDmsObjectPermission> instanceOf = new InstanceOf<IDmsObjectPermission>();
					instanceOf.New.DmsObject = dmsObject;
					instanceOf.New.PermissionId = PermissionProvider.DocumentViewPermission.Id;
					instanceOf.New.TypeRoleId = CommonRoleTypes.Author.Id;
					instanceOf.New.User = dmsObject.CreationAuthor;
					permissions.Add(instanceOf.New);
				}
				if (documentMetadataProfile.AuthorDefaultPermissionId == PermissionProvider.DocumentLoadPermission.Id || documentMetadataProfile.AuthorDefaultPermissionId == PermissionProvider.DocumentEditPermission.Id || documentMetadataProfile.AuthorDefaultPermissionId == PermissionProvider.DocumentFullAccessPermission.Id)
				{
					ISet<IDmsObjectPermission> permissions2 = dmsObject.Permissions;
					InstanceOf<IDmsObjectPermission> instanceOf2 = new InstanceOf<IDmsObjectPermission>();
					instanceOf2.New.DmsObject = dmsObject;
					instanceOf2.New.PermissionId = PermissionProvider.DocumentLoadPermission.Id;
					instanceOf2.New.TypeRoleId = CommonRoleTypes.Author.Id;
					instanceOf2.New.User = dmsObject.CreationAuthor;
					permissions2.Add(instanceOf2.New);
				}
				if (documentMetadataProfile.AuthorDefaultPermissionId == PermissionProvider.DocumentEditPermission.Id || documentMetadataProfile.AuthorDefaultPermissionId == PermissionProvider.DocumentFullAccessPermission.Id)
				{
					ISet<IDmsObjectPermission> permissions3 = dmsObject.Permissions;
					InstanceOf<IDmsObjectPermission> instanceOf3 = new InstanceOf<IDmsObjectPermission>();
					instanceOf3.New.DmsObject = dmsObject;
					instanceOf3.New.PermissionId = PermissionProvider.DocumentEditPermission.Id;
					instanceOf3.New.TypeRoleId = CommonRoleTypes.Author.Id;
					instanceOf3.New.User = dmsObject.CreationAuthor;
					permissions3.Add(instanceOf3.New);
				}
				if (documentMetadataProfile.AuthorDefaultPermissionId == PermissionProvider.DocumentFullAccessPermission.Id)
				{
					ISet<IDmsObjectPermission> permissions4 = dmsObject.Permissions;
					InstanceOf<IDmsObjectPermission> instanceOf4 = new InstanceOf<IDmsObjectPermission>();
					instanceOf4.New.DmsObject = dmsObject;
					instanceOf4.New.PermissionId = PermissionProvider.DocumentFullAccessPermission.Id;
					instanceOf4.New.TypeRoleId = CommonRoleTypes.Author.Id;
					instanceOf4.New.User = dmsObject.CreationAuthor;
					permissions4.Add(instanceOf4.New);
				}
				if (documentMetadataProfile.AuthorAddAccessDefaulPermission || documentMetadataProfile.AuthorDefaultPermissionId == PermissionProvider.DocumentFullAccessPermission.Id)
				{
					ISet<IDmsObjectPermission> permissions5 = dmsObject.Permissions;
					InstanceOf<IDmsObjectPermission> instanceOf5 = new InstanceOf<IDmsObjectPermission>();
					instanceOf5.New.DmsObject = dmsObject;
					instanceOf5.New.PermissionId = PermissionProvider.DocumentManagerAccessPermission.Id;
					instanceOf5.New.TypeRoleId = CommonRoleTypes.Author.Id;
					instanceOf5.New.User = dmsObject.CreationAuthor;
					permissions5.Add(instanceOf5.New);
					ISet<IDmsObjectPermission> permissions6 = dmsObject.Permissions;
					InstanceOf<IDmsObjectPermission> instanceOf6 = new InstanceOf<IDmsObjectPermission>();
					instanceOf6.New.DmsObject = dmsObject;
					instanceOf6.New.PermissionId = PermissionProvider.DocumentCreatePermission.Id;
					instanceOf6.New.TypeRoleId = CommonRoleTypes.Author.Id;
					instanceOf6.New.User = dmsObject.CreationAuthor;
					permissions6.Add(instanceOf6.New);
				}
			}
			else
			{
				ISet<IDmsObjectPermission> permissions7 = dmsObject.Permissions;
				InstanceOf<IDmsObjectPermission> instanceOf7 = new InstanceOf<IDmsObjectPermission>();
				instanceOf7.New.DmsObject = dmsObject;
				instanceOf7.New.PermissionId = PermissionProvider.DocumentViewPermission.Id;
				instanceOf7.New.TypeRoleId = CommonRoleTypes.Author.Id;
				instanceOf7.New.User = dmsObject.CreationAuthor;
				permissions7.Add(instanceOf7.New);
				ISet<IDmsObjectPermission> permissions8 = dmsObject.Permissions;
				InstanceOf<IDmsObjectPermission> instanceOf8 = new InstanceOf<IDmsObjectPermission>();
				instanceOf8.New.DmsObject = dmsObject;
				instanceOf8.New.PermissionId = PermissionProvider.DocumentLoadPermission.Id;
				instanceOf8.New.TypeRoleId = CommonRoleTypes.Author.Id;
				instanceOf8.New.User = dmsObject.CreationAuthor;
				permissions8.Add(instanceOf8.New);
				ISet<IDmsObjectPermission> permissions9 = dmsObject.Permissions;
				InstanceOf<IDmsObjectPermission> instanceOf9 = new InstanceOf<IDmsObjectPermission>();
				instanceOf9.New.DmsObject = dmsObject;
				instanceOf9.New.PermissionId = PermissionProvider.DocumentEditPermission.Id;
				instanceOf9.New.TypeRoleId = CommonRoleTypes.Author.Id;
				instanceOf9.New.User = dmsObject.CreationAuthor;
				permissions9.Add(instanceOf9.New);
				ISet<IDmsObjectPermission> permissions10 = dmsObject.Permissions;
				InstanceOf<IDmsObjectPermission> instanceOf10 = new InstanceOf<IDmsObjectPermission>();
				instanceOf10.New.DmsObject = dmsObject;
				instanceOf10.New.PermissionId = PermissionProvider.DocumentManagerAccessPermission.Id;
				instanceOf10.New.TypeRoleId = CommonRoleTypes.Author.Id;
				instanceOf10.New.User = dmsObject.CreationAuthor;
				permissions10.Add(instanceOf10.New);
				if (dmsObject is IFolder)
				{
					ISet<IDmsObjectPermission> permissions11 = dmsObject.Permissions;
					InstanceOf<IDmsObjectPermission> instanceOf11 = new InstanceOf<IDmsObjectPermission>();
					instanceOf11.New.DmsObject = dmsObject;
					instanceOf11.New.PermissionId = PermissionProvider.DocumentCreatePermission.Id;
					instanceOf11.New.TypeRoleId = CommonRoleTypes.Author.Id;
					instanceOf11.New.User = dmsObject.CreationAuthor;
					permissions11.Add(instanceOf11.New);
				}
				ISet<IDmsObjectPermission> permissions12 = dmsObject.Permissions;
				InstanceOf<IDmsObjectPermission> instanceOf12 = new InstanceOf<IDmsObjectPermission>();
				instanceOf12.New.DmsObject = dmsObject;
				instanceOf12.New.PermissionId = PermissionProvider.DocumentFullAccessPermission.Id;
				instanceOf12.New.TypeRoleId = CommonRoleTypes.Author.Id;
				instanceOf12.New.User = dmsObject.CreationAuthor;
				permissions12.Add(instanceOf12.New);
			}
		}
		finally
		{
			RunWithSoftDeletableService.Turned = turned;
		}
	}
}
