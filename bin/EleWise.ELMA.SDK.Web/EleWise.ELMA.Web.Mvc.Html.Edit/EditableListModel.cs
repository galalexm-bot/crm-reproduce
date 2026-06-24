using System;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Html.EditableList;

public class EditableListModel : ListModelBase<EditableListItem>
{
	public bool Edit { get; set; }

	public Func<MvcHtmlString, object> ListTemplate { get; set; }

	public Func<Tuple<MvcHtmlString, ListItem, MvcHtmlString>, object> ItemTemplate { get; set; }

	public string AddTemplate { get; set; }

	public string GroupByProperty { get; set; }

	public bool SeparateDeleteButton { get; set; }
}
