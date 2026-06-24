// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.ContactSimpleEventRender
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Models.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component(Order = 100)]
  public class ContactSimpleEventRender : BaseAuditEventRender
  {
    protected override IEnumerable<Guid> Actions
    {
      get
      {
        yield return ContactActions.AddCommentGuid;
        yield return DefaultEntityActions.UpdateGuid;
      }
    }

    protected override IEnumerable<Guid> Objects
    {
      get
      {
        yield return InterfaceActivator.UID<IContact>();
      }
    }

    protected override IHistoryBaseModel CreateEventData(
      HtmlHelper html,
      EntityActionEventArgs @event,
      IEntityActionHistoryLoader historyLoader)
    {
      if (html == null)
        throw new ArgumentNullException(nameof (html));
      if (@event == null)
        throw new ArgumentNullException(nameof (@event));
      if (historyLoader == null)
        throw new ArgumentNullException(nameof (historyLoader));
      if (@event.Action.Uid == ContactActions.AddCommentGuid)
        return this.RenderAddComment(html, @event, historyLoader);
      return @event.Action.Uid == DefaultEntityActions.UpdateGuid ? this.RenderUserEdit(html, @event, historyLoader) : (IHistoryBaseModel) null;
    }

    private IHistoryBaseModel RenderAddComment(
      HtmlHelper html,
      EntityActionEventArgs @event,
      IEntityActionHistoryLoader historyLoader)
    {
      if (historyLoader == null)
        throw new ArgumentNullException(nameof (historyLoader));
      CommentContactHistoryModel commentEvent = new CommentContactHistoryModel(@event, string.Empty);
      IContact contact = (IContact) @event.New;
      if (contact.Comments != null)
      {
        List<IComment> list = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid).Select<EntityActionEventArgs, IEntity>((Func<EntityActionEventArgs, IEntity>) (q => q.New)).Cast<IComment>().Where<IComment>((Func<IComment, bool>) (q => contact.Comments.Contains(q) && q.CreationAuthor.Equals((object) commentEvent.ActionAuthor))).ToList<IComment>();
        commentEvent.Comments = (ICollection<IComment>) list;
      }
      return (IHistoryBaseModel) commentEvent;
    }

    private IHistoryBaseModel RenderUserEdit(
      HtmlHelper html,
      [NotNull] EntityActionEventArgs @event,
      [NotNull] IEntityActionHistoryLoader historyLoader)
    {
      if (historyLoader == null)
        throw new ArgumentNullException(nameof (historyLoader));
      UserEditContactHistoryModel userEditEvent = new UserEditContactHistoryModel(@event, EleWise.ELMA.SR.T("Контакт изменен"));
      IContact contact = (IContact) @event.New;
      EntityActionEventArgs entityActionEventArgs1 = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, new long?(contact.Id)).FirstOrDefault<EntityActionEventArgs>();
      if (entityActionEventArgs1 != null)
      {
        userEditEvent.OldEntity = (IContact) entityActionEventArgs1.Old;
        userEditEvent.NewEntity = (IContact) entityActionEventArgs1.New;
        if (entityActionEventArgs1 is EditEntityActionEventArgs entityActionEventArgs2)
          userEditEvent.ChangedProperties = (IList<PropertyMetadata>) entityActionEventArgs2.ChangedProperties.ToList<PropertyMetadata>().Where<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => !userEditEvent.BaseProperties.Contains(p.Uid))).ToList<PropertyMetadata>();
      }
      return (IHistoryBaseModel) userEditEvent;
    }

    protected override HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
    {
      if (@event == null || @event.Action == null)
        return (HistoryPartViewBlock) null;
      if (!(@event.Action.Uid == DefaultEntityActions.UpdateGuid))
        return (HistoryPartViewBlock) null;
      return new HistoryPartViewBlock()
      {
        HistoryPartType = "action",
        Index = 1,
        RenderDelegate = (Func<HtmlHelper, IHistoryBaseModel, object>) ((html, model) => (object) html.Partial("AuditView/Contact.Edit", (object) model))
      };
    }
  }
}
