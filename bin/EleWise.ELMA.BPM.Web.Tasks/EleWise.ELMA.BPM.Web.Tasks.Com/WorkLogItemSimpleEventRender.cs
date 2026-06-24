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
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = 100)]
public class WorkLogItemSimpleEventRender : BaseAuditEventRender
{
	protected override IEnumerable<Guid> Actions
	{
		get
		{
			yield return WorkLogItemActions.AddCommentGuid;
			yield return DefaultEntityActions.CreateGuid;
			yield return WorkLogItemActions.RedirectGuid;
			yield return WorkLogItemActions.EditGuid;
			yield return WorkLogItemActions.ConfirmApprovalGuid;
			yield return WorkLogItemActions.RefuseApprovalGuid;
			yield return WorkLogItemActions.SendToApproveGuid;
			yield return WorkLogItemActions.ChangeStatusGuid;
		}
	}

	protected override IEnumerable<Guid> Objects => new List<Guid> { InterfaceActivator.UID<IWorkLogItem>() };

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
		if (@event.Action.Uid == DefaultEntityActions.CreateGuid)
		{
			return RenderCreate(html, @event, historyLoader);
		}
		if (@event.Action.Uid == WorkLogItemActions.AddCommentGuid)
		{
			return RenderAddComment(html, @event, historyLoader);
		}
		if (@event.Action.Uid == WorkLogItemActions.RedirectGuid)
		{
			return RenderRedirect(html, @event, historyLoader);
		}
		if (@event.Action.Uid == WorkLogItemActions.EditGuid)
		{
			return RenderUserEdit(html, @event, historyLoader);
		}
		if (@event.Action.Uid == WorkLogItemActions.SendToApproveGuid)
		{
			return RenderSendToApprove(html, @event, historyLoader);
		}
		if (@event.Action.Uid == WorkLogItemActions.ConfirmApprovalGuid)
		{
			return RenderConfirmApproval(html, @event, historyLoader);
		}
		if (@event.Action.Uid == WorkLogItemActions.RefuseApprovalGuid)
		{
			return RenderUnConfirmApproval(html, @event, historyLoader);
		}
		if (@event.Action.Uid == WorkLogItemActions.ChangeStatusGuid)
		{
			return RenderStatusChange(html, @event, historyLoader);
		}
		return null;
	}

	public static IHistoryBaseModel RenderCommentAction(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader, string eventTheme)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		IWorkLogItem workLogItem = @event.New as IWorkLogItem;
		CommentWorkLogItemHistoryModel commentEvent = new CommentWorkLogItemHistoryModel(@event, eventTheme);
		if (workLogItem != null && workLogItem.Comments != null)
		{
			List<IComment> comments = (from IComment q in from q in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
					select q.New
				where ((ICollection<IComment>)workLogItem.Comments).Contains(q) && q.CreationAuthor.Equals(commentEvent.ActionAuthor)
				select q).ToList();
			commentEvent.Comments = comments;
		}
		return commentEvent;
	}

	public static IHistoryBaseModel RenderAddComment(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader, string caption = null)
	{
		return RenderCommentAction(html, @event, historyLoader, caption);
	}

	public static IHistoryBaseModel RenderStatusChange(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader, string caption = null)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		IWorkLogItem workLogItem = (IWorkLogItem)@event.New;
		StatusChangeWorkLogItemHistoryModel statusChangeWorkLogItemHistoryModel = new StatusChangeWorkLogItemHistoryModel(@event, caption ?? SR.T("Изменён статус трудозатрат"));
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, workLogItem.Id).FirstOrDefault((EntityActionEventArgs e) => e is EditEntityActionEventArgs);
		if (entityActionEventArgs != null)
		{
			statusChangeWorkLogItemHistoryModel.OldEntity = (IWorkLogItem)entityActionEventArgs.Old;
			statusChangeWorkLogItemHistoryModel.NewEntity = (IWorkLogItem)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				statusChangeWorkLogItemHistoryModel.ChangedProperties = editEntityActionEventArgs.ChangedProperties.ToList();
			}
		}
		if (workLogItem.Comments != null)
		{
			IComment comment2 = (statusChangeWorkLogItemHistoryModel.Comment = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
				select e.New).Cast<IComment>().FirstOrDefault((IComment c) => ((ICollection<IComment>)workLogItem.Comments).Contains(c)));
		}
		return statusChangeWorkLogItemHistoryModel;
	}

	public static IHistoryBaseModel RenderCreate(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader, string caption = null)
	{
		return RenderCommentAction(html, @event, historyLoader, caption ?? SR.T("Трудозатраты созданы"));
	}

	public static IHistoryBaseModel RenderRedirect(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader, string caption = null)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		RedirectWorkLogItemHistoryModel redirectWorkLogItemHistoryModel = new RedirectWorkLogItemHistoryModel(@event, caption ?? SR.T("Назначен новый согласующий"));
		IWorkLogItem workLogItem = (IWorkLogItem)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, workLogItem.Id).FirstOrDefault((EntityActionEventArgs e) => e is EditEntityActionEventArgs);
		if (entityActionEventArgs != null)
		{
			redirectWorkLogItemHistoryModel.OldEntity = (IWorkLogItem)entityActionEventArgs.Old;
			redirectWorkLogItemHistoryModel.NewEntity = (IWorkLogItem)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				redirectWorkLogItemHistoryModel.ChangedProperties = editEntityActionEventArgs.ChangedProperties.ToList();
			}
		}
		if (workLogItem.Comments != null)
		{
			IComment comment2 = (redirectWorkLogItemHistoryModel.Comment = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
				select e.New).Cast<IComment>().FirstOrDefault((IComment c) => ((ICollection<IComment>)workLogItem.Comments).Contains(c)));
		}
		return redirectWorkLogItemHistoryModel;
	}

	public static IHistoryBaseModel RenderUserEdit(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader, string caption = null)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		UserEditWorkLogItemHistoryModel userEditWorkLogItemHistoryModel = new UserEditWorkLogItemHistoryModel(@event, caption ?? SR.T("Трудозатраты изменены"));
		IWorkLogItem workLogItem = (IWorkLogItem)@event.New;
		EntityActionEventArgs entityActionEventArgs = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, workLogItem.Id)
			where e is EditEntityActionEventArgs
			select e).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			userEditWorkLogItemHistoryModel.OldEntity = (IWorkLogItem)entityActionEventArgs.Old;
			userEditWorkLogItemHistoryModel.NewEntity = (IWorkLogItem)entityActionEventArgs.New;
			if (userEditWorkLogItemHistoryModel.NewEntity.Status == WorkLogItemStatus.Draft)
			{
				return null;
			}
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				userEditWorkLogItemHistoryModel.ChangedProperties = editEntityActionEventArgs.ChangedProperties.ToList();
			}
		}
		return userEditWorkLogItemHistoryModel;
	}

	public static IHistoryBaseModel RenderSendToApprove(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader, string caption = null)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		SendToApproveWorkLogItemHistoryModel sendToApproveWorkLogItemHistoryModel = new SendToApproveWorkLogItemHistoryModel(@event, caption ?? SR.T("Трудозатраты отправлены на согласование"));
		IWorkLogItem workLogItem = (IWorkLogItem)@event.New;
		EntityActionEventArgs entityActionEventArgs = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, workLogItem.Id)
			where e is EditEntityActionEventArgs
			select e).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			sendToApproveWorkLogItemHistoryModel.OldEntity = (IWorkLogItem)entityActionEventArgs.Old;
			sendToApproveWorkLogItemHistoryModel.NewEntity = (IWorkLogItem)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				sendToApproveWorkLogItemHistoryModel.ChangedProperties = editEntityActionEventArgs.ChangedProperties.ToList();
			}
		}
		return sendToApproveWorkLogItemHistoryModel;
	}

	public static IHistoryBaseModel RenderConfirmApproval(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader, string caption = null)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		ApprovalWorkLogItemHistoryModel approvalWorkLogItemHistoryModel = new ApprovalWorkLogItemHistoryModel(@event, caption ?? SR.T("Трудозатраты согласованы"));
		IWorkLogItem workLogItem = (IWorkLogItem)@event.New;
		EntityActionEventArgs entityActionEventArgs = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, workLogItem.Id)
			where e is EditEntityActionEventArgs
			select e).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			approvalWorkLogItemHistoryModel.OldEntity = (IWorkLogItem)entityActionEventArgs.Old;
			approvalWorkLogItemHistoryModel.NewEntity = (IWorkLogItem)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				approvalWorkLogItemHistoryModel.ChangedProperties = editEntityActionEventArgs.ChangedProperties.ToList();
			}
		}
		return approvalWorkLogItemHistoryModel;
	}

	public static IHistoryBaseModel RenderUnConfirmApproval(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader, string caption = null)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		ApprovalWorkLogItemHistoryModel approvalWorkLogItemHistoryModel = new ApprovalWorkLogItemHistoryModel(@event, caption ?? SR.T("Трудозатраты отклонены"));
		IWorkLogItem workLogItem = (IWorkLogItem)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, workLogItem.Id).FirstOrDefault((EntityActionEventArgs e) => e is EditEntityActionEventArgs);
		if (entityActionEventArgs != null)
		{
			approvalWorkLogItemHistoryModel.OldEntity = (IWorkLogItem)entityActionEventArgs.Old;
			approvalWorkLogItemHistoryModel.NewEntity = (IWorkLogItem)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				approvalWorkLogItemHistoryModel.ChangedProperties = editEntityActionEventArgs.ChangedProperties.ToList();
			}
		}
		if (workLogItem.Comments != null)
		{
			IComment comment2 = (approvalWorkLogItemHistoryModel.Comment = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
				select e.New).Cast<IComment>().FirstOrDefault((IComment c) => ((ICollection<IComment>)workLogItem.Comments).Contains(c)));
		}
		return approvalWorkLogItemHistoryModel;
	}

	protected override HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
	{
		if (@event == null || @event.Action == null)
		{
			return null;
		}
		if (@event.Action.Uid == WorkLogItemActions.RedirectGuid)
		{
			return RedirectViewBlock();
		}
		if (@event.Action.Uid == WorkLogItemActions.EditGuid)
		{
			return UserEditViewBlock();
		}
		if (@event.Action.Uid == WorkLogItemActions.SendToApproveGuid)
		{
			return SendToApproveViewBlock();
		}
		if (@event.Action.Uid == WorkLogItemActions.ConfirmApprovalGuid)
		{
			return ConfirmApprovalViewBlock();
		}
		if (@event.Action.Uid == WorkLogItemActions.RefuseApprovalGuid)
		{
			return UnConfirmApprovalViewBlock();
		}
		if (@event.Action.Uid == WorkLogItemActions.ChangeStatusGuid)
		{
			return StatusChangeViewBlock();
		}
		return null;
	}

	protected static HistoryPartViewBlock RedirectViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/WorkLogItem.Redirect", (object)model)
		};
	}

	protected static HistoryPartViewBlock StatusChangeViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/WorkLogItem.ChangeStatus", (object)model)
		};
	}

	protected static HistoryPartViewBlock UserEditViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/WorkLogItem.Edit", (object)model)
		};
	}

	protected static HistoryPartViewBlock SendToApproveViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/WorkLogItem.SendToApprove", (object)model)
		};
	}

	protected static HistoryPartViewBlock ConfirmApprovalViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/WorkLogItem.Confirm", (object)model)
		};
	}

	protected static HistoryPartViewBlock UnConfirmApprovalViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/WorkLogItem.UnConfirm", (object)model)
		};
	}
}
