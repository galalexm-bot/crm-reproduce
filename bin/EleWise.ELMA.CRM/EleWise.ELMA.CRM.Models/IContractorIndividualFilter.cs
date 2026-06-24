using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(IContractorIndividual))]
public interface IContractorIndividualFilter : IContractorFilter, IMarketingActivityTargetFilter, IEntityFilter
{
	string FirstName { get; set; }

	string SecondName { get; set; }

	string MiddleName { get; set; }

	IClientDocumentType DocumentType { get; set; }

	string DocumentSeries { get; set; }

	string DocumentNumber { get; set; }

	string DocumentIssued { get; set; }

	DateTimeRange DocumentIssueDate { get; set; }

	DateTimeRange DocumentEndDate { get; set; }

	ISet<IPaymentCard> PaymentCards { get; set; }
}
