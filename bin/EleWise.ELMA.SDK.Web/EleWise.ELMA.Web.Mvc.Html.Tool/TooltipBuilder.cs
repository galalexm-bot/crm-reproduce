using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Html.Tooltips;

public class TooltipBuilder
{
	private string _selector;

	private string _header;

	private string _text;

	public TooltipBuilder(string selector)
	{
		_selector = selector;
	}

	public TooltipBuilder Header(string text)
	{
		_header = text;
		return this;
	}

	public TooltipBuilder Text(string text)
	{
		_text = text;
		return this;
	}

	public MvcHtmlString Script()
	{
		return MvcHtmlString.Create($"elma.qtip('{_selector}', '{((!string.IsNullOrEmpty(_header)) ? $"<b>{_header}</b><br/>{_text}" : _text)}');");
	}
}
