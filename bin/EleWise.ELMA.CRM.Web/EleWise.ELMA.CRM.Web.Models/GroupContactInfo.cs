using System.Collections.Generic;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Web.Models;

public class GroupContactInfo
{
	public IList<IContact> Contacts { get; set; }

	public string PopupId { get; set; }
}
