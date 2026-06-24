using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Calendar.Export.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("4887c814-b045-47d3-b542-d73d988ddf40")]
[DisplayName(typeof(__Resources_InternetCalendarPeriod), "DisplayName")]
[Description(typeof(__Resources_InternetCalendarPeriod), "Description")]
public enum InternetCalendarPeriod
{
	[Uid("3723d38d-1db0-431f-b043-a0abad74b357")]
	[DisplayName(typeof(__Resources_InternetCalendarPeriod), "P_Day_DisplayName")]
	[Description(typeof(__Resources_InternetCalendarPeriod), "P_Day_Description")]
	Day,
	[Uid("33486398-56d1-435d-92f0-7327db442dd6")]
	[DisplayName(typeof(__Resources_InternetCalendarPeriod), "P_Week_DisplayName")]
	[Description(typeof(__Resources_InternetCalendarPeriod), "P_Week_Description")]
	Week,
	[Uid("6a74fc73-8f82-4cb8-a49f-4dcac2b29879")]
	[DisplayName(typeof(__Resources_InternetCalendarPeriod), "P_Month_DisplayName")]
	[Description(typeof(__Resources_InternetCalendarPeriod), "P_Month_Description")]
	Month,
	[Uid("88edfa9f-56a3-4453-81d5-249595554860")]
	[DisplayName(typeof(__Resources_InternetCalendarPeriod), "P_ThreeMonths_DisplayName")]
	[Description(typeof(__Resources_InternetCalendarPeriod), "P_ThreeMonths_Description")]
	ThreeMonths,
	[Uid("962d641a-0d7a-4485-b172-8970c0c5f70d")]
	[DisplayName(typeof(__Resources_InternetCalendarPeriod), "P_CurrentList_DisplayName")]
	CurrentList
}
