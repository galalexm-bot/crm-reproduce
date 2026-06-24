using System.Collections.Generic;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public sealed class WorkplaceColorSchemesModel : EntityModel<IWorkplaceColorScheme>
{
	public string ReturnUrl { get; set; }

	public ICollection<IWorkPlace> Workplaces { get; set; }

	public bool ReadOnly { get; set; }
}
