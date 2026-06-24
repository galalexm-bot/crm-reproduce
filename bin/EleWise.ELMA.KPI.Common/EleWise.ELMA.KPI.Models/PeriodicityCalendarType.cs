using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.KPI.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("29cbb41a-cf89-43c7-8efb-86303092b36d")]
[DisplayName(typeof(__Resources_PeriodicityCalendarType), "DisplayName")]
[NamespaceForDisplay("EleWise.ELMA.Common.Models")]
public enum PeriodicityCalendarType
{
	[Uid("99ff9513-f243-4749-868b-b494f82294f7")]
	[DisplayName(typeof(__Resources_PeriodicityCalendarType), "P_AllDays_DisplayName")]
	AllDays,
	[Uid("eec254da-6ed5-410f-8d56-eb62aa393d1c")]
	[DisplayName(typeof(__Resources_PeriodicityCalendarType), "P_ProductionSchedule_DisplayName")]
	ProductionSchedule
}
