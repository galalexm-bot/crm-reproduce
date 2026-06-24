using Bridge;

namespace EleWise.ELMA.Core.React.UI.Views;

[ObjectLiteral]
public sealed class TableGroupChangeEvent
{
	private TableGroupType _003CType_003Ek__BackingField;

	private TableColumn.Props[] _003CItems_003Ek__BackingField;

	private string _003CKey_003Ek__BackingField;

	private int _003CIndex_003Ek__BackingField;

	[Name("type")]
	public TableGroupType Type
	{
		get
		{
			return _003CType_003Ek__BackingField;
		}
		set
		{
			_003CType_003Ek__BackingField = value;
		}
	}

	[Name("items")]
	public TableColumn.Props[] Items
	{
		get
		{
			return _003CItems_003Ek__BackingField;
		}
		set
		{
			_003CItems_003Ek__BackingField = value;
		}
	}

	[Name("key")]
	public string Key
	{
		get
		{
			return _003CKey_003Ek__BackingField;
		}
		set
		{
			_003CKey_003Ek__BackingField = value;
		}
	}

	[Name("index")]
	public int Index
	{
		get
		{
			return _003CIndex_003Ek__BackingField;
		}
		set
		{
			_003CIndex_003Ek__BackingField = value;
		}
	}
}
