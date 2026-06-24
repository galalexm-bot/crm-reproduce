using EleWise.ELMA.Extensions;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class SelectableGridModel
{
	private string gridId;

	public bool CustomCountInfo { get; internal set; }

	public string GridId
	{
		get
		{
			return gridId;
		}
		set
		{
			gridId = value.HtmlEncode();
		}
	}

	public bool MultiSelect { get; set; }

	public string ElementsId { get; set; }
}
