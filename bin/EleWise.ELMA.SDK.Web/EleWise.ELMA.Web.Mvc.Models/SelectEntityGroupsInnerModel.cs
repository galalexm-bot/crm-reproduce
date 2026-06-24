using System.Collections.Generic;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Web.Mvc.Models;

internal sealed class SelectEntityGroupsInnerModel
{
	public bool ShowHeader { get; set; }

	public EntitySelectGroup Group { get; set; }

	public IEnumerable<IEntity> Entities { get; set; }
}
