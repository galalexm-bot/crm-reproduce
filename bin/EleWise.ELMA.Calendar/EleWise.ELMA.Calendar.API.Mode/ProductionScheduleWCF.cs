using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Projects.Models.Resources;

namespace EleWise.ELMA.Calendar.API.Models;

[Serializable]
[DataContract(Name = "ProductionSchedule")]
public class ProductionScheduleWCF
{
	[DataMember]
	public long Id { get; set; }

	[DataMember]
	public TimeSpan WorkStart { get; set; }

	[DataMember]
	public TimeSpan WorkEnd { get; set; }

	[DataMember]
	public TimeSpan DinnerStart { get; set; }

	[DataMember]
	public TimeSpan DinnerEnd { get; set; }

	[DataMember]
	public DayWCF[] Days { get; set; }

	[DataMember]
	public DayWCF[] ExceptionDays { get; set; }

	[Obsolete("Этот конструктор предназначен только для десериализации.", true)]
	public ProductionScheduleWCF()
	{
	}

	public ProductionScheduleWCF(IResourceCalendar productionSchedule)
	{
		Id = productionSchedule.Id;
		ProductionScheduleData productionScheduleData = ProductionScheduleDataFactory.CreateByEntity(productionSchedule);
		WorkStart = productionScheduleData.BaseIntervals.First().Start;
		WorkEnd = productionScheduleData.BaseIntervals.Last().End;
		bool flag = ((IEnumerable<IBaseTimeInterval>)productionSchedule.BaseIntervals).Count() == 1;
		DinnerStart = (flag ? productionScheduleData.BaseIntervals.First().Start.Add(new TimeSpan(0, 0, 1)) : productionScheduleData.BaseIntervals.First().End);
		DinnerEnd = (flag ? DinnerStart : productionScheduleData.BaseIntervals.Last().Start);
		Days = productionScheduleData.WeekDays.Select((WeekDay wd) => new DayWCF(wd)).ToArray();
		ExceptionDays = productionScheduleData.ExceptionalDays.Select((ExceptionalDay ed) => new DayWCF(ed)).ToArray();
	}
}
