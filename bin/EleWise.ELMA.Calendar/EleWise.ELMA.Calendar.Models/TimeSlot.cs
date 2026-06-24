using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Calendar.Models;

[Serializable]
[DataContract]
public sealed class TimeSlot
{
	[DataMember]
	public DateTime StartDate { get; internal set; }

	[DataMember]
	public DateTime EndDate { get; internal set; }

	[Obsolete("Этот конструктор предназначен только для десериализации.", true)]
	public TimeSlot()
	{
	}

	public TimeSlot(DateTime startDate, DateTime endDate)
	{
		Contract.CheckArgument(startDate < endDate, "startDate < endDate");
		StartDate = startDate;
		EndDate = endDate;
	}

	public override bool Equals(object obj)
	{
		return obj is TimeSlot other && Equals(other);
	}

	private bool Equals(TimeSlot other)
	{
		return StartDate.Equals(other.StartDate) && EndDate.Equals(other.EndDate);
	}

	public override int GetHashCode()
	{
		return (StartDate.GetHashCode() * 397) ^ EndDate.GetHashCode();
	}
}
