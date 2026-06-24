using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.CRM.Web.Models;

public class ContactGrid : BaseGridViewModel<IContact, IContactFilter>
{
	public long ContractorId { get; set; }
}
