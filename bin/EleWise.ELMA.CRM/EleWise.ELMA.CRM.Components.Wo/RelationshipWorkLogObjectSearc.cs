using System;
using System.Collections;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Tasks.ExtensionPoints;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.CRM.Components.WorkLog;

[Component]
public class RelationshipWorkLogObjectSearchExtension : CRMWorkLogObjectSearchExtensionBase
{
	public override Guid Uid => new Guid("{AA85C95E-214D-4721-925E-8C67F26F41AF}");

	public override Type BaseObjectType => typeof(IRelationship);

	protected override void Init()
	{
		AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.Name);
		AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.CreationDate);
		AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.CreationAuthor);
		AddProperty((IContractorWorkLogObjectSearchFilter m) => m.Contractor);
	}

	public override void SetupFilter(IEntityFilter entityFilter, IWorkLogObjectSearchFilter filter)
	{
		base.SetupFilter(entityFilter, filter);
		if (entityFilter is IRelationshipFilter relationshipFilter)
		{
			relationshipFilter.Theme = filter.Name;
			relationshipFilter.CreationDate = RelativeDateTimeDescriptor.GetDateTimeRange(filter.CreationDate);
			relationshipFilter.CreationAuthor = filter.CreationAuthor;
		}
	}

	public override void SetupCriteria(ICriteria criteria, IWorkLogObjectSearchFilter filter)
	{
		base.SetupCriteria(criteria, filter);
		if (filter is IContractorWorkLogObjectSearchFilter contractorWorkLogObjectSearchFilter && contractorWorkLogObjectSearchFilter.Contractor != null && contractorWorkLogObjectSearchFilter.Contractor.Count > 0)
		{
			criteria.Add((ICriterion)(object)Restrictions.In("Contractor", (ICollection)contractorWorkLogObjectSearchFilter.Contractor.Select((IContractor e) => e.Id).ToArray()));
		}
	}
}
