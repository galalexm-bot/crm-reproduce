using System.Collections.Generic;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class AssignRolesModel
{
	public IEnumerable<IUserGroup> Roles { get; set; }

	public string RedirectAction { get; set; }

	public string RedirectController { get; set; }

	public string RedirectArea { get; set; }

	public string Callback { get; set; }
}
