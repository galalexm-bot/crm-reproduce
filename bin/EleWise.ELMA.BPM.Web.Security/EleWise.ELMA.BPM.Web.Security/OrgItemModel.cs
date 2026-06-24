using System.Collections.Generic;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class OrgItemModel
{
	public IOrganizationItem OrgItem { get; set; }

	public IEnumerable<string> ParentsTree { get; set; }

	public bool HasUserViewPermission { get; set; }
}
