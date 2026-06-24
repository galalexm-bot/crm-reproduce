using System.Collections.Generic;

namespace EleWise.ELMA.Web.Mvc.Html.ChekBoxes;

public class CheckBoxesModel : ListModelBase<CheckBoxListItem>
{
	public bool IsEntity { get; set; }

	public int Columns { get; set; }

	public string ItemUrlTemplate { get; set; }

	public IDictionary<string, object> HtmlAttributes { get; set; }
}
