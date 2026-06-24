using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using NHibernate;

namespace EleWise.ELMA.Workflow.Extensions;

[Obsolete("Устарел.")]
[ExtensionPoint(ComponentType.All)]
public interface IFilterWorkflowInstanceCriteriaBuilder
{
	IEnumerable<Guid> EntityTypeUids { get; }

	Type EntityType { get; }

	void GetInstancesByEntityAddCriteria(ICriteria criteria, List<Guid> baseClassesUids);
}
