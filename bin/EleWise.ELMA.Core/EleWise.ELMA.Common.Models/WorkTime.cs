using System;
using System.Runtime.InteropServices;
using System.Text;
using EleWise.ELMA.Core;

namespace EleWise.ELMA.Common.Models;

public struct WorkTime
{
	[StructLayout(3)]
	private struct _003C_003Ec__DisplayClass45_0
	{
		public StringBuilder text;
	}

	private long value;

	private bool _003CHasValue_003Ek__BackingField;

	public long Value
	{
		get
		{
			return value;
		}
		set
		{
			this.value = value;
			HasValue = true;
		}
	}

	public bool HasValue
	{
		get
		{
			return _003CHasValue_003Ek__BackingField;
		}
		set
		{
			_003CHasValue_003Ek__BackingField = value;
		}
	}

	public long MinutesInDay => 1440L;

	public long Days => Value / MinutesInDay;

	public long Hours => Value / 60;

	public long Minutes => Value % 60;

	public long TotalDays => (long)Math.Floor((double)Value / (double)MinutesInDay);

	public long TotalHours => (long)Math.Floor((double)Value / 60.0);

	public long TotalMinutes => Value;

	public WorkTime(int minutes)
	{
		value = minutes;
		HasValue = true;
	}

	public WorkTime(long minutes)
	{
		value = minutes;
		HasValue = true;
	}

	public WorkTime(long days, long hours, long minutes)
	{
		this = default(WorkTime);
		value = days * MinutesInDay + hours * 60 + minutes;
		HasValue = true;
	}

	public WorkTime(long hours, long minutes)
	{
		value = hours * 60 + minutes;
		HasValue = true;
	}

	public WorkTime(long? hours, long? minutes)
	{
		value = (hours ?? 0) * 60 + (minutes ?? 0);
		HasValue = true;
	}

	public WorkTime(int? minutes)
	{
		this = default(WorkTime);
		if (!minutes.get_HasValue())
		{
			value = 0L;
			return;
		}
		value = minutes.get_Value();
		HasValue = true;
	}

	public WorkTime(long? minutes)
	{
		this = default(WorkTime);
		if (!minutes.get_HasValue())
		{
			value = 0L;
			return;
		}
		value = minutes.get_Value();
		HasValue = true;
	}

	public override string ToString()
	{
		return FormatString(shortValue: true);
	}

	public override bool Equals(object obj)
	{
		if (!(obj is WorkTime workTime))
		{
			return false;
		}
		return workTime.TotalMinutes == TotalMinutes;
	}

	public override int GetHashCode()
	{
		return ((object)TotalMinutes).GetHashCode();
	}

	public string ToFormatString()
	{
		return FormatString();
	}

	public static implicit operator long(WorkTime m)
	{
		return m.Value;
	}

	public static implicit operator WorkTime(long l)
	{
		return new WorkTime(l);
	}

	public static WorkTime operator -(WorkTime left, WorkTime right)
	{
		return new WorkTime(left.TotalMinutes - right.TotalMinutes);
	}

	public static WorkTime operator +(WorkTime left, WorkTime right)
	{
		return new WorkTime(left.TotalMinutes + right.TotalMinutes);
	}

	public static bool operator >(WorkTime left, WorkTime right)
	{
		return left.TotalMinutes > right.TotalMinutes;
	}

	public static bool operator <(WorkTime left, WorkTime right)
	{
		return left.TotalMinutes < right.TotalMinutes;
	}

	public static bool operator ==(WorkTime left, WorkTime right)
	{
		return left.TotalMinutes == right.TotalMinutes;
	}

	public static bool operator !=(WorkTime left, WorkTime right)
	{
		return left.TotalMinutes != right.TotalMinutes;
	}

	public static bool operator >=(WorkTime left, WorkTime right)
	{
		return left.TotalMinutes >= right.TotalMinutes;
	}

	public static bool operator <=(WorkTime left, WorkTime right)
	{
		return left.TotalMinutes <= right.TotalMinutes;
	}

	public static WorkTime operator /(WorkTime left, WorkTime right)
	{
		return left.TotalMinutes / right.TotalMinutes;
	}

	public static WorkTime operator %(WorkTime left, WorkTime right)
	{
		return left.TotalMinutes % right.TotalMinutes;
	}

	private string FormatString(bool shortValue = false)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		_003C_003Ec__DisplayClass45_0 _003C_003Ec__DisplayClass45_ = default(_003C_003Ec__DisplayClass45_0);
		_003C_003Ec__DisplayClass45_.text = new StringBuilder();
		if (!HasValue || TotalMinutes == 0L)
		{
			return string.Format("0 {0}", (object)SR.T("мин"));
		}
		if (!shortValue)
		{
			_003CFormatString_003Eg__Append_007C45_0(Days, SR.T("дн."), ref _003C_003Ec__DisplayClass45_);
			_003CFormatString_003Eg__Append_007C45_0(Hours, SR.T("ч"), ref _003C_003Ec__DisplayClass45_);
		}
		else
		{
			_003CFormatString_003Eg__Append_007C45_0(TotalHours, SR.T("ч"), ref _003C_003Ec__DisplayClass45_);
		}
		_003CFormatString_003Eg__Append_007C45_0(Minutes, SR.T("мин"), ref _003C_003Ec__DisplayClass45_);
		return ((object)_003C_003Ec__DisplayClass45_.text).ToString();
	}

	internal static void _003CFormatString_003Eg__Append_007C45_0(long val, string postfix, ref _003C_003Ec__DisplayClass45_0 P_2)
	{
		if (val > 0)
		{
			if (P_2.text.get_Length() > 0)
			{
				P_2.text.Append(" ");
			}
			P_2.text.Append(val);
			if (!string.IsNullOrEmpty(postfix))
			{
				P_2.text.Append(" ");
				P_2.text.Append(postfix);
			}
		}
	}
}
