using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.PropertyHandlers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Dynamic;
using EleWise.ELMA.Events;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Notifications;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.Components;

[Component]
public class CommentActionHandler : ICommentActionHandler, IEventHandler, ICommentActionProcessHandler, INotificationMessageHandler
{
	public const string AttachmentsKey = "Attachments";

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
		if (commentModel == null)
		{
			return;
		}
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(target.GetType());
		if (commentModel.Comment != null && !string.IsNullOrEmpty(commentModel.Comment.Text))
		{
			classMetadata.Properties.Where((PropertyMetadata p) => p.Handlers.Any((PropertyHandlerInfo h) => h.HandlerUid == CommentsPropertyHandler.UID)).ToList().ForEach(delegate(PropertyMetadata p)
			{
				PropertyInfo reflectionProperty3 = target.GetType().GetReflectionProperty(p.Name);
				if (reflectionProperty3 != null)
				{
					reflectionProperty3.GetValue(target, null).AsUntypedISet()?.Add(commentModel.Comment);
				}
			});
		}
		if (addAttachmentToTarget && commentModel.Attachments != null && commentModel.Attachments.Count > 0)
		{
			classMetadata.Properties.Where((PropertyMetadata p) => p.Handlers.Any((PropertyHandlerInfo h) => h.HandlerUid == AttachmentsPropertyHandler.UID)).ToList().ForEach(delegate(PropertyMetadata p)
			{
				PropertyInfo reflectionProperty2 = target.GetType().GetReflectionProperty(p.Name);
				if (reflectionProperty2 != null)
				{
					UntypedISetProxy untypedISetProxy2 = reflectionProperty2.GetValue(target, null).AsUntypedISet();
					if (untypedISetProxy2 != null)
					{
						foreach (IAttachment item in commentModel.Attachments.Where((IAttachment a) => a != null && a.File != null))
						{
							untypedISetProxy2.Add(item);
						}
					}
				}
			});
		}
		if (commentModel.CopiedAttachments == null || commentModel.CopiedAttachments.Count <= 0)
		{
			return;
		}
		classMetadata.Properties.Where((PropertyMetadata p) => p.Handlers.Any((PropertyHandlerInfo h) => h.HandlerUid == AttachmentsPropertyHandler.UID)).ToList().ForEach(delegate(PropertyMetadata p)
		{
			PropertyInfo reflectionProperty = target.GetType().GetReflectionProperty(p.Name);
			if (reflectionProperty != null)
			{
				UntypedISetProxy untypedISetProxy = reflectionProperty.GetValue(target, null).AsUntypedISet();
				if (untypedISetProxy != null)
				{
					foreach (IAttachment item2 in commentModel.CopiedAttachments.Where((IAttachment a) => a != null && a.File != null))
					{
						InstanceOf<IAttachment> instanceOf = new InstanceOf<IAttachment>();
						instanceOf.New.CreationAuthor = item2.CreationAuthor;
						instanceOf.New.CreationDate = item2.CreationDate;
						instanceOf.New.File = item2.File;
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
		if (commentModel == null)
		{
			return;
		}
		ClassMetadata obj = (ClassMetadata)MetadataLoader.LoadMetadata(target.GetType());
		if (commentModel.Attachments == null)
		{
			commentModel.Attachments = new List<IAttachment>();
		}
		obj.Properties.Where((PropertyMetadata p) => p.Handlers.Any((PropertyHandlerInfo h) => h.HandlerUid == AttachmentsPropertyHandler.UID)).ToList().ForEach(delegate(PropertyMetadata p)
		{
			PropertyInfo reflectionProperty = target.GetType().GetReflectionProperty(p.Name);
			if (reflectionProperty != null && reflectionProperty.GetValue(target, null) is IEnumerable enumerable)
			{
				foreach (IAttachment item in enumerable)
				{
					commentModel.Attachments.Add(item);
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
		if (commentModel != null)
		{
			e.ExtendedProperties["Comment"] = commentModel.Comment;
			e.ExtendedProperties["Attachments"] = commentModel.Attachments;
		}
	}

	public void ProcessNotificationToMessage(INotification notification, IMessage message)
	{
		if (notification is IExtendedPropertiesContainer extendedPropertiesContainer && message != null && extendedPropertiesContainer.ExtendedProperties.ContainsKey("Attachments") && extendedPropertiesContainer.ExtendedProperties["Attachments"] != null && extendedPropertiesContainer.ExtendedProperties["Attachments"] is IList<IAttachment> list && list.Count > 0)
		{
			Guid attachUid = InterfaceActivator.UID<IAttachment>();
			IEnumerable<MessageAttachment> second = from a in list
				where a != null && a.File != null
				select new MessageAttachment(a.File.Name, attachUid, a.Uid.ToString());
			IEnumerable<MessageAttachment> messageAttachments = message.MessageAttachments;
			message.MessageAttachments = (messageAttachments ?? Enumerable.Empty<MessageAttachment>()).Union(second).ToArray();
		}
	}
}
