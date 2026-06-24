using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Models;

public class UserEditContractorHistoryModel : HistoryBaseModel, IEditedHistoryModel<IContractor>, IHistoryBaseModel, IContractorHistoryBaseModel
{
	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public IContractor OldEntity { get; set; }

	public IContractor NewEntity { get; set; }

	public IEnumerable<EntityActionEventArgs> EmailUpdateEvents { get; set; }

	public IList<IEmail> NewEmails { get; set; }

	public IEnumerable<EntityActionEventArgs> PhoneUpdateEvents { get; set; }

	public IList<IPhone> NewPhones { get; set; }

	public EntityActionEventArgs LegalAddressUpdateEvent { get; set; }

	public EntityActionEventArgs PostalAddressUpdateEvent { get; set; }

	public IEnumerable<EntityActionEventArgs> BankAccountUpdateEvents { get; set; }

	public IList<IBankAccount> NewBankAccounts { get; set; }

	public IEnumerable<EntityActionEventArgs> PaymentCardUpdateEvents { get; set; }

	public IList<IPaymentCard> NewPaymentCards { get; set; }

	public IList<ICategory> NewCategory { get; set; }

	public IList<ICategory> OldCategory { get; set; }

	public List<Guid> BaseProperties => ContractorActionHelper.BaseProperties();

	public UserEditContractorHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
