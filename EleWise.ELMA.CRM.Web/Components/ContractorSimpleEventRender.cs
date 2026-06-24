// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.ContractorSimpleEventRender
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Audit;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Models.BillingInformation;
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
  public class ContractorSimpleEventRender : BaseAuditEventRender
  {
    protected override IEnumerable<Guid> Actions
    {
      get
      {
        yield return ContractorActions.AddCommentGuid;
        yield return DefaultEntityActions.CreateGuid;
        yield return ContractorActions.EditGuid;
        yield return ContractorActions.AddSlaveGuid;
        yield return ContractorActions.DelSlaveGuid;
        yield return ContractorActions.ChangeAccessGuid;
        yield return ContContractorPermissionActions.ChangeAccessGuid;
      }
    }

    protected override IEnumerable<Guid> Objects
    {
      get
      {
        List<Guid> list = MetadataServiceContext.Service.GetMetadataList().OfType<ClassMetadata>().Where<ClassMetadata>((Func<ClassMetadata, bool>) (m => m.BaseClassUid == InterfaceActivator.UID<IContractor>())).Select<ClassMetadata, Guid>((Func<ClassMetadata, Guid>) (m => m.Uid)).ToList<Guid>();
        list.Add(InterfaceActivator.UID<IContContractorPermission>());
        return (IEnumerable<Guid>) list;
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
      if (@event.Action.Uid == ContractorActions.AddCommentGuid)
        return this.RenderAddComment(html, @event, historyLoader);
      if (@event.Action.Uid == DefaultEntityActions.CreateGuid)
        return this.RenderCreate(html, @event, historyLoader);
      if (@event.Action.Uid == ContractorActions.EditGuid)
        return this.RenderUserEdit(html, @event, historyLoader);
      if (@event.Action.Uid == ContractorActions.AddSlaveGuid)
        return this.RenderUserSlaveEdit(html, @event, historyLoader);
      if (@event.Action.Uid == ContractorActions.DelSlaveGuid)
        return this.RenderUserSlaveDel(html, @event, historyLoader);
      if (@event.Action.Uid == ContractorActions.ChangeAccessGuid)
        return this.RenderChangeAccess(html, @event, historyLoader);
      return @event.Action.Uid == ContContractorPermissionActions.ChangeAccessGuid ? this.RenderContContractorChangeAccess(html, @event, historyLoader) : (IHistoryBaseModel) null;
    }

    private IHistoryBaseModel RenderChangeAccess(
      HtmlHelper html,
      [NotNull] EntityActionEventArgs @event,
      [NotNull] IEntityActionHistoryLoader historyLoader)
    {
      if (historyLoader == null)
        throw new ArgumentNullException(nameof (historyLoader));
      return @event is ContractorChangeAccessActionEventArgs ? (IHistoryBaseModel) new ChangeAccessContractorHistoryModel(@event, EleWise.ELMA.SR.T("Права доступа изменены"))
      {
        Info = ((ContractorChangeAccessActionEventArgs) @event).Info
      } : throw new ArgumentNullException(nameof (@event));
    }

    private IHistoryBaseModel RenderCommentAction(
      HtmlHelper html,
      EntityActionEventArgs @event,
      IEntityActionHistoryLoader historyLoader,
      string eventTheme)
    {
      if (historyLoader == null)
        throw new ArgumentNullException(nameof (historyLoader));
      CommentContractorHistoryModel commentEvent = new CommentContractorHistoryModel(@event, eventTheme);
      IContractor contractor = (IContractor) @event.New;
      if (contractor.Comments != null)
      {
        List<IComment> list = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid).Select<EntityActionEventArgs, IEntity>((Func<EntityActionEventArgs, IEntity>) (q => q.New)).Cast<IComment>().Where<IComment>((Func<IComment, bool>) (q => contractor.Comments.Contains(q) && q.CreationAuthor.Equals((object) commentEvent.ActionAuthor))).ToList<IComment>();
        commentEvent.Comments = (ICollection<IComment>) list;
      }
      return (IHistoryBaseModel) commentEvent;
    }

    private IHistoryBaseModel RenderAddComment(
      HtmlHelper html,
      EntityActionEventArgs @event,
      IEntityActionHistoryLoader historyLoader,
      string caption = null)
    {
      return this.RenderCommentAction(html, @event, historyLoader, caption);
    }

    private IHistoryBaseModel RenderCreate(
      HtmlHelper html,
      [NotNull] EntityActionEventArgs @event,
      [NotNull] IEntityActionHistoryLoader historyLoader,
      string caption = null)
    {
      return this.RenderCommentAction(html, @event, historyLoader, caption ?? EleWise.ELMA.SR.T("Контрагент создан"));
    }

    private IHistoryBaseModel RenderUserSlaveEdit(
      HtmlHelper html,
      [NotNull] EntityActionEventArgs @event,
      [NotNull] IEntityActionHistoryLoader historyLoader,
      string caption = null)
    {
      if (historyLoader == null)
        throw new ArgumentNullException(nameof (historyLoader));
      SlaveActionContractorHistoryModel contractorHistoryModel = new SlaveActionContractorHistoryModel(@event, EleWise.ELMA.SR.T("Добавление связанных объектов"));
      IContractor contractor = (IContractor) @event.New;
      EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, ContractorActions.AddSlaveGuid, new long?(contractor.Id)).FirstOrDefault<EntityActionEventArgs>();
      if (entityActionEventArgs != null && entityActionEventArgs is ContractorSlaveActionEventArgs)
      {
        ContractorSlaveActionEventArgs slaveActionEventArgs = entityActionEventArgs as ContractorSlaveActionEventArgs;
        contractorHistoryModel.NewEntity = contractor;
        contractorHistoryModel.OldEntity = contractor;
        contractorHistoryModel.SlaveObject = slaveActionEventArgs.SlaveObject;
        contractorHistoryModel.ActionUid = slaveActionEventArgs.ActionUid;
      }
      return (IHistoryBaseModel) contractorHistoryModel;
    }

    private IHistoryBaseModel RenderContContractorChangeAccess(
      HtmlHelper html,
      [NotNull] EntityActionEventArgs @event,
      [NotNull] IEntityActionHistoryLoader historyLoader,
      string caption = null)
    {
      if (historyLoader == null)
        throw new ArgumentNullException(nameof (historyLoader));
      CategoryContractorChangeAccessActionEventArgs originalEvent = @event is CategoryContractorChangeAccessActionEventArgs ? @event as CategoryContractorChangeAccessActionEventArgs : throw new ArgumentNullException(nameof (@event));
      ICategory category = CategoryManager.Instance.LoadOrNull(originalEvent.Info.CategoryId);
      string str = category != null ? category.Name : "";
      return (IHistoryBaseModel) new ChangeAccessContractorHistoryModel((EntityActionEventArgs) originalEvent, EleWise.ELMA.SR.T("Изменение прав в категории {0}", (object) str))
      {
        Info = originalEvent.Info
      };
    }

    private IHistoryBaseModel RenderUserSlaveDel(
      HtmlHelper html,
      [NotNull] EntityActionEventArgs @event,
      [NotNull] IEntityActionHistoryLoader historyLoader,
      string caption = null)
    {
      if (historyLoader == null)
        throw new ArgumentNullException(nameof (historyLoader));
      SlaveActionContractorHistoryModel contractorHistoryModel = new SlaveActionContractorHistoryModel(@event, EleWise.ELMA.SR.T("Удаление связанных объектов"));
      IContractor contractor = (IContractor) @event.New;
      EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, ContractorActions.DelSlaveGuid, new long?(contractor.Id)).FirstOrDefault<EntityActionEventArgs>();
      if (entityActionEventArgs != null && entityActionEventArgs is ContractorSlaveActionEventArgs)
      {
        ContractorSlaveActionEventArgs slaveActionEventArgs = entityActionEventArgs as ContractorSlaveActionEventArgs;
        contractorHistoryModel.NewEntity = contractor;
        contractorHistoryModel.OldEntity = contractor;
        contractorHistoryModel.SlaveObject = slaveActionEventArgs.SlaveObject;
        contractorHistoryModel.ActionUid = slaveActionEventArgs.ActionUid;
      }
      return (IHistoryBaseModel) contractorHistoryModel;
    }

    public IHistoryBaseModel RenderUserEdit(
      HtmlHelper html,
      [NotNull] EntityActionEventArgs @event,
      [NotNull] IEntityActionHistoryLoader historyLoader)
    {
      if (historyLoader == null)
        throw new ArgumentNullException(nameof (historyLoader));
      UserEditContractorHistoryModel userEditEvent = new UserEditContractorHistoryModel(@event, EleWise.ELMA.SR.T("Контрагент изменен"));
      IContractor contractor = (IContractor) @event.New;
      EntityActionEventArgs entityActionEventArgs1 = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, new long?(contractor.Id)).FirstOrDefault<EntityActionEventArgs>();
      if (entityActionEventArgs1 != null)
      {
        userEditEvent.OldEntity = (IContractor) entityActionEventArgs1.Old;
        userEditEvent.NewEntity = (IContractor) entityActionEventArgs1.New;
        if (entityActionEventArgs1 is EditEntityActionEventArgs entityActionEventArgs2)
          userEditEvent.ChangedProperties = (IList<PropertyMetadata>) entityActionEventArgs2.ChangedProperties.ToList<PropertyMetadata>().Where<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => !userEditEvent.BaseProperties.Contains(p.Uid))).ToList<PropertyMetadata>();
      }
      IEnumerable<EntityActionEventArgs> entityActionEventArgses1 = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IPaymentCard>(), DefaultEntityActions.UpdateGuid);
      userEditEvent.PaymentCardUpdateEvents = entityActionEventArgses1;
      List<IPaymentCard> list1 = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IPaymentCard>(), DefaultEntityActions.CreateGuid).Select<EntityActionEventArgs, IEntity>((Func<EntityActionEventArgs, IEntity>) (e => e.New)).Cast<IPaymentCard>().ToList<IPaymentCard>();
      userEditEvent.NewPaymentCards = (IList<IPaymentCard>) list1;
      IEnumerable<EntityActionEventArgs> entityActionEventArgses2 = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IBankAccount>(), DefaultEntityActions.UpdateGuid);
      userEditEvent.BankAccountUpdateEvents = entityActionEventArgses2;
      List<IBankAccount> list2 = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IBankAccount>(), DefaultEntityActions.CreateGuid).Select<EntityActionEventArgs, IEntity>((Func<EntityActionEventArgs, IEntity>) (e => e.New)).Cast<IBankAccount>().ToList<IBankAccount>();
      userEditEvent.NewBankAccounts = (IList<IBankAccount>) list2;
      IEnumerable<EntityActionEventArgs> entityActionEventArgses3 = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IEmail>(), DefaultEntityActions.UpdateGuid);
      userEditEvent.EmailUpdateEvents = entityActionEventArgses3;
      List<IEmail> list3 = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IEmail>(), DefaultEntityActions.CreateGuid).Select<EntityActionEventArgs, IEntity>((Func<EntityActionEventArgs, IEntity>) (e => e.New)).Cast<IEmail>().ToList<IEmail>();
      userEditEvent.NewEmails = (IList<IEmail>) list3;
      IEnumerable<EntityActionEventArgs> entityActionEventArgses4 = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IPhone>(), DefaultEntityActions.UpdateGuid);
      userEditEvent.PhoneUpdateEvents = entityActionEventArgses4;
      List<IPhone> list4 = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IPhone>(), DefaultEntityActions.CreateGuid).Select<EntityActionEventArgs, IEntity>((Func<EntityActionEventArgs, IEntity>) (e => e.New)).Cast<IPhone>().ToList<IPhone>();
      userEditEvent.NewPhones = (IList<IPhone>) list4;
      if (userEditEvent.OldEntity != null && userEditEvent.NewEntity != null)
      {
        string str1 = userEditEvent.OldEntity.CategoriesHash ?? "";
        string str2 = userEditEvent.NewEntity.CategoriesHash ?? "";
        if (!str1.Equals(str2))
        {
          List<long> oldCategories = ((IEnumerable<string>) str1.Split(',')).Where<string>((Func<string, bool>) (x => !string.IsNullOrWhiteSpace(x))).Select<string, long>(new Func<string, long>(long.Parse)).ToList<long>();
          List<long> newCategories = ((IEnumerable<string>) str2.Split(',')).Where<string>((Func<string, bool>) (x => !string.IsNullOrWhiteSpace(x))).Select<string, long>(new Func<string, long>(long.Parse)).ToList<long>();
          List<long> removedCategories = oldCategories.Where<long>((Func<long, bool>) (c => !newCategories.Contains(c))).ToList<long>();
          List<long> addedCategories = newCategories.Where<long>((Func<long, bool>) (c => !oldCategories.Contains(c))).ToList<long>();
          ICollection<ICategory> byIdArray = CategoryManager.Instance.FindByIdArray(removedCategories.Union<long>((IEnumerable<long>) addedCategories).ToArray<long>());
          userEditEvent.NewCategory = (IList<ICategory>) byIdArray.Where<ICategory>((Func<ICategory, bool>) (c => addedCategories.Any<long>((Func<long, bool>) (d => d == c.Id)))).ToList<ICategory>();
          userEditEvent.OldCategory = (IList<ICategory>) byIdArray.Where<ICategory>((Func<ICategory, bool>) (c => removedCategories.Any<long>((Func<long, bool>) (d => d == c.Id)))).ToList<ICategory>();
        }
      }
      return (IHistoryBaseModel) userEditEvent;
    }

    protected override HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
    {
      if (@event == null || @event.Action == null)
        return (HistoryPartViewBlock) null;
      if (@event.Action.Uid == ContractorActions.EditGuid)
        return ContractorSimpleEventRender.EditViewBlock();
      if (@event.Action.Uid == ContractorActions.AddSlaveGuid || @event.Action.Uid == ContractorActions.DelSlaveGuid)
        return ContractorSimpleEventRender.EditSlaveViewBlock();
      return @event.Action.Uid == ContractorActions.ChangeAccessGuid || @event.Action.Uid == ContContractorPermissionActions.ChangeAccessGuid ? this.ChangeAccessSlaveViewBlock() : (HistoryPartViewBlock) null;
    }

    private static HistoryPartViewBlock EditViewBlock() => new HistoryPartViewBlock()
    {
      HistoryPartType = "action",
      Index = 1,
      RenderDelegate = (Func<HtmlHelper, IHistoryBaseModel, object>) ((html, model) => (object) html.Partial("AuditView/Contractor.Edit", (object) model))
    };

    private static HistoryPartViewBlock EditSlaveViewBlock() => new HistoryPartViewBlock()
    {
      HistoryPartType = "action",
      Index = 1,
      RenderDelegate = (Func<HtmlHelper, IHistoryBaseModel, object>) ((html, model) => (object) html.Partial("AuditView/ContractorSlave.Edit", (object) model))
    };

    private HistoryPartViewBlock ChangeAccessSlaveViewBlock() => new HistoryPartViewBlock()
    {
      HistoryPartType = "action",
      Index = 1,
      RenderDelegate = (Func<HtmlHelper, IHistoryBaseModel, object>) ((html, model) => (object) html.Partial("AuditView/Contractor.ChangeAccess", (object) model))
    };
  }
}
