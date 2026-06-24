using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Security.Models;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Content.Models;

[FilterFor(typeof(IRoleMapPageItem))]
public interface IRoleMapPageItemFilter : IEntityFilter
{
	IPortletPage Page { get; set; }

	Int64Range Order { get; set; }

	ISet<IOrganizationItem> OrganizationItems { get; set; }

	ISet<IUser> Users { get; set; }

	IRoleMapPage Parent { get; set; }
}
