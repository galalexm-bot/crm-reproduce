using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Security.Models;

[Uid("23e063d0-b8a9-4332-930b-24c759246c78")]
[MetadataType(typeof(EnumMetadata))]
[DisplayName(typeof(__Resources_EmployeesBirthdaysOutputMode), "DisplayName")]
public enum EmployeesBirthdaysOutputMode
{
	[DisplayName(typeof(__Resources_EmployeesBirthdaysOutputMode), "P_Today_DisplayName")]
	[Uid("cc488948-e7f3-4e73-8264-01548e4327a9")]
	Today,
	[Uid("6f526827-e204-4f8e-863e-a7732ec6da48")]
	[DisplayName(typeof(__Resources_EmployeesBirthdaysOutputMode), "P_WeekAhead_DisplayName")]
	WeekAhead,
	[DisplayName(typeof(__Resources_EmployeesBirthdaysOutputMode), "P_MonthAhead_DisplayName")]
	[Uid("64c7288d-4fdf-4650-84ee-e8e28af86e12")]
	MonthAhead,
	[DisplayName(typeof(__Resources_EmployeesBirthdaysOutputMode), "P_BeforeTheYear_DisplayName")]
	[Uid("06733079-20c8-4680-abf4-48281a95ea47")]
	BeforeTheYear
}
