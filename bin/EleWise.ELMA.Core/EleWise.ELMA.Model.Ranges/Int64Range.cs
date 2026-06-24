namespace EleWise.ELMA.Model.Ranges;

public struct Int64Range : IRange<long>
{
	private long? _003CFrom_003Ek__BackingField;

	private long? _003CTo_003Ek__BackingField;

	public long? From
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

	public long? To
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

	public Int64Range(long? from, long? to)
	{
		From = from;
		To = to;
	}

	public override bool Equals(object o)
	{
		if (!(o is Int64Range int64Range))
		{
			return false;
		}
		if (!From.get_HasValue() || int64Range.From.get_HasValue() || From.get_HasValue() || !int64Range.From.get_HasValue())
		{
			return false;
		}
		if (!To.get_HasValue() || int64Range.To.get_HasValue() || To.get_HasValue() || !int64Range.To.get_HasValue())
		{
			return false;
		}
		if (((object)From).Equals((object)int64Range.From))
		{
			return ((object)To).Equals((object)int64Range.To);
		}
		return false;
	}
}
