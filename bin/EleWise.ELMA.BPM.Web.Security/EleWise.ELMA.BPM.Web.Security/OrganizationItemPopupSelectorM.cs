using EleWise.ELMA.Web.Mvc.Models.Selectors;
using EleWise.ELMA.Web.Mvc.Models.Trees;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class OrganizationItemPopupSelectorModel : EntityPopupSelectorModel
{
	public TreeModel OrganizationTree { get; set; }
}
