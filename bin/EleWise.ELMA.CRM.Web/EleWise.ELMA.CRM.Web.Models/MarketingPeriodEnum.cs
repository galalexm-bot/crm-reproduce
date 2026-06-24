using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.CRM.Web.Models;

public enum MarketingPeriodEnum
{
	[DisplayName(typeof(__Resources_MarketingPeriodEnum), "P_Month_DisplayName")]
	Month = 2,
	[DisplayName(typeof(__Resources_MarketingPeriodEnum), "P_Week_DisplayName")]
	Week = 1,
	[DisplayName(typeof(__Resources_MarketingPeriodEnum), "P_Day_DisplayName")]
	Day = 0
}
