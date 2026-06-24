namespace EleWise.ELMA.Web.Mvc.Models.Grids;

public class GridPageItem
{
	private string text;

	public int PageIndex { get; set; }

	public string Text
	{
		get
		{
			return text ?? PageIndex.ToString();
		}
		set
		{
			text = value;
		}
	}

	public bool Selected { get; set; }

	public GridPageItem(int pageIndex)
	{
		PageIndex = pageIndex;
	}

	public GridPageItem(int pageIndex, string text)
		: this(pageIndex)
	{
		Text = text;
	}

	public GridPageItem(int pageIndex, bool selected)
		: this(pageIndex)
	{
		Text = text;
		Selected = selected;
	}
}
