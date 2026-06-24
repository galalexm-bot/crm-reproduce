using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Audit;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.History;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.Documents.Web.Components;

[Component(Order = 100)]
public class DocumentSimpleEventRender : BaseAuditEventRender
{
	private static List<Guid> generalActions = new List<Guid>
	{
		DocumentActions.AddCommentGuid,
		DocumentActions.ChangeStatusGuid,
		DmsObjectActions.EditGuid,
		DmsObjectActions.MoveGuid,
		DefaultEntityActions.CreateGuid,
		DmsObjectActions.ArchiveGuid,
		DmsObjectActions.UnArchiveGuid,
		DmsObjectActions.ChangeAccessGuid,
		DocumentActions.SendedGuid,
		DocumentActions.EncryptGuid,
		DocumentActions.DecryptGuid,
		DocumentActions.EnterPasswordGuid,
		DocumentActions.WrongPasswordGuid,
		DocumentActions.ConvertedFromOtherTypeGuid
	};

	protected override IEnumerable<Guid> Actions
	{
		get
		{
			foreach (Guid generalAction in generalActions)
			{
				yield return generalAction;
			}
			foreach (IRenderInDocumentHistory extensionPoint in ComponentManager.Current.GetExtensionPoints<IRenderInDocumentHistory>())
			{
				yield return extensionPoint.ActionUid;
			}
		}
	}

	protected override IEnumerable<Guid> Objects
	{
		get
		{
			List<Guid> list = (from documentMetadata in MetadataServiceContext.Service.GetMetadataList().OfType<DocumentMetadata>()
				select documentMetadata.Uid).ToList();
			list.Add(InterfaceActivator.UID<IDocument>());
			return list;
		}
	}

	public override bool CanRender(EntityActionEventArgs @event)
	{
		IRenderInDocumentHistory renderInDocumentHistory = ComponentManager.Current.GetExtensionPoints<IRenderInDocumentHistory>().FirstOrDefault((IRenderInDocumentHistory r) => r.ActionUid == @event.Action.Uid && r.CanRender(@event));
		if (generalActions.Any((Guid a) => @event.Action.Uid == a))
		{
			Guid actionUid = @event.Action.Uid;
			Guid chapterUid = DocumentHistoryChapters.DocumentGeneralHistoryChapterInfo.UID;
			if (renderInDocumentHistory != null)
			{
				actionUid = renderInDocumentHistory.PrepareActionUidForHistory;
				if (renderInDocumentHistory.CustomHistoryChapter.HasValue)
				{
					chapterUid = renderInDocumentHistory.CustomHistoryChapter.Value;
				}
			}
			if ((renderInDocumentHistory != null && renderInDocumentHistory.CanRender(@event)) || (renderInDocumentHistory == null && Objects.ToList().Contains(@event.Object.Uid)))
			{
				return DocumentHistoryProfileManager.Instance.ActionIsVisible(actionUid, chapterUid, @event.Object.Uid);
			}
			return false;
		}
		return renderInDocumentHistory?.CanRender(@event) ?? base.CanRender(@event);
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
		if (@event.Action.Uid == DocumentActions.ChangeStatusGuid)
		{
			return RenderChangeStatus(html, @event, historyLoader);
		}
		if (@event.Action.Uid == DocumentActions.AddCommentGuid)
		{
			return RenderAddComment(html, @event, historyLoader);
		}
		if (@event.Action.Uid == DmsObjectActions.MoveGuid)
		{
			return RenderMove(html, @event, historyLoader);
		}
		if (@event.Action.Uid == DmsObjectActions.EditGuid)
		{
			return RenderUserEdit(html, @event, historyLoader);
		}
		if ((!@event.ExtendedProperties.ContainsKey("EventType") || !"FromTask".Equals(@event.ExtendedProperties["EventType"])) && @event.Action.Uid == DefaultEntityActions.CreateGuid)
		{
			return RenderCreate(html, @event, historyLoader);
		}
		if (@event.Action.Uid == DmsObjectActions.ArchiveGuid)
		{
			return RenderArchive(html, @event, historyLoader);
		}
		if (@event.Action.Uid == DmsObjectActions.UnArchiveGuid)
		{
			return RenderUnArchive(html, @event, historyLoader);
		}
		if (@event.Action.Uid == DmsObjectActions.ChangeAccessGuid)
		{
			return RenderChangeAccess(html, @event, historyLoader);
		}
		if (@event.Action.Uid == DocumentActions.SendedGuid)
		{
			return RenderSendDocument(html, @event, historyLoader);
		}
		if (@event.Action.Uid == DocumentActions.EncryptGuid)
		{
			return RenderEncryptDocument(html, @event, historyLoader);
		}
		if (@event.Action.Uid == DocumentActions.DecryptGuid)
		{
			return RenderDencryptDocument(html, @event, historyLoader);
		}
		if (@event.Action.Uid == DocumentActions.EnterPasswordGuid)
		{
			return RenderEnterPasswordDocument(html, @event, historyLoader);
		}
		if (@event.Action.Uid == DocumentActions.WrongPasswordGuid)
		{
			return RenderWrongPasswordDocument(html, @event, historyLoader);
		}
		if (@event.Action.Uid == DocumentActions.ConvertedFromOtherTypeGuid)
		{
			return RenderConvertedFromOtherTypeDocument(html, @event, historyLoader);
		}
		return ComponentManager.Current.GetExtensionPoints<IRenderInDocumentHistory>().FirstOrDefault((IRenderInDocumentHistory r) => r.ActionUid == @event.Action.Uid)?.RenderAction(html, @event, historyLoader);
	}

	private IHistoryBaseModel RenderConvertedFromOtherTypeDocument(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		ConvertedFromOtherTypeDocumentHistoryModel convertedFromOtherTypeDocumentHistoryModel = new ConvertedFromOtherTypeDocumentHistoryModel(@event, SR.T("Изменен тип документа (конвертация типа)"));
		if (@event is DocumentConvertedActionEventArgs documentConvertedActionEventArgs)
		{
			convertedFromOtherTypeDocumentHistoryModel.PrevTypeName = documentConvertedActionEventArgs.PrevTypeName;
			convertedFromOtherTypeDocumentHistoryModel.PrevType = documentConvertedActionEventArgs.PrevType;
			convertedFromOtherTypeDocumentHistoryModel.NewTypeName = documentConvertedActionEventArgs.NewTypeName;
			convertedFromOtherTypeDocumentHistoryModel.NewType = documentConvertedActionEventArgs.NewType;
		}
		return convertedFromOtherTypeDocumentHistoryModel;
	}

	private IHistoryBaseModel RenderWrongPasswordDocument(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		return new EncryptDocumentHistoryModel(@event, SR.T("Введен неправильный пароль для расшифровки"));
	}

	private IHistoryBaseModel RenderEnterPasswordDocument(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		return new EncryptDocumentHistoryModel(@event, SR.T("Введен правильный пароль для расшифровки"));
	}

	private IHistoryBaseModel RenderEncryptDocument(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		return new EncryptDocumentHistoryModel(@event, SR.T("Документ зашифрован"));
	}

	private IHistoryBaseModel RenderDencryptDocument(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		return new EncryptDocumentHistoryModel(@event, SR.T("Документ расшифрован"));
	}

	private IHistoryBaseModel RenderSendDocument(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		return new SendDocumentHistoryModel(@event, SR.T("Документ отправлен адресату"));
	}

	private IHistoryBaseModel RenderArchive(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		return new ArchiveDmsObjectHistoryModel(@event, SR.T("Документ помещен в архив"));
	}

	private IHistoryBaseModel RenderUnArchive(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		return new ArchiveDmsObjectHistoryModel(@event, SR.T("Документ извлечен из архива"));
	}

	private IHistoryBaseModel RenderChangeAccess(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		if (!(@event is DmsObjectChangeAccessActionEventArgs))
		{
			throw new ArgumentNullException("event");
		}
		return new ChangeAccessDmsObjecHistoryModel(@event, SR.T("Права доступа изменены"))
		{
			Info = ((DmsObjectChangeAccessActionEventArgs)@event).Info
		};
	}

	private IHistoryBaseModel RenderCreate(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		CreateDocumentHistoryModel createDocumentHistoryModel = new CreateDocumentHistoryModel(@event, SR.T("Документ создан"));
		IDocument document = (IDocument)@event.New;
		if (document.Attachments != null)
		{
			List<IAttachment> list = (List<IAttachment>)(createDocumentHistoryModel.Attachments = (from IAttachment a in from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IAttachment>(), DefaultEntityActions.CreateGuid)
					select e.New
				where ((ICollection<IAttachment>)document.Attachments).Contains(a)
				select a).ToList());
		}
		return createDocumentHistoryModel;
	}

	private IHistoryBaseModel RenderChangeStatus(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		ChangeStatusDocumentHistoryModel userEditEvent = new ChangeStatusDocumentHistoryModel(@event, SR.T("Изменен статус документа"));
		IDocument document = (IDocument)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, document.Id).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			userEditEvent.OldEntity = (IDocument)entityActionEventArgs.Old;
			userEditEvent.NewEntity = (IDocument)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				userEditEvent.ChangedProperties = editEntityActionEventArgs.ChangedProperties.Where((PropertyMetadata p) => p.Name == "Status" || !userEditEvent.BaseProperties.Contains(p.Uid)).ToList();
			}
		}
		if (document.Comments != null)
		{
			IComment comment = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
				select e.New).Cast<IComment>().FirstOrDefault((IComment c) => ((ICollection<IComment>)document.Comments).Contains(c));
			userEditEvent.Comment = comment;
		}
		return userEditEvent;
	}

	private IHistoryBaseModel RenderAddComment(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		CommentDocumentHistoryModel commentEvent = new CommentDocumentHistoryModel(@event, string.Empty);
		IDocument document = (IDocument)@event.New;
		if (document.Comments != null)
		{
			List<IComment> comments = (from IComment q in from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid).ToList()
					where e != null && e.New != null && e.New.GetId() != null
					group e by e.New.GetId().ToString() into g
					select g.First() into q
					select q.New
				where ((ICollection<IComment>)document.Comments).Contains(q) && q.CreationAuthor.Equals(commentEvent.ActionAuthor)
				select q).ToList();
			commentEvent.Comments = comments;
		}
		if (document.Attachments != null)
		{
			List<IAttachment> attachments = (from IAttachment a in from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IAttachment>(), DefaultEntityActions.CreateGuid)
					select e.New
				where ((ICollection<IAttachment>)document.Attachments).Contains(a)
				select a).ToList();
			commentEvent.Attachments = attachments;
		}
		return commentEvent;
	}

	private IHistoryBaseModel RenderMove(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		DmsObjectMoveActionEventArgs dmsObjectMoveActionEventArgs = (DmsObjectMoveActionEventArgs)@event;
		DmsObjectMoveInfo dmsInfo = dmsObjectMoveActionEventArgs.Info;
		if (dmsInfo == null)
		{
			return null;
		}
		MoveDmsObjectHistoryModel model = null;
		Locator.GetService<ISecurityService>()?.RunWithElevatedPrivilegiesAndWithDeleted(delegate
		{
			model = new MoveDmsObjectHistoryModel(@event, SR.T("Перемещен"))
			{
				OldFolder = FolderManager.Instance.LoadOrNull(dmsInfo.OldFolderId),
				NewFolder = FolderManager.Instance.LoadOrNull(dmsInfo.NewFolderId)
			};
		});
		return model;
	}

	private IHistoryBaseModel RenderUserEdit(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		UserEditDocumentHistoryModel userEditEvent = new UserEditDocumentHistoryModel(@event, SR.T("Документ изменен"));
		IDocument document = (IDocument)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, document.Id).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			userEditEvent.OldEntity = (IDocument)entityActionEventArgs.Old;
			userEditEvent.NewEntity = (IDocument)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				userEditEvent.ChangedProperties = editEntityActionEventArgs.ChangedProperties.Where((PropertyMetadata p) => !userEditEvent.BaseProperties.Contains(p.Uid)).ToList();
			}
		}
		if (document.Comments != null)
		{
			IComment comment = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
				select e.New).Cast<IComment>().FirstOrDefault((IComment c) => ((ICollection<IComment>)document.Comments).Contains(c));
			userEditEvent.Comment = comment;
		}
		if (document.Attachments != null)
		{
			List<IAttachment> attachments = (from IAttachment a in from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IAttachment>(), DefaultEntityActions.CreateGuid)
					select e.New
				where ((ICollection<IAttachment>)document.Attachments).Contains(a)
				select a).ToList();
			userEditEvent.Attachments = attachments;
		}
		return userEditEvent;
	}

	protected override HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
	{
		if (@event.Action.Uid == DocumentActions.ChangeStatusGuid)
		{
			return ChangeStatusViewBlock();
		}
		if (@event.Action.Uid == DmsObjectActions.EditGuid)
		{
			return EditViewBlock();
		}
		if (@event.Action.Uid == DmsObjectActions.MoveGuid)
		{
			return MoveViewBlock();
		}
		if (@event.Action.Uid == DmsObjectActions.ChangeAccessGuid)
		{
			return ChangeAccessViewBlock();
		}
		if (@event.Action.Uid == DocumentActions.ConvertedFromOtherTypeGuid)
		{
			return ConvertedFromOtherTypeBlock();
		}
		return ComponentManager.Current.GetExtensionPoints<IRenderInDocumentHistory>().FirstOrDefault((IRenderInDocumentHistory r) => r.ActionUid == @event.Action.Uid)?.GetExtraViewBlock(@event);
	}

	private HistoryPartViewBlock ConvertedFromOtherTypeBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/Document.ConvertedFromOtherType", (object)model)
		};
	}

	private HistoryPartViewBlock ChangeAccessViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/Document.ChangeAccess", (object)model)
		};
	}

	private HistoryPartViewBlock ChangeStatusViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/Document.ChangeStatus", (object)model)
		};
	}

	private HistoryPartViewBlock EditViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/Document.Edit", (object)model)
		};
	}

	private HistoryPartViewBlock MoveViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/Document.Move", (object)model)
		};
	}
}
