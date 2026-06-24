using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.KPI.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("d4ca8236-5c72-40ba-a656-9ce63523a0d1")]
[DisplayName(typeof(__Resources_PeriodicityType), "DisplayName")]
[DefaultValueUid("9dde7d8f-aefa-4882-9974-80fb20e2e386")]
[NamespaceForDisplay("EleWise.ELMA.Common.Models")]
public enum PeriodicityType
{
	[Uid("0e1df4ad-eaf2-4c4a-a64c-ab12df539430")]
	[DisplayName(typeof(__Resources_PeriodicityType), "P_None_DisplayName")]
	None,
	[Uid("e67e41c8-08e2-4fce-ad3d-4dd71b87f8ba")]
	[DisplayName(typeof(__Resources_PeriodicityType), "P_Day_DisplayName")]
	Day,
	[Uid("c62ef847-9daa-43ac-9f97-19e914f1e2de")]
	[DisplayName(typeof(__Resources_PeriodicityType), "P_Week_DisplayName")]
	Week,
	[Uid("9dde7d8f-aefa-4882-9974-80fb20e2e386")]
	[DisplayName(typeof(__Resources_PeriodicityType), "P_Month_DisplayName")]
	Month,
	[Uid("5cdacff2-2cf8-436f-b7f6-ad200b15f4f8")]
	[DisplayName(typeof(__Resources_PeriodicityType), "P_Quarter_DisplayName")]
	Quarter,
	[Uid("28cab793-df14-4535-94c0-4ce5288e1b58")]
	[DisplayName(typeof(__Resources_PeriodicityType), "P_HalfYear_DisplayName")]
	HalfYear,
	[Uid("865de747-b245-4e78-a296-4291606fca98")]
	[DisplayName(typeof(__Resources_PeriodicityType), "P_Year_DisplayName")]
	Year,
	[Uid("2b7ffb6c-b551-4af9-84fc-5930689b3029")]
	[DisplayName(typeof(__Resources_PeriodicityType), "P_Custom_DisplayName")]
	[View(Visibility.Hidden)]
	Custom
}
