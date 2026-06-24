using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using NHibernate.Criterion;
using NHibernate.SqlCommand;

namespace EleWise.ELMA.Documents.Managers;

public class LifeCycleTransitionManager : EntityManager<ILifeCycleTransition, long>
{
	public new static LifeCycleTransitionManager Instance => Locator.GetServiceNotNull<LifeCycleTransitionManager>();

	public IList<ILifeCycleTransition> GetTransitions(ILifeCycleStatus status)
	{
		return CreateCriteria().CreateAlias("Start", "st", (JoinType)1).CreateAlias("Finish", "fn", (JoinType)1).Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Eq("st.Id", (object)status.Id), (ICriterion)(object)Restrictions.Eq("fn.Id", (object)status.Id)))
			.SetCacheable(true)
			.List<ILifeCycleTransition>()
			.ToList();
	}

	public override ExportRuleList ExportRules()
	{
		Type parentType = InterfaceActivator.TypeOf<ILifeCycleTransition>();
		return new ExportRuleList
		{
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "Description",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "Finish",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "LifeCycle",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "Name",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "Start",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "Uid",
				ExportRuleType = ExportRuleType.Export
			}
		};
	}
}
