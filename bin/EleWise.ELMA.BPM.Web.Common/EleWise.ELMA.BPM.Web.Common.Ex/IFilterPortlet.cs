using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFilterPortlet
{
	bool AvailableFilterType(Guid filterTypeUid);

	object GetModel(GridCommand command, FilterModel filterModel, string gridId, HtmlHelper html);

	string ViewName();
}
