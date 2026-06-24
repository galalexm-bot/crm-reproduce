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
public class ContractorWorkLogObjectSearchExtension : CRMWorkLogObjectSearchExtensionBase
{
	public override Guid Uid => new Guid("{245C5146-F625-4527-A06C-49FF9360FD60}");

	public override Type BaseObjectType => typeof(IContractor);

	protected override void Init()
	{
		AddProperty((IContractorWorkLogObjectSearchFilter p) => p.Contractor);
		AddProperty((IContractorWorkLogObjectSearchFilter p) => p.CreationAuthor);
		AddProperty((IContractorWorkLogObjectSearchFilter p) => p.CreationDate);
	}

	public override void SetupCriteria(ICriteria criteria, IWorkLogObjectSearchFilter filter)
	{
		base.SetupCriteria(criteria, filter);
		if (filter is IContractorWorkLogObjectSearchFilter contractorWorkLogObjectSearchFilter && contractorWorkLogObjectSearchFilter.Contractor != null)
		{
			criteria.Add((ICriterion)(object)Restrictions.In("Id", (ICollection)contractorWorkLogObjectSearchFilter.Contractor.Select((IContractor e) => e.Id).ToArray()));
		}
	}

	public override void SetupFilter(IEntityFilter entityFilter, IWorkLogObjectSearchFilter filter)
	{
		base.SetupFilter(entityFilter, filter);
		if (entityFilter is IContractorFilter contractorFilter)
		{
			contractorFilter.CreationDate = RelativeDateTimeDescriptor.GetDateTimeRange(filter.CreationDate);
			if (filter.CreationAuthor != null)
			{
				contractorFilter.CreationAuthor = filter.CreationAuthor;
			}
		}
	}
}
