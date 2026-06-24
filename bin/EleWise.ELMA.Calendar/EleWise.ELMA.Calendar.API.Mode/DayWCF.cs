using System;
using System.Linq;
using System.Runtime.Serialization;
using EleWise.ELMA.Calendar.Models;

namespace EleWise.ELMA.Calendar.API.Models;

[Serializable]
[DataContract(Name = "Day")]
public class DayWCF
{
	[DataMember]
	public DayTypeEnum DayType { get; set; }

	[DataMember]
	public DateTime? Date { get; set; }

	[DataMember]
	public int? DayOfWeek { get; set; }

	[DataMember]
	public TimeSpan? WorkStart { get; set; }

	[DataMember]
	public TimeSpan? WorkEnd { get; set; }

	[DataMember]
	public TimeSpan? DinnerStart { get; set; }

	[DataMember]
	public TimeSpan? DinnerEnd { get; set; }

	[Obsolete("Этот конструктор предназначен только для десериализации", true)]
	public DayWCF()
	{
	}

	public DayWCF(WeekDay weekDay)
	{
		Date = null;
		DayOfWeek = (int)((weekDay.DayOfWeek == System.DayOfWeek.Sunday) ? ((DayOfWeek)7) : weekDay.DayOfWeek);
		DayType = (weekDay.IsHoliday ? DayTypeEnum.Holiday : DayTypeEnum.Short);
		if (!weekDay.IsHoliday)
		{
			bool flag = weekDay.WorkingTimeIntervals.Count() == 1;
			WorkStart = weekDay.WorkingTimeIntervals.First().Start;
			WorkEnd = weekDay.WorkingTimeIntervals.Last().End;
			DinnerStart = (flag ? weekDay.WorkingTimeIntervals.First().Start.Add(new TimeSpan(0, 0, 1)) : weekDay.WorkingTimeIntervals.First().End);
			DinnerEnd = (flag ? DinnerStart : new TimeSpan?(weekDay.WorkingTimeIntervals.Last().Start));
		}
	}

	public DayWCF(ExceptionalDay exceptionalDay)
	{
		DayOfWeek = null;
		Date = exceptionalDay.Date;
		DayType = (exceptionalDay.IsHoliday ? DayTypeEnum.Holiday : DayTypeEnum.Short);
		if (!exceptionalDay.IsHoliday)
		{
			bool flag = exceptionalDay.WorkingTimeIntervals.Count() == 1;
			WorkStart = exceptionalDay.WorkingTimeIntervals.First().Start;
			WorkEnd = exceptionalDay.WorkingTimeIntervals.Last().End;
			DinnerStart = (flag ? exceptionalDay.WorkingTimeIntervals.First().Start.Add(new TimeSpan(0, 0, 1)) : exceptionalDay.WorkingTimeIntervals.First().End);
			DinnerEnd = (flag ? DinnerStart : new TimeSpan?(exceptionalDay.WorkingTimeIntervals.Last().Start));
		}
	}
}
