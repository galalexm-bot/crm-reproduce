using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.Documents.Web.Components;

[Component]
public class DocumentLinkEventRender : BaseAuditEventRender
{
	protected override IEnumerable<Guid> Actions
	{
		get
		{
			yield return DocumentLinkActions.UserCreateGuid;
			yield return DocumentLinkActions.UserDeleteGuid;
			yield return DocumentLinkActions.UserEditGuid;
		}
	}

	protected override IEnumerable<Guid> Objects
	{
		get
		{
			yield return InterfaceActivator.UID<IDocumentLink>();
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
		if (@event.Action == null)
		{
			throw new ArgumentException("event.Action");
		}
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		if (@event.Action.Uid == DocumentLinkActions.UserCreateGuid)
		{
			return RenderCreate(html, @event, historyLoader);
		}
		if (@event.Action.Uid == DocumentLinkActions.UserEditGuid)
		{
			return RenderUserEdit(html, @event, historyLoader);
		}
		if (@event.Action.Uid == DocumentLinkActions.UserDeleteGuid)
		{
			return RenderUserDelete(html, @event, historyLoader);
		}
		return null;
	}

	private IHistoryBaseModel RenderCreate(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		IDocumentLink entity = (IDocumentLink)@event.New;
		return new CreateDocumentLinkHistoryModel(@event, SR.T("Создана связь с документом"))
		{
			Entity = entity
		};
	}

	private IHistoryBaseModel RenderUserDelete(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		IDocumentLink entity = (IDocumentLink)@event.New;
		return new CreateDocumentLinkHistoryModel(@event, SR.T("Удалена связь с документом"))
		{
			Entity = entity
		};
	}

	private IHistoryBaseModel RenderUserEdit(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		UserEditDocumentLinkHistoryModel userEditDocumentLinkHistoryModel = new UserEditDocumentLinkHistoryModel(@event, SR.T("Связь с документом изменена"));
		IDocumentLink documentLink = (IDocumentLink)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, documentLink.Id).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			userEditDocumentLinkHistoryModel.OldEntity = (IDocumentLink)entityActionEventArgs.Old;
			userEditDocumentLinkHistoryModel.NewEntity = (IDocumentLink)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				userEditDocumentLinkHistoryModel.ChangedProperties = editEntityActionEventArgs.ChangedProperties.ToList();
			}
		}
		return userEditDocumentLinkHistoryModel;
	}

	protected override HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
	{
		if (@event.Action.Uid == DocumentLinkActions.UserCreateGuid)
		{
			return CreateViewBlock();
		}
		if (@event.Action.Uid == DocumentLinkActions.UserEditGuid)
		{
			return UserEditBlock();
		}
		if (@event.Action.Uid == DocumentLinkActions.UserDeleteGuid)
		{
			return UserDeleteBlock();
		}
		return null;
	}

	private HistoryPartViewBlock CreateViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/DocumentLink.Create", (object)model)
		};
	}

	private HistoryPartViewBlock UserEditBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/DocumentLink.Edit", (object)model)
		};
	}

	private HistoryPartViewBlock UserDeleteBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/DocumentLink.Delete", (object)model)
		};
	}
}
