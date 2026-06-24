using System.Collections.Generic;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Models.Selectors;

public class EntityPopupSelectorModel
{
	public string InputId { get; set; }

	public IList<SelectListItem> AvalibleItems { get; set; }

	public IList<SelectListItem> SelectedItems { get; set; }

	public bool MultiSelect { get; set; }
}
