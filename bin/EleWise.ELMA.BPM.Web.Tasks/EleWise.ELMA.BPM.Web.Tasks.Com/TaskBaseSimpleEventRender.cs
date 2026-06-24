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
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Audit;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = 1000)]
public class TaskBaseSimpleEventRender : BaseAuditEventRender
{
	protected override IEnumerable<Guid> Actions
	{
		get
		{
			yield return TaskBaseActions.MarkReadGuid;
			yield return TaskBaseActions.AddCommentGuid;
			yield return TaskBaseActions.StartWorkGuid;
			yield return TaskBaseActions.CompleteGuid;
			yield return TaskBaseActions.IncompleteGuid;
			yield return TaskBaseActions.RedirectGuid;
			yield return TaskBaseActions.CreateSubTaskGuid;
			yield return TaskBaseActions.TerminateGuid;
			yield return TaskBaseActions.ChangeEndDateGuid;
			yield return DefaultEntityActions.CreateGuid;
			yield return TaskBaseActions.EditGuid;
			yield return TaskActions.ChangeControlGuid;
			yield return TaskActions.ControlCompleteGuid;
			yield return TaskActions.CloseGuid;
			yield return TaskActions.ReopenGuid;
			yield return TaskActions.ConfirmApprovalGuid;
			yield return TaskActions.RefuseApprovalGuid;
		}
	}

	protected override IEnumerable<Guid> Objects => from m in MetadataServiceContext.Service.GetMetadataList().OfType<ClassMetadata>()
		where MetadataLoader.GetBaseClasses(m).Any((ClassMetadata c) => c.Uid == InterfaceActivator.UID<ITaskBase>())
		select m.Uid;

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
		if (@event.Action == null)
		{
			throw new ArgumentException("event.Action");
		}
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		if (@event.Action.Uid == TaskBaseActions.MarkReadGuid)
		{
			return RenderMarkRead(html, @event, historyLoader);
		}
		if (@event.Action.Uid == TaskBaseActions.RedirectGuid)
		{
			return RenderRedirect(html, @event, historyLoader);
		}
		if (@event.Action.Uid == TaskBaseActions.AddCommentGuid)
		{
			return RenderCommentAction(html, @event, historyLoader, string.Empty, hideAttachAndComments: false);
		}
		if (@event.Action.Uid == TaskBaseActions.CompleteGuid)
		{
			if (@event is TaskActionEventArgs taskActionEventArgs && !string.IsNullOrEmpty(taskActionEventArgs.Caption))
			{
				return RenderComplete(html, @event, historyLoader, taskActionEventArgs.Caption);
			}
			return RenderComplete(html, @event, historyLoader);
		}
		if (@event.Action.Uid == TaskBaseActions.IncompleteGuid)
		{
			return RenderInComplete(html, @event, historyLoader);
		}
		if (@event.Action.Uid == TaskBaseActions.ChangeEndDateGuid)
		{
			return RenderChangeEndDate(html, @event, historyLoader);
		}
		if (@event.Action.Uid == TaskBaseActions.EditGuid)
		{
			return RenderUserEdit(html, @event, historyLoader);
		}
		if (@event.Action.Uid == TaskBaseActions.CreateSubTaskGuid)
		{
			return RenderCreateSubTask(html, @event, historyLoader);
		}
		if (@event.Action.Uid == TaskActions.ReopenGuid)
		{
			return RenderReopen(html, @event, historyLoader);
		}
		if (@event.Action.Uid == DefaultEntityActions.CreateGuid)
		{
			return RenderCreate(html, @event, historyLoader);
		}
		if (@event.Action.Uid == TaskActions.ControlCompleteGuid)
		{
			return RenderControlComplete(html, @event, historyLoader);
		}
		if (@event.Action.Uid == TaskActions.ChangeControlGuid)
		{
			return RenderChangeControl(html, @event, historyLoader);
		}
		if (@event.Action.Uid == TaskActions.CloseGuid)
		{
			return RenderCloseTask(html, @event, historyLoader);
		}
		if (@event.Action.Uid == TaskBaseActions.TerminateGuid)
		{
			return RenderCancelTask(html, @event, historyLoader);
		}
		if (@event.Action.Uid == TaskActions.ConfirmApprovalGuid)
		{
			return RenderConfirmApproval(html, @event, historyLoader);
		}
		if (@event.Action.Uid == TaskActions.RefuseApprovalGuid)
		{
			return RenderRefuseApproval(html, @event, historyLoader);
		}
		if (@event.Action.Uid == TaskBaseActions.StartWorkGuid)
		{
			return RenderStartWork(html, @event, historyLoader);
		}
		return null;
	}

	public static IHistoryBaseModel RenderCommentAction(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader, string eventTheme)
	{
		return RenderCommentAction(html, @event, historyLoader, eventTheme, hideAttachAndComments: false);
	}

	public static IHistoryBaseModel RenderCommentAction(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader, string eventTheme, bool hideAttachAndComments)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		ITaskBase task = @event.New as ITaskBase;
		CommentTaskHistoryModel commentEvent = new CommentTaskHistoryModel(@event, eventTheme);
		if (!hideAttachAndComments)
		{
			if (task != null && task.Comments != null)
			{
				List<IComment> comments = (from IComment q in from q in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
						select q.New
					where ((ICollection<IComment>)task.Comments).Contains(q) && q.CreationAuthor.Equals(commentEvent.ActionAuthor)
					select q).ToList();
				commentEvent.Comments = comments;
			}
			if (task != null && task.Attachments != null)
			{
				List<IAttachment> attachments = (from IAttachment a in from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IAttachment>(), DefaultEntityActions.CreateGuid)
						select e.New
					where ((ICollection<IAttachment>)task.Attachments).Contains(a)
					select a).ToList();
				commentEvent.Attachments = attachments;
			}
		}
		return commentEvent;
	}

	public static IHistoryBaseModel RenderAddComment(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader, string caption = null)
	{
		return RenderCommentAction(html, @event, historyLoader, caption);
	}

	public static IHistoryBaseModel RenderComplete(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader, string caption = null, bool hideAttachAndComments = false)
	{
		return RenderCommentAction(html, @event, historyLoader, caption ?? SR.T("Задача выполнена"), hideAttachAndComments);
	}

	public static IHistoryBaseModel RenderInComplete(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader, string caption = null)
	{
		return RenderCommentAction(html, @event, historyLoader, caption ?? SR.T("Задачу выполнить невозможно"));
	}

	public static IHistoryBaseModel RenderControlComplete(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader, string caption = null)
	{
		return RenderCommentAction(html, @event, historyLoader, caption ?? SR.T("Контроль выполнения завершен"));
	}

	public static IHistoryBaseModel RenderCancelTask(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader, string caption = null)
	{
		return RenderCommentAction(html, @event, historyLoader, caption ?? SR.T("Задача прервана"));
	}

	public static IHistoryBaseModel RenderCloseTask(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader, string caption = null)
	{
		return RenderCommentAction(html, @event, historyLoader, caption ?? SR.T("Задача закрыта"));
	}

	public static IHistoryBaseModel RenderTerminateTask(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader, string caption = null)
	{
		return RenderCommentAction(html, @event, historyLoader, caption ?? SR.T("Задача прервана"));
	}

	public static IHistoryBaseModel RenderCreate(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader, string caption = null)
	{
		return RenderCommentAction(html, @event, historyLoader, caption ?? SR.T("Задача создана"));
	}

	public static IHistoryBaseModel RenderCreateSubTask(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		CreateSubTaskHistoryModel createSubTaskHistoryModel = new CreateSubTaskHistoryModel(@event, SR.T("Создана подзадача"));
		if (!(@event is SubTaskCreateActionEventArgs subTaskCreateActionEventArgs))
		{
			ITaskBase parentTask = @event.New as ITaskBase;
			ITask task = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<ITask>(), DefaultEntityActions.CreateGuid)
				select e.New).Cast<ITask>().FirstOrDefault((ITask a) => a.ParentTask == parentTask);
			createSubTaskHistoryModel.TasksInfo = ((task == null) ? new List<CreateSubTaskHistoryInfoModel>() : new List<CreateSubTaskHistoryInfoModel>
			{
				new CreateSubTaskHistoryInfoModel
				{
					Id = task.Id,
					Subject = task.Subject
				}
			});
			return createSubTaskHistoryModel;
		}
		SubTaskCreateInfo info = subTaskCreateActionEventArgs.Info;
		if (info == null || info.SubTasksIds == null || !info.SubTasksIds.Any())
		{
			return null;
		}
		if (info.SubTasksIds.Count() > 1)
		{
			createSubTaskHistoryModel.ActionTheme = SR.T("Созданы подзадачи");
		}
		createSubTaskHistoryModel.TasksInfo = TaskBaseManager.Instance.GetSubTaskInfoForCreateAction(info);
		return createSubTaskHistoryModel;
	}

	public static IHistoryBaseModel RenderMarkRead(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader, string caption = null)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		return new MarkReadTaskHistoryModel(@event, caption ?? SR.T("Задача прочитана исполнителем"));
	}

	public static IHistoryBaseModel RenderChangeControl(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		ChangeControlTaskHistoryModel changeControlTaskHistoryModel = new ChangeControlTaskHistoryModel(@event, SR.T("Изменен контроль задачи"));
		ITask task = (ITask)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, task.Id).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			changeControlTaskHistoryModel.OldEntity = (ITask)entityActionEventArgs.Old;
			changeControlTaskHistoryModel.NewEntity = (ITask)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				changeControlTaskHistoryModel.ChangedProperties = editEntityActionEventArgs.ChangedProperties.ToList();
			}
		}
		if (task.Comments != null)
		{
			IComment comment2 = (changeControlTaskHistoryModel.Comment = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
				select e.New).Cast<IComment>().FirstOrDefault((IComment c) => ((ICollection<IComment>)task.Comments).Contains(c)));
		}
		return changeControlTaskHistoryModel;
	}

	public static IHistoryBaseModel RenderChangeEndDate(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		ChangeDateTaskHistoryModel historyModel = new ChangeDateTaskHistoryModel(@event, SR.T("Срок выполнения задачи изменён"));
		ITaskBase task = (ITaskBase)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, task.Id).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			historyModel.OldEntity = (ITaskBase)entityActionEventArgs.Old;
			historyModel.NewEntity = (ITaskBase)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				historyModel.ChangedProperties = (from p in editEntityActionEventArgs.ChangedProperties.ToList()
					where !historyModel.BaseProperties.Contains(p.Uid)
					select p).ToList();
			}
		}
		if (task.Comments != null)
		{
			IComment comment = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
				select e.New).Cast<IComment>().FirstOrDefault((IComment c) => ((ICollection<IComment>)task.Comments).Contains(c));
			historyModel.Comment = comment;
		}
		return historyModel;
	}

	public IHistoryBaseModel RenderUserEdit(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		UserEditTaskHistoryModel userEditEvent = new UserEditTaskHistoryModel(@event, SR.T("Задача изменена"));
		ITaskBase task = (ITaskBase)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, task.Id).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			userEditEvent.OldEntity = (ITaskBase)entityActionEventArgs.Old;
			userEditEvent.NewEntity = (ITaskBase)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				userEditEvent.ChangedProperties = (from p in editEntityActionEventArgs.ChangedProperties.ToList()
					where !userEditEvent.BaseProperties.Contains(p.Uid)
					select p).ToList();
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

	public static IHistoryBaseModel RenderStartWork(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader, string caption = null)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		UserEditTaskHistoryModel startWorkEvent = new UserEditTaskHistoryModel(@event, caption ?? SR.T("Работа над задачей начата"));
		ITaskBase task = (ITaskBase)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, task.Id).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			startWorkEvent.OldEntity = (ITaskBase)entityActionEventArgs.Old;
			startWorkEvent.NewEntity = (ITaskBase)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				startWorkEvent.ChangedProperties = (from p in editEntityActionEventArgs.ChangedProperties.ToList()
					where !startWorkEvent.BaseProperties.Contains(p.Uid)
					select p).ToList();
			}
		}
		if (task.Comments != null)
		{
			IComment comment = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
				select e.New).Cast<IComment>().FirstOrDefault((IComment c) => ((ICollection<IComment>)task.Comments).Contains(c));
			startWorkEvent.Comment = comment;
		}
		if (task.Attachments != null)
		{
			List<IAttachment> attachments = (from IAttachment a in from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IAttachment>(), DefaultEntityActions.CreateGuid)
					select e.New
				where ((ICollection<IAttachment>)task.Attachments).Contains(a)
				select a).ToList();
			startWorkEvent.Attachments = attachments;
		}
		return startWorkEvent;
	}

	public IHistoryBaseModel RenderReopen(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		UserEditTaskHistoryModel userEditTaskHistoryModel = new UserEditTaskHistoryModel(@event, SR.T("Задача открыта заново"));
		ITaskBase task = (ITaskBase)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, task.Id).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			userEditTaskHistoryModel.OldEntity = (ITaskBase)entityActionEventArgs.Old;
			userEditTaskHistoryModel.NewEntity = (ITaskBase)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				userEditTaskHistoryModel.ChangedProperties = editEntityActionEventArgs.ChangedProperties.ToList();
			}
		}
		if (task.Comments != null)
		{
			IComment comment2 = (userEditTaskHistoryModel.Comment = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
				select e.New).Cast<IComment>().FirstOrDefault((IComment c) => ((ICollection<IComment>)task.Comments).Contains(c)));
		}
		if (task.Attachments != null)
		{
			List<IAttachment> list = (List<IAttachment>)(userEditTaskHistoryModel.Attachments = (from IAttachment a in from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IAttachment>(), DefaultEntityActions.CreateGuid)
					select e.New
				where ((ICollection<IAttachment>)task.Attachments).Contains(a)
				select a).ToList());
		}
		return userEditTaskHistoryModel;
	}

	public static IHistoryBaseModel RenderRedirect(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader, string caption = null)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		RedirectTaskHistoryModel redirectTaskHistoryModel = new RedirectTaskHistoryModel(@event, caption ?? SR.T("Задача переназначена"));
		ITaskBase task = (ITaskBase)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, task.TypeUid, DefaultEntityActions.UpdateGuid, task.Id).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			redirectTaskHistoryModel.OldEntity = (ITaskBase)entityActionEventArgs.Old;
			redirectTaskHistoryModel.NewEntity = (ITaskBase)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				redirectTaskHistoryModel.ChangedProperties = editEntityActionEventArgs.ChangedProperties.ToList();
			}
		}
		if (task.Comments != null)
		{
			IComment comment2 = (redirectTaskHistoryModel.Comment = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
				select e.New).Cast<IComment>().FirstOrDefault((IComment c) => ((ICollection<IComment>)task.Comments).Contains(c)));
		}
		return redirectTaskHistoryModel;
	}

	public static IHistoryBaseModel RenderConfirmApproval(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		return RenderCommentAction(html, @event, historyLoader, SR.T("Задача согласована"));
	}

	public static IHistoryBaseModel RenderRefuseApproval(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		return RenderCommentAction(html, @event, historyLoader, SR.T("В согласовании отказано"));
	}

	protected override HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
	{
		if (@event == null || @event.Action == null)
		{
			return null;
		}
		if (@event.Action.Uid == TaskBaseActions.RedirectGuid)
		{
			return RedirectViewBlock();
		}
		if (@event.Action.Uid == TaskBaseActions.ChangeEndDateGuid)
		{
			return ChangeEndDateViewBlock();
		}
		if (@event.Action.Uid == TaskActions.ChangeControlGuid)
		{
			return ChangeControlViewBlock();
		}
		if (@event.Action.Uid == TaskBaseActions.EditGuid || @event.Action.Uid == TaskActions.ReopenGuid)
		{
			return EditViewBlock();
		}
		if (@event.Action.Uid == TaskBaseActions.CreateSubTaskGuid)
		{
			return CreateSubTaskViewBlock();
		}
		if (@event.Action.Uid == TaskBaseActions.StartWorkGuid)
		{
			return RenderStartWork();
		}
		return null;
	}

	public static HistoryPartViewBlock RedirectViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/Task.Redirect", (object)model)
		};
	}

	private static HistoryPartViewBlock ChangeEndDateViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/Task.ChangeEndDate", (object)model)
		};
	}

	private static HistoryPartViewBlock ChangeControlViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/Task.ChangeControl", (object)model)
		};
	}

	private static HistoryPartViewBlock EditViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/Task.Edit", (object)model)
		};
	}

	private static HistoryPartViewBlock CreateSubTaskViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/Task.CreateSubTask", (object)model)
		};
	}

	public static HistoryPartViewBlock RenderStartWork()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/Task.StartWork", (object)model)
		};
	}
}
