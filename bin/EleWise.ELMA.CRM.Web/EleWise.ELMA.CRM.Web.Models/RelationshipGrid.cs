using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.CRM.Web.Models;

public class RelationshipGrid : BaseGridViewModel<IRelationship, IRelationshipFilter>
{
	public long ContractorId { get; set; }

	public long ContactId { get; set; }

	public long LeadId { get; set; }

	public long SaleId { get; set; }
}
