using System;
using EleWise.ELMA.Web.Mvc.Html.EditableList;

namespace EleWise.ELMA.Web.Mvc.Models;

public class ModernSelectorModel
{
	public string SelectButtonText { get; set; }

	public string SelectButtonImageUrl { get; set; }

	public EditableListModel EditableList { get; set; }

	public Func<dynamic, object> SelectButtonAdditionalContent { get; set; }

	public string SelectButtonScript { get; set; }

	public bool HideDelete { get; set; }

	public ModernSelectorModel()
	{
		SelectButtonText = SR.T("Выбрать");
		SelectButtonImageUrl = "#search.svg";
	}
}
