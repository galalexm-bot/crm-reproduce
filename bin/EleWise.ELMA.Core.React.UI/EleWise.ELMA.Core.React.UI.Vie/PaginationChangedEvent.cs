using Bridge;

namespace EleWise.ELMA.Core.React.UI.Views;

[ObjectLiteral]
public class PaginationChangedEvent
{
	private int _003CPageSize_003Ek__BackingField;

	private int _003CCurrentPage_003Ek__BackingField;

	[Name("pageSize")]
	public int PageSize
	{
		get
		{
			return _003CPageSize_003Ek__BackingField;
		}
		set
		{
			_003CPageSize_003Ek__BackingField = value;
		}
	}

	[Name("currentPage")]
	public int CurrentPage
	{
		get
		{
			return _003CCurrentPage_003Ek__BackingField;
		}
		set
		{
			_003CCurrentPage_003Ek__BackingField = value;
		}
	}
}
