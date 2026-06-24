using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Content.Models;

[FilterFor(typeof(IRoleMapPage))]
public interface IRoleMapPageFilter : IPortalObjectFilter, IEntityFilter
{
	IPortletPage DefaultMapPage { get; set; }
}
