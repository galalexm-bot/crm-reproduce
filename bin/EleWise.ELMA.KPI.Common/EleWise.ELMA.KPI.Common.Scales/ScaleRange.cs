using System;

namespace EleWise.ELMA.KPI.Common.Scales;

[Serializable]
public class ScaleRange
{
	public double Start { get; private set; }

	public double End { get; private set; }

	public ScaleStatus Status { get; private set; }

	public ScaleRange(double start, double end, ScaleStatus status)
	{
		Start = start;
		End = end;
		Status = status;
	}

	public double Length()
	{
		return End - Start;
	}

	public bool Contains(double value)
	{
		if (Start <= value)
		{
			return value <= End;
		}
		return false;
	}

	public bool Contains(double? value)
	{
		if (!value.HasValue)
		{
			return false;
		}
		return Contains(value.Value);
	}

	public bool Equals(ScaleRange other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		if (other.End.Equals(End) && other.Start.Equals(Start))
		{
			return object.Equals(other.Status, Status);
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (this == obj)
		{
			return true;
		}
		if (obj.GetType() != typeof(ScaleRange))
		{
			return false;
		}
		return Equals((ScaleRange)obj);
	}

	public override int GetHashCode()
	{
		return (((End.GetHashCode() * 397) ^ Start.GetHashCode()) * 397) ^ ((Status != null) ? Status.GetHashCode() : 0);
	}

	public override string ToString()
	{
		return $"Start: {Start}, End: {End}, Status: {Status}";
	}
}
