using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.CRM.Web.Models;

public class LeadSelectResponsibleModel
{
	public long[] LeadsId { get; set; }

	public IUser User { get; set; }
}
