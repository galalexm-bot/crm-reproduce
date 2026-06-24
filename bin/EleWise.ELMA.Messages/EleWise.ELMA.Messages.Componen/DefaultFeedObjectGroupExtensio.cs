using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Messages.Components.Feed;

[Component(Order = 100000)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public class DefaultFeedObjectGroupExtension : IFeedObjectGroupExtension
{
	public virtual string MessageTypeCssClass => "FeedTypeDefault";

	public virtual string CommentaryDescription => SR.T("Оставить комментарий");

	public virtual bool IsSupport(Guid objectTypeUid)
	{
		return true;
	}

	public virtual string MessageTypeName(Guid objectTypeUid)
	{
		Type entityType = ModelHelper.GetEntityType(objectTypeUid);
		if (entityType == null)
		{
			return "";
		}
		if (!(InterfaceActivator.LoadMetadata(entityType) is EntityMetadata entityMetadata))
		{
			return "";
		}
		return entityMetadata.DisplayName;
	}
}
