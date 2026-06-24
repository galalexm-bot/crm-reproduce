using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace EleWise.ELMA.KPI.Common.API.Models;

[Serializable]
[DataContract(Name = "Periodicity")]
[Description("Периодичность")]
public class PeriodicityWCF
{
	[DataMember]
	[Description("Идентификатор объекта")]
	public long Id { get; set; }

	[DataMember]
	[Description("Название")]
	public string Name { get; set; }

	[DataMember]
	[Description("Тип периодичности")]
	public PeriodicityTypeEnum Type { get; set; }

	[DataMember]
	[Description("Тип календаря для периодичности")]
	public PeriodicityCalendarTypeEnum CalendarType { get; set; }

	[DataMember]
	[Description("Тип группировки для периода")]
	public PeriodGroupingTypeEnum GroupingType { get; set; }

	[DataMember]
	[Description("Список периодов для пользовательской периодичности")]
	public PersistedCustomPeriodWCF[] Periods { get; set; }
}
