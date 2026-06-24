// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.MarketingBaseSimpleEventRender
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
  public class MarketingBaseSimpleEventRender : BaseAuditEventRender
  {
    private readonly string marketingBaseStatusName = "Status";

    protected override IEnumerable<Guid> Actions
    {
      get
      {
        yield return MarketingBaseActions.AddCommentGuid;
        yield return MarketingBaseActions.ActivateGuid;
        yield return MarketingBaseActions.ArchiveGuid;
        yield return DefaultEntityActions.CreateGuid;
        yield return DefaultEntityActions.UpdateGuid;
      }
    }

    protected override IEnumerable<Guid> Objects => (IEnumerable<Guid>) new Guid[3]
    {
      InterfaceActivator.UID<IMarketingGroup>(),
      InterfaceActivator.UID<IMarketingActivity>(),
      InterfaceActivator.UID<IMarketingEffect>()
    };

    public override bool CanRender(EntityActionEventArgs @event)
    {
      if (!base.CanRender(@event))
        return false;
      return !(@event is EditEntityActionEventArgs entityActionEventArgs) || !entityActionEventArgs.ChangedProperties.Any<PropertyMetadata>((Func<PropertyMetadata, bool>) (c => c.Name == this.marketingBaseStatusName));
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
      if (@event.Action.Uid == MarketingBaseActions.AddCommentGuid)
        return this.RenderAddComment(@event, historyLoader, string.Empty);
      if (@event.Action.Uid == MarketingBaseActions.ArchiveGuid)
        return this.RenderAddComment(@event, historyLoader, EleWise.ELMA.SR.T("Перемещено(а) в архив"));
      if (@event.Action.Uid == MarketingBaseActions.ActivateGuid)
        return this.RenderAddComment(@event, historyLoader, EleWise.ELMA.SR.T("Восстановлено(а) из архива"));
      if (@event.Action.Uid == DefaultEntityActions.CreateGuid)
        return this.RenderCreateChanges(html, @event, historyLoader);
      return @event.Action.Uid == DefaultEntityActions.UpdateGuid ? this.RenderUpdateChanges(html, @event, historyLoader) : (IHistoryBaseModel) null;
    }

    private IHistoryBaseModel RenderAddComment(
      EntityActionEventArgs @event,
      IEntityActionHistoryLoader historyLoader,
      string text)
    {
      if (historyLoader == null)
        throw new ArgumentNullException(nameof (historyLoader));
      CommentMarketingBaseHistoryModel commentEvent = new CommentMarketingBaseHistoryModel(@event, text);
      IMarketingBase marketing = (IMarketingBase) @event.New;
      if (marketing.Comments != null)
      {
        List<IComment> list = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid).Select<EntityActionEventArgs, IEntity>((Func<EntityActionEventArgs, IEntity>) (q => q.New)).Cast<IComment>().Where<IComment>((Func<IComment, bool>) (q => marketing.Comments.Contains(q) && q.CreationAuthor.Equals((object) commentEvent.ActionAuthor))).ToList<IComment>();
        commentEvent.Comments = (ICollection<IComment>) list;
      }
      return (IHistoryBaseModel) commentEvent;
    }

    private IHistoryBaseModel RenderCreateChanges(
      HtmlHelper html,
      EntityActionEventArgs @event,
      IEntityActionHistoryLoader historyLoader)
    {
      if (@event.EntityType == InterfaceActivator.TypeOf<IMarketingGroup>())
        return this.RenderChanges(@event, historyLoader, EleWise.ELMA.SR.T("Группа маркетинговых мероприятий создана"));
      if (@event.EntityType == InterfaceActivator.TypeOf<IMarketingActivity>())
        return this.RenderChanges(@event, historyLoader, EleWise.ELMA.SR.T("Маркетинговое мероприятие создано"));
      return @event.EntityType == InterfaceActivator.TypeOf<IMarketingEffect>() ? this.RenderChanges(@event, historyLoader, EleWise.ELMA.SR.T("Маркетинговое воздействие создано")) : (IHistoryBaseModel) null;
    }

    private IHistoryBaseModel RenderUpdateChanges(
      HtmlHelper html,
      EntityActionEventArgs @event,
      IEntityActionHistoryLoader historyLoader)
    {
      if (@event.EntityType == InterfaceActivator.TypeOf<IMarketingGroup>())
        return this.RenderChanges(@event, historyLoader, EleWise.ELMA.SR.T("Группа маркетинговых мероприятий изменена"));
      if (@event.EntityType == InterfaceActivator.TypeOf<IMarketingActivity>())
        return this.RenderChanges(@event, historyLoader, EleWise.ELMA.SR.T("Маркетинговое мероприятие изменено"));
      return @event.EntityType == InterfaceActivator.TypeOf<IMarketingEffect>() ? this.RenderChanges(@event, historyLoader, EleWise.ELMA.SR.T("Маркетинговое воздействие изменено")) : (IHistoryBaseModel) null;
    }

    private IHistoryBaseModel RenderChanges(
      EntityActionEventArgs @event,
      IEntityActionHistoryLoader historyLoader,
      string eventText)
    {
      if (historyLoader == null)
        throw new ArgumentNullException(nameof (historyLoader));
      MarketingBaseChangesHistoryModel historyModel = new MarketingBaseChangesHistoryModel(@event, eventText);
      IMarketingBase marketingBase = (IMarketingBase) @event.New;
      EntityActionEventArgs entityActionEventArgs1 = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Metadata.Uid, DefaultEntityActions.UpdateGuid, new long?(marketingBase.Id)).FirstOrDefault<EntityActionEventArgs>();
      if (entityActionEventArgs1 != null)
      {
        historyModel.OldEntity = (IMarketingBase) entityActionEventArgs1.Old;
        historyModel.NewEntity = (IMarketingBase) entityActionEventArgs1.New;
        if (entityActionEventArgs1 is EditEntityActionEventArgs entityActionEventArgs2)
          historyModel.ChangedProperties = (IList<PropertyMetadata>) entityActionEventArgs2.ChangedProperties.Where<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => !historyModel.BaseProperties.Contains(p.Uid))).ToList<PropertyMetadata>();
      }
      if (marketingBase.Comments != null)
      {
        IComment comment = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid).Select<EntityActionEventArgs, IEntity>((Func<EntityActionEventArgs, IEntity>) (e => e.New)).Cast<IComment>().FirstOrDefault<IComment>((Func<IComment, bool>) (c => marketingBase.Comments.Contains(c)));
        historyModel.Comment = comment;
      }
      return (IHistoryBaseModel) historyModel;
    }

    protected override HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event) => @event.Action.Uid == DefaultEntityActions.UpdateGuid ? this.UpdateViewBlock() : (HistoryPartViewBlock) null;

    private HistoryPartViewBlock UpdateViewBlock() => new HistoryPartViewBlock()
    {
      HistoryPartType = "action",
      Index = 1,
      RenderDelegate = (Func<HtmlHelper, IHistoryBaseModel, object>) ((html, model) => (object) html.Partial("AuditView/Marketing.Update", (object) model))
    };
  }
}
