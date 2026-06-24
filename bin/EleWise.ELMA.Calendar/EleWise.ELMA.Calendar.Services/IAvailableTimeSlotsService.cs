using System.Collections.Generic;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Calendar.Services;

[DeveloperApi(DeveloperApiType.Service)]
[PublicApiMember("AvailableTimeSlotsServicesApi", "SR.M('Сервис получения свободного времени пользователей')", "SR.M('\r\n    /// <code>\r\n    /// //С помощью данного сервиса мы можем получать свободное время пользователей\r\n    /// \r\n    /// //Загрузить пользователей, свободное время которых хотим получить\r\n    /// var users = PublicAPI.Portal.Security.User.FindByIdArray(new long[] { 1, 3 });\r\n    /// //Указать сроки, за которые хотим получить свободное время пользователей\r\n    /// var timeSlots = new[] { new TimeSlot(new DateTime(2019, 6, 19, 8, 0, 0), new DateTime(2019, 6, 19, 18, 0, 0)) };\r\n    /// //Получить свободное время пользователей\r\n    /// var availableTimeSlots = PublicAPI.Services.AvailableTimeSlotsService.GetIntervals(users, timeSlots);\r\n    /// \r\n    /// </code>')")]
public interface IAvailableTimeSlotsService
{
	[PublicApiNodeId("AvailableTimeSlotsServicesApi")]
	IList<TimeSlot> GetIntervals([NotNull] IEnumerable<IUser> users, [NotNull] IEnumerable<TimeSlot> timeSlots);

	[PublicApiNodeId("AvailableTimeSlotsServicesApi")]
	IList<TimeSlot> GetIntervals([NotNull] IEnumerable<IUser> users, [NotNull] IEnumerable<ICalendarItem> calendarItems, [NotNull] IEnumerable<TimeSlot> timeSlots);
}
