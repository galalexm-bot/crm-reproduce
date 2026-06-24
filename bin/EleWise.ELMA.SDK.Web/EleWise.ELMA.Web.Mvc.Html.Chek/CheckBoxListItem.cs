namespace EleWise.ELMA.Web.Mvc.Html.ChekBoxes;

public class CheckBoxListItem : ListItem
{
	public bool IsChecked { get; private set; }

	public CheckBoxListItem(string value, string displayText, bool isChecked)
	{
		base.Value = value;
		base.DisplayText = displayText;
		IsChecked = isChecked;
	}
}
