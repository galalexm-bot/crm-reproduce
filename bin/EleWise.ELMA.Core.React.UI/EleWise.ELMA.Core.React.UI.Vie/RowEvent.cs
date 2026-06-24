using Bridge;

namespace EleWise.ELMA.Core.React.UI.Views;

[ObjectLiteral]
public class RowEvent : AgGridEvent
{
	private RowNode _003CNode_003Ek__BackingField;

	private object _003CData_003Ek__BackingField;

	private int _003CRowIndex_003Ek__BackingField;

	[Name("node")]
	public RowNode Node
	{
		get
		{
			return _003CNode_003Ek__BackingField;
		}
		set
		{
			_003CNode_003Ek__BackingField = value;
		}
	}

	[Name("data")]
	public object Data
	{
		get
		{
			return _003CData_003Ek__BackingField;
		}
		set
		{
			_003CData_003Ek__BackingField = value;
		}
	}

	[Name("rowIndex")]
	public int RowIndex
	{
		get
		{
			return _003CRowIndex_003Ek__BackingField;
		}
		set
		{
			_003CRowIndex_003Ek__BackingField = value;
		}
	}
}
