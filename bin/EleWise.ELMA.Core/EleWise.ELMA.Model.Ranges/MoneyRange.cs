using EleWise.ELMA.Common.Models;

namespace EleWise.ELMA.Model.Ranges;

public struct MoneyRange : IRange<Money>
{
	private Money _003CFrom_003Ek__BackingField;

	private Money _003CTo_003Ek__BackingField;

	public Money From
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

	public Money To
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

	Money? IRange<Money>.From
	{
		get
		{
			if (!From.HasValue)
			{
				return null;
			}
			return From;
		}
		set
		{
			From = value ?? new Money
			{
				HasValue = false
			};
		}
	}

	Money? IRange<Money>.To
	{
		get
		{
			if (!To.HasValue)
			{
				return null;
			}
			return To;
		}
		set
		{
			To = value ?? new Money
			{
				HasValue = false
			};
		}
	}

	public MoneyRange(Money? from, Money? to)
	{
		this = default(MoneyRange);
		if (from.get_HasValue())
		{
			From = from.get_Value();
		}
		if (to.get_HasValue())
		{
			To = to.get_Value();
		}
	}
}
