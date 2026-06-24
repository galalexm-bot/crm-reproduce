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
public class DocumentLinkWatchProvider : BaseWatchProvider
{
	public override IEnumerable<Guid> TypeUid
	{
		get
		{
			yield return InterfaceActivator.UID<IDocumentLink>();
		}
	}

	public override IEnumerable<Guid> ActionUids
	{
		get
		{
			yield return DocumentLinkActions.UserCreateGuid;
			yield return DocumentLinkActions.UserDeleteGuid;
			yield return DocumentLinkActions.UserEditGuid;
		}
	}

	public override IEnumerable<Guid> ParentTypeUid => from documentMetadata in MetadataServiceContext.Service.GetMetadataList().OfType<DocumentMetadata>()
		select documentMetadata.Uid;

	public override long? GetParentEntityId(IEntity entity)
	{
		if (entity == null)
		{
			return null;
		}
		if (entity is IDocumentLink documentLink)
		{
			if (documentLink.Document == null)
			{
				return null;
			}
			return documentLink.Document.Id;
		}
		return null;
	}

	public override IEnumerable<Guid> GetParentTypeUid(IEntity entity)
	{
		if (entity == null)
		{
			return ParentTypeUid;
		}
		if (entity is IDocumentLink documentLink)
		{
			if (documentLink.Document == null)
			{
				return ParentTypeUid;
			}
			ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(documentLink.Document.CastAsRealType().GetType());
			List<ClassMetadata> baseClasses = MetadataLoader.GetBaseClasses(classMetadata);
			baseClasses.Add(classMetadata);
			return baseClasses.Select((ClassMetadata ch) => ch.Uid).ToArray();
		}
		return ParentTypeUid;
	}

	public override bool CanSendToUser(IEntity entity, EleWise.ELMA.Security.Models.IUser user)
	{
		if (entity is IDocumentLink documentLink)
		{
			if (documentLink.Document == null)
			{
				return true;
			}
			return Locator.GetServiceNotNull<ISecurityService>().HasPermission(user, PermissionProvider.DocumentViewPermission, documentLink.Document.CastAsRealType());
		}
		return true;
	}
}
