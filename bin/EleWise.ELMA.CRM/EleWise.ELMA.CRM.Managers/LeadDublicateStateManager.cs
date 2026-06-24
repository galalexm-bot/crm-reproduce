using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using NHibernate.Criterion;

namespace EleWise.ELMA.CRM.Managers;

public class LeadDublicateStateManager : EntityManager<ILeadDublicateState, long>
{
	public new static LeadDublicateStateManager Instance => Locator.GetServiceNotNull<LeadDublicateStateManager>();

	public void SetDublicateState(long leadId, LeadDublicateStatus newStatus = LeadDublicateStatus.New)
	{
		base.SecurityService.RunWithElevatedPrivilegies(delegate
		{
			ILead lead = LeadManager.Instance.LoadOrNull(leadId);
			if (lead != null)
			{
				SetDublicateState(lead, newStatus);
			}
		});
	}

	[Transaction]
	public virtual void SetDublicateState(ILead lead, LeadDublicateStatus newStatus = LeadDublicateStatus.New)
	{
		ILeadDublicateState leadDublicateState = GetLeadDublicateState(lead);
		if (leadDublicateState == null)
		{
			leadDublicateState = InterfaceActivator.Create<ILeadDublicateState>();
			leadDublicateState.Lead = lead;
			leadDublicateState.Status = newStatus;
			leadDublicateState.Save();
		}
		else if (leadDublicateState.Status != newStatus)
		{
			leadDublicateState.Status = newStatus;
			leadDublicateState.Save();
		}
	}

	public ILeadDublicateState GetLeadDublicateState(ILead lead)
	{
		ILeadDublicateStateFilter leadDublicateStateFilter = InterfaceActivator.Create<ILeadDublicateStateFilter>();
		leadDublicateStateFilter.Lead = lead;
		return Find(leadDublicateStateFilter, new FetchOptions(0, 1)).FirstOrDefault();
	}

	internal IEnumerable<long> GetLeads4CheckDublicate()
	{
		return CreateCriteria().CreateAlias("Lead", "ld").Add((ICriterion)(object)Restrictions.Eq("Status", (object)LeadDublicateStatus.New)).Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNull("ld.IsDeleted"), (ICriterion)(object)Restrictions.Eq("ld.IsDeleted", (object)false)))
			.AddProjection((IProjection)(object)Projections.Property("ld.Id"))
			.List<long>();
	}
}
