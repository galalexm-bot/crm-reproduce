using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Workflow.Models;

public enum EventCycleInterval
{
	[DisplayName(typeof(__Resources_EventCycleInterval), "P_Month_DisplayName")]
	Month,
	[DisplayName(typeof(__Resources_EventCycleInterval), "P_Week_DisplayName")]
	Week,
	[DisplayName(typeof(__Resources_EventCycleInterval), "P_Day_DisplayName")]
	Day
}
