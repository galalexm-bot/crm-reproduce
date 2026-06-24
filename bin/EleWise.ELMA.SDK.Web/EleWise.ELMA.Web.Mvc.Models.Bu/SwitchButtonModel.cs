using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EleWise.ELMA.Web.Mvc.Models.Buttons;

public class SwitchButtonModel
{
	public string LabelFirst { get; set; }

	public string LableSecond { get; set; }

	public string IconFirst { get; set; }

	public string IconSecond { get; set; }

	public Expression Expression { get; set; }

	public int? Value { get; set; }

	public string Prefix { get; set; }

	public string Target { get; set; }

	public List<Enum> EnumValues { get; set; }

	public SwitchButtonModel()
	{
		LabelFirst = SR.T("Да");
		LableSecond = SR.T("Нет");
		IconFirst = "#complete.svg";
		IconSecond = "#close_outline.svg";
	}
}
