// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.RelationshipSimpleEventRender
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
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Models.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component(Order = 100)]
  public class RelationshipSimpleEventRender : BaseAuditEventRender
  {
    private UserManager userManager;

    public RelationshipSimpleEventRender(UserManager userManager) => this.userManager = userManager;

    protected override IEnumerable<Guid> Actions
    {
      get
      {
        yield return DefaultEntityActions.CreateGuid;
        yield return RelationshipActions.EditGuid;
        yield return RelationshipActions.AddCommentGuid;
        yield return RelationshipActions.CompleteGuid;
        yield return RelationshipActions.ChangeTimeGuid;
      }
    }

    protected override IEnumerable<Guid> Objects
    {
      get
      {
        yield return InterfaceActivator.UID<IRelationship>();
        yield return InterfaceActivator.UID<IRelationshipCall>();
        yield return InterfaceActivator.UID<IRelationshipMail>();
        yield return InterfaceActivator.UID<IRelationshipMeeting>();
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
      if (@event.Action.Uid == RelationshipActions.AddCommentGuid)
        return this.RenderAddComment(html, @event, historyLoader, string.Empty);
      if (@event.Action.Uid == RelationshipActions.CompleteGuid)
        return this.RenderAddComment(html, @event, historyLoader, EleWise.ELMA.SR.T("Выполнено"));
      if (@event.Action.Uid == DefaultEntityActions.CreateGuid)
        return this.RenderCreateChanges(html, @event, historyLoader);
      if (@event.Action.Uid == RelationshipActions.ChangeTimeGuid)
        return this.RenderChanges(html, @event, historyLoader, EleWise.ELMA.SR.T("Время изменено"));
      return @event.Action.Uid == RelationshipActions.EditGuid ? this.RenderEditChanges(html, @event, historyLoader) : (IHistoryBaseModel) null;
    }

    private IHistoryBaseModel RenderAddComment(
      HtmlHelper html,
      EntityActionEventArgs @event,
      IEntityActionHistoryLoader historyLoader,
      string eventSubject)
    {
      if (historyLoader == null)
        throw new ArgumentNullException(nameof (historyLoader));
      CommentRelationshipHistoryModel commentEvent = new CommentRelationshipHistoryModel(@event, eventSubject);
      IRelationship relationship = (IRelationship) @event.New;
      if (relationship.Comments != null)
      {
        List<IComment> list = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid).Select<EntityActionEventArgs, IEntity>((Func<EntityActionEventArgs, IEntity>) (q => q.New)).Cast<IComment>().Where<IComment>((Func<IComment, bool>) (q => relationship.Comments.Contains(q) && q.CreationAuthor.Equals((object) commentEvent.ActionAuthor))).ToList<IComment>();
        commentEvent.Comments = (ICollection<IComment>) list;
      }
      return (IHistoryBaseModel) commentEvent;
    }

    private IHistoryBaseModel RenderEditChanges(
      HtmlHelper html,
      EntityActionEventArgs @event,
      IEntityActionHistoryLoader historyLoader)
    {
      if (@event.EntityType == InterfaceActivator.TypeOf<IRelationshipCall>())
        return this.RenderChanges(html, @event, historyLoader, EleWise.ELMA.SR.T("Звонок изменён"));
      if (@event.EntityType == InterfaceActivator.TypeOf<IRelationshipMeeting>())
        return this.RenderChanges(html, @event, historyLoader, EleWise.ELMA.SR.T("Встреча изменена"));
      return @event.EntityType == InterfaceActivator.TypeOf<IRelationshipMail>() ? this.RenderChanges(html, @event, historyLoader, EleWise.ELMA.SR.T("Письмо изменено")) : (IHistoryBaseModel) null;
    }

    private IHistoryBaseModel RenderCreateChanges(
      HtmlHelper html,
      EntityActionEventArgs @event,
      IEntityActionHistoryLoader historyLoader)
    {
      if (@event.EntityType == InterfaceActivator.TypeOf<IRelationshipCall>())
        return this.RenderChanges(html, @event, historyLoader, EleWise.ELMA.SR.T("Звонок создан"));
      if (@event.EntityType == InterfaceActivator.TypeOf<IRelationshipMeeting>())
        return this.RenderChanges(html, @event, historyLoader, EleWise.ELMA.SR.T("Встреча создана"));
      return @event.EntityType == InterfaceActivator.TypeOf<IRelationshipMail>() ? this.RenderChanges(html, @event, historyLoader, EleWise.ELMA.SR.T("Письмо создано")) : (IHistoryBaseModel) null;
    }

    private IHistoryBaseModel RenderChanges(
      HtmlHelper html,
      EntityActionEventArgs @event,
      IEntityActionHistoryLoader historyLoader,
      string eventText)
    {
      if (historyLoader == null)
        throw new ArgumentNullException(nameof (historyLoader));
      RelationshipChangesHistoryModel historyModel = new RelationshipChangesHistoryModel(@event, eventText);
      IRelationship relationship = (IRelationship) @event.New;
      EntityActionEventArgs entityActionEventArgs1 = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Metadata.Uid, DefaultEntityActions.UpdateGuid, new long?(relationship.Id)).FirstOrDefault<EntityActionEventArgs>();
      if (entityActionEventArgs1 != null)
      {
        historyModel.OldEntity = (IRelationship) entityActionEventArgs1.Old;
        historyModel.NewEntity = (IRelationship) entityActionEventArgs1.New;
        if (entityActionEventArgs1 is EditEntityActionEventArgs entityActionEventArgs2)
          historyModel.ChangedProperties = (IList<PropertyMetadata>) entityActionEventArgs2.ChangedProperties.Where<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => !historyModel.BaseProperties.Contains(p.Uid))).ToList<PropertyMetadata>();
      }
      if (relationship.Comments != null)
      {
        IComment comment = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid).Select<EntityActionEventArgs, IEntity>((Func<EntityActionEventArgs, IEntity>) (e => e.New)).Cast<IComment>().FirstOrDefault<IComment>((Func<IComment, bool>) (c => relationship.Comments.Contains(c)));
        historyModel.Comment = comment;
      }
      if (historyModel.OldEntity != null && historyModel.NewEntity != null)
      {
        string str1 = historyModel.OldEntity.RelationshipUsersHash ?? "";
        string str2 = historyModel.NewEntity.RelationshipUsersHash ?? "";
        if (!str1.Equals(str2))
        {
          List<long> oldUsersId = ((IEnumerable<string>) str1.Split(',')).Where<string>((Func<string, bool>) (x => !string.IsNullOrWhiteSpace(x))).Select<string, long>(new Func<string, long>(long.Parse)).ToList<long>();
          List<long> newUsersId = ((IEnumerable<string>) str2.Split(',')).Where<string>((Func<string, bool>) (x => !string.IsNullOrWhiteSpace(x))).Select<string, long>(new Func<string, long>(long.Parse)).ToList<long>();
          List<long> removedUsersId = oldUsersId.Where<long>((Func<long, bool>) (c => !newUsersId.Contains(c))).ToList<long>();
          List<long> addedUsersId = newUsersId.Where<long>((Func<long, bool>) (c => !oldUsersId.Contains(c))).ToList<long>();
          ICollection<IUser> byIdArray = this.userManager.FindByIdArray(removedUsersId.Union<long>((IEnumerable<long>) addedUsersId).ToArray<long>());
          historyModel.NewEventUsers = (IList<IUser>) byIdArray.Where<IUser>((Func<IUser, bool>) (c => addedUsersId.Any<long>((Func<long, bool>) (d => d == c.Id)))).ToList<IUser>();
          historyModel.OldEventUsers = (IList<IUser>) byIdArray.Where<IUser>((Func<IUser, bool>) (c => removedUsersId.Any<long>((Func<long, bool>) (d => d == c.Id)))).ToList<IUser>();
        }
      }
      return (IHistoryBaseModel) historyModel;
    }

    protected override HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
    {
      if (@event.Action.Uid == RelationshipActions.ChangeTimeGuid)
        return this.ChangeTimeViewBlock();
      return @event.Action.Uid == RelationshipActions.EditGuid ? this.EditViewBlock() : (HistoryPartViewBlock) null;
    }

    private HistoryPartViewBlock ChangeTimeViewBlock() => new HistoryPartViewBlock()
    {
      HistoryPartType = "action",
      Index = 1,
      RenderDelegate = (Func<HtmlHelper, IHistoryBaseModel, object>) ((html, model) => (object) html.Partial("AuditView/Relationship.ChangeTime", (object) model))
    };

    private HistoryPartViewBlock EditViewBlock() => new HistoryPartViewBlock()
    {
      HistoryPartType = "action",
      Index = 1,
      RenderDelegate = (Func<HtmlHelper, IHistoryBaseModel, object>) ((html, model) => (object) html.Partial("AuditView/Relationship.Edit", (object) model))
    };
  }
}
