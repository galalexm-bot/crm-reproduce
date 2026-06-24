using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Audit;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.CRM.Web.Components;

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
			List<Guid> list = (from m in MetadataServiceContext.Service.GetMetadataList().OfType<ClassMetadata>()
				where m.BaseClassUid == InterfaceActivator.UID<IContractor>()
				select m.Uid).ToList();
			list.Add(InterfaceActivator.UID<IContContractorPermission>());
			return list;
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
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		if (@event.Action.Uid == ContractorActions.AddCommentGuid)
		{
			return RenderAddComment(html, @event, historyLoader);
		}
		if (@event.Action.Uid == DefaultEntityActions.CreateGuid)
		{
			return RenderCreate(html, @event, historyLoader);
		}
		if (@event.Action.Uid == ContractorActions.EditGuid)
		{
			return RenderUserEdit(html, @event, historyLoader);
		}
		if (@event.Action.Uid == ContractorActions.AddSlaveGuid)
		{
			return RenderUserSlaveEdit(html, @event, historyLoader);
		}
		if (@event.Action.Uid == ContractorActions.DelSlaveGuid)
		{
			return RenderUserSlaveDel(html, @event, historyLoader);
		}
		if (@event.Action.Uid == ContractorActions.ChangeAccessGuid)
		{
			return RenderChangeAccess(html, @event, historyLoader);
		}
		if (@event.Action.Uid == ContContractorPermissionActions.ChangeAccessGuid)
		{
			return RenderContContractorChangeAccess(html, @event, historyLoader);
		}
		return null;
	}

	private IHistoryBaseModel RenderChangeAccess(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		if (!(@event is ContractorChangeAccessActionEventArgs))
		{
			throw new ArgumentNullException("event");
		}
		return new ChangeAccessContractorHistoryModel(@event, SR.T("Права доступа изменены"))
		{
			Info = ((ContractorChangeAccessActionEventArgs)@event).Info
		};
	}

	private IHistoryBaseModel RenderCommentAction(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader, string eventTheme)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		CommentContractorHistoryModel commentEvent = new CommentContractorHistoryModel(@event, eventTheme);
		IContractor contractor = (IContractor)@event.New;
		if (contractor.Comments != null)
		{
			List<IComment> comments = (from IComment q in from q in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid)
					select q.New
				where ((ICollection<IComment>)contractor.Comments).Contains(q) && q.CreationAuthor.Equals(commentEvent.ActionAuthor)
				select q).ToList();
			commentEvent.Comments = comments;
		}
		return commentEvent;
	}

	private IHistoryBaseModel RenderAddComment(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader, string caption = null)
	{
		return RenderCommentAction(html, @event, historyLoader, caption);
	}

	private IHistoryBaseModel RenderCreate(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader, string caption = null)
	{
		return RenderCommentAction(html, @event, historyLoader, caption ?? SR.T("Контрагент создан"));
	}

	private IHistoryBaseModel RenderUserSlaveEdit(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader, string caption = null)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		SlaveActionContractorHistoryModel slaveActionContractorHistoryModel = new SlaveActionContractorHistoryModel(@event, SR.T("Добавление связанных объектов"));
		IContractor contractor = (IContractor)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, ContractorActions.AddSlaveGuid, contractor.Id).FirstOrDefault();
		if (entityActionEventArgs != null && entityActionEventArgs is ContractorSlaveActionEventArgs)
		{
			ContractorSlaveActionEventArgs contractorSlaveActionEventArgs = entityActionEventArgs as ContractorSlaveActionEventArgs;
			slaveActionContractorHistoryModel.NewEntity = contractor;
			slaveActionContractorHistoryModel.OldEntity = contractor;
			slaveActionContractorHistoryModel.SlaveObject = contractorSlaveActionEventArgs.SlaveObject;
			slaveActionContractorHistoryModel.ActionUid = contractorSlaveActionEventArgs.ActionUid;
		}
		return slaveActionContractorHistoryModel;
	}

	private IHistoryBaseModel RenderContContractorChangeAccess(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader, string caption = null)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		if (!(@event is CategoryContractorChangeAccessActionEventArgs))
		{
			throw new ArgumentNullException("event");
		}
		CategoryContractorChangeAccessActionEventArgs categoryContractorChangeAccessActionEventArgs = @event as CategoryContractorChangeAccessActionEventArgs;
		string text = "";
		ICategory category = CategoryManager.Instance.LoadOrNull(categoryContractorChangeAccessActionEventArgs.Info.CategoryId);
		text = ((category != null) ? category.Name : "");
		return new ChangeAccessContractorHistoryModel(categoryContractorChangeAccessActionEventArgs, SR.T("Изменение прав в категории {0}", text))
		{
			Info = categoryContractorChangeAccessActionEventArgs.Info
		};
	}

	private IHistoryBaseModel RenderUserSlaveDel(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader, string caption = null)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		SlaveActionContractorHistoryModel slaveActionContractorHistoryModel = new SlaveActionContractorHistoryModel(@event, SR.T("Удаление связанных объектов"));
		IContractor contractor = (IContractor)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, ContractorActions.DelSlaveGuid, contractor.Id).FirstOrDefault();
		if (entityActionEventArgs != null && entityActionEventArgs is ContractorSlaveActionEventArgs)
		{
			ContractorSlaveActionEventArgs contractorSlaveActionEventArgs = entityActionEventArgs as ContractorSlaveActionEventArgs;
			slaveActionContractorHistoryModel.NewEntity = contractor;
			slaveActionContractorHistoryModel.OldEntity = contractor;
			slaveActionContractorHistoryModel.SlaveObject = contractorSlaveActionEventArgs.SlaveObject;
			slaveActionContractorHistoryModel.ActionUid = contractorSlaveActionEventArgs.ActionUid;
		}
		return slaveActionContractorHistoryModel;
	}

	public IHistoryBaseModel RenderUserEdit(HtmlHelper html, [NotNull] EntityActionEventArgs @event, [NotNull] IEntityActionHistoryLoader historyLoader)
	{
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		UserEditContractorHistoryModel userEditEvent = new UserEditContractorHistoryModel(@event, SR.T("Контрагент изменен"));
		IContractor contractor = (IContractor)@event.New;
		EntityActionEventArgs entityActionEventArgs = historyLoader.LoadHistory(@event.UnitOfWorkUid, @event.Object.Uid, DefaultEntityActions.UpdateGuid, contractor.Id).FirstOrDefault();
		if (entityActionEventArgs != null)
		{
			userEditEvent.OldEntity = (IContractor)entityActionEventArgs.Old;
			userEditEvent.NewEntity = (IContractor)entityActionEventArgs.New;
			if (entityActionEventArgs is EditEntityActionEventArgs editEntityActionEventArgs)
			{
				userEditEvent.ChangedProperties = (from p in editEntityActionEventArgs.ChangedProperties.ToList()
					where !userEditEvent.BaseProperties.Contains(p.Uid)
					select p).ToList();
			}
		}
		IEnumerable<EntityActionEventArgs> paymentCardUpdateEvents = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IPaymentCard>(), DefaultEntityActions.UpdateGuid);
		userEditEvent.PaymentCardUpdateEvents = paymentCardUpdateEvents;
		List<IPaymentCard> newPaymentCards = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IPaymentCard>(), DefaultEntityActions.CreateGuid)
			select e.New).Cast<IPaymentCard>().ToList();
		userEditEvent.NewPaymentCards = newPaymentCards;
		IEnumerable<EntityActionEventArgs> bankAccountUpdateEvents = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IBankAccount>(), DefaultEntityActions.UpdateGuid);
		userEditEvent.BankAccountUpdateEvents = bankAccountUpdateEvents;
		List<IBankAccount> newBankAccounts = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IBankAccount>(), DefaultEntityActions.CreateGuid)
			select e.New).Cast<IBankAccount>().ToList();
		userEditEvent.NewBankAccounts = newBankAccounts;
		IEnumerable<EntityActionEventArgs> emailUpdateEvents = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IEmail>(), DefaultEntityActions.UpdateGuid);
		userEditEvent.EmailUpdateEvents = emailUpdateEvents;
		List<IEmail> newEmails = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IEmail>(), DefaultEntityActions.CreateGuid)
			select e.New).Cast<IEmail>().ToList();
		userEditEvent.NewEmails = newEmails;
		IEnumerable<EntityActionEventArgs> phoneUpdateEvents = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IPhone>(), DefaultEntityActions.UpdateGuid);
		userEditEvent.PhoneUpdateEvents = phoneUpdateEvents;
		List<IPhone> newPhones = (from e in historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IPhone>(), DefaultEntityActions.CreateGuid)
			select e.New).Cast<IPhone>().ToList();
		userEditEvent.NewPhones = newPhones;
		if (userEditEvent.OldEntity != null && userEditEvent.NewEntity != null)
		{
			string text = userEditEvent.OldEntity.CategoriesHash ?? "";
			string text2 = userEditEvent.NewEntity.CategoriesHash ?? "";
			if (!text.Equals(text2))
			{
				List<long> oldCategories = (from x in text.Split(',')
					where !string.IsNullOrWhiteSpace(x)
					select x).Select(long.Parse).ToList();
				List<long> newCategories = (from x in text2.Split(',')
					where !string.IsNullOrWhiteSpace(x)
					select x).Select(long.Parse).ToList();
				List<long> removedCategories = oldCategories.Where((long c) => !newCategories.Contains(c)).ToList();
				List<long> addedCategories = newCategories.Where((long c) => !oldCategories.Contains(c)).ToList();
				IEnumerable<long> source = removedCategories.Union(addedCategories);
				ICollection<ICategory> source2 = CategoryManager.Instance.FindByIdArray(source.ToArray());
				userEditEvent.NewCategory = source2.Where((ICategory c) => addedCategories.Any((long d) => d == c.Id)).ToList();
				userEditEvent.OldCategory = source2.Where((ICategory c) => removedCategories.Any((long d) => d == c.Id)).ToList();
			}
		}
		return userEditEvent;
	}

	protected override HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
	{
		if (@event == null || @event.Action == null)
		{
			return null;
		}
		if (@event.Action.Uid == ContractorActions.EditGuid)
		{
			return EditViewBlock();
		}
		if (@event.Action.Uid == ContractorActions.AddSlaveGuid)
		{
			return EditSlaveViewBlock();
		}
		if (@event.Action.Uid == ContractorActions.DelSlaveGuid)
		{
			return EditSlaveViewBlock();
		}
		if (@event.Action.Uid == ContractorActions.ChangeAccessGuid || @event.Action.Uid == ContContractorPermissionActions.ChangeAccessGuid)
		{
			return ChangeAccessSlaveViewBlock();
		}
		return null;
	}

	private static HistoryPartViewBlock EditViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/Contractor.Edit", (object)model)
		};
	}

	private static HistoryPartViewBlock EditSlaveViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/ContractorSlave.Edit", (object)model)
		};
	}

	private HistoryPartViewBlock ChangeAccessSlaveViewBlock()
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/Contractor.ChangeAccess", (object)model)
		};
	}
}
