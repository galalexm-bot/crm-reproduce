using System.Collections.Generic;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Web.Mvc.Models.Trees;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public class MenuLinksModel
{
	public IMenu Menu { get; set; }

	public TreeModel LinksTreeModel { get; set; }

	public List<IMenu> CopyToMenu { get; set; }

	public bool ReadOnly { get; set; }

	public bool CustomToolbar { get; set; }

	public IWorkPlace[] WorkPlaces { get; set; }
}
