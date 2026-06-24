using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Components;

[Component(Order = 100)]
public class DocumentVersionWatchProvider : BaseWatchProvider
{
	public override IEnumerable<Guid> TypeUid
	{
		get
		{
			yield return InterfaceActivator.UID<IDocumentVersion>();
		}
	}

	public override IEnumerable<Guid> ActionUids
	{
		get
		{
			yield return DocumentVersionActions.ChangeStatusGuid;
			yield return DocumentVersionActions.EditGuid;
			yield return DocumentVersionActions.LockGuid;
			yield return DocumentVersionActions.UnLockGuid;
			yield return DocumentVersionActions.UserCreateGuid;
			yield return DocumentVersionActions.DownloadGuid;
		}
	}

	public override IEnumerable<Guid> ParentTypeUid => from documentMetadata in MetadataServiceContext.Service.GetMetadataList().OfType<DocumentMetadata>()
		select documentMetadata.Uid;

	public override IEnumerable<Guid> GetParentTypeUid(IEntity entity)
	{
		if (entity == null)
		{
			return ParentTypeUid;
		}
		if (entity is IDocumentVersion documentVersion)
		{
			if (documentVersion.Document == null)
			{
				return ParentTypeUid;
			}
			ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(documentVersion.Document.CastAsRealType().GetType());
			List<ClassMetadata> baseClasses = MetadataLoader.GetBaseClasses(classMetadata);
			baseClasses.Add(classMetadata);
			return baseClasses.Select((ClassMetadata ch) => ch.Uid).ToArray();
		}
		return ParentTypeUid;
	}

	public override long? GetParentEntityId(IEntity entity)
	{
		if (entity == null)
		{
			return null;
		}
		if (entity is IDocumentVersion documentVersion)
		{
			if (documentVersion.Document == null)
			{
				return null;
			}
			return documentVersion.Document.Id;
		}
		return null;
	}

	public override bool CanSendToUser(IEntity entity, EleWise.ELMA.Security.Models.IUser user)
	{
		if (entity is IDocumentVersion documentVersion)
		{
			if (documentVersion.Document == null)
			{
				return true;
			}
			return Locator.GetServiceNotNull<ISecurityService>().HasPermission(user, PermissionProvider.DocumentViewPermission, documentVersion.Document.CastAsRealType());
		}
		return true;
	}
}
