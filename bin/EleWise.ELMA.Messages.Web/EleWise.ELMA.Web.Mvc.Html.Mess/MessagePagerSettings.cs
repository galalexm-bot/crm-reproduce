using EleWise.ELMA.Messages.Models;

namespace EleWise.ELMA.Web.Mvc.Html.MessageCustomPager;

public class MessagePagerSettings
{
	private int page = 1;

	private int pageSize = 15;

	public long SourceId { get; set; }

	public int Page
	{
		get
		{
			return page;
		}
		set
		{
			page = value;
		}
	}

	public int PageSize
	{
		get
		{
			return pageSize;
		}
		set
		{
			pageSize = value;
		}
	}

	public string Key { get; set; }

	public IBaseMessageFilter Filter { get; set; }
}
