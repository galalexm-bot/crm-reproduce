// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.SaleSimpleEventRender
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
  public class SaleSimpleEventRender : BaseAuditEventRender
  {
    private string saleStatusName;
    private string saleStageName;

    public SaleSimpleEventRender()
    {
      this.saleStatusName = "SaleStatus";
      this.saleStageName = "SaleStage";
    }

    protected override IEnumerable<Guid> Actions
    {
      get
      {
        yield return DefaultEntityActions.CreateGuid;
        yield return DefaultEntityActions.UpdateGuid;
        yield return SaleActions.AddCommentGuid;
        yield return SaleActions.ChangeStatusGuid;
        yield return SaleActions.ChangeStageGuid;
      }
    }

    protected override IEnumerable<Guid> Objects
    {
      get
      {
        yield return InterfaceActivator.UID<ISale>();
      }
    }

    public override bool CanRender(EntityActionEventArgs @event)
    {
      if (!base.CanRender(@event))
        return false;
      return !(@event is EditEntityActionEventArgs entityActionEventArgs) || !entityActionEventArgs.ChangedProperties.Any<PropertyMetadata>((Func<PropertyMetadata, bool>) (c => c.Name == this.saleStatusName || c.Name == this.saleStageName));
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
      if (@event.Action.Uid == DefaultEntityActions.CreateGuid)
        return this.RenderChanges(html, @event, historyLoader, EleWise.ELMA.SR.T("Сделка создана"));
      if (@event.Action.Uid == DefaultEntityActions.UpdateGuid)
        return this.RenderChanges(html, @event, historyLoader, EleWise.ELMA.SR.T("Сделка изменена"));
      if (@event.Action.Uid == SaleActions.AddCommentGuid)
        return this.RenderAddComment(html, @event, historyLoader);
      if (@event.Action.Uid == SaleActions.ChangeStatusGuid)
        return this.RenderChanges(html, @event, historyLoader, EleWise.ELMA.SR.T("Статус сделки изменен"));
      return @event.Action.Uid == SaleActions.ChangeStageGuid ? this.RenderChanges(html, @event, historyLoader, EleWise.ELMA.SR.T("Стадия сделки изменена")) : (IHistoryBaseModel) null;
    }

    private IHistoryBaseModel RenderAddComment(
      HtmlHelper html,
      EntityActionEventArgs @event,
      IEntityActionHistoryLoader historyLoader)
    {
      if (historyLoader == null)
        throw new ArgumentNullException(nameof (historyLoader));
      CommentSaleHistoryModel commentEvent = new CommentSaleHistoryModel(@event, string.Empty);
      ISale sale = (ISale) @event.New;
      if (sale.Comments != null)
      {
        List<IComment> list = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid).Select<EntityActionEventArgs, IEntity>((Func<EntityActionEventArgs, IEntity>) (q => q.New)).Cast<IComment>().Where<IComment>((Func<IComment, bool>) (q => sale.Comments.Contains(q) && q.CreationAuthor.Equals((object) commentEvent.ActionAuthor))).ToList<IComment>();
        commentEvent.Comments = (ICollection<IComment>) list;
      }
      return (IHistoryBaseModel) commentEvent;
    }

    protected IHistoryBaseModel RenderChanges(
      HtmlHelper html,
      EntityActionEventArgs @event,
      IEntityActionHistoryLoader historyLoader,
      string eventText)
    {
      if (historyLoader == null)
        throw new ArgumentNullException(nameof (historyLoader));
      SaleChangesHistoryModel historyModel = new SaleChangesHistoryModel(@event, eventText);
      ISale sale = (ISale) @event.New;
      EntityActionEventArgs entityActionEventArgs1 = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<ISale>(), DefaultEntityActions.UpdateGuid, new long?(sale.Id)).FirstOrDefault<EntityActionEventArgs>();
      if (entityActionEventArgs1 != null)
      {
        historyModel.OldEntity = (ISale) entityActionEventArgs1.Old;
        historyModel.NewEntity = (ISale) entityActionEventArgs1.New;
        if (entityActionEventArgs1 is EditEntityActionEventArgs entityActionEventArgs2)
          historyModel.ChangedProperties = (IList<PropertyMetadata>) entityActionEventArgs2.ChangedProperties.Where<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => !historyModel.BaseProperties.Contains(p.Uid))).ToList<PropertyMetadata>();
      }
      if (sale.Comments != null && historyModel.ChangedProperties != null && historyModel.ChangedProperties.Any<PropertyMetadata>())
      {
        IComment comment = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid).Select<EntityActionEventArgs, IEntity>((Func<EntityActionEventArgs, IEntity>) (e => e.New)).Cast<IComment>().FirstOrDefault<IComment>((Func<IComment, bool>) (c => sale.Comments.Contains(c)));
        historyModel.Comment = comment;
      }
      return (IHistoryBaseModel) historyModel;
    }

    protected override HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
    {
      if (@event.Action.Uid == DefaultEntityActions.UpdateGuid)
        return this.UpdateViewBlock();
      if (@event.Action.Uid == SaleActions.ChangeStatusGuid)
        return this.ChangeStatusViewBlock();
      return @event.Action.Uid == SaleActions.ChangeStageGuid ? this.ChangeStageViewBlock() : (HistoryPartViewBlock) null;
    }

    private HistoryPartViewBlock UpdateViewBlock() => new HistoryPartViewBlock()
    {
      HistoryPartType = "action",
      Index = 1,
      RenderDelegate = (Func<HtmlHelper, IHistoryBaseModel, object>) ((html, model) => (object) html.Partial("AuditView/Sale.UpdateView", (object) model))
    };

    private HistoryPartViewBlock ChangeStatusViewBlock() => new HistoryPartViewBlock()
    {
      HistoryPartType = "action",
      Index = 1,
      RenderDelegate = (Func<HtmlHelper, IHistoryBaseModel, object>) ((html, model) => (object) html.Partial("AuditView/Sale.ChangeStatus", (object) model))
    };

    private HistoryPartViewBlock ChangeStageViewBlock() => new HistoryPartViewBlock()
    {
      HistoryPartType = "action",
      Index = 1,
      RenderDelegate = (Func<HtmlHelper, IHistoryBaseModel, object>) ((html, model) => (object) html.Partial("AuditView/Sale.ChangeStage", (object) model))
    };
  }
}
