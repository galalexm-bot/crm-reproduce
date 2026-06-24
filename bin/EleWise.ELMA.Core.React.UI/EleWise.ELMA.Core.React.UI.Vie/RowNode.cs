using Bridge;

namespace EleWise.ELMA.Core.React.UI.Views;

public sealed class RowNode
{
	private object _003CKey_003Ek__BackingField;

	private bool _003CSelected_003Ek__BackingField;

	[Name("key")]
	public object Key
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

	[Name("selected")]
	public bool Selected
	{
		get
		{
			return _003CSelected_003Ek__BackingField;
		}
		set
		{
			_003CSelected_003Ek__BackingField = value;
		}
	}
}
