using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using NHibernate;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IWorkLogObjectSearchExtension
{
	Guid Uid { get; }

	List<Guid> ObjectTypeUids { get; }

	Type BaseObjectType { get; }

	List<string> Properties { get; }

	bool GroupBySearch { get; }

	void SetupFilter(IEntityFilter entityFilter, IWorkLogObjectSearchFilter filter);

	void SetupCriteria(ICriteria criteria, IWorkLogObjectSearchFilter filter);
}
