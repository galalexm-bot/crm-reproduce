using EleWise.ELMA.Web.Mvc.Models.Boxes;
using EleWise.ELMA.Web.Mvc.Models.Trees;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class CatalogListModel
{
	public TreeModel Tree { get; set; }

	public AutocompleteComboBox ComboBox { get; set; }
}
