using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.Documents.Web.Components;

[Component(Order = 50)]
public class DocumentVersionEventRender : BaseAuditEventRender
{
	protected override IEnumerable<Guid> Actions
	{
		get
		{
			yield return DefaultEntityActions.CreateGuid;
			yield return DocumentVersionActions.LockGuid;
			yield return DocumentVersionActions.UnLockGuid;
			yield return DocumentVersionActions.ChangeStatusGuid;
			yield return DocumentVersionActions.EditGuid;
			yield return DocumentVersionActions.DownloadGuid;
		}
	}

	protected override IEnumerable<Guid> Objects
	{
		get
		{
			yield return InterfaceActivator.UID<IDocumentVersion>();
		}
	}

	public override bool CanRender(EntityActionEventArgs @event)
	{
		return base.CanRender(@event);
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
		if (@event.Action.Uid == DocumentVersionActions.LockGuid)
		{
			return RenderLock(html, @event, historyLoader);
		}
		if (@event.Action.Uid == DocumentVersionActions.UnLockGuid)
		{
			return RenderUnLock(html, @event, historyLoader);
		}
		if (@event.Action.Uid == DocumentVersionActions.ChangeStatusGuid)
		{
			return RenderChangeStatus(html, @event, historyLoader);
		}
		if (@event.Action.Uid == DocumentVersionActions.EditGuid)
		{
			return RenderUserEdit(html, @event, historyLoader);
		}
		if (@event.Action.Uid == DocumentVersionActions.DownloadGuid)
		{
			return RenderDownload(html, @event, historyLoader);
		}
		return null;
	}

	private IHistoryBaseModel RenderCreate(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		return new CreateDocumentVersionHistoryModel(@event, SR.T("Добавлена новая версия"))
		{
			Entity = (IDocumentVersion)@event.New
		};
	}

	private IHistoryBaseModel RenderLock(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		LockDocumentVersionHistoryModel lockDocumentVersionHistoryModel = new LockDocumentVersionHistoryModel(@event, SR.T("Версия документа заблокирована"));
		IDocumentVersion documentVersion = (IDocumentVersion)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, documentVersion.Id).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			lockDocumentVersionHistoryModel.OldEntity = (IDocumentVersion)entityActionEventArgs.Old;
			lockDocumentVersionHistoryModel.NewEntity = (IDocumentVersion)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				lockDocumentVersionHistoryModel.ChangedProperties = editEntityActionEventArgs.ChangedProperties.ToList();
			}
		}
		return lockDocumentVersionHistoryModel;
	}

	private IHistoryBaseModel RenderUnLock(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		UnLockDocumentVersionHistoryModel unLockDocumentVersionHistoryModel = new UnLockDocumentVersionHistoryModel(@event, SR.T("Версия документа разблокирована"));
		IDocumentVersion documentVersion = (IDocumentVersion)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, documentVersion.Id).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			unLockDocumentVersionHistoryModel.OldEntity = (IDocumentVersion)entityActionEventArgs.Old;
			unLockDocumentVersionHistoryModel.NewEntity = (IDocumentVersion)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				unLockDocumentVersionHistoryModel.ChangedProperties = editEntityActionEventArgs.ChangedProperties.ToList();
			}
		}
		return unLockDocumentVersionHistoryModel;
	}

	private IHistoryBaseModel RenderChangeStatus(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		ChangeStatusDocumentVersionHistoryModel changeStatusDocumentVersionHistoryModel = new ChangeStatusDocumentVersionHistoryModel(@event, SR.T("Изменен статус версии документа"));
		IDocumentVersion documentVersion = (IDocumentVersion)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, documentVersion.Id).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			changeStatusDocumentVersionHistoryModel.OldEntity = (IDocumentVersion)entityActionEventArgs.Old;
			changeStatusDocumentVersionHistoryModel.NewEntity = (IDocumentVersion)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				changeStatusDocumentVersionHistoryModel.ChangedProperties = editEntityActionEventArgs.ChangedProperties.ToList();
			}
		}
		return changeStatusDocumentVersionHistoryModel;
	}

	private IHistoryBaseModel RenderUserEdit(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		UserEditDocumentVersionHistoryModel userEditDocumentVersionHistoryModel = new UserEditDocumentVersionHistoryModel(@event, SR.T("Версия документа изменена"));
		IDocumentVersion documentVersion = (IDocumentVersion)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, documentVersion.Id).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			userEditDocumentVersionHistoryModel.OldEntity = (IDocumentVersion)entityActionEventArgs.Old;
			userEditDocumentVersionHistoryModel.NewEntity = (IDocumentVersion)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				userEditDocumentVersionHistoryModel.ChangedProperties = editEntityActionEventArgs.ChangedProperties.ToList();
			}
		}
		IComment comment2 = (userEditDocumentVersionHistoryModel.Comment = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
			select e.New).Cast<IComment>().FirstOrDefault());
		List<IAttachment> list = (List<IAttachment>)(userEditDocumentVersionHistoryModel.Attachments = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IAttachment>(), DefaultEntityActions.CreateGuid)
			select e.New).Cast<IAttachment>().ToList());
		return userEditDocumentVersionHistoryModel;
	}

	private IHistoryBaseModel RenderDownload(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		return new CreateDocumentVersionHistoryModel(@event, SR.T("Выгружена версия"))
		{
			Entity = (IDocumentVersion)@event.New
		};
	}

	protected override HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
	{
		if (@event.Action.Uid == DefaultEntityActions.CreateGuid)
		{
			return CreateViewBlock();
		}
		if (@event.Action.Uid == DocumentVersionActions.LockGuid)
		{
			return LockViewBlock();
		}
		if (@event.Action.Uid == DocumentVersionActions.UnLockGuid)
		{
			return UnLockViewBlock();
		}
		if (@event.Action.Uid == DocumentVersionActions.ChangeStatusGuid)
		{
			return ChangeStatusViewBlock();
		}
		if (@event.Action.Uid == DocumentVersionActions.EditGuid)
		{
			return UserEditBlock();
		}
		if (@event.Action.Uid == DocumentVersionActions.DownloadGuid)
		{
			return DownloadBlock();
		}
		return null;
	}

	private HistoryPartViewBlock DownloadBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/DocumentVersion.Download", (object)model)
		};
	}

	private HistoryPartViewBlock CreateViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/DocumentVersion.Create", (object)model)
		};
	}

	private HistoryPartViewBlock LockViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/DocumentVersion.Lock", (object)model)
		};
	}

	private HistoryPartViewBlock UnLockViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/DocumentVersion.UnLock", (object)model)
		};
	}

	private HistoryPartViewBlock ChangeStatusViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/DocumentVersion.ChangeStatus", (object)model)
		};
	}

	private HistoryPartViewBlock UserEditBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/DocumentVersion.Edit", (object)model)
		};
	}
}
