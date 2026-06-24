using Bridge;

namespace EleWise.ELMA.Core.React.UI.Views;

[ObjectLiteral]
public sealed class ChangeWidthEvent
{
	private SizeColumn _003CSize_003Ek__BackingField;

	private string _003CColumnKey_003Ek__BackingField;

	[Name("size")]
	public SizeColumn Size
	{
		get
		{
			return _003CSize_003Ek__BackingField;
		}
		set
		{
			_003CSize_003Ek__BackingField = value;
		}
	}

	[Name("columnKey")]
	public string ColumnKey
	{
		get
		{
			return _003CColumnKey_003Ek__BackingField;
		}
		set
		{
			_003CColumnKey_003Ek__BackingField = value;
		}
	}
}
