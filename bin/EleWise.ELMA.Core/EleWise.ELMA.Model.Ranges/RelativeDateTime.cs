using System;
using EleWise.ELMA.Core.Helpers;

namespace EleWise.ELMA.Model.Ranges;

public class RelativeDateTime
{
	private bool _003CIsRelative_003Ek__BackingField;

	private string _003CRelativeFrom_003Ek__BackingField;

	private string _003CRelativeTo_003Ek__BackingField;

	private DateTimeRange _003CDateTimeRange_003Ek__BackingField;

	public bool IsRelative
	{
		get
		{
			return _003CIsRelative_003Ek__BackingField;
		}
		set
		{
			_003CIsRelative_003Ek__BackingField = value;
		}
	}

	public string RelativeFrom
	{
		get
		{
			return _003CRelativeFrom_003Ek__BackingField;
		}
		set
		{
			_003CRelativeFrom_003Ek__BackingField = value;
		}
	}

	public string RelativeTo
	{
		get
		{
			return _003CRelativeTo_003Ek__BackingField;
		}
		set
		{
			_003CRelativeTo_003Ek__BackingField = value;
		}
	}

	public DateTimeRange DateTimeRange
	{
		get
		{
			return _003CDateTimeRange_003Ek__BackingField;
		}
		set
		{
			_003CDateTimeRange_003Ek__BackingField = value;
		}
	}

	public System.DateTime? FromValue
	{
		get
		{
			if (!IsRelative)
			{
				return DateTimeRange.From;
			}
			StringParseHelper.GetDateTimeFromString(RelativeFrom, isFrom: true, out var result, out var _);
			return result;
		}
	}

	public System.DateTime? ToValue
	{
		get
		{
			if (!IsRelative)
			{
				return DateTimeRange.To;
			}
			StringParseHelper.GetDateTimeFromString(RelativeTo, isFrom: false, out var result, out var _);
			return result;
		}
	}

	public RelativeDateTime()
	{
	}

	public RelativeDateTime(System.DateTime? from, System.DateTime? to)
	{
		IsRelative = false;
		RelativeFrom = null;
		RelativeTo = null;
		DateTimeRange = new DateTimeRange(from, to);
	}

	public RelativeDateTime(string from, string to)
	{
		IsRelative = true;
		RelativeFrom = from;
		RelativeTo = to;
	}

	public static explicit operator DateTimeRange(RelativeDateTime rdt)
	{
		if (!rdt.IsRelative)
		{
			return rdt.DateTimeRange;
		}
		return new DateTimeRange(rdt.FromValue, rdt.ToValue);
	}
}
