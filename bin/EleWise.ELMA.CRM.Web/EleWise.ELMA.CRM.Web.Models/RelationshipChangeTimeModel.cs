using System;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.CRM.Web.Models;

public class RelationshipChangeTimeModel : FormViewModel
{
	public long EntityId { get; set; }

	public Guid EntityTypeUid { get; set; }

	public string Comment { get; set; }

	public DateTime StartDate { get; set; }

	public DateTime? EndDate { get; set; }

	public string PopupId { get; set; }
}
