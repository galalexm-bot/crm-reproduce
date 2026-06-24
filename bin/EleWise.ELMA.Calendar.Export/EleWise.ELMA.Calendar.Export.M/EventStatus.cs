using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Calendar.Export.Models;

public enum EventStatus
{
	[DisplayName(typeof(__Resources_EventStatus), "P_Undefined_DisplayName")]
	Undefined,
	[DisplayName(typeof(__Resources_EventStatus), "P_Tentative_DisplayName")]
	Tentative,
	[DisplayName(typeof(__Resources_EventStatus), "P_Confirmed_DisplayName")]
	Confirmed,
	[DisplayName(typeof(__Resources_EventStatus), "P_Cancelled_DisplayName")]
	Cancelled
}
