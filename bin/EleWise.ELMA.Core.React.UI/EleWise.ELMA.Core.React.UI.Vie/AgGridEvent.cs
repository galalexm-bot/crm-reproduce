using Bridge;

namespace EleWise.ELMA.Core.React.UI.Views;

[ObjectLiteral]
public class AgGridEvent : AgEvent
{
	private GridApi _003CApi_003Ek__BackingField;

	private ColumnApi _003CColumnApi_003Ek__BackingField;

	[Name("api")]
	public GridApi Api
	{
		get
		{
			return _003CApi_003Ek__BackingField;
		}
		set
		{
			_003CApi_003Ek__BackingField = value;
		}
	}

	[Name("columnApi")]
	public ColumnApi ColumnApi
	{
		get
		{
			return _003CColumnApi_003Ek__BackingField;
		}
		set
		{
			_003CColumnApi_003Ek__BackingField = value;
		}
	}
}
