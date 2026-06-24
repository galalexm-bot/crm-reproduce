using System;

namespace EleWise.ELMA.Web.Mvc.Models.Trees;

public class ExtTreeModel : TreeModel
{
	public string Name { get; set; }

	public Guid Uid { get; set; }

	public string EntityUrl { get; set; }
}
