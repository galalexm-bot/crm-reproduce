using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.PropertyHandlers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.Components;

[Component]
internal class FeedMessageAttachmentProvider : IFeedMessageAttachmentProvider
{
	private static readonly Guid AttachmentTypeUid = AttributeHelper<ImplementationUidAttribute>.GetAttribute(typeof(IAttachment), inherited: false).Uid;

	public IEnumerable<MessageAttachment> GetMessageAtachments(IEntity target)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		ClassMetadata obj = (ClassMetadata)MetadataLoader.LoadMetadata(target.GetType());
		List<IAttachment> listAttachments = new List<IAttachment>();
		obj.Properties.Where((PropertyMetadata p) => p.Handlers.Any((PropertyHandlerInfo h) => h.HandlerUid == AttachmentsPropertyHandler.UID)).ToList().ForEach(delegate(PropertyMetadata p)
		{
			PropertyInfo reflectionProperty = target.GetType().GetReflectionProperty(p.Name);
			if (reflectionProperty != null && reflectionProperty.GetValue(target, null) is IEnumerable source)
			{
				listAttachments.AddRange(source.Cast<IAttachment>());
			}
		});
		return listAttachments.Select((IAttachment a) => new MessageAttachment((a.File != null) ? a.File.Name : "unknown", AttachmentTypeUid, a.Uid.ToString()));
	}
}
