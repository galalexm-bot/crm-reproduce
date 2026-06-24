using EleWise.ELMA.Web.Mvc.Models.Boxes;

namespace EleWise.ELMA.Web.Mvc.Models;

public sealed class SelectEntitiesAndGroupsModel : AutocompleteItem
{
	public string Parent { get; set; }

	public int Level { get; set; }

	public bool IsGroup { get; set; }
}
