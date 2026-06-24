using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IFilterTypeFilter
{
	Guid EntityTypeUid { get; }

	Func<ClassMetadata, bool> GetFilter();
}
