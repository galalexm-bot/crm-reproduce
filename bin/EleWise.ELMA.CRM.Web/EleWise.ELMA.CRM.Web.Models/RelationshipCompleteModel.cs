using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.CRM.Web.Models;

public class RelationshipCompleteModel : FormViewModel
{
	public IRelationship Entity { get; set; }

	public long EntityId { get; set; }

	public string Comment { get; set; }

	public long Mode { get; set; }
}
