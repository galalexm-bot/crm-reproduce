using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.Calendar.API.Models;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.Calendar.API.Service.v1;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[WsdlDocumentation(typeof(__ICalendarServiceResources), "CalendarServiceDescription")]
[AuthorizeContractBehavior]
[FaultContractBehavior(typeof(PublicServiceException))]
public interface ICalendarService
{
	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/SetPackagesPeriod?months={months}")]
	[WsdlDocumentation(typeof(__ICalendarServiceResources), "SetPackagesPeriodDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__ICalendarServiceResources), "SetPackagesPeriodResultDescription")]
	bool SetPackagesPeriod([WsdlParamOrReturnDocumentation(typeof(__ICalendarServiceResources), "SetPackagesPeriodMonthsDescription")] int months);

	[OperationContract]
	[WebGet(UriTemplate = "/CalendarItems?startDate={startDate}&endDate={endDate}")]
	[WsdlDocumentation(typeof(__ICalendarServiceResources), "CalendarItemsDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__ICalendarServiceResources), "CalendarItemsResultDescription")]
	CalendarItemWCF[] CalendarItems([WsdlParamOrReturnDocumentation(typeof(__ICalendarServiceResources), "CalendarItemsStartDateDescription")] DateTime startDate, [WsdlParamOrReturnDocumentation(typeof(__ICalendarServiceResources), "CalendarItemsEndDateDescription")] DateTime endDate);

	[OperationContract]
	[WebGet(UriTemplate = "/GetProductionSchedule")]
	[WsdlDocumentation(typeof(__ICalendarServiceResources), "ProductionScheduleDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__ICalendarServiceResources), "ProductionScheduleResultDescription")]
	ProductionScheduleWCF GetProductionSchedule();

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/GetAvailableTimeSlots")]
	[WsdlDocumentation(typeof(__ICalendarServiceResources), "AvailableTimeSlotsDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__ICalendarServiceResources), "AvailableTimeSlotsResultDescription")]
	TimeSlot[] GetAvailableTimeSlots([WsdlParamOrReturnDocumentation(typeof(__ICalendarServiceResources), "AvailableTimeSlotsDataDescription")] TimeSlotsData data);
}
