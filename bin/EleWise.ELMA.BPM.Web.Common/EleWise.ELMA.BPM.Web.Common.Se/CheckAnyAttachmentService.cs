using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.BPM.Web.Common.Services;

[Service(Type = ComponentType.WebServer, InjectProperties = true, Scope = ServiceScope.Shell, EnableInterceptors = false)]
internal class CheckAnyAttachmentService : ICheckAnyAttachmentServiceExt, ICheckAnyAttachmentService
{
	public IEnumerable<IObjectAttachmentExtension> ObjectAttachmentExtensions { get; set; }

	public IEnumerable<IObjectAttachmentWithPropertyExtension> PropertyAttachmentExtensions { get; set; }

	public bool CheckAnyAttachments(Guid typeUid, IEntity entity)
	{
		return ObjectAttachmentExtensions.Where((IObjectAttachmentExtension p) => p.EntityType(typeUid)).Any((IObjectAttachmentExtension x) => x.IsAnyAttachments(entity));
	}

	public bool CheckAnyAttachmentsSpecified(Guid typeUid, IEntity entity)
	{
		return ObjectAttachmentExtensions.Where((IObjectAttachmentExtension p) => p is IObjectAttachmentSpecified && p.EntityType(typeUid)).Any((IObjectAttachmentExtension x) => ((IObjectAttachmentSpecified)x).IsAnyAttachmentsSpecified(entity));
	}

	public bool CheckAnyFile(Guid typeUid, IEntity entity)
	{
		return ObjectAttachmentExtensions.Where((IObjectAttachmentExtension p) => p.EntityType(typeUid)).Any((IObjectAttachmentExtension x) => x.IsAnyAttachments(entity));
	}

	public long GetCountAttachments(Guid typeUid, IEntity entity)
	{
		return ObjectAttachmentExtensions.Where((IObjectAttachmentExtension p) => p.EntityType(typeUid)).SelectMany((IObjectAttachmentExtension x) => x.GetAttachments(entity)).Count();
	}

	public bool CheckAnyTwoAndMoreAttachmentsFromProperty(Guid typeUid, long id, string propertyUid)
	{
		IObjectAttachmentWithPropertyExtension[] array = PropertyAttachmentExtensions.Where((IObjectAttachmentWithPropertyExtension p) => p.EntityType(typeUid)).ToArray();
		if (array.Length == 0)
		{
			return false;
		}
		IEntity entity = ModelHelper.GetEntity(typeUid, id);
		return array.Any((IObjectAttachmentWithPropertyExtension x) => x.GetAttachments(entity, propertyUid).Count() > 1);
	}
}
