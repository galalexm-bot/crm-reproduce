using System;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Models.BillingInformation;

namespace EleWise.ELMA.CRM.Web.Models;

public class PaymentCardPostEdit
{
	public string RowId { get; set; }

	public string Name { get; set; }

	public IPaymentSystem PaymentSystem { get; set; }

	public string Number { get; set; }

	public DateTime ValidTo { get; set; }

	public AccountStatus Status { get; set; }

	public string Comment { get; set; }
}
