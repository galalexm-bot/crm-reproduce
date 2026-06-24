using System.Collections.Generic;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Web.Models;

public class GroupContractorInfo
{
	public IList<IContractor> Contractors { get; set; }

	public string PopupId { get; set; }
}
