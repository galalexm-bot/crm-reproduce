using System;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.KPI.Models;

[Serializable]
public class TimePeriod
{
	public Guid PeriodictyId { get; private set; }

	public Pair<DateTime, DateTime> Range { get; private set; }

	public string Name { get; private set; }

	public string ShortName { get; private set; }

	public TimePeriod(Pair<DateTime, DateTime> range, string name, string shortName, Guid periodictyId)
	{
		Range = range;
		Name = name;
		ShortName = shortName;
		PeriodictyId = periodictyId;
	}

	public bool Equals(TimePeriod other)
	{
		if (PeriodictyId.Equals(other.PeriodictyId) && Name.Equals(other.Name) && ShortName.Equals(other.ShortName))
		{
			return Range.Equals(other.Range);
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
		if (obj.GetType() != typeof(TimePeriod))
		{
			return false;
		}
		return Equals((TimePeriod)obj);
	}

	public override int GetHashCode()
	{
		return (((((((PeriodictyId.GetHashCode() * 397) ^ ((Name != null) ? Name.GetHashCode() : 0)) * 397) ^ ((Name != null) ? Name.GetHashCode() : 0)) * 397) ^ ((ShortName != null) ? ShortName.GetHashCode() : 0)) * 397) ^ ((Range != null) ? Range.GetHashCode() : 0);
	}

	public override string ToString()
	{
		return Range.ToString();
	}
}
