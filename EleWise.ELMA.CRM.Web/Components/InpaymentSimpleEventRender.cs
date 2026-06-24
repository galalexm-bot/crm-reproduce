// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.InpaymentSimpleEventRender
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
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Models.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component(Order = 100)]
  public class InpaymentSimpleEventRender : BaseAuditEventRender
  {
    protected override IEnumerable<Guid> Actions
    {
      get
      {
        yield return InpaymentActions.AddCommentGuid;
      }
    }

    protected override IEnumerable<Guid> Objects
    {
      get
      {
        yield return InterfaceActivator.UID<IInpayment>();
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
      return @event.Action.Uid == InpaymentActions.AddCommentGuid ? this.RenderAddComment(html, @event, historyLoader) : (IHistoryBaseModel) null;
    }

    private IHistoryBaseModel RenderAddComment(
      HtmlHelper html,
      EntityActionEventArgs @event,
      IEntityActionHistoryLoader historyLoader)
    {
      if (historyLoader == null)
        throw new ArgumentNullException(nameof (historyLoader));
      CommentInpaymentHistoryModel commentEvent = new CommentInpaymentHistoryModel(@event, string.Empty);
      IInpayment inpayment = (IInpayment) @event.New;
      if (inpayment.Comments != null)
      {
        List<IComment> list = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid).Select<EntityActionEventArgs, IEntity>((Func<EntityActionEventArgs, IEntity>) (q => q.New)).Cast<IComment>().Where<IComment>((Func<IComment, bool>) (q => inpayment.Comments.Contains(q) && q.CreationAuthor.Equals((object) commentEvent.ActionAuthor))).ToList<IComment>();
        commentEvent.Comments = (ICollection<IComment>) list;
      }
      return (IHistoryBaseModel) commentEvent;
    }
  }
}
