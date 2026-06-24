using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Documents.ExtensionPoint;

[Component(Order = 100)]
public class DocumentBulkDataImportHandler : DmsObjectBulkDataImportHandler
{
	public override bool CanUse(Type type)
	{
		if (base.CanUse(type))
		{
			return typeof(IDocument).IsAssignableFrom(type);
		}
		return false;
	}

	public override void AfterImportPage(IEnumerable<MapInfo> mapInfos, BulkDataImportHandlerData handlerData)
	{
		Type documentType = typeof(IDocument);
		IEnumerable<Tuple<long, long>> ids = GetIdList(mapInfos, documentType, skipDocumentIds: false);
		if (!ids.Any())
		{
			return;
		}
		DataTable table = GetDmsObjectPermissionTable();
		if (!(mapInfos.FirstOrDefault((MapInfo inf) => documentType.IsAssignableFrom(inf.ObjectType)).Metadata is EntityMetadata entityMetadata))
		{
			return;
		}
		IDocumentMetadataProfile documentMetadataProfile = DocumentMetadataProfileManager.Instance.LoadByDocumentType(entityMetadata.ImplementationUid);
		if (documentMetadataProfile != null && (documentMetadataProfile.DefaultPermissionType == DocumentDefaultPermissionType.FromFolderPlusCustom || documentMetadataProfile.DefaultPermissionType == DocumentDefaultPermissionType.Custom))
		{
			((IEnumerable<IDmsObjectDefaultPermissions>)documentMetadataProfile.Permissions).Where((IDmsObjectDefaultPermissions p) => p.PermissionId != PermissionProvider.DocumentMetadataCreateInstance.Id).ToList().ForEach(delegate(IDmsObjectDefaultPermissions p)
			{
				foreach (Tuple<long, long> item in ids)
				{
					DataRow dataRow = table.NewRow();
					dataRow["Uid"] = Guid.NewGuid();
					dataRow["DmsObject"] = item.Item2;
					dataRow["PermissionId"] = p.PermissionId;
					dataRow["PermissionRole"] = p.PermissionRole;
					dataRow["UserSecuritySetCacheId"] = p.UserSecuritySetCacheId;
					if (p.TypeRoleId == CommonRoleTypes.Author.Id)
					{
						dataRow["User"] = item.Item1;
					}
					table.Rows.Add(dataRow);
					if (table.Rows.Count >= BulkInsertLimit)
					{
						base.Transformation.BulkInsert(DmsObjectPermissionTableName, table);
						table.Clear();
					}
				}
			});
		}
		List<Guid> list = new List<Guid>();
		if (documentMetadataProfile != null && documentMetadataProfile.AuthorDefaultPermissionId.HasValue)
		{
			if (documentMetadataProfile.AuthorDefaultPermissionId == PermissionProvider.DocumentViewPermission.Id || documentMetadataProfile.AuthorDefaultPermissionId == PermissionProvider.DocumentLoadPermission.Id || documentMetadataProfile.AuthorDefaultPermissionId == PermissionProvider.DocumentEditPermission.Id || documentMetadataProfile.AuthorDefaultPermissionId == PermissionProvider.DocumentFullAccessPermission.Id)
			{
				list.Add(PermissionProvider.DocumentViewPermission.Id);
			}
			if (documentMetadataProfile.AuthorDefaultPermissionId == PermissionProvider.DocumentLoadPermission.Id || documentMetadataProfile.AuthorDefaultPermissionId == PermissionProvider.DocumentEditPermission.Id || documentMetadataProfile.AuthorDefaultPermissionId == PermissionProvider.DocumentFullAccessPermission.Id)
			{
				list.Add(PermissionProvider.DocumentLoadPermission.Id);
			}
			if (documentMetadataProfile.AuthorDefaultPermissionId == PermissionProvider.DocumentEditPermission.Id || documentMetadataProfile.AuthorDefaultPermissionId == PermissionProvider.DocumentFullAccessPermission.Id)
			{
				list.Add(PermissionProvider.DocumentEditPermission.Id);
			}
			if (documentMetadataProfile.AuthorDefaultPermissionId == PermissionProvider.DocumentFullAccessPermission.Id)
			{
				list.Add(PermissionProvider.DocumentFullAccessPermission.Id);
			}
			if (documentMetadataProfile.AuthorAddAccessDefaulPermission || documentMetadataProfile.AuthorDefaultPermissionId == PermissionProvider.DocumentFullAccessPermission.Id)
			{
				list.Add(PermissionProvider.DocumentManagerAccessPermission.Id);
				list.Add(PermissionProvider.DocumentCreatePermission.Id);
			}
		}
		else
		{
			list = GetDefaultPermissionGuidList();
		}
		ExecuteInsertPermissions(ids, list, table);
	}

	public override void AfterImport(BulkDataImportHandlerData handlerData)
	{
		AddTypeForCleanUp(typeof(IDocument));
		base.AfterImport(handlerData);
		DocumentHistoryProfileManager.Instance.ClearCache();
	}
}
