using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;

namespace EleWise.ELMA.CRM.Managers;

public class RelationshipBaseManager<T, IdT> : EntityManager<T, IdT> where T : IEntity<IdT>, IRelationship
{
	[PublicApiMember]
	public override void Save(T obj)
	{
		if (obj.IsNew() && obj.Lead != null && obj.Lead.Status == LeadStatus.New)
		{
			CrmSettingsModule serviceNotNull = Locator.GetServiceNotNull<CrmSettingsModule>();
			obj.Lead.Status = serviceNotNull.Settings.DefaultLeadStatus;
			obj.Lead.InHandDate = DateTime.Now;
			obj.Lead.Save();
		}
		base.Save(obj);
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		IRelationshipFilter relationshipFilter = filter as IRelationshipFilter;
		IContact contact = null;
		IContractor contractor = null;
		if (relationshipFilter != null)
		{
			if (relationshipFilter.Contact != null)
			{
				contact = relationshipFilter.Contact;
				relationshipFilter.Contact = null;
			}
			if (relationshipFilter.Contractor != null)
			{
				contractor = relationshipFilter.Contractor;
				relationshipFilter.Contractor = null;
			}
		}
		base.SetupFilter(criteria, filter);
		if (contractor != null)
		{
			relationshipFilter.Contractor = contractor;
		}
		if (contact != null)
		{
			relationshipFilter.Contact = contact;
		}
		if (relationshipFilter == null)
		{
			return;
		}
		if (relationshipFilter.Schedules != null && ((IEnumerable<ISchedule>)relationshipFilter.Schedules).Any())
		{
			List<ISchedule> source = ((IEnumerable<ISchedule>)relationshipFilter.Schedules).Where((ISchedule s) => s.Owner == null).ToList();
			List<IUser> source2 = (from s in (IEnumerable<ISchedule>)relationshipFilter.Schedules
				where s.Owner != null
				select s.Owner).ToList();
			AbstractCriterion val = null;
			AbstractCriterion val2 = null;
			if (source.Any())
			{
				DetachedCriteria val3 = DetachedCriteria.For(InterfaceActivator.TypeOf<IRelationship>()).CreateAlias("Schedules", "sch", (JoinType)0).Add((ICriterion)(object)Restrictions.In("sch.Id", (ICollection)source.Select((ISchedule e) => e.Id).ToArray()))
					.SetProjection((IProjection)(object)Projections.ProjectionList().Add((IProjection)(object)Projections.Property("Id")));
				val = Subqueries.PropertyIn("Id", val3);
			}
			if (source2.Any())
			{
				DetachedCriteria val4 = DetachedCriteria.For(InterfaceActivator.TypeOf<IRelationshipUser>()).CreateAlias("User", "Useralias", (JoinType)0).Add((ICriterion)(object)Restrictions.In("Useralias.Id", (ICollection)source2.Select((IUser u) => u.Id).ToArray()))
					.SetProjection((IProjection)(object)Projections.Property("Relationship"));
				val2 = Subqueries.PropertyIn("Id", val4);
			}
			if (val != null && val2 != null)
			{
				criteria.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)val, (ICriterion)(object)val2));
			}
			else if (val != null)
			{
				criteria.Add((ICriterion)(object)val);
			}
			else if (val2 != null)
			{
				criteria.Add((ICriterion)(object)val2);
			}
		}
		if (relationshipFilter.Period.From.HasValue)
		{
			SimpleExpression val5 = Restrictions.Ge("EndDate", (object)relationshipFilter.Period.From);
			criteria.Add((ICriterion)(relationshipFilter.LoadExpired ? ((object)Restrictions.Or((ICriterion)(object)val5, (ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNull("Completed"), (ICriterion)(object)Restrictions.Eq("Completed", (object)false)), (ICriterion)(object)Restrictions.Lt("EndDate", (object)DateTime.Today)))) : ((object)val5)));
		}
		if (relationshipFilter.Period.To.HasValue)
		{
			criteria.Add((ICriterion)(object)Restrictions.Le("StartDate", (object)relationshipFilter.Period.To));
		}
		if (((ICollection<IUser>)relationshipFilter.RelationshipUsers).Count > 0)
		{
			DetachedCriteria val6 = DetachedCriteria.For(InterfaceActivator.TypeOf<IRelationshipUser>()).CreateAlias("User", "Useralias", (JoinType)0).Add((ICriterion)(object)Restrictions.In("Useralias.Id", (ICollection)((IEnumerable<IUser>)relationshipFilter.RelationshipUsers).Select((IUser u) => u.Id).ToArray()))
				.SetProjection((IProjection)(object)Projections.Property("Relationship"));
			criteria.Add((ICriterion)(object)Subqueries.PropertyIn("Id", val6));
		}
		if (contact != null)
		{
			AddContactsRelationshipsCriteria(criteria, contact.Id);
		}
		if (contractor != null)
		{
			AddContractorWithIncludedContactsRelationshipCriteria(criteria, contractor.Id);
		}
	}

	public void AddContactsRelationshipsCriteria(ICriteria criteria, long contactId)
	{
		DetachedCriteria val = DetachedCriteria.For(InterfaceActivator.TypeOf<IRelationship>()).CreateAlias("ContractorsContacts", "ccAlias").Add((ICriterion)(object)Restrictions.Eq("ccAlias.Id", (object)contactId))
			.SetProjection((IProjection)(object)Projections.Property("Id"));
		criteria.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Eq("Contact.Id", (object)contactId), (ICriterion)(object)Subqueries.PropertyIn("Id", val)));
	}

	private void AddContractorWithIncludedContactsRelationshipCriteria(ICriteria criteria, long contractorId)
	{
		DetachedCriteria val = DetachedCriteria.For(InterfaceActivator.TypeOf<IContractor>()).CreateAlias("Contacts", "cs").Add((ICriterion)(object)Restrictions.Eq((IProjection)(object)Projections.Property<IContractor>((Expression<Func<IContractor, object>>)((IContractor m) => m.Id)), (object)contractorId))
			.SetProjection((IProjection)(object)Projections.Property("cs.Id"));
		criteria.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Eq("Contractor.Id", (object)contractorId), (ICriterion)(object)Subqueries.PropertyIn("Contact.Id", val)));
	}
}
