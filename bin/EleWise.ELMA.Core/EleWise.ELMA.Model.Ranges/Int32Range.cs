namespace EleWise.ELMA.Model.Ranges;

public struct Int32Range : IRange<int>
{
	private int? _003CFrom_003Ek__BackingField;

	private int? _003CTo_003Ek__BackingField;

	public int? From
	{
		get
		{
			return _003CFrom_003Ek__BackingField;
		}
		set
		{
			_003CFrom_003Ek__BackingField = value;
		}
	}

	public int? To
	{
		get
		{
			return _003CTo_003Ek__BackingField;
		}
		set
		{
			_003CTo_003Ek__BackingField = value;
		}
	}

	public Int32Range(int? from, int? to)
	{
		From = from;
		To = to;
	}
}
