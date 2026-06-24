using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = 900)]
internal sealed class AccessRequestTaskEventRender : TaskBaseSimpleEventRender
{
	private readonly IEnumerable<Guid> objects = new Guid[1] { InterfaceActivator.UID<IAccessRequestTask>() };

	private readonly IMetadataRuntimeService metadataRuntimeService;

	private readonly EntityMetadata accessRequestTaskMetadata = InterfaceActivator.LoadMetadata<IAccessRequestTask>() as EntityMetadata;

	private readonly PropertyMetadata permissionGuidsPropertyMetadata = InterfaceActivator.LoadPropertyMetadata((IAccessRequestTask p) => p.AccessRequestPermissionGuids);

	private ISerializableTypeDescriptor listTypeDescriptor;

	protected override IEnumerable<Guid> Objects => objects;

	protected override IEnumerable<Guid> Actions
	{
		get
		{
			yield return AccessRequestTaskActions.CloseGuid;
			yield return AccessRequestTaskActions.ApproveAccessRequestGuid;
			yield return AccessRequestTaskActions.RefuseAccessRequestGuid;
			yield return TaskBaseActions.EditGuid;
		}
	}

	private ISerializableTypeDescriptor ListTypeDescriptor => listTypeDescriptor ?? (listTypeDescriptor = metadataRuntimeService.GetTypeDescriptor(permissionGuidsPropertyMetadata.TypeUid, permissionGuidsPropertyMetadata.SubTypeUid) as ISerializableTypeDescriptor);

	public AccessRequestTaskEventRender(IMetadataRuntimeService metadataRuntimeService)
	{
		this.metadataRuntimeService = metadataRuntimeService;
	}

	protected override IHistoryBaseModel CreateEventData(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (@event.Action.Uid == AccessRequestTaskActions.ApproveAccessRequestGuid)
		{
			return RenderApproveAccessRequest(html, @event, historyLoader);
		}
		if (@event.Action.Uid == AccessRequestTaskActions.RefuseAccessRequestGuid)
		{
			return RenderRefuseAccessRequest(html, @event, historyLoader);
		}
		if (@event.Action.Uid == AccessRequestTaskActions.CloseGuid)
		{
			return TaskBaseSimpleEventRender.RenderCloseTask(html, @event, historyLoader);
		}
		if (@event.Action.Uid == TaskBaseActions.EditGuid)
		{
			return RenderEdit(html, @event, historyLoader);
		}
		return null;
	}

	protected override HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
	{
		if (@event == null || @event.Action == null)
		{
			return null;
		}
		if (@event.Action.Uid == TaskBaseActions.EditGuid)
		{
			return EditViewBlock();
		}
		return base.GetExtraViewBlock(@event);
	}

	private IHistoryBaseModel RenderApproveAccessRequest(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		return TaskBaseSimpleEventRender.RenderCommentAction(html, @event, historyLoader, SR.T("Доступ предоставлен"));
	}

	private IHistoryBaseModel RenderRefuseAccessRequest(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		return TaskBaseSimpleEventRender.RenderCommentAction(html, @event, historyLoader, SR.T("В предоставлении доступа отказано"));
	}

	private IHistoryBaseModel RenderEdit(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		UserEditAccessRequestTaskHistoryModel userEditEvent = new UserEditAccessRequestTaskHistoryModel(@event, SR.T("Задача изменена"));
		IAccessRequestTask task = @event.New as IAccessRequestTask;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, task.Id).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			userEditEvent.OldEntity = entityActionEventArgs.Old as IAccessRequestTask;
			userEditEvent.NewEntity = entityActionEventArgs.New as IAccessRequestTask;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				userEditEvent.ChangedProperties = (from p in editEntityActionEventArgs.ChangedProperties.ToList()
					where !userEditEvent.BaseProperties.Contains(p.Uid)
					select p).ToList();
				SetPermissions(userEditEvent, editEntityActionEventArgs);
			}
		}
		if (task.Comments != null)
		{
			IComment comment = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
				select e.New).Cast<IComment>().FirstOrDefault((IComment c) => ((ICollection<IComment>)task.Comments).Contains(c));
			userEditEvent.Comment = comment;
		}
		if (task.Attachments != null)
		{
			List<IAttachment> attachments = (from IAttachment a in from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IAttachment>(), DefaultEntityActions.CreateGuid)
					select e.New
				where ((ICollection<IAttachment>)task.Attachments).Contains(a)
				select a).ToList();
			userEditEvent.Attachments = attachments;
		}
		return userEditEvent;
	}

	private void SetPermissions(UserEditAccessRequestTaskHistoryModel model, EditEntityActionEventArgs editEntityActionEventArgs)
	{
		Contract.ArgumentNotNull(model, "model");
		Contract.ArgumentNotNull(editEntityActionEventArgs, "editEntityActionEventArgs");
		if (model.ChangedProperties.Any((PropertyMetadata p) => p.Uid == permissionGuidsPropertyMetadata.Uid))
		{
			PropertyCompareData propertyCompareData = (ClassSerializationHelper.DeserializeObject(editEntityActionEventArgs.GetAdditionalData()) as Collection<PropertyCompareData>)?.FirstOrDefault((PropertyCompareData c) => c != null && c.PropertyGuid == permissionGuidsPropertyMetadata.Uid);
			if (propertyCompareData != null)
			{
				IEnumerable<Guid> enumerable = DeserializePermissions(model.OldEntity as IAccessRequestTask, propertyCompareData.OldPropertyData);
				IEnumerable<Guid> enumerable2 = DeserializePermissions(model.NewEntity as IAccessRequestTask, propertyCompareData.NewPropertyData);
				model.AddedPermissions = enumerable2.Except(enumerable);
				model.RemovedPermissions = enumerable.Except(enumerable2);
			}
		}
	}

	private IEnumerable<Guid> DeserializePermissions(IAccessRequestTask task, byte[] data)
	{
		Contract.ArgumentNotNull(task, "task");
		Contract.ArgumentNotNull(data, "data");
		IDictionary<string, object> values = ClassSerializationHelper.DeserializeObject(data) as IDictionary<string, object>;
		ListTypeDescriptor.Deserialize(task, accessRequestTaskMetadata, permissionGuidsPropertyMetadata, values);
		return task.AccessRequestPermissionGuids.ToList();
	}

	private HistoryPartViewBlock EditViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/AccessRequestTask.Edit", (object)model)
		};
	}
}
