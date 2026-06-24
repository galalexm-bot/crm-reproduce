using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IGridObjectSelectorExtensionExtended : IGridObjectSelectorExtension
{
	void EditGrid(DynamicGrid grid, Guid typeUid, HtmlHelper html);
}
