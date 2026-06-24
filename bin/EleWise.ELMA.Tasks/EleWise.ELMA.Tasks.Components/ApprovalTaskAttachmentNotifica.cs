using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Notifications;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components;

[Component]
internal class ApprovalTaskAttachmentNotificationHandler : INotificationMessageHandler, IEventHandler
{
	public void ProcessNotificationToMessage(INotification notification, IMessage message)
	{
		if (notification == null || message == null || !message.ActionUid.HasValue || !message.ObjectUid.HasValue || message.ActionUid != DefaultEntityActions.CreateGuid)
		{
			return;
		}
		TasksSettingsModule service = Locator.GetService<TasksSettingsModule>();
		if (service != null && service.Settings != null && !service.Settings.AllowAttachments)
		{
			return;
		}
		Type typeByUidOrNull = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(message.ObjectUid.Value);
		if (typeByUidOrNull == null || !typeof(IApprovalTask).IsAssignableFrom(typeByUidOrNull) || !long.TryParse(message.ObjectId, out var mId))
		{
			return;
		}
		IEntity entity = null;
		Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
		{
			entity = ModelHelper.GetEntity(message.ObjectUid.Value, mId);
		});
		if (!(entity is IApprovalTask))
		{
			return;
		}
		ITaskBase parentTask = ((IApprovalTask)entity).ParentTask;
		if (parentTask == null)
		{
			return;
		}
		List<string> list = new List<string>();
		double num = 0.0;
		foreach (IAttachment item in (IEnumerable<IAttachment>)parentTask.Attachments)
		{
			if (item.File != null)
			{
				list.Add(item.File.Id);
				num += (double)DataAccessManager.FileManager.FileSize(item.File.Uid.ToString());
			}
		}
		num = num / 1024.0 / 1024.0;
		if (service.Settings.MaxAttachmentSize <= 0 || !(num > (double)service.Settings.MaxAttachmentSize))
		{
			IMessage message2 = message;
			IEnumerable<string> attachmentIds = message.AttachmentIds;
			message2.AttachmentIds = (attachmentIds ?? Enumerable.Empty<string>()).Union(list).ToArray();
		}
	}
}
