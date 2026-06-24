using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.CRM.Web.Models;

public class LeadContactGrid : BaseGridViewModel<ILeadContact, ILeadContactFilter>
{
	public long LeadId { get; set; }
}
