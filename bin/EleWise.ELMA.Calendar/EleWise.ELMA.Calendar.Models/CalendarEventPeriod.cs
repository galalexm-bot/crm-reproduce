using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Calendar.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("d65cf401-216e-4ed0-9050-ab0c3cc575f8")]
[DisplayName(typeof(__Resources_CalendarEventPeriod), "DisplayName")]
[Description(typeof(__Resources_CalendarEventPeriod), "Description")]
public enum CalendarEventPeriod
{
	[Uid("92de0898-137c-45e3-911f-cd569457a6cc")]
	[DisplayName(typeof(__Resources_CalendarEventPeriod), "P_Once_DisplayName")]
	[Description(typeof(__Resources_CalendarEventPeriod), "P_Once_Description")]
	Once = 0,
	[Uid("f0291d1e-b4ea-4b4f-9a22-af09cd207e98")]
	[DisplayName(typeof(__Resources_CalendarEventPeriod), "P_WorkingDays_DisplayName")]
	[Description(typeof(__Resources_CalendarEventPeriod), "P_WorkingDays_Description")]
	WorkingDays = 1,
	[Uid("45502ec6-39e9-474e-9087-6a18b160f112")]
	[DisplayName(typeof(__Resources_CalendarEventPeriod), "P_Daily_DisplayName")]
	[Description(typeof(__Resources_CalendarEventPeriod), "P_Daily_Description")]
	Daily = 2,
	[Uid("bd13f93f-e075-44d8-98ec-9a7ba26bef34")]
	[DisplayName(typeof(__Resources_CalendarEventPeriod), "P_Weekly_DisplayName")]
	[Description(typeof(__Resources_CalendarEventPeriod), "P_Weekly_Description")]
	Weekly = 3,
	[Uid("251f5758-02a8-45f0-8d13-ec1e6d0a7850")]
	[DisplayName(typeof(__Resources_CalendarEventPeriod), "P_Monthly_DisplayName")]
	[Description(typeof(__Resources_CalendarEventPeriod), "P_Monthly_Description")]
	Monthly = 4,
	[Uid("67905aa6-ea2a-4ca0-95aa-c3f5b24e222e")]
	[DisplayName(typeof(__Resources_CalendarEventPeriod), "P_Quarterly_DisplayName")]
	Quarterly = 6,
	[Uid("fc2e9cf2-51ef-427b-ab6a-4d5d4606cace")]
	[DisplayName(typeof(__Resources_CalendarEventPeriod), "P_Yearly_DisplayName")]
	[Description(typeof(__Resources_CalendarEventPeriod), "P_Yearly_Description")]
	Yearly = 5
}
