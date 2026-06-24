using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;

namespace EleWise.ELMA.Tasks.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class WorkLogActivityManager : EntityManager<IWorkLogActivity, long>
{
	public new static WorkLogActivityManager Instance => Locator.GetServiceNotNull<WorkLogActivityManager>();

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (!(filter is IWorkLogActivityFilter workLogActivityFilter))
		{
			return;
		}
		if (workLogActivityFilter.HideIds != null && workLogActivityFilter.HideIds.Any())
		{
			criteria.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.In("Id", (ICollection)workLogActivityFilter.HideIds.ToArray())));
		}
		if (workLogActivityFilter.EntityTypeUid.HasValue)
		{
			string alias = "t";
			if (workLogActivityFilter.AllOrEntityTypeUid.HasValue && workLogActivityFilter.AllOrEntityTypeUid.Value)
			{
				criteria.GetOrCreateAlias("ObjectsUIDs", "ObjectsUIDs", (JoinType)1, ref alias);
				criteria.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Eq($"{alias}.ObjectUID", (object)new ReferenceOnEntityType
				{
					TypeUid = workLogActivityFilter.EntityTypeUid.Value
				}), (ICriterion)(object)Restrictions.Eq("AllObjectTypes", (object)true)));
			}
			else
			{
				criteria.GetOrCreateAlias("ObjectsUIDs", "ObjectsUIDs", (JoinType)0, ref alias);
				criteria.Add((ICriterion)(object)Restrictions.Eq($"{alias}.ObjectUID", (object)new ReferenceOnEntityType
				{
					TypeUid = workLogActivityFilter.EntityTypeUid.Value
				}));
			}
		}
	}

	[Transaction]
	public override void Delete(IWorkLogActivity obj)
	{
		foreach (IWorkLogActivityObjectType item in (IEnumerable<IWorkLogActivityObjectType>)obj.ObjectsUIDs)
		{
			item.HardDelete = obj.HardDelete;
			item.Delete();
		}
		base.Delete(obj);
	}
}
