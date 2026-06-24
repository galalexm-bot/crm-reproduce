using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.PropertyHandlers;
using EleWise.ELMA.Dynamic;
using EleWise.ELMA.Events;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Notifications;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Components;

[Component]
public class CommentDocumentsActionHandler : ICommentActionHandler, IEventHandler, ICommentActionProcessHandler, INotificationMessageHandler
{
	public const string DocumentAttachmentsKey = "DocumentAttachments";

	public void Process([NotNull] object target, ICommentActionModel commentModel)
	{
		Process(target, commentModel, addAttachmentToTarget: true);
	}

	public void Process([NotNull] object target, ICommentActionModel commentModel, bool addAttachmentToTarget)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		ICommentWithDocumentsActionModel docCommentModel = commentModel as ICommentWithDocumentsActionModel;
		if (docCommentModel == null)
		{
			return;
		}
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(target.GetType());
		if (docCommentModel.DocumentAttachments != null && docCommentModel.DocumentAttachments.Count > 0)
		{
			classMetadata.Properties.Where((PropertyMetadata p) => p.Handlers.Any((PropertyHandlerInfo h) => h.HandlerUid == DocumentAttachmentsPropertyHandler.UID)).ToList().ForEach(delegate(PropertyMetadata p)
			{
				PropertyInfo reflectionProperty2 = target.GetType().GetReflectionProperty(p.Name);
				if (reflectionProperty2 != null)
				{
					UntypedISetProxy untypedISetProxy2 = reflectionProperty2.GetValue(target, null).AsUntypedISet();
					foreach (IDocumentAttachment item in docCommentModel.DocumentAttachments.Where((IDocumentAttachment a) => a != null && a.Document != null))
					{
						if (addAttachmentToTarget)
						{
							untypedISetProxy2?.Add(item);
						}
						LastObjectInfoManager.Instance.AddInfo(new ReferenceOnEntity
						{
							ObjectTypeUId = InterfaceActivator.UID<IDocument>(),
							ObjectId = item.Document.Id
						});
					}
				}
			});
		}
		if (docCommentModel.CopiedDocumentAttachments == null || docCommentModel.CopiedDocumentAttachments.Count <= 0)
		{
			return;
		}
		classMetadata.Properties.Where((PropertyMetadata p) => p.Handlers.Any((PropertyHandlerInfo h) => h.HandlerUid == DocumentAttachmentsPropertyHandler.UID)).ToList().ForEach(delegate(PropertyMetadata p)
		{
			PropertyInfo reflectionProperty = target.GetType().GetReflectionProperty(p.Name);
			if (reflectionProperty != null)
			{
				UntypedISetProxy untypedISetProxy = reflectionProperty.GetValue(target, null).AsUntypedISet();
				if (untypedISetProxy != null)
				{
					foreach (IDocumentAttachment item2 in docCommentModel.CopiedDocumentAttachments.Where((IDocumentAttachment a) => a != null && a.Document != null))
					{
						InstanceOf<IDocumentAttachment> instanceOf = new InstanceOf<IDocumentAttachment>();
						instanceOf.New.Document = item2.Document;
						instanceOf.New.CreationAuthor = item2.CreationAuthor;
						instanceOf.New.CreationDate = item2.CreationDate;
						untypedISetProxy.Add(instanceOf.New);
					}
				}
			}
		});
	}

	public void ProcessToCommentModel([NotNull] object target, ICommentActionModel commentModel)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		ICommentWithDocumentsActionModel docCommentModel = commentModel as ICommentWithDocumentsActionModel;
		if (docCommentModel == null)
		{
			return;
		}
		ClassMetadata obj = (ClassMetadata)MetadataLoader.LoadMetadata(target.GetType());
		if (docCommentModel.DocumentAttachments == null)
		{
			docCommentModel.DocumentAttachments = new List<IDocumentAttachment>();
		}
		obj.Properties.Where((PropertyMetadata p) => p.Handlers.Any((PropertyHandlerInfo h) => h.HandlerUid == DocumentAttachmentsPropertyHandler.UID)).ToList().ForEach(delegate(PropertyMetadata p)
		{
			PropertyInfo reflectionProperty = target.GetType().GetReflectionProperty(p.Name);
			if (reflectionProperty != null)
			{
				UntypedISetProxy untypedISetProxy = reflectionProperty.GetValue(target, null).AsUntypedISet();
				if (untypedISetProxy != null)
				{
					foreach (IDocumentAttachment item in untypedISetProxy)
					{
						docCommentModel.DocumentAttachments.Add(item);
					}
				}
			}
		});
	}

	public void ProcessEventArgs([NotNull] EntityActionEventArgs e, ICommentActionModel commentModel)
	{
		if (e == null)
		{
			throw new ArgumentNullException("e");
		}
		if (commentModel is ICommentWithDocumentsActionModel commentWithDocumentsActionModel)
		{
			e.ExtendedProperties["DocumentAttachments"] = commentWithDocumentsActionModel.DocumentAttachments;
		}
	}

	public void ProcessNotificationToMessage(INotification notification, IMessage message)
	{
		if (notification is IExtendedPropertiesContainer extendedPropertiesContainer && message != null && extendedPropertiesContainer.ExtendedProperties.ContainsKey("DocumentAttachments") && extendedPropertiesContainer.ExtendedProperties["DocumentAttachments"] != null && extendedPropertiesContainer.ExtendedProperties["DocumentAttachments"] is IList<IDocumentAttachment> list && list.Count > 0)
		{
			Guid attachUid = InterfaceActivator.UID<IDocumentAttachment>();
			IEnumerable<MessageAttachment> second = list.Select((IDocumentAttachment a) => new MessageAttachment(a.Document.Name, attachUid, a.Uid.ToString()));
			IEnumerable<MessageAttachment> messageAttachments = message.MessageAttachments;
			message.MessageAttachments = (messageAttachments ?? Enumerable.Empty<MessageAttachment>()).Union(second).ToArray();
		}
	}
}
