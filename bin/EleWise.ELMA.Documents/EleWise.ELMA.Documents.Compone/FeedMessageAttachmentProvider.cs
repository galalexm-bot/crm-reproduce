using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.PropertyHandlers;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Components;

[Component]
internal class FeedMessageAttachmentProvider : IFeedMessageAttachmentProvider
{
	private static readonly Guid AttachmentTypeUid = AttributeHelper<ImplementationUidAttribute>.GetAttribute(typeof(IDocumentAttachment), inherited: false).Uid;

	public IEnumerable<MessageAttachment> GetMessageAtachments(IEntity target)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		ClassMetadata obj = (ClassMetadata)MetadataLoader.LoadMetadata(target.GetType());
		List<IDocumentAttachment> listAttachments = new List<IDocumentAttachment>();
		obj.Properties.Where((PropertyMetadata p) => p.Handlers.Any((PropertyHandlerInfo h) => h.HandlerUid == DocumentAttachmentsPropertyHandler.UID)).ToList().ForEach(delegate(PropertyMetadata p)
		{
			PropertyInfo reflectionProperty = target.GetType().GetReflectionProperty(p.Name);
			if (reflectionProperty != null && reflectionProperty.GetValue(target, null) is IEnumerable source)
			{
				listAttachments.AddRange(source.Cast<IDocumentAttachment>());
			}
		});
		if (target is IAttachmentsTaskBase attachmentsTaskBase)
		{
			listAttachments.AddRange((IEnumerable<IDocumentAttachment>)attachmentsTaskBase.DocumentAttachmentsSpecified);
		}
		return from a in listAttachments
			where a.Document != null
			select new MessageAttachment(a.Document.Name, AttachmentTypeUid, a.Uid.ToString());
	}
}
