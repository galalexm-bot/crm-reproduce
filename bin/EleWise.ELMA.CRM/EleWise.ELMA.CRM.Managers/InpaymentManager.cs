using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Security;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;

namespace EleWise.ELMA.CRM.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class InpaymentManager : BaseCrmManager<IInpayment>
{
	private static readonly string SalePropertyName = LinqUtils.NameOf((Expression<Func<IInpayment, object>>)((IInpayment m) => m.Sale));

	private static readonly string ContractorPropertyName = LinqUtils.NameOf((Expression<Func<IInpayment, object>>)((IInpayment m) => m.Contractor));

	private static readonly string ResponsiblePropertyName = LinqUtils.NameOf((Expression<Func<IInpayment, object>>)((IInpayment m) => m.Responsible));

	private static readonly string CreationAuthorPropertyName = LinqUtils.NameOf((Expression<Func<IInpayment, object>>)((IInpayment m) => m.CreationAuthor));

	public new static InpaymentManager Instance => Locator.GetServiceNotNull<InpaymentManager>();

	protected override string DefaultCriteriaAlias => "inpaymentMn";

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (!(filter is IInpaymentFilter inpaymentFilter))
		{
			return;
		}
		if (inpaymentFilter.GridDateRange.From.HasValue && inpaymentFilter.GridDateRange.To.HasValue)
		{
			if (inpaymentFilter.GridDateRange.From != DateTime.MinValue && inpaymentFilter.GridDateRange.To != DateTime.MaxValue)
			{
				criteria.Add((ICriterion)(object)Restrictions.Between((IProjection)(object)Projections.Property("Date"), (object)inpaymentFilter.GridDateRange.From, (object)inpaymentFilter.GridDateRange.To));
			}
			else if (inpaymentFilter.GridDateRange.From == DateTime.MinValue)
			{
				criteria.Add((ICriterion)(object)Restrictions.Le("Date", (object)inpaymentFilter.GridDateRange.To));
			}
			else if (inpaymentFilter.GridDateRange.To == DateTime.MaxValue)
			{
				criteria.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNull("Date"), (ICriterion)(object)Restrictions.Ge("Date", (object)inpaymentFilter.GridDateRange.From)));
			}
		}
		if (inpaymentFilter.StatusSet.HasItems())
		{
			criteria.Add((ICriterion)(object)Restrictions.In((IProjection)(object)Projections.Property("Status"), (ICollection)inpaymentFilter.StatusSet.ToList()));
		}
		if (inpaymentFilter.IsOverdue == false)
		{
			criteria.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.Eq("Status", (object)InpaymentStatus.InPlan), (ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Ge("Date", (object)DateTime.Today), (ICriterion)(object)Restrictions.IsNull("Date"))), (ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq("Status", (object)InpaymentStatus.InPlan))));
		}
		if (inpaymentFilter.InPlan == false)
		{
			criteria.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.Eq("Status", (object)InpaymentStatus.InPlan), (ICriterion)(object)Restrictions.Lt("Date", (object)DateTime.Today)), (ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq("Status", (object)InpaymentStatus.InPlan))));
		}
		if (inpaymentFilter.Received == false)
		{
			criteria.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq("Status", (object)InpaymentStatus.Received)));
		}
		if (inpaymentFilter.Cancelled == false)
		{
			criteria.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq("Status", (object)InpaymentStatus.Cancelled)));
		}
		if (inpaymentFilter.ShowOnlyMy)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("Responsible", (object)base.AuthenticationService.GetCurrentUser()));
		}
		criteria.CreateAlias(SalePropertyName, "inpsale", (JoinType)0).Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNull("inpsale.IsDeleted"), (ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq("inpsale.IsDeleted", (object)true))));
	}

	public double GetInPlanWithDateTotal(IInpaymentFilter filter)
	{
		ICriteria val = CreateCriteria(filter);
		SetupFilter(val, filter);
		val.Add((ICriterion)(object)Restrictions.Eq("Status", (object)InpaymentStatus.InPlan));
		val.Add((ICriterion)(object)Restrictions.IsNotNull("Date"));
		return val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Sum((IProjection)(object)ProjectionFor((IInpayment b) => b.Sum)) }).UniqueResult<Money>();
	}

	public double GetInPlanWithoutDateTotal(IInpaymentFilter filter)
	{
		ICriteria val = CreateCriteria(filter);
		SetupFilter(val, filter);
		val.Add((ICriterion)(object)Restrictions.Eq("Status", (object)InpaymentStatus.InPlan));
		val.Add((ICriterion)(object)Restrictions.IsNull("Date"));
		return val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Sum((IProjection)(object)ProjectionFor((IInpayment b) => b.Sum)) }).UniqueResult<Money>();
	}

	public double GetReceivedTotal(IInpaymentFilter filter)
	{
		ICriteria val = CreateCriteria(filter);
		SetupFilter(val, filter);
		val.Add((ICriterion)(object)Restrictions.Eq("Status", (object)InpaymentStatus.Received));
		return val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Sum((IProjection)(object)ProjectionFor((IInpayment b) => b.Sum)) }).UniqueResult<Money>();
	}

	public IEnumerable<InpaymentModel> GetInpayments(IInpaymentFilter inpaymentFilter, FetchOptions fetchOptions)
	{
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		ICriteria val = CreateCriteria(inpaymentFilter).CreateAlias(ContractorPropertyName, "cc", (JoinType)1).CreateAlias(ResponsiblePropertyName, "rs", (JoinType)1).CreateAlias(CreationAuthorPropertyName, "ca", (JoinType)1);
		SetupFilter(val, inpaymentFilter);
		val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property("Id"), "Id").Add((IProjection)(object)Projections.Property("Name"), "Name")
			.Add((IProjection)(object)Projections.Property("Status"), "Status")
			.Add((IProjection)(object)Projections.Property("Date"), "Date")
			.Add((IProjection)(object)Projections.Property("ActualDate"), "ActualDate")
			.Add((IProjection)(object)Projections.Property("Sum"), "Sum")
			.Add((IProjection)(object)Projections.Property("Invoice"), "Invoice")
			.Add((IProjection)(object)Projections.Property("cc.Id"), "ContractorId")
			.Add((IProjection)(object)Projections.Property($"cc.{GetTypeUidPropertyName(typeof(IContractor))}"), "ContractorTypeUid")
			.Add((IProjection)(object)Projections.Property("cc.Name"), "ContractorName")
			.Add((IProjection)(object)Projections.Property("inpsale.Id"), "SaleId")
			.Add((IProjection)(object)Projections.Property("inpsale.Name"), "SaleName")
			.Add((IProjection)(object)Projections.Property("inpsale.SaleStatus"), "SaleStatus")
			.Add((IProjection)(object)Projections.Property("rs.Id"), "ResponsibleId")
			.Add((IProjection)(object)Projections.Property("rs.Uid"), "ResponsibleUid")
			.Add((IProjection)(object)Projections.Property("rs.FirstName"), "ResponsibleFirstName")
			.Add((IProjection)(object)Projections.Property("rs.LastName"), "ResponsibleLastName")
			.Add((IProjection)(object)Projections.Property("rs.MiddleName"), "ResponsibleMiddleName")
			.Add((IProjection)(object)Projections.Property("ca.Id"), "CreationAuthorId")
			.Add((IProjection)(object)Projections.Property("ca.Uid"), "CreationAuthorUid")
			.Add((IProjection)(object)Projections.Property("ca.FirstName"), "CreationAuthorFirstName")
			.Add((IProjection)(object)Projections.Property("ca.LastName"), "CreationAuthorLastName")
			.Add((IProjection)(object)Projections.Property("ca.MiddleName"), "CreationAuthorMiddleName") });
		string text = null;
		text = ((fetchOptions.SortExpression == "ResponsibleShortName") ? "ResponsibleLastName" : ((!(fetchOptions.SortExpression == "CreationAuthorShortName")) ? fetchOptions.SortExpression : "CreationAuthorLastName"));
		if (!string.IsNullOrEmpty(text))
		{
			val.AddOrder(new Order(text, fetchOptions.SortDirection == ListSortDirection.Ascending));
		}
		return val.SetFirstResult(fetchOptions.FirstResult).SetMaxResults(fetchOptions.MaxResults).SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(InpaymentModel)))
			.List<InpaymentModel>();
	}

	public int GetInpaymentsCount(IInpaymentFilter inpaymentFilter)
	{
		ICriteria val = CreateCriteria(inpaymentFilter);
		SetupFilter(val, inpaymentFilter);
		val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Count("Id") });
		return Convert.ToInt32(val.UniqueResult<object>());
	}

	private void UpdateSalesVolume(ISale sale)
	{
		if (sale.InpaymentsPlanCompleted)
		{
			double value = (from x in EntityManager<IInpayment>.Instance.Find((IInpayment i) => i.Sale == sale)
				where x.Status != InpaymentStatus.Cancelled
				select x).Sum((IInpayment x) => x.Sum);
			sale.SalesVolume = value;
			sale.Save();
		}
	}

	[PublicApiMember]
	public override void Delete(IInpayment obj)
	{
		if (!CRMPermissionProvider.CheckAny(new Permission[2]
		{
			CRMPermissionProvider.CRMFullAccessPermission,
			CRMPermissionProvider.CRMDeleteInpaymentPermission
		}))
		{
			throw new SecurityException();
		}
		BaseDelete(obj);
	}

	[PublicApiMember]
	public void SetInpaymentStatus(IInpayment inpayment, InpaymentStatus inpaymentStatus, string changeStatusComment = null)
	{
		SetInpaymentStatus(inpayment, inpaymentStatus, null, changeStatusComment);
	}

	[PublicApiMember]
	public void SetInpaymentStatus(IInpayment inpayment, InpaymentStatus inpaymentStatus, DateTime? actualDate, string changeStatusComment = null)
	{
		if (inpayment == null)
		{
			throw new NullReferenceException(SR.T("Поступление не может быть null"));
		}
		inpayment.Status = inpaymentStatus;
		inpayment.ChangeStatusComment = changeStatusComment;
		inpayment.ActualDate = actualDate;
		inpayment.Save();
		UpdateSalesVolume(inpayment.Sale);
	}

	[PublicApiMember]
	public void SetInpaymentDate(IInpayment inpayment, DateTime date)
	{
		if (inpayment == null)
		{
			throw new NullReferenceException(SR.T("Поступление не может быть null"));
		}
		inpayment.Date = date;
		inpayment.Save();
	}

	[PublicApiMember]
	public void SetInpaymentDate(IInpayment inpayment)
	{
		if (inpayment == null)
		{
			throw new NullReferenceException(SR.T("Поступление не может быть null"));
		}
		inpayment.Date = null;
		inpayment.Save();
	}

	[PublicApiMember]
	public void SetCancelledStatus(IInpayment inpayment, string comment = null)
	{
		if (inpayment == null)
		{
			throw new NullReferenceException(SR.T("Поступление не может быть null"));
		}
		SetInpaymentStatus(inpayment, InpaymentStatus.Cancelled, comment);
	}

	[PublicApiMember]
	public void SetInPlanStatus(IInpayment inpayment, string comment = null)
	{
		SetInPlanStatus(inpayment, null, comment);
	}

	[PublicApiMember]
	public void SetInPlanStatus(IInpayment inpayment, DateTime? actualDate, string comment = null)
	{
		if (inpayment == null)
		{
			throw new NullReferenceException(SR.T("Поступление не может быть null"));
		}
		SetInpaymentStatus(inpayment, InpaymentStatus.InPlan, actualDate, comment);
	}

	[PublicApiMember]
	public void SetReceivedStatus(IInpayment inpayment, string comment = null)
	{
		if (inpayment == null)
		{
			throw new NullReferenceException(SR.T("Поступление не может быть null"));
		}
		SetInpaymentStatus(inpayment, InpaymentStatus.Received, comment);
	}

	[PublicApiMember]
	[Transaction]
	public virtual void AddComment(IInpayment inpayment, string comment)
	{
		if (inpayment == null)
		{
			throw new NullReferenceException(SR.T("Поступление не может быть null"));
		}
		IComment comment2 = InterfaceActivator.Create<IComment>();
		comment2.Text = comment;
		comment2.CreationDate = DateTime.Now;
		comment2.CreationAuthor = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		comment2.Save();
		ICommentActionModel commentActionModel = InterfaceActivator.Create<ICommentActionModel>();
		commentActionModel.Comment = comment2;
		ICommentActionHandler serviceNotNull = Locator.GetServiceNotNull<ICommentActionHandler>();
		serviceNotNull.Process(inpayment, commentActionModel);
		inpayment.Comments.Add(comment2);
		inpayment.Save();
		IEntityActionHandler serviceNotNull2 = Locator.GetServiceNotNull<IEntityActionHandler>();
		EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, inpayment, InpaymentActions.AddCommentGuid);
		if (entityActionEventArgs != null)
		{
			serviceNotNull.ProcessEventArgs(entityActionEventArgs, commentActionModel);
			serviceNotNull2.ActionExecuted(entityActionEventArgs);
		}
	}

	[PublicApiMember]
	public virtual void AddComment(IInpayment inpayment, string comment, EleWise.ELMA.Security.Models.IUser commentAuthor)
	{
		if (commentAuthor == null)
		{
			throw new NullReferenceException(SR.T("Автор комментария не может быть null"));
		}
		if (commentAuthor != base.AuthenticationService.GetCurrentUser())
		{
			base.SecurityService.RunByUser(commentAuthor, delegate
			{
				AddComment(inpayment, comment);
			});
		}
		else
		{
			AddComment(inpayment, comment);
		}
	}
}
