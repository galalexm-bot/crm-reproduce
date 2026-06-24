using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Security.Models;

[MetadataType(typeof(EnumMetadata))]
[DisplayName(typeof(__Resources_EmployeesEmployDateOutputMode), "DisplayName")]
[Uid("a35a7445-09be-445b-9c81-341960221f82")]
public enum EmployeesEmployDateOutputMode
{
	[Uid("125c5f35-01a6-4c33-8406-6134d15b35d0")]
	[DisplayName(typeof(__Resources_EmployeesEmployDateOutputMode), "P_DayBehind_DisplayName")]
	DayBehind,
	[Uid("f070f1b7-3faf-4928-a808-058a92fb2542")]
	[DisplayName(typeof(__Resources_EmployeesEmployDateOutputMode), "P_WeekBehind_DisplayName")]
	WeekBehind,
	[Uid("8ec7398e-fa46-4237-939e-5586cf860784")]
	[DisplayName(typeof(__Resources_EmployeesEmployDateOutputMode), "P_MonthBehind_DisplayName")]
	MonthBehind,
	[DisplayName(typeof(__Resources_EmployeesEmployDateOutputMode), "P_AfterTheYear_DisplayName")]
	[Uid("c2bcf8a1-c36c-4122-878b-fc3dc57aa986")]
	AfterTheYear
}
