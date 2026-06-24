using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace EleWise.ELMA.Web.Mvc.Html.Forms;

public class TwoColumnsFormLayout : DefaultFormLayout
{
	public enum SplitMode
	{
		OneByOne = 1,
		OrderOddOrEven
	}

	private SplitMode _splitMode = SplitMode.OneByOne;

	private WebViewAttributes _leftTableAttributes = new WebViewAttributes();

	private WebViewAttributes _rightTableAttributes = new WebViewAttributes();

	public SplitMode Mode
	{
		get
		{
			return _splitMode;
		}
		set
		{
			_splitMode = value;
		}
	}

	public WebViewAttributes LeftTableAttributes
	{
		get
		{
			return _leftTableAttributes;
		}
		set
		{
			_leftTableAttributes = value;
		}
	}

	public WebViewAttributes RightTableAttributes
	{
		get
		{
			return _rightTableAttributes;
		}
		set
		{
			_rightTableAttributes = value;
		}
	}

	public override MvcHtmlString RenderForm(HtmlHelper html, FormBuilderModel formModel)
	{
		return PartialExtensions.Partial(html, "Templates/TwoColumnsFormLayout", (object)formModel);
	}
}
