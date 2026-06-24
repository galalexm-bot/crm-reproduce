using System;
using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFilterPropertyStyler
{
	Dictionary<Guid, string> Styles { get; }

	bool CheckType(FilterModel model);
}
