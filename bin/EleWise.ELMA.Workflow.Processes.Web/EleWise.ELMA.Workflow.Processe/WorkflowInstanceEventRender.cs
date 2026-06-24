using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Models.History;
using EleWise.ELMA.Workflow.Audit;
using EleWise.ELMA.Workflow.Audit.HistoryModels;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.History;

[Component(Order = 0)]
public class WorkflowInstanceEventRender : BaseAuditEventRender
{
	protected override IEnumerable<Guid> Actions
	{
		get
		{
			yield return DefaultEntityActions.CreateGuid;
			yield return WorkflowInstanceActions.AddCommentGuid;
			yield return WorkflowInstanceActions.TimerStartedGuid;
			yield return WorkflowInstanceActions.TimerExecutedGuid;
			yield return WorkflowInstanceActions.MessageReceiveStartedGuid;
			yield return WorkflowInstanceActions.MessageReceiveCompletedGuid;
			yield return WorkflowInstanceActions.MessageReceiveTerminatedGuid;
			yield return WorkflowInstanceActions.ChangeResponsibleGuid;
			yield return WorkflowInstanceActions.TerminateGuid;
			yield return WorkflowInstanceActions.ChangeProcessVersionGuid;
			foreach (Guid item in from r in ComponentManager.Current.GetExtensionPoints<IRenderInWorkflowInstanceHistory>()
				select r.ActionUid)
			{
				yield return item;
			}
		}
	}

	protected override IEnumerable<Guid> Objects
	{
		get
		{
			yield return InterfaceActivator.UID<IWorkflowInstance>();
		}
	}

	protected override IHistoryBaseModel CreateEventData(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		if (@event == null)
		{
			throw new ArgumentNullException("event");
		}
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		if (@event.Action.Uid == DefaultEntityActions.CreateGuid && !@event.ExtendedProperties.ContainsKey("EventType"))
		{
			return RenderWorkflowInstanceCreate(html, @event, historyLoader);
		}
		if (@event.Action.Uid == WorkflowInstanceActions.AddCommentGuid)
		{
			return RenderWorkflowInstanceAddComment(html, @event, historyLoader);
		}
		if (@event.Action.Uid == WorkflowInstanceActions.TimerStartedGuid)
		{
			return RenderWorkflowInstanceTimerStarted(html, @event, historyLoader);
		}
		if (@event.Action.Uid == WorkflowInstanceActions.TimerExecutedGuid)
		{
			return RenderWorkflowInstanceTimerrExecuted(html, @event, historyLoader);
		}
		if (@event.Action.Uid == WorkflowInstanceActions.MessageReceiveStartedGuid || @event.Action.Uid == WorkflowInstanceActions.MessageReceiveCompletedGuid || @event.Action.Uid == WorkflowInstanceActions.MessageReceiveTerminatedGuid)
		{
			return RenderWorkflowInstanceMessageReceive(html, @event, historyLoader);
		}
		if (@event.Action.Uid == WorkflowInstanceActions.ChangeResponsibleGuid)
		{
			return RenderWorkflowInstanceChangeResponsible(html, @event, historyLoader);
		}
		if (@event.Action.Uid == WorkflowInstanceActions.TerminateGuid)
		{
			return RenderTerminateComment(html, @event, historyLoader);
		}
		if (@event.Action.Uid == WorkflowInstanceActions.ChangeProcessVersionGuid)
		{
			return RenderChangeProcessVersion(html, @event, historyLoader);
		}
		return ComponentManager.Current.GetExtensionPoints<IRenderInWorkflowInstanceHistory>().FirstOrDefault((IRenderInWorkflowInstanceHistory r) => r.ActionUid == @event.Action.Uid)?.RenderAction(html, @event, historyLoader);
	}

	private IHistoryBaseModel RenderWorkflowInstanceCreate(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		return new CreateWorkflowInstanceHistoryModel(@event, SR.T("Процесс запущен"));
	}

	private IHistoryBaseModel RenderWorkflowInstanceAddComment(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		string actionTheme = (@event.ExtendedProperties.ContainsKey("Theme") ? ((string)@event.ExtendedProperties["Theme"]) : string.Empty);
		AddCommentWorkflowInstanceHistoryModel commentEvent = new AddCommentWorkflowInstanceHistoryModel(@event, actionTheme);
		IWorkflowInstance instance = (IWorkflowInstance)@event.New;
		if (instance.Comments != null)
		{
			List<IComment> comments = (from IComment q in from q in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
					select q.New
				where ((ICollection<IComment>)instance.Comments).Contains(q) && q.CreationAuthor.Equals(commentEvent.ActionAuthor)
				select q).ToList();
			commentEvent.Comments = comments;
		}
		List<IAttachment> attachments = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IAttachment>(), DefaultEntityActions.CreateGuid)
			select e.New).Cast<IAttachment>().ToList();
		commentEvent.Attachments = attachments;
		return commentEvent;
	}

	private IHistoryBaseModel RenderWorkflowInstanceTimerStarted(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		WorkflowInstanceTimerActionEventArgs workflowInstanceTimerActionEventArgs = @event as WorkflowInstanceTimerActionEventArgs;
		string actionTheme = SR.T("Запущен таймер \"{0}\". Время выполнения таймера: \"{1}\"", workflowInstanceTimerActionEventArgs.TimerName, workflowInstanceTimerActionEventArgs.OnceExecuteTime);
		return new CreateWorkflowInstanceHistoryModel(@event, actionTheme);
	}

	private IHistoryBaseModel RenderWorkflowInstanceTimerrExecuted(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		WorkflowInstanceTimerActionEventArgs workflowInstanceTimerActionEventArgs = @event as WorkflowInstanceTimerActionEventArgs;
		string actionTheme = SR.T("Таймер \"{0}\" выполнен", workflowInstanceTimerActionEventArgs.TimerName);
		return new CreateWorkflowInstanceHistoryModel(@event, actionTheme);
	}

	private IHistoryBaseModel RenderWorkflowInstanceMessageReceive(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		if (!(@event is WorkflowMessageReceiveActionEventArgs workflowMessageReceiveActionEventArgs))
		{
			return null;
		}
		string text = ((@event.Action.Uid == WorkflowInstanceActions.MessageReceiveStartedGuid) ? SR.T("Начало ожидания сообщения") : ((@event.Action.Uid == WorkflowInstanceActions.MessageReceiveCompletedGuid) ? SR.T("Получено сообщение") : SR.T("Прервано ожидание сообщения")));
		text = text + " \"" + workflowMessageReceiveActionEventArgs.ElementName + "\".";
		IWorkflowMessageType workflowMessageType = ((workflowMessageReceiveActionEventArgs.MessageTypeId > 0) ? EntityManager<IWorkflowMessageType>.Instance.LoadOrNull(workflowMessageReceiveActionEventArgs.MessageTypeId) : null);
		if (workflowMessageType != null)
		{
			text = text + " " + SR.T("Тип сообщения: {0}.", workflowMessageType.Name);
		}
		if (!string.IsNullOrEmpty(workflowMessageReceiveActionEventArgs.ControlParameterValue))
		{
			text = text + " " + SR.T("Контрольный параметр: {0}.", workflowMessageReceiveActionEventArgs.ControlParameterValue);
		}
		return new CreateWorkflowInstanceHistoryModel(@event, text);
	}

	private IHistoryBaseModel RenderWorkflowInstanceChangeResponsible(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		ChangeResponsibleHistoryModel changeResponsibleHistoryModel = new ChangeResponsibleHistoryModel(@event, SR.T("Изменен ответственный"));
		IWorkflowInstance workflowInstance = (IWorkflowInstance)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, workflowInstance.Id).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			changeResponsibleHistoryModel.OldEntity = (IWorkflowInstance)entityActionEventArgs.Old;
			changeResponsibleHistoryModel.NewEntity = (IWorkflowInstance)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				changeResponsibleHistoryModel.ChangedProperties = editEntityActionEventArgs.ChangedProperties.Where((PropertyMetadata p) => p.Name == "Responsible").ToList();
			}
		}
		return changeResponsibleHistoryModel;
	}

	private IHistoryBaseModel RenderTerminateComment(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		string actionTheme = (@event.ExtendedProperties.ContainsKey("Theme") ? ((string)@event.ExtendedProperties["Theme"]) : SR.T("Процесс прерван"));
		TerminateWorkflowInstanceHistoryModel terminateWorkflowInstanceHistoryModel = new TerminateWorkflowInstanceHistoryModel(@event, actionTheme);
		IWorkflowInstance instance = (IWorkflowInstance)@event.New;
		if (instance.Comments != null)
		{
			IComment comment2 = (terminateWorkflowInstanceHistoryModel.Comment = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
				select e.New).Cast<IComment>().FirstOrDefault((IComment c) => ((ICollection<IComment>)instance.Comments).Contains(c)));
		}
		return terminateWorkflowInstanceHistoryModel;
	}

	private IHistoryBaseModel RenderChangeProcessVersion(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		IWorkflowInstance instance = (IWorkflowInstance)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, instance.Id).FirstOrDefault();
		ChangeProcessVersionHistoryModel changeProcessVersionHistoryModel = new ChangeProcessVersionHistoryModel(@event, string.Empty);
		if (entityActionEventArgs != null)
		{
			changeProcessVersionHistoryModel.OldEntity = (IWorkflowInstance)entityActionEventArgs.Old;
			changeProcessVersionHistoryModel.NewEntity = (IWorkflowInstance)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				changeProcessVersionHistoryModel.ChangedProperties = editEntityActionEventArgs.ChangedProperties.Where((PropertyMetadata p) => p.Name == "VersionNumber").ToList();
			}
			changeProcessVersionHistoryModel.ActionTheme = SR.T("Осуществлён переход на {0} версию процесса с {1}", changeProcessVersionHistoryModel.NewEntity.Process.VersionNumber, changeProcessVersionHistoryModel.OldEntity.Process.VersionNumber);
		}
		else
		{
			changeProcessVersionHistoryModel.ActionTheme = SR.T("Осуществлён переход на новую версию процесса");
		}
		if (instance.Comments != null)
		{
			IComment comment2 = (changeProcessVersionHistoryModel.Comment = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
				select e.New).Cast<IComment>().FirstOrDefault((IComment c) => ((ICollection<IComment>)instance.Comments).Contains(c)));
		}
		return changeProcessVersionHistoryModel;
	}

	protected override HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
	{
		if (@event == null || @event.Action == null)
		{
			return null;
		}
		if (@event.Action.Uid == WorkflowInstanceActions.ChangeResponsibleGuid)
		{
			return ChangeResponsibleViewBlock();
		}
		return ComponentManager.Current.GetExtensionPoints<IRenderInWorkflowInstanceHistory>().FirstOrDefault((IRenderInWorkflowInstanceHistory r) => r.ActionUid == @event.Action.Uid)?.GetExtraViewBlock(@event);
	}

	private HistoryPartViewBlock ChangeResponsibleViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/WorkflowInstance.ChangeResponsible", (object)model)
		};
	}
}
