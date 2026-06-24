namespace EleWise.ELMA.Model.Ranges;

public struct Int16Range : IRange<short>
{
	private short? _003CFrom_003Ek__BackingField;

	private short? _003CTo_003Ek__BackingField;

	public short? From
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

	public short? To
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

	public Int16Range(short? from, short? to)
	{
		From = from;
		To = to;
	}
}
