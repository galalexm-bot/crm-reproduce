using System.Collections.Generic;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Web.Models;

public class GroupLeadInfo
{
	public IList<ILead> Leads { get; set; }

	public string PopupId { get; set; }
}
