using System;

namespace EleWise.ELMA.Model.Ranges;

public struct DateTimeRange : IRange<System.DateTime>
{
	private System.DateTime? _003CFrom_003Ek__BackingField;

	private System.DateTime? _003CTo_003Ek__BackingField;

	public System.DateTime? From
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

	public System.DateTime? To
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

	public DateTimeRange(System.DateTime? from, System.DateTime? to)
	{
		From = from;
		To = to;
	}
}
