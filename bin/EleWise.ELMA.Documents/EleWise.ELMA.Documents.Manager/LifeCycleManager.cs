using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using NHibernate.Criterion;

namespace EleWise.ELMA.Documents.Managers;

public class LifeCycleManager : EntityManager<ILifeCycle, long>
{
	public new static LifeCycleManager Instance => Locator.GetServiceNotNull<LifeCycleManager>();

	public virtual ILifeCycle LoadOrNull(Type documentType)
	{
		IMetadata metadata = MetadataLoader.LoadMetadata(((EntityMetadata)MetadataLoader.LoadMetadata(documentType)).ImplementationUid, inherit: true, loadImplementation: false);
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("DocumentType", (object)metadata.Uid)).SetCacheable(true).List<ILifeCycle>()
			.LastOrDefault();
	}

	[ContextCache]
	public new virtual ILifeCycle LoadOrNull(Guid typeUid)
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("DocumentType", (object)typeUid)).SetCacheable(true).List<ILifeCycle>()
			.LastOrDefault();
	}

	public List<ILifeCycleStatus> GetAvaliableStatuses(ILifeCycle cycle)
	{
		ClassMetadata metadata = (ClassMetadata)MetadataLoader.LoadMetadata(cycle.DocumentType, inherit: true, loadImplementation: false);
		List<ILifeCycleStatus> statuses = ((IEnumerable<ILifeCycleStatus>)cycle.Statuses).ToList();
		MetadataLoader.GetBaseClasses(metadata, loadImplementation: false).ForEach(delegate(ClassMetadata bc)
		{
			ILifeCycle lifeCycle = Instance.LoadOrNull(bc.Uid);
			if (lifeCycle != null)
			{
				statuses.AddRange(((IEnumerable<ILifeCycleStatus>)lifeCycle.Statuses).Where((ILifeCycleStatus s) => !statuses.Any((ILifeCycleStatus st) => st.Uid == s.Uid)));
			}
		});
		return statuses;
	}

	public IList<ILifeCycle> GetCyclies(ILifeCycleStatus status)
	{
		return CreateCriteria().CreateAlias("Statuses", "st").Add((ICriterion)(object)Restrictions.Eq("st.Id", (object)status.Id)).SetCacheable(true)
			.List<ILifeCycle>()
			.ToList();
	}

	public override ExportRuleList ExportRules()
	{
		Type parentType = InterfaceActivator.TypeOf<ILifeCycle>();
		return new ExportRuleList
		{
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "DocumentType",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "IsCustomChangeStatus",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "Statuses",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "Transitions",
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
