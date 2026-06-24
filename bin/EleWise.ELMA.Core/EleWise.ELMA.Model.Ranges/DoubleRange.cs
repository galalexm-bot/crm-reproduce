namespace EleWise.ELMA.Model.Ranges;

public struct DoubleRange : IRange<double>
{
	private double? _003CFrom_003Ek__BackingField;

	private double? _003CTo_003Ek__BackingField;

	public double? From
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

	public double? To
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

	public DoubleRange(double? from, double? to)
	{
		From = from;
		To = to;
	}
}
