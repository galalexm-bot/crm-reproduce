using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFilterPropertyTypeResolver
{
	bool CheckType(IFilter filter);

	Dictionary<Guid, Type> GetFilterPropertyTypes(IFilter filter);
}
