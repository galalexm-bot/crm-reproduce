using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using NHibernate.Criterion;

namespace EleWise.ELMA.CRM.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class PaymentManager : EntityManager<IPayment, long>
{
	public new static PaymentManager Instance => Locator.GetServiceNotNull<PaymentManager>();

	public List<IPayment> GetExpiredPayments()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Lt("PaymentDate", (object)DateTime.Today)).Add((ICriterion)(object)Restrictions.In("PaymentStatus", (ICollection)new PaymentStatus[2]
		{
			PaymentStatus.Planned,
			PaymentStatus.Billed
		})).Add((ICriterion)(object)Restrictions.Eq("CreationAuthor", (object)base.AuthenticationService.GetCurrentUser()))
			.AddOrder(new Order("PaymentDate", true))
			.List<IPayment>()
			.ToList();
	}

	public List<IPayment> GetActualPayments(DateTime startDate, DateTime endDate)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Ge("PaymentDate", (object)startDate)).Add((ICriterion)(object)Restrictions.Le("PaymentDate", (object)endDate)).Add((ICriterion)(object)Restrictions.In("PaymentStatus", (ICollection)new PaymentStatus[2]
		{
			PaymentStatus.Planned,
			PaymentStatus.Billed
		}))
			.Add((ICriterion)(object)Restrictions.Eq("CreationAuthor", (object)base.AuthenticationService.GetCurrentUser()))
			.AddOrder(new Order("PaymentDate", true))
			.List<IPayment>()
			.ToList();
	}

	public void ChangeDate(IPayment payment, DateTime newDate)
	{
		if (payment != null)
		{
			payment.PaymentDate = newDate;
			Save(payment);
		}
	}

	public void ChangeStatus(IPayment payment, PaymentStatus status)
	{
		if (payment != null)
		{
			payment.PaymentStatus = status;
			Save(payment);
		}
	}

	public void ChangeSum(IPayment payment, long sum)
	{
		if (payment != null)
		{
			payment.Sum = sum;
			Save(payment);
		}
	}
}
