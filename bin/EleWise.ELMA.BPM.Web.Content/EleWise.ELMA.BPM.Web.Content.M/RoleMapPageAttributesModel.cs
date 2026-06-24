using EleWise.ELMA.Content.Models;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public class RoleMapPageAttributesModel
{
	public bool Shared { get; set; }

	public IRoleMapPage Page { get; set; }
}
