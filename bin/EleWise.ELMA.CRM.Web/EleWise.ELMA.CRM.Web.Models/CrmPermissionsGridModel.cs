using System.Collections.Generic;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Web.Models;

public class CrmPermissionsGridModel
{
	public IEnumerable<ILeadPermission> Items { get; set; }
}
