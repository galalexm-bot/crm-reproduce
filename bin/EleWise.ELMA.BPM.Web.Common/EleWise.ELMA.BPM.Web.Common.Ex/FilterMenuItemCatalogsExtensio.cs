using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

[Component]
public class FilterMenuItemCatalogsExtension : IFilterMenuItemExtension
{
	public IEnumerable<FilterMenuItem> FilterMenuItems()
	{
		return (from m in CatalogsController.EntityList.OfType<EntityMetadata>()
			select new FilterMenuItem
			{
				TypeUid = m.ImplementationUid,
				Code = "EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root",
				FilterIdParameter = "FilterId",
				FilterEditAction = "EditFilters",
				Routes = new ActionRoute("View", "Catalogs", new
				{
					area = "EleWise.ELMA.BPM.Web.Common",
					uid = m.ImplementationUid
				})
			}).ToList();
	}
}
