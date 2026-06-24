using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.Web.Mvc.Models.Selectors;

public class TabPanelItem : TabStripItem
{
	private int? tabindex;

	public int? TabIndex
	{
		get
		{
			return tabindex;
		}
		set
		{
			tabindex = value;
		}
	}
}
